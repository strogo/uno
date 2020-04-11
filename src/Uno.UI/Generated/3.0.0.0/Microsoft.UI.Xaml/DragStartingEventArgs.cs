#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DragStartingEventArgs : global::Microsoft.UI.Xaml.RoutedEventArgs
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Cancel
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DragStartingEventArgs.Cancel is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.DragStartingEventArgs", "bool DragStartingEventArgs.Cancel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.DataTransfer.DataPackage Data
		{
			get
			{
				throw new global::System.NotImplementedException("The member DataPackage DragStartingEventArgs.Data is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DragUI DragUI
		{
			get
			{
				throw new global::System.NotImplementedException("The member DragUI DragStartingEventArgs.DragUI is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.DataTransfer.DataPackageOperation AllowedOperations
		{
			get
			{
				throw new global::System.NotImplementedException("The member DataPackageOperation DragStartingEventArgs.AllowedOperations is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.DragStartingEventArgs", "DataPackageOperation DragStartingEventArgs.AllowedOperations");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.DragStartingEventArgs.Cancel.get
		// Forced skipping of method Microsoft.UI.Xaml.DragStartingEventArgs.Cancel.set
		// Forced skipping of method Microsoft.UI.Xaml.DragStartingEventArgs.Data.get
		// Forced skipping of method Microsoft.UI.Xaml.DragStartingEventArgs.DragUI.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DragOperationDeferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member DragOperationDeferral DragStartingEventArgs.GetDeferral() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Point GetPosition( global::Microsoft.UI.Xaml.UIElement relativeTo)
		{
			throw new global::System.NotImplementedException("The member Point DragStartingEventArgs.GetPosition(UIElement relativeTo) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.DragStartingEventArgs.AllowedOperations.get
		// Forced skipping of method Microsoft.UI.Xaml.DragStartingEventArgs.AllowedOperations.set
	}
}
