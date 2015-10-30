using System;
using Android.OS;
using Android.Util;
using Android.Content;
using CN.Jpush.Android.Api;
using System.Collections.Generic;

namespace CommunityCenter.Common
{
	public class JPushUtil: InstrumentedActivity,ITagAliasCallback
	{
		private  Handler handler;
		private ISharedPreferences sp_userinfo, sp_jpushInfo;
		private const int MSG_SET_ALIAS = 1001; 
		private const int MSG_SET_TAGS = 1002;
		private static readonly string Tag = "JPushSetAlias";
		private Context context;

		public JPushUtil (Context _context)
		{
			context = _context;
			handler = new Handler(DealMessage);
			//或得共享实例变量
			sp_userinfo = context.GetSharedPreferences(Global.SHAREDPREFERENCES_USERINFO,FileCreationMode.Private);
			sp_jpushInfo = context.GetSharedPreferences (Global.SHAREDPREFERENCES_JPUSH, FileCreationMode.Private);
		}

		/// <summary>
		/// hanlder回调函数
		/// </summary>
		/// <param name="msg">Message.</param>
		private void DealMessage(Message msg)
		{
			switch (msg.What) {
			case MSG_SET_ALIAS:
				Log.Debug (Tag,"设置aliasname");
				JPushInterface.SetAlias (context, (string)msg.Obj, this);
				break;
			case MSG_SET_TAGS:
				Log.Debug (Tag,"设置tag标签");
				JPushInterface.SetTags (context, (ICollection<string>)msg.Obj, this);
				break;

			}
		}


		/// <summary>
		/// 重写ITagAliasCallback方法
		/// </summary>
		/// <param name="p0">P0.</param>
		/// <param name="p1">P1.</param>
		/// <param name="p2">P2.</param>
		public  void GotResult (int code, string alias, ICollection<string> tags)
		{

			string logs;
			switch (code) {
			case 0:
				logs = "set alias or tags sucess";
				Log.Debug (Tag, logs);
				//写入shareprefrences值,保存
				sp_jpushInfo.Edit ().PutString (Global.Jpush_Alias,alias).Commit ();
				break;
			case 6002:
				logs = "failed set to alias or tags due to timeout,try again after 60s";
				Log.Debug (Tag, logs);
				if (EldYoungUtil.IsConnected(context))
					handler.SendMessageDelayed (handler.ObtainMessage (MSG_SET_ALIAS, alias), 1000 * 60);
				else
					Log.Debug (Tag,"no network");
				break;
			default:
				logs = "faild with errcode:" + code;
				Log.Debug (Tag, logs);
				break;
			}


		}

		/// <summary>
		/// 设置alias
		/// </summary>
		/// <param name="alias">Alias.</param>
		public  void SetAlias(string alias)
		{
			
			if (string.IsNullOrEmpty (alias))
				return;
			if (!EldYoungUtil.IsValidTagAndAlias (alias))
				return;
			//判断是否已经设置过别名，若设置过，将不在设置
			var jpush_alias = sp_jpushInfo.GetString(Global.Jpush_Alias,string.Empty);
			if (alias == jpush_alias)
				return;
			//使用hanlder异步设置alias
			handler.SendMessage(handler.ObtainMessage(MSG_SET_ALIAS,alias));
		}
	}
}

