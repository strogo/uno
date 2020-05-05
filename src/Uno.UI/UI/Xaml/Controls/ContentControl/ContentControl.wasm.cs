﻿using Uno.Extensions;
using Uno.Logging;
using Uno.UI.DataBinding;
using Uno.UI.Controls;
using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using Uno.Disposables;
using System.Runtime.CompilerServices;
using System.Text;
using Uno.UI;

namespace Microsoft.UI.Xaml.Controls
{
	// Android partial
    public partial class ContentControl
    {
		public ContentControl()
		{
			IFrameworkElementHelper.Initialize(this);
		}

		partial void RegisterContentTemplateRoot()
		{
			AddChild(ContentTemplateRoot);
		}

		partial void UnregisterContentTemplateRoot()
		{
			RemoveChild(ContentTemplateRoot);
		}
	}
}
