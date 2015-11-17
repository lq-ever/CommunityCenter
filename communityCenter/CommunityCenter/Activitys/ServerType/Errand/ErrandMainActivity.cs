
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

namespace CommunityCenter.Activitys.ServerType.Errand
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class ErrandMainActivity : Activity
	{
		private RelativeLayout rl_errand_Set, rl_errand_servicetype, rl_errand_ordersearch;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Create your application here
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.ErrandMainLayout);
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
			tv_desc.Text = "跑腿服务";

			//跑腿服务设置
			rl_errand_Set = FindViewById<RelativeLayout> (Resource.Id.rl_errand_Set);
			rl_errand_Set.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(ServiceSetActivity));
				intent.PutExtra("serviceType",(int)ServiceType.Errand);
				StartActivity(intent);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//跑腿服务类型
			rl_errand_servicetype = FindViewById<RelativeLayout>(Resource.Id.rl_errand_servicetype);
			rl_errand_servicetype.Click += (sender, e) => 
			{
				StartActivity(typeof(ErrandServiceActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

			//跑腿预约查询
			rl_errand_ordersearch = FindViewById<RelativeLayout>(Resource.Id.rl_errand_ordersearch);
			rl_errand_ordersearch.Click += (object sender, EventArgs e) => 
			{
				var intent = new Intent(this,typeof(ServiceOrderSearchActivity));
				intent.PutExtra("serviceType",(int)ServiceType.Errand);
				StartActivity(intent);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

		}
	}
}

