﻿using Uno.UI.Samples.Controls;
using Microsoft.UI.Xaml.Controls;

namespace UITests.Shared.Windows_UI_Xaml.xBind
{
	[SampleControlInfo("XAML", "xBind")]
	public sealed partial class xBind : UserControl
	{
		public XbindViewModel ViewModel { get; set; }

		public xBind()
		{
			this.InitializeComponent();

			ViewModel = new XbindViewModel(Dispatcher);
		}
	}
}
