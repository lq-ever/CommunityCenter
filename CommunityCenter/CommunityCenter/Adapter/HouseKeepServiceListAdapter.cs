using System;
using Android.Widget;
using Android.App;
using Android.Views;

namespace CommunityCenter
{
	public class HouseKeepServiceListAdapter:ArrayAdapter<HouserKeepServiceItem>
	{
		private Activity activity;
		public HouseKeepServiceListAdapter (Activity _activity):base(_activity,0)
		{
			activity = _activity;
		}
		public override Android.Views.View GetView ( int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			HouseKeepServiceItemView _houseKeepServiceItemView = null;
			var item = GetItem (position);
			if (convertView == null) {

				convertView = LayoutInflater.From (Context).Inflate (Resource.Layout.housekeepServiceListItemView, null);
				_houseKeepServiceItemView = new HouseKeepServiceItemView ();
				_houseKeepServiceItemView.img_service = convertView.FindViewById<ImageView> (Resource.Id.img_service);
				_houseKeepServiceItemView.tv_serviceName = convertView.FindViewById<TextView> (Resource.Id.tv_serviceName);
				_houseKeepServiceItemView.tv_serviceDesc = convertView.FindViewById<TextView> (Resource.Id.tv_serviceDesc);
				_houseKeepServiceItemView.tv_YHour = convertView.FindViewById<TextView> (Resource.Id.tv_YHour);
				_houseKeepServiceItemView.tv_YDay = convertView.FindViewById<TextView> (Resource.Id.tv_YDay);
				_houseKeepServiceItemView.btn_edit = convertView.FindViewById<Button> (Resource.Id.btn_edit);

				convertView.SetTag (Resource.Id.housekeepservicelistitemView, (Java.Lang.Object)_houseKeepServiceItemView);

			} else
				_houseKeepServiceItemView = (HouseKeepServiceItemView)convertView.GetTag (Resource.Id.housekeepservicelistitemView);
			//赋值
			_houseKeepServiceItemView.img_service.SetImageResource(item.ImageId);
			_houseKeepServiceItemView.tv_serviceName.Text = item.ServiceName;
			_houseKeepServiceItemView.tv_serviceDesc.Text = item.ServiceDesc;
			_houseKeepServiceItemView.tv_YDay.Text = item.YDay;
			_houseKeepServiceItemView.tv_YHour.Text = item.YHour;
			//编辑绑定事件
			_houseKeepServiceItemView.btn_edit.Tag = item;
			_houseKeepServiceItemView.btn_edit.Click -= ActionHandler;
			_houseKeepServiceItemView.btn_edit.Click += ActionHandler;

			return convertView;
		}

		/// <summary>
		/// 动作按钮事件方法
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		private void ActionHandler(object sender, EventArgs e)
		{
			var item = (HouserKeepServiceItem)(sender as Button).Tag;

			//弹出设置价格popup窗口
//			var unbindPopWindow = new UnbindPopWindow (activity, item){UnBindEventHandler = UnBindGuardian};
//			unbindPopWindow.ShowPopWindow (activity.FindViewById<LinearLayout> (Resource.Id.ll_BindGuardian));
		}
	}

	/// <summary>
	/// alarm item view.组件
	/// </summary>
	public class HouseKeepServiceItemView:Java.Lang.Object
	{
		public ImageView img_service;
		public TextView tv_serviceName;
		public TextView tv_serviceDesc;
		public TextView tv_YHour;
		public TextView tv_YDay;
		public Button btn_edit;
	}
}

