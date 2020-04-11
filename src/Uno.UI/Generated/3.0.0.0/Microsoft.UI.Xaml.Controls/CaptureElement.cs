#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CaptureElement : global::Microsoft.UI.Xaml.FrameworkElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Stretch Stretch
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Stretch)this.GetValue(StretchProperty);
			}
			set
			{
				this.SetValue(StretchProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Capture.MediaCapture Source
		{
			get
			{
				return (global::Windows.Media.Capture.MediaCapture)this.GetValue(SourceProperty);
			}
			set
			{
				this.SetValue(SourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SourceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Source", typeof(global::Windows.Media.Capture.MediaCapture), 
			typeof(global::Microsoft.UI.Xaml.Controls.CaptureElement), 
			new FrameworkPropertyMetadata(default(global::Windows.Media.Capture.MediaCapture)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty StretchProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Stretch", typeof(global::Microsoft.UI.Xaml.Media.Stretch), 
			typeof(global::Microsoft.UI.Xaml.Controls.CaptureElement), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Stretch)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public CaptureElement() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.CaptureElement", "CaptureElement.CaptureElement()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CaptureElement.CaptureElement()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CaptureElement.Source.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CaptureElement.Source.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CaptureElement.Stretch.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CaptureElement.Stretch.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CaptureElement.SourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CaptureElement.StretchProperty.get
	}
}
