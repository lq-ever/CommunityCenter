using System;
using Android.Widget;
using Android.App;
using System.Collections.Generic;
using Android.Views;
using CommunityCenter.Model.Alarm;

namespace CommunityCenter.Adapter
{
	public class AlarmHandleDetailInfoAdapter:BaseAdapter<AlarmInfoHandDetailItem>
	{
		private Activity Context;
		private List<AlarmInfoHandDetailItem> HandleDetails;
		public AlarmHandleDetailInfoAdapter (Activity _context,List<AlarmInfoHandDetailItem> _handleDetails)
		{
			Context = _context;
			HandleDetails = _handleDetails;
		}
		public override int Count {
			get {
				return HandleDetails.Count;
			}
		}

		public override AlarmInfoHandDetailItem this[int index] {
			get {
				return HandleDetails [index];
			}
		}

		public override Android.Views.View GetView (int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			AlarmHandleDetailView _alarmhandleDetailItemView = null;
			var item = HandleDetails[position];
			if (convertView == null) {
				convertView = LayoutInflater.From (Context).Inflate (Resource.Layout.AlarmHandleDetailInfoListitemView, null);
				_alarmhandleDetailItemView = new AlarmHandleDetailView ();
				_alarmhandleDetailItemView.tv_handledetail_handleTime = convertView.FindViewById<TextView> (Resource.Id.tv_handledetail_handleTime);
				_alarmhandleDetailItemView.tv_handledetail_handleContent = convertView.FindViewById<TextView> (Resource.Id.tv_handledetail_handleContent);
				_alarmhandleDetailItemView.tv_handledetail_remark = convertView.FindViewById<TextView> (Resource.Id.tv_handledetail_remark);
				convertView.SetTag (Resource.Id.alarmHandleDetailInfoListitemView, _alarmhandleDetailItemView);
			} else
				_alarmhandleDetailItemView = (AlarmHandleDetailView)convertView.GetTag (Resource.Id.alarmHandleDetailInfoListitemView);
			_alarmhandleDetailItemView.tv_handledetail_handleTime.Text= string.IsNullOrEmpty(item.HandleTime)?string.Empty:Convert.ToDateTime(item.HandleTime).ToString("yyyy-MM-dd HH:mm:ss");
			_alarmhandleDetailItemView.tv_handledetail_handleContent.Text = string.IsNullOrEmpty(item.HandleContent)?string.Empty:item.HandleContent;
			_alarmhandleDetailItemView.tv_handledetail_remark.Text = string.IsNullOrEmpty(item.Remark)?string.Empty:item.Remark;

			return convertView;
		}
		public override long GetItemId (int position)
		{
			return position;
		}
	}

	/// <summary>
	/// Guardian item view.组件
	/// </summary>
	public class AlarmHandleDetailView:Java.Lang.Object
	{
		public TextView tv_handledetail_handleTime;
		public TextView tv_handledetail_handleContent;
		public TextView tv_handledetail_remark;	
	}
}

