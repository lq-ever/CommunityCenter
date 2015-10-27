using System;
using Android.Widget;
using Android.Views;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;

namespace CommunityCenter.Common
{
	public class SelectPicPopWindow:PopupWindow
	{
		private View contentView;  
		private Activity activity;
		private Button btn_take_photo, btn_pick_photo, btn_cancel;  
		public SelectPicPopWindow (Activity _activity,View.IOnClickListener listener)
		{
			activity = _activity;
			LayoutInflater inflater = (LayoutInflater) activity.GetSystemService (Context.LayoutInflaterService);
			contentView = inflater.Inflate(Resource.Layout.headImgSelectorPop, null);  
			ContentView = contentView;
			btn_take_photo = contentView.FindViewById<Button> (Resource.Id.btn_take_photo);
			btn_pick_photo = contentView.FindViewById<Button> (Resource.Id.btn_pick_photo);
			btn_cancel = contentView.FindViewById<Button> (Resource.Id.btn_pic_cancel);
			//设置宽度、高度
			Width = Android.Views.ViewGroup.LayoutParams.MatchParent;
			Height = Android.Views.ViewGroup.LayoutParams.WrapContent;
			Focusable = true;
			OutsideTouchable = true;
			SetBackgroundDrawable (new ColorDrawable());
			AnimationStyle = Resource.Style.Animationbottom;

			//设置按钮绑定
			btn_take_photo.SetOnClickListener (listener);
			btn_pick_photo.SetOnClickListener (listener);

			//取消
			btn_cancel.Click += (sender, e) => 
			{
				Dismiss();

			};

			DismissEvent+= (sender, e) => 
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
				ShowAtLocation (parent, GravityFlags.Bottom|GravityFlags.CenterHorizontal, 0, 0);
			} else
				Dismiss ();
		}
	}
}

