﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace UITests.Shared.Windows_UI_Xaml_Controls.AutoSuggestBoxTests
{
	[SampleControlInfo("AutoSuggestBox", nameof(BasicAutoSuggestBox))]
	public sealed partial class BasicAutoSuggestBox : UserControl
	{
		private ObservableCollection<string> _suggestions = new ObservableCollection<string>();

		public BasicAutoSuggestBox()
		{
			this.InitializeComponent();
		}

		private bool ShouldClear => ShouldClearTextBox.IsChecked.GetValueOrDefault();

		private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
		{
			if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
			{
				if (ShouldClear || _suggestions.Count > 10)
				{
					_suggestions.Clear();
				}

				_suggestions.Add(sender.Text + "1");
				_suggestions.Add(sender.Text + "2");
			}
			box1.ItemsSource = _suggestions;
		}

		private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
		{
			result.Text = args.SelectedItem.ToString();
		}
	}
}
