using System;
using Android.Support.V4.View;
using Android.Views;
using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.Content;
using Java.Lang;
using CommunityCenter.Common;

namespace CommunityCenter.Adapter
{
	public class GuiderViewPageAdapter:PagerAdapter,View.IOnClickListener
	{
		// 界面列表
		private List<View> views;
		private Activity activity;
		public GuiderViewPageAdapter (List<View> _views,Activity _activity)
		{
			views = _views;
			activity = _activity;
		}
		/// <summary>
		/// 销毁position位置界面
		/// </summary>
		/// <param name="container">Container.</param>
		/// <param name="position">Position.</param>
		/// <param name="object">Object.</param>
		public override void DestroyItem (ViewGroup container, int position, Java.Lang.Object @object)
		{
			container.RemoveView(views[position]);
		}

		public override void FinishUpdate (View container)
		{
			base.FinishUpdate (container);
		}

		/// <summary>
		/// 当前界面数
		/// </summary>
		/// <value>The count.</value>
		public override int Count {
			get {

				if (views != null)
					return views.Count;
				return 0;
			}
		}

		/// <summary>
		/// 初始item位置界面
		/// </summary>
		/// <returns>The item.</returns>
		/// <param name="container">Container.</param>
		/// <param name="position">Position.</param>
		public override Java.Lang.Object InstantiateItem (ViewGroup container, int position)
		{

			container.AddView(views[position]);
			if (position == views.Count - 1) {
				var btn_start_use = container.FindViewById<Button> (Resource.Id.btn_start_use);
				btn_start_use.SetOnClickListener (this);
			} else {
				var btn_skip = container.FindViewById<Button> (Resource.Id.btn_skip);
				btn_skip.SetOnClickListener (this);
			}

			return views[position];
		}

		public void OnClick(View view)
		{
			SetGuided ();
			GoFuncHome ();
		}

		/// <summary>
		/// 设置已经引导过，存储在本地
		/// </summary>
		private void SetGuided()
		{
			var prefences = activity.GetSharedPreferences (Global.SHAREDPREFERENCES_USERINFO, FileCreationMode.Private);
			var edit = prefences.Edit ();
			edit.PutBoolean (Global.refrence_IsFirstIn, false);
			edit.Commit ();

		}

		/// <summary>
		/// 回到功能主界面
		/// </summary>
		private void GoFuncHome()
		{
			var intent = new Intent(activity,typeof(MainActivity));
			activity.StartActivity(intent);
			activity.Finish();
			activity.OverridePendingTransition (Resource.Animation.fade_in, Resource.Animation.fade_out);
		}

		/// <summary>
		/// 判断是否由对象生成界面
		/// </summary>
		/// <returns><c>true</c> if this instance is view from object the specified view object; otherwise, <c>false</c>.</returns>
		/// <param name="view">View.</param>
		/// <param name="object">Object.</param>
		public override bool IsViewFromObject (View view, Java.Lang.Object @object)
		{
			return (view == @object);

		}

		public override void RestoreState (Android.OS.IParcelable state, ClassLoader loader)
		{

		}
		public override void StartUpdate (View container)
		{

		}

		public override Android.OS.IParcelable SaveState ()
		{
			return null;
		}
	}
}

