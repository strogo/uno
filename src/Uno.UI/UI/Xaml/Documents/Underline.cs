namespace Microsoft.UI.Xaml.Documents
{
	public  partial class Underline : Span
	{
#if !__WASM__
		public Underline()
		{
			TextDecorations = Text.TextDecorations.Underline; // TODO
		}
#endif

		protected override void OnStyleChanged()
		{
			if (Style == null)
			{
				base.Style = Style.DefaultStyleForType(typeof(Underline));
				base.Style.ApplyTo(this);
			}
		}
	}
}
