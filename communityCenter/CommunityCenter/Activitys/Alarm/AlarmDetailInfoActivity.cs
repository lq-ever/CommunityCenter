
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
using CN.Jpush.Android.Api;

using Newtonsoft.Json;



using CommunityCenter.Common;
using Org.Json;
using CommunityCenter.Param;
using CommunityCenter.Model.Alarm;
using RestSharp;
using CommunityCenter.Json;
using CommunityCenter.Adapter;

namespace CommunityCenter.Activitys.Alarm
{
	[Activity (Theme="@style/MyCustomTheme")]			
	public class AlarmDetailInfoActivity : Activity
	{
		private string alarmId;
		private RestSharpRequestHelp restSharpRequestHelp;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private AlarmInfoDetailParam alarmInfoDetailParam;//请求参数对象
		private List<AlarmInfoHandDetailItem> alarmInfoHandleDetailLists = new List<AlarmInfoHandDetailItem>();

		private TextView tv_detail_alamTime, tv_detail_alarmPosition, tv_detail_trueName, tv_detail_alarmContent,
		tv_detail_deviceElectricity, tv_detail_alarmDeviceId,tv_detail_remark,tv_detail_status,tv_detail_alarmWay,
		tv_detail_handleUserType,tv_detail_cTrueName,tv_detail_cphoneNumberOne;

		private LinearLayout ll_maplocation;

		private ListView lv_handleDetail;

		private string alarmPosition = string.Empty;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.AlarmDetailInfoLayout);
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

			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "报警详细";
			var bundle = Intent.Extras;
			var alarmOrigin = bundle.GetString ("alarmOrigin");
			if (alarmOrigin == "Jpush") {
				var title = bundle.GetString (JPushInterface.ExtraNotificationTitle);
				var content = bundle.GetString (JPushInterface.ExtraAlert);
				var extras = bundle.GetString (JPushInterface.ExtraExtra);
				JSONObject extrasJson = new JSONObject(extras);
				alarmId = extrasJson.OptString("aid");
			
			}
			else if(alarmOrigin == "alarmList")
			{
			    alarmId = bundle.GetString ("alarmId");//报警id
			}
			tv_detail_alamTime = FindViewById<TextView>(Resource.Id.tv_detail_alamTime);
			tv_detail_alarmPosition = FindViewById<TextView> (Resource.Id.tv_detail_alarmPosition);
			tv_detail_trueName = FindViewById<TextView> (Resource.Id.tv_detail_trueName);
			tv_detail_alarmContent = FindViewById<TextView> (Resource.Id.tv_detail_alarmContent);
			tv_detail_deviceElectricity = FindViewById<TextView> (Resource.Id.tv_detail_deviceElectricity);
			tv_detail_alarmDeviceId = FindViewById<TextView> (Resource.Id.tv_detail_alarmDeviceId);
			tv_detail_remark = FindViewById<TextView> (Resource.Id.tv_detail_remark);
			tv_detail_status = FindViewById<TextView> (Resource.Id.tv_detail_status);
			tv_detail_alarmWay = FindViewById<TextView> (Resource.Id.tv_detail_alarmWay);
			tv_detail_handleUserType = FindViewById<TextView> (Resource.Id.tv_detail_handleUserType);
			tv_detail_cTrueName = FindViewById<TextView> (Resource.Id.tv_detail_cTrueName);
			tv_detail_cphoneNumberOne = FindViewById<TextView> (Resource.Id.tv_detail_cphoneNumberOne);
			lv_handleDetail = FindViewById<ListView> (Resource.Id.lv_handleDetail);
			ll_maplocation = FindViewById<LinearLayout> (Resource.Id.ll_maplocation);
			//查看地图
			ll_maplocation.Click += (object sender, EventArgs e) => {
				if(string.IsNullOrEmpty(alarmPosition) || !alarmPosition.Contains(","))
					return;
				var intent = new Intent(this,typeof(AlarmLocationActivity));
				var alarmbundle = new Bundle();
				alarmbundle.PutString("alarmPosition",alarmPosition);
				intent.PutExtras(alarmbundle);
				StartActivity(intent);
				//StartActivity(typeof(AlarmLocationActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//LoadDetailData ();
			new Handler ().PostDelayed (LoadDetailData, 1000);
		}

