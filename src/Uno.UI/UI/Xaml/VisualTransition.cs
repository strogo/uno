using Uno.Extensions;
using Microsoft.UI.Xaml.Media.Animation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml
{
	[ContentProperty(Name = "Storyboard")]
	public partial class VisualTransition : DependencyObject
	{
		public VisualTransition()
		{
			IsAutoPropertyInheritanceEnabled = false;
			InitializeBinder();
		}

		public string From { get; set; }

		public string To { get; set; }


		#region Storyboard DependencyProperty

		public Storyboard Storyboard
		{
			get { return (Storyboard)this.GetValue(StoryboardProperty); }
			set { this.SetValue(StoryboardProperty, value); }
		}

		public static readonly DependencyProperty StoryboardProperty =
			DependencyProperty.Register(
				"Storyboard",
				typeof(Storyboard),
				typeof(VisualTransition),
				new FrameworkPropertyMetadata(
					defaultValue: null,
					options: FrameworkPropertyMetadataOptions.LogicalChild
				)
			);

		#endregion
    }
}
