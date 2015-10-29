using System;
using Android.App;
using Android.Content;
using System.Collections.Generic;
using Android.Util;
using Android.Net;
using Android.Telephony;
using Android.OS;
using Android.Content.PM;
using System.Text.RegularExpressions;

namespace CommunityCenter.Common
{
	public class EldYoungUtil
	{
		public static readonly String KEY_APP_KEY = "JPUSH_APPKEY";
		public EldYoungUtil ()
		{
		}
		public static string FormatStrVaue(string strValue)
		{
			return string.IsNullOrEmpty (strValue) ? string.Empty : strValue;
		}


		/// <summary>
		/// Gets a value HasLogin属性判断是否登录
		/// </summary>
		/// <value><c>true</c> if has login; otherwise, <c>false</c>.</value>
		public static bool HasLogin
		{
			get{
				return !string.IsNullOrEmpty (Global.Guid);
			}
		}
		/// <summary>
		/// 启动登录活动activity.并传入参数至下一步
		/// </summary>
		/// <param name="activity">Activity.</param>
		public static void StartLoginActivity(Activity activity,FuncActivityType _funcActivityType)
		{
			Intent intent = new Intent (activity, typeof(LoginActivity));
			intent.PutExtra (Global.FuncType, (int)_funcActivityType);
			activity.StartActivity(intent);
			activity.OverridePendingTransition(Resource.Animation.bottom_in,0);
		}

		/// <summary>
		/// 判断应用程序是否已经启动
		/// </summary>
		/// <returns><c>true</c> if is applive the specified context packageName; otherwise, <c>false</c>.</returns>
		/// <param name="context">Context.</param>
		/// <param name="packageName">Package name.</param>
		public static bool IsApplive(Context context,string packageName)
		{
			ActivityManager _activityManager = (ActivityManager)context.GetSystemService (Context.ActivityService);

			IList<ActivityManager.RunningAppProcessInfo> processInfos = _activityManager.RunningAppProcesses;
			for (int i = 0; i < processInfos.Count; i++) {
				if (processInfos [i].ProcessName.Equals (packageName)) {
					Log.Debug("NotificationLaunch","app is alive,return true");
					return true;
				}
			}
			Log.Debug("NotificationLaunch","app is not alive,return false");
			return false;
		}

		/// <summary>
		/// 检测网络连接状态
		/// </summary>
		/// <returns><c>true</c> if this instance is connected the specified context; otherwise, <c>false</c>.</returns>
		/// <param name="context">Context.</param>
		public static bool IsConnected(Context context)
		{
			bool netFlag = false;
			ConnectivityManager connManager = (ConnectivityManager)context.GetSystemService (Context.ConnectivityService);

			if (connManager.ActiveNetworkInfo != null) {
				var wifiWorkInfo = connManager.GetNetworkInfo (ConnectivityType.Wifi);
				var gprsWorkInfo = connManager.GetNetworkInfo (ConnectivityType.Mobile);
				if (wifiWorkInfo != null && wifiWorkInfo.IsAvailable != false)
					netFlag = true;
				if (gprsWorkInfo != null && gprsWorkInfo.IsConnected != false)
					netFlag = true;
			}
			return netFlag;

		}
		/// <summary>
		/// 获取手机Imei
		/// </summary>
		/// <returns>The imei.</returns>
		/// <param name="context">Context.</param>
		public static string GetImei(Context context)
		{
			try{
				TelephonyManager telePhoneManager = (TelephonyManager) context.GetSystemService (Context.TelephonyService);
				return telePhoneManager.DeviceId;
			}
			catch(Android.Content.PM.PackageManager.NameNotFoundException ex) {
				return string.Empty;
			}
		}

		/// <summary>
		/// 获取app版本号versioncode
		/// </summary>
		/// <returns>The app version.</returns>
		/// <param name="context">Context.</param>
		public static string GetAppVersionCode(Context context)
		{
			return	context.PackageManager.GetPackageInfo (context.PackageName, 0).VersionName;
		}

		/// <summary>
		/// 获取JPushapp key
		/// </summary>
		/// <returns>The J push app key.</returns>
		/// <param name="context">Context.</param>
		public static string GetJPushAppKey(Context context)
		{
			Bundle metaData = null;
			string appKey = null;
			try{

				ApplicationInfo  info = context.PackageManager.GetApplicationInfo(context.PackageName,PackageInfoFlags.MetaData);

				if(info!=null)
					metaData = info.MetaData;
				if(metaData!=null)
					appKey = metaData.GetString(KEY_APP_KEY);
				if(appKey!=null && appKey.Length !=24)
					appKey = null;
			}
			catch(Android.Content.PM.PackageManager.NameNotFoundException ex) {

			}
			return appKey;
		}



