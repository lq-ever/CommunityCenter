using System;
using Android.Widget;
using Android.App;
using Android.Views;

namespace CommunityCenter.Adapter
{
	public class DealRecordListAdapter:ArrayAdapter<DealRecordItem>
	{
		private Activity activity;
		public DealRecordListAdapter (Activity _activity):base(_activity,0)
		{
			activity = _activity;
		}
		public override Android.Views.View GetView ( int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			DealRecordItemView _dealRecordItemView = null;
			var item = GetItem (position);
			if (convertView == null) {
				convertView = LayoutInflater.From (Context).Inflate (Resource.Layout.DealRecordListitemView, null);
				_dealRecordItemView = new DealRecordItemView ();
				_dealRecordItemView.tv_dealTime = convertView.FindViewById<TextView> (Resource.Id.tv_dealTime);
				_dealRecordItemView.tv_dealTypeDesc = convertView.FindViewById<TextView> (Resource.Id.tv_dealTypeDesc);
				_dealRecordItemView.tv_dealAmmount = convertView.FindViewById<TextView> (Resource.Id.tv_dealAmmount);
				_dealRecordItemView.tv_dealAccountName = convertView.FindViewById<TextView> (Resource.Id.tv_dealAccountName);
				_dealRecordItemView.tv_dealStatusDesc = convertView.FindViewById<TextView> (Resource.Id.tv_dealStatusDesc);
				convertView.SetTag (Resource.Id.dealRecordlistitemview, (Java.Lang.Object)_dealRecordItemView);

			} else
				_dealRecordItemView = (DealRecordItemView)convertView.GetTag (Resource.Id.dealRecordlistitemview);
			//赋值
			_dealRecordItemView.tv_dealTime.Text = !string.IsNullOrEmpty(item.DealTime)?Convert.ToDateTime(item.DealTime).ToString("yyyy-MM-dd HH:mm:ss"):string.Empty;
			_dealRecordItemView.tv_dealTypeDesc.Text = !string.IsNullOrEmpty(item.DealTypeDesc)?item.DealTypeDesc:string.Empty;
			_dealRecordItemView.tv_dealAmmount.Text = !string.IsNullOrEmpty(item.DealAmount)?item.DealAmount:string.Empty;
			_dealRecordItemView.tv_dealAccountName.Text = !string.IsNullOrEmpty(item.AccountName)?item.AccountName:string.Empty;
			_dealRecordItemView.tv_dealStatusDesc.Text = !string.IsNullOrEmpty(item.DealStatusDesc)?item.DealStatusDesc:string.Empty;
			return convertView;
		}
	}

	/// <summary>
	/// alarm item view.组件
	/// </summary>
	public class DealRecordItemView:Java.Lang.Object
	{
		public TextView tv_dealTime;
		public TextView tv_dealTypeDesc;
		public TextView tv_dealAmmount;
		public TextView tv_dealAccountName;
		public TextView tv_dealStatusDesc;
	}



}

