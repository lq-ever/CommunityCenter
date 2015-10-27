
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
	public class RegisterStepOneActivity : Activity,View.IOnClickListener
	{
		private EditText edit_Phone;
		private Button btn_RegisterNext;
		private CheckBox cb_Agree;
		private EditText edit_RegisterName;
		private EditText edit_PassWord;
		private EditText edit_ConfirmPassWord;
	//	private Dialog registerDialog;

		private string phoneNumber;
		private string nickName;
		private string passWord;
		private string confirmPassWord;
		private ConfirmphonePopWindow confirmPopWindow;

		private ImageView img_eye_ReisterPwd, img_eye_ReisterConfirmPwd;

		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.RegisterStepOneLayout);


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

				
			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "注册";

			edit_Phone = FindViewById<EditText> (Resource.Id.edit_Phone);
			btn_RegisterNext = FindViewById<Button> (Resource.Id.btn_RegistNext);
			cb_Agree = FindViewById<CheckBox> (Resource.Id.cb_Agree);
			edit_RegisterName = FindViewById<EditText> (Resource.Id.edit_ReisterNickName);
			edit_PassWord = FindViewById<EditText> (Resource.Id.edit_ReisterPwd);
			edit_ConfirmPassWord = FindViewById<EditText> (Resource.Id.edit_ReisterConfirmPwd);
			//密码眼睛切换
			img_eye_ReisterPwd = FindViewById<ImageView>(Resource.Id.img_eye_ReisterPwd);
			img_eye_ReisterConfirmPwd = FindViewById<ImageView> (Resource.Id.img_eye_ReisterConfirmPwd);

			img_eye_ReisterPwd.Click += (sender, e) => 
			{
				if(edit_PassWord.InputType == (Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationPassword))
				{
					edit_PassWord.InputType = Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationVisiblePassword;
					img_eye_ReisterPwd.SetImageResource(Resource.Drawable.ic_register_eye_selected);
				}
				else if(edit_PassWord.InputType == (Android.Text.InputTypes.ClassText| Android.Text.InputTypes.TextVariationVisiblePassword))
				{
					edit_PassWord.InputType = Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationPassword;
					img_eye_ReisterPwd.SetImageResource(Resource.Drawable.ic_register_eye_normal);
				}

			};

			img_eye_ReisterConfirmPwd.Click += (sender, e) => 
			{
				if(edit_ConfirmPassWord.InputType == (Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationPassword))
				{
					edit_ConfirmPassWord.InputType = Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationVisiblePassword;
					img_eye_ReisterConfirmPwd.SetImageResource(Resource.Drawable.ic_register_eye_selected);
				}
				else if(edit_ConfirmPassWord.InputType == (Android.Text.InputTypes.ClassText| Android.Text.InputTypes.TextVariationVisiblePassword))
				{
					edit_ConfirmPassWord.InputType = Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationPassword;
					img_eye_ReisterConfirmPwd.SetImageResource(Resource.Drawable.ic_register_eye_normal);
				}

			};



			//注册协议
			var tv_linkServiceAgree = FindViewById<TextView> (Resource.Id.tv_linkServiceAgree);
			tv_linkServiceAgree.Click += (sender, e) => 
			{
				StartActivity(typeof(ServiceAgreeActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

			//同意协议切换事件
			cb_Agree.CheckedChange += (sender, e) => 
			{
				if(cb_Agree.Checked)
					btn_RegisterNext.Enabled = true;
				else
					btn_RegisterNext.Enabled = false;
			};

			//点击下一步按钮事件
			btn_RegisterNext.Click+= (object sender, EventArgs e) => 
			{
				initInput();
				if(ValidInput())
				{
					if(confirmPopWindow==null)
						confirmPopWindow = new ConfirmphonePopWindow(this,phoneNumber);
					confirmPopWindow.ShowPopWindow(FindViewById<LinearLayout>(Resource.Id.ll_register));
				}

			};

		}

		public void OnClick (View v)
		{
			confirmPopWindow.Dismiss ();
			SendSMS (phoneNumber);
		}
		/// <summary>
		/// Valids the input.
		/// </summary>
		/// <returns><c>true</c>, if input was valided, <c>false</c> otherwise.</returns>
		private bool ValidInput()
		{
			nickName = edit_RegisterName.Text;
			if (string.IsNullOrEmpty (nickName)) {
				Toast.MakeText(this,"用户名不能为空,请先填写用户名",ToastLength.Short).Show();
				return false;
			}
			if (!EldYoungUtil.IsValidUserName (nickName)) {
				Toast.MakeText(this,"请输入规范的用户名,建议由中英文、数字、下划线组成",ToastLength.Short).Show();
				return false;
			}
			passWord = edit_PassWord.Text;
			if (string.IsNullOrEmpty (passWord)) {
				Toast.MakeText(this,"密码不能为空,请输入密码",ToastLength.Short).Show();
				return false;
			}
			if (!EldYoungUtil.IsPassWord (passWord)) {
				Toast.MakeText(this,"请输入规范的密码,建议由字母、数字和符号两种以上组成",ToastLength.Short).Show();
				return false;
			}
			confirmPassWord = edit_ConfirmPassWord.Text;
			if (string.IsNullOrEmpty (confirmPassWord)) {
				Toast.MakeText(this,"确认密码不能为空,请输入确认密码",ToastLength.Short).Show();
				return false;
			}
			if (passWord != confirmPassWord) {
				Toast.MakeText(this,"输入两次密码不一致,请检查",ToastLength.Short).Show();
				return false;
			}

			phoneNumber = edit_Phone.Text;
			if (string.IsNullOrEmpty (phoneNumber) || !EldYoungUtil.IsMobileNo (phoneNumber)) {
				Toast.MakeText(this,"输入正确规范的手机号,且不能为空",ToastLength.Short).Show();
				return false;
			}
			return true;	
		}
		private void initInput()
		{
			phoneNumber = string.Empty;
			nickName = string.Empty;
			passWord = string.Empty;
			confirmPassWord = string.Empty;
		}

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
				PhoneNumber = phoneNumber,NickName = nickName,PassWord = passWord
			};
					
			//使用restsharpApi方式

			SetRestRequestParams (smsInfoParam);

			var restSharpRequestHelp = new RestSharpRequestHelp(smsInfoParam.Url,requestParams);

			restSharpRequestHelp.ExcuteAsync ((resoponse) => {

				if(resoponse.ResponseStatus == ResponseStatus.Completed && resoponse.StatusCode == System.Net.HttpStatusCode.OK)
				{
					//获取并解析返回resultJson获取安全码结果值
					var result= resoponse.Content;
					var smsJson = JsonConvert.DeserializeObject<SmsJson>(result);
					if(smsJson.statuscode =="1")
					{
						RunOnUiThread(()=>{
							Intent intent = new Intent(this,typeof(RegisterResultActivity));
							var bundle = new Bundle();
							bundle.PutString("phoneNum",phoneNumber);
							bundle.PutString("nickName",nickName);
							bundle.PutString("passWord",passWord);
							bundle.PutString("securityCode",smsJson.data.ToString());
							intent.PutExtras(bundle);
							StartActivity(intent);
						});
					}
					else
					{
						RunOnUiThread(()=>
							{
								Toast.MakeText(this,smsJson.message,ToastLength.Short).Show();
							});
					}	
				}
				else if(resoponse.ResponseStatus == ResponseStatus.TimedOut)
				{
					RunOnUiThread(()=>
						{
							Toast.MakeText(this,"网络连接超时",ToastLength.Short).Show();
						});
				}
				else
				{
					RunOnUiThread(()=>
						{
							Toast.MakeText(this,resoponse.StatusDescription,ToastLength.Short).Show();
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
		/// 设置参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestParams(SmsInfoParam smsInfoParam)
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", smsInfoParam.Key);
			else
				requestParams ["key"] = smsInfoParam.Key;
			
			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", smsInfoParam.Eaction);
			else
				requestParams ["eaction"] = smsInfoParam.Eaction;
			if (!requestParams.ContainsKey ("ePhoneNumber"))
				requestParams.Add ("ePhoneNumber", smsInfoParam.EphoneNumber);
			else
				requestParams ["ePhoneNumber"] = smsInfoParam.EphoneNumber;
			if (!requestParams.ContainsKey ("ePassword"))
				requestParams.Add ("ePassword", smsInfoParam.EpassWord);
			else
				requestParams ["ePassword"] = smsInfoParam.EpassWord;
			if (!requestParams.ContainsKey ("eNickName"))
				requestParams.Add ("eNickName", smsInfoParam.EnickName);
			else
				requestParams ["eNickName"] = smsInfoParam.EnickName;
			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", smsInfoParam.Md5);
			else
				requestParams ["md5"] = smsInfoParam.Md5;
			
		}
	}
}

