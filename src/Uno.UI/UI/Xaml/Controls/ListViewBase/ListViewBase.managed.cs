﻿#if __WASM__ || __MACOS__
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
using System;
using System.Collections.Generic;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;

namespace Microsoft.UI.Xaml.Controls
{
	public partial class ListViewBase
	{
		IVirtualizingPanel VirtualizingPanel => ItemsPanelRoot as IVirtualizingPanel;

		private int PageSize => throw new NotImplementedException();

		private protected override bool ShouldItemsControlManageChildren => !(ItemsPanelRoot is IVirtualizingPanel);

		private void Refresh()
		{
			if (VirtualizingPanel != null)
			{
				VirtualizingPanel.GetLayouter().Refresh();

				InvalidateMeasure();
			}
		}

		private void AddItems(int firstItem, int count, int section)
		{
			Refresh();
		}

		private void RemoveItems(int firstItem, int count, int section)
		{
			Refresh();
		}

		private void AddGroup(int groupIndexInView)
		{
			Refresh();
		}

		private void RemoveGroup(int groupIndexInView)
		{
			Refresh();
		}

		private void ReplaceGroup(int groupIndexInView)
		{
			Refresh();
		}

		private ContentControl ContainerFromGroupIndex(int groupIndex) => throw new NotImplementedException();

		private void TryLoadMoreItems()
		{
			//TODO: ISupportIncrementalLoading
		}
	}
}
#endif
