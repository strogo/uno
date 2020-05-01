﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Globalization;
using System.Xml;
using Uno.Roslyn;
using Microsoft.CodeAnalysis;
using Uno.Extensions;
using Microsoft.Build.Execution;
using Uno.Logging;
using Uno.UI.SourceGenerators.Telemetry;

namespace Uno.UI.SourceGenerators.XamlGenerator
{
	internal partial class XamlCodeGeneration
	{
		private string[] _xamlSourceFiles;
		private string[] _xamlSourceLinks;
		private string _targetPath;
		private readonly string _defaultLanguage;
		private bool _isWasm;
		private string _defaultNamespace;
		private string[] _assemblySearchPaths;
		private RoslynMetadataHelper _metadataHelper;
		private string[] _excludeXamlNamespaces;
		private string[] _includeXamlNamespaces;
		private string[] _analyzerSuppressions;
		private string[] _resourceFiles;
		private Dictionary<string, string[]> _uiAutomationMappings;
		private readonly ProjectInstance _projectInstance;
		private readonly string _configuration;
		private readonly bool _isDebug;
		private readonly bool _outputSourceComments = true;

		/// <summary>
		/// If set, code generated from XAML will be annotated with the source method and line # in this file, for easier debugging.
		/// </summary>
		private readonly bool _shouldAnnotateGeneratedXaml = false;

		private static DateTime _buildTasksBuildDate = File.GetLastWriteTime(new Uri(typeof(XamlFileGenerator).Assembly.CodeBase).LocalPath);
		private INamedTypeSymbol[] _ambientGlobalResources;
		private readonly bool _isUiAutomationMappingEnabled;
		private Dictionary<string, string> _legacyTypes;

		// Determines if the source generator will skip the inclusion of UseControls in the
		// visual tree. See https://github.com/unoplatform/uno/issues/61
		private bool _skipUserControlsInVisualTree = true;

		private bool IsUnoAssembly => _defaultNamespace == "Uno.UI";

		/// <summary>
		/// Resource files that should be initialized first, in given order, because other resource declarations depend on them.
		/// </summary>
		private static readonly string[] _baseResourceDependencies = new[]
		{
			"SystemResources.xaml",
			"Generic.xaml",
			"Generic.Native.xaml",
		};

#pragma warning disable 649 // Unused member
		private readonly bool _forceGeneration;
#pragma warning restore 649 // Unused member

