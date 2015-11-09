
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
using CommunityCenter.Common;
using Newtonsoft.Json;
using System.Threading.Tasks;
using CommunityCenter.Adapter;
using CommunityCenter.Param;
using CommunityCenter.Model.ServerType.Admin;
using CommunityCenter.Json;

namespace CommunityCenter.Activitys.ServerType.Admin
{
	[Activity (Theme="@style/MyCustomTheme")]			
	public class AlarmRecordsActivity : Activity,PullToRefreshBase.IOnRefreshListener2,Spinner.IOnItemSelectedListener,Android.Views.View.IOnFocusChangeListener
	{
		private AlarmInfoListAdapter alarmInfoAdapter;
		private string other_startTime_default, other_endTime_default;
		private PullToRefreshListView otherAlarmRefreshListView;
		private int lastY;
		private ListView actualListView;
		private EditText edit_other_startTime, edit_other_endTime;
		private Button btn_other_search;
		private Spinner sp_other_guardian;

		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private AlarmInfoListParam alarmInfoListParam;//请求参数对象

		private int pageIndex =1;//当前页码
		private RestSharpRequestHelp restSharpRequestHelp;
		private RestSharpRequestHelp restSharpGetMyUserRequestHelp;
		private int total;//总记录数
		private List<AlarmInfoListItem> alarmInfoLists = new List<AlarmInfoListItem>();

		private List<AllMyUserListItem> myUserLists;//我的监护人列表
		private SearchAllMyUserParam myUserParam = new SearchAllMyUserParam(){UserId = Global.Guid};//我的监护人请求参数对象
		private Dictionary<string,string> myUserRequestParams = new Dictionary<string, string>();//监护人web请求
		private ArrayAdapter<AllMyUserListItem> myUserListAdapter;
		private string myUserId;
		private bool btnSearchFlag = false;//监听是否点击查询
		private bool IsRefreshing = false;//是否正在获取数据
		/** 是否已被加载过一次，第二次就不再去请求数据了 */
		protected bool HasLoadedOnce;

		private Spinner sp_alarmType;//报警类型
		private List<AlarmTypeItem> alarmTypeList;
		private ArrayAdapter<AlarmTypeItem> alarmTypeAdapter;//报警类型适配器
		private string alarmTypeId;//选择的报警类型
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.AlarmRecordsLayout);
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
			tv_desc.Text = "报警记录";


			otherAlarmRefreshListView = FindViewById<PullToRefreshListView> (Resource.Id.lv_otherAlarm);
			actualListView = (ListView)otherAlarmRefreshListView.RefreshableView;
			//设置可以上拉加载。下拉刷新
			otherAlarmRefreshListView.Mode = PullToRefreshBase.PullToRefreshMode.Both;

			//下拉刷新提示文本
			otherAlarmRefreshListView.GetLoadingLayoutProxy(true,false).SetPullLabel(GetString(Resource.String.pullDownLbl));
			otherAlarmRefreshListView.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(GetString(Resource.String.pullDownRefreshLbl));
			otherAlarmRefreshListView.GetLoadingLayoutProxy (true, false).SetReleaseLabel (GetString(Resource.String.pullDownReleaseLbl));
			//上拉加载提示文本
			otherAlarmRefreshListView.GetLoadingLayoutProxy(false,true).SetPullLabel(GetString(Resource.String.pullUpLbl));
			otherAlarmRefreshListView.GetLoadingLayoutProxy (false, true).SetRefreshingLabel (GetString(Resource.String.pullUpRefreshLbl));
			otherAlarmRefreshListView.GetLoadingLayoutProxy (false, true).SetReleaseLabel (GetString(Resource.String.pullUpReleaseLbl));



			otherAlarmRefreshListView.SetOnRefreshListener (this);
	


			//加载view
			edit_other_startTime = FindViewById<EditText>(Resource.Id.edit_other_startTime);

			edit_other_startTime.OnFocusChangeListener = this;
			edit_other_startTime.InputType = Android.Text.InputTypes.Null;
			edit_other_endTime = FindViewById<EditText> (Resource.Id.edit_other_endTime);

