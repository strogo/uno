#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Image 
	{
		#if false || false || NET461 || false || false
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Stretch Stretch
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Stretch)this.GetValue(StretchProperty);
			}
			set
			{
				this.SetValue(StretchProperty, value);
			}
		}
		#endif
		#if false || false || NET461 || false || false
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.ImageSource Source
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.ImageSource)this.GetValue(SourceProperty);
			}
			set
			{
				this.SetValue(SourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Thickness NineGrid
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Thickness)this.GetValue(NineGridProperty);
			}
			set
			{
				this.SetValue(NineGridProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.PlayTo.PlayToSource PlayToSource
		{
			get
			{
				return (global::Windows.Media.PlayTo.PlayToSource)this.GetValue(PlayToSourceProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty NineGridProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"NineGrid", typeof(global::Microsoft.UI.Xaml.Thickness), 
			typeof(global::Microsoft.UI.Xaml.Controls.Image), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Thickness)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PlayToSourceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"PlayToSource", typeof(global::Windows.Media.PlayTo.PlayToSource), 
			typeof(global::Microsoft.UI.Xaml.Controls.Image), 
			new FrameworkPropertyMetadata(default(global::Windows.Media.PlayTo.PlayToSource)));
		#endif
		#if false || false || NET461 || false || false
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SourceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Source", typeof(global::Microsoft.UI.Xaml.Media.ImageSource), 
			typeof(global::Microsoft.UI.Xaml.Controls.Image), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.ImageSource)));
		#endif
		#if false || false || NET461 || false || false
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty StretchProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Stretch", typeof(global::Microsoft.UI.Xaml.Media.Stretch), 
			typeof(global::Microsoft.UI.Xaml.Controls.Image), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Stretch)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Image.Image()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.Image()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.Source.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.Source.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.Stretch.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.Stretch.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.NineGrid.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.NineGrid.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.PlayToSource.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.ImageFailed.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.ImageFailed.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.ImageOpened.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.ImageOpened.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Casting.CastingSource GetAsCastingSource()
		{
			throw new global::System.NotImplementedException("The member CastingSource Image.GetAsCastingSource() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.CompositionBrush GetAlphaMask()
		{
			throw new global::System.NotImplementedException("The member CompositionBrush Image.GetAlphaMask() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.SourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.StretchProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.NineGridProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Image.PlayToSourceProperty.get
		#if false || false || NET461 || false || false
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.ExceptionRoutedEventHandler ImageFailed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Image", "event ExceptionRoutedEventHandler Image.ImageFailed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Image", "event ExceptionRoutedEventHandler Image.ImageFailed");
			}
		}
		#endif
		#if false || false || NET461 || false || false
		[global::Uno.NotImplemented]
		public  event global::Microsoft.UI.Xaml.RoutedEventHandler ImageOpened
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Image", "event RoutedEventHandler Image.ImageOpened");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Image", "event RoutedEventHandler Image.ImageOpened");
			}
		}
		#endif
	}
}