		public XamlCodeGeneration(Compilation sourceCompilation, ProjectInstance msbProject, Project roslynProject)
		{
			// To easily debug XAML code generation:
			// 1. Uncomment the line below
			// 2. Build Uno.UI.SourceGenerators and override local files (following instructions here: doc/articles/uno-development/debugging-uno-ui.md#debugging-unoui)
			// 3. Build project containing your XAML. When prompted to attach a Visual Studio instance:
			//		- if it's in an external solution, attach the VS instance running Uno.UI
			//		- if you're debugging XAML generation inside the Uno solution, opt to create a new VS instance
			//
			//Debugger.Launch();

			InitTelemetry(msbProject);

			_legacyTypes = msbProject
				.GetItems("LegacyTypes")
				.Select(i => i.EvaluatedInclude)
				.ToList()
				.ToDictionary(fullyQualifiedName => fullyQualifiedName.Split('.').Last());

			_metadataHelper = new RoslynMetadataHelper("Debug", sourceCompilation, msbProject, roslynProject, null, _legacyTypes);
			_assemblySearchPaths = new string[0];
			_projectInstance = msbProject;

			_configuration = msbProject.GetProperty("Configuration")?.EvaluatedValue
				?? throw new InvalidOperationException("The configuration property must be provided");

			_isDebug = string.Equals(_configuration, "Debug", StringComparison.OrdinalIgnoreCase);

			var xamlItems = msbProject.GetItems("Page")
				.Concat(msbProject.GetItems("ApplicationDefinition"));

			_xamlSourceFiles = xamlItems.Select(d => d.EvaluatedInclude)
				.ToArray();

			_xamlSourceLinks = xamlItems.Select(GetSourceLink)
				.ToArray();

			_excludeXamlNamespaces = msbProject
				.GetItems("ExcludeXamlNamespaces")
				.Select(i => i.EvaluatedInclude)
				.ToArray();

			_includeXamlNamespaces = msbProject
				.GetItems("IncludeXamlNamespaces")
				.Select(i => i.EvaluatedInclude)
				.ToArray();

			_analyzerSuppressions = msbProject
				.GetItems("XamlGeneratorAnalyzerSuppressions")
				.Select(i => i.EvaluatedInclude)
				.ToArray();

			_resourceFiles = msbProject
				.GetItems("PRIResource")
				.Select(i => i.EvaluatedInclude)
				.ToArray();

			if (bool.TryParse(msbProject.GetProperty("UseUnoXamlParser")?.EvaluatedValue, out var useUnoXamlParser) && useUnoXamlParser)
			{
				XamlRedirection.XamlConfig.IsUnoXaml = useUnoXamlParser || XamlRedirection.XamlConfig.IsMono;
			}

			if (bool.TryParse(msbProject.GetProperty("UnoSkipUserControlsInVisualTree")?.EvaluatedValue, out var skipUserControlsInVisualTree))
			{
				_skipUserControlsInVisualTree = skipUserControlsInVisualTree;
			}

			if (bool.TryParse(msbProject.GetProperty("ShouldWriteErrorOnInvalidXaml")?.EvaluatedValue, out var shouldWriteErrorOnInvalidXaml))
			{
				XamlFileGenerator.ShouldWriteErrorOnInvalidXaml = shouldWriteErrorOnInvalidXaml;
			}

			if (!bool.TryParse(msbProject.GetProperty("IsUiAutomationMappingEnabled")?.EvaluatedValue ?? "", out _isUiAutomationMappingEnabled))
			{
				_isUiAutomationMappingEnabled = false;
			}

			if (bool.TryParse(msbProject.GetProperty("ShouldAnnotateGeneratedXaml")?.EvaluatedValue, out var shouldAnnotateGeneratedXaml))
			{
				_shouldAnnotateGeneratedXaml = shouldAnnotateGeneratedXaml;
			}

			_targetPath = Path.Combine(
				Path.GetDirectoryName(msbProject.FullPath),
				msbProject.GetProperty("IntermediateOutputPath").EvaluatedValue
			);

			_defaultLanguage = msbProject.GetProperty("DefaultLanguage")?.EvaluatedValue;

			_analyzerSuppressions = msbProject
				.GetItems("XamlGeneratorAnalyzerSuppressions")
				.Select(i => i.EvaluatedInclude)
				.ToArray();

			_uiAutomationMappings = msbProject
				.GetItems("CustomUiAutomationMemberMapping")
				.Select(i => new
				{
					Key = i.EvaluatedInclude,
					Value = i.MetadataNames
						.Select(i.GetMetadataValue)
						.FirstOrDefault()
						?.Split()
						.Select(m => m.Trim())
						.Where(m => m.HasValueTrimmed())
				})
				.GroupBy(p => p.Key)
				.ToDictionary(p => p.Key, p => p.SelectMany(x => x.Value.Safe()).ToArray());

			_defaultNamespace = msbProject.GetPropertyValue("RootNamespace");

			_isWasm = msbProject.GetProperty("DefineConstants").EvaluatedValue?.Contains("__WASM__") ?? false;
		}

		/// <summary>
		/// Get the file location as seen in the IDE, used for ResourceDictionary.Source resolution.
		/// </summary>
		private string GetSourceLink(ProjectItemInstance projectItemInstance)
		{
			if (projectItemInstance.HasMetadata("Link"))
			{
				return projectItemInstance.GetMetadataValue("Link");
			}

			return projectItemInstance.EvaluatedInclude;
		}

