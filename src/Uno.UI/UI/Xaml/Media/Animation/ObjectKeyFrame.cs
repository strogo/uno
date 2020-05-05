﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.UI.Xaml.Media.Animation
{
	public partial class ObjectKeyFrame : DependencyObject
	{
		public ObjectKeyFrame()
		{
			IsAutoPropertyInheritanceEnabled = false;
			InitializeBinder();
		}

		#region KeyTime Dependency Property
		public KeyTime KeyTime
		{
			get { return (KeyTime)this.GetValue(KeyTimeProperty); }
			set { this.SetValue(KeyTimeProperty, value); }
		}
		
		// Using a DependencyProperty as the backing store for KeyTime.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty KeyTimeProperty =
			DependencyProperty.Register("KeyTime", typeof(KeyTime), typeof(ObjectKeyFrame), new PropertyMetadata(null));
		#endregion

		#region Value Dependency Property
		public object Value
		{
			get { return (object)this.GetValue(ValueProperty); }
			set { this.SetValue(ValueProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ValueProperty =
			DependencyProperty.Register("Value", typeof(object), typeof(ObjectKeyFrame), new PropertyMetadata(null));
		#endregion
	}
}
