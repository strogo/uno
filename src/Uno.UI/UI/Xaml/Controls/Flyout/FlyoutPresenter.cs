﻿using Uno.UI;
using Windows.Foundation;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class FlyoutPresenter : ContentControl
	{
		public FlyoutPresenter()
		{
		}

		protected override void OnPointerPressed(PointerRoutedEventArgs args)
		{
			if (this.GetTemplateRoot() is FrameworkElement root && this.Parent is FlyoutBasePopupPanel panel)
			{
				// allow flyout to be closed by clicking outside its content
				var rootCoords = args.GetCurrentPoint(root).Position;

				if (0 > rootCoords.X || rootCoords.X > root.ActualWidth ||
					0 > rootCoords.Y || rootCoords.Y > root.ActualHeight)
				{
					panel.Flyout.Hide();
				}
			}

			args.Handled = true;
		}

		protected override void OnPointerReleased(PointerRoutedEventArgs args)
		{
			// All pointer-related should be "eaten" to prevent closing
			// the flyout when a tap is done in its content
			args.Handled = true;
		}

		protected override void OnTapped(TappedRoutedEventArgs args)
		{
			// All pointer-related should be "eaten" to prevent closing
			// the flyout when a tap is done in its content
			args.Handled = true;
		}

		protected override void OnDoubleTapped(DoubleTappedRoutedEventArgs args)
		{
			// All pointer-related should be "eaten" to prevent closing
			// the flyout when a tap is done in its content
			args.Handled = true;
		}

		protected override bool CanCreateTemplateWithoutParent { get; } = true;

		internal override bool IsViewHit() => true;
	}
}
