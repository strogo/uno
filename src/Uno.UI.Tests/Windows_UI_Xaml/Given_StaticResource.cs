﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uno.UI.Tests.App.Views;
using Uno.UI.Tests.App.Xaml;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Uno.UI.Tests.Windows_UI_Xaml
{
	[TestClass]
	public class Given_StaticResource
	{
		[TestMethod]
		public void When_Resource_In_Application_Merged()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();
			Assert.AreEqual(Colors.MediumSpringGreen, (control.TopGrid.Background as SolidColorBrush).Color); //Resource is resolved before control is in visual tree

			app.HostView.Children.Add(control);

			Assert.AreEqual(Colors.MediumSpringGreen, (control.TopGrid.Background as SolidColorBrush).Color);
		}

		[TestMethod]
		public void When_Double_Resource_In_Application_Merged()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();
			app.HostView.Children.Add(control);

			Assert.AreEqual(256, control.TestBorder.Width);
		}

		[TestMethod]
		public void When_Double_Resource_In_Application_Merged_Non_View()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();
			app.HostView.Children.Add(control);

			var rowDef = control.TestGrid.RowDefinitions.First();
			Assert.AreEqual(256, rowDef.Height.Value);
		}

		[TestMethod]
		public void When_In_Same_Dictionary()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();
			app.HostView.Children.Add(control);

			Assert.AreEqual(33, control.StyledButton.FontSize);
		}

		[TestMethod]
		public void When_In_Dictionary_Merged()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();
			app.HostView.Children.Add(control);

			Assert.AreEqual(new Thickness(1, 2, 3, 4), control.StyledButton.BorderThickness);
		}

		[TestMethod]
		public void When_Set_On_Non_DependencyObject()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();
			app.HostView.Children.Add(control);

			Assert.AreEqual(33, control.TestMyControl.Poco.Bogosity);
		}

		[TestMethod]
		public void When_Setting_Non_DependencyProperty()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();
			app.HostView.Children.Add(control);

			Assert.AreEqual(33, control.TestMyControl.Splinitude);
		}

		[TestMethod]
		public void When_Inherited_In_Template()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();

			app.HostView.Children.Add(control);

			control.Measure(new Size(1000, 1000));

			var text1InlineAfter = control.InlineTemplateControl.TextBlock1.Text;

			Assert.AreEqual("LocalVisualTree", text1InlineAfter);
		}

		[TestMethod]
		[Ignore("Uno's StaticResource resolution doesn't exactly match UWP. Here, we don't use the parse-time scope.")]
		public void When_Inherited_In_Template_XAML_Scope()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();

			app.HostView.Children.Add(control);

			control.Measure(new Size(1000, 1000));
			
			var text1ResourceTemplateAfter = control.TemplateFromResourceControl.TextBlock1.Text;
			
			Assert.AreEqual("OuterVisualTree", text1ResourceTemplateAfter);
		}

		[TestMethod]
		[Ignore("Uno's StaticResource resolution doesn't exactly match UWP. Here, we don't use the parse-time scope.")]
		public void When_Inherited_In_Template_Applied()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();

			control.InlineTemplateControl.ApplyTemplate();
			control.TemplateFromResourceControl.ApplyTemplate();

			var text1InlineBefore = control.InlineTemplateControl.TextBlock1.Text;
			var text1ResourceTemplateBefore = control.TemplateFromResourceControl.TextBlock1.Text;

			var text3InlineBefore = control.InlineTemplateControl.TextBlock3.Text;
			var text3ResourceTemplateBefore = control.TemplateFromResourceControl.TextBlock3.Text;

			app.HostView.Children.Add(control);

			var text1InlineAfter = control.InlineTemplateControl.TextBlock1.Text;
			var text1ResourceTemplateAfter = control.TemplateFromResourceControl.TextBlock1.Text;

			Assert.AreEqual("LocalVisualTree", text1InlineBefore);
			Assert.AreEqual("OuterVisualTree", text1ResourceTemplateBefore);

			Assert.AreEqual("ApplicationLevel", text3InlineBefore);
			Assert.AreEqual("ApplicationLevel", text3ResourceTemplateBefore);

			Assert.AreEqual("LocalVisualTree", text1InlineAfter);
			Assert.AreEqual("OuterVisualTree", text1ResourceTemplateAfter);
		}

		[TestMethod]
		public void When_Multiple_References_Framework_DependencyObject()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();

			app.HostView.Children.Add(control);

			control.Measure(new Size(1000, 1000));

			var foreground = control.InlineTemplateControl.TextBlock1.Foreground as SolidColorBrush;
			var background = control.TemplateFromResourceControl.Background as SolidColorBrush;
			var inResources = control.Resources["MutatedColorBrush"] as SolidColorBrush;

			Assert.AreEqual(Colors.Chartreuse, foreground.Color);
			Assert.AreEqual(Colors.Chartreuse, background.Color);
			Assert.AreEqual(Colors.Chartreuse, inResources.Color);

			Assert.IsTrue(ReferenceEquals(foreground, background));
			Assert.IsTrue(ReferenceEquals(inResources, foreground));

			inResources.Color = Colors.GhostWhite;
			Assert.AreEqual(Colors.GhostWhite, foreground.Color);
			Assert.AreEqual(Colors.GhostWhite, background.Color);

			var control2 = new Test_Control();
			app.HostView.Children.Add(control2);
			control2.Measure(new Size(1000, 1000));


			var background2 = control2.TemplateFromResourceControl.Background as SolidColorBrush;
			var areRefEqual = ReferenceEquals(background, background2);
			Assert.IsFalse(areRefEqual);
			Assert.AreEqual(Colors.Chartreuse, background2.Color);
		}

		[TestMethod]
		[Ignore("At the moment, Uno only applies application-level Resources to non-DPs, causing this test to fail.")]
		public void When_Multiple_References_Poco()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();

			var poco1 = control.InlineTemplateControl.Poco;
			var poco2 = control.TemplateFromResourceControl.Poco;
			Assert.IsTrue(ReferenceEquals(poco1, poco2));

			Assert.AreEqual(101, poco1.Bogosity);
			Assert.AreEqual(101, poco2.Bogosity);

			poco1.Bogosity = 107;
			Assert.AreEqual(107, poco2.Bogosity);

			var control2 = new Test_Control();
			var poco3 = control2.InlineTemplateControl.Poco;
			Assert.IsFalse(ReferenceEquals(poco1, poco3));
			Assert.AreEqual(101, poco3.Bogosity);
		}

		[TestMethod]
		public void When_Multiple_References_Custom_DependencyObject()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();

			var do1_1 = control.InlineTemplateControl.DObjDP;
			var do1_2 = control.InlineTemplateControl.PlainDO;
			var do1_3 = control.TemplateFromResourceControl.DObjDP;
			var areRefEqual1 = ReferenceEquals(do1_1, do1_2);
			var areRefEqual2 = ReferenceEquals(do1_1, do1_3);

			var control2 = new Test_Control();
			var do2_1 = control.InlineTemplateControl.DObjDP;
			var areRefEqual3 = ReferenceEquals(do1_1, do2_1);
		}

		[TestMethod]
		public void When_System_Resource()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();

			Assert.AreEqual(Color.FromArgb(0xB3, 0xB6, 0xB6, 0xB6), (control.TopGrid.BorderBrush as SolidColorBrush).Color);
		}

		[TestMethod]
		public void When_Attached_Property_And_App_Resource()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();

			var bulbousness = MyBehavior.GetBulbousness(control.TestTextBlock);
			Assert.AreEqual(256, bulbousness);
		}

		[TestMethod]
		public void When_Attached_Property_And_Local_Resource()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();

			app.HostView.Children.Add(control); // This is only necessary for Uno, which currently doesn't resolve local resources until load-time.

			var bulbousness = MyBehavior.GetBulbousness(control.TestBorder);
			Assert.AreEqual(105.5, bulbousness);
		}

		[TestMethod]
		[Ignore("Uno's load-time resource resolution fails here because SolidColorBrush doesn't have its Parent set. (This is probably because the same Brush is typically used multiple times, requiring support for multi-Parent scenarios.)")]
		public void When_Non_View_And_Local_Brush()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();

			Assert.AreEqual(Colors.MintCream, (control.TemplateFromResourceControl.Foreground as SolidColorBrush).Color);
		}

		[TestMethod]
		public void When_Non_View_And_Local_Resource()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var control = new Test_Control();
			app.HostView.Children.Add(control);

			var rowDef = control.TestGrid.RowDefinitions[1];
			Assert.AreEqual(333, rowDef.Height.Value);
		}

		[TestMethod]
		public void When_ResourceKey_And_System()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var res = app.Resources["ImAStaticResourceInADictColorBrush"] as SolidColorBrush;
			Assert.AreEqual(Colors.LightGray, res.Color);
		}

		[TestMethod]
		public void When_ResourceKey_And_Local()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var res = app.Resources["ResourceKeyLocalReference"] as SolidColorBrush;
			Assert.AreEqual(Colors.MediumSpringGreen, res.Color);
		}

		[TestMethod]
		public void When_ResourceKey_And_Assigned()
		{
			var app = UnitTestsApp.App.EnsureApplication();

			var template = app.Resources["TemplateUsingStaticResourceAlias"] as ControlTemplate;
			var button = new Button { Template = template };
			button.Measure(new Size(1000, 1000));
			var tb = button.FindFirstChild<TextBlock>();
			Assert.AreEqual(Colors.MediumSpringGreen, (tb.Foreground as SolidColorBrush).Color);
		}
	}
}
