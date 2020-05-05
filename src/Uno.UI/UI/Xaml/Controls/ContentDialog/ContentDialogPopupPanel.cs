using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using Uno.Extensions;
using Uno.UI;
using Windows.Foundation;
using Windows.UI.ViewManagement;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	internal partial class ContentDialogPopupPanel : PopupPanel
	{
		private readonly ContentDialog _dialog;

		public ContentDialogPopupPanel(ContentDialog dialog) : base(dialog._popup)
		{
			_dialog = dialog;
		}

		protected override Size ArrangeOverride(Size finalSize)
		{
			if (this.Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug))
			{
				this.Log().LogDebug($"ArrangeOverride ContentDialogPopupPanel {finalSize}");
			}

			foreach (var child in Children)
			{
				if (!(child is UIElement elem))
				{
					continue;
				}

				var desiredSize = elem.DesiredSize;
				var rect = CalculateDialogPlacement(desiredSize);

				if (this.Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug))
				{
					this.Log().LogDebug($"Arranging ContentDialogPopupPanel {desiredSize} to {rect}");
				}

				elem.Arrange(rect);
			}

			return finalSize;
		}

		private Rect CalculateDialogPlacement(Size desiredSize)
		{
			var visibleBounds = ApplicationView.GetForCurrentView().VisibleBounds;

			// Make sure the desiredSize fits in visibleBounds
			if (desiredSize.Width > visibleBounds.Width)
			{
				desiredSize.Width = visibleBounds.Width;
			}
			if (desiredSize.Height > visibleBounds.Height)
			{
				desiredSize.Height = visibleBounds.Height;
			}

			var  finalPosition = new Point(
						x: (visibleBounds.Width - desiredSize.Width) / 2.0,
						y: (visibleBounds.Height - desiredSize.Height) / 2.0);

			var finalRect = new Rect(finalPosition, desiredSize);

			return finalRect;
		}
	}
}
