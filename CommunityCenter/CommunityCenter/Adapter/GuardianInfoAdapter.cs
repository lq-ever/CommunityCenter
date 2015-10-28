using System;
using Android.Widget;

using Android.App;
using Android.Content;
using Android.Views;


using System.Reflection;
using System.ComponentModel;
using System.Threading;
using System.Collections.Generic;
using Newtonsoft.Json;
using Android.OS;
using Com.Nostra13.Universalimageloader.Core;
using Android.Graphics;
using Com.Nostra13.Universalimageloader.Core.Display;
using Com.Nostra13.Universalimageloader.Core.Listener;
using Java.Util;
using CommunityCenter.Model.ServerType.Admin;
using CommunityCenter.Common;
using CommunityCenter.Param;
using CommunityCenter.Json;
using CommunityCenter.Activitys.ServerType.Admin;




namespace CommunityCenter.Adapter
{
	public class GuardianInfoAdapter:ArrayAdapter<GuardianInfoListItem>
	{
		private Activity activity;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private UnBindGuardianParam unBindGuardianParam = new UnBindGuardianParam();//请求参数对象
		private RestSharpRequestHelp restSharpRequestHelp;
		private IImageLoadingListener animateFirstListener = new AnimateFirstDisplayListener(); 
		public GuardianInfoAdapter (Activity _activity):base(_activity,0)
		{
			activity = _activity;

		}

		public override Android.Views.View GetView ( int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			
			GuardianItemView _guardianItemView = null;
			var item = GetItem (position);
			if (convertView == null) {
				
				convertView = LayoutInflater.From (Context).Inflate (Resource.Layout.guardianListitemView, null);
				_guardianItemView = new GuardianItemView ();
				_guardianItemView.guardian_img_head = convertView.FindViewById<ImageView> (Resource.Id.guardian_img_head);
				_guardianItemView.tv_Name = convertView.FindViewById<TextView> (Resource.Id.tv_Name);
				_guardianItemView.tv_PhoneNum = convertView.FindViewById<TextView> (Resource.Id.tv_phoneNumber);
				_guardianItemView.img_Sex = convertView.FindViewById<ImageView> (Resource.Id.img_sex);
				_guardianItemView.tv_Detail = convertView.FindViewById<TextView> (Resource.Id.tv_detail);
				_guardianItemView.btn_Action = convertView.FindViewById<Button> (Resource.Id.btn_Action);
				_guardianItemView.tv_Location = convertView.FindViewById<TextView> (Resource.Id.tv_location);
				convertView.SetTag (Resource.Id.guardianlistitemview, (Java.Lang.Object)_guardianItemView);


			} else
				_guardianItemView = (GuardianItemView)convertView.GetTag (Resource.Id.guardianlistitemview);
			
			_guardianItemView.tv_Name.Text = item.TrueName;
			_guardianItemView.tv_PhoneNum.Text = item.PhoneNumberOne;
			//设置地址
			if (string.IsNullOrEmpty (item.ContactAddress))
				_guardianItemView.tv_Location.Text = string.Empty;
			else {
				if (item.ContactAddress.Contains ("|"))
					_guardianItemView.tv_Location.Text = item.ContactAddress.Split (new char[]{ '|' }) [1];
				else
					_guardianItemView.tv_Location.Text = item.ContactAddress;

			}
		    _guardianItemView.btn_Action.Text = "解绑";

			//设置男女
			var imgSexId = (item.Sex == Sex.Male) ? Resource.Drawable.ic_sex_man : Resource.Drawable.ic_sex_woman;
			_guardianItemView.img_Sex.SetImageResource (imgSexId);

			//设置头像采用二级缓存、异步加载

			Global.imageLoader.DisplayImage(item.HeadImgReleaseUrl,_guardianItemView.guardian_img_head,Global.Options);
			//按钮绑定事件 			
			_guardianItemView.btn_Action.Tag = item;
			_guardianItemView.btn_Action.Click -= ActionHandler;
			_guardianItemView.btn_Action.Click += ActionHandler;

			//详情按钮事件
			_guardianItemView.tv_Detail.Tag = item;
			_guardianItemView.tv_Detail.Click -= DetailHandler;
			_guardianItemView.tv_Detail.Click += DetailHandler;
			return convertView;
			
		}



