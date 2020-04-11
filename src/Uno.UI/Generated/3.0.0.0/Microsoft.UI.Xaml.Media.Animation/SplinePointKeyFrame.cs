#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SplinePointKeyFrame : global::Microsoft.UI.Xaml.Media.Animation.PointKeyFrame
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Animation.KeySpline KeySpline
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Animation.KeySpline)this.GetValue(KeySplineProperty);
			}
			set
			{
				this.SetValue(KeySplineProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty KeySplineProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"KeySpline", typeof(global::Microsoft.UI.Xaml.Media.Animation.KeySpline), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplinePointKeyFrame), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Animation.KeySpline)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SplinePointKeyFrame() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.SplinePointKeyFrame", "SplinePointKeyFrame.SplinePointKeyFrame()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplinePointKeyFrame.SplinePointKeyFrame()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplinePointKeyFrame.KeySpline.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplinePointKeyFrame.KeySpline.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplinePointKeyFrame.KeySplineProperty.get
	}
}
