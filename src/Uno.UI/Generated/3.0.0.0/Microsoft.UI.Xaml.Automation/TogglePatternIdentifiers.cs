#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TogglePatternIdentifiers 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Automation.AutomationProperty ToggleStateProperty
		{
			get
			{
				throw new global::System.NotImplementedException("The member AutomationProperty TogglePatternIdentifiers.ToggleStateProperty is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.TogglePatternIdentifiers.ToggleStateProperty.get
	}
}
