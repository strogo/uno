#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EasingColorKeyFrame : global::Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase EasingFunction
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase)this.GetValue(EasingFunctionProperty);
			}
			set
			{
				this.SetValue(EasingFunctionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty EasingFunctionProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"EasingFunction", typeof(global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.EasingColorKeyFrame), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public EasingColorKeyFrame() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.EasingColorKeyFrame", "EasingColorKeyFrame.EasingColorKeyFrame()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.EasingColorKeyFrame.EasingColorKeyFrame()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.EasingColorKeyFrame.EasingFunction.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.EasingColorKeyFrame.EasingFunction.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.EasingColorKeyFrame.EasingFunctionProperty.get
	}
}
