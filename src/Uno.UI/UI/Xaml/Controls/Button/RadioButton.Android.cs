﻿using Android.Views;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Uno.Extensions;
using Uno.UI;
using Microsoft.UI.Xaml.Controls.Primitives;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class RadioButton : ToggleButton
	{
		private IEnumerable<RadioButton> GetOtherHierarchicalGroupMembers()
		{
			return (Parent as ViewGroup)?
				.GetChildren()
				.OfType<RadioButton>()
				.Where(rb => rb != this)
				?? Enumerable.Empty<RadioButton>();
		}
	}
}
