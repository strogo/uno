#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Provider
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ITextProvider2 : global::Microsoft.UI.Xaml.Automation.Provider.ITextProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider RangeFromAnnotation( global::Microsoft.UI.Xaml.Automation.Provider.IRawElementProviderSimple annotationElement);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.Automation.Provider.ITextRangeProvider GetCaretRange(out bool isActive);
		#endif
	}
}
