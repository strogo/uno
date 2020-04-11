#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class DatePickerFlyoutItem : global::Microsoft.UI.Xaml.DependencyObject,global::Microsoft.UI.Xaml.Data.ICustomPropertyProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string SecondaryText
		{
			get
			{
				return (string)this.GetValue(SecondaryTextProperty);
			}
			set
			{
				this.SetValue(SecondaryTextProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string PrimaryText
		{
			get
			{
				return (string)this.GetValue(PrimaryTextProperty);
			}
			set
			{
				this.SetValue(PrimaryTextProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Type Type
		{
			get
			{
				throw new global::System.NotImplementedException("The member Type DatePickerFlyoutItem.Type is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PrimaryTextProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"PrimaryText", typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Controls.DatePickerFlyoutItem), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SecondaryTextProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"SecondaryText", typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Controls.DatePickerFlyoutItem), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.DatePickerFlyoutItem.PrimaryText.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.DatePickerFlyoutItem.PrimaryText.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.DatePickerFlyoutItem.SecondaryText.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.DatePickerFlyoutItem.SecondaryText.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Data.ICustomProperty GetCustomProperty( string name)
		{
			throw new global::System.NotImplementedException("The member ICustomProperty DatePickerFlyoutItem.GetCustomProperty(string name) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Data.ICustomProperty GetIndexedProperty( string name,  global::System.Type type)
		{
			throw new global::System.NotImplementedException("The member ICustomProperty DatePickerFlyoutItem.GetIndexedProperty(string name, Type type) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string GetStringRepresentation()
		{
			throw new global::System.NotImplementedException("The member string DatePickerFlyoutItem.GetStringRepresentation() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.DatePickerFlyoutItem.Type.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.DatePickerFlyoutItem.PrimaryTextProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.DatePickerFlyoutItem.SecondaryTextProperty.get
		// Processing: Microsoft.UI.Xaml.Data.ICustomPropertyProvider
	}
}
