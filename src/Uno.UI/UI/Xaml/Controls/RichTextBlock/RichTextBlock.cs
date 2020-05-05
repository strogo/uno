#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.Controls
{
	[ContentProperty(Name = nameof(Blocks))]
	public  partial class RichTextBlock : global::Microsoft.UI.Xaml.FrameworkElement
	{
		[global::Uno.NotImplemented]
		public RichTextBlock() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RichTextBlock", "RichTextBlock.RichTextBlock()");

			Blocks = new Documents.BlockCollection();
		}

		public BlockCollection Blocks { get; } 
	}
}
