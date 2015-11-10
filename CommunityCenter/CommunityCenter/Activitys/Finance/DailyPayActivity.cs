
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
using CommunityCenter.Common;

namespace CommunityCenter.Activitys.Finance
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class DailyPayActivity : Activity
	{
		private RelativeLayout rl_chargePhone,rl_chargeWater,rl_chargeEle,rl_chargeGas,rl_chargeTv,rl_chargeFix,rl_chargeOil,rl_chargeTraffic;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.DailyPayLayout );
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			// Create your application here
			InitView();
		}
		private void InitView()
		{
			//设置标题栏
			var img_header_back = FindViewById<ImageView> (Resource.Id.img_header_back);
			img_header_back.Click += (sender, e) => 
			{
				this.Finish();
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			var tv_back = FindViewById<TextView> (Resource.Id.tv_back);
			tv_back.Text = "返回";
			var tv_desc = FindViewById<TextView> (Resource.Id.tv_desc);
			tv_desc.Text = "生活缴费";

			rl_chargePhone = FindViewById<RelativeLayout> (Resource.Id.rl_chargePhone);
			rl_chargePhone.Click += (sender, e) => 
			{
				EldYoungUtil.StartTargetActivity(this,FuncActivityType.ChargePhone);
			};

			rl_chargeWater = FindViewById<RelativeLayout> (Resource.Id.rl_chargeWater);
			rl_chargeWater.Click += (sender, e) => 
			{
				EldYoungUtil.StartTargetActivity(this,FuncActivityType.ChargeWater);
			};

			rl_chargeEle = FindViewById<RelativeLayout> (Resource.Id.rl_chargeEle);
			rl_chargeEle.Click += (sender, e) => 
			{
				EldYoungUtil.StartTargetActivity(this,FuncActivityType.ChargeEle);
			};

			rl_chargeGas = FindViewById<RelativeLayout> (Resource.Id.rl_chargeGas);
			rl_chargeGas.Click += (sender, e) => 
			{
				EldYoungUtil.StartTargetActivity(this,FuncActivityType.ChargeGas);
			};

			rl_chargeTv = FindViewById<RelativeLayout> (Resource.Id.rl_chargeTv);
			rl_chargeTv.Click += (sender, e) => 
			{
				EldYoungUtil.StartTargetActivity(this,FuncActivityType.ChargeTv);
			};

			rl_chargeFix = FindViewById<RelativeLayout> (Resource.Id.rl_chargeFix);
			rl_chargeFix.Click += (sender, e) => 
			{
				EldYoungUtil.StartTargetActivity(this,FuncActivityType.ChargeFix);
			};

			rl_chargeOil = FindViewById<RelativeLayout> (Resource.Id.rl_chargeOil);
			rl_chargeOil.Click += (sender, e) => 
			{
				EldYoungUtil.StartTargetActivity(this,FuncActivityType.ChargeOil);
			};

			rl_chargeTraffic = FindViewById<RelativeLayout> (Resource.Id.rl_chargeTraffic);
			rl_chargeTraffic.Click += (sender, e) => 
			{
				EldYoungUtil.StartTargetActivity(this,FuncActivityType.ChargeTraffic);
			};

		}
	}
}

