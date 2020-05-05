﻿using Android.Views;
using Uno.Extensions;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using Uno.UI;

namespace Microsoft.UI.Xaml
{
	public partial class ElementStub : FrameworkElement
	{
		public ElementStub()
		{
			Visibility = Visibility.Collapsed;
		}

		private View MaterializeContent()
		{
			var parentViewGroup = (this as View).Parent as ViewGroup;
			var currentPosition = parentViewGroup?.GetChildren().IndexOf(this);

			if (currentPosition != null && currentPosition.Value != -1)
			{
				parentViewGroup.RemoveViewAt(currentPosition.Value);

				var UnoViewGroup = parentViewGroup as UnoViewGroup;

				var newContent = ContentBuilder();

				if (UnoViewGroup != null)
				{
					var newContentAsFrameworkElement = newContent as IFrameworkElement;
					if (newContentAsFrameworkElement != null)
					{
						newContentAsFrameworkElement.TemplatedParent = (UnoViewGroup as IFrameworkElement)?.TemplatedParent;
					}
					UnoViewGroup.AddView(newContent, currentPosition.Value);
				}
				else
				{
					parentViewGroup.AddView(newContent, currentPosition.Value);
				}

				return newContent;
			}

			return null;
		}
	}
}