		public KeyValuePair<string, string>[] Generate()
		{
			var stopwatch = Stopwatch.StartNew();

			try
			{
				this.Log().InfoFormat("Xaml Source Generation is using the {0} Xaml Parser", XamlRedirection.XamlConfig.IsUnoXaml ? "Uno.UI" : "System");

				var lastBinaryUpdateTime = _forceGeneration ? DateTime.MaxValue : GetLastBinaryUpdateTime();

				var resourceKeys = GetResourceKeys();
				var filesFull = new XamlFileParser(_excludeXamlNamespaces, _includeXamlNamespaces).ParseFiles(_xamlSourceFiles);
				var files = filesFull.Trim()
				.OrderBy(f => f.UniqueID)
				.ToArray();

				for (int i = 0; i < files.Length; i++)
				{
					files[i].ShortId = i;
				}

				TrackStartGeneration(files);

				var globalStaticResourcesMap = BuildAssemblyGlobalStaticResourcesMap(files, filesFull, _xamlSourceLinks);

				var filesQuery = files
					.ToArray();

				var outputFiles = filesQuery
#if !DEBUG
				.AsParallel()
#endif
				.Select(file => new KeyValuePair<string, string>(
						file.UniqueID,
						new XamlFileGenerator(
							file: file,
							targetPath: _targetPath,
							defaultNamespace: _defaultNamespace,
							metadataHelper: _metadataHelper,
							fileUniqueId: file.UniqueID,
							lastReferenceUpdateTime: lastBinaryUpdateTime,
							analyzerSuppressions: _analyzerSuppressions,
							globalStaticResourcesMap: globalStaticResourcesMap,
							outputSourceComments: _outputSourceComments,
							resourceKeys: resourceKeys,
							isUiAutomationMappingEnabled: _isUiAutomationMappingEnabled,
							uiAutomationMappings: _uiAutomationMappings,
							defaultLanguage: _defaultLanguage,
							isWasm: _isWasm,
							isDebug: _isDebug,
							skipUserControlsInVisualTree: _skipUserControlsInVisualTree,
							shouldAnnotateGeneratedXaml: _shouldAnnotateGeneratedXaml
						)
						.GenerateFile()
					)
					)
					.ToList();


				outputFiles.Add(new KeyValuePair<string, string>("GlobalStaticResources", GenerateGlobalResources(files, globalStaticResourcesMap)));

				TrackGenerationDone(stopwatch.Elapsed);

				return outputFiles.ToArray();
			}
			catch (Exception e)
			{
				TrackGenerationFailed(e, stopwatch.Elapsed);

				throw;
			}
			finally
			{
				_telemetry.Flush();
			}
		}

		private XamlGlobalStaticResourcesMap BuildAssemblyGlobalStaticResourcesMap(XamlFileDefinition[] files, XamlFileDefinition[] filesFull, string[] links)
		{
			var map = new XamlGlobalStaticResourcesMap();

			BuildLocalProjectResources(files, map);
			BuildAmbientResources(files, map);
			map.BuildResourceDictionaryMap(filesFull, links);

			return map;
		}

		private void BuildAmbientResources(XamlFileDefinition[] files, XamlGlobalStaticResourcesMap map)
		{
			// Lookup for GlobalStaticResources classes in external assembly
			// references only, and in Uno.UI itself for generic.xaml-like resources.

			var query = from ext in _metadataHelper.Compilation.ExternalReferences
						let sym = _metadataHelper.Compilation.GetAssemblyOrModuleSymbol(ext) as IAssemblySymbol
						where sym != null
						from module in sym.Modules
						from reference in module.ReferencedAssemblies
						where reference.Name == "Uno.UI" || sym.Name == "Uno.UI"
						from typeName in sym.GlobalNamespace.GetNamespaceTypes()
						where typeName.Name.EndsWith("GlobalStaticResources")
						select typeName;

			_ambientGlobalResources = query.Distinct().ToArray();

			foreach (var ambientResources in _ambientGlobalResources)
			{
				var publicProperties = from member in ambientResources.GetAllProperties()
									   where member.DeclaredAccessibility == Microsoft.CodeAnalysis.Accessibility.Public
									   select member;


				foreach (var member in publicProperties)
				{
					map.Add(member.Name, ambientResources.ContainingNamespace.ToDisplayString(), XamlGlobalStaticResourcesMap.ResourcePrecedence.System);
				}
			}
		}

		private void BuildLocalProjectResources(XamlFileDefinition[] files, XamlGlobalStaticResourcesMap map)
		{
			foreach (var file in files)
			{
				var topLevelControl = file.Objects.FirstOrDefault();

				if (topLevelControl?.Type.Name == "ResourceDictionary")
				{
					BuildResourceMap(topLevelControl, map);

					var themeDictionaries = topLevelControl.Members.FirstOrDefault(m => m.Member.Name == "ThemeDictionaries");

					if (themeDictionaries != null)
					{
						// We extract all distinct keys of all themed resource dictionaries defined and add them to global map

						IEnumerable<string> GetResources(XamlObjectDefinition themeDictionary)
						{
							if (!(themeDictionary.Members
								.FirstOrDefault(x => x.Member.Name.Equals("Key"))
								?.Value is string))
							{
								yield break;
							}

							var resources = themeDictionary.Members
								.FirstOrDefault(x => x.Member.Name.Equals("_UnknownContent"))
								?.Objects;

							if (resources != null)
							{
								foreach (var resource in resources)
								{
									if (resource.Members.FirstOrDefault(x => x.Member.Name.Equals("Key"))
										?.Value is string resourceKey)
									{
										yield return resourceKey;
									}
								}
							}
						}

						var themeResources = themeDictionaries
							.Objects
							.SelectMany(GetResources)
							.Distinct();

						foreach (var themeResource in themeResources)
						{
							map.Add(themeResource, _defaultNamespace, XamlGlobalStaticResourcesMap.ResourcePrecedence.Local);
						}
					}
				}
			}
		}

