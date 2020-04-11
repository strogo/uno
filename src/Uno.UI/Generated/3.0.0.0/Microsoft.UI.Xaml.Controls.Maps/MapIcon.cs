#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapIcon : global::Microsoft.UI.Xaml.Controls.Maps.MapElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Title
		{
			get
			{
				return (string)this.GetValue(TitleProperty);
			}
			set
			{
				this.SetValue(TitleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point NormalizedAnchorPoint
		{
			get
			{
				return (global::Windows.Foundation.Point)this.GetValue(NormalizedAnchorPointProperty);
			}
			set
			{
				this.SetValue(NormalizedAnchorPointProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Geolocation.Geopoint Location
		{
			get
			{
				return (global::Windows.Devices.Geolocation.Geopoint)this.GetValue(LocationProperty);
			}
			set
			{
				this.SetValue(LocationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Storage.Streams.IRandomAccessStreamReference Image
		{
			get
			{
				throw new global::System.NotImplementedException("The member IRandomAccessStreamReference MapIcon.Image is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.MapIcon", "IRandomAccessStreamReference MapIcon.Image");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Maps.MapElementCollisionBehavior CollisionBehaviorDesired
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Maps.MapElementCollisionBehavior)this.GetValue(CollisionBehaviorDesiredProperty);
			}
			set
			{
				this.SetValue(CollisionBehaviorDesiredProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LocationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Location", typeof(global::Windows.Devices.Geolocation.Geopoint), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapIcon), 
			new FrameworkPropertyMetadata(default(global::Windows.Devices.Geolocation.Geopoint)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty NormalizedAnchorPointProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"NormalizedAnchorPoint", typeof(global::Windows.Foundation.Point), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapIcon), 
			new FrameworkPropertyMetadata(default(global::Windows.Foundation.Point)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TitleProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Title", typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapIcon), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CollisionBehaviorDesiredProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"CollisionBehaviorDesired", typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapElementCollisionBehavior), 
			typeof(global::Microsoft.UI.Xaml.Controls.Maps.MapIcon), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Maps.MapElementCollisionBehavior)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MapIcon() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.MapIcon", "MapIcon.MapIcon()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.MapIcon()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.Location.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.Location.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.Title.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.Title.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.NormalizedAnchorPoint.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.NormalizedAnchorPoint.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.Image.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.Image.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.CollisionBehaviorDesired.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.CollisionBehaviorDesired.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.CollisionBehaviorDesiredProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.LocationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.TitleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.MapIcon.NormalizedAnchorPointProperty.get
	}
}
