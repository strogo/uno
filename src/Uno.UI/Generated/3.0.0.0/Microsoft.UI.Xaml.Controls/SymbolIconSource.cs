#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SymbolIconSource : global::Microsoft.UI.Xaml.Controls.IconSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.Symbol Symbol
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Symbol)this.GetValue(SymbolProperty);
			}
			set
			{
				this.SetValue(SymbolProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SymbolProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Symbol", typeof(global::Microsoft.UI.Xaml.Controls.Symbol), 
			typeof(global::Microsoft.UI.Xaml.Controls.SymbolIconSource), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Symbol)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SymbolIconSource() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.SymbolIconSource", "SymbolIconSource.SymbolIconSource()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SymbolIconSource.SymbolIconSource()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SymbolIconSource.Symbol.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SymbolIconSource.Symbol.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SymbolIconSource.SymbolProperty.get
	}
}
