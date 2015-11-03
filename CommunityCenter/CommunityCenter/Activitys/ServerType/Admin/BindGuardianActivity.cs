
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
using CommunityCenter.Model.ServerType.Admin;
using CommunityCenter.Adapter;
using CommunityCenter.Common;
using Com.Nostra13.Universalimageloader.Core.Listener;
using CommunityCenter.Param;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CommunityCenter.Json;

namespace CommunityCenter.Activitys.ServerType.Admin
{
	[Activity (Theme="@style/MyCustomTheme")]			
	public class BindGuardianActivity : Activity,PullToRefreshBase.IOnRefreshListener2
	{
		private PullToRefreshListView myGuardianRefreshListView;
		private ListView actualListView;
		private int lastY;

		private List<GuardianInfoListItem> guardianInfoList;
		private GuardianInfoAdapter guardianInfoAdapter ;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private MineGuardianInfoListParam myGuardianInfoListParam;//请求参数对象
		private int pageIndex =1;//当前页码
		private RestSharpRequestHelp restSharpRequestHelp;
		private int total;//总记录数
		/** 是否已被加载过一次，第二次就不再去请求数据了 */
		protected bool HasLoadedOnce;
		private bool IsRefreshing = false;//是否正在获取数据
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.BindGuardianLayout);
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
			var tv_back = FindViewById<TextView> (Resource.Id.tv_back);
			tv_back.Text = "管理员";
			var tv_desc = FindViewById<TextView> (Resource.Id.tv_desc);
			tv_desc.Text = "绑定会员";

			myGuardianRefreshListView = FindViewById<PullToRefreshListView> (Resource.Id.lv_myGuardian);
			actualListView = (ListView)myGuardianRefreshListView.RefreshableView;
			//设置可以上拉加载。下拉刷新
			myGuardianRefreshListView.Mode = PullToRefreshBase.PullToRefreshMode.Both;

			//下拉刷新提示文本
			myGuardianRefreshListView.GetLoadingLayoutProxy(true,false).SetPullLabel(GetString(Resource.String.pullDownLbl));
			myGuardianRefreshListView.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(GetString(Resource.String.pullDownRefreshLbl));
			myGuardianRefreshListView.GetLoadingLayoutProxy (true, false).SetReleaseLabel (GetString(Resource.String.pullDownReleaseLbl));
			//上拉加载提示文本
			myGuardianRefreshListView.GetLoadingLayoutProxy(false,true).SetPullLabel(GetString(Resource.String.pullUpLbl));
			myGuardianRefreshListView.GetLoadingLayoutProxy (false, true).SetRefreshingLabel (GetString(Resource.String.pullUpRefreshLbl));
			myGuardianRefreshListView.GetLoadingLayoutProxy (false, true).SetReleaseLabel (GetString(Resource.String.pullUpReleaseLbl));




			//设置上拉下拉监听事件
			myGuardianRefreshListView.SetOnRefreshListener (this);
		


			//设置滑动listview停止加载图片
			actualListView.SetOnScrollListener (new PauseOnScrollListener(Global.imageLoader,false,false));

			guardianInfoAdapter = new GuardianInfoAdapter (this);
			actualListView.Adapter = guardianInfoAdapter;

			//初始化请求参数对象
			myGuardianInfoListParam = new MineGuardianInfoListParam (){ UserId = Global.Guid};