		private void BuildResourceMap(XamlObjectDefinition parentNode, XamlGlobalStaticResourcesMap map)
		{
			var contentNode = parentNode.Members.FirstOrDefault(m => m.Member.Name == "_UnknownContent");

			if (contentNode != null)
			{
				foreach (var resource in contentNode.Objects)
				{
					var key = resource.Members.FirstOrDefault(m => m.Member.Name == "Key");

					if (
						key != null
						&& resource.Type.Name != "StaticResource"
					)
					{
						map.Add(key.Value.ToString(), _defaultNamespace, XamlGlobalStaticResourcesMap.ResourcePrecedence.Local);
					}
				}
			}
		}

		//get keys of localized strings
		private string[] GetResourceKeys()
		{
			string[] resourceKeys = new string[0];

			if (_resourceFiles != null)
			{
				foreach (var file in _resourceFiles)
				{
					this.Log().Info("Parse resource file : " + file);

					//load document
					XmlDocument doc = new XmlDocument();
					doc.Load(file);
					XmlNode root = doc.DocumentElement;

					//extract all localization keys from Win10 resource file
					resourceKeys = resourceKeys
						.Concat(doc
							.SelectNodes("//data")
							.Cast<XmlElement>()
							.Select(node => node.GetAttribute("name"))
							.ToArray()
						)
						.Distinct()
						.Select(k => k.Replace(".", "/"))
						.ToArray();
				}
			}

			this.Log().Info(resourceKeys.Count() + " localization keys found");
			return resourceKeys;
		}

		private DateTime GetLastBinaryUpdateTime()
		{
			// Determine the last update time, to allow for the re-generation of the files.
			// Include the current assembly, as it might have been updated since the last generation.

			return _assemblySearchPaths
				.Select(File.GetLastWriteTime)
				.Concat(_buildTasksBuildDate)
				.Max();
		}

