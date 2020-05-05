using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
using Uno.UI.Samples.Helper;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;

namespace Uno.UI.Samples.UITests.ImageBrushTestControl
{
	[SampleControlInfo("ImageBrushTestControl", "ImageBrush_StreamSource")]
	public sealed partial class ImageBrush_StreamSource : UserControl
	{
		private readonly ImageBrush_StreamSource_Data _context;

		public ImageBrush_StreamSource()
		{
			this.InitializeComponent();

			DataContext = _context = new ImageBrush_StreamSource_Data();

			this.RunWhileLoaded(async ct =>
			{
				var data = await new HttpClient().GetByteArrayAsync("http://www.google.com/logos/2006/worldcup06_pt.gif");

				var bitmapImage = new BitmapImage();

#if NETFX_CORE
				var stream = new MemoryStream(data).AsRandomAccessStream();
#else
				var stream = new MemoryStream(data);
#endif
				using (stream)  //Test that SetSourceAsync does not depend on the lifetime of this stream
				{
					await bitmapImage.SetSourceAsync(stream);
					_context.MySource = bitmapImage;
				}
			});
		}
	}

	public partial class ImageBrush_StreamSource_Data : DependencyObject
	{
		public ImageBrush_StreamSource_Data()
		{
		}

#region MySource DependencyProperty

		public ImageSource MySource
		{
			get { return (ImageSource)this.GetValue(MySourceProperty); }
			set { this.SetValue(MySourceProperty, value); }
		}

		// Using a DependencyProperty as the backing store for MySource.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty MySourceProperty =
			DependencyProperty.Register("MySource", typeof(ImageSource), typeof(ImageBrush_StreamSource_Data), new PropertyMetadata(null));

#endregion

	}
}
