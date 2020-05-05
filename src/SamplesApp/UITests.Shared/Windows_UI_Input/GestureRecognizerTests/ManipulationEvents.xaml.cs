﻿using System;
using System.Linq;
using Windows.UI;
using Windows.UI.Input;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Uno.UI.Samples.Controls;

namespace UITests.Shared.Windows_UI_Input.GestureRecognizerTests
{
	[SampleControlInfo("Gesture recognizer", "Manipulation Events")]
	public sealed partial class ManipulationEvents : Page
	{
		public ManipulationEvents()
		{
			this.InitializeComponent();

			SizeChanged += (snd, e) => System.Diagnostics.Debug.WriteLine($"Size: {e.NewSize}");
			PointerMoved += (snd, e) => System.Diagnostics.Debug.WriteLine($"Pointer: {e.GetCurrentPoint(this).Position}");

			_thumb.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;
			_thumb.ManipulationStarted += (snd, e) =>
			{
				_thumb.Background = new SolidColorBrush(Colors.Blue);
				Move(e.Cumulative, e.Cumulative);
			};
			_thumb.ManipulationDelta += (snd, e) =>
			{
				Move(e.Delta, e.Cumulative);
			};
			_thumb.ManipulationCompleted += (snd, e) =>
			{
				Move(new ManipulationDelta { Scale = 1 }, e.Cumulative);
				_thumb.Background = new SolidColorBrush(Colors.Red);
			};
		}

		private void Move(ManipulationDelta delta, ManipulationDelta cumulative)
		{
			var deltaTransform = GetOrCreateTransform(_thumb);
			deltaTransform.X -= delta.Translation.X;
			deltaTransform.Y -= delta.Translation.Y;

			var cumulativeTransform = GetOrCreateTransform(_thumbShadow);
			cumulativeTransform.X = -cumulative.Translation.X;
			cumulativeTransform.Y = -cumulative.Translation.Y;

			System.Diagnostics.Debug.WriteLine(
				$"X: {cumulative.Translation.X:' '000.00;'-'000.00} (Δ: {delta.Translation.X:' '00.00;'-'00.00} Σ: {deltaTransform.X:' '000.00;'-'000.00}) " +
				$"Y: {cumulative.Translation.Y:' '000.00;'-'000.00} (Δ: {delta.Translation.Y:' '00.00;'-'00.00} Σ: {deltaTransform.Y:' '000.00;'-'000.00}) ");
		}

		private static TranslateTransform GetOrCreateTransform(Border target)
		{
			var transform = target.RenderTransform as TranslateTransform;
			if (transform == null)
			{
				target.RenderTransform = transform = new TranslateTransform();
			}

			return transform;
		}
	}
}
