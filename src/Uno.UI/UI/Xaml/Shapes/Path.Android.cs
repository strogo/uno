using Windows.Foundation;
using Microsoft.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Shapes
{
	public partial class Path : ArbitraryShapeBase
	{
		protected override Android.Graphics.Path GetPath(Size availableSize)
		{
			var streamGeometry = Data.ToStreamGeometry();
			return streamGeometry?.ToPath();
		}

		partial void OnDataChanged()
		{
			RequestLayout();
		}
	}
}
