﻿using System;
using Windows.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
#if __IOS__
using CoreGraphics;
using _View = UIKit.UIView;
#elif __MACOS__
using CoreGraphics;
using _View = AppKit.NSView;
#endif


namespace Uno.UI.Toolkit
{
	[ContentProperty(Name = "ElevatedContent")]
	[TemplatePart(Name = "PART_Border", Type = typeof(Border))]
	public sealed partial class ElevatedView : Control
#if !NETFX_CORE
		, ICustomClippingElement
#endif
	{
		/*
		 *  +-ElevatedView------------+
		 *  |                         |
		 *  |  +-Border------------+  |
		 *  |  |                   |  |
		 *  |  |  +-Content-----+  |  |
		 *  |  |  | (...)       |  |  |
		 *  |  |  +-------------+  |  |
		 *  |  |                   |  |
		 *  |  +-------------------+  |
		 *  |                         |
		 *  +-------------------------+
		 *
		 * Elevated is responsible for the shadow
		 * Border responsible for rounded corners (if any)
		 *
		 */

		private Border _border;

		public ElevatedView()
		{
			DefaultStyleKey = typeof(ElevatedView);

#if !NETFX_CORE
			Loaded += (snd, evt) => SynchronizeContentTemplatedParent();
#endif
		}

		protected override void OnApplyTemplate()
		{
			_border = GetTemplateChild("PART_Border") as Border;

			UpdateElevation();
		}

		public static readonly DependencyProperty ElevationProperty = DependencyProperty.Register(
			"Elevation", typeof(double), typeof(ElevatedView), new PropertyMetadata(default(double), OnChanged));

#if __ANDROID__
		public new double Elevation
#else
		public double Elevation
#endif
		{
			get => (double)GetValue(ElevationProperty);
			set => SetValue(ElevationProperty, value);
		}

		public static readonly DependencyProperty ShadowColorProperty = DependencyProperty.Register(
			"ShadowColor", typeof(Color), typeof(ElevatedView), new PropertyMetadata(Color.FromArgb(64, 0, 0, 0), OnChanged));

		public Color ShadowColor
		{
			get => (Color)GetValue(ShadowColorProperty);
			set => SetValue(ShadowColorProperty, value);
		}

		public static readonly DependencyProperty ElevatedContentProperty = DependencyProperty.Register(
			"ElevatedContent", typeof(object), typeof(ElevatedView), new PropertyMetadata(default(object)));

		public object ElevatedContent
		{
			get => GetValue(ElevatedContentProperty);
			set => SetValue(ElevatedContentProperty, value);
		}

#if !NETFX_CORE
		public new static readonly DependencyProperty BackgroundProperty = DependencyProperty.Register(
			"Background", typeof(Brush), typeof(ElevatedView), new PropertyMetadata(default(Brush)));

		public new Brush Background
		{
			get => (Brush)GetValue(BackgroundProperty);
			set => SetValue(BackgroundProperty, value);
		}

		public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
			"CornerRadius", typeof(CornerRadius), typeof(ElevatedView), new PropertyMetadata(default(CornerRadius), OnChanged));

		public CornerRadius CornerRadius
		{
			get => (CornerRadius)GetValue(CornerRadiusProperty);
			set => SetValue(CornerRadiusProperty, value);
		}

		protected internal override void OnTemplatedParentChanged(DependencyPropertyChangedEventArgs e)
		{
			base.OnTemplatedParentChanged(e);

			// This is required to ensure that FrameworkElement.FindName can dig through the tree after
			// the control has been created.
			SynchronizeContentTemplatedParent();
		}

		private void SynchronizeContentTemplatedParent()
		{
			// Manual propagation of the templated parent to the content property
			// until we get the propagation running properly
			if (ElevatedContent is IFrameworkElement content)
			{
				content.TemplatedParent = this.TemplatedParent;
			}
		}
#endif

		private static void OnChanged(DependencyObject snd, DependencyPropertyChangedEventArgs evt) => ((ElevatedView)snd).UpdateElevation();

		private void UpdateElevation()
		{
			if (_border == null)
			{
				return; // not initialized yet
			}

#if !NETFX_CORE
			SynchronizeContentTemplatedParent();
#endif

			if (Background == null)
			{
				this.SetElevationInternal(0, default);
			}
			else
			{
#if __WASM__
				this.SetElevationInternal(Elevation, ShadowColor);
				this.SetCornerRadius(CornerRadius);
#elif __IOS__
				this.SetElevationInternal(Elevation, ShadowColor, _border.BoundsPath);
#elif __ANDROID__
				_border.SetElevationInternal(Elevation, ShadowColor);
#endif
				// TODO: MacOS
				// TODO: UWA (waiting for support v10.0.18362.0+ to use ThemeShadow)
			}
		}

#if !NETFX_CORE
		bool ICustomClippingElement.AllowClippingToLayoutSlot => false; // Never clip, since it will remove the shadow

		bool ICustomClippingElement.ForceClippingToLayoutSlot => false;
#endif
	}
}
