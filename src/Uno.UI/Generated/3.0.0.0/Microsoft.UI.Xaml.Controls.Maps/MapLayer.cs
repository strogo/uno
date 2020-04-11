#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapLayer : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int ZIndex
		{
			get
			{
				return (int)this.GetValue(ZIndexProperty);
			}
			set
			{
				this.SetValue(ZIndexProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Visible
		{
			get
			{
				return (bool)this.GetValue(VisibleProperty);
			}
			set
			{
				this.SetValue(VisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int MapTabIndex
		{
			get
			{
				return (int)this.GetValue(MapTabIndexProperty);
			}
			set
			{
				this.SetValue(MapTabIndexProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MapTabIndexProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"MapTabIndex", typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapLayer), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty VisibleProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Visible", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapLayer), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ZIndexProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ZIndex", typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapLayer), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Maps.MapLayer.MapLayer()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapLayer.MapLayer()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapLayer.MapTabIndex.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapLayer.MapTabIndex.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapLayer.Visible.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapLayer.Visible.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapLayer.ZIndex.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapLayer.ZIndex.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapLayer.MapTabIndexProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapLayer.VisibleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapLayer.ZIndexProperty.get
	}
}
