
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
using CommunityCenter.Activitys.Finance;
using Com.Handmark.Pulltorefresh.Library;
using CommunityCenter.Adapter;
using System.Threading.Tasks;
using System.Threading;

namespace CommunityCenter.Activitys.Finance
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class DealRecordsActivity : Activity,PullToRefreshBase.IOnRefreshListener2
	{

		private string dealStatus, dealType, dealStartTime, dealEndTime;
		private PullToRefreshListView lv_dealRecords;

		private bool IsRefreshing = false;//是否正在获取数据
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();

		private DealRecordListAdapter dealRecordAdapter;
		private ListView actualListView;
		private List<DealRecordItem> dealRecordInfoLists = new List<DealRecordItem>();
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.DealRecordsLayout);
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
			tv_desc.Text = "交易记录";

			//操作栏
			var tv_action = FindViewById<TextView> (Resource.Id.tv_action);
			tv_action.Text = "筛选";
			tv_action.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(ChooseDealRecordConditionActivity));
				var requestCode = 0;  
				StartActivityForResult(intent,requestCode);
			};

			//对条件赋初始值
			dealStatus = "0";
			dealStartTime = DateTime.Now.ToString ("yyyy-MM-dd");
			dealEndTime = DateTime.Now.AddDays (1).ToString ("yyyy-MM-dd");

			//设置下拉刷新动画
			lv_dealRecords = FindViewById<PullToRefreshListView> (Resource.Id.lv_dealRecords);
			actualListView = (ListView)lv_dealRecords.RefreshableView;
			//设置可以上拉加载。下拉刷新
			lv_dealRecords.Mode = PullToRefreshBase.PullToRefreshMode.Both;
			//下拉刷新提示文本

			//下拉刷新提示文本
			lv_dealRecords.GetLoadingLayoutProxy(true,false).SetPullLabel(GetString(Resource.String.pullDownLbl));
			lv_dealRecords.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(GetString(Resource.String.pullDownRefreshLbl));
			lv_dealRecords.GetLoadingLayoutProxy (true, false).SetReleaseLabel (GetString(Resource.String.pullDownReleaseLbl));
			//上拉加载提示文本
			lv_dealRecords.GetLoadingLayoutProxy(false,true).SetPullLabel(GetString(Resource.String.pullUpLbl));
			lv_dealRecords.GetLoadingLayoutProxy (false, true).SetRefreshingLabel (GetString(Resource.String.pullUpRefreshLbl));
			lv_dealRecords.GetLoadingLayoutProxy (false, true).SetReleaseLabel (GetString(Resource.String.pullUpReleaseLbl));
			//绑定监听事件
			lv_dealRecords.SetOnRefreshListener(this);
			//设置自定义列表adapter		
			dealRecordAdapter = new DealRecordListAdapter (this);
			actualListView.Adapter = dealRecordAdapter;

			actualListView.ItemClick+= (object sender, AdapterView.ItemClickEventArgs e) => 
			{
				var intent  = new Intent(this,typeof(DealRecordDetailActivity));
				var bundle = new Bundle();
			
				bundle.PutString("dealRecordId",dealRecordAdapter.GetItem(e.Position-1).DealRecordId);
				intent.PutExtras(bundle);
				StartActivity(intent);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//第一次不为空设置自动刷新view
			new Handler ().PostDelayed (() => {
				lv_dealRecords.Refreshing = true;
			}, 500);
		}

		protected override void OnActivityResult (int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult (requestCode, resultCode, data);
			if (resultCode == Result.Ok) {
				//过滤赋值
				dealStatus = data.GetStringExtra ("dealStatus");
				dealType = data.GetStringExtra ("dealType");
				dealStartTime = data.GetStringExtra ("dealStarttime");
				dealEndTime = data.GetStringExtra ("dealEndtime");
				//todo:重新刷新数据
				loadData();
			}
		}



		private void loadData()
		{
			//todo:调用web服务获取已经绑定银行卡数据
			Thread.Sleep (1000);
			RunOnUiThread (() => {
				dealRecordInfoLists.Clear();
				dealRecordAdapter.Clear();
				dealRecordInfoLists.Add(new DealRecordItem(){DealTime="2015-10-12 13:20:24",DealAmount="50",DealStatusDesc="成功",DealTypeDesc="充值",AccountName="环迅支付",DealRecordId="215421"});
				dealRecordInfoLists.Add(new DealRecordItem(){DealTime="2015-10-12 13:20:24",DealAmount="10",DealStatusDesc="失败",DealTypeDesc="宽带费",AccountName="环迅支付",DealRecordId="125224"});
				dealRecordInfoLists.Add(new DealRecordItem(){DealTime="2015-10-12 13:20:24",DealAmount="500",DealStatusDesc="成功",DealTypeDesc="购物",AccountName="环迅支付",DealRecordId="1545665"});

				dealRecordAdapter.AddAll(dealRecordInfoLists);
				dealRecordAdapter.NotifyDataSetChanged();
				lv_dealRecords.OnRefreshComplete ();
				IsRefreshing = false;
			});
		}

		/// <summary>
		/// 监听下拉刷新事件
		/// </summary>
		/// <param name="p0">P0.</param>
		public void OnPullDownToRefresh (PullToRefreshBase p0)
		{
			if (!IsRefreshing) {
				IsRefreshing = true;
				Task.Factory.StartNew (() => {
					loadData();
				});
			} else {
				lv_dealRecords.OnRefreshComplete ();
				IsRefreshing = false;

			}
		}

		/// <summary>
		/// 监听上拉加载更多事件
		/// </summary>
		/// <param name="p0">P0.</param>
		public void OnPullUpToRefresh (PullToRefreshBase p0)
		{
			if (!IsRefreshing) {
				IsRefreshing = true;
				Task.Factory.StartNew (() => {
					//加载更多数据
					LoadMoreData ();
				});
			} else {
				lv_dealRecords.OnRefreshComplete ();
				IsRefreshing = false;
			}

		}

		/// <summary>
		/// Loads the more data.
		/// </summary>
		private void LoadMoreData()
		{
			//todo:调用web服务获取已经绑定银行卡数据
			Thread.Sleep (2000);
			RunOnUiThread (() => {

				var morelist = new List<DealRecordItem>()
				{
					new DealRecordItem(){DealTime="2015-10-12 13:20:24",DealAmount="50",DealStatusDesc="成功",DealTypeDesc="充值",AccountName="环迅支付"},
					new DealRecordItem(){DealTime="2015-10-12 13:20:24",DealAmount="50",DealStatusDesc="成功",DealTypeDesc="充值",AccountName="环迅支付"},
					new DealRecordItem(){DealTime="2015-10-12 13:20:24",DealAmount="50",DealStatusDesc="成功",DealTypeDesc="充值",AccountName="环迅支付"}
				};
				dealRecordInfoLists.AddRange(morelist);
				dealRecordAdapter.AddAll(morelist);
				dealRecordAdapter.NotifyDataSetChanged();
				lv_dealRecords.OnRefreshComplete ();
				IsRefreshing = false;
			});
		}


	}
}

