#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TreeViewItemAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.ListViewItemAutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.IExpandCollapseProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Automation.ExpandCollapseState ExpandCollapseState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpandCollapseState TreeViewItemAutomationPeer.ExpandCollapseState is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public TreeViewItemAutomationPeer( global::Microsoft.UI.Xaml.Controls.TreeViewItem owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.TreeViewItemAutomationPeer", "TreeViewItemAutomationPeer.TreeViewItemAutomationPeer(TreeViewItem owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.TreeViewItemAutomationPeer.TreeViewItemAutomationPeer(Microsoft.UI.Xaml.Controls.TreeViewItem)
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.TreeViewItemAutomationPeer.ExpandCollapseState.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Collapse()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.TreeViewItemAutomationPeer", "void TreeViewItemAutomationPeer.Collapse()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Expand()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.TreeViewItemAutomationPeer", "void TreeViewItemAutomationPeer.Expand()");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IExpandCollapseProvider
	}
}
