using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.UI.Xaml
{
	public static partial class UIElementExtensions
	{
		public static UIElement GetVisualTreeParent(this UIElement uiElement) => (uiElement as FrameworkElement)?.Parent as UIElement;
	}
}
