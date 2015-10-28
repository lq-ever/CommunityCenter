using System;
using Android.Widget;

using Android.App;
using Android.Views;
using CommunityCenter.Model.ServerType.Admin;
using CommunityCenter.Common;



namespace CommunityCenter.Adapter
{
	public class AlarmInfoListAdapter:ArrayAdapter<AlarmInfoListItem>
	{
		private Activity activity;
		public AlarmInfoListAdapter (Activity _activity):base(_activity,0)
		{
			activity = _activity;
		}

		public override Android.Views.View GetView ( int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			AlarmItemView _alarmItemView = null;
			var item = GetItem (position);
			if (convertView == null) {

				convertView = LayoutInflater.From (Context).Inflate (Resource.Layout.alarmListitemView, null);
				_alarmItemView = new AlarmItemView ();
				_alarmItemView.tv_alarmTrueName = convertView.FindViewById<TextView> (Resource.Id.tv_alarmTrueName);
				_alarmItemView.tv_alarmTime = convertView.FindViewById<TextView> (Resource.Id.tv_alarmTime);
				_alarmItemView.tv_alarmStatus = convertView.FindViewById<TextView> (Resource.Id.tv_alarmStatus);
				_alarmItemView.tv_alarmContent = convertView.FindViewById<TextView> (Resource.Id.tv_alarmContent);

				convertView.SetTag (Resource.Id.alarmlistitemview, (Java.Lang.Object)_alarmItemView);

			} else
				_alarmItemView = (AlarmItemView)convertView.GetTag (Resource.Id.alarmlistitemview);

			_alarmItemView.tv_alarmTrueName.Text = EldYoungUtil.FormatStrVaue(item.TrueName);
			_alarmItemView.tv_alarmTime.Text = string.IsNullOrEmpty(item.AlarmTime)?string.Empty: Convert.ToDateTime( item.AlarmTime).ToString("yyyy-MM-dd HH:mm:ss");
			_alarmItemView.tv_alarmStatus.Text = EldYoungUtil.FormatStrVaue(item.Status);
			_alarmItemView.tv_alarmContent.Text = EldYoungUtil.FormatStrVaue(item.AlarmContent);
			return convertView;
		}
	}

	/// <summary>
	/// alarm item view.组件
	/// </summary>
	public class AlarmItemView:Java.Lang.Object
	{
		public TextView tv_alarmTrueName;
		public TextView tv_alarmTime;
		public TextView tv_alarmStatus;	
		public TextView tv_alarmContent;

	}
}

