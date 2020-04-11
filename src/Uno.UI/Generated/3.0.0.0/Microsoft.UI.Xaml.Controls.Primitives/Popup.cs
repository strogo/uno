#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || false || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class Popup : global::Microsoft.UI.Xaml.FrameworkElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double VerticalOffset
		{
			get
			{
				return (double)this.GetValue(VerticalOffsetProperty);
			}
			set
			{
				this.SetValue(VerticalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsOpen
		{
			get
			{
				return (bool)this.GetValue(IsOpenProperty);
			}
			set
			{
				this.SetValue(IsOpenProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsLightDismissEnabled
		{
			get
			{
				return (bool)this.GetValue(IsLightDismissEnabledProperty);
			}
			set
			{
				this.SetValue(IsLightDismissEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double HorizontalOffset
		{
			get
			{
				return (double)this.GetValue(HorizontalOffsetProperty);
			}
			set
			{
				this.SetValue(HorizontalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Animation.TransitionCollection ChildTransitions
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Animation.TransitionCollection)this.GetValue(ChildTransitionsProperty);
			}
			set
			{
				this.SetValue(ChildTransitionsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement Child
		{
			get
			{
				return (global::Microsoft.UI.Xaml.UIElement)this.GetValue(ChildProperty);
			}
			set
			{
				this.SetValue(ChildProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.LightDismissOverlayMode LightDismissOverlayMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.LightDismissOverlayMode)this.GetValue(LightDismissOverlayModeProperty);
			}
			set
			{
				this.SetValue(LightDismissOverlayModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ChildProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Child", typeof(global::Microsoft.UI.Xaml.UIElement), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Popup), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ChildTransitionsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ChildTransitions", typeof(global::Microsoft.UI.Xaml.Media.Animation.TransitionCollection), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Popup), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Animation.TransitionCollection)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalOffsetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"HorizontalOffset", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Popup), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsLightDismissEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsLightDismissEnabled", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Popup), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsOpenProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsOpen", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Popup), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalOffsetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"VerticalOffset", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Popup), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LightDismissOverlayModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"LightDismissOverlayMode", typeof(global::Microsoft.UI.Xaml.Controls.LightDismissOverlayMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.Popup), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.LightDismissOverlayMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || false || __MACOS__
		[global::Uno.NotImplemented]
		public Popup() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Popup", "Popup.Popup()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.Popup()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.Child.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.Child.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.IsOpen.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.IsOpen.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.HorizontalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.HorizontalOffset.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.VerticalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.VerticalOffset.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.ChildTransitions.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.ChildTransitions.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.IsLightDismissEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.IsLightDismissEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.Opened.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.Opened.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.Closed.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.Closed.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.LightDismissOverlayMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.LightDismissOverlayMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.LightDismissOverlayModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.ChildProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.IsOpenProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.HorizontalOffsetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.VerticalOffsetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.ChildTransitionsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.Popup.IsLightDismissEnabledProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::System.EventHandler<object> Closed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Popup", "event EventHandler<object> Popup.Closed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Popup", "event EventHandler<object> Popup.Closed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::System.EventHandler<object> Opened
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Popup", "event EventHandler<object> Popup.Opened");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.Popup", "event EventHandler<object> Popup.Opened");
			}
		}
		#endif
	}
}
