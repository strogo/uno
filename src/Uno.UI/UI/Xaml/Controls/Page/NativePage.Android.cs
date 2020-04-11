﻿using System;
using System.Collections.Generic;
using System.Text;
using Android.OS;
using Android.Views;
using Uno.UI;

namespace Microsoft.UI.Xaml.Controls
{
	public abstract class NativePage : BaseActivity
    {
		private Style _style;

		public NativePage(IntPtr ptr, Android.Runtime.JniHandleOwnership owner) : base(ptr, owner)
		{
		}

		public NativePage()
		{
		}

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			Style = null;
			
			InitializeComponent();

			var decorView = (ContextHelper.Current as Android.App.Activity).Window.DecorView;

			Microsoft.UI.Xaml.Window.Current.SystemUiVisibility = (int)decorView.SystemUiVisibility;
			decorView.SetOnSystemUiVisibilityChangeListener(new OnSystemUiVisibilityChangeListener());
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();

			// By detaching the ContentView after destroying the page,
			// the same ContentView can be reused by other activities.
			(ContentView?.Parent as ViewGroup)?.RemoveView(ContentView);
		}

		protected abstract void InitializeComponent();

		public View Content
		{
			get {
				return ContentView;
			}
			set
			{
				SetContentView(value, new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent));
			}
		}

		public virtual Style Style
		{
			get
			{
				return _style;
			}
			set
			{
				_style = value ?? Style.DefaultStyleForType(typeof(NativePage));
				_style.ApplyTo(this);
			}
		}
    }
}
