﻿using System.Linq;
using Windows.Foundation;
using Microsoft.UI.Xaml.Wasm;
using Uno.Extensions;

namespace Microsoft.UI.Xaml.Shapes
{
	partial class Polygon
	{
		private readonly SvgElement _polygon = new SvgElement("polygon");

		public Polygon()
		{
			SvgChildren.Add(_polygon);

			InitCommonShapeProperties();
		}

		protected override SvgElement GetMainSvgElement()
		{
			return _polygon;
		}

		partial void OnPointsChanged()
		{
			var points = string.Join(" ", Points.Select(p => $"{p.X.ToStringInvariant()},{p.Y.ToStringInvariant()}"));
			_polygon.SetAttribute("points", points);
		}
	}
}
