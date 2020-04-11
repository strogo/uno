#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Shapes
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Polyline
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.FillRule FillRule
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.FillRule)this.GetValue(FillRuleProperty);
			}
			set
			{
				this.SetValue(FillRuleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty FillRuleProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"FillRule", typeof(global::Microsoft.UI.Xaml.Media.FillRule), 
			typeof(global::Microsoft.UI.Xaml.Shapes.Polyline), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.FillRule)));
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Polyline.Polyline()
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Polyline.FillRule.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Polyline.FillRule.set
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Polyline.Points.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Polyline.Points.set
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Polyline.FillRuleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Shapes.Polyline.PointsProperty.get
	}
}
