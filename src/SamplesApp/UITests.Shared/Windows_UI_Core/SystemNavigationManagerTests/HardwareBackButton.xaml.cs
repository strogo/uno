using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Uno.UI.Samples.Controls;

namespace UITests.Shared.Windows_UI_Core.SystemNavigationManagerTests
{
	[SampleControlInfo("SystemNavigationManager", "HardwareBackButton")]
	public sealed partial class HardwareBackButton : Page
	{
		public HardwareBackButton()
		{
			this.InitializeComponent();

			Loaded += (snd, e) => Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;
			Unloaded += (snd, e) => Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested -= OnBackRequested;
		}

		private void Enable(object sender, TappedRoutedEventArgs e)
		{
			_output.Text += "Enable\r\n";
			Windows.UI.Core.SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
		}

		private void Disable(object sender, TappedRoutedEventArgs e)
		{
			_output.Text += "Collapse\r\n";
			Windows.UI.Core.SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
		}

		private void OnBackRequested(object sender, BackRequestedEventArgs args)
		{
			_output.Text += "Back requested\r\n";
			args.Handled = _handle.IsChecked.GetValueOrDefault();
		}
	}
}
