#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ListViewAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ListViewAutomationPeer( global::Microsoft.UI.Xaml.Controls.ListView owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.ListViewAutomationPeer", "ListViewAutomationPeer.ListViewAutomationPeer(ListView owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.ListViewAutomationPeer.ListViewAutomationPeer(Microsoft.UI.Xaml.Controls.ListView)
	}
}
