using System;
using System.Collections.Generic;
using System.Text;
using Uno.Extensions;
using Uno.Disposables;
using Uno.Logging;
using Uno.UI;
using Microsoft.UI.Xaml.Input;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class ToggleSwitch
	{
		partial void OnLoadedPartial()
		{
			Clickable = true;
			Focusable = true;
			FocusableInTouchMode = true;
		}
	}
}
