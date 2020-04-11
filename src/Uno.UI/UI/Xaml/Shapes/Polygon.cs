using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Collections;

namespace Microsoft.UI.Xaml.Shapes
{
	public partial class Polygon : ArbitraryShapeBase
	{
		#region Points

		public PointCollection Points
		{
			get { return (PointCollection)GetValue(PointsProperty); }
			set { SetValue(PointsProperty, value); }
		}

		public static global::Microsoft.UI.Xaml.DependencyProperty PointsProperty { get; } =
			DependencyProperty.Register(
				"Points", typeof(global::Microsoft.UI.Xaml.Media.PointCollection),
				typeof(global::Microsoft.UI.Xaml.Shapes.Polygon),
				new FrameworkPropertyMetadata(
					defaultValue: default(global::Microsoft.UI.Xaml.Media.PointCollection),
					options: FrameworkPropertyMetadataOptions.LogicalChild | FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange,
					propertyChangedCallback: (s, e) => ((Polygon)s).OnPointsChanged()
				)
			);

		partial void OnPointsChanged();

		#endregion

		protected internal override IEnumerable<object> GetShapeParameters()
		{
			yield return Points?.ToArray();

			foreach (var p in base.GetShapeParameters())
			{
				yield return p;
			}
		}
	}
}
