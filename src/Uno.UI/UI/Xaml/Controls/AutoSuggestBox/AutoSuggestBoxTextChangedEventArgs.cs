#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	public  partial class AutoSuggestBoxTextChangedEventArgs : global::Microsoft.UI.Xaml.DependencyObject
	{
		public AutoSuggestionBoxTextChangeReason Reason
		{
			get => (AutoSuggestionBoxTextChangeReason)this.GetValue(ReasonProperty);
			set => this.SetValue(ReasonProperty, value);
		}

		public static global::Microsoft.UI.Xaml.DependencyProperty ReasonProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Reason", typeof(AutoSuggestionBoxTextChangeReason), 
			typeof(global::Microsoft.UI.Xaml.Controls.AutoSuggestBoxTextChangedEventArgs), 
			new FrameworkPropertyMetadata(default(AutoSuggestionBoxTextChangeReason)));

		public AutoSuggestBoxTextChangedEventArgs() : base()
		{
		}
	}
}
