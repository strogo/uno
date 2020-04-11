using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	public partial class PickerFlyoutBase : FlyoutBase
	{
#if __IOS__ || __ANDROID__
		protected PickerFlyoutBase()
		{
		}
#endif
	}
}
