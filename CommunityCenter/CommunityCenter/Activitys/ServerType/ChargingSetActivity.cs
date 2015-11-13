
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

namespace CommunityCenter.Activitys.ServerType
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class ChargingSetActivity : Activity
	{
		private int serviceType;
		private EditText edit_YHour, edit_YDay;
		private Button btn_Confirm;
		private string chargeYHour, chargeYDay;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.ChargingSetLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			InitView ();
		}
		private void InitView()
		{
			//设置标题栏
			var img_header_back = FindViewById<ImageView> (Resource.Id.img_header_back);
			img_header_back.Click += (sender, e) => 
			{
				SetResult(Result.Canceled);
				this.Finish();
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			var tv_back = FindViewById<TextView> (Resource.Id.tv_back);
			tv_back.Text = "关闭";
			var tv_desc = FindViewById<TextView> (Resource.Id.tv_desc);
			tv_desc.Text = "收费设置";
			//获取serviceType值
			serviceType = Intent.GetIntExtra("serviceType",0);
			//确定按钮
			btn_Confirm = FindViewById<Button> (Resource.Id.btn_Confirm);
			btn_Confirm.Click += (sender, e) => 
			{
				chargeYHour = edit_YHour.Text;
				chargeYDay = edit_YDay.Text;
				var intent = new Intent();
				intent.PutExtra("chargeYHour",chargeYHour);
				intent.PutExtra("chargeYDay",chargeYDay);
				//todo:调用webservice提交服务器
				SetResult(Result.Ok,intent);
				this.Finish();
			};

		}

		public override void OnBackPressed ()
		{
			SetResult(Result.Canceled);
			base.OnBackPressed ();
		}
	}
}

