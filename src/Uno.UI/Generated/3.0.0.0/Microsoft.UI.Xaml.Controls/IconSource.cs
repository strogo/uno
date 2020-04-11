#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class IconSource : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Brush Foreground
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Brush)this.GetValue(ForegroundProperty);
			}
			set
			{
				this.SetValue(ForegroundProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ForegroundProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Foreground", typeof(global::Microsoft.UI.Xaml.Media.Brush), 
			typeof(global::Microsoft.UI.Xaml.Controls.IconSource), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Brush)));
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IconSource.Foreground.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IconSource.Foreground.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.IconSource.ForegroundProperty.get
	}
}
