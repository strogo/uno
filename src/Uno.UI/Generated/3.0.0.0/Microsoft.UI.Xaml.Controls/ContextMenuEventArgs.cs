#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContextMenuEventArgs : global::Microsoft.UI.Xaml.RoutedEventArgs
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ContextMenuEventArgs.Handled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ContextMenuEventArgs", "bool ContextMenuEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double CursorLeft
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ContextMenuEventArgs.CursorLeft is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double CursorTop
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ContextMenuEventArgs.CursorTop is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ContextMenuEventArgs.Handled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ContextMenuEventArgs.Handled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ContextMenuEventArgs.CursorLeft.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ContextMenuEventArgs.CursorTop.get
	}
}
