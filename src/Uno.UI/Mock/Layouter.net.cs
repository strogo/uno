﻿using System;
using System.Collections.Generic;
using Windows.Foundation;
using System.Linq;
using Uno.Disposables;
using System.Text;
using System.Threading.Tasks;
using Uno.Extensions;
using Uno;
using Uno.Logging;
using View = Microsoft.UI.Xaml.UIElement;
using Microsoft.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	partial class Layouter : ILayouter
	{
		protected Size MeasureChildOverride(View view, Size slotSize)
		{
			view.Measure(slotSize);

			return view.DesiredSize;
		}
		
		protected void ArrangeChildOverride(View view, Rect frame)
		{
			view.Arranged = frame;
			view.LayoutSlotWithMarginsAndAlignments = frame;
			view.LayoutSlot = frame;
		}

		protected Size DesiredChildSize(View view)
		{
			return view.DesiredSize;
		}

		Size ILayouter.GetDesiredSize(View view) => DesiredChildSize(view);

		partial void SetDesiredChildSize(View view, Size size)
		{
			view.DesiredSize = size;
		}
	}
}