			edit_other_endTime.OnFocusChangeListener = this;
			edit_other_endTime.InputType = Android.Text.InputTypes.Null;
			other_endTime_default = DateTime.Now.ToString ("yyyy-MM-dd");
			other_startTime_default = DateTime.Now.AddDays (-7).ToString ("yyyy-MM-dd");
			edit_other_startTime.Text = other_startTime_default;
			edit_other_endTime.Text = other_endTime_default;




			btn_other_search =FindViewById<Button> (Resource.Id.btn_other_search);
			//查询按钮
			btn_other_search.Click += (sender, e) => 
			{
				btnSearchFlag = true;
				loadData();
			};

			//下拉框
			sp_other_guardian = FindViewById<Spinner>(Resource.Id.sp_other_guardian);
			sp_other_guardian.OnItemSelectedListener = this;   
			sp_other_guardian.Visibility = ViewStates.Visible;//设置默认值


			//下拉框
			sp_alarmType = FindViewById<Spinner>(Resource.Id.sp_alarmType);
			sp_alarmType.OnItemSelectedListener = this;   
			sp_alarmType.Visibility = ViewStates.Visible;//设置默认值

			//设置自定义列表adapter		
			alarmInfoAdapter = new AlarmInfoListAdapter (this);
			actualListView.Adapter = alarmInfoAdapter;

			actualListView.ItemClick += (sender, e) => 
			{
				var intent  = new Intent(this,typeof(AlarmDetailInfoActivity));
				var bundle = new Bundle();
				bundle.PutString("alarmOrigin","alarmList");
				bundle.PutString("alarmId",alarmInfoAdapter.GetItem(e.Position-1).AId);
				intent.PutExtras(bundle);
				StartActivity(intent);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

			alarmInfoListParam =  new AlarmInfoListParam();
			//初始化view完成
			LasyloadData ();
		}

		public void OnFocusChange (View v, bool hasFocus)
		{
			if (hasFocus) {
				((EditText)v).ClearFocus ();
				var datepickdialog = new DatePickDialogUtil (this, ((EditText)v).Text);
				datepickdialog.DatePickDialogShow ((EditText)v);
			}
		}

		/// <summary>
		/// 初始化报警类型
		/// </summary>
		private void InitAlarmTypeSpinner()
		{
			alarmTypeList = new List<AlarmTypeItem> ()
			{
				new AlarmTypeItem(){AlarmTypeId="0",AlarmTypeDesc="PAUL报警"},new AlarmTypeItem(){AlarmTypeId="1",AlarmTypeDesc="摔倒报警"},
				new AlarmTypeItem(){AlarmTypeId="1002",AlarmTypeDesc="紧急求助报警"},new AlarmTypeItem(){AlarmTypeId="1003",AlarmTypeDesc="无活动报警"},
				new AlarmTypeItem(){AlarmTypeId="1011",AlarmTypeDesc="防盗报警"},new AlarmTypeItem(){AlarmTypeId="1012",AlarmTypeDesc="火灾报警"},
				new AlarmTypeItem(){AlarmTypeId="1013",AlarmTypeDesc="燃气泄漏报警"}
			};
			alarmTypeAdapter = new ArrayAdapter<AlarmTypeItem>(this,Android.Resource.Layout.SimpleSpinnerItem,alarmTypeList);
			alarmTypeAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
			sp_alarmType.Adapter = alarmTypeAdapter;
			sp_alarmType.SetSelection(0,true);
		}

