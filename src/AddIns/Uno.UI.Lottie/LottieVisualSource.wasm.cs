﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Uno.Foundation;
using Windows.Foundation;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Uno.Extensions;

namespace Microsoft.Toolkit.Uwp.UI.Lottie
{
	public partial class LottieVisualSource
	{
		private AnimatedVisualPlayer _initializedPlayer;
		private bool _isPlaying;
		private Size _compositionSize = new Size(0, 0);

		partial void InnerUpdate()
		{
			var player = _player;
			if(_initializedPlayer != player)
			{
				player.RegisterHtmlCustomEventHandler("lottie_state", OnStateChanged, isDetailJson: false);
				_initializedPlayer = player;
			}

			var js = new[]
			{
				"Uno.UI.Lottie.setAnimationProperties({",
				"elementId:",
				player.HtmlId.ToString(),
				",jsonPath:\"",
				UriSource?.PathAndQuery ?? "",
				"\",autoplay:",
				player.AutoPlay ? "true" : "false",
				",stretch:\"",
				player.Stretch.ToString(),
				"\",rate:",
				player.PlaybackRate.ToString(),
				"});"
			};
			WebAssemblyRuntime.InvokeJS(string.Concat(js));
			_isPlaying = player.AutoPlay;
		}

		private void OnStateChanged(object sender, HtmlCustomEventArgs e)
		{
			ParseStateString(e.Detail);
		}

		private void ParseStateString(string stateString)
		{
			var parts = stateString.Split('|');
			double.TryParse(parts[0], NumberStyles.Float, CultureInfo.InvariantCulture, out var w);
			double.TryParse(parts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out var h);
			var loaded = parts[2].Equals("true", StringComparison.Ordinal);
			var paused = parts[3].Equals("true", StringComparison.Ordinal);

			_player.SetValue(AnimatedVisualPlayer.IsAnimatedVisualLoadedProperty, loaded);
			_player.SetValue(AnimatedVisualPlayer.IsPlayingProperty, !paused);
			if (double.TryParse(parts[4], NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var duration))
			{
				if (double.IsNaN(duration))
				{
					duration = 0d;
				}
				_player.SetValue(AnimatedVisualPlayer.DurationProperty, TimeSpan.FromSeconds(duration));
			}

			_compositionSize = new Size(w, h);
		}

		void IAnimatedVisualSource.Play(double fromProgress, double toProgress, bool looped)
		{
			var js = new[]
			{
				"Uno.UI.Lottie.play(",
				_player.HtmlId.ToString(),
				",",
				fromProgress.ToStringInvariant(),
				",",
				toProgress.ToStringInvariant(),
				",",
				looped ? "true" : "false",
				");"
			};
			WebAssemblyRuntime.InvokeJS(string.Concat(js));
			_isPlaying = true;
		}

		void IAnimatedVisualSource.Stop()
		{
			var js = new[]
			{
				"Uno.UI.Lottie.stop(",
				_player.HtmlId.ToString(),
				");"
			};
			WebAssemblyRuntime.InvokeJS(string.Concat(js));
			_isPlaying = false;
		}

		void IAnimatedVisualSource.Pause()
		{
			var js = new[]
			{
				"Uno.UI.Lottie.pause(",
				_player.HtmlId.ToString(),
				");"
			};
			WebAssemblyRuntime.InvokeJS(string.Concat(js));
			_isPlaying = false;
		}

		void IAnimatedVisualSource.Resume()
		{
			var js = new[]
			{
				"Uno.UI.Lottie.resume(",
				_player.HtmlId.ToString(),
				");"
			};
			WebAssemblyRuntime.InvokeJS(string.Concat(js));
			_isPlaying = true;
		}

		public void SetProgress(double progress)
		{
			var js = new[]
			{
				"Uno.UI.Lottie.setProgress(",
				_player.HtmlId.ToString(),
				",",
				progress.ToString(CultureInfo.InvariantCulture),
				");"
			};
			WebAssemblyRuntime.InvokeJS(string.Concat(js));
			_isPlaying = true;
		}

		void IAnimatedVisualSource.Load()
		{
			if (!_isPlaying)
			{
				return;
			}

			var js = new[]
			{
					"Uno.UI.Lottie.resume(",
					_player.HtmlId.ToString(),
					");"
				};
			WebAssemblyRuntime.InvokeJS(string.Concat(js));
		}

		void IAnimatedVisualSource.Unload()
		{
			if (!_isPlaying)
			{
				return;
			}

			var js = new[]
			{
					"Uno.UI.Lottie.pause(",
					_player.HtmlId.ToString(),
					");"
				};
			WebAssemblyRuntime.InvokeJS(string.Concat(js));
		}

		private Size CompositionSize => _compositionSize;
	}
}
