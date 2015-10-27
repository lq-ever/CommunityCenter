using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.Graphics.Drawables;

namespace CommunityCenter.Common
{
	/// <summary>
	/// 实现自定义的progressdialog加载动画 by lq 20150707
	/// </summary>
	public class CustomProgressDialog:Dialog
	{

		private static CustomProgressDialog customProgressDialog = null;
		public CustomProgressDialog (Context context):base(context)
		{

		}

		public CustomProgressDialog(Context context,int theme) :base(context,theme)
		{
		}

		public static CustomProgressDialog createDialog(Context context){
			customProgressDialog = new CustomProgressDialog (context, Resource.Style.CustomProgressDialog);
			customProgressDialog.SetContentView(Resource.Layout.customprogressdialog);
			customProgressDialog.Window.Attributes.Gravity = Android.Views.GravityFlags.Center;
			return customProgressDialog;

		}

		public override void OnWindowFocusChanged(bool hasFocus){

			if (customProgressDialog == null){
				return;
			}

			ImageView imageView = customProgressDialog.FindViewById<ImageView>(Resource.Id.loadingImageView);
			AnimationDrawable animationDrawable =(AnimationDrawable) imageView.Background;
			animationDrawable.Start ();
			base.OnWindowFocusChanged (hasFocus);
		}

		public  CustomProgressDialog SetTitile(String strTitle){
			return customProgressDialog;
		}

		public CustomProgressDialog SetMessage(String strMessage){
			TextView tvMsg = customProgressDialog.FindViewById<TextView>(Resource.Id.id_tv_loadingmsg);

			if (tvMsg != null){

				tvMsg.Text = strMessage;
			}

			return customProgressDialog;
		}
	}
}

