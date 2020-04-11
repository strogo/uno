using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.UI.Xaml.Controls
{
	internal interface IDeferral
	{
		Action DeferralAction { get; set; }
	}
}
