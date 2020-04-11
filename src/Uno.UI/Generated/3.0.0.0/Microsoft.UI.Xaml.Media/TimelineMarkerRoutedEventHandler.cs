#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	public delegate void TimelineMarkerRoutedEventHandler(object @sender, global::Microsoft.UI.Xaml.Media.TimelineMarkerRoutedEventArgs @e);
	#endif
}
