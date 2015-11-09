
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
using CommunityCenter.Model.Finance;

namespace CommunityCenter.Activitys.Finance
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class ChooseDealRecordConditionActivity : Activity,Spinner.IOnItemSelectedListener
	{
		private EditText edit_deal_startTime,edit_deal_endTime;
		private Button btn_today,btn_week,btn_month,btn_threemonth,btn_confirm;
		private Spinner sp_deal_status,sp_deal_type;
		private string dealStartTime,dealEndTime,dealStatus,dealType;
		private ArrayAdapter<DealStatusItem> dealStatusAdapter;
		private ArrayAdapter<DealTypeItem> dealTypeAdapter;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.ChooseDealRecordsConditionLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			InitView ();
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
			tv_back.Text = "关闭";
			var tv_desc = FindViewById<TextView> (Resource.Id.tv_desc);
			tv_desc.Text = "交易记录条件";

			edit_deal_startTime = FindViewById<EditText> (Resource.Id.edit_deal_startTime);
			edit_deal_endTime = FindViewById<EditText> (Resource.Id.edit_deal_endTime);
			btn_today = FindViewById<Button> (Resource.Id.btn_today);
			btn_week = FindViewById<Button> (Resource.Id.btn_week);
			btn_month = FindViewById<Button> (Resource.Id.btn_month);
			btn_threemonth = FindViewById<Button> (Resource.Id.btn_threemonth);
			btn_confirm = FindViewById<Button> (Resource.Id.btn_confirm);
			//配置下拉选中条件
			sp_deal_status = FindViewById<Spinner> (Resource.Id.sp_deal_status);
			sp_deal_type = FindViewById<Spinner> (Resource.Id.sp_deal_type);


			sp_deal_status.OnItemSelectedListener = this;   
			sp_deal_status.Visibility = ViewStates.Visible;//设置默认值

			sp_deal_type.OnItemSelectedListener = this;   
			sp_deal_type.Visibility = ViewStates.Visible;//设置默认值

			//交易时间赋初始值
			edit_deal_startTime.Text= DateTime.Now.ToString ("yyyy-MM-dd");
			edit_deal_endTime.Text = DateTime.Now.AddDays (1).ToString ("yyyy-MM-dd");
			//时间按钮选择
			btn_today.Click += (sender, e) => 
			{
				edit_deal_startTime.Text= DateTime.Now.ToString ("yyyy-MM-dd");
				edit_deal_endTime.Text = DateTime.Now.AddDays (1).ToString ("yyyy-MM-dd");
			};
			btn_week.Click += (sender, e) => 
			{
				edit_deal_startTime.Text= DateTime.Now.AddDays (-7).ToString ("yyyy-MM-dd");
				edit_deal_endTime.Text = DateTime.Now.ToString ("yyyy-MM-dd");
			};
			btn_month.Click += (sender, e) => 
			{
				edit_deal_startTime.Text= DateTime.Now.AddMonths (-1).ToString ("yyyy-MM-dd");
				edit_deal_endTime.Text = DateTime.Now.ToString ("yyyy-MM-dd");
			};
			btn_threemonth.Click += (sender, e) => 
			{
				edit_deal_startTime.Text= DateTime.Now.AddMonths (-3).ToString ("yyyy-MM-dd");
				edit_deal_endTime.Text = DateTime.Now.ToString ("yyyy-MM-dd");
			};
			//确认按钮
			btn_confirm.Click += (sender, e) => 
			{
				var intent = new Intent();
				intent.PutExtra("dealStatus",dealStatus);
				intent.PutExtra("dealType",dealType);
				intent.PutExtra("dealStarttime",dealStartTime);
				intent.PutExtra("dealEndtime",dealEndTime);
				SetResult(Result.Ok,intent);
				this.Finish();
			};

			//赋值下拉框
			InitDealStatus();
			InitDealType ();
		}
		/// <summary>
		/// 初始化交易状态
		/// </summary>
		private void InitDealStatus()
		{
			//todo:调用webservice获取,暂用假数据
			var dealStatusList = new List<DealStatusItem> ()
			{
				new DealStatusItem(){DealStatusId="0",DealStatusDesc="全部"},new DealStatusItem(){DealStatusId="1",DealStatusDesc="交易成功"},
				new DealStatusItem(){DealStatusId="2",DealStatusDesc="交易中"},new DealStatusItem(){DealStatusId="3",DealStatusDesc="交易失败"}
			};
			dealStatusAdapter = new ArrayAdapter<DealStatusItem>(this,Android.Resource.Layout.SimpleSpinnerItem,dealStatusList);
			dealStatusAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
			sp_deal_status.Adapter = dealStatusAdapter;
			sp_deal_status.SetSelection(0,true);
		}
		/// <summary>
		/// 初始化交易分类
		/// </summary>
		private void InitDealType()
		{
			//todo:调用webservice获取,暂用假数据
			var dealTypeList = new List<DealTypeItem> ()
			{
				new DealTypeItem(){DealTypeId="0",DealTypeDesc="全部"},new DealTypeItem(){DealTypeId="1",DealTypeDesc="提现"},
				new DealTypeItem(){DealTypeId="2",DealTypeDesc="充值"},new DealTypeItem(){DealTypeId="3",DealTypeDesc="购物"},
				new DealTypeItem(){DealTypeId="4",DealTypeDesc="水电费"},new DealTypeItem(){DealTypeId="5",DealTypeDesc="话费"},
				new DealTypeItem(){DealTypeId="6",DealTypeDesc="宽带费"},new DealTypeItem(){DealTypeId="7",DealTypeDesc="有限电视费"},
				new DealTypeItem(){DealTypeId="8",DealTypeDesc="加油卡充值"}
			};
			dealTypeAdapter = new ArrayAdapter<DealTypeItem>(this,Android.Resource.Layout.SimpleSpinnerItem,dealTypeList);
			dealStatusAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
			sp_deal_type.Adapter = dealTypeAdapter;
			sp_deal_type.SetSelection(0,true);
		}

		#region spinner 事件
		public  void OnItemSelected (AdapterView parent, View view, int position, long id)
		{
			if (parent.Id == Resource.Id.sp_deal_status) {
				dealStatus = dealStatusAdapter.GetItem (position).DealStatusId;
				parent.Visibility = ViewStates.Visible;

			} else if (parent.Id == Resource.Id.sp_deal_type) {
				dealType = dealTypeAdapter.GetItem (position).DealTypeId;
				parent.Visibility = ViewStates.Visible;
			}

		}
		public void OnNothingSelected (AdapterView parent)
		{

		}

		#endregion

		public override void OnBackPressed ()
		{
			SetResult(Result.Canceled);
			base.OnBackPressed ();
		}

	}
}

