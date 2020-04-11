#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PathIconSource : global::Microsoft.UI.Xaml.Controls.IconSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Media.Geometry Data
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Geometry)this.GetValue(DataProperty);
			}
			set
			{
				this.SetValue(DataProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DataProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Data", typeof(global::Microsoft.UI.Xaml.Media.Geometry), 
			typeof(global::Microsoft.UI.Xaml.Controls.PathIconSource), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Geometry)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public PathIconSource() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PathIconSource", "PathIconSource.PathIconSource()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PathIconSource.PathIconSource()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PathIconSource.Data.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PathIconSource.Data.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PathIconSource.DataProperty.get
	}
}
