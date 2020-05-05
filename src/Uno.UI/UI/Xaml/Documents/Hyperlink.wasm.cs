﻿using System;
using System.Linq;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;

namespace Microsoft.UI.Xaml.Documents
{
	partial class Hyperlink
	{
		public Hyperlink() : base("a")
		{
			UpdateNavigationProperties(null, _defaultNavigationTarget);

			PointerPressed += TextBlock.OnPointerPressed;
			PointerReleased += TextBlock.OnPointerReleased;
			PointerCaptureLost += TextBlock.OnPointerCaptureLost;
		}

		#region NavigationTarget DependencyProperty
		private const NavigationTarget _defaultNavigationTarget = NavigationTarget.NewDocument;

		public NavigationTarget NavigationTarget
		{
			get => (NavigationTarget)GetValue(NavigationTargetProperty);
			set => SetValue(NavigationTargetProperty, value);
		}

		public static readonly DependencyProperty NavigationTargetProperty = DependencyProperty.Register(
			"NavigationTarget",
			typeof(NavigationTarget),
			typeof(Hyperlink),
			new PropertyMetadata(_defaultNavigationTarget, (s, e) => ((Hyperlink)s).OnNavigationTargetChanged(e)));

		private void OnNavigationTargetChanged(DependencyPropertyChangedEventArgs e)
			=> UpdateNavigationProperties(NavigateUri, (NavigationTarget)e.NewValue);
		#endregion

		partial void OnNavigateUriChangedPartial(Uri newNavigateUri)
			=> UpdateNavigationProperties(newNavigateUri, NavigationTarget);

		private void UpdateNavigationProperties(Uri navigateUri, NavigationTarget target)
		{
			var uri = navigateUri?.OriginalString;
			if (string.IsNullOrWhiteSpace(uri))
			{
				SetAttribute(
					("target", ""),
					("href", "#") // Required to get the native hover visual state
				);
			}
			else if (target == NavigationTarget.NewDocument)
			{
				SetAttribute(
					("target", "_blank"),
					("href", uri)
				);
			}
			else
			{
				SetAttribute(
					("target", ""),
					("href", uri)
				);
			}
			UpdateHitTest();
		}

		internal override bool IsViewHit()
			=> NavigateUri != null || base.IsViewHit();
	}

	public enum NavigationTarget
	{
		NewDocument,
		SameDocument
	}
}
