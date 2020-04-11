#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Documents
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContactContentLinkProvider : global::Microsoft.UI.Xaml.Documents.ContentLinkProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ContactContentLinkProvider() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Documents.ContactContentLinkProvider", "ContactContentLinkProvider.ContactContentLinkProvider()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Documents.ContactContentLinkProvider.ContactContentLinkProvider()
	}
}