		/// <summary>
		/// 动作按钮事件方法
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		private void ActionHandler(object sender, EventArgs e)
		{
			var item = (GuardianInfoListItem)(sender as Button).Tag;

			//解绑,弹出解绑popup窗口
			var unbindPopWindow = new UnbindPopWindow (activity, item){UnBindEventHandler = UnBindGuardian};
			unbindPopWindow.ShowPopWindow (activity.FindViewById<LinearLayout> (Resource.Id.ll_BindGuardian));
		}

		/// <summary>
		/// 解绑监护人
		/// </summary>
		/// <param name="userId">User identifier.</param>
		private void UnBindGuardian(GuardianInfoListItem item)
		{
			//调用webservice
			ProgressDialogUtil.StartProgressDialog(activity,"正在解绑中...");
			//检测网络连接
			if(!EldYoungUtil.IsConnected(activity))
			{
				Toast.MakeText(activity,"网络连接超时,请检测网路",ToastLength.Short).Show();
				ProgressDialogUtil.StopProgressDialog();
				return;
			}

			unBindGuardianParam.Id = item.Id;
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", unBindGuardianParam.Key);
			else
				requestParams ["key"] = unBindGuardianParam.Key;
			if (!requestParams.ContainsKey ("eId"))
				requestParams.Add ("eId", unBindGuardianParam.Eid);
			else
				requestParams ["eId"] = unBindGuardianParam.Eid;
			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", unBindGuardianParam.Eaction);
			else
				requestParams ["eaction"] = unBindGuardianParam.Eaction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", unBindGuardianParam.Md5);
			else
				requestParams ["md5"] = unBindGuardianParam.Md5;
			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (unBindGuardianParam.Url,requestParams);
			else
				restSharpRequestHelp.RequestParams = requestParams;
			//调用解绑web服务
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					
					var result = response.Content;
					var unBindGuardianJson = JsonConvert.DeserializeObject<UnBindGuardianJson>(result);
					if(unBindGuardianJson.statuscode == "1")
					{
						if(unBindGuardianJson.data == "1")
						{
							activity.RunOnUiThread(()=>
								{
									Toast.MakeText(activity,"解绑成功",ToastLength.Short).Show();
									ProgressDialogUtil.StopProgressDialog();
									Remove(item);
									return;
								});
						}
						else
						{
							activity.RunOnUiThread(()=>
								{
									Toast.MakeText(activity,"解绑失败,稍后在试...",ToastLength.Short).Show();
									ProgressDialogUtil.StopProgressDialog();
									return;
								});
						}
					}
					else
					{
						activity.RunOnUiThread(()=>
							{
								Toast.MakeText(activity,"解绑失败,稍后在试...",ToastLength.Short).Show();
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



		/// <summary>
		/// 详情事件方法
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		private void DetailHandler(object sender, EventArgs e)
		{
			var item = (GuardianInfoListItem)(sender as TextView).Tag;
			Intent intent = new Intent (activity, typeof(GuardianDetailInfoActivity));
			var bundle = new Bundle();
			bundle.PutString("UId",item.UId);
			intent.PutExtras(bundle);
			Context.StartActivity (intent);
			activity.OverridePendingTransition (Android.Resource.Animation.SlideInLeft, Android.Resource.Animation.SlideOutRight);
		}
	}



	/// <summary>
	/// Guardian item view.组件
	/// </summary>
	public class GuardianItemView:Java.Lang.Object
	{
		public TextView tv_Name;
		public TextView tv_PhoneNum;
		public ImageView img_Sex;
		public TextView tv_Detail;
		public Button btn_Action;
		public TextView tv_Location;
		public ImageView guardian_img_head;

	}

	public  class AnimateFirstDisplayListener: SimpleImageLoadingListener
	{
		static List<string> displayedImages = new List<string> ();
		public override void OnLoadingComplete (string p0, View p1, Bitmap p2)
		{
			if (p2 != null) {
				ImageView imageView = (ImageView)p1;
				//判断是否第一显示
				var firstdisplay = !displayedImages.Contains(p0);
				if (firstdisplay) {
					//图片淡入效果
					FadeInBitmapDisplayer.Animate (imageView, 500);
					displayedImages.Add (p0);
				}
				
			}
			  
		}
	}



}

