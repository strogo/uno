﻿using Uno;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	/// <summary>
	/// Placement of the Flyout relative to its target control.
	/// </summary>
	public enum FlyoutPlacementMode
	{
		/// <summary>
		/// The preferred location of the flyout is above the target element.
		/// </summary>
		Top,
		/// <summary>
		/// The preferred location of the flyout is below the target element.
		/// </summary>
		Bottom,
		/// <summary>
		/// The preferred location of the flyout is to the left of the target element.
		/// </summary>
		Left,
		/// <summary>
		/// The preferred location of the flyout is to the right of the target element.
		/// </summary>
		Right,
		/// <summary>
		/// The preferred location of the flyout is centered on the screen.
		/// </summary>
		Full,
		[NotImplemented]
		TopEdgeAlignedLeft,
		[NotImplemented]
		TopEdgeAlignedRight,
		[NotImplemented]
		BottomEdgeAlignedLeft,
		[NotImplemented]
		BottomEdgeAlignedRight,
		[NotImplemented]
		LeftEdgeAlignedTop,
		[NotImplemented]
		LeftEdgeAlignedBottom,
		[NotImplemented]
		RightEdgeAlignedTop,
		[NotImplemented]
		RightEdgeAlignedBottom,
		[NotImplemented]
		Auto
	}
}
