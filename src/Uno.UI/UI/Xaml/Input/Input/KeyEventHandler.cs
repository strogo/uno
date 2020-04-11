#if !NET461
using Microsoft.UI.Xaml.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.UI.Xaml.Input
{
    public delegate void KeyEventHandler(object sender, KeyRoutedEventArgs e);
}
#endif