
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
using Com.Handmark.Pulltorefresh.Library;
using System.Threading.Tasks;
using Newtonsoft.Json;

using System.Threading;
using CommunityCenter;
using CommunityCenter.Model;
using CommunityCenter.Common;
using CommunityCenter.Adapter;
using CommunityCenter.Param;
using CommunityCenter.Json;

namespace CommunityCenter.Fragments.Advice
{
	public class RecordAdviceFragment : BaseFragment,Android.Widget.RadioGroup.IOnCheckedChangeListener,PullToRefreshBase.IOnRefreshListener2
	{
		private RadioGroup radio_advice_Group;
		private RadioButton rbtn_all, rbtn_zixun, rbtn_jianyi, rbtn_tousu, rbtn_other;
		private TextView tv_recordNum;
		private string _adviceType = ((int)AdviceType.All).ToString();//默认咨询建议类型

		private AdviceRecordListAdapter adviceRecordListAdapter;
		private PullToRefreshListView lv_recordAdviceRefreshListView;
		private int lastY;
		private ListView actualListView;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();

		private AdviceRecordInfoListParam adviceRecordInfoListParam;//请求参数对象

		private int pageIndex =1;//当前页码
		private RestSharpRequestHelp restSharpRequestHelp;
		private int total;//总记录数
		private List<AdviceRecordInfoItem> adviceRecordLists = new List<AdviceRecordInfoItem>();


		private bool IsRefreshing = false;//是否正在获取数据
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
			var recordAdviceView = inflater.Inflate (Resource.Layout.RecordAdviceLayout,container,false);
			return recordAdviceView;
		}
		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			//radiogroup
			radio_advice_Group = View.FindViewById<RadioGroup> (Resource.Id.radio_advice_Group);
			radio_advice_Group.SetOnCheckedChangeListener (this);
			//radiobutton
			rbtn_all  = View.FindViewById<RadioButton>(Resource.Id.rbtn_all);
			rbtn_all.Tag = ((int)AdviceType.All).ToString();
			//默认咨询选中
			rbtn_all.Checked = true;
			rbtn_zixun = View.FindViewById<RadioButton> (Resource.Id.rbtn_zixun);
			rbtn_zixun.Tag = ((int)AdviceType.Consult).ToString();
			rbtn_jianyi = View.FindViewById<RadioButton> (Resource.Id.rbtn_jianyi);
			rbtn_jianyi.Tag = ((int)AdviceType.Suggest).ToString();
			rbtn_tousu = View.FindViewById<RadioButton> (Resource.Id.rbtn_tousu);
			rbtn_tousu.Tag = ((int)AdviceType.Complain).ToString();
			rbtn_other = View.FindViewById<RadioButton> (Resource.Id.rbtn_other);
			rbtn_other.Tag = ((int)AdviceType.Other).ToString();
			tv_recordNum = View.FindViewById<TextView> (Resource.Id.tv_recordNum);
			//pulltolistview
			lv_recordAdviceRefreshListView = View.FindViewById<PullToRefreshListView> (Resource.Id.lv_recordAdvice);
			actualListView = (ListView)lv_recordAdviceRefreshListView.RefreshableView;

			//设置可以上拉加载。下拉刷新
			lv_recordAdviceRefreshListView.Mode = PullToRefreshBase.PullToRefreshMode.Both;
			//下拉刷新提示文本
			lv_recordAdviceRefreshListView.GetLoadingLayoutProxy(true,false).SetPullLabel(GetString(Resource.String.pullDownLbl));
			lv_recordAdviceRefreshListView.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(GetString(Resource.String.pullDownRefreshLbl));
			lv_recordAdviceRefreshListView.GetLoadingLayoutProxy (true, false).SetReleaseLabel (GetString(Resource.String.pullDownReleaseLbl));
			//上拉加载提示文本
			lv_recordAdviceRefreshListView.GetLoadingLayoutProxy(false,true).SetPullLabel(GetString(Resource.String.pullUpLbl));
			lv_recordAdviceRefreshListView.GetLoadingLayoutProxy (false, true).SetRefreshingLabel (GetString(Resource.String.pullUpRefreshLbl));
			lv_recordAdviceRefreshListView.GetLoadingLayoutProxy (false, true).SetReleaseLabel (GetString(Resource.String.pullUpReleaseLbl));
	

			//绑定监听事件
			lv_recordAdviceRefreshListView.SetOnRefreshListener (this);

