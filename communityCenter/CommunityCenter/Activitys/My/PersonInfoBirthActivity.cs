
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
	public class PersonInfoBirthActivity : Activity
	{
		private EditText edit_birth;
		private Button btn_Save;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.PersonInfoBirthLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			InitView ();
		}
		private void InitView()
		{
			//设置标题栏
			var btn_headerBack = FindViewById<Button> (Resource.Id.btn_header_back);

			btn_headerBack.Click += (sender, e) => 
			{
				this.Finish();
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "生日";
			edit_birth = FindViewById<EditText>(Resource.Id.edit_birth);
			edit_birth.Click += (sender, e) => 
			{
				var datepickdialog = new DatePickDialogUtil(this,edit_birth.Text);
				datepickdialog.DatePickDialogShow(edit_birth);

			};
			edit_birth.Text = !string.IsNullOrEmpty (Global.MyInfo.Age) ?Convert.ToDateTime(Global.MyInfo.Age).ToString("yyyy-MM-dd") :"";
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
			var birth = edit_birth.Text;
			if (string.IsNullOrEmpty (birth)) {
				Toast.MakeText(this,"生日不能为空,请选择生日日期",ToastLength.Short).Show();
				return ;
			}
			if (Convert.ToDateTime(birth) >= Convert.ToDateTime(DateTime.Now.ToString ("yyyy-MM-dd"))) {
				Toast.MakeText (this, "生日应小于当前日期", ToastLength.Short).Show ();
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
				Uid = Global.MyInfo.UId,ParamType = "Age",ParamValue = birth
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
									Global.MyInfo.Age = birth;
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

