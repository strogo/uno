﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.UI.Xaml
{
	public partial class Application
	{
		public Application()
		{
			Current = this;
        }

		private ApplicationTheme GetDefaultSystemTheme() => ApplicationTheme.Light;

		internal void ForceSetRequestedTheme(ApplicationTheme theme) => _requestedTheme = theme;
	}
}
