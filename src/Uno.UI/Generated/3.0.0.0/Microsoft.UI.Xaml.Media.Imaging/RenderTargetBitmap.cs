#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Imaging
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RenderTargetBitmap : global::Microsoft.UI.Xaml.Media.ImageSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int PixelHeight
		{
			get
			{
				return (int)this.GetValue(PixelHeightProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int PixelWidth
		{
			get
			{
				return (int)this.GetValue(PixelWidthProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PixelHeightProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"PixelHeight", typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Media.Imaging.RenderTargetBitmap), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PixelWidthProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"PixelWidth", typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Media.Imaging.RenderTargetBitmap), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RenderTargetBitmap() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Imaging.RenderTargetBitmap", "RenderTargetBitmap.RenderTargetBitmap()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Imaging.RenderTargetBitmap.RenderTargetBitmap()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Imaging.RenderTargetBitmap.PixelWidth.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Imaging.RenderTargetBitmap.PixelHeight.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncAction RenderAsync( global::Microsoft.UI.Xaml.UIElement element)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction RenderTargetBitmap.RenderAsync(UIElement element) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncAction RenderAsync( global::Microsoft.UI.Xaml.UIElement element,  int scaledWidth,  int scaledHeight)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction RenderTargetBitmap.RenderAsync(UIElement element, int scaledWidth, int scaledHeight) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.IBuffer> GetPixelsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IBuffer> RenderTargetBitmap.GetPixelsAsync() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Imaging.RenderTargetBitmap.PixelWidthProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Imaging.RenderTargetBitmap.PixelHeightProperty.get
	}
}
