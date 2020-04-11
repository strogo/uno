using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.UI.Xaml.Automation.Peers;
using Microsoft.UI.Xaml.Controls.Primitives;

namespace Microsoft.UI.Xaml.Controls
{
    public partial class CheckBox : ToggleButton
    {
		public CheckBox()
		{
			InitializeVisualStates();
		}

		protected override AutomationPeer OnCreateAutomationPeer()
		{
			return new CheckBoxAutomationPeer(this);
		}
	}
}