#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ToolTipService
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PlacementProperty { get; } =
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"Placement", typeof(global::Microsoft.UI.Xaml.Controls.Primitives.PlacementMode),
			typeof(global::Microsoft.UI.Xaml.Controls.ToolTipService),
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Primitives.PlacementMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PlacementTargetProperty { get; } =
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"PlacementTarget", typeof(global::Microsoft.UI.Xaml.UIElement),
			typeof(global::Microsoft.UI.Xaml.Controls.ToolTipService),
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.UIElement)));
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTipService.PlacementProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Controls.Primitives.PlacementMode GetPlacement( global::Microsoft.UI.Xaml.DependencyObject element)
		{
			return (global::Microsoft.UI.Xaml.Controls.Primitives.PlacementMode)element.GetValue(PlacementProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetPlacement( global::Microsoft.UI.Xaml.DependencyObject element,  global::Microsoft.UI.Xaml.Controls.Primitives.PlacementMode value)
		{
			element.SetValue(PlacementProperty, value);
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTipService.PlacementTargetProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.UIElement GetPlacementTarget( global::Microsoft.UI.Xaml.DependencyObject element)
		{
			return (global::Microsoft.UI.Xaml.UIElement)element.GetValue(PlacementTargetProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetPlacementTarget( global::Microsoft.UI.Xaml.DependencyObject element,  global::Microsoft.UI.Xaml.UIElement value)
		{
			element.SetValue(PlacementTargetProperty, value);
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToolTipService.ToolTipProperty.get
	}
}
