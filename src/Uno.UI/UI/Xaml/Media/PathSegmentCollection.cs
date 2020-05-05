using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.UI.Xaml.Media
{
	public partial class PathSegmentCollection : DependencyObjectCollection<PathSegment>
	{
		public PathSegmentCollection()
		{
		}

		private protected override void OnCollectionChanged()
		{
			base.OnCollectionChanged();
			this.InvalidateMeasure();
		}
	}
}
