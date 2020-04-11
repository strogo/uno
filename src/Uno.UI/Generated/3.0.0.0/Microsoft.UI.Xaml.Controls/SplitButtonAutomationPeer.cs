#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SplitButtonAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.IExpandCollapseProvider,global::Microsoft.UI.Xaml.Automation.Provider.IInvokeProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Automation.ExpandCollapseState ExpandCollapseState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ExpandCollapseState SplitButtonAutomationPeer.ExpandCollapseState is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public SplitButtonAutomationPeer( global::Microsoft.UI.Xaml.Controls.SplitButton owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.SplitButtonAutomationPeer", "SplitButtonAutomationPeer.SplitButtonAutomationPeer(SplitButton owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SplitButtonAutomationPeer.SplitButtonAutomationPeer(Microsoft.UI.Xaml.Controls.SplitButton)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.SplitButtonAutomationPeer.ExpandCollapseState.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Collapse()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.SplitButtonAutomationPeer", "void SplitButtonAutomationPeer.Collapse()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Expand()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.SplitButtonAutomationPeer", "void SplitButtonAutomationPeer.Expand()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Invoke()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.SplitButtonAutomationPeer", "void SplitButtonAutomationPeer.Invoke()");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IExpandCollapseProvider
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IInvokeProvider
	}
}
