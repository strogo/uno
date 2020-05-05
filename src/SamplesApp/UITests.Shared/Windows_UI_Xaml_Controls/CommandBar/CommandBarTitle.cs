﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.Foundation;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Uno.UI.Samples.Content.UITests.CommandBar
{
	/// <summary>
	/// Control with multiple parts, to test CommandBar
	/// </summary>
    public partial class CommandBarTitle : Control
    {
		public CommandBarTitle()
		{
			this.DefaultStyleKey = typeof(CommandBarTitle);
		}
		

		public string MainTitle
		{
			get { return (string)GetValue(MainTitleProperty); }
			set { SetValue(MainTitleProperty, value); }
		}
		
		public static readonly DependencyProperty MainTitleProperty =
			DependencyProperty.Register("MainTitle", typeof(string), typeof(CommandBarTitle), new PropertyMetadata(string.Empty));
		
		public string SubTitle1
		{
			get { return (string)GetValue(SubTitle1Property); }
			set { SetValue(SubTitle1Property, value); }
		}
		
		public static readonly DependencyProperty SubTitle1Property =
			DependencyProperty.Register("SubTitle1", typeof(string), typeof(CommandBarTitle), new PropertyMetadata(string.Empty));

		public string SubTitle2
		{
			get { return (string)GetValue(SubTitle2Property); }
			set { SetValue(SubTitle2Property, value); }
		}

		public static readonly DependencyProperty SubTitle2Property =
			DependencyProperty.Register("SubTitle2", typeof(string), typeof(CommandBarTitle), new PropertyMetadata(string.Empty));
	}
}
