#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FlipViewAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.SelectorAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public FlipViewAutomationPeer( global::Microsoft.UI.Xaml.Controls.FlipView owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.FlipViewAutomationPeer", "FlipViewAutomationPeer.FlipViewAutomationPeer(FlipView owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.FlipViewAutomationPeer.FlipViewAutomationPeer(Microsoft.UI.Xaml.Controls.FlipView)
	}
}
