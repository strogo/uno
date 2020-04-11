using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
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


namespace Uno.UI.Samples.UITests.ImageTestsControl
{
	[SampleControlInfo(category: "Image", controlName: nameof(ImageSourceStream))]
	public sealed partial class ImageSourceStream : Page
	{
		public ImageSourceStream()
		{
			this.InitializeComponent();

			this.Loaded += OnLoaded;
		}

		private const string _imageUrl = "http://placehold.it/420x220&text=Super+Image";

		private async void OnLoaded(object sender, RoutedEventArgs e)
		{
            Stream stream;
#if !NETFX_CORE
			using (var client = new WebClient())
			{
				stream = await client.OpenReadTaskAsync(_imageUrl);
			}
#else
			var request = WebRequest.CreateHttp(_imageUrl);
			var response = await request.GetResponseAsync();
			stream = response.GetResponseStream();
#endif
			using (stream) //Test that SetSourceAsync does not depend on the lifetime of this stream
			{
				var bitmap = new BitmapImage();
#if !NETFX_CORE
				await bitmap.SetSourceAsync(stream);
#else
				var memStream = new MemoryStream();
				await stream.CopyToAsync(memStream);
				memStream.Position = 0;
				using (memStream)
				{
					await bitmap.SetSourceAsync(memStream.AsRandomAccessStream());
				}

#endif
				MyImage.Source = bitmap;

			}

		}
	}
}
