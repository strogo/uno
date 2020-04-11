#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarPencilButton : global::Microsoft.UI.Xaml.Controls.InkToolbarPenButton
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public InkToolbarPencilButton() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.InkToolbarPencilButton", "InkToolbarPencilButton.InkToolbarPencilButton()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarPencilButton.InkToolbarPencilButton()
	}
}
