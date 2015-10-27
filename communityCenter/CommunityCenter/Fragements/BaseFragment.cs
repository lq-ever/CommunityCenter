
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

namespace CommunityCenter
{
	/// <summary>
	/// Base fragment.基类懒加载实现当fragment可见并初始化完成才去加载数据
	/// </summary>
	public abstract class BaseFragment : Fragment
	{
		//fragment当前是否可见
		protected bool IsVisible;
		/** 标志位，标志已经初始化完成 */
		protected bool IsPrepared;
		/** 是否已被加载过一次，第二次就不再去请求数据了 */
		protected bool HasLoadedOnce;

		public override bool UserVisibleHint {
			get {
				return base.UserVisibleHint;
			}
			set {
				base.UserVisibleHint = value;
				if (UserVisibleHint) {
					IsVisible = true;
					LasyloadData ();
				} else
					IsVisible = false;
			}
		}

		public abstract void LasyloadData();

	}
}

