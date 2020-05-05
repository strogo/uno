﻿using Uno.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uno.Extensions;
using Uno.UI.DataBinding;
using System.Runtime.CompilerServices;
using System.Drawing;
using Uno.Disposables;
using Microsoft.UI.Xaml;
using System.ComponentModel;
using Microsoft.UI.Xaml.Media;
using AppKit;
using System.Collections;

namespace Uno.UI.Controls
{
	public partial class BindableNSView : NSView, INotifyPropertyChanged, DependencyObject, IShadowChildrenProvider, IEnumerable
	{
		private MaterializableList<NSView> _shadowChildren = new MaterializableList<NSView>(0);

		List<NSView> IShadowChildrenProvider.ChildrenShadow => _shadowChildren.Materialized;

		internal IReadOnlyList<NSView> ChildrenShadow => _shadowChildren;

		public override void DidAddSubview(NSView NSView)
		{
			base.DidAddSubview(NSView);

			// Reference the list as we don't know where
			// the items has been added other than by getting the complete list.
			// Subviews materializes a new array at every call, which makes it safe to
			// reference.
			_shadowChildren = new MaterializableList<NSView>(Subviews);
		}

		internal List<NSView>.Enumerator GetChildrenEnumerator() => _shadowChildren.Materialized.GetEnumerator();

		public override void WillRemoveSubview(NSView NSView)
		{
			base.WillRemoveSubview(NSView);

			var position = _shadowChildren.IndexOf(NSView, ReferenceEqualityComparer<NSView>.Default);

			if(position != -1)
			{
				_shadowChildren.RemoveAt(position);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public BindableNSView()
		{
			Initialize();
		}

		public BindableNSView(IntPtr handle)
			: base(handle)
		{
			Initialize();
		}

		public BindableNSView(RectangleF frame)
			: base(frame)
		{
			Initialize();
		}

		/// <remarks>
		/// This is required to ensure that the coordinate system matches UWP, where the origin is at the top left.
		/// See https://developer.apple.com/documentation/appkit/nsview/1483532-isflipped for more details.
		/// </remarks>
		public override bool IsFlipped => true;

		private void Initialize()
		{
			InitializeBinder();
		}

		/// <summary>
		/// Moves a view from one position to another position, without unloading it.
		/// </summary>
		/// <param name="oldIndex">The old index of the item</param>
		/// <param name="newIndex">The new index of the item</param>
		/// <remarks>
		/// TBD
		/// </remarks>
		internal void MoveViewTo(int oldIndex, int newIndex)
		{
			var view = _shadowChildren[oldIndex];

			_shadowChildren.RemoveAt(oldIndex);
			_shadowChildren.Insert(newIndex, view);

			var reorderIndex = Math.Min(oldIndex, newIndex);

			for (int i = reorderIndex; i < _shadowChildren.Count; i++)
			{
				// TODO: Use AddSubview with foremost
				// BringSubviewToFront(newShadow[i]);
			}
		}

		protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public IEnumerator GetEnumerator() => Subviews.GetEnumerator();
	}
}
