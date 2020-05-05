﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.Foundation;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	public partial class CarouselPanel : VirtualizingPanel
	{
		private readonly ItemsStackPanelLayout _layout = new ItemsStackPanelLayout();
		
		public CarouselPanel()
		{
			_layout.Initialize(this);
		}

		protected override Size MeasureOverride(Size availableSize) => _layout.MeasureOverride(availableSize);

		protected override Size ArrangeOverride(Size finalSize) => _layout.ArrangeOverride(finalSize);

		private protected override VirtualizingPanelLayout GetLayouterCore() => _layout;
	}
}
