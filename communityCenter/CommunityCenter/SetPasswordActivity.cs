
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
using CommunityCenter.Param;
using CommunityCenter.Common;
using CommunityCenter.Json;


namespace CommunityCenter
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class SetPasswordActivity : Activity
	{
		private string sendType;
		private string phoneNumber;
		private EditText edit_Pwd, edit_ConfirmPwd;

		private Button btn_Submit;

		private string passWord, confirmPassWord;
		private Dictionary<string,string> requestsubmitParams = new Dictionary<string,string> ();
		private ImageView img_eye_Pwd, img_eye_ConfirmPwd;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.SetPasswordLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			// Create your application here
			InitView();
		}

		private void InitView()
		{
			
			var bundle = Intent.Extras;
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
			tv_desc.Text = "设置密码";

			edit_Pwd = FindViewById<EditText> (Resource.Id.edit_Pwd);
			edit_ConfirmPwd = FindViewById<EditText> (Resource.Id.edit_ConfirmPwd);
			btn_Submit = FindViewById<Button> (Resource.Id.btn_Submit);

			//取得上一页面传递过来的值包括是什么类型（找回密码\修改支付密码\修改密码）
			sendType = bundle.GetString ("SendType");
			if (sendType == "FindPwd") {
				edit_Pwd.Hint = "输入新登录密码";
				edit_ConfirmPwd.Hint = "再次输入新登录密码";
				phoneNumber = bundle.GetString ("PhoneNumber");//将手机号作为guid
			} else if (sendType == "ModifyPwd") {
				edit_Pwd.Hint = "输入新登录密码";
				edit_ConfirmPwd.Hint = "再次输入新登录密码";
			} else if (sendType == "ModifyPayPwd") {
				edit_Pwd.Hint = "输入新支付密码";
				edit_ConfirmPwd.Hint = "再次输入新支付密码";
			}
			btn_Submit.Click += (sender, e) => 
			{
				Submit();
			};

			//密码眼睛切换
			img_eye_Pwd = FindViewById<ImageView> (Resource.Id.img_eye_Pwd);
			img_eye_ConfirmPwd = FindViewById<ImageView> (Resource.Id.img_eye_ConfirmPwd);

			img_eye_Pwd.Click += (sender, e) => 
			{
				if(edit_Pwd.InputType == (Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationPassword))
				{
					edit_Pwd.InputType = Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationVisiblePassword;
					img_eye_Pwd.SetImageResource(Resource.Drawable.ic_register_eye_selected);
				}
				else if(edit_Pwd.InputType == (Android.Text.InputTypes.ClassText| Android.Text.InputTypes.TextVariationVisiblePassword))
				{
					edit_Pwd.InputType = Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationPassword;
					img_eye_Pwd.SetImageResource(Resource.Drawable.ic_register_eye_normal);
				}

			};

			img_eye_ConfirmPwd.Click += (sender, e) => 
			{
				if(edit_ConfirmPwd.InputType == (Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationPassword))
				{
					edit_ConfirmPwd.InputType = Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationVisiblePassword;
					img_eye_ConfirmPwd.SetImageResource(Resource.Drawable.ic_register_eye_selected);
				}
				else if(edit_ConfirmPwd.InputType == (Android.Text.InputTypes.ClassText| Android.Text.InputTypes.TextVariationVisiblePassword))
				{
					edit_ConfirmPwd.InputType = Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationPassword;
					img_eye_ConfirmPwd.SetImageResource(Resource.Drawable.ic_register_eye_normal);
				}

			};

		}
		/// <summary>
		/// Submit this instance.
		/// </summary>
		private void Submit()
		{
			passWord = edit_Pwd.Text;
			if (string.IsNullOrEmpty (passWord)) {
				Toast.MakeText(this,"密码不能为空,请输入密码",ToastLength.Short).Show();
				return ;
			}
			confirmPassWord = edit_ConfirmPwd.Text;
			if (string.IsNullOrEmpty (confirmPassWord)) {
				Toast.MakeText(this,"确认密码不能为空,请输入确认密码",ToastLength.Short).Show();
				return ;
			}
			if (passWord != confirmPassWord) {
				Toast.MakeText(this,"输入两次密码不一致,请检查",ToastLength.Short).Show();
				return ;
			}
			if (!EldYoungUtil.IsPassWord (passWord)) {
				Toast.MakeText (this, "请输入正确规范用户名6-20位，建议由字母、数字和符号两种以上组成", ToastLength.Short).Show ();
				return;
			}
			ProgressDialogUtil.StartProgressDialog(this,"正在提交...");
			//检测网络连接
			if(!EldYoungUtil.IsConnected(this))
			{
				Toast.MakeText(this,"网络连接超时,请检测网路",ToastLength.Short).Show();
				ProgressDialogUtil.StopProgressDialog();
				return;
			}
			//调用restapi注册,将用户名、密码信息写
			var modipwdParam = new ModiyPasswordParam () {
				Type = sendType,Password = passWord
			};
			if (sendType == "FindPwd")
				modipwdParam.UId = phoneNumber;
			else
				modipwdParam.UId = Global.Guid;

			//初始化参数
			SetRestRequestParams (modipwdParam);
			var restSharpRequestHelp = new RestSharpRequestHelp(modipwdParam.Url,requestsubmitParams);
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					
					//获取并解析返回resultJson获取安全码结果值
	 				var result = response.Content;
					var setpwdJson = JsonConvert.DeserializeObject<SetPasswordJson>(result);
					if(setpwdJson.statuscode =="1")
					{
						RunOnUiThread(()=>{

							Toast.MakeText(this,setpwdJson.message,ToastLength.Short).Show();
							ProgressDialogUtil.StopProgressDialog();
							var intent = new Intent(this,typeof(LoginActivity));
							intent.SetFlags(ActivityFlags.ClearTask|ActivityFlags.NewTask);
							StartActivity(intent);			

							this.Finish();

						});
					}
					else
					{
						RunOnUiThread(()=>
							{
								Toast.MakeText(this,setpwdJson.message,ToastLength.Short).Show();
								ProgressDialogUtil.StopProgressDialog();
								return;
							});
					}


				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					RunOnUiThread(()=>
						{
							Toast.MakeText(this,"网络连接超时，请重试",ToastLength.Short).Show();
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
		private void SetRestRequestParams(ModiyPasswordParam modipwdParam)
		{
			if (!requestsubmitParams.ContainsKey ("key"))
				requestsubmitParams.Add ("key", modipwdParam.Key);
			else
				requestsubmitParams ["key"] = modipwdParam.Key;

			if (!requestsubmitParams.ContainsKey ("eaction"))
				requestsubmitParams.Add ("eaction", modipwdParam.Eaction);
			else
				requestsubmitParams ["eaction"] = modipwdParam.Eaction;

			if (!requestsubmitParams.ContainsKey ("eUId")) 
				requestsubmitParams.Add ("eUId", modipwdParam.Euid);	
			else
				requestsubmitParams ["eUId"] = modipwdParam.Euid;

			if (!requestsubmitParams.ContainsKey ("ePassword")) 
				requestsubmitParams.Add ("ePassword", modipwdParam.Epassword);	
			else
				requestsubmitParams ["ePassword"] = modipwdParam.Epassword;
			

			if (!requestsubmitParams.ContainsKey ("eType"))
				requestsubmitParams.Add ("eType", modipwdParam.Etype);
			else
				requestsubmitParams ["eType"] = modipwdParam.Etype;

			if (!requestsubmitParams.ContainsKey ("md5"))
				requestsubmitParams.Add ("md5", modipwdParam.Md5);
			else
				requestsubmitParams ["md5"] = modipwdParam.Md5;

		}

	}
}

