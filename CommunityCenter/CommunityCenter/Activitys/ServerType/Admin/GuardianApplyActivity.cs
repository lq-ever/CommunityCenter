
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
using Newtonsoft.Json;

using Com.Nostra13.Universalimageloader.Core.Listener;
using Com.Nostra13.Universalimageloader.Core;
using CommunityCenter.Adapter;
using CommunityCenter.Common;
using CommunityCenter.Param;
using CommunityCenter.Json;

namespace CommunityCenter.Activitys.ServerType.Admin
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class GuardianApplyActivity : Activity,PullToRefreshBase.IOnRefreshListener
	{
		private GetApplyInfoListAadapter getApplyInfoAdapter;
		private PullToRefreshListView guardianApplyRefreshListView;


		private ListView actualListView;
		private RestSharpRequestHelp restSharpRequestHelp;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private GetApplyInfoParam getApplyInfoParam;//请求参数对象

		private bool IsPrepared;
		protected bool HasLoadedOnce;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.GuardianApplyLayout);
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
			tv_back.Text = "管理员";
			var tv_desc = FindViewById<TextView> (Resource.Id.tv_desc);
			tv_desc.Text = "绑定申请";


			guardianApplyRefreshListView = FindViewById<PullToRefreshListView> (Resource.Id.lv_guardianApply);
			actualListView = (ListView)guardianApplyRefreshListView.RefreshableView;

			//设置可以上拉加载。下拉刷新
			guardianApplyRefreshListView.Mode = PullToRefreshBase.PullToRefreshMode.PullFromStart;
			//下拉刷新提示文本
			guardianApplyRefreshListView.GetLoadingLayoutProxy(true,false).SetPullLabel(GetString(Resource.String.pullDownLbl));
			guardianApplyRefreshListView.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(GetString(Resource.String.pullDownRefreshLbl));
			guardianApplyRefreshListView.GetLoadingLayoutProxy (true, false).SetReleaseLabel (GetString(Resource.String.pullDownReleaseLbl));

			guardianApplyRefreshListView.SetOnRefreshListener (this);

			//设置adapter		
			getApplyInfoAdapter = new GetApplyInfoListAadapter (this);
			actualListView.Adapter = getApplyInfoAdapter;
			//设置滑动listview停止加载图片
			actualListView.SetOnScrollListener (new PauseOnScrollListener(Global.imageLoader,false,false));
			getApplyInfoParam = new GetApplyInfoParam (){ Id = Global.Guid };
			//初始化view完成
			IsPrepared = true;
			LasyloadData ();

		}
		public override void OnWindowFocusChanged (bool hasFocus)
		{
			base.OnWindowFocusChanged (hasFocus);
			if (hasFocus && HasLoadedOnce) {
				LasyloadData();
			}
		}
		private void LasyloadData()
		{
			if (!IsPrepared)
				return;
			//第一次进入设置自动刷新view
			guardianApplyRefreshListView.Refreshing = true;
		}
		/// <summary>
		/// 加载数据
		/// </summary>
		private void loadData()
		{
			//检测网络连接
			if(!EldYoungUtil.IsConnected(this))
			{
				Toast.MakeText(this,"网络连接超时,请检测网络",ToastLength.Short).Show();
				return;
			}
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", getApplyInfoParam.Key);
			else
				requestParams ["key"] = getApplyInfoParam.Key;
			
			if (!requestParams.ContainsKey ("eId"))
				requestParams.Add ("eId", getApplyInfoParam.Eid);
			else
				requestParams ["eId"] = getApplyInfoParam.Eid;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", getApplyInfoParam.Eaction);
			else
				requestParams ["eaction"] = getApplyInfoParam.Eaction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", getApplyInfoParam.Md5);
			else
				requestParams ["md5"] = getApplyInfoParam.Md5;
			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (getApplyInfoParam.Url,requestParams);
			else
				restSharpRequestHelp.RequestParams = requestParams;
			
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					
					var result = response.Content;
					var getApplyInfoJson = JsonConvert.DeserializeObject<GetApplyInfoJson>(result);
					if(getApplyInfoJson.statuscode =="1")
					{
						RunOnUiThread(()=>
							{
								getApplyInfoAdapter.Clear();//清空所有数据
								getApplyInfoAdapter.AddAll(getApplyInfoJson.data);
								getApplyInfoAdapter.NotifyDataSetChanged();
								guardianApplyRefreshListView.OnRefreshComplete ();
								HasLoadedOnce = true;
								
							});
					}
					else
					{
						RunOnUiThread(()=>
							{
								Toast.MakeText(this,"获取监护申请信息失败,稍后在试...",ToastLength.Short).Show();
								guardianApplyRefreshListView.OnRefreshComplete ();
								return;
							});
					}


				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					RunOnUiThread(()=>
						{
							Toast.MakeText(this,"网络连接超时,稍后在试...",ToastLength.Short).Show();
							guardianApplyRefreshListView.OnRefreshComplete ();
							return;
						});
				}
				else
				{
					RunOnUiThread(()=>
						{
							Toast.MakeText(this,response.StatusDescription,ToastLength.Short).Show();
							guardianApplyRefreshListView.OnRefreshComplete ();
							return;
						});
				}
			});
		}

		public void OnRefresh (PullToRefreshBase p0)
		{
			Task.Factory.StartNew (() => {
				loadData();
			});

		}
	}
}

