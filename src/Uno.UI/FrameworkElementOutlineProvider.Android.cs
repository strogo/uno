﻿using Android.Graphics;
using Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Shapes;

namespace Uno.UI
{
    public class FrameworkElementOutlineProvider : ViewOutlineProvider
    {
		public override void GetOutline(View view, Outline outline)
		{
			var rect = new RectF(0, 0, view.Width, view.Height);

			var cornerRadius = GetCornerRadius(view);

			var path = cornerRadius.GetOutlinePath(rect);

			outline.SetConvexPath(path);
		}

		private static CornerRadius GetCornerRadius(View view)
		{
			switch (view)
			{
				case Border border:
					return border.CornerRadius;
				case Panel panel:
					return panel.CornerRadius;
				case Control ctl:
					return ctl.CornerRadius;
				default:
					return CornerRadius.None;
			}
		}
	}
}
