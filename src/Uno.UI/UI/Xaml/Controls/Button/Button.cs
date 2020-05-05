﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uno.Extensions;
using Microsoft.UI.Xaml.Automation.Peers;
using Microsoft.UI.Xaml.Controls.Primitives;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class Button : ButtonBase
	{
		static Button()
		{
			StaticInitializeVisualStates();

			HorizontalContentAlignmentProperty.OverrideMetadata(
				typeof(Button),
				new FrameworkPropertyMetadata(HorizontalAlignment.Center)
			);

			VerticalContentAlignmentProperty.OverrideMetadata(
				typeof(Button),
				new FrameworkPropertyMetadata(VerticalAlignment.Center)
			);
		}

		public Button()
		{
			InitializeVisualStates();

			Click += (s, e) => { Flyout?.ShowAt(this); };
		}

		#region Flyout Dependency Property
		public FlyoutBase Flyout
		{
			get { return (FlyoutBase)this.GetValue(FlyoutProperty); }
			set { this.SetValue(FlyoutProperty, value); }
		}

		public static readonly DependencyProperty FlyoutProperty =
			DependencyProperty.Register(
				"Flyout",
				typeof(FlyoutBase),
				typeof(Button),
				new FrameworkPropertyMetadata(
					defaultValue: null,
					options: FrameworkPropertyMetadataOptions.LogicalChild
				)
			);
		#endregion

		protected override void OnUnloaded()
		{
			base.OnUnloaded();

			Flyout?.Close();
		}

		protected override AutomationPeer OnCreateAutomationPeer()
			=> new ButtonAutomationPeer(this);
	}
}
