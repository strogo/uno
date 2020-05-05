using System;
using System.Collections.Generic;
using Android.Views;

namespace Microsoft.UI.Xaml.Media
{
	public  partial class CompositionTarget 
	{
		private static List<EventHandler<object>> _handlers = new List<EventHandler<object>>();
		private static FrameCallback _callback;

		public static event EventHandler<object> Rendering
		{
			add
			{
				_handlers.Add(value);
				
				if(_callback == null)
				{
					_callback = new FrameCallback();
					Choreographer.Instance.PostFrameCallback(_callback);
				}
			}
			remove
			{
				_handlers.Remove(value);

				if(_handlers.Count == 0)
				{
					Choreographer.Instance.RemoveFrameCallback(_callback);
					_callback = null;
				}
			}
		}

		internal class FrameCallback : Java.Lang.Object, Choreographer.IFrameCallback
		{
			public void DoFrame(long frameTimeNanos) => OnFrame();
		}

		private static void OnFrame()
		{
			_handlers.ForEach(h => h(null, null));
		}
	}
}
