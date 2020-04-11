#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LoopingSelectorPanel : global::Microsoft.UI.Xaml.Controls.Canvas,global::Microsoft.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AreHorizontalSnapPointsRegular
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool LoopingSelectorPanel.AreHorizontalSnapPointsRegular is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AreVerticalSnapPointsRegular
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool LoopingSelectorPanel.AreVerticalSnapPointsRegular is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorPanel.AreHorizontalSnapPointsRegular.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorPanel.AreVerticalSnapPointsRegular.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorPanel.HorizontalSnapPointsChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorPanel.HorizontalSnapPointsChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorPanel.VerticalSnapPointsChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorPanel.VerticalSnapPointsChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<float> GetIrregularSnapPoints( global::Microsoft.UI.Xaml.Controls.Orientation orientation,  global::Microsoft.UI.Xaml.Controls.Primitives.SnapPointsAlignment alignment)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<float> LoopingSelectorPanel.GetIrregularSnapPoints(Orientation orientation, SnapPointsAlignment alignment) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float GetRegularSnapPoints( global::Microsoft.UI.Xaml.Controls.Orientation orientation,  global::Microsoft.UI.Xaml.Controls.Primitives.SnapPointsAlignment alignment, out float offset)
		{
			throw new global::System.NotImplementedException("The member float LoopingSelectorPanel.GetRegularSnapPoints(Orientation orientation, SnapPointsAlignment alignment, out float offset) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::System.EventHandler<object> HorizontalSnapPointsChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorPanel", "event EventHandler<object> LoopingSelectorPanel.HorizontalSnapPointsChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorPanel", "event EventHandler<object> LoopingSelectorPanel.HorizontalSnapPointsChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::System.EventHandler<object> VerticalSnapPointsChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorPanel", "event EventHandler<object> LoopingSelectorPanel.VerticalSnapPointsChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.LoopingSelectorPanel", "event EventHandler<object> LoopingSelectorPanel.VerticalSnapPointsChanged");
			}
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo
	}
}
