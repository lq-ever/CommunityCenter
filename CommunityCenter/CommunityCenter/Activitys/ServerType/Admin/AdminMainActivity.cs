
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
	[Activity (Theme="@style/MyCustomTheme")]			
	public class AdminMainActivity : Activity
	{
		private RelativeLayout rl_admin_Set,rl_admin_guardianApply,rl_admin_guardians,rl_admin_alarmRecords,rl_admin_healthRecords;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.AdminMainLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			InitView ();
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
			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "管理员";
			//设置
			rl_admin_Set = FindViewById<RelativeLayout> (Resource.Id.rl_admin_Set);
			rl_admin_Set.Click += (object sender, EventArgs e) => 
			{
				
				StartActivity(typeof(AdminSetActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//会员申请
			rl_admin_guardianApply = FindViewById<RelativeLayout> (Resource.Id.rl_admin_guardianApply);
			rl_admin_guardianApply.Click += (object sender, EventArgs e) => 
			{
				StartActivity(typeof(GuardianApplyActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//绑定会员记录
			rl_admin_guardians = FindViewById<RelativeLayout> (Resource.Id.rl_admin_guardians);
			rl_admin_guardians.Click += (sender, e) => 
			{
				StartActivity(typeof(BindGuardianActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//报警记录
			rl_admin_alarmRecords  = FindViewById<RelativeLayout>(Resource.Id.rl_admin_alarmRecords);
			rl_admin_alarmRecords.Click += (sender, e) => 
			{
				StartActivity(typeof(AlarmRecordsActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//体检记录
			rl_admin_healthRecords = FindViewById<RelativeLayout>(Resource.Id.rl_admin_healthRecords);
			rl_admin_healthRecords.Click += (sender, e) => 
			{
				StartActivity(typeof(HealthRecordsActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

		}
	}
}