		/// <summary>
		/// 设置我的监护人下拉框
		/// </summary>
		private void InitSpinner()
		{
			if (!myUserRequestParams.ContainsKey ("eUserId"))
				myUserRequestParams.Add ("eUserId", myUserParam.EuserId);
			else
				myUserRequestParams ["eUserId"] = myUserParam.EuserId;

			if (!myUserRequestParams.ContainsKey ("eaction"))
				myUserRequestParams.Add ("eaction", myUserParam.Eaction);
			else
				myUserRequestParams ["eaction"] = myUserParam.Eaction;

			if (!myUserRequestParams.ContainsKey ("md5"))
				myUserRequestParams.Add ("md5", myUserParam.Md5);
			else
				myUserRequestParams ["md5"] = myUserParam.Md5;

			if (!myUserRequestParams.ContainsKey ("key"))
				myUserRequestParams.Add ("key", myUserParam.Key);
			else
				myUserRequestParams ["key"] = myUserParam.Key;
			//设置restsharprequest
			if (restSharpGetMyUserRequestHelp == null)
				restSharpGetMyUserRequestHelp = new RestSharpRequestHelp (myUserParam.Url,myUserRequestParams);
			else
				restSharpGetMyUserRequestHelp.RequestParams = myUserRequestParams;
			restSharpGetMyUserRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var result = response.Content;
					var searchMyUserJson = JsonConvert.DeserializeObject<SearchAllMyUserJson>(result);
					if(searchMyUserJson.statuscode == "1")
					{

						myUserLists = searchMyUserJson.data;
						RunOnUiThread(()=>
						{
						    myUserListAdapter = new ArrayAdapter<AllMyUserListItem>(this,Android.Resource.Layout.SimpleSpinnerItem,myUserLists);
							myUserListAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
							sp_other_guardian.Adapter = myUserListAdapter;
							sp_other_guardian.SetSelection(0,true);
						});

					}

				}


			});

		}

		#region spinner 事件
		public  void OnItemSelected (AdapterView parent, View view, int position, long id)
		{
			if (parent.Id == Resource.Id.sp_other_guardian) {
				var userSelected = myUserListAdapter.GetItem (position);
				myUserId = userSelected.UId;
				parent.Visibility = ViewStates.Visible;

			} else if (parent.Id == Resource.Id.sp_alarmType) {
				var alarmTypeSelected = alarmTypeAdapter.GetItem (position);
				alarmTypeId = alarmTypeSelected.AlarmTypeId;
				parent.Visibility = ViewStates.Visible;
			}
			if(!string.IsNullOrEmpty(myUserId))
				//第一次进入设置自动刷新view
				otherAlarmRefreshListView.Refreshing = true;

		}
		public void OnNothingSelected (AdapterView parent)
		{

		}
		#endregion
		public  void LasyloadData ()
		{
			//填充报警方式类别
			InitAlarmTypeSpinner ();
			InitSpinner ();//填充我的监护人
		}


		private void loadData()
		{
			if(btnSearchFlag)
				ProgressDialogUtil.StartProgressDialog(this,"正在查询报警信息...",true);
			if (string.IsNullOrEmpty (myUserId)) {
				//未选择任何监护人
				RunOnUiThread (() => 
				{
					otherAlarmRefreshListView.OnRefreshComplete ();
					if(btnSearchFlag)
						ProgressDialogUtil.StopProgressDialog();
				});
				return;
			}
			pageIndex =1;
			UpdateAlarmInfoListParam ();

			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK )
				{
					var result = response.Content;
					var alarmlistInfoJson = JsonConvert.DeserializeObject<SearchAlarmInfoJson>(result);
					if(alarmlistInfoJson.statuscode == "1")
					{
						total =  alarmlistInfoJson.data.total;
						alarmInfoLists = alarmlistInfoJson.data.items;

						RunOnUiThread(()=>
						{
							alarmInfoAdapter.Clear();
							alarmInfoAdapter.AddAll(alarmInfoLists);
							alarmInfoAdapter.NotifyDataSetChanged();
							HasLoadedOnce = true;//加载第一次成功
						});

					}
					else
					{
						RunOnUiThread(()=>
						{
							Toast.MakeText(this,"获取报警列表信息错误",ToastLength.Short).Show();
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
					otherAlarmRefreshListView.OnRefreshComplete ();
					IsRefreshing = false;
					if(btnSearchFlag)
						ProgressDialogUtil.StopProgressDialog();
				});
			});

		}

		/// <summary>
		/// 更新参数请求对象
		/// </summary>
		private void UpdateAlarmInfoListParam()
		{
			alarmInfoListParam.UserId = myUserId;
			alarmInfoListParam.PageIndex = pageIndex.ToString();
			alarmInfoListParam.StartTime = string.IsNullOrEmpty( edit_other_startTime.Text)?other_startTime_default:edit_other_startTime.Text;
			alarmInfoListParam.EndTime = string.IsNullOrEmpty( edit_other_endTime.Text)?other_endTime_default:edit_other_endTime.Text;
			alarmInfoListParam.AlarmType = alarmTypeId;
			SetRestRequestParams ();
		}
		/// <summary>
		/// 设置参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestParams()
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", alarmInfoListParam.Key);
			else
				requestParams ["key"] = alarmInfoListParam.Key;

			if (!requestParams.ContainsKey ("eAlarmType"))
				requestParams.Add ("eAlarmType", alarmInfoListParam.EalarmType);
			else
				requestParams ["eAlarmType"] = alarmInfoListParam.EalarmType;

			if (!requestParams.ContainsKey ("eUserId"))
				requestParams.Add ("eUserId", alarmInfoListParam.EuserId);
			else
				requestParams ["eUserId"] = alarmInfoListParam.EuserId;

			if (!requestParams.ContainsKey ("eStartTime"))
				requestParams.Add ("eStartTime", alarmInfoListParam.EstartTime);
			else
				requestParams ["eStartTime"] = alarmInfoListParam.EstartTime;

			if (!requestParams.ContainsKey ("eEndTime"))
				requestParams.Add ("eEndTime", alarmInfoListParam.EendTime);
			else
				requestParams ["eEndTime"] = alarmInfoListParam.EendTime;

			if (!requestParams.ContainsKey ("ePageIndex"))
				requestParams.Add ("ePageIndex", alarmInfoListParam.EpageIndex);
			else
				requestParams ["ePageIndex"] = alarmInfoListParam.EpageIndex;

			if (!requestParams.ContainsKey ("ePageSize"))
				requestParams.Add ("ePageSize", alarmInfoListParam.EpageSize);
			else
				requestParams ["ePageSize"] = alarmInfoListParam.EpageSize;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", alarmInfoListParam.Eaction);
			else
				requestParams ["eaction"] = alarmInfoListParam.Eaction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", alarmInfoListParam.Md5);
			else
				requestParams ["md5"] = alarmInfoListParam.Md5;
			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (alarmInfoListParam.Url,requestParams);
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
				btnSearchFlag = false;
				Task.Factory.StartNew (() => {
					loadData ();
				});
			} else {
				otherAlarmRefreshListView.OnRefreshComplete ();
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
				btnSearchFlag = false;
				Task.Factory.StartNew (() => {
					//加载更多数据
					LoadMoreData ();
				});
			} else {
				otherAlarmRefreshListView.OnRefreshComplete ();
				IsRefreshing = false;
			}

		}

		/// <summary>
		/// Loads the more data.
		/// </summary>
		private void LoadMoreData()
		{
			lastY = alarmInfoLists.Count;
			pageIndex++;
			UpdateAlarmInfoListParam ();
			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var result = response.Content;
					var alarmlistInfoJson = JsonConvert.DeserializeObject<SearchAlarmInfoJson>(result);
					if(alarmlistInfoJson.statuscode == "1")
					{
						total =  alarmlistInfoJson.data.total;
						alarmInfoLists.AddRange(alarmlistInfoJson.data.items);
						RunOnUiThread(()=>
						{
							alarmInfoAdapter.AddAll(alarmlistInfoJson.data.items);
							alarmInfoAdapter.NotifyDataSetChanged();
							//讲listview滚动到上次加载位置
							actualListView.SetSelectionFromTop(lastY,(int)TrimMemory.Background);
						});
					}
					else
					{
						pageIndex --;
						RunOnUiThread(()=>
						{
							Toast.MakeText(this,"获取更多报警列表信息错误",ToastLength.Short).Show();
						});
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
					otherAlarmRefreshListView.OnRefreshComplete ();
					IsRefreshing = false;
				});
			});
		}
	}
}

