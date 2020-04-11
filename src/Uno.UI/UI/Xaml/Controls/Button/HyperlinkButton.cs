using System;
using System.Collections.Generic;
using System.Text;
using Windows.System;
using Microsoft.UI.Xaml.Automation.Peers;
using Microsoft.UI.Xaml.Controls.Primitives;
using Windows.Foundation;
using Microsoft.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class HyperlinkButton : ButtonBase
	{
		public HyperlinkButton()
		{
			InitializeVisualStates();

			Click += (s, e) => TryNavigate();
		}
		
		protected override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			// This differs from UWP, where it looks for a template child named "ContentPresenter", 
			// but ultimately sets the underline on the TextBlock of the first ContentPresenter with a {TemplateBinding Content}.
			// UWP also doesn't seem to do this in OnApplyTemplate (it's done between the first Measure and the first Arrange).
			if (GetTemplateChild("ContentPresenter") is ContentPresenter contentPresenter)
			{
				// Forces ContentPresenter to materialize its template.
				contentPresenter.Measure(new Size(0, 0));
				if (VisualTreeHelper.GetChildrenCount(contentPresenter) == 1 && VisualTreeHelper.GetChild(contentPresenter, 0) is TextBlock textBlock)
				{
					textBlock.TextDecorations = Windows.UI.Text.TextDecorations.Underline;
				}
			}
		}

		#region NavigateUri

		public Uri NavigateUri
		{
			get { return (Uri)GetValue(NavigateUriProperty); }
			set { SetValue(NavigateUriProperty, value); }
		}

		public static global::Microsoft.UI.Xaml.DependencyProperty NavigateUriProperty { get; } =
			Microsoft.UI.Xaml.DependencyProperty.Register(
				"NavigateUri", typeof(global::System.Uri),
				typeof(global::Microsoft.UI.Xaml.Controls.HyperlinkButton),
				new FrameworkPropertyMetadata(default(global::System.Uri)));

#endregion

		private void TryNavigate()
		{
			if (NavigateUri != null)
			{
				Launcher.LaunchUriAsync(NavigateUri);
			}
		}

		partial void NavigatePartial();

		protected override AutomationPeer OnCreateAutomationPeer()
		{
			return new HyperlinkButtonAutomationPeer(this);
		}
	}
}
