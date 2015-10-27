
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

using RestSharp;

using Newtonsoft.Json;
using CommunityCenter.Common;
using CommunityCenter.Param;
using CommunityCenter.Json;


namespace CommunityCenter
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class RegisterResultActivity : Activity
	{
		private Button btn_Submit;
		private TextView tv_PhoneShow;
		private EditText edit_SecurityCode;
		public Button btn_Send;
		private string phoneNum;
		private string nickName;
		private string passWord;
		public string securityCode;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private Dictionary<string,string> requestSmsParams = new Dictionary<string, string>();
		private JPushUtil _jpushUtil;
		private MyCount mc;
		private ISharedPreferences sp_userinfo;
		private TextView tv_SendCodeStatusShow;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.RegisterStepTwoLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			sp_userinfo = this.GetSharedPreferences(Global.SHAREDPREFERENCES_USERINFO,FileCreationMode.Private);
			_jpushUtil = new JPushUtil (this);
			InitView ();

		}
		private void InitView()
		{
			//设置标题栏
			var btn_header_back = FindViewById<Button> (Resource.Id.btn_header_back);
			btn_header_back.Click += (sender, e) => 
			{
				this.Finish();
			};


		
			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "填写短信验证码";

			btn_Submit = FindViewById<Button> (Resource.Id.btn_Submit);
			btn_Send = FindViewById<Button> (Resource.Id.btn_Send);
			tv_PhoneShow = FindViewById<TextView> (Resource.Id.tv_PhoneShow);
			edit_SecurityCode = FindViewById<EditText> (Resource.Id.edit_SecurityCode);
			tv_SendCodeStatusShow = FindViewById<TextView>(Resource.Id.tv_SendCodeStatusShow);
			//取得上一页面传递过来的值
			var bundle = Intent.Extras;
			//从bundle中获取值赋值显示
			phoneNum= bundle.GetString("phoneNum");
		 	nickName = bundle.GetString ("nickName");
		    passWord = bundle.GetString ("passWord");
		    securityCode = bundle.GetString("securityCode");

			tv_PhoneShow.Text = phoneNum;

			//初始化计时器,启动
			mc = new MyCount(this,60000,1000);
			mc.Start ();

			edit_SecurityCode.TextChanged+= (sender, e) => 
			{
				if(edit_SecurityCode.Text.Length>0)
				{
					btn_Submit.Enabled = true;
					btn_Submit.SetBackgroundResource(Resource.Color.blue);
				}
				else
				{
					btn_Submit.Enabled =false;
					btn_Submit.SetBackgroundResource(Resource.Color.lightgray);
				}
			};


			btn_Submit.Click += (sender, e) => 
			{
				
				var inputCode = edit_SecurityCode.Text;

				if(string.IsNullOrEmpty(inputCode) || !EldYoungUtil.IsSecurityCode(inputCode))
				{
					Toast.MakeText(this,"请输入接收到的手机验证码,且不能为空",ToastLength.Short).Show();
					return ;
				}
				if(inputCode!=securityCode)
				{
					Toast.MakeText(this,"输入验证码不正确,请重新填写",ToastLength.Short).Show();
					return;
				}

				Reister();
			
			};

			//发送验证码
			btn_Send.Click += (sender, e) => 
			{
				tv_SendCodeStatusShow.Visibility = ViewStates.Invisible;
				btn_Send.Clickable = false;
				btn_Send.SetBackgroundResource(Resource.Color.lightgray);
				btn_Send.SetTextColor(Resources.GetColor(Resource.Color.ingray));
				SendSMS(phoneNum);
			};



		}
		#region 重新发送验证码

		/// <summary>
		/// 发送消息
		/// </summary>
		/// <param name="phoneNum">Phone number.</param>
		private void SendSMS(string _phoneNumber)
		{
			ProgressDialogUtil.StartProgressDialog(this,"正在发送验证码...");

			//检测网络连接
			if(!EldYoungUtil.IsConnected(this))
			{
				Toast.MakeText(this,"网络连接超时,请检测网路",ToastLength.Short).Show();
				ProgressDialogUtil.StopProgressDialog();
				return;
			}

			var smsInfoParam = new SmsInfoParam () {
				PhoneNumber = phoneNum,NickName = nickName,PassWord = passWord
			};

			//使用restsharpApi方式

			SetRestRequestParams (smsInfoParam);

			var restSharpRequestHelp = new RestSharpRequestHelp(smsInfoParam.Url,requestSmsParams);

			restSharpRequestHelp.ExcuteAsync ((response) => {

				if(response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					
					//获取并解析返回resultJson获取安全码结果值
					var resultJson = response.Content;
					var smsJson = JsonConvert.DeserializeObject<SmsJson>(resultJson);
					if(smsJson.statuscode =="1")
					{
						RunOnUiThread(()=>{
							securityCode = smsJson.data.ToString();

							mc.Start();
							tv_SendCodeStatusShow.Visibility = ViewStates.Visible;
						});
					}
					else
					{
						RunOnUiThread(()=>
							{
								tv_SendCodeStatusShow.Visibility = ViewStates.Invisible;
								Toast.MakeText(this,smsJson.message,ToastLength.Short).Show();

							});
					}
				}
				else if(response.ResponseStatus == ResponseStatus.TimedOut)
				{
					RunOnUiThread(()=>
						{
							tv_SendCodeStatusShow.Visibility = ViewStates.Invisible;
							Toast.MakeText(this,"网络连接超时",ToastLength.Short).Show();
						});
				}
				else
				{
					RunOnUiThread(()=>
						{
							tv_SendCodeStatusShow.Visibility = ViewStates.Invisible;
							Toast.MakeText(this,response.StatusDescription,ToastLength.Short).Show();
						});
				}
				RunOnUiThread(()=>
					{
						ProgressDialogUtil.StopProgressDialog();
						return;
					});
			});
		}



		/// <summary>
		/// 设置发送短信参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestParams(SmsInfoParam smsInfoParam)
		{
			if (!requestSmsParams.ContainsKey ("key"))
				requestSmsParams.Add ("key", smsInfoParam.Key);
			else
				requestSmsParams ["key"] = smsInfoParam.Key;

			if (!requestSmsParams.ContainsKey ("eaction"))
				requestSmsParams.Add ("eaction", smsInfoParam.Eaction);
			else
				requestSmsParams ["eaction"] = smsInfoParam.Eaction;
			if (!requestSmsParams.ContainsKey ("ePhoneNumber"))
				requestSmsParams.Add ("ePhoneNumber", smsInfoParam.EphoneNumber);
			else
				requestSmsParams ["ePhoneNumber"] = smsInfoParam.EphoneNumber;
			if (!requestSmsParams.ContainsKey ("ePassword"))
				requestSmsParams.Add ("ePassword", smsInfoParam.EpassWord);
			else
				requestSmsParams ["ePassword"] = smsInfoParam.EpassWord;
			if (!requestSmsParams.ContainsKey ("eNickName"))
				requestSmsParams.Add ("eNickName", smsInfoParam.EnickName);
			else
				requestSmsParams ["eNickName"] = smsInfoParam.EnickName;
			if (!requestSmsParams.ContainsKey ("md5"))
				requestSmsParams.Add ("md5", smsInfoParam.Md5);
			else
				requestSmsParams ["md5"] = smsInfoParam.Md5;



		}

		#endregion


		#region 注册

		/// <summary>
		/// Reister this instance.
		/// </summary>
		private void Reister()
		{
			ProgressDialogUtil.StartProgressDialog(this,"正在注册...");
			//检测网络连接
			if(!EldYoungUtil.IsConnected(this))
			{
				Toast.MakeText(this,"网络连接超时,请检测网路",ToastLength.Short).Show();
				ProgressDialogUtil.StopProgressDialog();
				return;
			}


			//todo:调用restapi注册,将用户名、密码信息写
			var registerInfoParam = new RegisterInfoParam () {
				PhoneNumber = phoneNum,NickName = nickName,PassWord = passWord
			};

			//初始化参数
			SetRestRequestParams (registerInfoParam);

			var restSharpRequestHelp = new RestSharpRequestHelp(registerInfoParam.Url,requestParams);
			restSharpRequestHelp.ExcuteAsync ((response) => {
				if(response.ResponseStatus == ResponseStatus.Completed)
				{
					//获取并解析返回resultJson获取Guid结果值
					if(response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var resultJson = response.Content;
						var registerJson = JsonConvert.DeserializeObject<RegisterJson>(resultJson);
						if(registerJson.statuscode=="1")
						{
							Global.MyInfo = registerJson.data.Table[0];
							var Uid = Global.MyInfo.UId;
							Global.Guid = Uid;
							//登录成功，将登录guid写入refrence文件
							sp_userinfo.Edit().PutString(Global.refrence_Guid,Uid).Commit();
							var guidAsAlias = Uid.Replace("-","_");
							//注册用户成功，写极光推送别名,进入主界面
							_jpushUtil.SetAlias(guidAsAlias);
							sp_userinfo.Edit().PutString(Global.refrence_UserName,nickName).Commit();
							sp_userinfo.Edit().PutString(Global.refrence_Password,passWord).Commit();
							sp_userinfo.Edit().PutBoolean(Global.refrence_Password_Check,true).Commit();
							RunOnUiThread(()=>
								{
									//跳转到功能主界面
									var intent = new Intent(this,typeof(MainActivity));
									intent.SetFlags(ActivityFlags.ClearTask|ActivityFlags.NewTask);
									StartActivity(intent);			
									this.Finish();
									ProgressDialogUtil.StopProgressDialog();
									Toast.MakeText(this,"注册成功",ToastLength.Short).Show();
									OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
								});

						}
						else
						{
							//注册失败
							RunOnUiThread(()=>
								{
									Toast.MakeText(this,registerJson.message,ToastLength.Short).Show();
									ProgressDialogUtil.StopProgressDialog();
									return;
								});
						}
					}

				}
				else if(response.ResponseStatus == ResponseStatus.TimedOut)
				{
					RunOnUiThread(()=>
						{
							Toast.MakeText(this,"网络连接超时",ToastLength.Short).Show();
							ProgressDialogUtil.StopProgressDialog();
							return;
						});
				}
				else
				{
					RunOnUiThread(()=>
						{
							Toast.MakeText(this,response.StatusDescription,ToastLength.Short).Show();
							ProgressDialogUtil.StopProgressDialog();
							return;
						});
				}



			});

		}

		/// <summary>
		/// Sets the rest request parameters.
		/// </summary>
		/// <param name="registerInfoParam">Register info parameter.</param>
		private void SetRestRequestParams(RegisterInfoParam registerInfoParam)
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", registerInfoParam.Key);
			else
				requestParams ["key"] = registerInfoParam.Key;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", registerInfoParam.Eaction);
			else
				requestParams ["eaction"] = registerInfoParam.Eaction;
			
			if (!requestParams.ContainsKey ("ePhoneNumber"))
				requestParams.Add ("ePhoneNumber", registerInfoParam.EphoneNumber);
			else
				requestParams ["ePhoneNumber"] = registerInfoParam.EphoneNumber;
			
			if (!requestParams.ContainsKey ("ePassword"))
				requestParams.Add ("ePassword", registerInfoParam.EpassWord);
			else
				requestParams ["ePassword"] = registerInfoParam.EpassWord;
			
			if (!requestParams.ContainsKey ("eNickName"))
				requestParams.Add ("eNickName", registerInfoParam.EnickName);
			else
				requestParams ["eNickName"] = registerInfoParam.EnickName;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", registerInfoParam.Md5);
			else
				requestParams ["md5"] = registerInfoParam.Md5;
		

		}

		#endregion


		/// <summary>
		/// 发送验证码计时器
		/// </summary>
		public class MyCount:CountDownTimer
		{
			private RegisterResultActivity Activity;
			public MyCount(RegisterResultActivity _Activity,long millisInFuture, long countDownInterval):base(millisInFuture,countDownInterval)
			{
				Activity = _Activity;
			}
			public override void OnTick (long millisUntilFinished)
			{
				//Activity.btn_Send.Clickable = false;
				Activity.btn_Send.Text = (millisUntilFinished / 1000) + "秒后可重发";
			}
			public override void OnFinish ()
			{
				Activity.btn_Send.Text = "获取验证码";
				Activity.btn_Send.Clickable = true;
				Activity.securityCode = string.Empty;
				Activity.btn_Send.SetBackgroundResource (Resource.Color.blue);
				Activity.btn_Send.SetTextColor(Activity.Resources.GetColor(Resource.Color.white));
			}
		}


		public override void Finish ()
		{
			base.Finish ();
			mc.Cancel ();
		}


	}


}

