
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
	public class ServiceDescActivity : Activity
	{
		private EditText edit_serviceDesc;
		private Button btn_Confirm;
		private int serviceType;
		private string serviceDesc;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.ServiceDescLayout);
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
			tv_desc.Text = "设置服务描述";

			//获取serviceType值
			serviceType = Intent.GetIntExtra("serviceType",0);

			btn_Confirm = FindViewById<Button> (Resource.Id.btn_Confirm);
			btn_Confirm.Click += (object sender, EventArgs e) => 
			{
				serviceDesc = tv_desc.Text;
				var intent = new Intent();
				intent.PutExtra("serviceDesc",serviceDesc);
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

