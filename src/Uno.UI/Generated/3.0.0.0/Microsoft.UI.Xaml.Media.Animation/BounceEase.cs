#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class BounceEase : global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double Bounciness
		{
			get
			{
				return (double)this.GetValue(BouncinessProperty);
			}
			set
			{
				this.SetValue(BouncinessProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int Bounces
		{
			get
			{
				return (int)this.GetValue(BouncesProperty);
			}
			set
			{
				this.SetValue(BouncesProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty BouncesProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Bounces", typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.BounceEase), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty BouncinessProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Bounciness", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.BounceEase), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Media.Animation.BounceEase.BounceEase()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.BounceEase.BounceEase()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.BounceEase.Bounces.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.BounceEase.Bounces.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.BounceEase.Bounciness.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.BounceEase.Bounciness.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.BounceEase.BouncesProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.BounceEase.BouncinessProperty.get
	}
}