			LasyloadData ();

		}
		private void LasyloadData()
		{
			//第一次进入设置自动刷新view
			myGuardianRefreshListView.Refreshing = true;
		}

		private void loadData()
		{
			pageIndex = 1;
			UpdateGuardianInfoListParam ();
			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{

					var result = response.Content;
					var guardianInfoJson =  JsonConvert.DeserializeObject<GuardianInfoJson>(result);
					if(guardianInfoJson.statuscode =="1")
					{
						total = guardianInfoJson.data.total;
						guardianInfoList = guardianInfoJson.data.items;
						RunOnUiThread(()=>
						{
							guardianInfoAdapter.Clear();
							guardianInfoAdapter.AddAll(guardianInfoList);
							guardianInfoAdapter.NotifyDataSetChanged();
							HasLoadedOnce = true;//加载第一次成功
						});
					}
					else
					{
						RunOnUiThread(()=>
						{
						    Toast.MakeText(this,"获取监护人列表信息失败...",ToastLength.Short).Show();
						});
					}
				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					RunOnUiThread(()=>
					{
					    Toast.MakeText(this,"网络连接超时,稍后在试...",ToastLength.Short).Show();
					});
				}
				else
				{
					RunOnUiThread(()=>
					{
						Toast.MakeText(this,response.StatusDescription,ToastLength.Short).Show();
					});
				}
				RunOnUiThread(()=>
				{
					myGuardianRefreshListView.OnRefreshComplete ();
					IsRefreshing = false;
				});
			});
		}

		private void UpdateGuardianInfoListParam()
		{
			myGuardianInfoListParam.PageIndex = pageIndex.ToString();
			SetRestRequestParams ();
		}

		private void SetRestRequestParams()
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", myGuardianInfoListParam.Key);
			else
				requestParams ["key"] = myGuardianInfoListParam.Key;

			if (!requestParams.ContainsKey ("eUserId"))
				requestParams.Add ("eUserId", myGuardianInfoListParam.EuserId);
			else
				requestParams ["eUserId"] = myGuardianInfoListParam.EuserId;

			if (!requestParams.ContainsKey ("ePageIndex"))
				requestParams.Add ("ePageIndex", myGuardianInfoListParam.EpageIndex);
			else
				requestParams ["ePageIndex"] = myGuardianInfoListParam.EpageIndex;

			if (!requestParams.ContainsKey ("ePageSize"))
				requestParams.Add ("ePageSize", myGuardianInfoListParam.EpageSize);
			else
				requestParams ["ePageSize"] = myGuardianInfoListParam.EpageSize;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", myGuardianInfoListParam.Eaction);
			else
				requestParams ["eaction"] = myGuardianInfoListParam.Eaction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", myGuardianInfoListParam.Md5);
			else
				requestParams ["md5"] = myGuardianInfoListParam.Md5;
			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (myGuardianInfoListParam.Url,requestParams);
			else
				restSharpRequestHelp.RequestParams = requestParams;

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
					loadData ();
				});
			} else {
				myGuardianRefreshListView.OnRefreshComplete ();
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
					LoadMoreData ();
				});
			} else {
				myGuardianRefreshListView.OnRefreshComplete ();
				IsRefreshing = false;
			}


		}

		private void LoadMoreData()
		{
			lastY = guardianInfoList.Count;
			pageIndex++;
			UpdateGuardianInfoListParam ();
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed)
				{
					if(response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var result = response.Content;
						var guardianInfoJson =  JsonConvert.DeserializeObject<GuardianInfoJson>(result); 
						if(guardianInfoJson.statuscode == "1")
						{
							total = guardianInfoJson.data.total;
							guardianInfoList.AddRange(guardianInfoJson.data.items);
							RunOnUiThread(()=>
							{
								guardianInfoAdapter.AddAll(guardianInfoJson.data.items);
								guardianInfoAdapter.NotifyDataSetChanged();
								//讲listview滚动到上次加载位置
								actualListView.SetSelectionFromTop(lastY,(int)TrimMemory.Background);
							});
						}
						else
						{
							pageIndex --;
							RunOnUiThread(()=>
							{
							    Toast.MakeText(this,"获取更多监护人列表信息出错...",ToastLength.Short).Show();
							});
						}

					}

				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					pageIndex --;
					RunOnUiThread(()=>
					{
					    Toast.MakeText(this,"网络连接超时,稍后在试...",ToastLength.Short).Show();
					});
				}
				else
				{
					pageIndex --;
					RunOnUiThread(()=>
					{
						Toast.MakeText(this,response.StatusDescription,ToastLength.Short).Show();
					});
				}
				RunOnUiThread(()=>
				{
					myGuardianRefreshListView.OnRefreshComplete ();
					IsRefreshing = false;
				});

			});

		}
	}
}

