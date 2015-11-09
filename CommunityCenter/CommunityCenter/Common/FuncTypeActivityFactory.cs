using System;
using Android.App;
using CommunityCenter.Activitys.ServerType.Admin;
using CommunityCenter.Activitys.ServerType.Errand;
using CommunityCenter.Activitys.Nurse;
using CommunityCenter.Activitys.HouseKeep;
using CommunityCenter.Activitys.My;
using CommunityCenter.Activitys.Finance;

namespace CommunityCenter.Common
{
	public class FuncTypeActivityFactory
	{
		
		public FuncTypeActivityFactory ()
		{
			
		}
		/// <summary>
		/// 根据服务类型创建服务activity
		/// </summary>
		/// <returns>The server target factory.</returns>
		/// <param name="serverTypeName">Server type name.</param>
		public static Type CreateServerTargetFactory(string serverTypeName)
		{
			Type _activityType = null;
			switch (serverTypeName) {
			case "管理员":
				_activityType = typeof(AdminMainActivity);
				break;
			case "跑腿":
				_activityType = typeof(ErrandMainActivity);
				break;
			case "护理":
				_activityType = typeof(NurseMainActivity);
				break;
			case "家政":
				_activityType = typeof(HouseKeepMainActivity);
				break;
			}
			return _activityType;
		}
		/// <summary>
		/// 根据功能类型创建对应activitytype
		/// </summary>
		/// <returns>The server target factory.</returns>
		/// <param name="serverTypeName">Server type name.</param>
		public static Type CreateFuncActivityFactory(int _funcActivityType)
		{
			Type _activityType = null; 
			switch (_funcActivityType) {
			case (int)FuncActivityType.Main:
				_activityType = typeof(MainActivity);
				break;
			case (int)FuncActivityType.AccountSecurity:
				_activityType = typeof(AccountSecurityActivity);
				break;
			case (int) FuncActivityType.AdminMain:
				_activityType = typeof(AdminMainActivity);
				break;
			case (int)FuncActivityType.HouseKeepMain:
				_activityType = typeof(HouseKeepMainActivity);
				break;
			case (int)FuncActivityType.ErrandMain:
				_activityType = typeof(ErrandMainActivity);
				break;
			case (int)FuncActivityType.NurseMain:
				_activityType = typeof(NurseMainActivity);
				break;
			case (int)FuncActivityType.Advice:
				_activityType = typeof(AdviceActivity);
				break;
			case (int)FuncActivityType.Certificate:
				_activityType = typeof(CertificateActivity);
				break;
			case (int)FuncActivityType.PersonInfo:
				_activityType = typeof(PersonInfoActivity);
				break;
			case (int)FuncActivityType.Charge:
				_activityType = typeof(ChargeActivity);
				break;
			case (int)FuncActivityType.WithDraw:
				_activityType = typeof(WithDrawActivity);
				break;
			case (int)FuncActivityType.BankCards:
				_activityType = typeof(BankCardsActivity);
				break;
			case (int)FuncActivityType.DealRecords:
				_activityType = typeof(DealRecordsActivity);
				break;
			case (int)FuncActivityType.DailyPay:
				_activityType = typeof(DailyPayActivity);
				break;
			}
			return _activityType;
		}
	}
}

