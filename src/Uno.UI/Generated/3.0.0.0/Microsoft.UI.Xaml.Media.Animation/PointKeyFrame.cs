#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class PointKeyFrame : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point Value
		{
			get
			{
				return (global::Windows.Foundation.Point)this.GetValue(ValueProperty);
			}
			set
			{
				this.SetValue(ValueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Animation.KeyTime KeyTime
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Animation.KeyTime)this.GetValue(KeyTimeProperty);
			}
			set
			{
				this.SetValue(KeyTimeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty KeyTimeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"KeyTime", typeof(global::Microsoft.UI.Xaml.Media.Animation.KeyTime), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.PointKeyFrame), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Animation.KeyTime)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ValueProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Value", typeof(global::Windows.Foundation.Point), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.PointKeyFrame), 
			new FrameworkPropertyMetadata(default(global::Windows.Foundation.Point)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Media.Animation.PointKeyFrame.PointKeyFrame()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointKeyFrame.PointKeyFrame()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointKeyFrame.Value.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointKeyFrame.Value.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointKeyFrame.KeyTime.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointKeyFrame.KeyTime.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointKeyFrame.ValueProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PointKeyFrame.KeyTimeProperty.get
	}
}
