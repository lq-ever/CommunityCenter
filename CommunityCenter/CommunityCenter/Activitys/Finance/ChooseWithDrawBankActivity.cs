﻿
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
using CommunityCenter.Adapter;
using CommunityCenter.Model.Finance;
using Com.Nostra13.Universalimageloader.Core.Listener;
using CommunityCenter.Common;

namespace CommunityCenter.Activitys.Finance
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class ChooseWithDrawBankActivity : Activity
	{
		private ListView lv_bankType;

		private BankCardInfoListAdapter bankCardInfoListAdapter ;
		private List<BankCardItem> bankInfoLists = new List<BankCardItem>();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.ChooseWithDrawBankLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			InitView ();
			// Create your application here 
		}

		private void InitView()
		{
			//设置标题栏
			var img_header_back = FindViewById<ImageView> (Resource.Id.img_header_back);
			img_header_back.Click += (sender, e) => 
			{
				SetResult(Result.Canceled);
				this.Finish();
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			var tv_back = FindViewById<TextView> (Resource.Id.tv_back);
			tv_back.Text = "返回";
			var tv_desc = FindViewById<TextView> (Resource.Id.tv_desc);
			tv_desc.Text = "选择银行卡";
			lv_bankType = FindViewById<ListView> (Resource.Id.lv_bankType);
			bankCardInfoListAdapter = new BankCardInfoListAdapter (this);

			lv_bankType.Adapter = bankCardInfoListAdapter;
			//设置滑动listview停止加载图片
			lv_bankType.SetOnScrollListener (new PauseOnScrollListener(Global.imageLoader,false,false));
			lv_bankType.SetSelector (Resource.Color.red);//设置被选中项颜色为红
			LoadBankTypeData ();
			//点击列表详细
			lv_bankType.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => 
			{
				var intent = new Intent();
				intent.PutExtra("choosebankTypeId",bankCardInfoListAdapter.GetItem(e.Position).BankCardTypeId);
				intent.PutExtra("choosebankDesc",bankCardInfoListAdapter.GetItem(e.Position).BankCardTypeDesc);
				intent.PutExtra("choosebankCardNo",bankCardInfoListAdapter.GetItem(e.Position).BankCardNo);
				SetResult(Result.Ok,intent);
				this.Finish();
			};
		}

		/// <summary>
		/// Loads the type data.
		/// </summary>
		private void LoadBankTypeData()
		{
			//todo:调用webservice获取数据
			bankInfoLists.Clear();
			bankCardInfoListAdapter.Clear();
			bankCardInfoListAdapter.Add(new BankCardItem(){BankCardTypeId="0",BankCardTypeDesc="交通银行",BankCardNo="652847412336698512",BankCardImageUrl="http://c.lelaozu.com/images/%E4%BA%A4%E9%80%9A%E9%93%B6%E8%A1%8C.png"});
			bankInfoLists.Add(new BankCardItem(){BankCardTypeId="0",BankCardTypeDesc="工商银行",BankCardNo="24556548111444585242",BankCardImageUrl="http://c.lelaozu.com/images/%E5%86%9C%E4%B8%9A%E9%93%B6%E8%A1%8C.png"});
			bankInfoLists.Add(new BankCardItem(){BankCardTypeId="0",BankCardTypeDesc="农业银行",BankCardNo="2455487512215214548878",BankCardImageUrl="http://c.lelaozu.com/images/%E9%82%AE%E6%94%BF%E9%93%B6%E8%A1%8C.png"});
			bankCardInfoListAdapter.AddAll(bankInfoLists);
			bankCardInfoListAdapter.NotifyDataSetChanged();
		}

		public override void OnBackPressed ()
		{
			SetResult(Result.Canceled);
			base.OnBackPressed ();
		}

	}
}

