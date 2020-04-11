#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class KeyboardAccelerator : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Microsoft.UI.Xaml.DependencyObject ScopeOwner
		{
			get
			{
				return (global::Microsoft.UI.Xaml.DependencyObject)this.GetValue(ScopeOwnerProperty);
			}
			set
			{
				this.SetValue(ScopeOwnerProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.System.VirtualKeyModifiers Modifiers
		{
			get
			{
				return (global::Windows.System.VirtualKeyModifiers)this.GetValue(ModifiersProperty);
			}
			set
			{
				this.SetValue(ModifiersProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.System.VirtualKey Key
		{
			get
			{
				return (global::Windows.System.VirtualKey)this.GetValue(KeyProperty);
			}
			set
			{
				this.SetValue(KeyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsEnabled
		{
			get
			{
				return (bool)this.GetValue(IsEnabledProperty);
			}
			set
			{
				this.SetValue(IsEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"IsEnabled", typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Input.KeyboardAccelerator), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty KeyProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Key", typeof(global::Windows.System.VirtualKey), 
			typeof(global::Microsoft.UI.Xaml.Input.KeyboardAccelerator), 
			new FrameworkPropertyMetadata(default(global::Windows.System.VirtualKey)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ModifiersProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"Modifiers", typeof(global::Windows.System.VirtualKeyModifiers), 
			typeof(global::Microsoft.UI.Xaml.Input.KeyboardAccelerator), 
			new FrameworkPropertyMetadata(default(global::Windows.System.VirtualKeyModifiers)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.DependencyProperty ScopeOwnerProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			"ScopeOwner", typeof(global::Microsoft.UI.Xaml.DependencyObject), 
			typeof(global::Microsoft.UI.Xaml.Input.KeyboardAccelerator), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.DependencyObject)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Input.KeyboardAccelerator.KeyboardAccelerator()
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.KeyboardAccelerator()
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.Key.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.Key.set
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.Modifiers.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.Modifiers.set
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.IsEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.IsEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.ScopeOwner.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.ScopeOwner.set
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.Invoked.add
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.Invoked.remove
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.KeyProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.ModifiersProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.IsEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Input.KeyboardAccelerator.ScopeOwnerProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Input.KeyboardAccelerator, global::Microsoft.UI.Xaml.Input.KeyboardAcceleratorInvokedEventArgs> Invoked
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Input.KeyboardAccelerator", "event TypedEventHandler<KeyboardAccelerator, KeyboardAcceleratorInvokedEventArgs> KeyboardAccelerator.Invoked");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Input.KeyboardAccelerator", "event TypedEventHandler<KeyboardAccelerator, KeyboardAcceleratorInvokedEventArgs> KeyboardAccelerator.Invoked");
			}
		}
		#endif
	}
}
