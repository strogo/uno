
using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using Uno.Disposables;
using System.Runtime.CompilerServices;
using Uno.Extensions;
using Uno.Logging;
using Uno.UI;
using Uno.UI.DataBinding;
using Windows.Foundation;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
#if XAMARIN_IOS
using Color = UIKit.UIColor;
using View = UIKit.UIView;
#elif XAMARIN_ANDROID
using Color = Android.Resource.Color;
using View = Android.Views.View;
#elif NET461
using Color = System.Object;
using View = Microsoft.UI.Xaml.FrameworkElement;
#endif  


