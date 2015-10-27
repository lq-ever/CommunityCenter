using System;
using Android.Widget;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Graphics.Drawables;

namespace CommunityCenter.Common
{
	public class ConfirmphonePopWindow:PopupWindow
	{
		private View contentView;  
		private Activity activity;
		private Button btn_confirm, btn_cancel;
		private TextView tv_phoneNumber;

		public ConfirmphonePopWindow (Activity _activity,string _phoneNumber)
		{
			activity = _activity;
			LayoutInflater inflater = (LayoutInflater) activity.GetSystemService (Context.LayoutInflaterService);
			contentView = inflater.Inflate(Resource.Layout.customconfirmphonedialog, null);  
			ContentView = contentView;
			btn_confirm = contentView.FindViewById<Button> (Resource.Id.btn_confirm);
			btn_cancel = contentView.FindViewById<Button> (Resource.Id.btn_cancel);
			tv_phoneNumber = contentView.FindViewById<TextView> (Resource.Id.tv_phoneNumber);
			//设置宽度、高度

			Width = 960;
			Height = Android.Views.ViewGroup.LayoutParams.WrapContent;
			Focusable = true;
			OutsideTouchable = true;
			//Update ();
			SetBackgroundDrawable (new ColorDrawable());
			AnimationStyle = Resource.Style.Animationbottom;

			tv_phoneNumber.Text = "+86 " + _phoneNumber;
			//设置按钮绑定
			btn_confirm.SetOnClickListener ((Android.Views.View.IOnClickListener)activity);

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
				ShowAtLocation (parent, GravityFlags.Center, 0, 0);
			} else
				Dismiss ();
		}
	}
}

