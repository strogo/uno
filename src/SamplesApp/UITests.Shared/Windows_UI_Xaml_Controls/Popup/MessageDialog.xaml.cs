﻿using System;
using System.Threading.Tasks;
using Uno.UI.Samples.Controls;
using Windows.UI.Popups;
using Microsoft.UI.Xaml.Controls;

namespace UITests.Shared.Windows_UI_Xaml_Controls.Popup
{
	[SampleControlInfo("Popup", "MessageDialog", description:"The dialog dims the screen behind it and blocks touch events from passing to the app's canvas until the user responds.")]
	public sealed partial class MessageDialog : Page
	{
		private const string _title = "Internet Connectivity";

		public MessageDialog()
		{
			this.InitializeComponent();

			WithoutTitle.Tapped += (snd, evt) =>
			{
				var messageDialog = new Windows.UI.Popups.MessageDialog("No internet connection has been found.");

				Task.Run(async () => await messageDialog.ShowAsync());
			};

			WithTitle.Tapped += (snd, evt) =>
			{
				var messageDialog = new Windows.UI.Popups.MessageDialog("No internet connection has been found.");
				messageDialog.Title = "Internet Connectivity";

				Task.Run(async () => await messageDialog.ShowAsync());
			};


			WithOneCommandAndTitle.Tapped += (snd, evt) =>
			{
				var messageDialog = new Windows.UI.Popups.MessageDialog("No internet connection has been found.");

				messageDialog.Commands.Add(new UICommand("Acknowledge", new UICommandInvokedHandler(this.CommandInvokedHandler)));
				messageDialog.Title = "Internet Connectivity";

				Task.Run(async () => await messageDialog.ShowAsync());
			};

			WithTwoCommandsAndTitle.Tapped += (snd, evt) =>
			{
				var messageDialog = new Windows.UI.Popups.MessageDialog("No internet connection has been found.");
				messageDialog.Title = "Internet Connectivity";

				messageDialog.Commands.Add(new UICommand("Try Again", new UICommandInvokedHandler(this.CommandInvokedHandler)));
				messageDialog.DefaultCommandIndex = 0;

				messageDialog.Commands.Add(new UICommand("Cancel",new UICommandInvokedHandler(this.CommandInvokedHandler)));
				messageDialog.DefaultCommandIndex = 1;

				Task.Run(async () => await messageDialog.ShowAsync());
			};

			WithThreeCommandsAndTitle.Tapped += (snd, evt) =>
			{
				var messageDialog = new Windows.UI.Popups.MessageDialog("No internet connection has been found.");
				messageDialog.Title = "My Cool Title";

				messageDialog.Commands.Add(new UICommand("Try Again", new UICommandInvokedHandler(this.CommandInvokedHandler)));
				messageDialog.DefaultCommandIndex = 0;

				messageDialog.Commands.Add(new UICommand("Reset Network Settings",new UICommandInvokedHandler(this.CommandInvokedHandler)));

				messageDialog.Commands.Add(new UICommand("Cancel",new UICommandInvokedHandler(this.CommandInvokedHandler)));
				messageDialog.CancelCommandIndex = 2;

				Task.Run(async () => await messageDialog.ShowAsync());
			};

		}

		private void CommandInvokedHandler(IUICommand command)
		{
		}
	}
}
