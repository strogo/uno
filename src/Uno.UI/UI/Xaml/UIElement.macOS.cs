using CoreAnimation;
using CoreGraphics;
using Foundation;
using Uno.Extensions;
using Uno.UI.Controls;
using Windows.Foundation;
using Microsoft.UI.Xaml.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uno.Logging;
using Uno;
using Windows.Devices.Input;
using Microsoft.Extensions.Logging;
using Microsoft.UI.Xaml.Media;
using Uno.UI.Extensions;
using Uno.UI;
using AppKit;

namespace Microsoft.UI.Xaml
{
	public partial class UIElement : BindableNSView
	{
		internal bool IsPointerCaptured { get; set; }

		#region Logs
		private static readonly ILogger _log = typeof(UIElement).Log();
		private static readonly Action LogRegisterPointerCanceledNotImplemented = Actions.CreateOnce(() => _log.Error("Unable to RegisterPointerCanceled on UIElement for iOS. Not Implemented."));
		private static readonly Action LogUnregisterPointerCanceledNotImplemented = Actions.CreateOnce(() => _log.Error("Unable to UnregisterPointerCanceled on UIElement for iOS. Not Implemented."));
		private static readonly Action LogRegisterPointerExitedNotImplemented = Actions.CreateOnce(() => _log.Error("Unable to RegisterPointerExited on UIElement for iOS. Not Implemented."));
		private static readonly Action LogUnRegisterPointerExitedNotImplemented = Actions.CreateOnce(() => _log.Error("Unable to UnregisterPointerExited on UIElement for iOS. Not Implemented."));
		private static readonly Action LogRegisterPointerPressedNotImplemented = Actions.CreateOnce(() => _log.Error("Unable to RegisterPointerPressed on UIElement for iOS. Not Implemented."));
		private static readonly Action LogUnRegisterPointerPressedNotImplemented = Actions.CreateOnce(() => _log.Error("Unable to UnRegisterPointerPressed on UIElement for iOS. Not Implemented."));
		private static readonly Action LogRegisterPointerReleasedNotImplemented = Actions.CreateOnce(() => _log.Error("Unable to RegisterPointerReleased on UIElement for iOS. Not Implemented."));
		private static readonly Action LogUnRegisterPointerReleasedNotImplemented = Actions.CreateOnce(() => _log.Error("Unable to UnregisterPointerReleased on UIElement for iOS. Not Implemented."));
		#endregion

		public UIElement()
		{
			Initialize();
			InitializePointers();
		}		
		
		internal bool ClippingIsSetByCornerRadius { get; set; } = false;



        partial void OnOpacityChanged(DependencyPropertyChangedEventArgs args)
		{
			// Don't update the internal value if the value is being animated.
			// The value is being animated by the platform itself.
			if (!(args.NewPrecedence == DependencyPropertyValuePrecedences.Animations && args.BypassesPropagation))
			{
				AlphaValue = IsRenderingSuspended ? 0 : (nfloat)Opacity;
			}
		}

		protected virtual void OnVisibilityChanged(Visibility oldValue, Visibility newValue)
		{
			var newVisibility = (Visibility)newValue;

			if (base.Hidden != newVisibility.IsHidden())
			{
				base.Hidden = newVisibility.IsHidden();
				base.NeedsLayout = true;			

				if (newVisibility == Visibility.Visible)
				{
					// This recursively invalidates the layout of all subviews
					// to ensure LayoutSubviews is called and views get updated.
					// Failing to do this can cause some views to remain collapsed.
					SetSubviewsNeedLayout();
				}
			}
		}

		public override bool Hidden
		{
			get
			{
				return base.Hidden;
			}
			set
			{
				// Only set the Visility property, the Hidden property is updated 
				// in the property changed handler as there are actions associated with 
				// the change.
				Visibility = value ? Visibility.Collapsed : Visibility.Visible;
			}
		}

