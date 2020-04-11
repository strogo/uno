using System.Web;
using Uno.UI.UI.Xaml.Documents;

namespace Microsoft.UI.Xaml.Documents
{
	partial class Run
	{
		partial void OnTextChangedPartial()
		{
			this.SetText(Text);
		}
	}
}
