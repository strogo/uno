#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebViewPermissionRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.WebViewPermissionRequest PermissionRequest
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebViewPermissionRequest WebViewPermissionRequestedEventArgs.PermissionRequest is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebViewPermissionRequestedEventArgs.PermissionRequest.get
	}
}
