
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
using CommunityCenter.Param;
using CommunityCenter.Json;


namespace CommunityCenter.Activitys.My
{
	[Activity (Theme="@style/MyCustomTheme")]			
	public class PersonInfoIdCardNoActivity : Activity
	{
		private EditText edit_IdCardNo;
		private Button btn_Save;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.PersonInfoIdCardNoLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			InitView ();
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
			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "身份证号";
			//真实姓名
			edit_IdCardNo = FindViewById<EditText>(Resource.Id.edit_IdCardNo);
			edit_IdCardNo.Text = string.IsNullOrEmpty (Global.MyInfo.IDNumber) ? "" : Global.MyInfo.IDNumber;
			btn_Save = FindViewById<Button> (Resource.Id.btn_Save);
			btn_Save.Click += (sender, e) => 
			{
				Save();
			};

		}

		/// <summary>
		/// 保存
		/// </summary>
		private void Save()
		{
			var IdCardNo = edit_IdCardNo.Text;
			if (string.IsNullOrEmpty (IdCardNo)) {
				Toast.MakeText(this,"身份证不能为空,请输入身份证号",ToastLength.Short).Show();
				return ;
			}
			if (!EldYoungUtil.IsIdCardNo (IdCardNo)) {
				Toast.MakeText(this,"请输入规范的身份证号",ToastLength.Short).Show();
				return ;
			}
			ProgressDialogUtil.StartProgressDialog(this,"正在保存...");
			//检测网络连接
			if(!EldYoungUtil.IsConnected(this))
			{
				Toast.MakeText(this,"网络连接超时,请检测网络",ToastLength.Short).Show();	
				ProgressDialogUtil.StopProgressDialog();
				return;
			}

			//调用restapi注册,将用户名、密码信息写
			var updateMyInfoParam = new UpdateMyInfoParam () {
				Uid = Global.MyInfo.UId,ParamType = "IDNumber",ParamValue = IdCardNo
			};
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", updateMyInfoParam.Key);
			else
				requestParams ["key"] = updateMyInfoParam.Key;

			if (!requestParams.ContainsKey ("eUId"))
				requestParams.Add ("eUId", updateMyInfoParam.Euid);
			else
				requestParams ["eUId"] = updateMyInfoParam.Euid;

			if (!requestParams.ContainsKey ("eparamType"))
				requestParams.Add ("eparamType", updateMyInfoParam.EparamType);
			else
				requestParams ["eparamType"] = updateMyInfoParam.EparamType;

			if (!requestParams.ContainsKey ("eparamValue"))
				requestParams.Add ("eparamValue", updateMyInfoParam.EparamValue);
			else
				requestParams ["eparamValue"] = updateMyInfoParam.EparamValue;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", updateMyInfoParam.Md5);
			else
				requestParams ["md5"] = updateMyInfoParam.Md5;	
			var restSharpRequestHelp = new RestSharpRequestHelp(updateMyInfoParam.Url,requestParams);
			restSharpRequestHelp.ExcuteAsync((RestSharp.IRestResponse response) => 
				{
					if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						//获取并解析返回resultJson获取安全码结果值
						var result = response.Content;
						var updateMyInfoJson = JsonConvert.DeserializeObject<UpdateMyInfoJson>(result);
						if(updateMyInfoJson.statuscode == "1")
						{
							RunOnUiThread(()=>
								{
									Toast.MakeText(this,"保存成功",ToastLength.Short).Show();
									Global.MyInfo.IDNumber = IdCardNo;
									ProgressDialogUtil.StopProgressDialog();
									this.Finish();
									OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
								});
						}
						else
						{
							RunOnUiThread(()=>
								{
									Toast.MakeText(this,updateMyInfoJson.message,ToastLength.Short).Show();
									ProgressDialogUtil.StopProgressDialog();
									return;
								});
						}
					}
					else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut){
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
	}
}

