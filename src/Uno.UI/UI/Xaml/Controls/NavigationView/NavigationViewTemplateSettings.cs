// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

//
// This file is a C# translation of the NavigationViewTemplateSettings.cpp file from WinUI controls.
//

namespace Microsoft.UI.Xaml.Controls
{
	public  partial class NavigationViewTemplateSettings : global::Microsoft.UI.Xaml.DependencyObject
	{
		public  global::Microsoft.UI.Xaml.Visibility BackButtonVisibility
		{
			get => (global::Microsoft.UI.Xaml.Visibility)GetValue(BackButtonVisibilityProperty);
			internal set => SetValue(BackButtonVisibilityProperty, value);
		}

		public  global::Microsoft.UI.Xaml.Visibility LeftPaneVisibility
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Visibility)GetValue(LeftPaneVisibilityProperty);
			}
			internal set => SetValue(LeftPaneVisibilityProperty, value);
		}

		public  global::Microsoft.UI.Xaml.Visibility OverflowButtonVisibility
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Visibility)GetValue(OverflowButtonVisibilityProperty);
			}
			internal set => SetValue(OverflowButtonVisibilityProperty, value);
		}

		public  global::Microsoft.UI.Xaml.Visibility PaneToggleButtonVisibility
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Visibility)GetValue(PaneToggleButtonVisibilityProperty);
			}
			internal set => SetValue(PaneToggleButtonVisibilityProperty, value);
		}

		public  bool SingleSelectionFollowsFocus
		{
			get
			{
				return (bool)GetValue(SingleSelectionFollowsFocusProperty);
			}
			internal set => SetValue(SingleSelectionFollowsFocusProperty, value);
		}

		public  double TopPadding
		{
			get
			{
				return (double)GetValue(TopPaddingProperty);
			}
			internal set => SetValue(TopPaddingProperty, value);
		}

		public  global::Microsoft.UI.Xaml.Visibility TopPaneVisibility
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Visibility)GetValue(TopPaneVisibilityProperty);
			}
			internal set => SetValue(TopPaneVisibilityProperty, value);
		}

		public static global::Microsoft.UI.Xaml.DependencyProperty BackButtonVisibilityProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"BackButtonVisibility", typeof(global::Microsoft.UI.Xaml.Visibility), 
			typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings), 
			new FrameworkPropertyMetadata(Visibility.Collapsed));

		public static global::Microsoft.UI.Xaml.DependencyProperty LeftPaneVisibilityProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"LeftPaneVisibility", typeof(global::Microsoft.UI.Xaml.Visibility), 
			typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings), 
			new FrameworkPropertyMetadata(Visibility.Visible));

		public static global::Microsoft.UI.Xaml.DependencyProperty OverflowButtonVisibilityProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"OverflowButtonVisibility", typeof(global::Microsoft.UI.Xaml.Visibility), 
			typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings), 
			new FrameworkPropertyMetadata(Visibility.Collapsed));

		public static global::Microsoft.UI.Xaml.DependencyProperty PaneToggleButtonVisibilityProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"PaneToggleButtonVisibility", typeof(global::Microsoft.UI.Xaml.Visibility), 
			typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings), 
			new FrameworkPropertyMetadata(Visibility.Visible));

		public static global::Microsoft.UI.Xaml.DependencyProperty SingleSelectionFollowsFocusProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"SingleSelectionFollowsFocus", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings), 
			new FrameworkPropertyMetadata(false));

		public static global::Microsoft.UI.Xaml.DependencyProperty TopPaddingProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"TopPadding", typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings), 
			new FrameworkPropertyMetadata(0.0));

		public static global::Microsoft.UI.Xaml.DependencyProperty TopPaneVisibilityProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"TopPaneVisibility", typeof(global::Microsoft.UI.Xaml.Visibility), 
			typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings), 
			new FrameworkPropertyMetadata(Visibility.Collapsed));
	}
}
