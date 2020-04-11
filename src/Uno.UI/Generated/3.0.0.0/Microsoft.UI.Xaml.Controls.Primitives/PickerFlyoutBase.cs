#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public partial class PickerFlyoutBase : global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty TitleProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"Title", typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.PickerFlyoutBase), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected PickerFlyoutBase() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.PickerFlyoutBase", "PickerFlyoutBase.PickerFlyoutBase()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.PickerFlyoutBase.PickerFlyoutBase()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnConfirmed()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.PickerFlyoutBase", "void PickerFlyoutBase.OnConfirmed()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual bool ShouldShowConfirmationButtons()
		{
			throw new global::System.NotImplementedException("The member bool PickerFlyoutBase.ShouldShowConfirmationButtons() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.PickerFlyoutBase.TitleProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static string GetTitle( global::Microsoft.UI.Xaml.DependencyObject element)
		{
			return (string)element.GetValue(TitleProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void SetTitle( global::Microsoft.UI.Xaml.DependencyObject element,  string value)
		{
			element.SetValue(TitleProperty, value);
		}
		#endif
	}
}
