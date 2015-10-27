using System;
using Android.Widget;
using Android.App;
using Java.Util;
using Java.Text;
using Android.Views;
using Java.Lang;

namespace CommunityCenter.Common
{
	public class DatePickDialogUtil:Java.Lang.Object,DatePicker.IOnDateChangedListener
	{
		private DatePicker datePicker;
		private AlertDialog dialog; 
		private string dateTime;  
		private string initDate;
		private Activity activity;

		public DatePickDialogUtil (Activity _activity,string _initDate)
		{
			activity = _activity;
			initDate = _initDate;

		}

		public void DatePickDialogShow(EditText edit_birth)
		{
			var datepickerlayout = (LinearLayout) activity.LayoutInflater.Inflate (Resource.Layout.commondatepickerlayout, null);
			datePicker = datepickerlayout.FindViewById<DatePicker> (Resource.Id.datepicker);
			InitDatePicker (datePicker);
		
			var builder = new AlertDialog.Builder (activity).SetView(datepickerlayout);
			builder.SetPositiveButton ("设置", (sender, e) => {
				dialog.Dismiss();	
				edit_birth.Text = dateTime;

			});
			builder.SetNegativeButton ("取消", (sender, e) => {
				dialog.Dismiss();	

			});
			dialog= builder.Create ();

			dialog.Show();
			OnDateChanged (null, 0, 0, 0);
		}

		private void InitDatePicker(DatePicker _datepicker)
		{
			Calendar calendar = Calendar.Instance;
			if (!string.IsNullOrEmpty (initDate)) {
				var date = initDate.Split (new char[]{'-'}, StringSplitOptions.RemoveEmptyEntries);
				var year = Integer.ValueOf(date [0]).IntValue();
				var month = Integer.ValueOf (date [1]).IntValue ()-1;
				var day = Integer.ValueOf (date [2]).IntValue ();
				_datepicker.Init (year, month, day, this);

			}
			else
			  _datepicker.Init (calendar.Get (CalendarField.Year), calendar.Get (CalendarField.Month), calendar.Get (CalendarField.DayOfMonth), this);
			
	
			  
		}


		public void  OnDateChanged (DatePicker view, int year, int monthOfYear, int dayOfMonth)
		{
			var calendar = Calendar.Instance;
			calendar.Set (datePicker.Year, datePicker.Month, datePicker.DayOfMonth);
			SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
			dateTime = sdf.Format (calendar.Time);

		}
	}
}

