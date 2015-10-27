using System;
using Android.App;
using CommunityCenter.Activitys.ServerType.Admin;
using CommunityCenter.Activitys.ServerType.Errand;
using CommunityCenter.Activitys.Nurse;
using CommunityCenter.Activitys.HouseKeep;

namespace CommunityCenter.Common
{
	public class ServerTargetActivityFactory
	{
		
		public ServerTargetActivityFactory ()
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
	}
}

