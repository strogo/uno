// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

//
// This file is a C# translation of the NavigationViewItem.cpp file from WinUI controls.
//

using System;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Shapes;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class NavigationViewItem : NavigationViewItemBase
	{
		public IconElement Icon
		{
			get => (IconElement)GetValue(IconProperty);
			set => SetValue(IconProperty, value);
		}

		public double CompactPaneLength
			=> (double)GetValue(CompactPaneLengthProperty);

		public bool SelectsOnInvoked
		{
			get => (bool)GetValue(SelectsOnInvokedProperty);
			set => SetValue(SelectsOnInvokedProperty, value);
		}

		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectsOnInvokedProperty { get; } =
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"SelectsOnInvoked", typeof(bool),
			typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewItem),
			new FrameworkPropertyMetadata(true));

		public static global::Microsoft.UI.Xaml.DependencyProperty CompactPaneLengthProperty { get; } =
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"CompactPaneLength", typeof(double),
			typeof(NavigationViewItem),
			new FrameworkPropertyMetadata(defaultValue: 48.0)
		);

		public static global::Microsoft.UI.Xaml.DependencyProperty IconProperty { get; } =
		Microsoft.UI.Xaml.DependencyProperty.Register(
			name: "Icon",
			propertyType: typeof(IconElement),
			ownerType: typeof(NavigationViewItem),
			typeMetadata: new FrameworkPropertyMetadata(defaultValue: null)
		);
	}
}
