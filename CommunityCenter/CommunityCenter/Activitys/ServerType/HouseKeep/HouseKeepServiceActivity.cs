
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CommunityCenter
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class HouseKeepServiceActivity : Activity
	{
		private ListView lv_housekeepservice;

		private HouseKeepServiceListAdapter houseKeepServiceListAdapter ;
		private List<HouserKeepServiceItem> houseKeepServiceLists = new List<HouserKeepServiceItem>();
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Create your application here
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.HouseKeepServiceLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			// Create your application here
			InitView();
		}
		private void InitView()
		{
			//设置标题栏
			var img_header_back = FindViewById<ImageView> (Resource.Id.img_header_back);
			img_header_back.Click += (sender, e) => 
			{
				this.Finish();
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

			var tv_back = FindViewById<TextView> (Resource.Id.tv_back);
			tv_back.Text = "返回";
			var tv_desc = FindViewById<TextView> (Resource.Id.tv_desc);
			tv_desc.Text = "家政服务类型";

			var tv_action = FindViewById<TextView> (Resource.Id.tv_action);
			tv_action.Text = "编辑类型";
			tv_action.Click += (sender, e) => 
			{
				//todo:跳转到编辑服务类型界面
			};
			//获取listview
			lv_housekeepservice = FindViewById<ListView> (Resource.Id.lv_housekeepservice);
			houseKeepServiceListAdapter = new HouseKeepServiceListAdapter (this);
			lv_housekeepservice.Adapter = houseKeepServiceListAdapter;
			LoadHouseKeepAllServiceList ();
		}

		/// <summary>
		/// 获取所有家政服务类型列表
		/// </summary>
		private void LoadHouseKeepAllServiceList()
		{
			//todo:调用webservice获取数据
			houseKeepServiceLists.Clear();
			houseKeepServiceListAdapter.Clear();
			houseKeepServiceLists.Add (new HouserKeepServiceItem (){ ImageId = Resource.Drawable.icon_housekeep_clean,ServiceName="保洁",ServiceDesc="清理房间卫生等",ServiceChoosed=true,ServiceType=ServiceType.HouseKeep_Clean,YDay="50",YHour="15"});
			houseKeepServiceLists.Add (new HouserKeepServiceItem (){ ImageId = Resource.Drawable.icon_housekeep_cook,ServiceName="做饭",ServiceDesc="负责做饭",ServiceChoosed=true,ServiceType=ServiceType.HouseKeep_Cook,YDay="50",YHour="15"});
			houseKeepServiceLists.Add (new HouserKeepServiceItem (){ ImageId = Resource.Drawable.icon_housekeep_wash,ServiceName="洗衣",ServiceDesc="负责洗衣服",ServiceChoosed=true,ServiceType=ServiceType.HouseKeep_Wash,YDay="50",YHour="15"});
			houseKeepServiceLists.Add (new HouserKeepServiceItem (){ ImageId = Resource.Drawable.icon_housekeep_moon,ServiceName="月嫂",ServiceDesc="照理小孩子",ServiceChoosed=true,ServiceType=ServiceType.HouseKeep_Moon,YDay="50",YHour="15"});
			houseKeepServiceLists.Add (new HouserKeepServiceItem (){ ImageId = Resource.Drawable.icon_housekeep_schoolrun,ServiceName="接送小孩",ServiceDesc="接送小孩上学",ServiceChoosed=true,ServiceType=ServiceType.HouseKeep_SchoolRun,YDay="50",YHour="15"});
			houseKeepServiceLists.Add (new HouserKeepServiceItem (){ ImageId = Resource.Drawable.icon_housekeep_deal,ServiceName="买卖",ServiceDesc="购买日常生活用品",ServiceChoosed=true,ServiceType=ServiceType.HouseKeep_Deal,YDay="50",YHour="15"});

			houseKeepServiceListAdapter.AddAll (houseKeepServiceLists);
			houseKeepServiceListAdapter.NotifyDataSetChanged ();
		}
	}
}

