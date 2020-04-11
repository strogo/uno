﻿using System;
using System.Windows.Input;
using Uno.UI.Samples.UITests.Helpers;
using Windows.UI.Core;
using Microsoft.UI.Xaml.Data;

namespace UITests.Shared.Windows_UI_Xaml_Controls.TimePicker.Model
{
	[Bindable]
	public class TimePickerViewModel : ViewModelBase
	{
		private TimeSpan _time = new TimeSpan(12,0,0);

		public TimePickerViewModel(CoreDispatcher dispatcher) : base(dispatcher)
		{
		}

		public TimeSpan Time
		{
			get => _time;
			set
			{
				_time = value;
				RaisePropertyChanged("Time");
			}
		}

		public ICommand SetToCurrentTime => GetOrCreateCommand(() => Time = DateTime.Now.TimeOfDay);
	}
}
