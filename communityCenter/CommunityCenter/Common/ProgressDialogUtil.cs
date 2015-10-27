using System;
using Android.App;
using Android.Views;

namespace CommunityCenter.Common
{
	public class ProgressDialogUtil
	{
		private static CustomProgressDialog progressDialog;
		public ProgressDialogUtil ()
		{

		}
		/// <summary>
		/// 启动 progress dialog.
		/// </summary>
		/// <param name="context">Context.</param>
		/// <param name="msg">Message.</param>
		public static void StartProgressDialog(Activity activity,string msg,bool canceleable =false)
		{
			progressDialog = CustomProgressDialog.createDialog (activity);
			progressDialog.Window.SetGravity (GravityFlags.Center); 
			progressDialog.SetMessage (msg);
			progressDialog.Show ();
			progressDialog.SetCancelable (canceleable);

		}
		/// <summary>
		/// 停止 the progress dialog.
		/// </summary>
		public static void StopProgressDialog()
		{
			if (progressDialog != null && progressDialog.IsShowing)
				progressDialog.Dismiss ();
			progressDialog = null;

		}
	}
}

