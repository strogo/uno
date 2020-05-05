using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Microsoft.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	public sealed partial class TickBar : FrameworkElement
	{

		#region Fill DependencyProperty

		public Brush Fill
		{
			get { return (Brush)GetValue(FillProperty); }
			set { SetValue(FillProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Fill.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty FillProperty =
			DependencyProperty.Register("Fill", typeof(Brush), typeof(TickBar), new PropertyMetadata(null, (s, e) => ((TickBar)s)?.OnFillChanged(e)));


		private void OnFillChanged(DependencyPropertyChangedEventArgs e)
		{

		}

		#endregion

		public TickBar()
		{

		}
	}
}
