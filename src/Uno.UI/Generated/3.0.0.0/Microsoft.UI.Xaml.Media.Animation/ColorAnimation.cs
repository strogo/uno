#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
#if false || false || false || false || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ColorAnimation : global::Microsoft.UI.Xaml.Media.Animation.Timeline
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
			typeof(global::Microsoft.UI.Xaml.Media.Animation.ColorAnimation), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Animation.EasingFunctionBase)));
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.ColorAnimation()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.From.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.From.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.To.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.To.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.By.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.By.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.EasingFunction.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.EasingFunction.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.EnableDependentAnimation.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.EnableDependentAnimation.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.FromProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.ToProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.ByProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.EasingFunctionProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.ColorAnimation.EnableDependentAnimationProperty.get
	}
}
