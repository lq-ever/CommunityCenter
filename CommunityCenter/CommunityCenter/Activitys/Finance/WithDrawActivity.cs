
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
using Newtonsoft.Json;
using CommunityCenter.Param;
using CommunityCenter.Json;
using CommunityCenter.Activitys.Finance;

namespace CommunityCenter
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class WithDrawActivity : Activity
	{
		private TextView tv_accountBalance, tv_with_drawbank,tv_SendCodeStatusShow;
		private EditText edit_withdrawmoney, edit_dealPwd, edit_securityCode;
		private RelativeLayout rl_withdraw_bank;
		private Button btn_Send, btn_Add;
		private RadioButton rbtn_moreday,rbtn_lesshour;
		private MyCount mc;
		private string phoneNumber;
		private Dictionary<string,string> requestsendcodeParams = new Dictionary<string,string> ();
		private string securityCode;

		private string choosebankTypeId;
		private string choosebankCardNo;
		private string choosebankDesc;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.WithDrawLayout);
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
			tv_desc.Text = "提现";

			tv_accountBalance = FindViewById<TextView> (Resource.Id.tv_accountBalance);
			tv_with_drawbank = FindViewById<TextView> (Resource.Id.tv_with_drawbank);
			tv_SendCodeStatusShow = FindViewById<TextView> (Resource.Id.tv_SendCodeStatusShow);

			edit_dealPwd = FindViewById<EditText> (Resource.Id.edit_dealPwd);
			edit_securityCode = FindViewById<EditText> (Resource.Id.edit_securityCode);
			edit_withdrawmoney = FindViewById<EditText> (Resource.Id.edit_withdrawmoney);

			btn_Add = FindViewById<Button> (Resource.Id.btn_Add);
			btn_Send = FindViewById<Button> (Resource.Id.btn_Send);
			rbtn_moreday = FindViewById<RadioButton> (Resource.Id.rbtn_moreday);
			rbtn_lesshour = FindViewById<RadioButton> (Resource.Id.rbtn_lesshour);
			rl_withdraw_bank = FindViewById<RelativeLayout> (Resource.Id.rl_withdraw_bank);
			//选择提现的银行卡
			rl_withdraw_bank.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(ChooseWithDrawBankActivity));
				var requestCode = 0;  
				StartActivityForResult(intent,requestCode);
			};

		    //todo :赋值可用资金和提现银行卡

			//初始化计时器,启动
			mc = new MyCount(this,60000,1000);
			//发送验证码
			btn_Send.Click += (sender, e) => 
			{
				tv_SendCodeStatusShow.Visibility = ViewStates.Invisible;
				btn_Send.Enabled = false;
				SendCode();
			};


			//提现申请
			btn_Add.Click += (sender, e) => 
			{
				WithDraw();
			};

			//安全码验证
			edit_securityCode.TextChanged += (sender, e) => 
			{
				if(edit_securityCode.Text.Length>0)
					btn_Add.Enabled = true;
				else
					btn_Add.Enabled =false;
			};

		}

		/// <summary>
		/// 发送验证码
		/// </summary>
		private void SendCode()
		{

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

		protected override void OnActivityResult (int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult (requestCode, resultCode, data);
			if (resultCode == Result.Ok) {
				//赋值
				choosebankTypeId = data.GetStringExtra ("choosebankTypeId");
				choosebankCardNo = data.GetStringExtra ("choosebankCardNo");
				choosebankDesc = data.GetStringExtra ("choosebankDesc");
				tv_with_drawbank.Text = choosebankDesc + choosebankCardNo.Substring (choosebankCardNo.Length - 4);
			}
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
		/// 提现申请
		/// </summary>
		private void WithDraw()
		{
			
			Toast.MakeText (this, "提现申请成功", ToastLength.Short).Show ();
		}

		/// <summary>
		/// 发送验证码计时器
		/// </summary>
		public class MyCount:CountDownTimer
		{
			private WithDrawActivity Activity;
			public MyCount(WithDrawActivity _Activity,long millisInFuture, long countDownInterval):base(millisInFuture,countDownInterval)
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

