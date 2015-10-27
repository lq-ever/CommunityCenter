
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
using Android.Support.V4.View;
using CommunityCenter.Adapter;

namespace CommunityCenter
{
	[Activity (Theme ="@style/AppTheme")]			
	public class GuiderActivity : Activity,ViewPager.IOnPageChangeListener,View.IOnClickListener
	{
		private ViewPager guiderViewpager;
		private GuiderViewPageAdapter vpAdapter;
		//底部小图片
		private ImageView[] dots;
		private List<View> views;
		//当前选中位置
		private int currentIndex;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Create your application here
			SetContentView (Resource.Layout.Guider);
			// 初始化页面
			InitViews();
			InitDots ();
		}
		private void InitViews()
		{
			LayoutInflater inflater = LayoutInflater.From (this);
			//初始化引导图片列表
			views = new List<View>();
			views.Add (inflater.Inflate (Resource.Layout.Guider1, null));
			views.Add (inflater.Inflate(Resource.Layout.Guider2,null));
			views.Add (inflater.Inflate(Resource.Layout.Guider3,null));
			views.Add (inflater.Inflate(Resource.Layout.Guider4,null));

			vpAdapter = new GuiderViewPageAdapter (views, this);
			guiderViewpager = FindViewById<ViewPager> (Resource.Id.guiderviewpager);
			guiderViewpager.Adapter = vpAdapter;
			//绑定回调
			guiderViewpager.AddOnPageChangeListener (this);
		
		}

		private void InitDots()
		{
			var dotimagelayout = FindViewById<LinearLayout> (Resource.Id.dotImageLayout);
			dots = new ImageView[views.Count];
			//循环取得小点图片
			for (int i = 0; i < views.Count; i++) {
				dots [i] = (ImageView)dotimagelayout.GetChildAt (i);
				dots [i].Enabled = true;//设置为灰色
				dots[i].SetOnClickListener(this);
				dots[i].Tag = i;
			}
			currentIndex = 0;
			dots [currentIndex].Enabled = false;//设置为白色，选中状态
		}

		/// <summary>
		/// 设置当前引导点的选中
		/// </summary>
		/// <param name="position">Position.</param>
		private void SetCurrentDot(int position)
		{
			if (position < 0 || position > views.Count - 1 || currentIndex == position)
				return;
			dots [position].Enabled = false;
			dots [currentIndex].Enabled = true;
			currentIndex = position;

		}

		/// <summary>
		/// 设置当前引导页
		/// </summary>
		/// <param name="position">Position.</param>
		private void SetCurView(int position)
		{
			if (position < 0 || position >= dots.Length)
				return;

			guiderViewpager.SetCurrentItem (position,true);
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
			SetCurrentDot (position);
		}
		#endregion

		/// <summary>
		/// 底部图片选中
		/// </summary>
		/// <param name="v">V.</param>
		public void OnClick(View v)
		{
			SetCurView ((int) v.Tag);
			SetCurrentDot ((int)v.Tag);
		}
	}
}

