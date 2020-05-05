using System;
using System.Drawing;
using Uno.Disposables;
using Uno.Extensions;
using Uno.UI.Extensions;
using System.Linq;
using Windows.UI.Core;
using Uno.Diagnostics.Eventing;
using Foundation;
using AppKit;
using CoreGraphics;
using Uno.Collections;
using Microsoft.UI.Xaml.Input;
using WebKit;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml;
using Uno.UI.Controls;
using Uno.Logging;
using Windows.Foundation;
using Windows.UI.ViewManagement;

namespace Uno.UI.Controls
{
	/// <summary>
	/// A UIWindow which handle the focus item.
	/// </summary>
	public partial class Window : NSWindow
	{
		private static readonly WeakAttachedDictionary<NSView, string> _attachedProperties = new WeakAttachedDictionary<NSView, string>();
		private const string NeedsKeyboardAttachedPropertyKey = "NeedsKeyboard";

		private readonly InputPane _inputPane;
		private WeakReference<NSScrollView> _scrollViewModifiedForKeyboard;

		/// <summary>
		/// ctor.
		/// </summary>
		public Window(CGRect contentRect, NSWindowStyle aStyle, NSBackingStore bufferingType, bool deferCreation)
			: base(contentRect, aStyle, bufferingType, deferCreation)
		{
			_inputPane = InputPane.GetForCurrentView();
			_inputPane.Window = this;
		}

		public static void SetNeedsKeyboard(NSView view, bool needsKeyboard)
		{
			if (view != null)
			{
				_attachedProperties.SetValue(view, NeedsKeyboardAttachedPropertyKey, (bool?)needsKeyboard);
			}
		}

		private static bool GetNeedsKeyboard(NSView view)
		{
			var superViews = view.FindSuperviews().ToList();
			superViews.Insert(0, view);

			return superViews.Any(superView => _attachedProperties.GetValue(superView, NeedsKeyboardAttachedPropertyKey, () => default(bool?)).GetValueOrDefault());
		}

		private static bool NeedsKeyboard(NSView view)
		{
			return view is NSTextView
				|| view is NSTextField
				|| GetNeedsKeyboard(view);
		}
		
		public BringIntoViewMode? FocusedViewBringIntoViewOnKeyboardOpensMode { get; set; }


		internal void MakeVisible(NSView view, BringIntoViewMode? bringIntoViewMode, bool useForcedAnimation = false)
		{
			if (view == null)
			{
				return;
			}

			if (bringIntoViewMode == null)
			{
				return;
			}

			var scrollView = view.FindSuperviewsOfType<NSScrollView>().LastOrDefault();
			_scrollViewModifiedForKeyboard = new WeakReference<NSScrollView>(scrollView);

			if (scrollView == null)
			{
				this.Log().Warn("Keyboard will show, but we cannot find any ScrollView with enough space for the currently focused view, so it's impossible to ensure that it's visible.");
				return;
			}


			var scrollViewRectInWindow = scrollView.ConvertRectFromView(scrollView.Bounds, scrollView);

			var keyboardTop = (nfloat)_inputPane.OccludedRect.Top;

			var keyboardOverlap = scrollViewRectInWindow.Bottom - keyboardTop;
			if (keyboardOverlap > 0)
			{
				scrollView.ContentInsets = new NSEdgeInsets(0, 0, keyboardOverlap, 0);
			}

			var viewRectInScrollView = CGRect.Empty;
			
			if (!(view is TextBox))
			{
				// We want to scroll to the textbox and not the inner textview.
				view = view.FindFirstParent<TextBox>() ?? view;
			}

			viewRectInScrollView = scrollView.ConvertRectFromView(view.Bounds, view);

			scrollView.ScrollRectToVisible(viewRectInScrollView);
		}

	}
}
