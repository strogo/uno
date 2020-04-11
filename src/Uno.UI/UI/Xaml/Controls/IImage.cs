using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.UI.Xaml.Controls
{
    public interface IImage : IFrameworkElement
    {
		ImageSource Source { get; set; }

		Stretch Stretch { get; set; }
    }
}
