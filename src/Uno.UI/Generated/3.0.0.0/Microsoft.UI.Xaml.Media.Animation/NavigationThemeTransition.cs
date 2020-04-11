#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class NavigationThemeTransition : global::Microsoft.UI.Xaml.Media.Animation.Transition
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo DefaultNavigationTransitionInfo
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo)this.GetValue(DefaultNavigationTransitionInfoProperty);
			}
			set
			{
				this.SetValue(DefaultNavigationTransitionInfoProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DefaultNavigationTransitionInfoProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"DefaultNavigationTransitionInfo", typeof(global::Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.NavigationThemeTransition), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public NavigationThemeTransition() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.NavigationThemeTransition", "NavigationThemeTransition.NavigationThemeTransition()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.NavigationThemeTransition.NavigationThemeTransition()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.NavigationThemeTransition.DefaultNavigationTransitionInfo.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.NavigationThemeTransition.DefaultNavigationTransitionInfo.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.NavigationThemeTransition.DefaultNavigationTransitionInfoProperty.get
	}
}
