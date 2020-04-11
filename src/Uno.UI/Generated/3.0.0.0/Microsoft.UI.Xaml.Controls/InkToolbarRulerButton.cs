#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarRulerButton : global::Microsoft.UI.Xaml.Controls.InkToolbarToggleButton
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Input.Inking.InkPresenterRuler Ruler
		{
			get
			{
				return (global::Windows.UI.Input.Inking.InkPresenterRuler)this.GetValue(RulerProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty RulerProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Ruler", typeof(global::Windows.UI.Input.Inking.InkPresenterRuler), 
			typeof(global::Microsoft.UI.Xaml.Controls.InkToolbarRulerButton), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Input.Inking.InkPresenterRuler)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public InkToolbarRulerButton() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.InkToolbarRulerButton", "InkToolbarRulerButton.InkToolbarRulerButton()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarRulerButton.InkToolbarRulerButton()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarRulerButton.Ruler.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarRulerButton.RulerProperty.get
	}
}
