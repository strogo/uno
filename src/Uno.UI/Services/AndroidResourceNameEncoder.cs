using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Uno.UI
{
    internal static class AndroidResourceNameEncoder
    {
		private const string NumberPrefix = "__";

		// These characters are not supported on Android, but they're used by the attached property localization syntax.
		// Example: "MyUid.[using:Microsoft.UI.Xaml.Automation]AutomationProperties.Name"
		private static readonly Regex sanitizeName = new Regex(@"[^a-zA-Z0-9_.]", RegexOptions.Compiled);

		/// <summary>
		/// Encode a resource name to remove characters that are not supported on Android.
		/// </summary>
		/// <param name="key">The original resource name from the UWP Resources.resw file.</param>
		/// <returns>The encoded resource name for the Android Strings.xml file.</returns>
		public static string Encode(string key)
		{
			// Checks whether the key contains unsupported characters
			key = sanitizeName.Replace(key, "_");

			//Checks if the keys are starting by a number because they are invalid in C#
			if (int.TryParse(key.Substring(0,1), out var number))
			{
				key = $"{NumberPrefix}{key}";
			}

			return key;
		}
	}
}
