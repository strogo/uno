#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.UI
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebViewControlDOMContentLoadedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Uri Uri
		{
			get
			{
				throw new global::System.NotImplementedException("The member Uri WebViewControlDOMContentLoadedEventArgs.Uri is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Web.UI.WebViewControlDOMContentLoadedEventArgs.Uri.get
	}
}
