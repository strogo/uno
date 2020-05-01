﻿using System;
using System.Collections.Generic;
using System.Text;
using Uno.UI;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
	public partial class AppBar : ContentControl
	{
		private double _compactHeight;
		private double _minimalHeight;

		public AppBar()
		{
			TemplateSettings = new AppBarTemplateSettings(this);

			SizeChanged += (s, e) => UpdateTemplateSettings();
		}

		#region IsSticky

		public bool IsSticky
		{
			get => (bool)GetValue(IsStickyProperty);
			set => SetValue(IsStickyProperty, value);
		}

		public static DependencyProperty IsStickyProperty { get; } =
			DependencyProperty.Register(
				"IsSticky",
				typeof(bool),
				typeof(AppBar),
				new FrameworkPropertyMetadata(default(bool))
			);

		#endregion

		#region IsOpen

		public bool IsOpen
		{
			get => (bool)GetValue(IsOpenProperty);
			set => SetValue(IsOpenProperty, value);
		}

		public static DependencyProperty IsOpenProperty { get; } =
		DependencyProperty.Register(
			"IsOpen",
			typeof(bool),
			typeof(AppBar),
			new FrameworkPropertyMetadata(default(bool))
		);

		#endregion

		#region ClosedDisplayMode

		public AppBarClosedDisplayMode ClosedDisplayMode
		{
			get => (AppBarClosedDisplayMode)GetValue(ClosedDisplayModeProperty);
			set => SetValue(ClosedDisplayModeProperty, value);
		}

		public static DependencyProperty ClosedDisplayModeProperty { get; } =
			DependencyProperty.Register(
				"ClosedDisplayMode",
				typeof(AppBarClosedDisplayMode),
				typeof(AppBar),
				new FrameworkPropertyMetadata(AppBarClosedDisplayMode.Compact)
			);

		#endregion

		#region LightDismissOverlayMode

		public LightDismissOverlayMode LightDismissOverlayMode
		{
			get => (LightDismissOverlayMode)GetValue(LightDismissOverlayModeProperty);
			set => SetValue(LightDismissOverlayModeProperty, value);
		}

		public static DependencyProperty LightDismissOverlayModeProperty { get; } =
			DependencyProperty.Register(
				"LightDismissOverlayMode",
				typeof(LightDismissOverlayMode),
				typeof(AppBar),
				new FrameworkPropertyMetadata(default(LightDismissOverlayMode))
			);

		#endregion

		public AppBarTemplateSettings TemplateSettings { get; }

		public event EventHandler<object> Closed;
		public event EventHandler<object> Opened;
		public event EventHandler<object> Closing;
		public event EventHandler<object> Opening;

		protected virtual void OnClosed(object e)
		{
			Closed?.Invoke(this, e);
		}

		protected virtual void OnOpened(object e)
		{
			Opened?.Invoke(this, e);
		}

		protected virtual void OnClosing(object e)
		{
			Closing?.Invoke(this, e);
		}

		protected virtual void OnOpening(object e)
		{
			Opening?.Invoke(this, e);
		}

		protected override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			_compactHeight = ResourceResolver.ResolveTopLevelResource<double>("AppBarThemeCompactHeight");
			_minimalHeight = ResourceResolver.ResolveTopLevelResource<double>("AppBarThemeMinimalHeight");

			UpdateTemplateSettings();

		}

		private void UpdateTemplateSettings()
		{
			var contentHeight = (ContentTemplateRoot as FrameworkElement)?.ActualHeight ?? ActualHeight;
			TemplateSettings.ClipRect = new Foundation.Rect(0, 0, ActualWidth, contentHeight);

			var compactVerticalDelta = _compactHeight - contentHeight;
			TemplateSettings.CompactVerticalDelta = compactVerticalDelta;
			TemplateSettings.NegativeCompactVerticalDelta = -compactVerticalDelta;

			var minimalVerticalDelta = _minimalHeight - contentHeight;
			TemplateSettings.MinimalVerticalDelta = minimalVerticalDelta;
			TemplateSettings.NegativeMinimalVerticalDelta = -minimalVerticalDelta;

			TemplateSettings.HiddenVerticalDelta = -contentHeight;
			TemplateSettings.NegativeHiddenVerticalDelta = contentHeight;
		}
	}
}
