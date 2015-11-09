
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

namespace CommunityCenter
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class DealRecordDetailActivity : Activity
	{
		private TextView tv_dealNo,tv_dealName,tv_dealTime,tv_dealAmmount,tv_dealType,tv_dealAccount,tv_dealRemark;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.DetailRecordDetailLayout);
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
			tv_desc.Text = "交易详情";
			tv_dealNo = FindViewById<TextView> (Resource.Id.tv_dealNo);
			tv_dealName = FindViewById<TextView> (Resource.Id.tv_dealName);
			tv_dealTime = FindViewById<TextView> (Resource.Id.tv_dealTime);
			tv_dealAmmount = FindViewById<TextView> (Resource.Id.tv_dealAmmount);
			tv_dealType = FindViewById<TextView> (Resource.Id.tv_dealType);
			tv_dealAccount = FindViewById<TextView> (Resource.Id.tv_dealAccount);
			tv_dealRemark = FindViewById<TextView> (Resource.Id.tv_dealRemark);
			var bundle = Intent.Extras;
			var dealRecordId = bundle.GetString ("dealRecordId");
			new Handler ().PostDelayed (() => {
				LoadData(dealRecordId);
			}, 500);
		}

		/// <summary>
		///获取交易详情
		/// </summary>
		private void LoadData(string dealRecordId)
		{
			ProgressDialogUtil.StartProgressDialog (this, "正在获取交易详细数据...");
			//检测网络连接
			if(!EldYoungUtil.IsConnected(this))
			{
				Toast.MakeText(this,"网络连接超时,请检测网路",ToastLength.Short).Show();
				ProgressDialogUtil.StopProgressDialog();
				return;
			}
			//todo:调用webservice赋值

		}
	}
}

