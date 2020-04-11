using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using CoreGraphics;
using Uno.UI.Extensions;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Controls.Primitives;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class DatePicker
	{

		/// <summary>
		/// iOS-specific property that allows apps to specify any flyout placement 
		/// (especially FlyoutPlacementMode.Full, which is commonly used on iPhone)
		/// </summary>
		public FlyoutPlacementMode FlyoutPlacement { get; set; }
	}
}
