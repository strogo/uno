﻿using Microsoft.Build.Execution;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Uno.Extensions;
using Uno.SourceGeneration;
using Uno.UI.SourceGenerators.Helpers;

namespace Uno.UI.SourceGenerators.NativeCtor
{
	public class RemoteControlGenerator : SourceGenerator
	{
		public override void Execute(SourceGeneratorContext context)
		{
			if(
				context.GetProjectInstance().GetPropertyValue("Configuration") == "Debug"
				&& IsApplication(context.GetProjectInstance()))
			{
				var unoRemoteControlPort = context.GetProjectInstance().GetPropertyValue("UnoRemoteControlPort");

				var addresses = NetworkInterface.GetAllNetworkInterfaces()
					  .SelectMany(x => x.GetIPProperties().UnicastAddresses)
					  .Where(x => !IPAddress.IsLoopback(x.Address));

				var sb = new IndentedStringBuilder();

				foreach(var addressInfo in addresses)
				{
					sb.AppendLineInvariant($"[assembly: global::Uno.UI.HotReload.ServerEndpointAttribute(\"{addressInfo.Address}\", {unoRemoteControlPort})]");
				}

				sb.AppendLineInvariant($"[assembly: global::Uno.UI.HotReload.ProjectConfigurationAttribute(");
				sb.AppendLineInvariant($"@\"{context.GetProjectInstance().FullPath}\",\n");

				var xamlPaths = from item in context.GetProjectInstance().GetItems("Page").Concat(context.GetProjectInstance().GetItems("ApplicationDefinition"))
								select Path.GetDirectoryName(item.EvaluatedInclude);

				var distictPaths = string.Join(",\n", xamlPaths.Distinct().Select(p => $"@\"{p}\""));

				sb.AppendLineInvariant("{0}", $"new[]{{{distictPaths}}}");

				sb.AppendLineInvariant($")]");

				context.AddCompilationUnit("HotReload", sb.ToString());
			}
		}

		private bool IsApplication(ProjectInstance projectInstance)
		{
			var isAndroidApp = projectInstance.GetPropertyValue("AndroidApplication")?.Equals("true", StringComparison.OrdinalIgnoreCase) ?? false;
			var isiOSApp = projectInstance.GetPropertyValue("ProjectTypeGuids")?.Equals("{FEACFBD2-3405-455C-9665-78FE426C6842};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}", StringComparison.OrdinalIgnoreCase) ?? false;
			var ismacOSApp = projectInstance.GetPropertyValue("ProjectTypeGuids")?.Equals("{A3F8F2AB-B479-4A4A-A458-A89E7DC349F1};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}", StringComparison.OrdinalIgnoreCase) ?? false;
			var isExe = projectInstance.GetPropertyValue("OutputType")?.Equals("Exe", StringComparison.OrdinalIgnoreCase) ?? false;
			var isWasm = projectInstance.GetPropertyValue("WasmHead")?.Equals("true", StringComparison.OrdinalIgnoreCase) ?? false;

			return isAndroidApp
				|| (isiOSApp && isExe)
				|| (ismacOSApp && isExe)
				|| isWasm;
		}
	}
}
