﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Core;

namespace Microsoft.UI.Xaml
{
	/// <summary>
	/// The dependency object interface.
	/// </summary>
	/// <remarks>This diverges from UWP's dependency object to be able to make any object a dependency object</remarks>
	public partial interface DependencyObject
	{
		CoreDispatcher Dispatcher { get; }

		object GetValue(DependencyProperty dp);

		void SetValue(DependencyProperty dp, object value);

		void ClearValue(DependencyProperty dp);

		object ReadLocalValue(DependencyProperty dp);

		object GetAnimationBaseValue(DependencyProperty dp);

		long RegisterPropertyChangedCallback(DependencyProperty dp, DependencyPropertyChangedCallback callback);

		void UnregisterPropertyChangedCallback(DependencyProperty dp, long token);
	}
}
