using Uno.UI.Samples.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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


// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Uno.UI.Samples.UITests.BorderTestsControl
{
	[SampleControlInfo("Border", "Uniform_Thickness_and_Small_Radius")]
	public sealed partial class Uniform_Thickness_and_Small_Radius : UserControl
	{
		public Uniform_Thickness_and_Small_Radius()
		{
			this.InitializeComponent();
		}
	}
}
