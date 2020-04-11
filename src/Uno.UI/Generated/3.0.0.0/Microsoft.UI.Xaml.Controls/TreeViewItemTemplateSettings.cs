#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class TreeViewItemTemplateSettings : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Visibility CollapsedGlyphVisibility
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Visibility)this.GetValue(CollapsedGlyphVisibilityProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int DragItemsCount
		{
			get
			{
				return (int)this.GetValue(DragItemsCountProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Visibility ExpandedGlyphVisibility
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Visibility)this.GetValue(ExpandedGlyphVisibilityProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.Thickness Indentation
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Thickness)this.GetValue(IndentationProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty CollapsedGlyphVisibilityProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"CollapsedGlyphVisibility", typeof(global::Microsoft.UI.Xaml.Visibility), 
			typeof(global::Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Visibility)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty DragItemsCountProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"DragItemsCount", typeof(int), 
			typeof(global::Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ExpandedGlyphVisibilityProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ExpandedGlyphVisibility", typeof(global::Microsoft.UI.Xaml.Visibility), 
			typeof(global::Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Visibility)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IndentationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Indentation", typeof(global::Microsoft.UI.Xaml.Thickness), 
			typeof(global::Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Thickness)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings.TreeViewItemTemplateSettings()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings.TreeViewItemTemplateSettings()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings.ExpandedGlyphVisibility.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings.CollapsedGlyphVisibility.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings.Indentation.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings.DragItemsCount.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings.ExpandedGlyphVisibilityProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings.CollapsedGlyphVisibilityProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings.IndentationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TreeViewItemTemplateSettings.DragItemsCountProperty.get
	}
}
