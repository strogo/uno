#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DurationHelper 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Duration Automatic
		{
			get
			{
				throw new global::System.NotImplementedException("The member Duration DurationHelper.Automatic is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Duration Forever
		{
			get
			{
				throw new global::System.NotImplementedException("The member Duration DurationHelper.Forever is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.DurationHelper.Automatic.get
		// Forced skipping of method Microsoft.UI.Xaml.DurationHelper.Forever.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static int Compare( global::Microsoft.UI.Xaml.Duration duration1,  global::Microsoft.UI.Xaml.Duration duration2)
		{
			throw new global::System.NotImplementedException("The member int DurationHelper.Compare(Duration duration1, Duration duration2) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Duration FromTimeSpan( global::System.TimeSpan timeSpan)
		{
			throw new global::System.NotImplementedException("The member Duration DurationHelper.FromTimeSpan(TimeSpan timeSpan) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool GetHasTimeSpan( global::Microsoft.UI.Xaml.Duration target)
		{
			throw new global::System.NotImplementedException("The member bool DurationHelper.GetHasTimeSpan(Duration target) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Duration Add( global::Microsoft.UI.Xaml.Duration target,  global::Microsoft.UI.Xaml.Duration duration)
		{
			throw new global::System.NotImplementedException("The member Duration DurationHelper.Add(Duration target, Duration duration) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool Equals( global::Microsoft.UI.Xaml.Duration target,  global::Microsoft.UI.Xaml.Duration value)
		{
			throw new global::System.NotImplementedException("The member bool DurationHelper.Equals(Duration target, Duration value) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Microsoft.UI.Xaml.Duration Subtract( global::Microsoft.UI.Xaml.Duration target,  global::Microsoft.UI.Xaml.Duration duration)
		{
			throw new global::System.NotImplementedException("The member Duration DurationHelper.Subtract(Duration target, Duration duration) is not implemented in Uno.");
		}
		#endif
	}
}
