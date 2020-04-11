#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class XamlLight : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.CompositionLight CompositionLight
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionLight XamlLight.CompositionLight is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.XamlLight", "CompositionLight XamlLight.CompositionLight");
			}
		}
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Media.XamlLight.XamlLight()
		// Forced skipping of method Microsoft.UI.Xaml.Media.XamlLight.XamlLight()
		// Forced skipping of method Microsoft.UI.Xaml.Media.XamlLight.CompositionLight.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.XamlLight.CompositionLight.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual string GetId()
		{
			throw new global::System.NotImplementedException("The member string XamlLight.GetId() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnConnected( global::Microsoft.UI.Xaml.UIElement newElement)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.XamlLight", "void XamlLight.OnConnected(UIElement newElement)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		protected virtual void OnDisconnected( global::Microsoft.UI.Xaml.UIElement oldElement)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.XamlLight", "void XamlLight.OnDisconnected(UIElement oldElement)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void AddTargetElement( string lightId,  global::Microsoft.UI.Xaml.UIElement element)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.XamlLight", "void XamlLight.AddTargetElement(string lightId, UIElement element)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void RemoveTargetElement( string lightId,  global::Microsoft.UI.Xaml.UIElement element)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.XamlLight", "void XamlLight.RemoveTargetElement(string lightId, UIElement element)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void AddTargetBrush( string lightId,  global::Microsoft.UI.Xaml.Media.Brush brush)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.XamlLight", "void XamlLight.AddTargetBrush(string lightId, Brush brush)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static void RemoveTargetBrush( string lightId,  global::Microsoft.UI.Xaml.Media.Brush brush)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.XamlLight", "void XamlLight.RemoveTargetBrush(string lightId, Brush brush)");
		}
		#endif
	}
}
