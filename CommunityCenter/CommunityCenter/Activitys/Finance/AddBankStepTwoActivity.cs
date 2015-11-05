
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
using CommunityCenter.Common;
using CommunityCenter.Param;
using Newtonsoft.Json;
using CommunityCenter.Json;

namespace CommunityCenter
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class AddBankStepTwoActivity : Activity
	{
		private EditText edit_cardOwnerName,edit_IdCardNo,edit_bankopenloc,edit_bankbranch,edit_bankCardNo,edit_prePhoneNo,edit_Code;
		private TextView tv_SendCodeStatusShow;
		private CheckBox cb_defaut_bank;
		private Button btn_Send,btn_Add;
		private MyCount mc;
		private string phoneNumber;
		private Dictionary<string,string> requestsendcodeParams = new Dictionary<string,string> ();
		private string securityCode;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.AddBankStepTwoLayout);
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
			var tv_back = FindViewById<TextView> (Resource.Id.tv_back);
			tv_back.Text = "返回";
			var tv_desc = FindViewById<TextView> (Resource.Id.tv_desc);
			tv_desc.Text = "银行卡信息";

			edit_cardOwnerName = FindViewById<EditText> (Resource.Id.edit_cardOwnerName);
			edit_IdCardNo = FindViewById<EditText> (Resource.Id.edit_IdCardNo);
			edit_bankopenloc = FindViewById<EditText> (Resource.Id.edit_bankopenloc);
			edit_bankbranch = FindViewById<EditText> (Resource.Id.edit_bankbranch);
			edit_bankCardNo = FindViewById<EditText> (Resource.Id.edit_bankCardNo);
			edit_prePhoneNo = FindViewById<EditText> (Resource.Id.edit_prePhoneNo);
			edit_Code = FindViewById<EditText> (Resource.Id.edit_Code);

			tv_SendCodeStatusShow = FindViewById<TextView> (Resource.Id.tv_SendCodeStatusShow);

			cb_defaut_bank = FindViewById<CheckBox> (Resource.Id.cb_defaut_bank);
			btn_Send = FindViewById<Button> (Resource.Id.btn_Send);
			btn_Add = FindViewById<Button> (Resource.Id.btn_Add);

			//安全码验证
			edit_Code.TextChanged += (sender, e) => 
			{
				if(edit_Code.Text.Length>0)
					btn_Add.Enabled = true;
				else
					btn_Add.Enabled =false;
			};
			//初始化计时器,启动
			mc = new MyCount(this,60000,1000);
			//发送验证码
			btn_Send.Click += (sender, e) => 
			{
				tv_SendCodeStatusShow.Visibility = ViewStates.Invisible;
				btn_Send.Enabled = false;
				SendCode();
			};

			//添加银行卡信息
			btn_Add.Click += (sender, e) => 
			{
				AddBank();
			};
		}

		/// <summary>
		/// 添加银行卡信息
		/// </summary>
		private void AddBank()
		{
			//todo:调用web服务添加银行卡信息
			Toast.MakeText(this,"添加成功",ToastLength.Short).Show();
			var intent = new Intent (this, typeof(BankCardsActivity));
			intent.SetFlags (ActivityFlags.ClearTop);
			StartActivity (intent);
			OverridePendingTransition (Android.Resource.Animation.SlideInLeft, Android.Resource.Animation.SlideOutRight);
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
				PhoneNumberOne = phoneNumber,Type = ""
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
		/// Valids the input.
		/// </summary>
		/// <returns><c>true</c>, if input was valided, <c>false</c> otherwise.</returns>
		private bool ValidInput()
		{
		    phoneNumber = edit_prePhoneNo.Text;
			if (string.IsNullOrEmpty (phoneNumber) || !EldYoungUtil.IsMobileNo (phoneNumber)) {
				Toast.MakeText(this,"输入正确规范的手机号,且不能为空",ToastLength.Short).Show();
				return false;
			}
			return true;
		}
		/// <summary>
		/// 发送验证码计时器
		/// </summary>
		public class MyCount:CountDownTimer
		{
			private AddBankStepTwoActivity Activity;
			public MyCount(AddBankStepTwoActivity _Activity,long millisInFuture, long countDownInterval):base(millisInFuture,countDownInterval)
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

