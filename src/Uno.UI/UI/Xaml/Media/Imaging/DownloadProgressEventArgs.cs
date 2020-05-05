using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Microsoft.UI.Xaml.Media.Imaging
{
	public sealed partial class DownloadProgressEventArgs
	{
		/// <summary>
		/// Gets download progress as a value that is between 0 and 100.
		/// </summary>
		public int Progress
		{
			get;
			set;
		}
	}
}