		public void SetSubviewsNeedLayout()
		{
			base.NeedsLayout = true;

			if (this is Controls.Panel p)
			{
				// This section is here because of the enumerator type returned by Children,
				// to avoid allocating during the enumeration.
				foreach (var view in p.Children)
				{
					(view as IFrameworkElement)?.SetSubviewsNeedLayout();
				}
			}
			else
			{
				foreach (var view in this.GetChildren())
				{
					(view as IFrameworkElement)?.SetSubviewsNeedLayout();
				}
			}
		}

		internal Windows.Foundation.Point GetPosition(Point position, global::Microsoft.UI.Xaml.UIElement relativeTo)
		{
#if __IOS__
			return relativeTo.ConvertPointToCoordinateSpace(position, relativeTo);
#elif __MACOS__
			throw new NotImplementedException();
#endif
		}

		private CGRect ToCGRect(Rect rect)
		{
			return new CGRect
			(
				(nfloat)(rect.X),
				(nfloat)(rect.Y),
				(nfloat)(rect.Width),
				(nfloat)(rect.Height)
			);
		}

		/// <summary>
		/// Gets the origin point of the <paramref name="view"/> in the clippingParent's 
		/// coordinate system.
		/// </summary>
		/// <param name="view">The view to get the point from</param>
		/// <param name="parentView">The view for which to get the adjusted coordinates from</param>
		/// <returns></returns>
		private static CGPoint ConvertOriginPointToView(NSView view, NSView parentView)
		{
			var value = CGPoint.Empty;
			var current = view;

			do
			{
				if (current is FrameworkElement fr)
				{
					value.X += (nfloat)fr.AppliedFrame.X;
					value.Y += (nfloat)fr.AppliedFrame.Y;
				}
				else
				{
					value.X += current.Frame.X;
					value.Y += current.Frame.Y;
				}

				current = current.Superview;

			} while (current != null && current != parentView);

			return value;
		}

#region DoubleTapped event
		private void RegisterDoubleTapped(DoubleTappedEventHandler handler)
		{
			LogRegisterPointerCanceledNotImplemented();
		}

		private void UnregisterDoubleTapped(DoubleTappedEventHandler handler)
		{
			LogRegisterPointerCanceledNotImplemented();
		}
#endregion

#region PointerCanceled event
		private void RegisterPointerCanceled(PointerEventHandler handler)
		{
			LogRegisterPointerCanceledNotImplemented();
		}

		private void UnregisterPointerCanceled(PointerEventHandler handler)
		{
			LogUnregisterPointerCanceledNotImplemented();
		}
#endregion

#region PointerExited event
		private void RegisterPointerExited(PointerEventHandler handler)
		{
			LogRegisterPointerExitedNotImplemented();
		}

		private void UnregisterPointerExited(PointerEventHandler handler)
		{
			LogUnRegisterPointerExitedNotImplemented();
		}
#endregion

#region PointerPressed event
		private void RegisterPointerPressed(PointerEventHandler handler)
		{
			LogRegisterPointerPressedNotImplemented();
		}

		private void UnregisterPointerPressed(PointerEventHandler handler)
		{
			LogUnRegisterPointerPressedNotImplemented();
		}
#endregion

#region PointerReleased event
		private void RegisterPointerReleased(PointerEventHandler handler)
		{
			LogRegisterPointerReleasedNotImplemented();
		}

		private void UnregisterPointerReleased(PointerEventHandler handler)
		{
			LogUnRegisterPointerReleasedNotImplemented();
		}
#endregion

#region Tapped event
		private void RegisterTapped(TappedEventHandler handler)
		{
			LogRegisterPointerReleasedNotImplemented();
		}

		private void UnregisterTapped(TappedEventHandler handler)
		{
			LogUnRegisterPointerReleasedNotImplemented();
		}
#endregion

		internal void RaiseTapped(TappedRoutedEventArgs args) => LogUnRegisterPointerReleasedNotImplemented();

#if DEBUG
		public string ShowLocalVisualTree(int fromHeight) => AppKit.UIViewExtensions.ShowLocalVisualTree(this, fromHeight);
#endif
	}
}
