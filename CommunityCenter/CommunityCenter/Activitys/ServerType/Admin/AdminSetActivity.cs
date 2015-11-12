
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

namespace CommunityCenter.Activitys.ServerType.Admin
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class AdminSetActivity : Activity
	{
		private RelativeLayout rl_service_time, rl_service_Area, rl_service_desc, rl_service_chargingSet;
		private TextView tv_serviceTime, tv_serviceArea, tv_servicedesc, tv_ChargingSet;
		private const int ServiceTime =1;
		private const int ServiceArea = 2;
		private const int ServiceDesc = 3;
		private const int ChargingSet = 4;
		private string startWeek, endWeek,startTime,endTime;//时间相关
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.AdminSetLayout );
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
			tv_desc.Text = "管理员设置";

			rl_service_time = FindViewById<RelativeLayout> (Resource.Id.rl_service_time);
			rl_service_Area = FindViewById<RelativeLayout> (Resource.Id.rl_service_Area);
			rl_service_desc = FindViewById<RelativeLayout> (Resource.Id.rl_service_desc);
			rl_service_chargingSet = FindViewById<RelativeLayout> (Resource.Id.rl_service_chargingSet);
			tv_serviceTime = FindViewById<TextView> (Resource.Id.tv_serviceTime);
			tv_serviceArea = FindViewById<TextView> (Resource.Id.tv_serviceArea);
			tv_servicedesc = FindViewById<TextView> (Resource.Id.tv_servicedesc);
			tv_ChargingSet = FindViewById<TextView> (Resource.Id.tv_ChargingSet);
			//服务时间
			rl_service_time.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(ServiceTimeActivity));
				intent.PutExtra("serviceType",(int)ServiceType.Admin);
				StartActivityForResult(intent,ServiceTime);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//服务范围
			rl_service_Area.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(ServiceAreaActivity));
				intent.PutExtra("serviceType",(int)ServiceType.Admin);
				StartActivityForResult(intent,ServiceArea);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//服务描述
			rl_service_desc.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(ServiceDescActivity));
				intent.PutExtra("serviceType",(int)ServiceType.Admin);
				StartActivityForResult(intent,ServiceDesc);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//收费设置
			rl_service_chargingSet.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(ChargingSetActivity));
				intent.PutExtra("serviceType",(int)ServiceType.Admin);
				StartActivityForResult(intent,ChargingSet);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//todo:laoddata
			LoadData();
		}
		/// <summary>
		/// 赋值
		/// </summary>
		private void LoadData()
		{
			
		}
		protected override void OnActivityResult (int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult (requestCode, resultCode, data);
			if (resultCode == Result.Canceled)
				return;
			if (requestCode == ServiceTime) {
				if (resultCode == Result.Ok) {
					startWeek = data.GetStringExtra ("startweek");
					endWeek = data.GetStringExtra ("endweek");
					startTime = data.GetStringExtra ("starttime");
					endTime = data.GetStringExtra ("endtime");
					tv_serviceTime.Text = startWeek + "-" + endWeek + ":" + startTime + "-" + endTime;
				}

			} else if (requestCode == ServiceArea) {


				
			} else if (requestCode == ServiceDesc) {
				
				
			} else if (requestCode == ChargingSet) {


			}

		}
	}
}

