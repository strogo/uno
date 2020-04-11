#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IItemContainerMapping 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		object ItemFromContainer( global::Microsoft.UI.Xaml.DependencyObject container);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.DependencyObject ContainerFromItem( object item);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		int IndexFromContainer( global::Microsoft.UI.Xaml.DependencyObject container);
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		global::Microsoft.UI.Xaml.DependencyObject ContainerFromIndex( int index);
		#endif
	}
}
