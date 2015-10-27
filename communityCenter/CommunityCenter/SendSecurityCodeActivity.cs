
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

using Newtonsoft.Json;
using CommunityCenter.Common;
using CommunityCenter.Json;
using CommunityCenter.Param;


namespace CommunityCenter
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class SendSecurityCodeActivity : Activity
	{
		private EditText edit_Phone,edit_SecurityCode;
		public Button btn_Send,btn_Next;
		private MyCount mc;
		private string securityCode;
		private string sendType;
		private string phoneNumber;
		private Dictionary<string,string> requestsendcodeParams = new Dictionary<string,string> ();
		public TextView tv_SendCodeStatusShow;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.SendSecurityCodeLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			// Create your application here
			InitView();
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

			//取得上一页面传递过来的值包括是什么类型发送验证码（找回密码\修改支付密码\修改密码）
			var bundle = Intent.Extras;
			sendType = bundle.GetString ("SendType");
			phoneNumber = bundle.GetString ("PhoneNumber");

			var tv_header_title = FindViewById<TextView> (Resource.Id.tv_header_title);
			tv_SendCodeStatusShow = FindViewById<TextView>(Resource.Id.tv_SendCodeStatusShow);
			edit_Phone = FindViewById<EditText> (Resource.Id.edit_Phone);
			edit_Phone.Text = phoneNumber;
			if (sendType == "FindPwd") {
				tv_header_title.Text = "找回登录密码";
				edit_Phone.Enabled = true;
				edit_Phone.Hint = "请输入手机号";
			} else if (sendType == "ModifyPwd") {
				tv_header_title.Text = "修改登录密码";
				edit_Phone.Enabled = false;
				SetPhoneNumberShow ();
			} else if (sendType == "ModifyPayPwd") {
				tv_header_title.Text = "设置支付密码";
				edit_Phone.Enabled = false;
				SetPhoneNumberShow ();
			}
			edit_SecurityCode = FindViewById<EditText> (Resource.Id.edit_SecurityCode);
			btn_Send = FindViewById<Button> (Resource.Id.btn_Send);
			btn_Next = FindViewById<Button> (Resource.Id.btn_Next);

			//初始化计时器,启动
			mc = new MyCount(this,60000,1000);
			//发送验证码
			btn_Send.Click += (sender, e) => 
			{
				tv_SendCodeStatusShow.Visibility = ViewStates.Invisible;
				btn_Send.Enabled = false;
				SendCode();
			};

			edit_SecurityCode.TextChanged+= (sender, e) => 
			{
				if(edit_SecurityCode.Text.Length>0)
				{
					btn_Next.Enabled = true;

				}
				else
				{
					btn_Next.Enabled =false;

				}
			};
			//下一步
			btn_Next.Click += (sender, e) => 
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
				var intent = new Intent(this,typeof(SetPasswordActivity));
				var nextbundle = new Bundle();
				nextbundle.PutString("SendType",sendType);
				if(sendType == "FindPwd")
				{
					nextbundle.PutString("PhoneNumber",phoneNumber);
				}
				intent.PutExtras(nextbundle);
				StartActivity(intent);
				if(sendType!="FindPwd")
					this.Finish();	
				ProgressDialogUtil.StopProgressDialog();

			};
			//拨打客服
			var tv_customPhone = FindViewById<TextView>(Resource.Id.tv_customPhone);
			var customPhoneNum = tv_customPhone.Text;
			tv_customPhone.Click += (sender, e) => 
			{
				Intent intent=new Intent(Intent.ActionCall,Android.Net.Uri.Parse ("tel:"+customPhoneNum));
				StartActivity(intent);
			};

		}
		private void SetPhoneNumberShow()
		{
			
			if (!string.IsNullOrEmpty (phoneNumber)) {
				var midleStr = phoneNumber.Substring (3, 4);
				var resultStr = phoneNumber.Replace (midleStr, "****");
				edit_Phone.Text = resultStr;
			}
			
		}
		/// <summary>
		/// Valids the input.
		/// </summary>
		/// <returns><c>true</c>, if input was valided, <c>false</c> otherwise.</returns>
		private bool ValidInput()
		{
			if(sendType == "FindPwd")
				phoneNumber = edit_Phone.Text;
			if (string.IsNullOrEmpty (phoneNumber) || !EldYoungUtil.IsMobileNo (phoneNumber)) {
				Toast.MakeText(this,"输入正确规范的手机号,且不能为空",ToastLength.Short).Show();
				return false;
			}
			return true;
		}

		/// <summary>
		/// 发送验证码
		/// </summary>
		private void SendCode()
		{
			if (!ValidInput ()) {
				
				return;
			}
			ProgressDialogUtil.StartProgressDialog(this,"正在发送验证码...");
			//检测网络连接
			if(!EldYoungUtil.IsConnected(this))
			{
				Toast.MakeText(this,"网络连接超时,请检测网络",ToastLength.Short).Show();
				btn_Send.Enabled = true;
				ProgressDialogUtil.StopProgressDialog();
				return;
			}

			var sendCodeParam = new SendCodeParam () {
				PhoneNumberOne = phoneNumber,Type = sendType
			};
			//使用restsharpApi方式

			SetRestRequestSendCodeParams (sendCodeParam);

			var restSharpRequestHelp = new RestSharpRequestHelp(sendCodeParam.Url,requestsendcodeParams);
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					//获取并解析返回resultJson获取安全码结果值
					var result = response.Content;
					var sendCodeJson = JsonConvert.DeserializeObject<SendCodeJson>(result);
					if(sendCodeJson.statuscode =="1")
					{
						RunOnUiThread(()=>{
							securityCode = sendCodeJson.data.ToString();
							ProgressDialogUtil.StopProgressDialog();
							Toast.MakeText(this,"验证码发送成功",ToastLength.Short).Show();
							tv_SendCodeStatusShow.Visibility = ViewStates.Visible;
							mc.Start();

						});
					}
					else
					{
						RunOnUiThread(()=>
							{
								Toast.MakeText(this,sendCodeJson.message,ToastLength.Short).Show();
								ProgressDialogUtil.StopProgressDialog();
								btn_Send.Enabled = true;
								tv_SendCodeStatusShow.Visibility = ViewStates.Invisible;
								return;
							});
					}
				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					RunOnUiThread(()=>
						{
							Toast.MakeText(this,"网络连接超时",ToastLength.Short).Show();
							ProgressDialogUtil.StopProgressDialog();
							btn_Send.Enabled = true;
							tv_SendCodeStatusShow.Visibility = ViewStates.Invisible;
							return;
						});
				}
				else
				{
					RunOnUiThread(()=>
						{
							Toast.MakeText(this,response.StatusDescription,ToastLength.Short).Show();
							ProgressDialogUtil.StopProgressDialog();
							btn_Send.Enabled = true;
							tv_SendCodeStatusShow.Visibility = ViewStates.Invisible;
							return;
						});
					
				}
			});
		}

		/// <summary>
		/// 设置发送短信参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestSendCodeParams(SendCodeParam sendcodeParam)
		{
			if (!requestsendcodeParams.ContainsKey ("key"))
				requestsendcodeParams.Add ("key", sendcodeParam.Key);
			else
				requestsendcodeParams ["key"] = sendcodeParam.Key;

			if (!requestsendcodeParams.ContainsKey ("eaction"))
				requestsendcodeParams.Add ("eaction", sendcodeParam.Eaction);
			else
				requestsendcodeParams ["eaction"] = sendcodeParam.Eaction;
			
			if (!requestsendcodeParams.ContainsKey ("ePhoneNumberOne"))
				requestsendcodeParams.Add ("ePhoneNumberOne", sendcodeParam.EphoneNumberOne);
			else
				requestsendcodeParams ["ePhoneNumberOne"] = sendcodeParam.EphoneNumberOne;
			if (!requestsendcodeParams.ContainsKey ("eType"))
				requestsendcodeParams.Add ("eType", sendcodeParam.Etype);
			else
				requestsendcodeParams ["eType"] = sendcodeParam.Etype;
			if (!requestsendcodeParams.ContainsKey ("md5"))
				requestsendcodeParams.Add ("md5", sendcodeParam.Md5);
			else
				requestsendcodeParams ["md5"] = sendcodeParam.Md5;



		}


		/// <summary>
		/// 发送验证码计时器
		/// </summary>
		public class MyCount:CountDownTimer
		{
			private SendSecurityCodeActivity Activity;
			public MyCount(SendSecurityCodeActivity _Activity,long millisInFuture, long countDownInterval):base(millisInFuture,countDownInterval)
			{
				Activity = _Activity;
			}
			public override void OnTick (long millisUntilFinished)
			{
				Activity.btn_Send.Text = (millisUntilFinished / 1000) + "秒后可重发";
			}
			public override void OnFinish ()
			{
				Activity.btn_Send.Text = "获取验证码";
				Activity.btn_Send.Enabled = true;
				Activity.tv_SendCodeStatusShow.Visibility = ViewStates.Invisible;
			}
		}


		public override void Finish ()
		{
			base.Finish ();
			mc.Cancel ();
		}

		protected override void OnStop ()
		{
			base.OnStop ();
			mc.Cancel ();
		}
		protected override void OnResume ()
		{
			base.OnResume ();
			btn_Send.Enabled = true;
		}
	}


}

