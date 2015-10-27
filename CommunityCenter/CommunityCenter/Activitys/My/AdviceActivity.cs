
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.View;

using Android.Util;
using Android.Views.Animations;

using Android.Support.V4.App;
using Android.App;
using CommunityCenter.Fragments.Advice;
using CommunityCenter.Adapter;



namespace CommunityCenter.Activitys.My
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class AdviceActivity : FragmentActivity,ViewPager.IOnPageChangeListener,View.IOnClickListener
	{
		private ViewPager adviceViewPager;
		private List<Android.Support.V4.App.Fragment> fragmentsList;
		private ImageView ivBottomLine;
		private Button tab_btn_writeAdvice, tab_btn_recordAdvice;
		private int currentIndex = 0;
		private int bottomLineWidth;
		private int offset = 0;
		private int position_one;
		public  static int num = 2 ;
		WriteAdviceFragment _writeAdviceFrag;
		RecordAdviceFragment _recordAdviceFrag;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.AdviceLayout);
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
			var tv_header_title = FindViewById<TextView> (Resource.Id.tv_header_title);
			tv_header_title.Text = "投诉建议";
			InitWidth();
			InitTabBtnView();
			InitViewPager();
			TranslateAnimation animation = new TranslateAnimation(position_one, offset, 0, 0){FillAfter = true,Duration = 300};
			ivBottomLine.StartAnimation(animation);
		}
		private void InitTabBtnView( ) {
			tab_btn_writeAdvice = FindViewById<Button>(Resource.Id.tab_btn_writeAdvice);
			tab_btn_recordAdvice = FindViewById<Button>(Resource.Id.tab_btn_recordAdvice);
			tab_btn_writeAdvice.SetTextColor(Resources.GetColor(Resource.Color.blue));

			tab_btn_writeAdvice.SetOnClickListener(this);
			tab_btn_recordAdvice.SetOnClickListener(this);
		}

		private void InitViewPager() {
			adviceViewPager = (ViewPager) FindViewById<ViewPager>(Resource.Id.adviceViewPager);
			fragmentsList = new List<Android.Support.V4.App.Fragment>();

			_writeAdviceFrag = new WriteAdviceFragment();
			_recordAdviceFrag = new RecordAdviceFragment();

			fragmentsList.Add(_writeAdviceFrag);
			fragmentsList.Add(_recordAdviceFrag);

			//关闭预加载，默认一次只加载一个Fragment
			adviceViewPager.OffscreenPageLimit =1;

			adviceViewPager.Adapter = new ViewFragmentPagerAdapter(fragmentsList,SupportFragmentManager);
			adviceViewPager.AddOnPageChangeListener (this);
			adviceViewPager.SetCurrentItem (0, true);

		}

		private void InitWidth() {
			ivBottomLine = FindViewById<ImageView>(Resource.Id.iv_bottom_line);
			bottomLineWidth = ivBottomLine.LayoutParameters.Width;
			DisplayMetrics dm = new DisplayMetrics();

			WindowManager.DefaultDisplay.GetMetrics(dm);
			int screenW = dm.WidthPixels;
			offset = (int) ((screenW / num - bottomLineWidth) / 2);
			int avg = (int) (screenW / num);

			position_one = avg + offset;
		}
		#region 实现IOnPageChangeListener接口
		public  void  OnPageScrollStateChanged (int state)
		{

		}

		public  void OnPageScrolled(int arg0, float arg1, int arg2) {

		}

		/// <summary>
		/// 新的页面被选中调用
		/// </summary>
		/// <param name="position">Position.</param>
		public void OnPageSelected(int position)
		{
			Animation animation = null;
			switch (position)
			{
			case 0:
				if (currentIndex == 1) {
					animation = new TranslateAnimation (position_one, offset, 0, 0);
					tab_btn_writeAdvice.SetTextColor (Resources.GetColor (Resource.Color.blue));
				} 

				tab_btn_recordAdvice.SetTextColor (Resources.GetColor (Resource.Color.darkgray));

				break;
			case 1:
				if (currentIndex == 0) {
					animation = new TranslateAnimation (offset, position_one, 0, 0);
					tab_btn_recordAdvice.SetTextColor (Resources.GetColor (Resource.Color.blue));
				} 
				tab_btn_writeAdvice.SetTextColor (Resources.GetColor(Resource.Color.darkgray));
				break;
			}

			animation.FillAfter = true;
			animation.Duration = 300;
			ivBottomLine.StartAnimation (animation);
			currentIndex = position;
		}
		#endregion


		#region 重写IOnClickListener接口
		/// <summary>
		/// 触发回调函数
		/// </summary>
		/// <param name="v">V.</param>
		public void  OnClick (View v)
		{
			int position = 0;
			switch (v.Id) {
			case Resource.Id.tab_btn_writeAdvice:
				position = 0;
				SetCurView (position);
				break;
			case Resource.Id.tab_btn_recordAdvice:
				position = 1;
				SetCurView (position);
				break;
			default:
				break;
			}
			currentIndex = position;
		}
		#endregion

		/// <summary>
		/// 设置当前页
		/// </summary>
		/// <param name="position">Position.</param>
		private void SetCurView(int position)
		{
			if (position < 0 || position >= fragmentsList.Count)
				return;
			adviceViewPager.SetCurrentItem (position,true);
		}

	}
}

