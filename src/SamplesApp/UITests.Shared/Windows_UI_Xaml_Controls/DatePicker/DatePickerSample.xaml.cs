using UITests.Shared.Windows_UI_Xaml_Controls.DatePicker.Models;
using Uno.UI.Samples.Controls;
using Microsoft.UI.Xaml.Controls;

namespace UITests.Shared.Windows_UI_Xaml_Controls.DatePicker
{
	[SampleControlInfo(viewModelType: typeof(DatePickerViewModel))]
	public sealed partial class DatePickerSample : UserControl
	{
		public DatePickerSample()
		{
			this.InitializeComponent();
		}
	}
}
