﻿#if __ANDROID__ || __WASM__
using Uno.Extensions;
using Uno.Disposables;
using Uno.Logging;
using Microsoft.UI.Xaml.Controls.Primitives;
using System;
using Microsoft.UI.Xaml.Media;
using Uno.UI;

#if XAMARIN_ANDROID
using View = Android.Views.View;
#elif NET461 || __WASM__
using View = Microsoft.UI.Xaml.FrameworkElement;
#endif


namespace Microsoft.UI.Xaml.Controls
{
	public partial class Popup
	{
		private readonly SerialDisposable _closePopup = new SerialDisposable();

#if __ANDROID__
		private bool _useNativePopup = FeatureConfiguration.Popup.UseNativePopup;
#endif

		partial void InitializePartial()
		{
#if __ANDROID__
			if (_useNativePopup)
			{
				InitializeNativePartial();
			}
#endif

			PopupPanel = new PopupPanel(this);
		}

		partial void InitializeNativePartial();

		protected override void OnChildChanged(View oldChild, View newChild)
		{
			base.OnChildChanged(oldChild, newChild);

			PopupPanel.Children.Remove(oldChild);

			if (newChild != null)
			{
				PopupPanel.Children.Add(newChild);
			}
		}

		protected override void OnIsLightDismissEnabledChanged(bool oldIsLightDismissEnabled, bool newIsLightDismissEnabled)
		{
			base.OnIsLightDismissEnabledChanged(oldIsLightDismissEnabled, newIsLightDismissEnabled);

#if __ANDROID__
			if (_useNativePopup)
			{
				OnIsLightDismissEnabledChangedNative(oldIsLightDismissEnabled, newIsLightDismissEnabled);
			}
			else
#endif
			{
				if (PopupPanel != null)
				{
					PopupPanel.Background = GetPanelBackground();
				}
			}
		}

		partial void OnIsLightDismissEnabledChangedNative(bool oldIsLightDismissEnabled, bool newIsLightDismissEnabled);

		protected override void OnIsOpenChanged(bool oldIsOpen, bool newIsOpen)
		{
			base.OnIsOpenChanged(oldIsOpen, newIsOpen);

			if (this.Log().IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug))
			{
				this.Log().Debug($"Popup.IsOpenChanged({oldIsOpen}, {newIsOpen})");
			}

#if __ANDROID__
			if (_useNativePopup)
			{
				OnIsOpenChangedNative(oldIsOpen, newIsOpen);
			}
			else
#endif
			{
				if (newIsOpen)
				{
					_closePopup.Disposable = Window.Current.OpenPopup(this);
					PopupPanel.Visibility = Visibility.Visible;
				}
				else
				{
					_closePopup.Disposable = null;
					PopupPanel.Visibility = Visibility.Collapsed;
				}
			}
		}

		partial void OnIsOpenChangedNative(bool oldIsOpen, bool newIsOpen);

		partial void OnPopupPanelChangedPartial(PopupPanel previousPanel, PopupPanel newPanel)
		{
#if __ANDROID__
			if (_useNativePopup)
			{
				OnPopupPanelChangedPartialNative(previousPanel, newPanel);
			}
			else
#endif
			{
				previousPanel?.Children.Clear();

				if (newPanel != null)
				{
					if (Child != null)
					{
						newPanel.Children.Add(Child);
					}
					newPanel.Background = GetPanelBackground();
				}
			}
		}

		partial void OnPopupPanelChangedPartialNative(PopupPanel previousPanel, PopupPanel newPanel);
	}
}
#endif
