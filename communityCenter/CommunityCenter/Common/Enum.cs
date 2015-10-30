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
		DealRecords=12//交易记录
	}

}

