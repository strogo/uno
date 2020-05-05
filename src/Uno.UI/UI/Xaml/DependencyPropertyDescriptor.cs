﻿using System;
using Uno.Extensions;
using Uno.Logging;

namespace Microsoft.UI.Xaml
{
	internal class DependencyPropertyDescriptor
	{

		public DependencyPropertyDescriptor(Type ownerType, string name)
		{
			OwnerType = ownerType;
			Name = name;
        }

		public string Name { get; }

		public Type OwnerType { get; }

		/// <summary>
		/// Parses an attached PropertyPath in the form of "(clrnamespace:Type.Property)"
		/// </summary>
		/// <param name="propertyPath">The property path</param>
		/// <returns></returns>
		internal static DependencyPropertyDescriptor Parse(string propertyPath)
		{
			if (propertyPath.Contains(":"))
			{
				// (Uno.UI.Tests.BinderTests:Attachable.MyValue)

				var bindingParts = propertyPath.Trim(new[] { '(', ')' }).Split(new[] { ':' });

				if (bindingParts.Length == 2)
				{
					var ns = bindingParts[0];
					var propertyParts = bindingParts[1].Split(new[] { '.' });

					if (propertyParts.Length == 2)
					{
						var typeName = propertyParts[0];
						var propertyname = propertyParts[1];

						var qualifiedTypeName = ns + "." + typeName;

						// Search using the current metadata provider
						var type = Uno.UI.DataBinding.BindingPropertyHelper
							.BindableMetadataProvider
							?.GetBindableTypeByFullName(qualifiedTypeName)
							?.Type;

						if(type == null)
						{
							// If not available, search through Reflection
							type = Type.GetType(qualifiedTypeName);

							if(type == null)
							{
								foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
								{
									type = asm.GetType(qualifiedTypeName);
									if (type != null)
									{
										break;
									}
								}
							}
						}

						if (type != null)
						{
							return new DependencyPropertyDescriptor(type, propertyname);
						}
					}
					else
					{
						if (typeof(DependencyPropertyDescriptor).Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug))
						{
							typeof(DependencyPropertyDescriptor).Log().DebugFormat($"The property path [{propertyPath}] is not formatted properly (must only access one property)");
						}
					}
				}
				else
				{
					if (typeof(DependencyPropertyDescriptor).Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug))
					{
						typeof(DependencyPropertyDescriptor).Log().DebugFormat($"The property path [{propertyPath}] is not formatted properly (must have exactly one ':')");
					}
				}
			}

			return null;
		}
	}
}