			//设置adapter		
			adviceRecordListAdapter = new AdviceRecordListAdapter (Activity);
			actualListView.Adapter = adviceRecordListAdapter;
			//初始化请求参数信息
			adviceRecordInfoListParam = new AdviceRecordInfoListParam () {
				UId = Global.Guid,
				AdviceType = _adviceType
			};
			//初始化view完成
			IsPrepared = true;
			LasyloadData ();
		}
		/// <summary>
		/// radiogroup的选择切换事件
		/// </summary>
		/// <param name="group">Group.</param>
		/// <param name="checkedId">Checked identifier.</param>
		public void OnCheckedChanged (RadioGroup group, int checkedId)
		{
			_adviceType = View.FindViewById<RadioButton> (checkedId).Tag.ToString();
			//留言类型切换设置自动刷新view
			lv_recordAdviceRefreshListView.Refreshing = true;
		}

		public override void LasyloadData ()
		{
			if (!IsPrepared || !IsVisible)
				return;
			//第一次进入设置自动刷新view
			lv_recordAdviceRefreshListView.Refreshing = true;
		}

		/// <summary>
		/// 监听下拉刷新事件
		/// </summary>
		/// <param name="p0">P0.</param>
		public void OnPullDownToRefresh (PullToRefreshBase p0)
		{
			if (!IsRefreshing) {
				IsRefreshing = true;

				LoadData ();
			} else {
				lv_recordAdviceRefreshListView.OnRefreshComplete ();
				IsRefreshing = false;
			}

		}
		/// <summary>
		/// 初始化数据
		/// </summary>
		private void LoadData()
		{
			pageIndex =1;
			UpdateAdviceInfoListParam ();
			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {

				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var result = response.Content;
					var adviceRecordInfoJson = JsonConvert.DeserializeObject<AdviceRecordInfoJson>(result);
					if(adviceRecordInfoJson.statuscode == "1")
					{

						total =  adviceRecordInfoJson.data.total;
						adviceRecordLists = adviceRecordInfoJson.data.items;

						Activity.RunOnUiThread(()=>
							{
								tv_recordNum.Text = total.ToString();
								adviceRecordListAdapter.Clear();//清空所有数据

								adviceRecordListAdapter.AddAll(adviceRecordLists);
								adviceRecordListAdapter.NotifyDataSetChanged();
								HasLoadedOnce = true;//加载第一次成功

							});

					}
					else
					{
						Activity.RunOnUiThread(()=>
							{
								Toast.MakeText(Activity,"获取报警留言信息错误",ToastLength.Short).Show();
							});
					}
					
				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,"网络连接超时,稍后在试...",ToastLength.Short).Show();
						});
				}
				else
				{
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,response.StatusDescription,ToastLength.Short).Show();
						});
				}
				Activity.RunOnUiThread(()=>
					{
						lv_recordAdviceRefreshListView.OnRefreshComplete ();
						IsRefreshing = false;
					});
			});

		}
		/// <summary>
		/// 更新参数请求对象
		/// </summary>
		private void UpdateAdviceInfoListParam()
		{
			adviceRecordInfoListParam.PageIndex = pageIndex.ToString();
			adviceRecordInfoListParam.AdviceType = _adviceType;
			SetRestRequestParams ();
		}

		/// <summary>
		/// 设置参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestParams()
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", adviceRecordInfoListParam.Key);
			else
				requestParams ["key"] = adviceRecordInfoListParam.Key;

			if (!requestParams.ContainsKey ("eAdviceType"))
				requestParams.Add ("eAdviceType", adviceRecordInfoListParam.EadviceType);
			else
				requestParams ["eAdviceType"] = adviceRecordInfoListParam.EadviceType;
			
			if (!requestParams.ContainsKey ("ePlatformType"))
				requestParams.Add ("ePlatformType", adviceRecordInfoListParam.EplatformType);
			else
				requestParams ["ePlatformType"] = adviceRecordInfoListParam.EplatformType;

			if (!requestParams.ContainsKey ("eUserId"))
				requestParams.Add ("eUserId", adviceRecordInfoListParam.Euid);
			else
				requestParams ["eUserId"] = adviceRecordInfoListParam.Euid;
			if (!requestParams.ContainsKey ("ePageIndex"))
				requestParams.Add ("ePageIndex", adviceRecordInfoListParam.EpageIndex);
			else
				requestParams ["ePageIndex"] = adviceRecordInfoListParam.EpageIndex;

			if (!requestParams.ContainsKey ("ePageSize"))
				requestParams.Add ("ePageSize", adviceRecordInfoListParam.EpageSize);
			else
				requestParams ["ePageSize"] = adviceRecordInfoListParam.EpageSize;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", adviceRecordInfoListParam.Eaction);
			else
				requestParams ["eaction"] = adviceRecordInfoListParam.Eaction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", adviceRecordInfoListParam.Md5);
			else
				requestParams ["md5"] = adviceRecordInfoListParam.Md5;
			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (adviceRecordInfoListParam.Url,requestParams);
			else
				restSharpRequestHelp.RequestParams = requestParams;


					
		}
		/// <summary>
		/// 监听上拉加载更多事件
		/// </summary>
		/// <param name="p0">P0.</param>
		public void OnPullUpToRefresh (PullToRefreshBase p0)
		{
			if (!IsRefreshing) {
				IsRefreshing = true;
				LoadMoreData ();
			} else {
				lv_recordAdviceRefreshListView.OnRefreshComplete ();
				IsRefreshing = false;
			}

		}

		/// <summary>
		/// 获取更多数据
		/// </summary>
		private void LoadMoreData()
		{
			lastY = adviceRecordLists.Count;
			pageIndex++;
			UpdateAdviceInfoListParam ();
			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{

					var result = response.Content;
					var adviceRecordInfoJson = JsonConvert.DeserializeObject<AdviceRecordInfoJson>(result);
					if(adviceRecordInfoJson.statuscode == "1")
					{
						total =  adviceRecordInfoJson.data.total;
						adviceRecordLists.AddRange(adviceRecordInfoJson.data.items);

						Activity.RunOnUiThread(()=>
							{
								tv_recordNum.Text = total.ToString();
								adviceRecordListAdapter.AddAll(adviceRecordInfoJson.data.items);
								adviceRecordListAdapter.NotifyDataSetChanged();
								//讲listview滚动到上次加载位置
								actualListView.SetSelectionFromTop(lastY,(int)TrimMemory.Background);
							});
						
					}
					else
					{
						pageIndex--;
						Activity.RunOnUiThread(()=>
							{
								Toast.MakeText(Activity,"获取更多留言信息错误",ToastLength.Short).Show();
							});
					}
				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					pageIndex--;
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,"网络连接超时,稍后在试...",ToastLength.Short).Show();
						});
				}
				else
				{
					pageIndex--;
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,response.StatusDescription,ToastLength.Short).Show();
						});
				}
				Activity.RunOnUiThread(()=>
					{

						lv_recordAdviceRefreshListView.OnRefreshComplete ();
						IsRefreshing = false;
					});
			});
		}
	}
}

