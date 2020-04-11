#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RatingItemImageInfo : global::Microsoft.UI.Xaml.Controls.RatingItemInfo
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.ImageSource UnsetImage
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.ImageSource)this.GetValue(UnsetImageProperty);
			}
			set
			{
				this.SetValue(UnsetImageProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.ImageSource PointerOverPlaceholderImage
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.ImageSource)this.GetValue(PointerOverPlaceholderImageProperty);
			}
			set
			{
				this.SetValue(PointerOverPlaceholderImageProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.ImageSource PointerOverImage
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.ImageSource)this.GetValue(PointerOverImageProperty);
			}
			set
			{
				this.SetValue(PointerOverImageProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.ImageSource PlaceholderImage
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.ImageSource)this.GetValue(PlaceholderImageProperty);
			}
			set
			{
				this.SetValue(PlaceholderImageProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.ImageSource Image
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.ImageSource)this.GetValue(ImageProperty);
			}
			set
			{
				this.SetValue(ImageProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.ImageSource DisabledImage
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.ImageSource)this.GetValue(DisabledImageProperty);
			}
			set
			{
				this.SetValue(DisabledImageProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DisabledImageProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"DisabledImage", typeof(global::Microsoft.UI.Xaml.Media.ImageSource), 
			typeof(global::Microsoft.UI.Xaml.Controls.RatingItemImageInfo), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.ImageSource)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ImageProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Image", typeof(global::Microsoft.UI.Xaml.Media.ImageSource), 
			typeof(global::Microsoft.UI.Xaml.Controls.RatingItemImageInfo), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.ImageSource)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PlaceholderImageProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"PlaceholderImage", typeof(global::Microsoft.UI.Xaml.Media.ImageSource), 
			typeof(global::Microsoft.UI.Xaml.Controls.RatingItemImageInfo), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.ImageSource)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PointerOverImageProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"PointerOverImage", typeof(global::Microsoft.UI.Xaml.Media.ImageSource), 
			typeof(global::Microsoft.UI.Xaml.Controls.RatingItemImageInfo), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.ImageSource)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PointerOverPlaceholderImageProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"PointerOverPlaceholderImage", typeof(global::Microsoft.UI.Xaml.Media.ImageSource), 
			typeof(global::Microsoft.UI.Xaml.Controls.RatingItemImageInfo), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.ImageSource)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty UnsetImageProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"UnsetImage", typeof(global::Microsoft.UI.Xaml.Media.ImageSource), 
			typeof(global::Microsoft.UI.Xaml.Controls.RatingItemImageInfo), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.ImageSource)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RatingItemImageInfo() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RatingItemImageInfo", "RatingItemImageInfo.RatingItemImageInfo()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.RatingItemImageInfo()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.DisabledImage.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.DisabledImage.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.Image.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.Image.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.PlaceholderImage.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.PlaceholderImage.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.PointerOverImage.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.PointerOverImage.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.PointerOverPlaceholderImage.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.PointerOverPlaceholderImage.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.UnsetImage.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.UnsetImage.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.DisabledImageProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.ImageProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.PlaceholderImageProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.PointerOverImageProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.PointerOverPlaceholderImageProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RatingItemImageInfo.UnsetImageProperty.get
	}
}
