
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
	public class ServiceAreaActivity : Activity
	{
		private EditText edit_startServiceArea, edit_endServiceArea;
		private Button btn_Confirm;
		private string startServiceArea, endServiceArea;
		private int serviceType;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.ServiceAreaLayout);
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
			tv_desc.Text = "设置服务范围";

			edit_startServiceArea = FindViewById<EditText> (Resource.Id.edit_startServiceArea);
			edit_endServiceArea = FindViewById<EditText> (Resource.Id.edit_endServiceArea);

			//获取serviceType值
			serviceType = Intent.GetIntExtra("serviceType",0);
			//确认按钮
			btn_Confirm = FindViewById<Button> (Resource.Id.btn_Confirm);
			btn_Confirm.Click += (sender, e) => 
			{
				var intent = new Intent();
				intent.PutExtra("startServiceArea",startServiceArea);
				intent.PutExtra("endServiceArea",endServiceArea);
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

