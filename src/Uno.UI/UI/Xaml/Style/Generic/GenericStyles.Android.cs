﻿using Uno.UI.Controls;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using Uno.Disposables;
using System.Text;
using Uno.UI.Converters;
using Android.Util;
using Uno.UI;
using Uno;

#if XAMARIN_ANDROID
using View = Android.Views.View;
using ViewGroup = Android.Views.ViewGroup;
using Font = Android.Graphics.Typeface;
using Android.Graphics;
#elif XAMARIN_IOS
using View = MonoTouch.UIKit.UIView;
using ViewGroup = MonoTouch.UIKit.UIView;
using Color = MonoTouch.UIKit.UIColor;
using Font = MonoTouch.UIKit.UIFont;
#endif

namespace Microsoft.UI.Xaml
{
	public static partial class GenericStyles
	{
		static partial void InitStyles()
		{
			InitItemsControl();
			InitFlipView();
			InitPage();
			InitWebView();
			InitDatePicker();
			InitFlipViewItem();
			InitToggleSwitch();
			InitFlyoutPresenter();

#if !IS_UNO
			InitExpander();
			InitShowControl();
			InitAsyncValuePresenter();
			InitIfDataContextControl();
			InitStructuredContentPresenter();
#endif

			// WARNING: For compatibility reasons, the default template of a ContentControl is NULL
			//			which makes the ContentControl skip the ContentPresenter level.
			//			This is critical for android where the ViewGroup nesting is severely limited 
			//			in Android 4.4 and lower, where the UI thread stack size is 32KB or below.
			//
			//          This line is intentionally left here to remind of the reason why
			//          there is no ContentControl template, please do not remove.
			// InitContentControl();
		}

#if !IS_UNO
		private static void InitStructuredContentPresenter()
		{
			var style = new Style(typeof(StructuredContentPresenter))
			{
				Setters =
				{
					new Setter<StructuredContentPresenter>("Template", pb => pb
						.Template = new ControlTemplate(() => new ContentControl {
							Name = "PART_Root",
							HorizontalContentAlignment = HorizontalAlignment.Stretch,
							VerticalContentAlignment = VerticalAlignment.Stretch,
						})
					)
				}
			};

			Style.RegisterDefaultStyleForType(typeof(StructuredContentPresenter), style);
		}
#endif
		
		private static void InitFlipViewItem()
		{
			var style = new Style(typeof(FlipViewItem))
			{
				Setters = {
					new Setter<FlipViewItem>("Template", t =>
						t.Template = Funcs.Create(() =>
							new ContentPresenter { }
								.Binding("Content", new TemplateBinding("Content"))
								.Binding("ContentTemplate", new TemplateBinding("ContentTemplate"))
								.Binding("ContentTemplateSelector", new TemplateBinding("ContentTemplateSelector"))
						)
					),
				}
			};

			Style.RegisterDefaultStyleForType(typeof(FlipViewItem), style);
		}

		private static View CommandTemplate()
		{
			var button = new Button
			{
				HorizontalAlignment = HorizontalAlignment.Stretch,
				ContentTemplate = new DataTemplate(() => new TextBlock
				{
					HorizontalAlignment = HorizontalAlignment.Center,
					VerticalAlignment = Xaml.VerticalAlignment.Center,
					MaxLines = 0,
					Text = "Default",
					Foreground = SolidColorBrushHelper.FromARGB(255, 13, 121, 252),
#if XAMARIN_IOS
						TextAlignment = UITextAlignment.Center,
						LineBreakMode = MonoTouch.UIKit.UILineBreakMode.TailTruncation,
						//Font = UIFont.FromName("HelveticaNeue-Bold", (float)(25 / _scaleRatio)
#elif XAMARIN_ANDROID
					FontSize = 25,
#endif
				}
					.Binding("Text", new Data.Binding("")))
			}
			.Binding("Content", "Text")
			.Binding("Command", "Command");

			// The button separator (hidden by default)
			var right = new ContentControl
			{
				Width = 1,
				Background = SolidColorBrushHelper.FromARGB(255, 104, 104, 104),
				VerticalAlignment = VerticalAlignment.Stretch,
				HorizontalAlignment = HorizontalAlignment.Right,
				Visibility = Visibility.Collapsed
			};

			var border = new Grid
			{
				button,
				right
			};

			return border;
		}

#if !IS_UNO
		private static void InitExpander()
		{
			var style = new Style(typeof(Uno.UI.Controls.Expander))
			{
				Setters = {
					new Setter<Uno.UI.Controls.Expander>("Template", t =>
						t.Template = new ControlTemplate(() =>
							{
								return new StackPanel {
									Children = {
										new ToggleButton {
										}
										.Binding("IsChecked", new TemplateBinding("IsOpened"))
										.Binding("Content", new TemplateBinding("HeaderContent"))
										.Binding("ContentTemplate", new TemplateBinding("HeaderTemplate")),

										new ContentPresenter {
										}
										.Binding("Content", new TemplateBinding("Content"))
										.Binding("ContentTemplate", new TemplateBinding("ContentTemplate"))
									},
								};
							}
						)
					)
				}
			};

			Style.RegisterDefaultStyleForType(typeof(Uno.UI.Controls.Expander), style);
		}
#endif

