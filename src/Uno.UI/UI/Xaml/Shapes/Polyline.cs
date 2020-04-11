using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.UI.Xaml.Media;


namespace Microsoft.UI.Xaml.Shapes
{
	public partial class Polyline : ArbitraryShapeBase
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
				typeof(global::Microsoft.UI.Xaml.Shapes.Polyline),
				new FrameworkPropertyMetadata(
					defaultValue: default(global::Microsoft.UI.Xaml.Media.PointCollection),
				    options: FrameworkPropertyMetadataOptions.LogicalChild | FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange,
					propertyChangedCallback: (s, e) => ((Polyline)s).OnPointsChanged()
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
