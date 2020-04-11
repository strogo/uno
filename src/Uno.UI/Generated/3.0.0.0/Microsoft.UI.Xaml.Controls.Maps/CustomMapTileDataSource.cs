#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CustomMapTileDataSource : global::Microsoft.UI.Xaml.Controls.Maps.MapTileDataSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public CustomMapTileDataSource() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.CustomMapTileDataSource", "CustomMapTileDataSource.CustomMapTileDataSource()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.CustomMapTileDataSource.CustomMapTileDataSource()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.CustomMapTileDataSource.BitmapRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Maps.CustomMapTileDataSource.BitmapRequested.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Maps.CustomMapTileDataSource, global::Microsoft.UI.Xaml.Controls.Maps.MapTileBitmapRequestedEventArgs> BitmapRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.CustomMapTileDataSource", "event TypedEventHandler<CustomMapTileDataSource, MapTileBitmapRequestedEventArgs> CustomMapTileDataSource.BitmapRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Maps.CustomMapTileDataSource", "event TypedEventHandler<CustomMapTileDataSource, MapTileBitmapRequestedEventArgs> CustomMapTileDataSource.BitmapRequested");
			}
		}
		#endif
	}
}
