#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CalendarDatePickerAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.IInvokeProvider,global::Microsoft.UI.Xaml.Automation.Provider.IValueProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsReadOnly
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CalendarDatePickerAutomationPeer.IsReadOnly is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CalendarDatePickerAutomationPeer.Value is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public CalendarDatePickerAutomationPeer( global::Microsoft.UI.Xaml.Controls.CalendarDatePicker owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.CalendarDatePickerAutomationPeer", "CalendarDatePickerAutomationPeer.CalendarDatePickerAutomationPeer(CalendarDatePicker owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.CalendarDatePickerAutomationPeer.CalendarDatePickerAutomationPeer(Microsoft.UI.Xaml.Controls.CalendarDatePicker)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Invoke()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.CalendarDatePickerAutomationPeer", "void CalendarDatePickerAutomationPeer.Invoke()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.CalendarDatePickerAutomationPeer.IsReadOnly.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.CalendarDatePickerAutomationPeer.Value.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetValue( string value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.CalendarDatePickerAutomationPeer", "void CalendarDatePickerAutomationPeer.SetValue(string value)");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IInvokeProvider
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IValueProvider
	}
}
