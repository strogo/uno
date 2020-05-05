﻿using System;
using Windows.Foundation;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Airbnb.Lottie;
using Uno.UI;
#if __IOS__
using _ViewContentMode = UIKit.UIViewContentMode;
#else
using _ViewContentMode = Airbnb.Lottie.LOTViewContentMode;
#endif

namespace Microsoft.Toolkit.Uwp.UI.Lottie
{
	partial class LottieVisualSource
	{
		private LOTAnimationView _animation;

		public bool UseHardwareAcceleration { get; set; } = true;

		private string _lastPath = "";

		partial void InnerUpdate()
		{
			var player = _player;
			if (_animation == null)
			{
				_animation = new LOTAnimationView();
				SetProperties();
#if __IOS__
				player.Add(_animation);
#else
				player.AddSubview(_animation);
#endif
			}
			else
			{
				SetProperties();
			}

			void SetProperties()
			{
				var path = UriSource?.PathAndQuery ?? "";
				if (_lastPath != path)
				{
					_animation.SetAnimationNamed(path);
					_lastPath = path;

					// Force layout to recalculate
					player.InvalidateMeasure();
					player.InvalidateArrange();

					if (player.AutoPlay)
					{
						Play(0, 1, true);
					}
				}

				switch (player.Stretch)
				{
					case Microsoft.UI.Xaml.Media.Stretch.None:
						_animation.ContentMode = _ViewContentMode.Center;
						break;
					case Microsoft.UI.Xaml.Media.Stretch.Uniform:
						_animation.ContentMode = _ViewContentMode.ScaleAspectFit;
						break;
					case Microsoft.UI.Xaml.Media.Stretch.Fill:
						_animation.ContentMode = _ViewContentMode.ScaleToFill;
						break;
					case Microsoft.UI.Xaml.Media.Stretch.UniformToFill:
						_animation.ContentMode = _ViewContentMode.ScaleAspectFill;
						break;
				}

				var duration = TimeSpan.FromSeconds(_animation.AnimationDuration);
				player.SetValue(AnimatedVisualPlayer.DurationProperty, duration);

				var isLoaded = duration > TimeSpan.Zero;
				player.SetValue(AnimatedVisualPlayer.IsAnimatedVisualLoadedProperty, isLoaded);

				_animation.CompletionBlock = isCompleted =>
				{
					SetIsPlaying(_animation.IsAnimationPlaying);
				};

				_animation.AnimationSpeed = (nfloat)player.PlaybackRate;
			}
		}

		public void Play(double fromProgress, double toProgress, bool looped)
		{
			if (_animation != null)
			{
				if (_animation.IsAnimationPlaying)
				{
					_animation.Stop();
				}

				_animation.LoopAnimation = looped;

				void Start()
				{
					_animation.PlayFromProgress((nfloat)fromProgress, (nfloat)toProgress, isFinished =>
					{
						if (looped && isFinished)
						{
							Start();
						}
					});
				}

				Start();
				SetIsPlaying(true);
			}
		}

		public void Stop()
		{
			SetIsPlaying(false);
			_animation.Stop();
		}

		public void Pause()
		{
			SetIsPlaying(false);
			_animation.Pause();
		}

		public void Resume()
		{
			_animation.Play();
			SetIsPlaying(true);
		}

		public void SetProgress(double progress)
		{
			if (_animation != null)
			{
				_animation.AnimationProgress = (nfloat)progress;
			}
		}

		public void Load()
		{
			if (_player.IsPlaying)
			{
				_animation.Play();
			}
		}

		public void Unload()
		{
			if (_player.IsPlaying)
			{
				_animation.Pause();
			}
		}

		private Size CompositionSize => _animation.IntrinsicContentSize;
	}
}
