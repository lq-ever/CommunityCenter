
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
using CommunityCenter.Common;

namespace CommunityCenter.Activitys.ServerType
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class ServiceTimeActivity : Activity,Spinner.IOnItemSelectedListener,Android.Views.View.IOnFocusChangeListener
	{
		private Spinner sp_startWeek, sp_endWeek;
		private EditText edit_startTime, edit_endTime;
		private List<WeekItem> weekList;
		private ArrayAdapter<WeekItem> startWeekAdapter,endWeekAdapter;
		private string startWeek, endWeek,startTime,endTime;
		private Button btn_Confirm;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.ServiceTimeLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			InitView ();
		}
		/// <summary>
		/// Inits the view.
		/// </summary>
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
			tv_desc.Text = "设置服务时间";

			sp_startWeek = FindViewById<Spinner> (Resource.Id.sp_startWeek);
			sp_endWeek = FindViewById<Spinner> (Resource.Id.sp_endWeek);
			sp_startWeek.OnItemSelectedListener = this;   
			sp_startWeek.Visibility = ViewStates.Visible;//设置默认值
			sp_endWeek.OnItemSelectedListener = this;   
			sp_endWeek.Visibility = ViewStates.Visible;//设置默认值

			edit_startTime = FindViewById<EditText> (Resource.Id.edit_startTime);
			edit_endTime = FindViewById<EditText> (Resource.Id.edit_endTime);

			edit_startTime.OnFocusChangeListener = this;
			edit_startTime.InputType = Android.Text.InputTypes.Null;

			edit_endTime.OnFocusChangeListener = this;
			edit_endTime.InputType = Android.Text.InputTypes.Null;
			//初始化日期数据
			weekList = new List<WeekItem> () {
				new WeekItem (){ Week = WeekType.Monday, WeekDesc = "周一" },
				new WeekItem (){ Week = WeekType.Tuesday, WeekDesc = "周二" },
				new WeekItem (){ Week = WeekType.Wednesday, WeekDesc = "周三" },
				new WeekItem (){ Week = WeekType.Tuesday, WeekDesc = "周四" },
				new WeekItem (){ Week = WeekType.Friday, WeekDesc = "周五" },
				new WeekItem (){ Week = WeekType.Saturday, WeekDesc = "周六" },
				new WeekItem (){ Week = WeekType.Sunday, WeekDesc = "周日" }

			};
			//初始化下拉框
			InitWeekSpinner();
			btn_Confirm.Click += (sender, e) => 
			{
				var intent = new Intent();
				intent.PutExtra("startweek",startWeek);
				intent.PutExtra("endweek",endWeek);
				intent.PutExtra("starttime",startTime);
				intent.PutExtra("endtime",endTime);
				//todo:调用webservice提交服务器
				SetResult(Result.Ok,intent);
				this.Finish();
			};
		}

		/// <summary>
		/// 时间框选中时间
		/// </summary>
		/// <param name="v">V.</param>
		/// <param name="hasFocus">If set to <c>true</c> has focus.</param>
		public void OnFocusChange (View v, bool hasFocus)
		{
			if (hasFocus) {
				((EditText)v).ClearFocus ();
				var datepickdialog = new DatePickDialogUtil (this, ((EditText)v).Text);
				datepickdialog.DatePickDialogShow ((EditText)v);
			}
		}

		/// <summary>
		/// 初始化下拉框周数据
		/// </summary>
		private void InitWeekSpinner()
		{
			//开始周
			startWeekAdapter = new ArrayAdapter<WeekItem>(this,Android.Resource.Layout.SimpleSpinnerItem,weekList);
			startWeekAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
			sp_startWeek.Adapter = startWeekAdapter;
			sp_startWeek.SetSelection(0,true);
			//结束周
			startWeekAdapter = new ArrayAdapter<WeekItem>(this,Android.Resource.Layout.SimpleSpinnerItem,weekList);
			startWeekAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
			sp_startWeek.Adapter = startWeekAdapter;
			sp_startWeek.SetSelection(0,true);

		}

		#region spinner 事件
		public  void OnItemSelected (AdapterView parent, View view, int position, long id)
		{
			if (parent.Id == Resource.Id.sp_startWeek) {

				startWeek= startWeekAdapter.GetItem (position).WeekDesc;
				parent.Visibility = ViewStates.Visible;

			} else if (parent.Id == Resource.Id.sp_endWeek) {

				endWeek = endWeekAdapter.GetItem (position).WeekDesc;
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

