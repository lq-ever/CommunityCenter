
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
using Android.Content.PM;
using CommunityCenter.Common;
using CN.Jpush.Android.Api;

namespace CommunityCenter
{
	[Activity (MainLauncher =true,ScreenOrientation= ScreenOrientation.Portrait,  NoHistory = true,Theme= "@style/AppTheme")]			
	public class SplashActivity : InstrumentedActivity,IDialogInterfaceOnKeyListener
	{
		private Dialog noticeDialog;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Splash);
			new Handler ().PostDelayed (() => {
				//LoadActivity();
				var updateManager = new UpdateManager(this,true);
				if (updateManager.CheckUpdate())
				{
					var builder = new AlertDialog.Builder (this).SetTitle ("软件升级").SetMessage ("发现新版本,建议更新使用新版本").SetOnKeyListener(this).SetCancelable(false);
					builder.SetPositiveButton ("下载", (sender, e) => {
						noticeDialog.Dismiss();	
						//显示下载对话框,下载
						updateManager.ShowDownloadDialog();
					});
					builder.SetNegativeButton ("以后再说", (sender, e) => {
						noticeDialog.Dismiss();	
						LoadActivity();
					});
					noticeDialog= builder.Create ();
					noticeDialog.Show();
				}
				else
				{
					LoadActivity();
				}
			},2000);
		
			// Create your application here
		}

		public bool OnKey (IDialogInterface dialog, [GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			if (keyCode == Keycode.Back && e.RepeatCount == 0)
				return true;
			return false;
		}
		/// <summary>
		/// 进入界面.
		/// </summary>
		public void LoadActivity()
		{
			//如果启动app的Intent中带有额外的参数，表明app是从点击通知栏的动作中启动的
			//将参数取出，传递到MainActivity中

			var sharedPreferenceuserinfo = this.GetSharedPreferences(Global.SHAREDPREFERENCES_USERINFO,FileCreationMode.Private);
			//读取refrence文件
			var isFirstLaunch = sharedPreferenceuserinfo.GetBoolean (Global.refrence_IsFirstIn, true);//是否第一次登录
			Global.Guid = sharedPreferenceuserinfo.GetString(Global.refrence_Guid,string.Empty);//guid
			if (isFirstLaunch) {
				//软件第一次使用，进入功能引导页				
				StartActivity (typeof(GuiderActivity));
			} else {
				//不是第一次使用，直接进入主界面
				StartActivity(typeof(MainActivity));
			}
			this.Finish ();
			OverridePendingTransition (Resource.Animation.fade_in, Resource.Animation.fade_out);
		}

		protected override void OnResume ()
		{
			base.OnResume ();
			JPushInterface.OnResume (ApplicationContext);
		}
		protected override void OnPause ()
		{
			base.OnPause ();
			JPushInterface.OnPause (ApplicationContext);
		}

	}
}

