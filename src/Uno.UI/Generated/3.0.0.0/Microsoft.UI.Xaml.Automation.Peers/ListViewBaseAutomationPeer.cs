#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ListViewBaseAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.SelectorAutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.IDropTargetProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string DropEffect
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ListViewBaseAutomationPeer.DropEffect is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string[] DropEffects
		{
			get
			{
				throw new global::System.NotImplementedException("The member string[] ListViewBaseAutomationPeer.DropEffects is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ListViewBaseAutomationPeer( global::Microsoft.UI.Xaml.Controls.ListViewBase owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer", "ListViewBaseAutomationPeer.ListViewBaseAutomationPeer(ListViewBase owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer.ListViewBaseAutomationPeer(Microsoft.UI.Xaml.Controls.ListViewBase)
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer.DropEffect.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer.DropEffects.get
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IDropTargetProvider
	}
}
