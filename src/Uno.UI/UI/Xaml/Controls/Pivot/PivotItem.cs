﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Uno.UI;
#if XAMARIN_ANDROID
using Android.Views;
#endif

namespace Microsoft.UI.Xaml.Controls
{
    public partial class PivotItem : ContentControl
    {
		public PivotItem()
		{
			this.HorizontalAlignment = HorizontalAlignment.Stretch;
			this.VerticalAlignment = VerticalAlignment.Stretch;

			this.HorizontalContentAlignment = HorizontalAlignment.Stretch;
			this.VerticalContentAlignment = VerticalAlignment.Stretch;
		}

		public PivotItem(string header) : this()
		{
			Header = header;
		}

		protected override bool CanCreateTemplateWithoutParent => true;

		public object Header
		{
			get { return this.GetValue(HeaderProperty); }
			set { this.SetValue(HeaderProperty, value); }
		}

		public static readonly DependencyProperty HeaderProperty =
			DependencyProperty.Register("Header", typeof(object), typeof(PivotItem), new PropertyMetadata(null));

#if XAMARIN_ANDROID
		// This allows the PivotItem to fill the whole available space.
		protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
			if (ChildCount != 0)
			{
				MeasureChild(GetChildAt(0), widthMeasureSpec, heightMeasureSpec);
			}

			SetMeasuredDimension(ViewHelper.MeasureSpecGetSize(widthMeasureSpec), ViewHelper.MeasureSpecGetSize(heightMeasureSpec));
		}
#endif
	}
}