		/// <summary>
		/// 检测tag或别名有效性,只能是数字、英文字母、中文
		/// </summary>
		/// <returns><c>true</c> if is valid tag and alias the specified str; otherwise, <c>false</c>.</returns>
		/// <param name="str">String.</param>
		public static bool IsValidTagAndAlias(string str)
		{
			Regex regex = new Regex ("^[\u4E00-\u9FA50-9a-zA-Z_-]{0,}$");
			return regex.IsMatch (str);
		}

		/// <summary>
		/// 用户名验证 4-20位，由中英文、数字、下划线组成
		/// </summary>
		/// <returns><c>true</c> if is valid user name the specified userName; otherwise, <c>false</c>.</returns>
		/// <param name="userName">User name.</param>
		public static bool IsValidUserName(string userName)
		{
			var userNameRegex = "^[a-zA-Z0-9_u4e00-u9fa5]{4,20}$";
			return Regex.IsMatch (userName, userNameRegex);
		}
		/// <summary>
		/// 密码验证 6-20位，建议由字母、数字和符号两种以上组成
		/// </summary>
		/// <returns><c>true</c> if is pass word the specified passWord; otherwise, <c>false</c>.</returns>
		/// <param name="passWord">Pass word.</param>
		public static bool IsPassWord(string passWord)
		{
			var pwdRegx = "^[\\x21-\\x7E]{6,20}$";
			return Regex.IsMatch (passWord, pwdRegx);
		}

		/// <summary>
		/// 验证手机号
		/// </summary>
		/// <returns><c>true</c> if is mobile no the specified mobileNo; otherwise, <c>false</c>.</returns>
		/// <param name="mobileNo">Mobile no.</param>
		public static bool IsMobileNo(string mobileNo)
		{

			if (string.IsNullOrEmpty (mobileNo))
				return false;
			var telRegex = "^(0|86|17951)?(13[0-9]|15[012356789]|17[678]|18[0-9]|14[57])[0-9]{8}$";
			return Regex.IsMatch (mobileNo, telRegex);

		}

		/// <summary>
		/// 手机安全码
		/// </summary>
		/// <returns><c>true</c> if is security code the specified code; otherwise, <c>false</c>.</returns>
		/// <param name="code">Code.</param>
		public static bool IsSecurityCode(string code)
		{
			var securityCode = "^\\d{6}$";
			return Regex.IsMatch (code, securityCode);
		}
		/// <summary>
		/// 验证固定电话号码
		/// </summary>
		/// <returns><c>true</c> if is fixed phone the specified fixedPhone; otherwise, <c>false</c>.</returns>
		/// <param name="fixedPhone">Fixed phone.</param>
		public static bool IsFixedPhone(string fixedPhone)
		{
			var fixedRegx = "\\d{3}-\\d{8}|\\d{4}-\\d{7,8}";
			return Regex.IsMatch (fixedPhone, fixedRegx);
		}
		/// <summary>
		/// 验证身份证号码
		/// </summary>
		/// <returns><c>true</c> if is identifier card no the specified IdCardNo; otherwise, <c>false</c>.</returns>
		/// <param name="IdCardNo">Identifier card no.</param>
		public static bool IsIdCardNo(string IdCardNo)
		{
			var idCardNoRegx = "^(^[1-9]\\d{7}((0\\d)|(1[0-2]))(([0|1|2]\\d)|3[0-1])\\d{3}$)|(^[1-9]\\d{5}[1-9]\\d{3}((0\\d)|(1[0-2]))(([0|1|2]\\d)|3[0-1])((\\d{4})|\\d{3}[Xx])$)$";
			return Regex.IsMatch (IdCardNo, idCardNoRegx);
		}
		/// <summary>
		/// 验证邮箱号码
		/// </summary>
		/// <returns><c>true</c> if is email the specified email; otherwise, <c>false</c>.</returns>
		/// <param name="email">Email.</param>
		public static bool IsEmail(string email)
		{
			var emailRegx = "[\\w!#$%&'*+/=?^_`{|}~-]+(?:\\.[\\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\\w](?:[\\w-]*[\\w])?\\.)+[\\w](?:[\\w-]*[\\w])?";
			return Regex.IsMatch (email, emailRegx);
		}
		/// <summary>
		/// 验证是否真实姓名 不可包含字母、数字、特殊符号和非法词汇[2~8个汉字]
		/// </summary>
		/// <returns><c>true</c> if is true name the specified trueName; otherwise, <c>false</c>.</returns>
		/// <param name="trueName">True name.</param>
		public static bool IsTrueName(string trueName)
		{
			var trueNameRegx = "[\\u4e00-\\u9fa5]{2,8}";
			return Regex.IsMatch (trueName,trueNameRegx);
		}

		public static int px2dip(Context context, float pxValue)
		{
			var m = context.Resources.DisplayMetrics.Density;
			return (int)(pxValue / m + 0.5f) ;
		}
	}
}

