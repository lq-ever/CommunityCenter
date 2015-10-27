using System;
using Android.Widget;

using Android.App;
using System.Collections.Generic;

using Android.Views;
using Newtonsoft.Json;

using Com.Nostra13.Universalimageloader.Core;
using Com.Nostra13.Universalimageloader.Core.Listener;

using Android.Graphics;
using Com.Nostra13.Universalimageloader.Core.Display;
using CommunityCenter.Model.ServerType.Admin;
using CommunityCenter.Common;
using CommunityCenter.Param;
using CommunityCenter.Json;


namespace CommunityCenter.Adapter
{
	public class GetApplyInfoListAadapter:ArrayAdapter<GetApplyInfoListItem>
	{
		private Activity activity;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private ExamineBundGuardianParam examinebundGuardianParam = new ExamineBundGuardianParam();//请求参数对象
		private RestSharpRequestHelp restSharpRequestHelp;

		public GetApplyInfoListAadapter (Activity _activity):base(_activity,0)
		{
			activity = _activity;
		}

		public override Android.Views.View GetView ( int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			GetApplyInfoListItemView _getApplyInfoItemView = null;
			var item = GetItem (position);
			if (convertView == null) {

				convertView = LayoutInflater.From (Context).Inflate (Resource.Layout.getApplyInfoListItemView, null);
				_getApplyInfoItemView = new GetApplyInfoListItemView ();
				_getApplyInfoItemView.guardian_img_head = convertView.FindViewById<ImageView> (Resource.Id.guardian_img_head);
				_getApplyInfoItemView.tv_Name = convertView.FindViewById<TextView> (Resource.Id.tv_Name);
				_getApplyInfoItemView.tv_PhoneNum = convertView.FindViewById<TextView> (Resource.Id.tv_phoneNumber);
				_getApplyInfoItemView.img_Sex = convertView.FindViewById<ImageView> (Resource.Id.img_sex);
			
				_getApplyInfoItemView.tv_GuardianStatus = convertView.FindViewById<TextView> (Resource.Id.tv_GuardianStatus);
				_getApplyInfoItemView.tv_applyContent = convertView.FindViewById<TextView> (Resource.Id.tv_applyContent);
				_getApplyInfoItemView.ll_action = convertView.FindViewById<LinearLayout> (Resource.Id.ll_action);
				_getApplyInfoItemView.btn_action_agree = convertView.FindViewById<Button> (Resource.Id.btn_action_agree);
				_getApplyInfoItemView.btn_action_disagree = convertView.FindViewById<Button> (Resource.Id.btn_action_disagree);

				convertView.SetTag (Resource.Id.getApplyInfoListItemView, (Java.Lang.Object)_getApplyInfoItemView);

			} else
				_getApplyInfoItemView = (GetApplyInfoListItemView)convertView.GetTag (Resource.Id.getApplyInfoListItemView);

			_getApplyInfoItemView.tv_Name.Text = item.TrueName;
			_getApplyInfoItemView.tv_PhoneNum.Text = item.PhoneNumberOne;
			_getApplyInfoItemView.tv_applyContent.Text = item.Remark;
			var imgSexId = (item.Sex == Sex.Male) ? Resource.Drawable.ic_sex_man : Resource.Drawable.ic_sex_woman;
			_getApplyInfoItemView.img_Sex.SetImageResource (imgSexId);
			//设置头像采用二级缓存、异步加载
			Global.imageLoader.DisplayImage(item.HeadImgReleaseUrl,_getApplyInfoItemView.guardian_img_head,Global.Options);
			SetGuardianStatusAndAction (_getApplyInfoItemView, item);

			return convertView;
		}


