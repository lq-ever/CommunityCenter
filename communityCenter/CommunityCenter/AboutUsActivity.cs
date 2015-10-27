
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
using CommunityCenter.Common;


namespace CommunityCenter
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class AboutUsActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.AboutUsLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			// Create your application here
			InitView();
		}
		private void InitView()
		{
			//设置标题栏
			var btn_header_back = FindViewById<Button> (Resource.Id.btn_header_back);
			btn_header_back.Click += (sender, e) => 
			{
				this.Finish();
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			var tv_header_title = FindViewById<TextView> (Resource.Id.tv_header_title);
			tv_header_title.Text = "关于我们";
			var tv_appversion = FindViewById<TextView> (Resource.Id.tv_appversion);
			tv_appversion.Text = "社区中心Android版 V"+EldYoungUtil.GetAppVersionCode(this);
		}
	}
}

