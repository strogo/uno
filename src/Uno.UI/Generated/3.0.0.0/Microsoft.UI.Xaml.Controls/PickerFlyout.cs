#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PickerFlyout : global::Microsoft.UI.Xaml.Controls.Primitives.PickerFlyoutBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement Content
		{
			get
			{
				return (global::Microsoft.UI.Xaml.UIElement)this.GetValue(ContentProperty);
			}
			set
			{
				this.SetValue(ContentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool ConfirmationButtonsVisible
		{
			get
			{
				return (bool)this.GetValue(ConfirmationButtonsVisibleProperty);
			}
			set
			{
				this.SetValue(ConfirmationButtonsVisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ConfirmationButtonsVisibleProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ConfirmationButtonsVisible", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.PickerFlyout), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Content", typeof(global::Microsoft.UI.Xaml.UIElement), 
			typeof(global::Microsoft.UI.Xaml.Controls.PickerFlyout), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public PickerFlyout() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PickerFlyout", "PickerFlyout.PickerFlyout()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PickerFlyout.PickerFlyout()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PickerFlyout.Content.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PickerFlyout.Content.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PickerFlyout.ConfirmationButtonsVisible.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PickerFlyout.ConfirmationButtonsVisible.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PickerFlyout.Confirmed.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PickerFlyout.Confirmed.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<bool> ShowAtAsync( global::Microsoft.UI.Xaml.FrameworkElement target)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> PickerFlyout.ShowAtAsync(FrameworkElement target) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PickerFlyout.ContentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PickerFlyout.ConfirmationButtonsVisibleProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.PickerFlyout, global::Microsoft.UI.Xaml.Controls.PickerConfirmedEventArgs> Confirmed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PickerFlyout", "event TypedEventHandler<PickerFlyout, PickerConfirmedEventArgs> PickerFlyout.Confirmed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PickerFlyout", "event TypedEventHandler<PickerFlyout, PickerConfirmedEventArgs> PickerFlyout.Confirmed");
			}
		}
		#endif
	}
}
