using System;
using Android.Widget;
using Android.Content;
using Android.Views;
using Android.Graphics.Drawables;
using Android.App;
using System.Threading;
using CommunityCenter.Model.ServerType.Admin;


namespace CommunityCenter.Common
{
	//定义解绑委托
	public delegate void UnBindEventHandler(GuardianInfoListItem item);

	public class UnbindPopWindow:PopupWindow 
	{
		private View contentView;  
		private Activity activity;
		public UnBindEventHandler UnBindEventHandler;
		public UnbindPopWindow (Activity _activity,GuardianInfoListItem item)
		{
			activity = _activity;
			LayoutInflater inflater = (LayoutInflater) activity.GetSystemService (Context.LayoutInflaterService);
			contentView = inflater.Inflate(Resource.Layout.customunbinddialogLayout, null);  

			ContentView = contentView;
			Width = 900;
			Height = 450;
			Focusable = true;
			OutsideTouchable = true;
			//Update ();
			SetBackgroundDrawable (new ColorDrawable());
			AnimationStyle = Resource.Style.AnimationPreview;
			var btn_confirm = contentView.FindViewById<Button> (Resource.Id.btn_confirm);
			btn_confirm.Click += (sender, e) => 
			{
				Dismiss();

				if(UnBindEventHandler != null)
					UnBindEventHandler(item);
		
			};
			var btn_cancel = contentView.FindViewById<Button> (Resource.Id.btn_cancel);
			btn_cancel.Click += (sender, e) => 
			{
				Dismiss();
			};

			DismissEvent += (sender, e) => 
			{
				BackgroundAlpha(1f);

			};
		}

		/// <summary>
		/// 设置弹出背景色
		/// </summary>
		/// <param name="bgAlpha">Background alpha.</param>
		public void BackgroundAlpha(float bgAlpha)  
		{  
			activity.Window.AddFlags (WindowManagerFlags.DimBehind);
			WindowManagerLayoutParams lp = activity.Window.Attributes;
			lp.Alpha = bgAlpha;
			activity.Window.Attributes = lp;
		}  
		public void ShowPopWindow(View parent)
		{
			if (!IsShowing) {
				BackgroundAlpha (0.5f);
				ShowAtLocation (parent, GravityFlags.Center, 0, 0);
			} else
				Dismiss ();
		}
	}
}

