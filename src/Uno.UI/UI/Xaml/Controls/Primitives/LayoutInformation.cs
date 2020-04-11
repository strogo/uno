using Windows.Foundation;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	partial class LayoutInformation
	{
		public static Rect GetLayoutSlot(FrameworkElement element)
		{
			return element.LayoutSlot;
		}

		public static Size GetAvailableSize(UIElement element)
			=> element.LastAvailableSize;
	}
}
