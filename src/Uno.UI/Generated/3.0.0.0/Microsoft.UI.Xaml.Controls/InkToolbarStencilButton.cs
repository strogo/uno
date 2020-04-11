#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarStencilButton : global::Microsoft.UI.Xaml.Controls.InkToolbarMenuButton
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.InkToolbarStencilKind SelectedStencil
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.InkToolbarStencilKind)this.GetValue(SelectedStencilProperty);
			}
			set
			{
				this.SetValue(SelectedStencilProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsRulerItemVisible
		{
			get
			{
				return (bool)this.GetValue(IsRulerItemVisibleProperty);
			}
			set
			{
				this.SetValue(IsRulerItemVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsProtractorItemVisible
		{
			get
			{
				return (bool)this.GetValue(IsProtractorItemVisibleProperty);
			}
			set
			{
				this.SetValue(IsProtractorItemVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Input.Inking.InkPresenterProtractor Protractor
		{
			get
			{
				return (global::Windows.UI.Input.Inking.InkPresenterProtractor)this.GetValue(ProtractorProperty);
			}
		}
		#endif
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
		public static global::Microsoft.UI.Xaml.DependencyProperty IsProtractorItemVisibleProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsProtractorItemVisible", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.InkToolbarStencilButton), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsRulerItemVisibleProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsRulerItemVisible", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.InkToolbarStencilButton), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ProtractorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Protractor", typeof(global::Windows.UI.Input.Inking.InkPresenterProtractor), 
			typeof(global::Microsoft.UI.Xaml.Controls.InkToolbarStencilButton), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Input.Inking.InkPresenterProtractor)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty RulerProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Ruler", typeof(global::Windows.UI.Input.Inking.InkPresenterRuler), 
			typeof(global::Microsoft.UI.Xaml.Controls.InkToolbarStencilButton), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Input.Inking.InkPresenterRuler)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectedStencilProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"SelectedStencil", typeof(global::Microsoft.UI.Xaml.Controls.InkToolbarStencilKind), 
			typeof(global::Microsoft.UI.Xaml.Controls.InkToolbarStencilButton), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.InkToolbarStencilKind)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public InkToolbarStencilButton() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.InkToolbarStencilButton", "InkToolbarStencilButton.InkToolbarStencilButton()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.InkToolbarStencilButton()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.Ruler.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.Protractor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.SelectedStencil.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.SelectedStencil.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.IsRulerItemVisible.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.IsRulerItemVisible.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.IsProtractorItemVisible.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.IsProtractorItemVisible.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.RulerProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.ProtractorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.SelectedStencilProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.IsRulerItemVisibleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.InkToolbarStencilButton.IsProtractorItemVisibleProperty.get
	}
}
