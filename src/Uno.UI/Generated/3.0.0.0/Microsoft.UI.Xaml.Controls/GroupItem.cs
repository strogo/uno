#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GroupItem : global::Microsoft.UI.Xaml.Controls.ContentControl
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public GroupItem() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.GroupItem", "GroupItem.GroupItem()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.GroupItem.GroupItem()
	}
}
