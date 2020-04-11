#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapPolyline : global::Microsoft.UI.Xaml.Controls.Maps.MapElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double StrokeThickness
		{
			get
			{
				throw new global::System.NotImplementedException("The member double MapPolyline.StrokeThickness is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.MapPolyline", "double MapPolyline.StrokeThickness");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool StrokeDashed
		{
			get
			{
				return (bool)this.GetValue(StrokeDashedProperty);
			}
			set
			{
				this.SetValue(StrokeDashedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Color StrokeColor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color MapPolyline.StrokeColor is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.MapPolyline", "Color MapPolyline.StrokeColor");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Geolocation.Geopath Path
		{
			get
			{
				return (global::Windows.Devices.Geolocation.Geopath)this.GetValue(PathProperty);
			}
			set
			{
				this.SetValue(PathProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PathProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Path", typeof(global::Windows.Devices.Geolocation.Geopath), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapPolyline), 
			new FrameworkPropertyMetadata(default(global::Windows.Devices.Geolocation.Geopath)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty StrokeDashedProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"StrokeDashed", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapPolyline), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapPolyline() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.MapPolyline", "MapPolyline.MapPolyline()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapPolyline.MapPolyline()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapPolyline.Path.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapPolyline.Path.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapPolyline.StrokeColor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapPolyline.StrokeColor.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapPolyline.StrokeThickness.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapPolyline.StrokeThickness.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapPolyline.StrokeDashed.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapPolyline.StrokeDashed.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapPolyline.PathProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapPolyline.StrokeDashedProperty.get
	}
}