		private static void InitDatePicker()
		{
			var style = new Style(typeof(Microsoft.UI.Xaml.Controls.DatePicker))
			{
				Setters = {
					new Setter<DatePicker>("Template", t =>
						t.Template = Funcs.Create(() =>
						{

							return new BindableDatePicker(ContextHelper.Current);
						})
					)
				}
			};

			Style.RegisterDefaultStyleForType(typeof(Microsoft.UI.Xaml.Controls.DatePicker), style);
		}


		private static void InitWebView()
		{
			var style = new Style(typeof(Microsoft.UI.Xaml.Controls.WebView))
			{
				Setters = {
					new Setter<WebView>("Template", t =>
						t.Template = Funcs.Create(() =>
							new Android.Webkit.WebView(ContextHelper.Current)
						)
					)
				}
			};

			Style.RegisterDefaultStyleForType(typeof(Microsoft.UI.Xaml.Controls.WebView), style);
		}

		private static void InitPage()
		{
			var style = new Style(typeof(Microsoft.UI.Xaml.Controls.NativePage))
			{
			};

			Style.RegisterDefaultStyleForType(typeof(Microsoft.UI.Xaml.Controls.NativePage), style);
		}

		private static void InitItemsControl()
		{
			var style = new Style(typeof(Microsoft.UI.Xaml.Controls.ItemsControl))
			{
				Setters = {
					new Setter<ItemsControl>("Template", t =>
						t.Template = Funcs.Create(() => new ItemsPresenter()
							.Binding(ItemsPresenter.PaddingProperty.Name, new TemplateBinding(ItemsControl.PaddingProperty.Name))
						)
					)
				}
			};

			Style.RegisterDefaultStyleForType(typeof(Microsoft.UI.Xaml.Controls.ItemsControl), style);
		}
		
		private static void InitFlipView()
		{
			var style = new Style(typeof(Microsoft.UI.Xaml.Controls.FlipView))
			{
				Setters =
				{
					new Setter<FlipView>("ItemsPanel", t=>
						t.ItemsPanel = new ItemsPanelTemplate(()=>
							new NativePagedView()
						)
					),
					new Setter<FlipView>("Template", t =>
						t.Template = new ControlTemplate(() =>
							new ItemsPresenter()
						)
					)					
				}
			};

			Style.RegisterDefaultStyleForType(typeof(Microsoft.UI.Xaml.Controls.FlipView), style);
		}
		
		private static void InitToggleSwitch()
		{
			var style = new Style(typeof(Microsoft.UI.Xaml.Controls.ToggleSwitch))
			{
				Setters = {
					new Setter<ToggleSwitch>("Template", t =>
						t.Template = Funcs.Create(() =>
							{
								var nativeToggleButton =
									new BindableSwitchCompat()
									.Binding("Checked", new TemplateBinding("IsOn") { Mode = BindingMode.TwoWay })
									.Binding("Enabled", new Data.TemplateBinding("IsEnabled"))
									.Binding("Text", new Data.TemplateBinding("Header"))
									;
							
								return nativeToggleButton;
							}
						)
					)
				}
			};

			Style.RegisterDefaultStyleForType(typeof(Microsoft.UI.Xaml.Controls.ToggleSwitch), style);
		}

		private static void InitContentControl()
		{
			var style = new Style(typeof(ContentControl))
			{
				Setters = {
					new Setter<ContentControl>("Template", t =>
						t.Template = Funcs.Create(() =>
							new ContentPresenter()
								.Binding("Content", new TemplateBinding("Content"))
								.Binding("ContentTemplate", new TemplateBinding("ContentTemplate"))
								.Binding("Margin", new TemplateBinding("Padding"))
								.Binding("HorizontalAlignment", new TemplateBinding("HorizontalContentAlignment"))
								.Binding("VerticalAlignment", new TemplateBinding("VerticalContentAlignment"))
						)
					),
					new Setter<ContentControl>("HorizontalContentAlignment", t => t.HorizontalContentAlignment = HorizontalAlignment.Left),
					new Setter<ContentControl>("VerticalContentAlignment", t => t.VerticalContentAlignment = VerticalAlignment.Top)
				}
			};

			Style.RegisterDefaultStyleForType(typeof(ContentControl), style);
		}

		private static void InitFlyoutPresenter()
		{
			var style = new Style(typeof(FlyoutPresenter))
			{
				Setters = {
					new Setter<FlyoutPresenter>("Template", t =>
						t.Template = Funcs.Create(() =>
							new Border()
							{
								Child = new ContentPresenter()
									.Binding("Content", new TemplateBinding("Content"))
									.Binding("ContentTemplate", new TemplateBinding("ContentTemplate"))
									.Binding("Margin", new TemplateBinding("Padding"))
									.Binding("HorizontalAlignment", new TemplateBinding("HorizontalContentAlignment"))
									.Binding("VerticalAlignment", new TemplateBinding("VerticalContentAlignment"))
							}
							.Binding("Background", new TemplateBinding("Background"))
							.Binding("BorderBrush", new TemplateBinding("BorderBrush"))
							.Binding("BorderThickness", new TemplateBinding("BorderThickness"))
						)
					),
					new Setter<FlyoutPresenter>("HorizontalContentAlignment", t => t.HorizontalContentAlignment = HorizontalAlignment.Stretch),
					new Setter<FlyoutPresenter>("VerticalContentAlignment", t => t.VerticalContentAlignment = VerticalAlignment.Stretch)
				}
			};

			Style.RegisterDefaultStyleForType(typeof(FlyoutPresenter), style);
		}
	}
}
