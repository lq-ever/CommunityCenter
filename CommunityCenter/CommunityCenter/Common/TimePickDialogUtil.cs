using System;
using Android.Widget;
using Android.App;
using Java.Util;
using Java.Lang;
using Java.Text;



namespace CommunityCenter.Common
{
	public class TimePickDialogUtil:Java.Lang.Object,TimePicker.IOnTimeChangedListener
	{
		private TimePicker timePicker;
		private AlertDialog dialog; 
		private string dateTime;  
		private string initTime;
		private Activity activity;
	

		public TimePickDialogUtil (Activity _activity,string _initTime)
		{
			activity = _activity;
			initTime = _initTime;
		}

		public void TimePickDialogShow(EditText edit_inputTime)
		{
			var timepickerlayout = (LinearLayout) activity.LayoutInflater.Inflate (Resource.Layout.commontimepickerlayout, null);
			timePicker = (TimePicker) timepickerlayout.FindViewById<TimePicker>(Resource.Id.timepicker); 
			InitTimePicker (timePicker);
			timePicker.SetIs24HourView(Java.Lang.Boolean.ValueOf(true)); 
			timePicker.SetOnTimeChangedListener(this);  
			var builder = new AlertDialog.Builder (activity).SetView(timepickerlayout);
			builder.SetPositiveButton ("设置", (sender, e) => {
				dialog.Dismiss();	
				edit_inputTime.Text = dateTime;

			});
			builder.SetNegativeButton ("取消", (sender, e) => {
				dialog.Dismiss();	

			});
			dialog= builder.Create ();

			dialog.Show();
			OnTimeChanged (null,0,0);
		}

		private void InitTimePicker(TimePicker _timePicker)
		{
			Calendar calendar = Calendar.Instance;
			if (!string.IsNullOrEmpty (initTime)) {
				var time = initTime.Split (new string[]{ ":" },StringSplitOptions.RemoveEmptyEntries);
				var hour =Integer.ValueOf(time[0]);
				var minute = Integer.ValueOf (time [1]);
				_timePicker.CurrentHour = hour;
				_timePicker.CurrentMinute = minute;
				
			} else {
				_timePicker.CurrentHour = Integer.ValueOf(calendar.Get (CalendarField.HourOfDay));
				_timePicker.CurrentMinute = Integer.ValueOf(calendar.Get (CalendarField.Minute));
			}
		}

		public void OnTimeChanged (TimePicker view, int hourOfDay, int minute)
		{
			var calendar = Calendar.Instance;
			calendar.Set(CalendarField.HourOfDay,timePicker.CurrentHour.IntValue());
			calendar.Set (CalendarField.Minute, timePicker.CurrentMinute.IntValue());
			SimpleDateFormat sdf = new SimpleDateFormat("HH:mm");
			dateTime = sdf.Format (calendar.Time);
		}
	}
}

