
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
using CommunityCenter.Activitys.ServerType.Admin;
using CommunityCenter.Activitys.ServerType;

namespace CommunityCenter.Activitys.HouseKeep
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class HouseKeepMainActivity : Activity
	{
		private RelativeLayout rl_housekeep_Set, rl_housekeep_servicetype, rl_housekeep_ordersearch;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Create your application here
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.HouseKeepMainLayout);
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
			tv_desc.Text = "家政服务";

			//家政服务设置
			rl_housekeep_Set = FindViewById<RelativeLayout> (Resource.Id.rl_housekeep_Set);
			rl_housekeep_Set.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(ServiceSetActivity));
				intent.PutExtra("serviceType",(int)ServiceType.HouseKeep);
				StartActivity(intent);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//服务类型
			rl_housekeep_servicetype = FindViewById<RelativeLayout>(Resource.Id.rl_housekeep_servicetype);
			rl_housekeep_servicetype.Click += (sender, e) => 
			{
				StartActivity(typeof(HouseKeepServiceActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

			//预约查询
			rl_housekeep_ordersearch = FindViewById<RelativeLayout>(Resource.Id.rl_housekeep_ordersearch);
			rl_housekeep_ordersearch.Click += (object sender, EventArgs e) => 
			{
				var intent = new Intent(this,typeof(ServiceOrderSearchActivity));
				intent.PutExtra("serviceType",(int)ServiceType.HouseKeep);
				StartActivity(intent);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};


		}
	}
}

