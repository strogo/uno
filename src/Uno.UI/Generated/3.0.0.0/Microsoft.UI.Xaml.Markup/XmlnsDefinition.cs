#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Markup
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct XmlnsDefinition 
	{
		// Forced skipping of method Microsoft.UI.Xaml.Markup.XmlnsDefinition.XmlnsDefinition()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  string XmlNamespace;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		public  string Namespace;
		#endif
	}
}
