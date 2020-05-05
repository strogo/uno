﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using Foundation;
using CoreAnimation;
using CoreGraphics;
using Uno.UI;
using Size = Windows.Foundation.Size;

namespace Microsoft.UI.Xaml.Shapes
{
	public partial class Ellipse : ArbitraryShapeBase
	{
		public Ellipse()
		{
		}

		protected override CGPath GetPath(Size availableSize)
		{
			var calculatedBounds = this.ApplySizeConstraints(availableSize);

			var strokeThickness = (nfloat)this.ActualStrokeThickness;

			var area = new CGRect(
				x: 0,
				y: 0,

				//In ios we need to inflate the bounds because the stroke thickness is not taken into account when
				//forming the ellipse from rect.
				width: calculatedBounds.Width - strokeThickness,
				height: calculatedBounds.Height - strokeThickness
			);

			return CGPath.EllipseFromRect(area);
		}
	}
}
