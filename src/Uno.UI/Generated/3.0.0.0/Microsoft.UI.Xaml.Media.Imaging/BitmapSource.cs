#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Imaging
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class BitmapSource : global::Microsoft.UI.Xaml.Media.ImageSource
	{
		// Skipping already declared property PixelHeight
		// Skipping already declared property PixelWidth
		// Skipping already declared property PixelHeightProperty
		// Skipping already declared property PixelWidthProperty
		// Skipping already declared method Microsoft.UI.Xaml.Media.Imaging.BitmapSource.BitmapSource()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Imaging.BitmapSource.BitmapSource()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Imaging.BitmapSource.PixelWidth.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Imaging.BitmapSource.PixelHeight.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetSource( global::Windows.Storage.Streams.IRandomAccessStream streamSource)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Imaging.BitmapSource", "void BitmapSource.SetSource(IRandomAccessStream streamSource)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncAction SetSourceAsync( global::Windows.Storage.Streams.IRandomAccessStream streamSource)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction BitmapSource.SetSourceAsync(IRandomAccessStream streamSource) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Imaging.BitmapSource.PixelWidthProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Imaging.BitmapSource.PixelHeightProperty.get
	}
}
