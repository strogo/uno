#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class DataTemplateSelector : global::Microsoft.UI.Xaml.IElementFactory
	{
		// Skipping already declared method Microsoft.UI.Xaml.Controls.DataTemplateSelector.DataTemplateSelector()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.DataTemplateSelector.DataTemplateSelector()
		// Skipping already declared method Microsoft.UI.Xaml.Controls.DataTemplateSelector.SelectTemplate(object, Microsoft.UI.Xaml.DependencyObject)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.DataTemplateSelector.SelectTemplate(object)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.DataTemplateSelector.SelectTemplateCore(object, Microsoft.UI.Xaml.DependencyObject)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.DataTemplateSelector.SelectTemplateCore(object)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.UIElement GetElement( global::Microsoft.UI.Xaml.ElementFactoryGetArgs args)
		{
			throw new global::System.NotImplementedException("The member UIElement DataTemplateSelector.GetElement(ElementFactoryGetArgs args) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void RecycleElement( global::Microsoft.UI.Xaml.ElementFactoryRecycleArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.DataTemplateSelector", "void DataTemplateSelector.RecycleElement(ElementFactoryRecycleArgs args)");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.IElementFactory
	}
}
