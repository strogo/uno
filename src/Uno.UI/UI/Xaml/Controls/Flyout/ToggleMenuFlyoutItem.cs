using System.Windows.Input;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class ToggleMenuFlyoutItem : MenuFlyoutItem
	{
		public ToggleMenuFlyoutItem()
		{

		}

		#region IsChecked

		public bool IsChecked
		{
			get { return (bool)GetValue(IsCheckedProperty); }
			set { SetValue(IsCheckedProperty, value); }
		}

		public static global::Microsoft.UI.Xaml.DependencyProperty IsCheckedProperty { get; } =
			Microsoft.UI.Xaml.DependencyProperty.Register(
				"IsChecked", typeof(bool),
				typeof(global::Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem),
				new FrameworkPropertyMetadata(default(bool)));

		#endregion
	}
}