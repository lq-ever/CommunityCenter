
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

using Newtonsoft.Json;
using CommunityCenter.Model.ServerType.Admin;
using CommunityCenter.Common;

namespace CommunityCenter.Activitys.ServerType.Admin
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class PhysicalDetailInfoActivity : Activity
	{
		private HealthInfoItem healthInfoItem;
		private TextView tv_TestTime,tv_Height,tv_Weight,tv_BMI,tv_BloodGlucose,
		tv_BloodOxygenParaOne,tv_HeartRate,tv_BreathCapacity,tv_BodyTemperature,tv_BloodPressureParaTwo,tv_BloodPressureParaOne,tv_BloodLipidParaOne,
		tv_BloodLipidParaFour,tv_BloodLipidParaTwo,
		tv_BloodLipidParaThree,tv_UrineRoutinePH,tv_UrineRoutineSG,
		tv_UrineRoutineURO,tv_UrineRoutineWBC,tv_UrineRoutineBLO,tv_UrineRoutineKET,tv_UrineRoutineGLU,tv_UrineRoutineRPO,tv_UrineRoutineBIL;

		private ImageView img_BMI_Arraw, img_BloodGlucose_Arraw, img_BloodOxygenParaOne_Arraw, img_HeartRate_Arraw, img_BreathCapacity_Arraw, img_BodyTemperature_Arraw, img_BloodLipidParaOne_Arraw, img_BloodLipidParaFour_Arraw, img_BloodLipidParaTwo_Arraw,
		img_BloodLipidParaThree_Arraw, img_UrineRoutinePH_Arraw, img_UrineRoutineSG_Arraw, img_UrineRoutineURO_Arraw;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.PhysicalDetailInfoLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			// Create your application here
			InitView();
		}
		private void InitView()
		{
			ProgressDialogUtil.StartProgressDialog(this,"正在加载体检详细信息...");
			//设置标题栏
			var img_header_back = FindViewById<ImageView> (Resource.Id.img_header_back);
			img_header_back.Click += (sender, e) => 
			{
				this.Finish();
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

			var tv_back = FindViewById<TextView> (Resource.Id.tv_back);
			tv_back.Text = "健康记录";
			var tv_desc = FindViewById<TextView> (Resource.Id.tv_desc);
			tv_desc.Text = "健康信息详情";


			//获取列表传递详细数据
			var _healthItemInfoJson = Intent.GetStringExtra ("healthInfo");
			healthInfoItem = JsonConvert.DeserializeObject<HealthInfoItem> (_healthItemInfoJson);
			tv_TestTime = FindViewById<TextView> (Resource.Id.tv_TestTime);
			tv_Height = FindViewById<TextView> (Resource.Id.tv_Height);
			tv_Weight = FindViewById<TextView> (Resource.Id.tv_Weight);
			tv_BMI = FindViewById<TextView> (Resource.Id.tv_BMI);
			tv_BloodGlucose = FindViewById<TextView> (Resource.Id.tv_BloodGlucose);
			tv_BloodOxygenParaOne = FindViewById<TextView> (Resource.Id.tv_BloodOxygenParaOne);
			tv_HeartRate = FindViewById<TextView> (Resource.Id.tv_HeartRate);
			tv_BreathCapacity = FindViewById<TextView> (Resource.Id.tv_BreathCapacity);
			tv_BodyTemperature = FindViewById<TextView> (Resource.Id.tv_BodyTemperature);
			tv_BloodPressureParaTwo = FindViewById<TextView> (Resource.Id.tv_BloodPressureParaTwo);
			tv_BloodPressureParaOne = FindViewById<TextView> (Resource.Id.tv_BloodPressureParaOne);
			tv_BloodLipidParaOne = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaOne);
			tv_BloodLipidParaFour = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaFour);
			tv_BloodLipidParaTwo = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaTwo);
			tv_BloodLipidParaThree = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaThree);
			tv_UrineRoutinePH = FindViewById<TextView> (Resource.Id.tv_UrineRoutinePH);
			tv_UrineRoutineSG = FindViewById<TextView> (Resource.Id.tv_UrineRoutineSG);
			tv_UrineRoutineURO = FindViewById<TextView> (Resource.Id.tv_UrineRoutineURO);
			tv_UrineRoutineWBC = FindViewById<TextView> (Resource.Id.tv_UrineRoutineWBC);
			tv_UrineRoutineBLO = FindViewById<TextView> (Resource.Id.tv_UrineRoutineBLO);
			tv_UrineRoutineKET = FindViewById<TextView> (Resource.Id.tv_UrineRoutineKET);
			tv_UrineRoutineGLU = FindViewById<TextView> (Resource.Id.tv_UrineRoutineGLU);
			tv_UrineRoutineRPO = FindViewById<TextView> (Resource.Id.tv_UrineRoutineRPO);
			tv_UrineRoutineBIL = FindViewById<TextView> (Resource.Id.tv_UrineRoutineBIL);
			img_BMI_Arraw = FindViewById<ImageView> (Resource.Id.img_BMI_Arraw);
			img_BloodGlucose_Arraw = FindViewById<ImageView> (Resource.Id.img_BloodGlucose_Arraw);
			img_BloodOxygenParaOne_Arraw = FindViewById<ImageView> (Resource.Id.img_BloodOxygenParaOne_Arraw);
			img_HeartRate_Arraw = FindViewById<ImageView> (Resource.Id.img_HeartRate_Arraw);
			img_BreathCapacity_Arraw = FindViewById<ImageView> (Resource.Id.img_BreathCapacity_Arraw);
			img_BodyTemperature_Arraw = FindViewById<ImageView> (Resource.Id.img_BodyTemperature_Arraw);
			img_BloodLipidParaOne_Arraw = FindViewById<ImageView> (Resource.Id.img_BloodLipidParaOne_Arraw);
			img_BloodLipidParaFour_Arraw = FindViewById<ImageView> (Resource.Id.img_BloodLipidParaFour_Arraw);
			img_BloodLipidParaTwo_Arraw = FindViewById<ImageView> (Resource.Id.img_BloodLipidParaTwo_Arraw);
			img_BloodLipidParaThree_Arraw = FindViewById<ImageView> (Resource.Id.img_BloodLipidParaThree_Arraw);
			img_UrineRoutinePH_Arraw = FindViewById<ImageView> (Resource.Id.img_UrineRoutinePH_Arraw);
			img_UrineRoutineSG_Arraw = FindViewById<ImageView> (Resource.Id.img_UrineRoutineSG_Arraw);
			img_UrineRoutineURO_Arraw = FindViewById<ImageView> (Resource.Id.img_UrineRoutineURO_Arraw);

			new Handler ().PostDelayed (LoadData, 1000);

		}

		/// <summary>
		/// 加载体检详细数据
		/// </summary>
		private void LoadData()
		{
			//身体质量指数
			tv_TestTime.Text = string.IsNullOrEmpty (healthInfoItem.TestTime) ? "-" : Convert.ToDateTime(healthInfoItem.TestTime).ToString("yyyy-MM-dd HH:mm:ss");

			tv_Height.Text = string.IsNullOrEmpty (healthInfoItem.Height) ? "-" : healthInfoItem.Height+"cm/";
			tv_Weight.Text = string.IsNullOrEmpty (healthInfoItem.Weight) ? "-" : healthInfoItem.Weight+"kg";
			if (!string.IsNullOrEmpty (healthInfoItem.Height) && !string.IsNullOrEmpty (healthInfoItem.Weight)) {
				var bmi = Convert.ToDouble (healthInfoItem.Weight) / ((Convert.ToDouble (healthInfoItem.Height) / 100) * (Convert.ToDouble (healthInfoItem.Height) / 100));
				tv_BMI.Text = string.Format ("{0:F}", bmi); // bmi.ToString ();
				if (bmi > HealthStand.BMI_High || bmi < HealthStand.BMI_Low) {
					//异常
					tv_BMI.SetTextColor (Resources.GetColor (Resource.Color.pink));
					img_BMI_Arraw.Visibility = ViewStates.Visible;
				} else
					img_BMI_Arraw.Visibility = ViewStates.Gone;

			} else
				img_BMI_Arraw.Visibility = ViewStates.Gone;

			//血糖
			tv_BloodGlucose.Text = string.IsNullOrEmpty(healthInfoItem.BloodGlucose)?"-":healthInfoItem.BloodGlucose;

			if (!string.IsNullOrEmpty (healthInfoItem.BloodGlucose)) {
				var bloodGlucose = healthInfoItem.BloodGlucose;

				if (Convert.ToDouble (bloodGlucose) > HealthStand.BloodGlucose_High || Convert.ToDouble (bloodGlucose) < HealthStand.BloodGlucose_Low) {
					tv_BloodGlucose.SetTextColor (Resources.GetColor (Resource.Color.pink));
					img_BloodGlucose_Arraw.Visibility = ViewStates.Visible;
				} else
					img_BloodGlucose_Arraw.Visibility = ViewStates.Gone;
			} else
				img_BloodGlucose_Arraw.Visibility = ViewStates.Gone;

			//血氧
			tv_BloodOxygenParaOne.Text = string.IsNullOrEmpty(healthInfoItem.BloodOxygenParaOne)?"-":healthInfoItem.BloodOxygenParaOne;

			if (!string.IsNullOrEmpty (healthInfoItem.BloodOxygenParaOne)) {
				var bloodOxygen = healthInfoItem.BloodOxygenParaOne;
				if (Convert.ToDouble (bloodOxygen) > HealthStand.BloodOxygen_High || Convert.ToDouble (bloodOxygen) < HealthStand.BloodOxygen_Low) {
					tv_BloodOxygenParaOne.SetTextColor (Resources.GetColor (Resource.Color.pink));
					img_BloodOxygenParaOne_Arraw.Visibility = ViewStates.Visible;
				} else
					img_BloodOxygenParaOne_Arraw.Visibility = ViewStates.Gone;
			} else
				img_BloodOxygenParaOne_Arraw.Visibility = ViewStates.Gone;

			//血压
			tv_BloodPressureParaOne.Text = string.IsNullOrEmpty(healthInfoItem.BloodPressureParaOne)?"-":healthInfoItem.BloodPressureParaOne;
			tv_BloodPressureParaTwo.Text = string.IsNullOrEmpty (healthInfoItem.BloodPressureParaTwo) ? "-" : healthInfoItem.BloodPressureParaTwo;
			//心率
			tv_HeartRate.Text = string.IsNullOrEmpty(healthInfoItem.HeartRate)?"-":healthInfoItem.HeartRate;

			if (!string.IsNullOrEmpty (healthInfoItem.HeartRate)) {
				var heartRate = healthInfoItem.HeartRate;
				if (Convert.ToDouble (heartRate) > HealthStand.HeartRate_High || Convert.ToDouble (heartRate) < HealthStand.HeartRate_Low) {
					tv_HeartRate.SetTextColor (Resources.GetColor (Resource.Color.pink));
					img_HeartRate_Arraw.Visibility = ViewStates.Visible;
				} else
					img_HeartRate_Arraw.Visibility = ViewStates.Gone;
			} else
				img_HeartRate_Arraw.Visibility = ViewStates.Gone;

			//肺活量
			tv_BreathCapacity.Text = string.IsNullOrEmpty(healthInfoItem.BreathCapacity)?"-":healthInfoItem.BreathCapacity;

			if (!string.IsNullOrEmpty (healthInfoItem.BreathCapacity)) {
				var breathCapacity = healthInfoItem.BreathCapacity;
				if (Convert.ToDouble (breathCapacity) > HealthStand.BreathCapacity_High || Convert.ToDouble (breathCapacity) < HealthStand.BreathCapacity_Low) {
					tv_BreathCapacity.SetTextColor (Resources.GetColor (Resource.Color.pink));
					img_BreathCapacity_Arraw.Visibility = ViewStates.Visible;
				} else
					img_BreathCapacity_Arraw.Visibility = ViewStates.Gone;
			} else
				img_BreathCapacity_Arraw.Visibility = ViewStates.Gone;
			//体温
			tv_BodyTemperature.Text = string.IsNullOrEmpty(healthInfoItem.BodyTemperature)?"-":healthInfoItem.BodyTemperature;

			if (!string.IsNullOrEmpty (healthInfoItem.BodyTemperature)) {
				var bodyTemperature = Convert.ToDouble (healthInfoItem.BodyTemperature);
				if (bodyTemperature > HealthStand.BodyTemperature_High || bodyTemperature < HealthStand.BodyTemperature_Low) {
					tv_BodyTemperature.SetTextColor (Resources.GetColor (Resource.Color.pink));
					img_BodyTemperature_Arraw.Visibility = ViewStates.Visible;
				} else
					img_BodyTemperature_Arraw.Visibility = ViewStates.Gone;
			} else
				img_BodyTemperature_Arraw.Visibility = ViewStates.Gone;
			//总胆固醇
			tv_BloodLipidParaOne.Text = string.IsNullOrEmpty(healthInfoItem.BloodLipidParaOne)?"-":healthInfoItem.BloodLipidParaOne;

			if (!string.IsNullOrEmpty (healthInfoItem.BloodLipidParaOne)) {
				var bloodLipidParaOne = Convert.ToDouble (healthInfoItem.BloodLipidParaOne);
				if (bloodLipidParaOne > HealthStand.BloodLipidParaOne_High || bloodLipidParaOne < HealthStand.BloodLipidParaOne_Low) {
					tv_BloodLipidParaOne.SetTextColor (Resources.GetColor (Resource.Color.pink));
					img_BloodLipidParaOne_Arraw.Visibility = ViewStates.Visible;
				} else
					img_BloodOxygenParaOne_Arraw.Visibility = ViewStates.Gone;
					
			} else
				img_BloodLipidParaOne_Arraw.Visibility = ViewStates.Gone;

			//低密度脂蛋白胆固醇

			tv_BloodLipidParaTwo.Text = string.IsNullOrEmpty(healthInfoItem.BloodLipidParaTwo)?"-":healthInfoItem.BloodLipidParaTwo;

			if (!string.IsNullOrEmpty (healthInfoItem.BloodLipidParaTwo)) {
				var bloodLipidParaTwo = Convert.ToDouble (healthInfoItem.BloodLipidParaTwo);
				if (bloodLipidParaTwo > HealthStand.BloodLipidParaTwo_High || bloodLipidParaTwo < HealthStand.BloodLipidParaTwo_Low) {
					tv_BloodLipidParaTwo.SetTextColor (Resources.GetColor (Resource.Color.pink));

					img_BloodLipidParaTwo_Arraw.Visibility = ViewStates.Visible;

				} else
					img_BloodLipidParaTwo_Arraw.Visibility = ViewStates.Gone;
			} else
				img_BloodLipidParaTwo_Arraw.Visibility = ViewStates.Gone;

			//高密度脂蛋白胆固醇

			tv_BloodLipidParaThree.Text = string.IsNullOrEmpty(healthInfoItem.BloodLipidParaThree)?"-":healthInfoItem.BloodLipidParaThree;
		
			if (!string.IsNullOrEmpty (healthInfoItem.BloodLipidParaThree)) {
				var bloodLipidParaThree = Convert.ToDouble (healthInfoItem.BloodLipidParaThree);
				if (bloodLipidParaThree > HealthStand.BloodLipidParaThree_High || bloodLipidParaThree < HealthStand.BloodLipidParaThree_Low) {
					tv_BloodLipidParaThree.SetTextColor (Resources.GetColor (Resource.Color.pink));
					img_BloodLipidParaThree_Arraw.Visibility = ViewStates.Visible;
				} else
					img_BloodLipidParaThree_Arraw.Visibility = ViewStates.Gone;
			} else
				img_BloodLipidParaThree_Arraw.Visibility = ViewStates.Gone;

			//甘油三酯
			tv_BloodLipidParaFour.Text = string.IsNullOrEmpty(healthInfoItem.BloodLipidParaFour)?"-":healthInfoItem.BloodLipidParaFour;

			if (!string.IsNullOrEmpty (healthInfoItem.BloodLipidParaFour)) {
				var bloodLipidParaFour = Convert.ToDouble (healthInfoItem.BloodLipidParaFour);
				if (bloodLipidParaFour > HealthStand.BloodLipidParaFour_High || bloodLipidParaFour < HealthStand.BloodLipidParaFour_Low) {
					tv_BloodLipidParaFour.SetTextColor (Resources.GetColor (Resource.Color.pink));
					img_BloodLipidParaFour_Arraw.Visibility = ViewStates.Visible;
				} else
					img_BloodLipidParaFour_Arraw.Visibility = ViewStates.Gone;
			} else
				img_BloodLipidParaFour_Arraw.Visibility = ViewStates.Gone;
			//酸碱度
			tv_UrineRoutinePH.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutinePH)?"-":healthInfoItem.UrineRoutinePH;
	
			if (!string.IsNullOrEmpty (healthInfoItem.UrineRoutinePH)) {
				var urineRoutinePh = Convert.ToDouble (healthInfoItem.UrineRoutinePH);
				if (urineRoutinePh > HealthStand.PH_High || urineRoutinePh < HealthStand.PH_Low) {
					tv_UrineRoutinePH.SetTextColor (Resources.GetColor (Resource.Color.pink));
					img_UrineRoutinePH_Arraw.Visibility = ViewStates.Visible;
				} else
					img_UrineRoutinePH_Arraw.Visibility = ViewStates.Gone;
			} else
				img_UrineRoutinePH_Arraw.Visibility = ViewStates.Gone;
			//尿比重
			tv_UrineRoutineSG.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineSG)?"-":healthInfoItem.UrineRoutineSG;
	
			if (!string.IsNullOrEmpty (healthInfoItem.UrineRoutineSG)) {
				var urineRoutineSg = Convert.ToDouble (healthInfoItem.UrineRoutineSG);
				if (urineRoutineSg > HealthStand.UrineRoutineSG_High || urineRoutineSg < HealthStand.UrineRoutineSG_Low) {
					tv_UrineRoutineSG.SetTextColor (Resources.GetColor (Resource.Color.pink));
					img_UrineRoutineSG_Arraw.Visibility = ViewStates.Visible;
				} else
					img_UrineRoutineSG_Arraw.Visibility = ViewStates.Gone;
			} else
				img_UrineRoutineSG_Arraw.Visibility = ViewStates.Gone;

			//尿胆元
			tv_UrineRoutineURO.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineURO)?"-":healthInfoItem.UrineRoutineURO;
	
			if (!string.IsNullOrEmpty (healthInfoItem.UrineRoutineURO)) {
				var urineRoutineUro = Convert.ToDouble (healthInfoItem.UrineRoutineURO);
				if (urineRoutineUro > HealthStand.UrineRoutineURO_High || urineRoutineUro < HealthStand.UrineRoutineURO_Low) {
					tv_UrineRoutineURO.SetTextColor (Resources.GetColor (Resource.Color.pink));
					img_UrineRoutineURO_Arraw.Visibility = ViewStates.Visible;
				} else
					img_UrineRoutineURO_Arraw.Visibility = ViewStates.Gone;
			} else
				img_UrineRoutineURO_Arraw.Visibility = ViewStates.Gone;
			//隐血
			tv_UrineRoutineBLO.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineBLO)?"-":healthInfoItem.UrineRoutineBLO;
			//白细胞(WBC):(WBC/uL)
			tv_UrineRoutineWBC.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineWBC)?"-":healthInfoItem.UrineRoutineWBC;
			//尿蛋白(PRO)
			tv_UrineRoutineRPO.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutinePRO)?"-":healthInfoItem.UrineRoutinePRO;
			//尿糖(GLU)
			tv_UrineRoutineGLU.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineGLU)?"-":healthInfoItem.UrineRoutineGLU;
			RunOnUiThread (() => {
				ProgressDialogUtil.StopProgressDialog();
			});
		}
	}
}

