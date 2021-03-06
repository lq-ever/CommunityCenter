﻿
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
using Android.Support.V4.Widget;
using System.Threading.Tasks;
using System.Threading;
using Com.Handmark.Pulltorefresh.Library;
using CommunityCenter.Common;

namespace CommunityCenter
{
	public class MainTabFinanceFragment :Fragment,PullToRefreshBase.IOnRefreshListener
	{
		private PullToRefreshScrollView pull_refresh_scroll_finance;
		private TextView tv_totalAssets,tv_availableAssets,tv_frozenAssets;
		private RelativeLayout rl_charge,rl_withDraw,rl_bankCards,rl_DealRecords,rl_dailyPay,rl_respect;

		private bool IsRefreshing = false;//是否正在获取数据
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
			var tab_financeView = inflater.Inflate (Resource.Layout.Main_Tab_Finance, container, false);
			return tab_financeView;
		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);
			//设置下拉刷新动画
			pull_refresh_scroll_finance = View.FindViewById<PullToRefreshScrollView> (Resource.Id.pull_refresh_scroll_finance);
			//设置可以上拉加载。下拉刷新
			pull_refresh_scroll_finance.Mode = PullToRefreshBase.PullToRefreshMode.PullFromStart;
			//绑定监听事件
			pull_refresh_scroll_finance.SetOnRefreshListener(this);

			tv_totalAssets = View.FindViewById<TextView> (Resource.Id.tv_totalAssets);
			tv_availableAssets = View.FindViewById<TextView> (Resource.Id.tv_availableAssets);
			tv_frozenAssets = View.FindViewById<TextView> (Resource.Id.tv_frozenAssets);
			rl_charge = View.FindViewById<RelativeLayout> (Resource.Id.rl_charge);
			rl_withDraw = View.FindViewById<RelativeLayout> (Resource.Id.rl_withDraw);
			rl_bankCards = View.FindViewById<RelativeLayout> (Resource.Id.rl_bankCards);
			rl_DealRecords = View.FindViewById<RelativeLayout> (Resource.Id.rl_DealRecords);
			rl_dailyPay = View.FindViewById<RelativeLayout> (Resource.Id.rl_dailyPay);
			rl_respect = View.FindViewById<RelativeLayout> (Resource.Id.rl_respect);
			//充值
			rl_charge.Click += (object sender, EventArgs e) => 
			{
				EldYoungUtil.StartTargetActivity(Activity,FuncActivityType.Charge);
			};
			//提现
			rl_withDraw.Click += (object sender, EventArgs e) => 
			{
				EldYoungUtil.StartTargetActivity(Activity,FuncActivityType.WithDraw);
			};
			//银行卡
			rl_bankCards.Click += (sender, e) => 
			{
				EldYoungUtil.StartTargetActivity(Activity,FuncActivityType.BankCards);
			};
			//交易记录
			rl_DealRecords.Click += (sender, e) => 
			{
				EldYoungUtil.StartTargetActivity(Activity,FuncActivityType.DealRecords);
			};
			//日常缴费
			rl_dailyPay.Click += (object sender, EventArgs e) => 
			{
				EldYoungUtil.StartTargetActivity(Activity,FuncActivityType.DailyPay);
			};
			//更多
			rl_respect.Click += (sender, e) => 
			{
				//todo nothing
			};
			//初始化加载完成

			new Handler ().PostDelayed (() => {
				if(EldYoungUtil.HasLogin)
					//第一次进入设置自动刷新view
					pull_refresh_scroll_finance.Refreshing = true;
			}, 500);

		}


		/// <summary>
		/// 下拉刷新回调函数
		/// </summary>
		/// <param name="p0">P0.</param>
		public void OnRefresh (PullToRefreshBase p0)
		{
			if (!IsRefreshing) {
				IsRefreshing = true;
				Task.Factory.StartNew (() => {
					loadData();
				});
			} else {
				pull_refresh_scroll_finance.OnRefreshComplete ();
				IsRefreshing = false;
			}
		}

		/// <summary>
		/// 调用web服务获取金额数据
		/// </summary>
		private void loadData()
		{
			//todo:调用web服务获取数据,赋值
			Thread.Sleep (1000);
			Activity.RunOnUiThread (() => {
				pull_refresh_scroll_finance.OnRefreshComplete ();
				IsRefreshing = false;
			});

		}

	}
}

