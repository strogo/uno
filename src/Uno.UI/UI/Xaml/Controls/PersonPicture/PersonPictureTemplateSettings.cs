// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using Uno.UI.Helpers.WinUI;
using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.Resources;
using Windows.Foundation;
using Windows.Storage.Streams;
using Microsoft.UI.Xaml.Automation;
using Microsoft.UI.Xaml.Automation.Peers;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Shapes;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class PersonPictureTemplateSettings : DependencyObject
	{
		public ImageBrush ActualImageBrush
		{
			get { return (ImageBrush)GetValue(ActualImageBrushProperty); }
			internal set { SetValue(ActualImageBrushProperty, value); }
		}

		// Using a DependencyProperty as the backing store for ActualImageBrush.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ActualImageBrushProperty =
			DependencyProperty.Register("ActualImageBrush", typeof(ImageBrush), typeof(PersonPictureTemplateSettings), new PropertyMetadata(null));



		public string ActualInitials
		{
			get { return (string)GetValue(ActualInitialsProperty); }
			internal set { SetValue(ActualInitialsProperty, value); }
		}

		// Using a DependencyProperty as the backing store for ActualInitials.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ActualInitialsProperty =
			DependencyProperty.Register("ActualInitials", typeof(string), typeof(PersonPictureTemplateSettings), new PropertyMetadata(""));
	}
}