		private void SetGuardianStatusAndAction(GetApplyInfoListItemView _getApplyInfoItemView,GetApplyInfoListItem item)
		{
			if (item.BindDeriction == 0) {
				_getApplyInfoItemView.ll_action.Visibility = ViewStates.Invisible;
				//被监护人
				switch (item.IsPass) {
				case "0":
					_getApplyInfoItemView.tv_GuardianStatus.Text = "等待对方处理申请";
					break;
				case "1":
					_getApplyInfoItemView.tv_GuardianStatus.Text = "对方已同意申请";
					break;
				case "2":
					_getApplyInfoItemView.tv_GuardianStatus.Text = "对方已拒绝申请";
					break;

				}
				
			} else {
				//监护人
				switch (item.IsPass) {
				case "0":
					_getApplyInfoItemView.ll_action.Visibility = ViewStates.Visible;
					_getApplyInfoItemView.tv_GuardianStatus.Visibility = ViewStates.Invisible;
					_getApplyInfoItemView.btn_action_agree.Tag = item;
					_getApplyInfoItemView.btn_action_disagree.Tag = item;
					_getApplyInfoItemView.btn_action_agree.SetTag (Resource.Id.ll_action, "1");
					_getApplyInfoItemView.btn_action_disagree.SetTag (Resource.Id.ll_action, "0");
					_getApplyInfoItemView.btn_action_agree.Click -= ActionHandler;
					_getApplyInfoItemView.btn_action_agree.Click += ActionHandler;
					_getApplyInfoItemView.btn_action_disagree.Click -= ActionHandler;
					_getApplyInfoItemView.btn_action_disagree.Click += ActionHandler;

					break;
				case "1":
					_getApplyInfoItemView.ll_action.Visibility = ViewStates.Invisible;
					_getApplyInfoItemView.tv_GuardianStatus.Text = "我已同意对方申请";
					break;
				case "2":
					_getApplyInfoItemView.ll_action.Visibility = ViewStates.Invisible;
					_getApplyInfoItemView.tv_GuardianStatus.Text = "我已拒绝对方申请";
					break;
				}

			}
		}

		/// <summary>
		/// 事件处理程序
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		private void ActionHandler(object sender, EventArgs e)
		{
			var btnAction = sender as Button;
			var item = (GetApplyInfoListItem)btnAction.Tag;
			var actionflag = btnAction.GetTag (Resource.Id.ll_action);
			ProgressDialogUtil.StartProgressDialog(activity,"正在处理中...");
			//检测网络连接
			if(!EldYoungUtil.IsConnected(activity))
			{
				Toast.MakeText(activity,"网络连接超时,请检测网路",ToastLength.Short).Show();
				ProgressDialogUtil.StopProgressDialog();
				return;
			}

			examinebundGuardianParam.Ifagreen = actionflag.ToString();
			examinebundGuardianParam.Id = item.Id;

			if (!requestParams.ContainsKey ("eId"))
				requestParams.Add ("eId", examinebundGuardianParam.Eid);
			else
				requestParams ["eId"] = examinebundGuardianParam.Eid;
			
			if (!requestParams.ContainsKey ("eifagreen"))
				requestParams.Add ("eifagreen", examinebundGuardianParam.Eifagreen);
			else
				requestParams ["eifagreen"] = examinebundGuardianParam.Eifagreen;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", examinebundGuardianParam.Eaction);
			else
				requestParams ["eaction"] = examinebundGuardianParam.Eaction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", examinebundGuardianParam.Md5);
			else
				requestParams ["md5"] = examinebundGuardianParam.Md5;
			
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", examinebundGuardianParam.Key);
			else
				requestParams ["key"] = examinebundGuardianParam.Key;

			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (examinebundGuardianParam.Url,requestParams);
			else
				restSharpRequestHelp.RequestParams = requestParams;
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed &&response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					
					var result = response.Content;
					var examinebundGuardianJson = JsonConvert.DeserializeObject<ExamineBundGuardianJson>(result);
					if(examinebundGuardianJson.statuscode == "1")
					{
						activity.RunOnUiThread(()=>
							{
								Toast.MakeText(activity,"处理成功...",ToastLength.Short).Show();
								ProgressDialogUtil.StopProgressDialog();
								Remove(item);
								return;
							});
					}
					else
					{
						activity.RunOnUiThread(()=>
							{
								Toast.MakeText(activity,"处理失败,稍后在试...",ToastLength.Short).Show();
								ProgressDialogUtil.StopProgressDialog();
								return;
							});
					}


				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					activity.RunOnUiThread(()=>
						{
							Toast.MakeText(activity,"网络连接超时,稍后在试...",ToastLength.Short).Show();
							ProgressDialogUtil.StopProgressDialog();
							return;
						});
				}
				else
				{
					activity.RunOnUiThread(()=>
						{
							Toast.MakeText(activity,response.StatusDescription,ToastLength.Short).Show();
							ProgressDialogUtil.StopProgressDialog();
							return;
						});
				}
			});

		}



	}

	/// <summary>
	/// Guardian item view.组件
	/// </summary>
	public class GetApplyInfoListItemView:Java.Lang.Object
	{
		public TextView tv_Name;
		public TextView tv_PhoneNum;
		public ImageView img_Sex;
		public ImageView guardian_img_head;
		public TextView tv_GuardianStatus;
		public TextView tv_applyContent;
		public LinearLayout ll_action;
		public Button btn_action_agree;
		public Button btn_action_disagree;

	}
}

