using System;
using System.Threading;

using Android.Content;
using Android.Widget;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Net;
using Java.Net;
using Java.IO;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

using Android.Util;
using Newtonsoft.Json;
using CommunityCenter.Param;
using CommunityCenter.Json;





namespace CommunityCenter.Common
{
	public class UpdateManager:Activity,IDialogInterfaceOnKeyListener
	{
		private Context context;
		private SplashActivity splashAcivity;
		private bool loadNext =false;
		private const int DownLoading =1;
		private const int DownLoadFinish =2;

		//分隔符
		private static  String FILE_SEPARATOR = "/";  
		// 下载安装包存放路径  
		private static readonly String FILE_PATH = Android.OS.Environment.ExternalStorageDirectory.ToString()+FILE_SEPARATOR+"eldyoungCommCenter/Cache/Autoupdate/";

		// 文件存放全路径
		private string saveFileName = FILE_PATH +Global.package_name+".apk";
		private int progress;//记录下载进度

		private bool cancelUpdate =false;

		private ProgressBar mProgressbar;//更新进度条

	

		private Dialog dowloadDialog;
		private Dialog noticeDialog;

		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private string localversionCode;

		public UpdateManager (Context _context,bool _loadNext)
		{
			context = _context;
			loadNext = _loadNext;
			if(loadNext)
				splashAcivity = (SplashActivity)context;

		}
//		/// <summary>
//		/// 检测软件更新
//		/// </summary>
		public bool CheckUpdate()
		{
//			if (IsUpdate ()) {
//				//显示提示对话框
//				ShowNoticeDialog();
//			}
			//update by liuqiang 2015/07/08 for 暂停使用更新
			return IsUpdate(); 
			//return false;
		}
			

