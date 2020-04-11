#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BitmapIconSource : global::Microsoft.UI.Xaml.Controls.IconSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Uri UriSource
		{
			get
			{
				return (global::System.Uri)this.GetValue(UriSourceProperty);
			}
			set
			{
				this.SetValue(UriSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool ShowAsMonochrome
		{
			get
			{
				return (bool)this.GetValue(ShowAsMonochromeProperty);
			}
			set
			{
				this.SetValue(ShowAsMonochromeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ShowAsMonochromeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ShowAsMonochrome", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.BitmapIconSource), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty UriSourceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"UriSource", typeof(global::System.Uri), 
			typeof(global::Microsoft.UI.Xaml.Controls.BitmapIconSource), 
			new FrameworkPropertyMetadata(default(global::System.Uri)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public BitmapIconSource() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.BitmapIconSource", "BitmapIconSource.BitmapIconSource()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.BitmapIconSource.BitmapIconSource()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.BitmapIconSource.UriSource.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.BitmapIconSource.UriSource.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.BitmapIconSource.ShowAsMonochrome.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.BitmapIconSource.ShowAsMonochrome.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.BitmapIconSource.UriSourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.BitmapIconSource.ShowAsMonochromeProperty.get
	}
}
