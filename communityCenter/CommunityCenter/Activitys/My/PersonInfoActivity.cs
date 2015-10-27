
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


namespace CommunityCenter.Activitys.My
{
	[Activity (Theme="@style/MyCustomTheme")]			
	public class PersonInfoActivity : Activity
	{
		private RelativeLayout rl_person_UserName, rl_person_TrueName, rl_person_IdCardNo, rl_person_Gender, rl_person_Birth, rl_person_phoneNumber, rl_person_fixedPhone,
			rl_person_email, rl_person_IdCardLocation, rl_person_trueLocation;
		private TextView tv_UserName, tv_TrueName, tv_IdCardNo, tv_Gender, tv_Birth, tv_phoneNumber, tv_fixedPhone, tv_email, tv_IdCardLocation, tv_TrueLocation;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.PersonInfoLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			InitView ();
			// Create your application here
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
			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "个人信息";
			//用户名
			rl_person_UserName = FindViewById<RelativeLayout> (Resource.Id.rl_person_UserName);
			tv_UserName = FindViewById<TextView> (Resource.Id.tv_UserName);
			//真实姓名
			rl_person_TrueName = FindViewById<RelativeLayout>(Resource.Id.rl_person_TrueName);
			tv_TrueName = FindViewById<TextView> (Resource.Id.tv_TrueName);
			rl_person_TrueName.Click += (sender, e) => 
			{
				StartActivity(typeof(PersonInfoTrueNameActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//身份证号码
			rl_person_IdCardNo = FindViewById<RelativeLayout> (Resource.Id.rl_person_IdCardNo);
			tv_IdCardNo = FindViewById<TextView> (Resource.Id.tv_IdCardNo);
			rl_person_IdCardNo.Click += (sender, e) => 
			{
				StartActivity(typeof(PersonInfoIdCardNoActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

			//性别
			rl_person_Gender = FindViewById<RelativeLayout>(Resource.Id.rl_person_Gender);
			tv_Gender = FindViewById<TextView> (Resource.Id.tv_Gender);
			rl_person_Gender.Click += (sender, e) => 
			{
				StartActivity(typeof(PersonInfoGenderActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//生日
			rl_person_Birth = FindViewById<RelativeLayout>(Resource.Id.rl_person_Birth);
			tv_Birth = FindViewById<TextView> (Resource.Id.tv_Birth);
			rl_person_Birth.Click += (sender, e) => 
			{
				StartActivity(typeof(PersonInfoBirthActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//手机号码
			rl_person_phoneNumber = FindViewById<RelativeLayout>(Resource.Id.rl_person_phoneNumber);
			tv_phoneNumber = FindViewById<TextView> (Resource.Id.tv_phoneNumber);
			rl_person_phoneNumber.Click += (sender, e) => 
			{
				//暂时不搞
			};
			//固定电话
			rl_person_fixedPhone = FindViewById<RelativeLayout>(Resource.Id.rl_person_fixedPhone);
			tv_fixedPhone = FindViewById<TextView> (Resource.Id.tv_fixedPhone);
			rl_person_fixedPhone.Click += (sender, e) => 
			{
				StartActivity(typeof(PersonInfoFixedPhoneActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//邮箱
			rl_person_email = FindViewById<RelativeLayout>(Resource.Id.rl_person_email);
			tv_email = FindViewById<TextView> (Resource.Id.tv_email);
			rl_person_email.Click += (sender, e) => 
			{
				StartActivity(typeof(PersonInfoEmailActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//身份证所在地
			rl_person_IdCardLocation = FindViewById<RelativeLayout>(Resource.Id.rl_person_IdCardLocation);
			tv_IdCardLocation = FindViewById<TextView> (Resource.Id.tv_IdCardLocation);
			rl_person_IdCardLocation.Click += (sender, e) => 
			{
				StartActivity(typeof(PersonInfoIdCardNoLocationActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//详细地址
			rl_person_trueLocation = FindViewById<RelativeLayout>(Resource.Id.rl_person_trueLocation);
			tv_TrueLocation = FindViewById<TextView> (Resource.Id.tv_TrueLocation);
			rl_person_trueLocation.Click += (sender, e) => 
			{
				StartActivity(typeof(PersonInfoTrueLocationActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

		}
		private void SetPersonInfoShow()
		{
			//用户名
			tv_UserName.Text = Global.MyInfo.UserName;
			//真实姓名
			tv_TrueName.Text = string.IsNullOrEmpty (Global.MyInfo.TrueName) ? "" : Global.MyInfo.TrueName;
			//身份证号码
			tv_IdCardNo.Text = string.IsNullOrEmpty (Global.MyInfo.IDNumber) ? "" : Global.MyInfo.IDNumber;
			//性别
			if (string.IsNullOrEmpty (Global.MyInfo.Gender))
				tv_Gender.Text = "未设置";
			else if (Global.MyInfo.Gender.Equals ("0"))
				tv_Gender.Text = "男";
			else if (Global.MyInfo.Gender.Equals ("1"))
				tv_Gender.Text = "女";
				
			//生日
			tv_Birth.Text = !string.IsNullOrEmpty (Global.MyInfo.Age) ?Convert.ToDateTime(Global.MyInfo.Age).ToString("yyyy-MM-dd") :"";
			//电话号码

			var iphoneNumber = Global.MyInfo.PhoneNumberOne;
			if (!string.IsNullOrEmpty (iphoneNumber)) {
				var midleStr = iphoneNumber.Substring (3, 4);
				var resultStr = iphoneNumber.Replace (midleStr, "****");
				tv_phoneNumber.Text = resultStr;
			} else
				tv_phoneNumber.Text = string.Empty;
			//固定电话

			tv_fixedPhone.Text = !string.IsNullOrEmpty (Global.MyInfo.TelePhoneNumber) ? Global.MyInfo.TelePhoneNumber : "";
			//电子邮箱
			tv_email.Text = !string.IsNullOrEmpty (Global.MyInfo.Email) ? Global.MyInfo.Email : "";
			//身份证所在地
			tv_IdCardLocation.Text = !string.IsNullOrEmpty (Global.MyInfo.IDAddress) ? Global.MyInfo.IDAddress : "";
			//todo:设置详细地址
			tv_TrueLocation.Text = string.Empty;
		}
		protected override void OnResume ()
		{
			SetPersonInfoShow ();
			base.OnResume ();
		}
	}
}

