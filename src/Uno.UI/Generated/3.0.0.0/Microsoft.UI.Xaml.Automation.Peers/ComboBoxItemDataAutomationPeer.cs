#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ComboBoxItemDataAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.IScrollItemProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ComboBoxItemDataAutomationPeer( object item,  global::Microsoft.UI.Xaml.Automation.Peers.ComboBoxAutomationPeer parent) : base(item, parent)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.ComboBoxItemDataAutomationPeer", "ComboBoxItemDataAutomationPeer.ComboBoxItemDataAutomationPeer(object item, ComboBoxAutomationPeer parent)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.ComboBoxItemDataAutomationPeer.ComboBoxItemDataAutomationPeer(object, Microsoft.UI.Xaml.Automation.Peers.ComboBoxAutomationPeer)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ScrollIntoView()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.ComboBoxItemDataAutomationPeer", "void ComboBoxItemDataAutomationPeer.ScrollIntoView()");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IScrollItemProvider
	}
}
