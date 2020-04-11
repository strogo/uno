using System.Drawing;
using System.Linq;
using Uno.Extensions;
using Uno;
using Microsoft.UI.Xaml.Controls;
using System;
using Uno.Disposables;
using System.Collections.Generic;
using Microsoft.UI.Xaml.Controls.Primitives;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class RadioButton : ToggleButton
	{
		private IEnumerable<RadioButton> GetOtherHierarchicalGroupMembers()
		{
			return Superview?
					.Subviews
					.OfType<RadioButton>()
					.Where(rb => rb != this)
					?? Enumerable.Empty<RadioButton>();
		}
	}
}

