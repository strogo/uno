#if NET461
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	abstract partial class VirtualizingPanelLayout
	{
		public abstract Orientation ScrollOrientation { get; }

		public Orientation Orientation { get; set; }
	}
}
#endif
