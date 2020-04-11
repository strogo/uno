#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ToggleSplitButtonAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.IExpandCollapseProvider,global::Microsoft.UI.Xaml.Automation.Provider.IToggleProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Automation.ExpandCollapseState ExpandCollapseState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpandCollapseState ToggleSplitButtonAutomationPeer.ExpandCollapseState is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Automation.ToggleState ToggleState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ToggleState ToggleSplitButtonAutomationPeer.ToggleState is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public ToggleSplitButtonAutomationPeer( global::Microsoft.UI.Xaml.Controls.ToggleSplitButton owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ToggleSplitButtonAutomationPeer", "ToggleSplitButtonAutomationPeer.ToggleSplitButtonAutomationPeer(ToggleSplitButton owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToggleSplitButtonAutomationPeer.ToggleSplitButtonAutomationPeer(Microsoft.UI.Xaml.Controls.ToggleSplitButton)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToggleSplitButtonAutomationPeer.ExpandCollapseState.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Collapse()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ToggleSplitButtonAutomationPeer", "void ToggleSplitButtonAutomationPeer.Collapse()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Expand()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ToggleSplitButtonAutomationPeer", "void ToggleSplitButtonAutomationPeer.Expand()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ToggleSplitButtonAutomationPeer.ToggleState.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Toggle()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ToggleSplitButtonAutomationPeer", "void ToggleSplitButtonAutomationPeer.Toggle()");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IExpandCollapseProvider
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IToggleProvider
	}
}
