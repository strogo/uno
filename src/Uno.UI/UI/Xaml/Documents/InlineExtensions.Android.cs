﻿using System;
using System.Linq;
using Uno.Extensions;
using Microsoft.UI.Xaml.Controls;
using Android.Text;
using Android.Text.Style;
using System.Collections.Generic;
using Uno.UI;
using Microsoft.UI.Xaml.Media;
using Windows.UI.Text;

namespace Microsoft.UI.Xaml.Documents
{
	internal static partial class InlineExtensions
	{
		internal static TextPaint GetPaint(this Inline inline)
		{
			return Uno.UI.Controls.TextPaintPool.GetPaint(
				inline.FontWeight,
				inline.FontStyle,
				inline.FontFamily,
				inline.FontSize,
				inline.CharacterSpacing,
				(inline.Foreground as SolidColorBrush)?.Color ?? Colors.Transparent,
				inline.BaseLineAlignment,
				inline.TextDecorations
			);
		}
	}
}