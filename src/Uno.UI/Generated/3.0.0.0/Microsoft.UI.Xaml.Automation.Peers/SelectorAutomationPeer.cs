#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SelectorAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.ISelectionProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanSelectMultiple
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SelectorAutomationPeer.CanSelectMultiple is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsSelectionRequired
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SelectorAutomationPeer.IsSelectionRequired is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SelectorAutomationPeer( global::Microsoft.UI.Xaml.Controls.Primitives.Selector owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.SelectorAutomationPeer", "SelectorAutomationPeer.SelectorAutomationPeer(Selector owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.SelectorAutomationPeer.SelectorAutomationPeer(Microsoft.UI.Xaml.Controls.Primitives.Selector)
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.SelectorAutomationPeer.CanSelectMultiple.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.SelectorAutomationPeer.IsSelectionRequired.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Automation.Provider.IRawElementProviderSimple[] GetSelection()
		{
			throw new global::System.NotImplementedException("The member IRawElementProviderSimple[] SelectorAutomationPeer.GetSelection() is not implemented in Uno.");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Automation.Provider.ISelectionProvider
	}
}
