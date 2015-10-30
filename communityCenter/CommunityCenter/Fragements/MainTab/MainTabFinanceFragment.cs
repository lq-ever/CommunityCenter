
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
	public class MainTabFinanceFragment : BaseFragment,PullToRefreshBase.IOnRefreshListener
	{
		private PullToRefreshScrollView pull_refresh_scroll_finance;
		private TextView tv_totalAssets,tv_availableAssets,tv_frozenAssets;
		private RelativeLayout rl_charge,rl_withDraw,rl_bankCards,rl_DealRecords;

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
			//初始化加载完成
			IsPrepared = true;
		}
		/// <summary>
		/// 延迟加载
		/// </summary>
		public override void LasyloadData ()
		{
			if (!IsPrepared || !IsVisible)
				return;
			//第一次进入设置自动刷新view
			pull_refresh_scroll_finance.Refreshing = true;
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
			Thread.Sleep (3000);
			pull_refresh_scroll_finance.OnRefreshComplete ();
			IsRefreshing = false;
		}

	}
}

