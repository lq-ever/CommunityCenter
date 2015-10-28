using System;
using Android.Widget;

using Android.App;
using Android.Views;
using CommunityCenter.Model.ServerType.Admin;


namespace CommunityCenter.Adapter
{
	public class HealthInfoListAdapter:ArrayAdapter<HealthInfoItem>
	{
		private Activity activity;
		public HealthInfoListAdapter (Activity _activity):base(_activity,0)
		{
			activity = _activity;
		}

		public override Android.Views.View GetView ( int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			HealthItemView _healthItemView = null;
			var item = GetItem (position);
			if (convertView == null) {
				
				convertView = LayoutInflater.From (Context).Inflate (Resource.Layout.healthListItemView, null);
				_healthItemView = new HealthItemView ();
				_healthItemView.tv_TestTime = convertView.FindViewById<TextView> (Resource.Id.tv_TestTime);
				_healthItemView.tv_Weight = convertView.FindViewById<TextView> (Resource.Id.tv_Weight);
				_healthItemView.tv_BloodGlucose = convertView.FindViewById<TextView> (Resource.Id.tv_BloodGlucose);


				convertView.SetTag (Resource.Id.healthitemview, (Java.Lang.Object)_healthItemView);

			} else
				_healthItemView = (HealthItemView)convertView.GetTag (Resource.Id.healthitemview);

			_healthItemView.tv_TestTime.Text = Convert.ToDateTime(item.TestTime).ToString("yyyy-MM-dd HH:mm:ss");
			_healthItemView.tv_Weight.Text = item.Weight;
			_healthItemView.tv_BloodGlucose.Text = item.BloodGlucose;

			return convertView;
		}
	}

	/// <summary>
	/// alarm item view.组件
	/// </summary>
	public class HealthItemView:Java.Lang.Object
	{
		public TextView tv_TestTime;
		public TextView tv_Weight;
		public TextView tv_BloodGlucose;	


	}
}

