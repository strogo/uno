﻿using System;
using System.Linq;
using Windows.Foundation;
using Microsoft.UI.Xaml.Wasm;
using Uno;
using Uno.Extensions;
using Microsoft.UI.Xaml.Media;
using System.Collections.Generic;

namespace Microsoft.UI.Xaml.Shapes
{
	partial class Polyline
	{
		private readonly SvgElement _polyline = new SvgElement("polyline");

		public Polyline()
		{
			SvgChildren.Add(_polyline);

			InitCommonShapeProperties();
		}

		protected override SvgElement GetMainSvgElement()
		{
			return _polyline;
		}

		partial void OnPointsChanged()
		{
			var points = string.Join(" ", Points.Select(p => $"{p.X.ToStringInvariant()},{p.Y.ToStringInvariant()}"));
			_polyline.SetAttribute("points", points);
		}
	}
}
