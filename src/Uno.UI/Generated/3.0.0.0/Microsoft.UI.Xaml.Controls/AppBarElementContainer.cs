#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppBarElementContainer : global::Microsoft.UI.Xaml.Controls.ContentControl,global::Microsoft.UI.Xaml.Controls.ICommandBarElement,global::Microsoft.UI.Xaml.Controls.ICommandBarElement2
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsCompact
		{
			get
			{
				return (bool)this.GetValue(IsCompactProperty);
			}
			set
			{
				this.SetValue(IsCompactProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int DynamicOverflowOrder
		{
			get
			{
				return (int)this.GetValue(DynamicOverflowOrderProperty);
			}
			set
			{
				this.SetValue(DynamicOverflowOrderProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsInOverflow
		{
			get
			{
				return (bool)this.GetValue(IsInOverflowProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DynamicOverflowOrderProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"DynamicOverflowOrder", typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.AppBarElementContainer), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsCompactProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsCompact", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.AppBarElementContainer), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsInOverflowProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsInOverflow", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.AppBarElementContainer), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public AppBarElementContainer() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.AppBarElementContainer", "AppBarElementContainer.AppBarElementContainer()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarElementContainer.AppBarElementContainer()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarElementContainer.IsCompact.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarElementContainer.IsCompact.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarElementContainer.IsInOverflow.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarElementContainer.DynamicOverflowOrder.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarElementContainer.DynamicOverflowOrder.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarElementContainer.IsCompactProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarElementContainer.IsInOverflowProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarElementContainer.DynamicOverflowOrderProperty.get
		// Processing: Microsoft.UI.Xaml.Controls.ICommandBarElement
		// Processing: Microsoft.UI.Xaml.Controls.ICommandBarElement2
	}
}
