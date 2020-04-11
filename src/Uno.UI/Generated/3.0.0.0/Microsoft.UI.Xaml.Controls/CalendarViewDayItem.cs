#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CalendarViewDayItem : global::Microsoft.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsBlackout
		{
			get
			{
				return (bool)this.GetValue(IsBlackoutProperty);
			}
			set
			{
				this.SetValue(IsBlackoutProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.DateTimeOffset Date
		{
			get
			{
				return (global::System.DateTimeOffset)this.GetValue(DateProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DateProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Date", typeof(global::System.DateTimeOffset), 
			typeof(global::Microsoft.UI.Xaml.Controls.CalendarViewDayItem), 
			new FrameworkPropertyMetadata(default(global::System.DateTimeOffset)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsBlackoutProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsBlackout", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.CalendarViewDayItem), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public CalendarViewDayItem() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.CalendarViewDayItem", "CalendarViewDayItem.CalendarViewDayItem()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CalendarViewDayItem.CalendarViewDayItem()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CalendarViewDayItem.IsBlackout.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CalendarViewDayItem.IsBlackout.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CalendarViewDayItem.Date.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetDensityColors( global::System.Collections.Generic.IEnumerable<global::Windows.UI.Color> colors)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.CalendarViewDayItem", "void CalendarViewDayItem.SetDensityColors(IEnumerable<Color> colors)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CalendarViewDayItem.IsBlackoutProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CalendarViewDayItem.DateProperty.get
	}
}
