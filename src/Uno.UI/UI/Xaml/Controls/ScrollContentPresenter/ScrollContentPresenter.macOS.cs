﻿using Uno.Extensions;
using Uno.Logging;
using Uno.UI.DataBinding;
using Microsoft.UI.Xaml.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using Uno.Disposables;
using System.Runtime.CompilerServices;
using System.Text;
using System.Drawing;
using AppKit;
using Uno.UI;
using Foundation;
using CoreGraphics;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class ScrollContentPresenter : NSScrollView, IHasSizeThatFits
	{
		public ScrollContentPresenter()
		{
			InitializeScrollContentPresenter();

			Notifications.ObserveDidLiveScroll(this, OnLiveScroll);

			DrawsBackground = false;
		}

		public nfloat ZoomScale {
			get => Magnification;
			set => Magnification = value;
		}

		public NSEdgeInsets ContentInset { get; set; }

		public CGPoint UpperScrollLimit { get; }

		public ScrollMode HorizontalScrollMode { get; set; }

		public ScrollMode VerticalScrollMode { get; set; }

		public float MinimumZoomScale { get; set; }

		public float MaximumZoomScale { get; set; }

		private bool ShowsVerticalScrollIndicator
		{
			get => HasVerticalScroller;
			set => HasVerticalScroller = value;
		}

		private bool ShowsHorizontalScrollIndicator
		{
			get => HasHorizontalScroller;
			set => HasHorizontalScroller = value;
		}

		public override bool NeedsLayout
		{
			get => base.NeedsLayout; set
			{
				base.NeedsLayout = value;

				if (value)
				{
					_requiresMeasure = true;

					if (Superview != null)
					{
						Superview.NeedsLayout = true;
					}
				}
			}
		}

		public void SetContentOffset(CGPoint contentOffset, bool animated)
		{
			// Support for ChangeView https://github.com/unoplatform/uno/issues/626
		}

		partial void OnContentChanged(NSView previousView, NSView newView)
		{
			DocumentView = newView;
		}

		private void OnLiveScroll(object sender, NSNotificationEventArgs e)
		{
			var offset = DocumentVisibleRect.Location;
			(TemplatedParent as ScrollViewer)?.OnScrollInternal(offset.X, offset.Y, isIntermediate: false);
		}
	}
}
