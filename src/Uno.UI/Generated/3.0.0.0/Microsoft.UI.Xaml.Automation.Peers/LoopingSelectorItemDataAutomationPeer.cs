#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LoopingSelectorItemDataAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.AutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.IVirtualizedItemProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Realize()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.LoopingSelectorItemDataAutomationPeer", "void LoopingSelectorItemDataAutomationPeer.Realize()");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IVirtualizedItemProvider
	}
}
