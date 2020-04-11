using System;
using Microsoft.UI.Xaml.Controls;
using Uno.Extensions;

#if XAMARIN_ANDROID
using View = Android.Views.View;
using ViewGroup = Android.Views.ViewGroup;
#elif XAMARIN_IOS_UNIFIED
using View = UIKit.UIView;
using Color = UIKit.UIColor;
using Font = UIKit.UIFont;
#elif __MACOS__
using View = AppKit.NSView;
using ViewGroup = AppKit.NSView;
#else
using View = Microsoft.UI.Xaml.UIElement;
#endif

namespace Microsoft.UI.Xaml.Controls
{
	public partial class ItemsPanelTemplate : FrameworkTemplate
	{
		public ItemsPanelTemplate() : this(null) { }

		public ItemsPanelTemplate(Func<View> factory)
			: base (factory)
		{
		}

		public static implicit operator ItemsPanelTemplate(Func<View> obj)
		{
			return new ItemsPanelTemplate(obj);
		}

		public static implicit operator Func<View>(ItemsPanelTemplate obj)
		{
			return () => (View)obj.LoadContent();
		}

		public new View LoadContent()
		{
			return (View)base.LoadContent();
		}
	}
}

