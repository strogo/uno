#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapTileSource : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Maps.MapZoomLevelRange ZoomLevelRange
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Maps.MapZoomLevelRange)this.GetValue(ZoomLevelRangeProperty);
			}
			set
			{
				this.SetValue(ZoomLevelRangeProperty, value);
			}
		}
		#endif
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
		public  int TilePixelSize
		{
			get
			{
				return (int)this.GetValue(TilePixelSizeProperty);
			}
			set
			{
				this.SetValue(TilePixelSizeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Maps.MapTileLayer Layer
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Maps.MapTileLayer)this.GetValue(LayerProperty);
			}
			set
			{
				this.SetValue(LayerProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsTransparencyEnabled
		{
			get
			{
				return (bool)this.GetValue(IsTransparencyEnabledProperty);
			}
			set
			{
				this.SetValue(IsTransparencyEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsRetryEnabled
		{
			get
			{
				return (bool)this.GetValue(IsRetryEnabledProperty);
			}
			set
			{
				this.SetValue(IsRetryEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsFadingEnabled
		{
			get
			{
				return (bool)this.GetValue(IsFadingEnabledProperty);
			}
			set
			{
				this.SetValue(IsFadingEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Maps.MapTileDataSource DataSource
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Maps.MapTileDataSource)this.GetValue(DataSourceProperty);
			}
			set
			{
				this.SetValue(DataSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Geolocation.GeoboundingBox Bounds
		{
			get
			{
				return (global::Windows.Devices.Geolocation.GeoboundingBox)this.GetValue(BoundsProperty);
			}
			set
			{
				this.SetValue(BoundsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AllowOverstretch
		{
			get
			{
				return (bool)this.GetValue(AllowOverstretchProperty);
			}
			set
			{
				this.SetValue(AllowOverstretchProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan FrameDuration
		{
			get
			{
				return (global::System.TimeSpan)this.GetValue(FrameDurationProperty);
			}
			set
			{
				this.SetValue(FrameDurationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int FrameCount
		{
			get
			{
				return (int)this.GetValue(FrameCountProperty);
			}
			set
			{
				this.SetValue(FrameCountProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AutoPlay
		{
			get
			{
				return (bool)this.GetValue(AutoPlayProperty);
			}
			set
			{
				this.SetValue(AutoPlayProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Maps.MapTileAnimationState AnimationState
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Maps.MapTileAnimationState)this.GetValue(AnimationStateProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AllowOverstretchProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"AllowOverstretch", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty BoundsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Bounds", typeof(global::Windows.Devices.Geolocation.GeoboundingBox), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(global::Windows.Devices.Geolocation.GeoboundingBox)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DataSourceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"DataSource", typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileDataSource), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Maps.MapTileDataSource)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsFadingEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsFadingEnabled", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsRetryEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsRetryEnabled", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsTransparencyEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsTransparencyEnabled", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LayerProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Layer", typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileLayer), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Maps.MapTileLayer)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TilePixelSizeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"TilePixelSize", typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty VisibleProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Visible", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ZIndexProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ZIndex", typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ZoomLevelRangeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ZoomLevelRange", typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapZoomLevelRange), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Maps.MapZoomLevelRange)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AnimationStateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"AnimationState", typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileAnimationState), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Maps.MapTileAnimationState)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty AutoPlayProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"AutoPlay", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty FrameCountProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"FrameCount", typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty FrameDurationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"FrameDuration", typeof(global::System.TimeSpan), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapTileSource), 
			new FrameworkPropertyMetadata(default(global::System.TimeSpan)));
#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.MapTileSource()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.MapTileSource()
#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapTileSource() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.MapTileSource", "MapTileSource.MapTileSource(MapTileDataSource dataSource)");
		}
#endif
#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapTileSource( global::Microsoft.UI.Xaml.Controls.Maps.MapTileDataSource dataSource) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.MapTileSource", "MapTileSource.MapTileSource(MapTileDataSource dataSource)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.MapTileSource(Microsoft.UI.Xaml.Controls.Maps.MapTileDataSource)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapTileSource( global::Microsoft.UI.Xaml.Controls.Maps.MapTileDataSource dataSource,  global::Microsoft.UI.Xaml.Controls.Maps.MapZoomLevelRange zoomLevelRange) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.MapTileSource", "MapTileSource.MapTileSource(MapTileDataSource dataSource, MapZoomLevelRange zoomLevelRange)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.MapTileSource(Microsoft.UI.Xaml.Controls.Maps.MapTileDataSource, Microsoft.UI.Xaml.Controls.Maps.MapZoomLevelRange)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapTileSource( global::Microsoft.UI.Xaml.Controls.Maps.MapTileDataSource dataSource,  global::Microsoft.UI.Xaml.Controls.Maps.MapZoomLevelRange zoomLevelRange,  global::Windows.Devices.Geolocation.GeoboundingBox bounds) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.MapTileSource", "MapTileSource.MapTileSource(MapTileDataSource dataSource, MapZoomLevelRange zoomLevelRange, GeoboundingBox bounds)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.MapTileSource(Microsoft.UI.Xaml.Controls.Maps.MapTileDataSource, Microsoft.UI.Xaml.Controls.Maps.MapZoomLevelRange, Windows.Devices.Geolocation.GeoboundingBox)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapTileSource( global::Microsoft.UI.Xaml.Controls.Maps.MapTileDataSource dataSource,  global::Microsoft.UI.Xaml.Controls.Maps.MapZoomLevelRange zoomLevelRange,  global::Windows.Devices.Geolocation.GeoboundingBox bounds,  int tileSizeInPixels) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.MapTileSource", "MapTileSource.MapTileSource(MapTileDataSource dataSource, MapZoomLevelRange zoomLevelRange, GeoboundingBox bounds, int tileSizeInPixels)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.MapTileSource(Microsoft.UI.Xaml.Controls.Maps.MapTileDataSource, Microsoft.UI.Xaml.Controls.Maps.MapZoomLevelRange, Windows.Devices.Geolocation.GeoboundingBox, int)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.DataSource.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.DataSource.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.Layer.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.Layer.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.ZoomLevelRange.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.ZoomLevelRange.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.Bounds.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.Bounds.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.AllowOverstretch.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.AllowOverstretch.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.IsFadingEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.IsFadingEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.IsTransparencyEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.IsTransparencyEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.IsRetryEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.IsRetryEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.ZIndex.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.ZIndex.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.TilePixelSize.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.TilePixelSize.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.Visible.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.Visible.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.AnimationState.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.AutoPlay.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.AutoPlay.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.FrameCount.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.FrameCount.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.FrameDuration.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.FrameDuration.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Pause()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.MapTileSource", "void MapTileSource.Pause()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Play()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.MapTileSource", "void MapTileSource.Play()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Stop()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.MapTileSource", "void MapTileSource.Stop()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.AnimationStateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.AutoPlayProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.FrameCountProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.FrameDurationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.DataSourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.LayerProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.ZoomLevelRangeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.BoundsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.AllowOverstretchProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.IsFadingEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.IsTransparencyEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.IsRetryEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.ZIndexProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.TilePixelSizeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapTileSource.VisibleProperty.get
	}
}
