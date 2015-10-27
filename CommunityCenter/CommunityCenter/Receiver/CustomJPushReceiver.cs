using System;
using Android.Content;
using Android.Util;
using Android.App;
using Android.OS;
using Java.Util.Logging;
using CN.Jpush.Android.Api;
using System.Text;
using CommunityCenter.Common;
using CommunityCenter.Activitys.Alarm;



namespace CommunityCenter.Receiver
{
	public class CustomJPushReceiver:BroadcastReceiver 
	{
		private static readonly string TAG = "CustomJPushReceiver";

		private NotificationManager notificationManager;

		public CustomJPushReceiver ()
		{
			
		}

		public override void OnReceive (Context context, Intent intent)
		{
			
			
			if (notificationManager == null)
				notificationManager = (NotificationManager) context.GetSystemService (Context.NotificationService);
			Bundle bundle = intent.Extras;
			Log.Debug (TAG,"[CustomJPushReceiver] onReceive - "+intent.Action +",extrals:"+ printBundle(bundle));

			if (JPushInterface.ActionRegistrationId.Equals (intent.Action)) {
				//注册成功,获取广播中的registerid
				var regId = bundle.GetString(JPushInterface.ExtraRegistrationId);
				Log.Debug(TAG, "[CustomJPushReceiver] 接收Registration Id : " + regId);
			    
			}
			else if (JPushInterface.ActionMessageReceived.Equals (intent.Action)) {
				//接收自定义消息
				Log.Debug(TAG, "[CustomJPushReceiver] 接收到推送下来的自定义消息: " + bundle.GetString(JPushInterface.ExtraMessage));
				ProcessCustomMessage(context, bundle);
				
			} else if (JPushInterface.ActionNotificationReceived.Equals (intent.Action)) {
				//接收到用户通知
				int notifactionId = bundle.GetInt(JPushInterface.ExtraNotificationId);
				Log.Debug(TAG, "[CustomJPushReceiver] 接收到推送下来的通知的ID: " + notifactionId);

			} else if (JPushInterface.ActionNotificationOpened.Equals (intent.Action)) {

				Log.Debug(TAG, "[CustomJPushReceiver] 用户点击打开了通知");
				OpenNotification (context,bundle);

			} else if (JPushInterface.ActionRichpushCallback.Equals (intent.Action)) {
				Log.Debug(TAG, "[CustomJPushReceiver] 用户收到到RICH PUSH CALLBACK: " + bundle.GetString(JPushInterface.ExtraExtra));
				//在这里根据 JPushInterface.EXTRA_EXTRA 的内容处理代码，比如打开新的Activity， 打开一个网页等..

			} else if (JPushInterface.ActionConnectionChange.Equals (intent.Action)) {
				//接收网络变化 连接/断开
				var connected = intent.GetBooleanExtra(JPushInterface.ExtraConnectionChange, false);
				Log.Warn(TAG, "[CustomJPushReceiver]" + intent.Action +" connected state change to "+connected);
			} else {
				//处理其它意图
				Log.Debug(TAG, "Unhandled intent - " + intent.Action);
			}
				

		}

		// 打印所有的 intent extra 数据
		private static String printBundle(Bundle bundle) {
			StringBuilder sb = new StringBuilder();
			foreach (string key in bundle.KeySet()) {
				if (key.Equals(JPushInterface.ExtraNotificationId)) {
					sb.Append("\nkey:" + key + ", value:" + bundle.GetInt(key));
				}else if(key.Equals(JPushInterface.ExtraConnectionChange)){
					sb.Append("\nkey:" + key + ", value:" + bundle.GetBoolean(key));
				} 
				else {
					sb.Append("\nkey:" + key + ", value:" + bundle.GetString(key));
				}
			}
			return sb.ToString();
		}
			
		private void OpenNotification(Context context,Bundle bundle)
		{
			//清除所有通知
			JPushInterface.ClearAllNotifications(context);
			//判断app进程是否存活
			if (EldYoungUtil.IsApplive (context, "com.lelaozu.communitycenter")) {
				//如果存活的话，就直接启动报警DetailActivity，但要考虑一种情况，就是app的进程虽然仍然在
				//但Task栈已经空了，比如用户点击Back键退出应用，但进程还没有被系统回收，如果直接启动
				//DetailActivity,再按Back键就不会返回任何界面了。所以在启动DetailActivity前，要先启动splash界面。
				Log.Info("NotificationReceiver", "the app process is alive");


				Intent mainIntent = new Intent(context, typeof(MainActivity));
				mainIntent.SetFlags(ActivityFlags.NewTask |ActivityFlags.SingleTop);
				Intent alarmDetailInfoIntent = new Intent(context, typeof(AlarmDetailInfoActivity));
				bundle.PutString("alarmOrigin","Jpush");
				alarmDetailInfoIntent.PutExtras (bundle);
				Intent[] intents = new Intent[] { mainIntent,alarmDetailInfoIntent};
				context.StartActivities (intents);

			} else {
				//如果app进程已经被杀死，先重新启动app，将alarmDetailActivity的启动参数传入Intent中，参数经过
				//SplashActivity传入MainActivity，此时app的初始化已经完成，在MainActivity中就可以根据传入,参数跳转到DetailActivity中去了
				Log.Info("NotificationReceiver", "the app process is dead");
				Intent launchIntent = context.PackageManager.GetLaunchIntentForPackage ("com.lelaozu.communitycenter");
				launchIntent.SetFlags(
					ActivityFlags.NewTask|ActivityFlags.ResetTaskIfNeeded);
				bundle.PutString("alarmOrigin","Jpush");
				launchIntent.PutExtras (bundle);
				context.StartActivity(launchIntent);

					
			}
				
		}

		/// <summary>
		/// 接收自定义消息
		/// </summary>
		/// <param name="context">Context.</param>
		/// <param name="bundle">Bundle.</param>
		private void ProcessCustomMessage(Context context,Bundle bundle)
		{
//			if (MainActivity.isForeground) {
//				String message = bundle.getString(JPushInterface.EXTRA_MESSAGE);
//				String extras = bundle.getString(JPushInterface.EXTRA_EXTRA);
//				Intent msgIntent = new Intent(MainActivity.MESSAGE_RECEIVED_ACTION);
//				msgIntent.putExtra(MainActivity.KEY_MESSAGE, message);
//				if (!ExampleUtil.isEmpty(extras)) {
//					try {
//						JSONObject extraJson = new JSONObject(extras);
//						if (null != extraJson && extraJson.length() > 0) {
//							msgIntent.putExtra(MainActivity.KEY_EXTRAS, extras);
//						}
//					} catch (JSONException e) {
//
//					}
//
//				}
//				context.sendBroadcast(msgIntent);
//			}

		}



	
	}


}