		private void LoadDetailData()
		{
			ProgressDialogUtil.StartProgressDialog (this, "正在加载报警详细数据...");
			if (string.IsNullOrEmpty (alarmId)) {
				ProgressDialogUtil.StopProgressDialog ();
				return;
			}
			//检测网络连接
			if(!EldYoungUtil.IsConnected(this))
			{
				Toast.MakeText(this,"网络连接超时,请检测网路",ToastLength.Short).Show();
				ProgressDialogUtil.StopProgressDialog();
				return;
			}
			alarmInfoDetailParam = new AlarmInfoDetailParam (){ AId = alarmId };

			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", alarmInfoDetailParam.Key);
			else
				requestParams ["eAId"] = alarmInfoDetailParam.Key;
			if (!requestParams.ContainsKey ("eAId"))
				requestParams.Add ("eAId",alarmInfoDetailParam.EaId);

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", alarmInfoDetailParam.Eaction);
			else
				requestParams ["eaction"] = alarmInfoDetailParam.Eaction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", alarmInfoDetailParam.Md5);
			else
				requestParams ["md5"] = alarmInfoDetailParam.Md5;

			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (alarmInfoDetailParam.Url,requestParams);
			else
				restSharpRequestHelp.RequestParams = requestParams;
			//调用webservice
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
				
					var result = response.Content;
					var alarmdetailInfoJson = JsonConvert.DeserializeObject<SearchAlarmDeatilInfoJson>(result);
					if(alarmdetailInfoJson.statuscode =="1")
					{
						if(alarmdetailInfoJson.data.detail.Count>0)
						{
							var detail = alarmdetailInfoJson.data.detail[0];
							RunOnUiThread(()=>
								{
									tv_detail_alamTime.Text = string.IsNullOrEmpty(detail.AlarmTime)?string.Empty:Convert.ToDateTime(detail.AlarmTime).ToString("yyyy-MM-dd HH:mm:ss");
									tv_detail_alarmContent.Text = EldYoungUtil.FormatStrVaue(detail.AlarmContent);
									tv_detail_alarmDeviceId.Text = EldYoungUtil.FormatStrVaue(detail.AlarmDeviceId);
									tv_detail_alarmPosition.Text = EldYoungUtil.FormatStrVaue(detail.AlarmPosition);
									alarmPosition = EldYoungUtil.FormatStrVaue(detail.AlarmPosition);
									tv_detail_alarmWay.Text = EldYoungUtil.FormatStrVaue(detail.AlarmWay);
									tv_detail_cphoneNumberOne.Text = EldYoungUtil.FormatStrVaue(detail.CPhoneNumberOne);
									tv_detail_cTrueName.Text = EldYoungUtil.FormatStrVaue(detail.CTrueName);
									tv_detail_deviceElectricity.Text = EldYoungUtil.FormatStrVaue(detail.DeviceElectricity);
									tv_detail_handleUserType.Text = EldYoungUtil.FormatStrVaue(detail.HandleUserType);
									tv_detail_remark.Text = EldYoungUtil.FormatStrVaue(detail.Remark);
									tv_detail_status.Text = EldYoungUtil.FormatStrVaue(detail.Status);
									tv_detail_trueName.Text = EldYoungUtil.FormatStrVaue(detail.TrueName);
								});
							
						} 

						if(alarmdetailInfoJson.data.handdetail.Count>0)
						{
							var handleDetails = alarmdetailInfoJson.data.handdetail;
							RunOnUiThread(()=>
								{
									lv_handleDetail.Adapter = new AlarmHandleDetailInfoAdapter(this,handleDetails);
								});
							
						}
						RunOnUiThread(()=>
							{
								ProgressDialogUtil.StopProgressDialog();
							});
					}
					else
					{
						RunOnUiThread(()=>
							{
								Toast.MakeText(this,"获取报警详情信息错误...",ToastLength.Short).Show();
								ProgressDialogUtil.StopProgressDialog();
								return;
							});
					}


				}
				else if(response.ResponseStatus == ResponseStatus.TimedOut)
				{
					RunOnUiThread(()=>
						{
							Toast.MakeText(this,"网络连接超时,稍后在试...",ToastLength.Short).Show();
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

