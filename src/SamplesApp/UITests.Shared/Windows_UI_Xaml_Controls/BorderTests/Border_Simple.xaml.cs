using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
#if NETFX_CORE
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
#elif HAS_UNO
using Microsoft.UI.Xaml.Controls;
using System.Globalization;
#endif

namespace Uno.UI.Samples.UITests.BorderTestsControl
{
	[SampleControlInfo("Border", "Border_Simple")]
	public sealed partial class Border_Simple : UserControl
	{
		public Border_Simple()
		{
			this.InitializeComponent();
		}
	}
}
