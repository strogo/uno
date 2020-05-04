﻿using Windows.UI.Xaml.Markup;
using Windows.Foundation;

namespace Windows.UI.Xaml.Media
{
	public partial class LinearGradientBrush : GradientBrush
	{
		public LinearGradientBrush()
		{
		}

		public LinearGradientBrush(
			GradientStopCollection gradientStopCollection,
			double angle)
		{
			GradientStops = gradientStopCollection;
		}

		public Point StartPoint
		{
			get => (Point)GetValue(StartPointProperty);
			set => SetValue(StartPointProperty, value);
		}
		public static readonly DependencyProperty StartPointProperty = DependencyProperty.Register(
			"StartPoint",
			typeof(Point),
			typeof(LinearGradientBrush),
			new PropertyMetadata(default(Point))
		);

		public Point EndPoint
		{
			get => (Point)GetValue(EndPointProperty);
			set => SetValue(EndPointProperty, value);
		}
		public static readonly DependencyProperty EndPointProperty = DependencyProperty.Register(
			"EndPoint",
			typeof(Point),
			typeof(LinearGradientBrush),
			new PropertyMetadata(new Point(1,1))
		);
	}
}
