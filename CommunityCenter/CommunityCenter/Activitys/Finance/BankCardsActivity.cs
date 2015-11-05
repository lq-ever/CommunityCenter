
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
using Com.Handmark.Pulltorefresh.Library;
using System.Threading.Tasks;
using System.Threading;
using CommunityCenter.Adapter;
using CommunityCenter.Model.Finance;

namespace CommunityCenter
{
	[Activity (Theme = "@style/MyCustomTheme" )]			
	public class BankCardsActivity : Activity,PullToRefreshBase.IOnRefreshListener
	{
		private PullToRefreshListView lv_bankCards;

		private bool IsRefreshing = false;//是否正在获取数据
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();

		private BankCardInfoListAdapter bankCardAdapter;
		private ListView actualListView;
		private List<BankCardItem> bankInfoLists = new List<BankCardItem>();
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.BankCardsLayout);
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
			tv_desc.Text = "银行卡";
			var tv_action = FindViewById<TextView> (Resource.Id.tv_action);
			tv_action.Text = "添加";
			tv_action.Click += (object sender, EventArgs e) => 
			{
				//跳转添加银行卡页面
				StartActivity(typeof(AddBankStepOneActivity));
			};

			//设置下拉刷新动画
			lv_bankCards = FindViewById<PullToRefreshListView> (Resource.Id.lv_bankcard);
			actualListView = (ListView)lv_bankCards.RefreshableView;
			//设置可以上拉加载。下拉刷新
			lv_bankCards.Mode = PullToRefreshBase.PullToRefreshMode.PullFromStart;
			//下拉刷新提示文本
			lv_bankCards.GetLoadingLayoutProxy(true,false).SetPullLabel(string.Empty);
			lv_bankCards.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(string.Empty);
			lv_bankCards.GetLoadingLayoutProxy (true, false).SetReleaseLabel (string.Empty);
			//绑定监听事件
			lv_bankCards.SetOnRefreshListener(this);
			//设置自定义列表adapter		
			bankCardAdapter = new BankCardInfoListAdapter (this);
			actualListView.Adapter = bankCardAdapter;

			//第一次不为空设置自动刷新view
			new Handler ().PostDelayed (() => {
				lv_bankCards.Refreshing = true;
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
				lv_bankCards.OnRefreshComplete ();
				IsRefreshing = false;

			}
		}

		private void loadData()
		{
			//todo:调用web服务获取已经绑定银行卡数据
			Thread.Sleep (3000);
			RunOnUiThread (() => {
				bankInfoLists.Clear();
				bankCardAdapter.Clear();
				bankInfoLists.Add(new BankCardItem(){BankCardTypeId="0",BankCardImageUrl="http://c.lelaozu.com/images/%E4%BA%A4%E9%80%9A%E9%93%B6%E8%A1%8C.png",BankCardNo="2548756398214258"});
				bankInfoLists.Add(new BankCardItem(){BankCardTypeId="0",BankCardImageUrl="http://c.lelaozu.com/images/%E5%86%9C%E4%B8%9A%E9%93%B6%E8%A1%8C.png",BankCardNo="52847102369874256"});
				bankInfoLists.Add(new BankCardItem(){BankCardTypeId="0",BankCardImageUrl="http://c.lelaozu.com/images/%E9%82%AE%E6%94%BF%E9%93%B6%E8%A1%8C.png",BankCardNo="52874102369874411215"});
				bankCardAdapter.AddAll(bankInfoLists);
				bankCardAdapter.NotifyDataSetChanged();
				lv_bankCards.OnRefreshComplete ();
				IsRefreshing = false;
			});
		}

	}
}