		private string GenerateGlobalResources(IEnumerable<XamlFileDefinition> files, XamlGlobalStaticResourcesMap map)
		{
			var outputFile = Path.Combine(_targetPath, "GlobalStaticResources.g.cs");

			var writer = new IndentedStringBuilder();

			writer.AppendLineInvariant("// <autogenerated />");
			writer.AppendLineInvariant("#pragma warning disable 618  // Ignore obsolete members warnings");
			writer.AppendLineInvariant("#pragma warning disable 105  // Ignore duplicate namespaces");
			writer.AppendLineInvariant("#pragma warning disable 1591 // Ignore missing XML comment warnings");
			writer.AppendLineInvariant("using System;");
			writer.AppendLineInvariant("using System.Linq;");
			writer.AppendLineInvariant("using System.Collections.Generic;");
			writer.AppendLineInvariant("using Uno.Extensions;");
			writer.AppendLineInvariant("using Uno;");
			writer.AppendLineInvariant("using System.Diagnostics;");

			//TODO Determine the list of namespaces to use
			writer.AppendLineInvariant($"using {XamlConstants.BaseXamlNamespace};");
			writer.AppendLineInvariant($"using {XamlConstants.Namespaces.Controls};");
			writer.AppendLineInvariant($"using {XamlConstants.Namespaces.Data};");
			writer.AppendLineInvariant($"using {XamlConstants.Namespaces.Documents};");
			writer.AppendLineInvariant($"using {XamlConstants.Namespaces.Media};");
			writer.AppendLineInvariant($"using {XamlConstants.Namespaces.MediaAnimation};");
			writer.AppendLineInvariant("using {0};", _defaultNamespace);
			writer.AppendLineInvariant("");

			using (writer.BlockInvariant("namespace {0}", _defaultNamespace))
			{
				writer.AppendLineInvariant("/// <summary>");
				writer.AppendLineInvariant("/// Contains all the static resources defined for the application");
				writer.AppendLineInvariant("/// </summary>");

				AnalyzerSuppressionsGenerator.Generate(writer, _analyzerSuppressions);
				using (writer.BlockInvariant("public sealed partial class GlobalStaticResources"))
				{
					writer.AppendLineInvariant("static bool _initialized;");
					writer.AppendLineInvariant("private static bool _stylesRegistered;");
					if (!IsUnoAssembly)
					{
						writer.AppendLineInvariant("private static bool _dictionariesRegistered;");
					}

					using (writer.BlockInvariant("static GlobalStaticResources()"))
					{
						writer.AppendLineInvariant("Initialize();");
					}

					using (writer.BlockInvariant("public static void Initialize()"))
					{
						using (writer.BlockInvariant("if (!_initialized)"))
						{
							using (IsUnoAssembly ? writer.BlockInvariant("using (ResourceResolver.WriteInitiateGlobalStaticResourcesEventActivity())") : null)
							{
								writer.AppendLineInvariant("_initialized = true;");

								foreach (var ambientResource in _ambientGlobalResources)
								{
									if (ambientResource.GetMethods().Any(m => m.Name == "Initialize"))
									{
										writer.AppendLineInvariant("global::{0}.Initialize();", ambientResource.GetFullName());
									}
								}

								foreach (var ambientResource in _ambientGlobalResources)
								{
									// Note: we do *not* call RegisterDefaultStyles for the current assembly, because those styles are treated as implicit styles, not default styles
									if (ambientResource.GetMethods().Any(m => m.Name == "RegisterDefaultStyles"))
									{
										writer.AppendLineInvariant("global::{0}.RegisterDefaultStyles();", ambientResource.GetFullName());
									}
								}

								foreach (var ambientResource in _ambientGlobalResources)
								{
									if (ambientResource.GetMethods().Any(m => m.Name == "RegisterResourceDictionariesBySource"))
									{
										writer.AppendLineInvariant("global::{0}.RegisterResourceDictionariesBySource();", ambientResource.GetFullName());
									}
								}

								if (IsUnoAssembly)
								{
									// Build master dictionary
									foreach (var dictProperty in map.GetAllDictionaryProperties(_baseResourceDependencies))
									{
										writer.AppendLineInvariant("MasterDictionary.MergedDictionaries.Add({0});", dictProperty);
									}
								}
							}
						}
					}

					using (writer.BlockInvariant("public static void RegisterDefaultStyles()"))
					{
						using (writer.BlockInvariant("if(!_stylesRegistered)"))
						{
							writer.AppendLineInvariant("_stylesRegistered = true;");
							foreach (var file in files)
							{
								writer.AppendLineInvariant("RegisterDefaultStyles_{0}();", file.UniqueID);
							}
						}
					}

					if (!IsUnoAssembly)
					{
						writer.AppendLineInvariant("// Register ResourceDictionaries using ms-appx:/// syntax, this is called for external resources");
						using (writer.BlockInvariant("public static void RegisterResourceDictionariesBySource()"))
						{
							using (writer.BlockInvariant("if(!_dictionariesRegistered)"))
							{
								writer.AppendLineInvariant("_dictionariesRegistered = true;");
								foreach (var file in files.Where(IsResourceDictionary))
								{
									writer.AppendLineInvariant("global::Uno.UI.ResourceResolver.RegisterResourceDictionaryBySource(\"ms-appx:///{0}/{1}\", () => {2}_ResourceDictionary);",
										_metadataHelper.AssemblyName,
										map.GetSourceLink(file),
										file.UniqueID
									);
								}
							}
						}
					}

					writer.AppendLineInvariant("// Register ResourceDictionaries using ms-resource:/// syntax, this is called for local resources");
					using (writer.BlockInvariant("internal static void RegisterResourceDictionariesBySourceLocal()"))
					{
						foreach (var file in files.Where(IsResourceDictionary))
						{
							writer.AppendLineInvariant("global::Uno.UI.ResourceResolver.RegisterResourceDictionaryBySource(\"ms-resource:///Files/{0}\", () => {1}_ResourceDictionary);",
								map.GetSourceLink(file),
								file.UniqueID
							);
						}
					}

					if (IsUnoAssembly)
					{
						// Declare master dictionary
						writer.AppendLine();
						writer.AppendLineInvariant("internal static ResourceDictionary MasterDictionary {{get; }} = new ResourceDictionary();");
					}

					// Generate all the partial methods, even if they don't exist. That avoids
					// having to sync the generation of the files with this global table.
					foreach (var file in files)
					{
						writer.AppendLineInvariant("static partial void RegisterDefaultStyles_{0}();", file.UniqueID);
					}

					writer.AppendLineInvariant("");
				}
			}

			return writer.ToString();
		}

		private bool IsResourceDictionary(XamlFileDefinition fileDefinition) => fileDefinition.Objects.FirstOrDefault()?.Type.Name == "ResourceDictionary";
	}
}
