
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

using Java.IO;
using CommunityCenter.Common;

namespace CommunityCenter
{
	[Activity (Theme="@style/MyCustomTheme")]			
	public class SettingActivity : Activity,IDialogInterfaceOnKeyListener
	{
		private ISharedPreferences sp_userinfo;
		private string filePath = Android.OS.Environment.ExternalStorageDirectory.ToString () + "/eldyoungCommCenter/";
		private TextView tv_CacheSize;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.Setting);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			//或得共享实例变量
			sp_userinfo = this.GetSharedPreferences(Global.SHAREDPREFERENCES_USERINFO,FileCreationMode.Private);
			InitView ();
			// Create your application here
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
			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "设置";
			//获取缓存大小值
			tv_CacheSize = FindViewById<TextView> (Resource.Id.tv_CacheSize);
			tv_CacheSize.Text = DeleteCleanCacheManager.GetCacheSize(new File(filePath));
			//关于我们
			var rl_aboutUs = FindViewById<RelativeLayout> (Resource.Id.rl_aboutUs);
			rl_aboutUs.Click += (sender, e) => 
			{
				StartActivity(typeof(AboutUsActivity));
				OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);
			};
			//版本检测  待测试
			var rl_versionCheck = FindViewById<RelativeLayout>(Resource.Id.rl_versionCheck);
			rl_versionCheck.Click += (sender, e) => 
			{
				new Handler().PostDelayed(()=>
					{
						var updateManager = new UpdateManager(this,false);
						if (updateManager.CheckUpdate())
						{
							updateManager.ShowNoticeDialog();
						}
						else
						{
							RunOnUiThread(()=>
								{
									Toast.MakeText(this,"当前是已是最新版本",ToastLength.Short).Show();
								});
							
						}
						
					},1000);
				
			};
			//清楚缓存
			var rl_cacheRemover = FindViewById<RelativeLayout>(Resource.Id.rl_cacheRemover);
			rl_cacheRemover.Click += (sender, e) => 
			{
				//清除缓存
				if(DeleteCleanCacheManager.CleanCustomCache(filePath))
				{
					Toast.MakeText(this,"清除缓存成功",ToastLength.Short).Show();
					tv_CacheSize.Text = "0B";
				}
				else
				{
					Toast.MakeText(this,"清除缓存失败",ToastLength.Short).Show();
				}
				
			};

			//退出进入登录界面
			var btn_Exit = FindViewById<Button> (Resource.Id.btn_Exit);
			btn_Exit.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(MainActivity));
				intent.SetFlags(ActivityFlags.ClearTask|ActivityFlags.NewTask);
				StartActivity(intent);						
				this.Finish();
				//退出成功，将清空guid、密码文件信息，设置全局guid为空
				sp_userinfo.Edit().PutString(Global.refrence_Guid,string.Empty).Commit();
				sp_userinfo.Edit().PutString(Global.refrence_Password,string.Empty).Commit();
				Global.Guid = string.Empty;
				OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);
			};
		}
		public bool OnKey (IDialogInterface dialog, [GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			if (keyCode == Keycode.Back && e.RepeatCount == 0)
				return true;
			return false;
		}
	}
}

