using Microsoft.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Automation.Peers
{
	public  partial class ToggleSwitchAutomationPeer : FrameworkElementAutomationPeer, Provider.IToggleProvider
	{
		public ToggleSwitchAutomationPeer(ToggleSwitch owner) : base(owner)
		{
		}
		
		protected override string GetClassNameCore()
		{
			return "ToggleSwitch";
		}

		protected override AutomationControlType GetAutomationControlTypeCore()
		{
			return AutomationControlType.Button;
		}

		public ToggleState ToggleState => ((ToggleSwitch)Owner).IsOn ? ToggleState.On : ToggleState.Off;
		
		public void Toggle()
		{
			if (IsEnabled())
			{
				((ToggleSwitch)Owner).AutomationPeerToggle();
			}
		}
	}
}
