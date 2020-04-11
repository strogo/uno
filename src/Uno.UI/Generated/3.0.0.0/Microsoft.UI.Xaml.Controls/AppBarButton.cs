#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppBarButton : global::Microsoft.UI.Xaml.Controls.Button,global::Microsoft.UI.Xaml.Controls.ICommandBarElement,global::Microsoft.UI.Xaml.Controls.ICommandBarElement2
	{
		#if false || false || false || false || false
		[global::Uno.NotImplemented]
		public  string Label
		{
			get
			{
				return (string)this.GetValue(LabelProperty);
			}
			set
			{
				this.SetValue(LabelProperty, value);
			}
		}
		#endif
		#if false || false || false || false || false
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.IconElement Icon
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.IconElement)this.GetValue(IconProperty);
			}
			set
			{
				this.SetValue(IconProperty, value);
			}
		}
		#endif
		#if false || false || false || false || false
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.CommandBarLabelPosition LabelPosition
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.CommandBarLabelPosition)this.GetValue(LabelPositionProperty);
			}
			set
			{
				this.SetValue(LabelPositionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string KeyboardAcceleratorTextOverride
		{
			get
			{
				return (string)this.GetValue(KeyboardAcceleratorTextOverrideProperty);
			}
			set
			{
				this.SetValue(KeyboardAcceleratorTextOverrideProperty, value);
			}
		}
		#endif
		#if false || false || false || false || false
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
		#if false || false || false || false || false
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
		#if false || false || false || false || false
		[global::Uno.NotImplemented]
		public  bool IsInOverflow
		{
			get
			{
				return (bool)this.GetValue(IsInOverflowProperty);
			}
		}
		#endif
		#if false || false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IconProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Icon", typeof(global::Microsoft.UI.Xaml.Controls.IconElement), 
			typeof(global::Microsoft.UI.Xaml.Controls.AppBarButton), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.IconElement)));
		#endif
		#if false || false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsCompactProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsCompact", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.AppBarButton), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if false || false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LabelProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Label", typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Controls.AppBarButton), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if false || false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DynamicOverflowOrderProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"DynamicOverflowOrder", typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.AppBarButton), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if false || false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsInOverflowProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsInOverflow", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.AppBarButton), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if false || false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty LabelPositionProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"LabelPosition", typeof(global::Microsoft.UI.Xaml.Controls.CommandBarLabelPosition), 
			typeof(global::Microsoft.UI.Xaml.Controls.AppBarButton), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.CommandBarLabelPosition)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty KeyboardAcceleratorTextOverrideProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"KeyboardAcceleratorTextOverride", typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Controls.AppBarButton), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if false || false || false || __WASM__ || false
		[global::Uno.NotImplemented]
		public AppBarButton() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.AppBarButton", "AppBarButton.AppBarButton()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.AppBarButton()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.Label.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.Label.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.Icon.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.Icon.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.LabelPosition.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.LabelPosition.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.KeyboardAcceleratorTextOverride.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.KeyboardAcceleratorTextOverride.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.TemplateSettings.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.IsCompact.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.IsCompact.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.IsInOverflow.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.DynamicOverflowOrder.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.DynamicOverflowOrder.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.KeyboardAcceleratorTextOverrideProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.LabelPositionProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.IsInOverflowProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.DynamicOverflowOrderProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.LabelProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.IconProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.AppBarButton.IsCompactProperty.get
		// Processing: Microsoft.UI.Xaml.Controls.ICommandBarElement
		// Processing: Microsoft.UI.Xaml.Controls.ICommandBarElement2
	}
}
