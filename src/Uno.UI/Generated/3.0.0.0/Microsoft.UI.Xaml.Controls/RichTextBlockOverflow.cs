#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RichTextBlockOverflow : global::Microsoft.UI.Xaml.FrameworkElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Thickness Padding
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Thickness)this.GetValue(PaddingProperty);
			}
			set
			{
				this.SetValue(PaddingProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.RichTextBlockOverflow OverflowContentTarget
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.RichTextBlockOverflow)this.GetValue(OverflowContentTargetProperty);
			}
			set
			{
				this.SetValue(OverflowContentTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double BaselineOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double RichTextBlockOverflow.BaselineOffset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Documents.TextPointer ContentEnd
		{
			get
			{
				throw new global::System.NotImplementedException("The member TextPointer RichTextBlockOverflow.ContentEnd is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Controls.RichTextBlock ContentSource
		{
			get
			{
				throw new global::System.NotImplementedException("The member RichTextBlock RichTextBlockOverflow.ContentSource is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Documents.TextPointer ContentStart
		{
			get
			{
				throw new global::System.NotImplementedException("The member TextPointer RichTextBlockOverflow.ContentStart is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool HasOverflowContent
		{
			get
			{
				return (bool)this.GetValue(HasOverflowContentProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int MaxLines
		{
			get
			{
				return (int)this.GetValue(MaxLinesProperty);
			}
			set
			{
				this.SetValue(MaxLinesProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsTextTrimmed
		{
			get
			{
				return (bool)this.GetValue(IsTextTrimmedProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty HasOverflowContentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"HasOverflowContent", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.RichTextBlockOverflow), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty OverflowContentTargetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"OverflowContentTarget", typeof(global::Microsoft.UI.Xaml.Controls.RichTextBlockOverflow), 
			typeof(global::Microsoft.UI.Xaml.Controls.RichTextBlockOverflow), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.RichTextBlockOverflow)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty PaddingProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Padding", typeof(global::Microsoft.UI.Xaml.Thickness), 
			typeof(global::Microsoft.UI.Xaml.Controls.RichTextBlockOverflow), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Thickness)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty MaxLinesProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"MaxLines", typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.RichTextBlockOverflow), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsTextTrimmedProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsTextTrimmed", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.RichTextBlockOverflow), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public RichTextBlockOverflow() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RichTextBlockOverflow", "RichTextBlockOverflow.RichTextBlockOverflow()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.RichTextBlockOverflow()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.OverflowContentTarget.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.OverflowContentTarget.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.Padding.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.Padding.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.ContentSource.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.HasOverflowContent.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.ContentStart.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.ContentEnd.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.BaselineOffset.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Documents.TextPointer GetPositionFromPoint( global::Windows.Foundation.Point point)
		{
			throw new global::System.NotImplementedException("The member TextPointer RichTextBlockOverflow.GetPositionFromPoint(Point point) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Focus( global::Microsoft.UI.Xaml.FocusState value)
		{
			throw new global::System.NotImplementedException("The member bool RichTextBlockOverflow.Focus(FocusState value) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.MaxLines.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.MaxLines.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.IsTextTrimmed.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.IsTextTrimmedChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.IsTextTrimmedChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.IsTextTrimmedProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.MaxLinesProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.OverflowContentTargetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.PaddingProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.RichTextBlockOverflow.HasOverflowContentProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.RichTextBlockOverflow, global::Microsoft.UI.Xaml.Controls.IsTextTrimmedChangedEventArgs> IsTextTrimmedChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RichTextBlockOverflow", "event TypedEventHandler<RichTextBlockOverflow, IsTextTrimmedChangedEventArgs> RichTextBlockOverflow.IsTextTrimmedChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.RichTextBlockOverflow", "event TypedEventHandler<RichTextBlockOverflow, IsTextTrimmedChangedEventArgs> RichTextBlockOverflow.IsTextTrimmedChanged");
			}
		}
		#endif
	}
}
