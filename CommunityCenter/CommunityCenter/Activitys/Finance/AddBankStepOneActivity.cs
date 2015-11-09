
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

namespace CommunityCenter.Activitys.Finance
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class AddBankStepOneActivity : Activity
	{
		private EditText edit_cardOwnerName,edit_IdCardNo;
		private Button btn_Next;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.AddBankStepOneLayout);
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
			tv_desc.Text = "持卡人信息";
			edit_cardOwnerName = FindViewById<EditText> (Resource.Id.edit_cardOwnerName);
			edit_IdCardNo = FindViewById<EditText> (Resource.Id.edit_IdCardNo);
			btn_Next = FindViewById<Button> (Resource.Id.btn_Next);
			//todo:对持卡人姓名和身份证号码赋值

			//下一步
			btn_Next.Click += (sender, e) => 
			{
				StartActivity(typeof(AddBankStepTwoActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
		}
	}
}

