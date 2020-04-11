#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PivotPanel : global::Microsoft.UI.Xaml.Controls.Panel,global::Microsoft.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AreHorizontalSnapPointsRegular
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool PivotPanel.AreHorizontalSnapPointsRegular is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AreVerticalSnapPointsRegular
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool PivotPanel.AreVerticalSnapPointsRegular is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public PivotPanel() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.PivotPanel", "PivotPanel.PivotPanel()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.PivotPanel.PivotPanel()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.PivotPanel.AreHorizontalSnapPointsRegular.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.PivotPanel.AreVerticalSnapPointsRegular.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.PivotPanel.HorizontalSnapPointsChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.PivotPanel.HorizontalSnapPointsChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.PivotPanel.VerticalSnapPointsChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.PivotPanel.VerticalSnapPointsChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<float> GetIrregularSnapPoints( global::Microsoft.UI.Xaml.Controls.Orientation orientation,  global::Microsoft.UI.Xaml.Controls.Primitives.SnapPointsAlignment alignment)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<float> PivotPanel.GetIrregularSnapPoints(Orientation orientation, SnapPointsAlignment alignment) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  float GetRegularSnapPoints( global::Microsoft.UI.Xaml.Controls.Orientation orientation,  global::Microsoft.UI.Xaml.Controls.Primitives.SnapPointsAlignment alignment, out float offset)
		{
			throw new global::System.NotImplementedException("The member float PivotPanel.GetRegularSnapPoints(Orientation orientation, SnapPointsAlignment alignment, out float offset) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::System.EventHandler<object> HorizontalSnapPointsChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.PivotPanel", "event EventHandler<object> PivotPanel.HorizontalSnapPointsChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.PivotPanel", "event EventHandler<object> PivotPanel.HorizontalSnapPointsChanged");
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
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.PivotPanel", "event EventHandler<object> PivotPanel.VerticalSnapPointsChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.PivotPanel", "event EventHandler<object> PivotPanel.VerticalSnapPointsChanged");
			}
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo
	}
}
