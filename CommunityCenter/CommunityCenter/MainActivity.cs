using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using CommunityCenter.Fragments.MainTab;
using CommunityCenter.Activitys.ServerType.Admin;


namespace CommunityCenter
{
	[Activity (Theme= "@style/AppTheme")]
	public class MainActivity : FragmentActivity,View.IOnClickListener
	{
		private MainTabServerFragment _serverFrag;
		private MainTabMyFragment _myFrag;
		private MainTabFinanceFragment _financeFrag;

		//底部布局
		private LinearLayout ll_tab_bottom_server,ll_tab_bottom_my,ll_tab_bottom_finance;
		//底部按钮
		private ImageButton btn_tab_bottom_server,btn_tab_bottom_my,btn_tab_bottom_finance;
		//底部文本
		private TextView tv_tab_bottom_server,tv_tab_bottom_my,tv_tab_bottom_finance;

		private Dialog exitDialog;

		//使用fragmentManager管理
		private Android.Support.V4.App.FragmentManager fragmentManager;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			fragmentManager = SupportFragmentManager;
			InitViews ();
			//设置第一个选中
			SetTabSections (0);

			//如果是通过点击报警通知过来，直接跳转到报警详细界面
			var alarmbundle1= Intent.Extras;
			if (alarmbundle1 != null) {
				var alarmInfoIntent = new Intent(this,typeof(AlarmDetailInfoActivity));
				alarmInfoIntent.PutExtras (alarmbundle1);
				StartActivity (alarmInfoIntent);
				OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);
			}
		}

		/// <summary>
		/// 初始化
		/// </summary>
		private void InitViews()
		{
			ll_tab_bottom_server = FindViewById<LinearLayout> (Resource.Id.ll_tab_bottom_server);
			ll_tab_bottom_my = FindViewById<LinearLayout> (Resource.Id.ll_tab_bottom_my);
			ll_tab_bottom_finance = FindViewById<LinearLayout> (Resource.Id.ll_tab_bottom_finance);
			btn_tab_bottom_server = ll_tab_bottom_server.FindViewById<ImageButton> (Resource.Id.btn_tab_bottom_server);
			tv_tab_bottom_server = ll_tab_bottom_server.FindViewById<TextView> (Resource.Id.tv_tab_bottom_server);
			btn_tab_bottom_finance = ll_tab_bottom_finance.FindViewById<ImageButton> (Resource.Id.btn_tab_bottom_finance);
			tv_tab_bottom_finance = ll_tab_bottom_finance.FindViewById<TextView> (Resource.Id.tv_tab_bottom_finance);

			btn_tab_bottom_my = ll_tab_bottom_my.FindViewById<ImageButton> (Resource.Id.btn_tab_bottom_my);
			tv_tab_bottom_my = ll_tab_bottom_my.FindViewById<TextView> (Resource.Id.tv_tab_bottom_my);
			//设置触发事件
			ll_tab_bottom_server.SetOnClickListener (this);
			ll_tab_bottom_finance.SetOnClickListener (this);
			ll_tab_bottom_my.SetOnClickListener (this);
		}

		/// <summary>
		/// 触发回调函数
		/// </summary>
		/// <param name="v">V.</param>
		public void  OnClick (View v)
		{
			
			switch (v.Id) {
			case Resource.Id.ll_tab_bottom_server:
				SetTabSections (0);
				break;
			case Resource.Id.ll_tab_bottom_finance:
				SetTabSections (1);
				break;
			case Resource.Id.ll_tab_bottom_my:
				SetTabSections (2);
				break;
			default:
				break;
			}
		}

		private void SetTabSections(int index)
		{
			ResetView ();
			var trasaction = fragmentManager.BeginTransaction ();

			//隐藏掉所有的fragment
			HideFragments(trasaction);
			switch (index) {
			case 0:
				ll_tab_bottom_server.SetBackgroundResource (Resource.Color.griditems_bg);
				btn_tab_bottom_server.SetImageResource (Resource.Drawable.ic_menu_health_selected);
				tv_tab_bottom_server.SetTextColor(Resources.GetColor(Resource.Color.blue));
				if (_serverFrag == null) {
					_serverFrag = new MainTabServerFragment ();
					trasaction.Add (Resource.Id.id_mainContent, _serverFrag);
				}
				else
					trasaction.Show(_serverFrag);
				break;
			case 1:
				ll_tab_bottom_finance.SetBackgroundResource (Resource.Color.griditems_bg);
				btn_tab_bottom_finance.SetImageResource (Resource.Drawable.ic_menu_alarm_selected);
				tv_tab_bottom_finance.SetTextColor(Resources.GetColor(Resource.Color.blue));
				if (_financeFrag == null) {
					_financeFrag = new MainTabFinanceFragment ();
					trasaction.Add (Resource.Id.id_mainContent, _financeFrag);

				} else
					trasaction.Show (_financeFrag);
				break;		
			case 2:
				ll_tab_bottom_my.SetBackgroundResource (Resource.Color.griditems_bg);
				btn_tab_bottom_my.SetImageResource (Resource.Drawable.ic_menu_mine_selected);
				tv_tab_bottom_my.SetTextColor(Resources.GetColor(Resource.Color.blue));
				if (_myFrag == null) {
					_myFrag = new MainTabMyFragment ();
					trasaction.Add (Resource.Id.id_mainContent, _myFrag);

				} else
					trasaction.Show (_myFrag);
				break;	
			}
			trasaction.Commit ();
		}

		/// <summary>
		/// 重置所有选中状态
		/// </summary>
		private void ResetView()
		{
			ll_tab_bottom_server.SetBackgroundResource(Resource.Color.white);
			ll_tab_bottom_finance.SetBackgroundResource (Resource.Color.white);
			ll_tab_bottom_my.SetBackgroundResource(Resource.Color.white);

			btn_tab_bottom_server.SetImageResource (Resource.Drawable.ic_menu_health_normal);
			tv_tab_bottom_server.SetTextColor(Resources.GetColor(Resource.Color.lightgray));

			btn_tab_bottom_finance.SetImageResource (Resource.Drawable.ic_menu_alarm_normal);
			tv_tab_bottom_finance.SetTextColor(Resources.GetColor(Resource.Color.lightgray));

			btn_tab_bottom_my.SetImageResource (Resource.Drawable.ic_menu_mine_normal);
			tv_tab_bottom_my.SetTextColor(Resources.GetColor(Resource.Color.lightgray));
		}

		private void HideFragments(Android.Support.V4.App.FragmentTransaction transaction)
		{
			if (_serverFrag != null)
				transaction.Hide (_serverFrag);
			if (_financeFrag != null)
				transaction.Hide (_financeFrag);
			if (_myFrag != null)
				transaction.Hide (_myFrag);
		}

		/// <param name="keyCode">The value in event.getKeyCode().</param>
		/// <param name="e">Description of the key event.</param>
		/// <summary>
		/// Called when a key was pressed down and not handled by any of the views 退出提示
		///  inside of the activity.
		/// </summary>
		/// <returns>To be added.</returns>
		public override bool OnKeyDown (Keycode keyCode, KeyEvent e)
		{

			if (keyCode == Keycode.Back && e.RepeatCount == 0) {
				var builder = new AlertDialog.Builder (this).SetTitle ("操作提示").SetMessage ("确定要退出吗?");
				builder.SetPositiveButton ("确定", (sender, args) => {
					this.Finish();

				}).SetNegativeButton ("取消", (sender, args) => {
					exitDialog.Dismiss();
				});
				exitDialog= builder.Create ();
				exitDialog.Show();
			}
			return base.OnKeyDown (keyCode, e);
		}


	}
}


