﻿using System.Collections.Generic;
using Uno.UI.Samples.Controls;
using Windows.Devices.Geolocation;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Maps;


// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Uno.UI.Samples.Content.UITests.MapControl
{
	[SampleControlInfo("Map", "MapControl")]
	public sealed partial class MapControl : UserControl
    {
		public Geopoint PinPoint { get; set; }

		public MapControl()
        {
            this.InitializeComponent();
			AddMapIcon();
		}

		private void AddMapIcon()
		{
			var myLandmarks = new List<MapElement>();
			BasicGeoposition snPosition = new BasicGeoposition { Latitude = 47.620, Longitude = -122.349 };
			PinPoint = new Geopoint(snPosition);
			var spaceNeedleIcon = new MapIcon
			{
				Location = PinPoint,
				ZIndex = 0,
				Title = "Pin"
			};
			myLandmarks.Add(spaceNeedleIcon);
			var landmarksLayer = new MapElementsLayer
			{
				ZIndex = 1,
				MapElements = myLandmarks
			};
			MyMapControl.Layers.Add(landmarksLayer);
			MyMapControl.Center = PinPoint;
			MyMapControl.ZoomLevel = 14;
		}
	}
}
