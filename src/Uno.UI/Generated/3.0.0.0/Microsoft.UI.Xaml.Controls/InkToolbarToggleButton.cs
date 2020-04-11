#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarToggleButton : global::Microsoft.UI.Xaml.Controls.CheckBox
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.InkToolbarToggle ToggleKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member InkToolbarToggle InkToolbarToggleButton.ToggleKind is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarToggleButton.ToggleKind.get
	}
}
