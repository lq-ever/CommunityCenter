
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;

using Newtonsoft.Json;

using CommunityCenter;
using CommunityCenter.Common;
using CommunityCenter.Param;
using CommunityCenter.Json;


namespace CommunityCenter.Fragments.Advice
{
	public class WriteAdviceFragment : BaseFragment,Android.Widget.RadioGroup.IOnCheckedChangeListener
	{
		
		private RadioGroup radio_advice_Group;
		private RadioButton rbtn_zixun, rbtn_jianyi, rbtn_tousu, rbtn_other;
		private EditText edit_advice_title, edit_advice_content;
		private Button btn_Publish;
		private string _adviceType = ((int)AdviceType.Consult).ToString();
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);

			base.OnCreateView (inflater, container, savedInstanceState);
			var WriteAdviceView = inflater.Inflate (Resource.Layout.WriteAdviceLayout,container,false);
			return WriteAdviceView;
		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			//radiogroup
			radio_advice_Group = View.FindViewById<RadioGroup> (Resource.Id.radio_advice_Group);
			radio_advice_Group.SetOnCheckedChangeListener (this);
			//radiobutton
			rbtn_zixun = View.FindViewById<RadioButton> (Resource.Id.rbtn_zixun);
			rbtn_zixun.Tag = ((int)AdviceType.Consult).ToString();
			//默认咨询选中
			rbtn_zixun.Checked = true;
			rbtn_jianyi = View.FindViewById<RadioButton> (Resource.Id.rbtn_jianyi);
			rbtn_jianyi.Tag =((int)AdviceType.Suggest).ToString ();
			rbtn_tousu = View.FindViewById<RadioButton> (Resource.Id.rbtn_tousu);
			rbtn_tousu.Tag = ((int)AdviceType.Complain).ToString ();
			rbtn_other = View.FindViewById<RadioButton> (Resource.Id.rbtn_other);
			rbtn_other.Tag = ((int)AdviceType.Other).ToString();

			edit_advice_title = View.FindViewById<EditText> (Resource.Id.edit_advice_title);
			edit_advice_content = View.FindViewById<EditText> (Resource.Id.edit_advice_content);
			//发表按钮
			btn_Publish = View.FindViewById<Button> (Resource.Id.btn_Publish);
			btn_Publish.Click += (sender, e) => 
			{
				PublishAdvice();
			};

			//初始化view完成
			IsPrepared = true;
			LasyloadData ();
		}

		public override void LasyloadData ()
		{
			if (!IsPrepared || !IsVisible)
				return;
		}
		/// <summary>
		/// radiogroup的选择切换事件
		/// </summary>
		/// <param name="group">Group.</param>
		/// <param name="checkedId">Checked identifier.</param>
		public void OnCheckedChanged (RadioGroup group, int checkedId)
		{
			_adviceType = View.FindViewById<RadioButton> (checkedId).Tag.ToString();
		}

		private void PublishAdvice()
		{
			var adviceTitle = edit_advice_title.Text;
			if (string.IsNullOrEmpty (adviceTitle)) {
				Toast.MakeText(Activity,"留言标题不能为空,请输入标题",ToastLength.Short).Show();
				return ;
			}
			var adviceContent = edit_advice_content.Text;
			if (string.IsNullOrEmpty (adviceContent)) {
				Toast.MakeText(Activity,"留言内容不能为空,请输入留言内容",ToastLength.Short).Show();
				return ;
			}

			ProgressDialogUtil.StartProgressDialog(Activity,"正在保存...");
			//检测网络连接
			if(!EldYoungUtil.IsConnected(Activity))
			{
				Toast.MakeText(Activity,"网络连接超时,请检测网络",ToastLength.Short).Show();	
				ProgressDialogUtil.StopProgressDialog();
				return;
			}

			//调用restapi注册,将用户名、密码信息写
			var adviceWriteParam = new AdviceWriteParam () {
				UId = Global.Guid,AdviceType = _adviceType,AdviceTitle = adviceTitle,AdviceContent = adviceContent
			};
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", adviceWriteParam.Key);
			else
				requestParams ["key"] = adviceWriteParam.Key;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", adviceWriteParam.Eaction);
			else
				requestParams ["eaction"] = adviceWriteParam.Eaction;

			if (!requestParams.ContainsKey ("eUId"))
				requestParams.Add ("eUId", adviceWriteParam.Euid);
			else
				requestParams ["eUId"] = adviceWriteParam.Euid;

			if (!requestParams.ContainsKey ("eAdviceType"))
				requestParams.Add ("eAdviceType", adviceWriteParam.EadviceType);
			else
				requestParams ["eAdviceType"] = adviceWriteParam.EadviceType;

			if (!requestParams.ContainsKey ("ePlatformType"))
				requestParams.Add ("ePlatformType", adviceWriteParam.EplatformType);
			else
				requestParams ["ePlatformType"] = adviceWriteParam.EplatformType;

			if (!requestParams.ContainsKey ("eAdviceTitle"))
				requestParams.Add ("eAdviceTitle", adviceWriteParam.EadviceTitle);
			else
				requestParams ["eAdviceTitle"] = adviceWriteParam.EadviceTitle;

			if (!requestParams.ContainsKey ("eAdviceContent"))
				requestParams.Add ("eAdviceContent", adviceWriteParam.EadviceContent);
			else
				requestParams ["eAdviceContent"] = adviceWriteParam.EadviceContent;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", adviceWriteParam.Md5);
			else
				requestParams ["md5"] = adviceWriteParam.Md5;	

			var restSharpRequestHelp = new RestSharpRequestHelp(adviceWriteParam.Url,requestParams);
			restSharpRequestHelp.ExcuteAsync((RestSharp.IRestResponse response) => 
				{
					if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						//获取并解析返回resultJson获取安全码结果值
						var result = response.Content;
						var adviceWriteJson = JsonConvert.DeserializeObject<AdviceWriteJson>(result);
						if(adviceWriteJson.statuscode == "1")
						{
							Activity.RunOnUiThread(()=>
								{
									Toast.MakeText(Activity,"保存成功",ToastLength.Short).Show();
									ProgressDialogUtil.StopProgressDialog();

								});
						}
						else
						{
							Activity.RunOnUiThread(()=>
								{
									Toast.MakeText(Activity,adviceWriteJson.message,ToastLength.Short).Show();
									ProgressDialogUtil.StopProgressDialog();
									return;
								});
						}
					}
					else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut){
						Activity.RunOnUiThread(()=>
							{
								Toast.MakeText(Activity,"网络连接超时，请重试",ToastLength.Short).Show();
								ProgressDialogUtil.StopProgressDialog();
								return;
							});
					}
					else
					{
						Activity.RunOnUiThread(()=>
							{
								Toast.MakeText(Activity,response.StatusDescription,ToastLength.Short).Show();
								ProgressDialogUtil.StopProgressDialog();
								return;
							});
					}

				});

		}
	}
}

