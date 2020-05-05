﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.UI.Xaml.Shapes
{
	public partial class Line : ArbitraryShapeBase
	{
		public Line()
		{
			InitializePartial();
		}

		partial void InitializePartial();

		public double X1
		{
			get => (double)GetValue(X1Property);
			set => SetValue(X1Property, value);
		}

		public static global::Microsoft.UI.Xaml.DependencyProperty X1Property { get; } =
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"X1", typeof(double),
			typeof(global::Microsoft.UI.Xaml.Shapes.Line),
			new FrameworkPropertyMetadata(
				defaultValue: 0.0,
				options: FrameworkPropertyMetadataOptions.AffectsMeasure,
				propertyChangedCallback: OnX1PropertyChanged
			)
		);

		private static void OnX1PropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
		{
			if(dependencyObject is Line line)
			{
				line.OnX1PropertyChangedPartial((double)args.OldValue, (double)args.NewValue);
			}
		}

		partial void OnX1PropertyChangedPartial(double oldValue, double newValue);

		public double X2
		{
			get => (double)GetValue(X2Property);
			set => SetValue(X2Property, value);
		}

		public static global::Microsoft.UI.Xaml.DependencyProperty X2Property { get; } =
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"X2", typeof(double),
			typeof(global::Microsoft.UI.Xaml.Shapes.Line),
			new FrameworkPropertyMetadata(
				defaultValue: 0.0,
				options: FrameworkPropertyMetadataOptions.AffectsMeasure,
				propertyChangedCallback: OnX2PropertyChanged
			)
		);

		private static void OnX2PropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
		{
			if (dependencyObject is Line line)
			{
				line.OnX2PropertyChangedPartial((double)args.OldValue, (double)args.NewValue);
			}
		}
		partial void OnX2PropertyChangedPartial(double oldValue, double newValue);

		public double Y1
		{
			get => (double)GetValue(Y1Property);
			set => SetValue(Y1Property, value);
		}

		public static global::Microsoft.UI.Xaml.DependencyProperty Y1Property { get; } =
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Y1", typeof(double),
			typeof(global::Microsoft.UI.Xaml.Shapes.Line),
			new FrameworkPropertyMetadata(
				defaultValue: 0.0,
				options: FrameworkPropertyMetadataOptions.AffectsMeasure,
				propertyChangedCallback: OnY1PropertyChanged
			)
		);

		private static void OnY1PropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
		{
			if (dependencyObject is Line line)
			{
				line.OnY1PropertyChangedPartial((double)args.OldValue, (double)args.NewValue);
			}
		}

		partial void OnY1PropertyChangedPartial(double oldValue, double newValue);

		public double Y2
		{
			get => (double)GetValue(Y2Property);
			set => SetValue(Y2Property, value);
		}

		public static global::Microsoft.UI.Xaml.DependencyProperty Y2Property { get; } =
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Y2", typeof(double),
			typeof(global::Microsoft.UI.Xaml.Shapes.Line),
			new FrameworkPropertyMetadata(
				defaultValue: 0.0,
				options: FrameworkPropertyMetadataOptions.AffectsMeasure,
				propertyChangedCallback: OnY2PropertyChanged
			)
		);
		private static void OnY2PropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
		{
			if (dependencyObject is Line line)
			{
				line.OnY2PropertyChangedPartial((double)args.OldValue, (double)args.NewValue);
			}
		}

		partial void OnY2PropertyChangedPartial(double oldValue, double newValue);


		protected internal override IEnumerable<object> GetShapeParameters()
		{
			yield return X1;
			yield return X2;
			yield return Y1;
			yield return Y2;

			foreach (var p in base.GetShapeParameters())
			{
				yield return p;
			}
		}
	}
}
