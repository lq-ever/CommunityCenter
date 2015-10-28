using System;

namespace CommunityCenter.Model.ServerType.Admin
{
	public class HealthStand
	{
		public HealthStand ()
		{
		}
		/// <summary>
		/// BMI指标
		/// </summary>
		public const double BMI_High = 23.9;
		public const double BMI_Low = 18.5;

		/// <summary>
		/// 血糖
		/// </summary>
		public const double  BloodGlucose_High =7.8;
		public const double BloodGlucose_Low =4.0;
		/// <summary>
		/// 血氧
		/// </summary>
		public const double BloodOxygen_High =98;
		public const double BloodOxygen_Low = 92;
		/// <summary>
		/// 心率
		/// </summary>
		public const double HeartRate_High = 75;
		public const double HeartRate_Low =62;

		/// <summary>
		/// 肺活量
		/// </summary>
		public const double BreathCapacity_High =4000;
		public const double BreathCapacity_Low = 2500;
		/// <summary>
		/// 体温
		/// </summary>
		public const double BodyTemperature_High =37;
		public const double BodyTemperature_Low =35;

		/// <summary>
		/// 总胆固醇
		/// </summary>
		public const double  BloodLipidParaOne_High = 5.98;
		public const double BloodLipidParaOne_Low = 2.86;

		/// <summary>
		/// 低密度蛋白胆固醇
		/// </summary>
		public const double BloodLipidParaTwo_High =4.14;
		public const double BloodLipidParaTwo_Low =3.1;
		/// <summary>
		/// 高密度蛋白胆固醇
		/// </summary>
		public const double BloodLipidParaThree_High =1.83;
		public const double BloodLipidParaThree_Low =0.9;
		/// <summary>
		/// 甘油三酯
		/// </summary>
		public const double BloodLipidParaFour_High=1.7;
		public const double BloodLipidParaFour_Low =0;

		/// <summary>
		/// 酸碱度PH
		/// </summary>
		public const double PH_High =8.0;
		public const double PH_Low =7.5;
		/// <summary>
		/// 尿比重
		/// </summary>
		public const double UrineRoutineSG_High =1.03;
		public const double UrineRoutineSG_Low =1.01;
		/// <summary>
		/// 尿胆原
		/// </summary>
		public const double UrineRoutineURO_High =3.55;
		public const double UrineRoutineURO_Low=0.01;


	}
}

