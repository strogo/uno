#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SplitCloseThemeAnimation : global::Microsoft.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string OpenedTargetName
		{
			get
			{
				return (string)this.GetValue(OpenedTargetNameProperty);
			}
			set
			{
				this.SetValue(OpenedTargetNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject OpenedTarget
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DependencyObject)this.GetValue(OpenedTargetProperty);
			}
			set
			{
				this.SetValue(OpenedTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double OpenedLength
		{
			get
			{
				return (double)this.GetValue(OpenedLengthProperty);
			}
			set
			{
				this.SetValue(OpenedLengthProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double OffsetFromCenter
		{
			get
			{
				return (double)this.GetValue(OffsetFromCenterProperty);
			}
			set
			{
				this.SetValue(OffsetFromCenterProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ContentTranslationOffset
		{
			get
			{
				return (double)this.GetValue(ContentTranslationOffsetProperty);
			}
			set
			{
				this.SetValue(ContentTranslationOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Primitives.AnimationDirection ContentTranslationDirection
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Primitives.AnimationDirection)this.GetValue(ContentTranslationDirectionProperty);
			}
			set
			{
				this.SetValue(ContentTranslationDirectionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string ContentTargetName
		{
			get
			{
				return (string)this.GetValue(ContentTargetNameProperty);
			}
			set
			{
				this.SetValue(ContentTargetNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject ContentTarget
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DependencyObject)this.GetValue(ContentTargetProperty);
			}
			set
			{
				this.SetValue(ContentTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string ClosedTargetName
		{
			get
			{
				return (string)this.GetValue(ClosedTargetNameProperty);
			}
			set
			{
				this.SetValue(ClosedTargetNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject ClosedTarget
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DependencyObject)this.GetValue(ClosedTargetProperty);
			}
			set
			{
				this.SetValue(ClosedTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double ClosedLength
		{
			get
			{
				return (double)this.GetValue(ClosedLengthProperty);
			}
			set
			{
				this.SetValue(ClosedLengthProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ClosedLengthProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ClosedLength", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ClosedTargetNameProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ClosedTargetName", typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ClosedTargetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ClosedTarget", typeof(global::Microsoft.UI.Xaml.DependencyObject), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentTargetNameProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ContentTargetName", typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentTargetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ContentTarget", typeof(global::Microsoft.UI.Xaml.DependencyObject), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentTranslationDirectionProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ContentTranslationDirection", typeof(global::Microsoft.UI.Xaml.Controls.Primitives.AnimationDirection), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Primitives.AnimationDirection)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentTranslationOffsetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ContentTranslationOffset", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OffsetFromCenterProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"OffsetFromCenter", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OpenedLengthProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"OpenedLength", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OpenedTargetNameProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"OpenedTargetName", typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OpenedTargetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"OpenedTarget", typeof(global::Microsoft.UI.Xaml.DependencyObject), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SplitCloseThemeAnimation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation", "SplitCloseThemeAnimation.SplitCloseThemeAnimation()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.SplitCloseThemeAnimation()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.OpenedTargetName.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.OpenedTargetName.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.OpenedTarget.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.OpenedTarget.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ClosedTargetName.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ClosedTargetName.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ClosedTarget.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ClosedTarget.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ContentTargetName.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ContentTargetName.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ContentTarget.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ContentTarget.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.OpenedLength.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.OpenedLength.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ClosedLength.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ClosedLength.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.OffsetFromCenter.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.OffsetFromCenter.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ContentTranslationDirection.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ContentTranslationDirection.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ContentTranslationOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ContentTranslationOffset.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.OpenedTargetNameProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.OpenedTargetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ClosedTargetNameProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ClosedTargetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ContentTargetNameProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ContentTargetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.OpenedLengthProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ClosedLengthProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.OffsetFromCenterProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ContentTranslationDirectionProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.SplitCloseThemeAnimation.ContentTranslationOffsetProperty.get
	}
}
