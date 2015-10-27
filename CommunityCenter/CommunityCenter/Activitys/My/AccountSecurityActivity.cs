
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
using Com.Handmark.Pulltorefresh.Library;
using System.Threading.Tasks;
using System.Threading;
using CommunityCenter.Common;


namespace CommunityCenter.Activitys.My
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class AccountSecurityActivity : Activity
	{
		
		private TextView tv_payPwd,tv_phoneBind,tv_identity;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.AccountSecurityLayout);
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
			tv_header_title.Text = "账户安全";



			//登录密码
			var rl_person_loginPwd = FindViewById<RelativeLayout>(Resource.Id.rl_person_loginPwd);
			rl_person_loginPwd.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(SendSecurityCodeActivity));
				var sendbundle = new Bundle();
				sendbundle.PutString("SendType","ModifyPwd");//修改密码
				sendbundle.PutString("PhoneNumber",Global.MyInfo.PhoneNumberOne);
				intent.PutExtras(sendbundle);
				StartActivity(intent);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);

			};
			//修改支付密码
			var rl_person_payPwd = FindViewById<RelativeLayout>(Resource.Id.rl_person_payPwd);
			rl_person_payPwd.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(SendSecurityCodeActivity));
				var sendbundle = new Bundle();
				sendbundle.PutString("SendType","ModifyPayPwd");//设置支付密码
				sendbundle.PutString("PhoneNumber",Global.MyInfo.PhoneNumberOne);
				intent.PutExtras(sendbundle);
				StartActivity(intent);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			tv_payPwd = FindViewById<TextView> (Resource.Id.tv_payPwd);

			//手机绑定
			var rl_person_phoneBind = FindViewById<RelativeLayout>(Resource.Id.rl_person_phoneBind);
			rl_person_phoneBind.Click += (sender, e) => 
			{

			};
			tv_phoneBind = FindViewById<TextView> (Resource.Id.tv_phoneBind);

			//身份认证
			var rl_person_identity = FindViewById<RelativeLayout>(Resource.Id.rl_person_identity);
			rl_person_identity.Click += (sender, e) => 
			{

			};
			tv_identity = FindViewById<TextView> (Resource.Id.tv_identity);


		}

		private void SetDesShow()
		{
			tv_payPwd.Text = string.IsNullOrEmpty (Global.MyInfo.PayPassword) ? "设置" : "修改";
			tv_phoneBind.Text = string.IsNullOrEmpty (Global.MyInfo.PhoneNumberOne) ? "绑定" : "解绑";
			tv_identity.Text = string.IsNullOrEmpty (Global.MyInfo.IDNumber) ? "未认证" : "已认证";

		}

		protected override void OnResume ()
		{
			SetDesShow ();
			base.OnResume ();
		}
	}
}

