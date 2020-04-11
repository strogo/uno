using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.UI.Xaml.Controls.Primitives;

namespace Microsoft.UI.Xaml.Controls
{
    public partial class GridViewItem : SelectorItem
	{
		public GridViewItem()
		{
			Initialize();
		}

		partial void Initialize();

		public global::Microsoft.UI.Xaml.Controls.Primitives.GridViewItemTemplateSettings TemplateSettings { get; } = new Primitives.GridViewItemTemplateSettings();
	}
}
