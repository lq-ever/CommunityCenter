
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
using Com.Handmark.Pulltorefresh.Library;

namespace CommunityCenter
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class ServiceOrderSearchActivity : Activity
	{
		private int serviceType;//服务类型
		private Button btn_all,btn_todo,btn_sucessorder,btn_done,btn_search;
		private EditText edit_orderNo,edit_orderName,edit_startTime,edit_endTime;
		private ImageView iv_bottom_line;
		private PullToRefreshListView orderSearchRefreshListView;//列表view


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.ChooseBankTypeLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			InitView ();
		}
		private void InitView()
		{
			//设置标题栏
			var img_header_back = FindViewById<ImageView> (Resource.Id.img_header_back);
			img_header_back.Click += (sender, e) => 
			{
				SetResult(Result.Canceled);
				this.Finish();
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//获取服务类型值
			serviceType = Intent.GetIntExtra ("serviceType", 0);
			var tv_back = FindViewById<TextView> (Resource.Id.tv_back);
			tv_back.Text = "返回";
			var tv_desc = FindViewById<TextView> (Resource.Id.tv_desc);
			//界面赋值
			tv_desc.Text = GetActivityDesc (serviceType);
		}
		/// <summary>
		/// Gets the activity desc.
		/// </summary>
		/// <returns>The activity desc.</returns>
		/// <param name="_serviceType">Service type.</param>
		private string GetActivityDesc(int _serviceType)
		{
			string desc = string.Empty;
			switch (_serviceType) {

			case (int)ServiceType.HouseKeep:
				desc = "家政预约";
				break;
			case (int)ServiceType.Errand:
				desc = "护理预约";
				break;
			case (int)ServiceType.Nurse:
				desc = "跑腿预约";
				break;
			}
			return desc;
		}
	}
}

