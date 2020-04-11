﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UITests.Shared.Windows_UI_Xaml_Controls.Button
{
	[SampleControlInfo("Button", "RadioButton_Pressed", description: "RadioButtons with a lower opacity when in pressed state. Tapping on any zone should have the same result.")]
	public sealed partial class RadioButton_Pressed : UserControl
    {
        public RadioButton_Pressed()
        {
            this.InitializeComponent();
        }
	}


	public class FromNullableBoolToCustomValueConverter : IValueConverter
	{
		public object NullOrFalseValue { get; set; }
		public object TrueValue { get; set; }

		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if (value == null || !System.Convert.ToBoolean(value, CultureInfo.InvariantCulture))
			{
				return NullOrFalseValue;
			}
			else
			{
				return TrueValue;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}
