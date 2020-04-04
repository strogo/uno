﻿using System;
using Uno;
using Uno.Diagnostics.Eventing;
using Uno.UI;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

#if XAMARIN_ANDROID
using View = Android.Views.View;
using ViewGroup = Android.Views.ViewGroup;
using Font = Android.Graphics.Typeface;
using Android.Graphics;
using DependencyObject = System.Object;
#elif XAMARIN_IOS
using View = UIKit.UIView;
using ViewGroup = UIKit.UIView;
using UIKit;
#elif __MACOS__
using View = AppKit.NSView;
using ViewGroup = AppKit.NSView;
using AppKit;
#else
using View = Windows.UI.Xaml.UIElement;
using ViewGroup = Windows.UI.Xaml.UIElement;
#endif

namespace Windows.UI.Xaml
{
	public partial class Application
	{
		private bool _initializationComplete = false;
		private readonly static IEventProvider _trace = Tracing.Get(TraceProvider.Id);
		private ApplicationTheme? _requestedTheme;
		private bool _themeSetExplicitly = false;

		[Preserve]
		public static class TraceProvider
		{
			public readonly static Guid Id = new Guid(
				// {DEE07725-1CBF-4BF6-AC8A-960360CB3512}
				unchecked((int)0xdee07725), 0x1cbf, 0x4bf6, new byte[] { 0xac, 0x8a, 0x96, 0x3, 0x60, 0xcb, 0x35, 0x12 }
			);

			public const int LauchedStart = 1;
			public const int LauchedStop = 2;
		}

		public static Application Current { get; private set; }

		public DebugSettings DebugSettings { get; } = new DebugSettings();

		public ApplicationTheme RequestedTheme
		{
			get
			{
				if (_requestedTheme == null)
				{
					// just cache the theme, but do not notify about a change unnecessarily
					_requestedTheme = GetDefaultSystemTheme();
					ObserveSystemThemeChanges();
				}
				return _requestedTheme.Value;
			}
			set
			{
				if (_initializationComplete)
				{
					throw new NotSupportedException("Operation not supported");
				}
				// this flag makes sure the app will not respond to OS events
				_themeSetExplicitly = true;
				SetRequestedTheme(value);
			}
		}

		public ResourceDictionary Resources { get; } = new ResourceDictionary();

#pragma warning disable CS0067 // The event is never used
		public event EventHandler<object> Resuming;
#pragma warning restore CS0067 // The event is never used

#pragma warning disable CS0067 // The event is never used
		public event SuspendingEventHandler Suspending;
#pragma warning restore CS0067 // The event is never used

		public event UnhandledExceptionEventHandler UnhandledException;

		public void OnSystemThemeChanged()
		{
			// if user overrides theme, don't apply system theme
			if (!_themeSetExplicitly)
			{
				var theme = GetDefaultSystemTheme();
				SetRequestedTheme(theme);
			}
		}

#if !__ANDROID__
		[NotImplemented]
		public void Exit()
		{

		}
#endif

		public static void Start(global::Windows.UI.Xaml.ApplicationInitializationCallback callback)
		{
			StartPartial(callback);
		}

		partial void ObserveSystemThemeChanges();

		static partial void StartPartial(ApplicationInitializationCallback callback);

		protected internal virtual void OnActivated(IActivatedEventArgs args) { }

		protected internal virtual void OnLaunched(LaunchActivatedEventArgs args) { }

		internal void InitializationCompleted() => _initializationComplete = true;

		internal void RaiseRecoverableUnhandledException(Exception e) => UnhandledException?.Invoke(this, new UnhandledExceptionEventArgs(e, false));

		private IDisposable WritePhaseEventTrace(int startEventId, int stopEventId)
		{
			if (_trace.IsEnabled)
			{
				return _trace.WriteEventActivity(
					startEventId,
					stopEventId,
					new object[] { }
				);
			}
			else
			{
				return null;
			}
		}

		internal void OnResuming()
		{
			ApplicationModel.Core.CoreApplication.RaiseResuming();

			OnResumingPartial();
		}

		partial void OnResumingPartial();

		internal void OnSuspending()
		{
			ApplicationModel.Core.CoreApplication.RaiseSuspending(new ApplicationModel.SuspendingEventArgs(new ApplicationModel.SuspendingOperation(DateTime.Now.AddSeconds(30))));

			OnSuspendingPartial();
		}

		partial void OnSuspendingPartial();

		protected virtual void OnWindowCreated(global::Windows.UI.Xaml.WindowCreatedEventArgs args)
		{
		}

		internal void RaiseWindowCreated(Window window)
		{
			OnWindowCreated(new WindowCreatedEventArgs(window));
		}

		internal void SetRequestedTheme(ApplicationTheme requestedTheme)
		{
			if (requestedTheme != RequestedTheme)
			{
				_requestedTheme = requestedTheme;

				OnRequestedThemeChanged();
			}
		}

		private void OnRequestedThemeChanged()
		{
			if (Windows.UI.Xaml.Window.Current.Content is FrameworkElement root)
			{
				PropagateThemeChanged(root);
			}

			void PropagateThemeChanged(object instance)
			{
				// Update ThemeResource references that have changed
				if (instance is FrameworkElement fe)
				{
					fe.UpdateThemeBindings();
				}

				//Try Panel.Children before ViewGroup.GetChildren - this results in fewer allocations
				if (instance is Controls.Panel p)
				{
					foreach (object o in p.Children)
					{
						PropagateThemeChanged(o);
					}
				}
				else if (instance is ViewGroup g)
				{
					foreach (object o in g.GetChildren())
					{
						PropagateThemeChanged(o);
					}
				}
			}
		}
	}
}
