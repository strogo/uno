#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LoopingSelectorItemAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.IScrollItemProvider,global::Microsoft.UI.Xaml.Automation.Provider.ISelectionItemProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsSelected
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool LoopingSelectorItemAutomationPeer.IsSelected is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Automation.Provider.IRawElementProviderSimple SelectionContainer
		{
			get
			{
				throw new global::System.NotImplementedException("The member IRawElementProviderSimple LoopingSelectorItemAutomationPeer.SelectionContainer is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void ScrollIntoView()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.LoopingSelectorItemAutomationPeer", "void LoopingSelectorItemAutomationPeer.ScrollIntoView()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.LoopingSelectorItemAutomationPeer.IsSelected.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.LoopingSelectorItemAutomationPeer.SelectionContainer.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void AddToSelection()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.LoopingSelectorItemAutomationPeer", "void LoopingSelectorItemAutomationPeer.AddToSelection()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void RemoveFromSelection()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.LoopingSelectorItemAutomationPeer", "void LoopingSelectorItemAutomationPeer.RemoveFromSelection()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Select()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.LoopingSelectorItemAutomationPeer", "void LoopingSelectorItemAutomationPeer.Select()");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IScrollItemProvider
		// Processing: Microsoft.UI.Xaml.Automation.Provider.ISelectionItemProvider
	}
}
