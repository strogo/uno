﻿using System;
using System.Collections.Generic;
using System.Text;
using CoreGraphics;
using Uno.Media;
using Windows.Foundation;


namespace Microsoft.UI.Xaml.Shapes
{
	public partial class Polyline
	{
		protected override CGPath GetPath(Size availableSize)
		{
			var coords = Points;

			if (coords != null)
			{
				var streamGeometry = GeometryHelper.Build(c =>
				{
					c.BeginFigure(new Point(coords[0].X, coords[0].Y), true, false);
					for (int i = 1; i < coords.Count; i++)
					{
						c.LineTo(new Point(coords[i].X, coords[i].Y), true, false);
					}
				});

				return streamGeometry.ToCGPath();
			}

			return null;
		}
	}
}
