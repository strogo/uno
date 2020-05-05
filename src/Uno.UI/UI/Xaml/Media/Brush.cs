﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Windows.UI;

namespace Microsoft.UI.Xaml.Media
{
	[TypeConverter(typeof(BrushConverter))]
	public partial class Brush : DependencyObject
	{
		public Brush()
		{
			InitializeBinder();
		}

		public static implicit operator Brush(Color uiColor) => SolidColorBrushHelper.FromARGB(uiColor.A, uiColor.R, uiColor.G, uiColor.B);

		public static implicit operator Brush(string colorCode) => SolidColorBrushHelper.Parse(colorCode);

		#region Opacity Dependency Property

		public double Opacity
		{
			get => (double)GetValue(OpacityProperty);
			set => SetValue(OpacityProperty, value);
		}

		// Using a DependencyProperty as the backing store for Opacity.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty OpacityProperty =
			DependencyProperty.Register(
				"Opacity", 
				typeof(double), 
				typeof(Brush),
				new PropertyMetadata(
					defaultValue: 1d,
					propertyChangedCallback: (s, e) => ((Brush)s).OnOpacityChanged((double)e.OldValue, (double)e.NewValue)
				)
			);

		protected virtual void OnOpacityChanged(double oldValue, double newValue)
		{
		}

		#endregion

		public Transform RelativeTransform
		{
			get => (Transform)GetValue(RelativeTransformProperty);
			set => SetValue(RelativeTransformProperty, value);
		}

		public static readonly DependencyProperty RelativeTransformProperty =
			DependencyProperty.Register(
				"RelativeTransform",
				typeof(Transform),
				typeof(Brush),
				new PropertyMetadata(
					null,

					propertyChangedCallback: (s, e) =>
						((Brush)s).OnRelativeTransformChanged((Transform)e.OldValue, (Transform)e.NewValue)));

		protected virtual void OnRelativeTransformChanged(Transform oldValue, Transform newValue)
		{
		}

		private protected Color GetColorWithOpacity(Color referenceColor)
		{
			return Color.FromArgb((byte)(Opacity * referenceColor.A), referenceColor.R, referenceColor.G, referenceColor.B);
		}
	}
}
