#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SetterBase : global::Microsoft.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsSealed
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SetterBase.IsSealed is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.SetterBase.IsSealed.get
	}
}
