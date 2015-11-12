using System;

namespace CommunityCenter
{
	public enum Sex
	{

		Female =1,
		Male=0,
	}

	public enum AdviceType
	{

		Consult =0,//咨询
		Suggest =1,//建议
		Complain=2,//投诉
		Other =3,//其它
		All =4//全部
	}

	/// <summary>
	/// 功能类型
	/// </summary>
	public enum FuncActivityType
	{
		Main =0,//主界面
		AdminMain=1,//管理员界面
		ErrandMain=2,//跑腿界面
		HouseKeepMain=3,//家政
		NurseMain=4,//护理
		PersonInfo=5,//个人信息
		AccountSecurity=6,//账户安全
		Certificate=7,//证书
		Advice=8,//投诉建议
		Charge=9,//充值
		WithDraw=10,//提现
		BankCards =11,//银行卡
		DealRecords=12,//交易记录
		DailyPay =13,//日常缴费
		ChargeEle=14,//电缴费
		ChargeGas=15,//煤缴费
		ChargeFix=16,//固话宽带缴费
		ChargeOil=17,//加油卡充值
		ChargePhone=18,//充话费
		ChargeTraffic=19,//交通违章缴费
		ChargeTv=20,//有限电视缴费
		ChargeWater=21//水缴费
			
	}

	public enum ServiceType
	{
		Admin=0,//管理员
		Errand=1,//跑腿
		HouseKeep=2,//家政
		Nurse=3,//护理
		Nurse_Admission=4,//入院护理
		Nurse_LateMorning=5,//晨晚护理
		Nurse_Foot=6,//足疗护理
		Nurse_Scrapping=7,//刮痧护理
		Nurse_Mouth=8,//口腔护理
		Nurse_Clinical=9,//临床护理
		Nurese_Skin=10,//皮肤护理
		HouseKeep_Wash=11,//洗衣
		HouseKeep_Clean=12,//保洁
		HouseKeep_Deal=13,//买卖
		HouseKeep_Cook=14,//做饭
		HouseKeep_SchoolRun=15,//接送小孩上学
		HouseKeep_Moon=16,//月嫂
		Errand_OneToTwo=17,//1-2km
		Errand_TwoToThree=18,//2-3km,
		Errand_ThreeToFour,//3-4Km,
		Errand_FourToFive,//4-5km,
		Errand_FiveToSix,//5-6km,
		Errand_SixMore//6km以上

	}

	/// <summary>
	/// 一周
	/// </summary>
	public enum WeekType
	{
		Monday=1,
		Tuesday=2,
		Wednesday=3,
		Thursday=4,
		Friday=5,
		Saturday=6,
		Sunday=7


	}

}

