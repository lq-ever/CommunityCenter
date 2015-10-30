
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

namespace CommunityCenter.Activitys.HouseKeep
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class HouseKeepMainActivity : Activity
	{
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
			var tv_header_title = FindViewById<TextView> (Resource.Id.tv_header_title);
			tv_header_title.Text = "家政服务";
		}
	}
}

