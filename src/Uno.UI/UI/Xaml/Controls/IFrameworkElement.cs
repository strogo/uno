using System;
using System.Drawing;
using System.Linq;
using Uno.Extensions;
using Microsoft.UI.Xaml;
using Uno.UI.DataBinding;
using Microsoft.UI.Xaml.Data;

#if XAMARIN_ANDROID
using View = Android.Views.View;
using Font = Android.Graphics.Typeface;
using Android.Graphics;
#endif

namespace Microsoft.UI.Xaml
{
	public partial interface IFrameworkElement : DependencyObject
	{
	}
}