		/// <summary>
		/// 检测是否需要更新,调用web服务
		/// </summary>
		/// <returns><c>true</c> if this instance is update; otherwise, <c>false</c>.</returns>
		private bool IsUpdate()
		{
			var checkFlag = false;
			var returnFlag = false;
			// 获取本地软件版本号，
			localversionCode =EldYoungUtil.GetAppVersionCode(context);
			//localversionCode =eldyoungUtil.GetAppVersionCode;
			//获取webservice中android app版本号,两者比较，如果不同，返回true else false
			//检测网络连接
			if(!EldYoungUtil.IsConnected(context))
			{
				return returnFlag;
			}
			var getAppVersionParam = new GetAppVersionParam ();

			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", getAppVersionParam.Key);
			else
				requestParams ["key"] = getAppVersionParam.Key;
			if (!requestParams.ContainsKey ("eappPlatform"))
				requestParams.Add ("eappPlatform", getAppVersionParam.EappPlatform);
			else
				requestParams ["eappPlatform"] = getAppVersionParam.EappPlatform;

			if (!requestParams.ContainsKey ("epackageName"))
				requestParams.Add ("epackageName", getAppVersionParam.EpackageName);
			else
				requestParams ["epackageName"] = getAppVersionParam.EpackageName;
			
			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", getAppVersionParam.Md5);
			else
				requestParams ["md5"] = getAppVersionParam.Md5;

			var restSharpRequestHelp = new RestSharpRequestHelp(getAppVersionParam.Url,requestParams);
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					//获取并解析返回resultJson获取安全码结果值
					var result =response.Content;
					if(string.IsNullOrEmpty(result))
					{
						checkFlag = true;
					}
					else
					{
						var appVersionJson = JsonConvert.DeserializeObject<GetAppVersionJson>(result);
						if(appVersionJson.statuscode =="1")
						{
							var serverAppVersionCode = appVersionJson.data.AppServerVersionCode;
							if(localversionCode!=serverAppVersionCode)
							{
								//版本不一致有更新
								Global.AppPackagePath = appVersionJson.data.AppFilePath;
								returnFlag = true;
								checkFlag=true;
							}
							else
								checkFlag=true;
						}
						else
							checkFlag = true;
					}
				}
				else
				{
					checkFlag=true;
					Log.Info("CheckAppServerVersion",string.IsNullOrEmpty(response.StatusDescription)?"":response.StatusDescription);

				}
			});

			while (true) {
				//检测完成
				if (checkFlag) {
					return returnFlag;
				}
			}
		}
		/// <summary>
		/// 显示软件更新对话框
		/// </summary>
		public void ShowNoticeDialog()
		{
			
			var builder = new AlertDialog.Builder (context).SetTitle ("软件升级").SetMessage ("发现新版本,建议更新使用").SetOnKeyListener(this).SetCancelable(false);

			builder.SetPositiveButton ("下载", (sender, e) => {
				noticeDialog.Dismiss();	
				//显示下载对话框
				ShowDownloadDialog();
			});
			builder.SetNegativeButton ("以后再说", (sender, e) => {
				noticeDialog.Dismiss();	

			});
			noticeDialog= builder.Create ();
			noticeDialog.Show();
		}

		/// <summary>
		/// 显示软件下载更新对话框
		/// </summary>
		public void ShowDownloadDialog()
		{
			
			var builder = new AlertDialog.Builder (context).SetTitle ("正在更新").SetCancelable(false).SetOnKeyListener(this).SetCancelable(false);
			var inflater = LayoutInflater.From (context);
			var view = inflater.Inflate (Resource.Layout.progressbar, null);
			mProgressbar = view.FindViewById<ProgressBar> (Resource.Id.progressbar);
			builder.SetView (view);

			builder.SetNegativeButton ("取消", (sender, e) => {
				dowloadDialog.Dismiss();
				//设置取消状态
				cancelUpdate = true;
				//从初始页加载
				if(loadNext)
					splashAcivity.LoadActivity();
			});
			dowloadDialog = builder.Create ();
			dowloadDialog.Show ();
			//异步下载文件
			Task.Factory.StartNew(()=>DownloadApk());

		}

		public bool OnKey (IDialogInterface dialog, Keycode keyCode, KeyEvent e)    
		{
			if (keyCode == Keycode.Back && e.RepeatCount == 0)
				return true;
			return false;
		}

		/// <summary>
		/// 下载apk文件
		/// </summary>
		private void DownloadApk()
		{
			
			URL url = null;  
			Stream instream = null;  
			FileOutputStream outstream = null;  
			HttpURLConnection conn = null;  
			try
			{
				url = new URL(Global.AppPackagePath);
				//创建连接
				conn = (HttpURLConnection) url.OpenConnection();
				conn.Connect();

				conn.ConnectTimeout =20000;
				//获取文件大小
				var filelength = conn.ContentLength;
				instream = conn.InputStream;
				var file = new Java.IO.File(FILE_PATH);
				if(!file.Exists())
				{
					file.Mkdir();
				}
				outstream = new FileOutputStream(new Java.IO.File(saveFileName));

				int count =0;
				//缓存
				byte[] buff = new byte[1024];
				//写入文件中
				do
				{
					int numread = instream.Read(buff,0,buff.Length);
					count+=numread;
					//计算进度条位置
					progress = (int)(((float)count/filelength)*100);
				    //更新进度---- other question

					mProgressbar.Progress = progress;
					if(numread<=0)
					{
						//下载完成,安装新apk
						Task.Factory.StartNew(InStallApk);
						break;
					}
					//写入文件
					outstream.Write(buff,0,numread);

				}
				while(!cancelUpdate);//点击取消，停止下载
					
			}
			catch(Exception ex)
			{
				Android.Util.Log.Error (ex.StackTrace,ex.Message);
			}
			finally
			{
				if (instream != null)
					instream.Close ();
				if (outstream != null)
					outstream.Close ();
				if(conn!=null)
				    conn.Disconnect ();
			}
			dowloadDialog.Dismiss ();
		}

		private void InStallApk()
		{
			var file = new Java.IO.File (saveFileName);
			if (!file.Exists ()) {
				return;
			}
			//通过Intent安装新的apk文件
			Intent intent = new Intent(Intent.ActionView);
			intent.SetDataAndType (Android.Net.Uri.Parse ("file://"+saveFileName.ToString()), "application/vnd.android.package-archive");
			context.StartActivity (intent);

		}

	}
}

