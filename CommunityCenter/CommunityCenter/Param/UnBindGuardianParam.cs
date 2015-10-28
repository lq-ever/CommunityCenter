using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	/// <summary>
	/// 解绑参数对象
	/// </summary>
	public class UnBindGuardianParam:BaseParam
	{
		public UnBindGuardianParam ()
		{
			
		}
		public override string Action {
			get {
				return "UnBundGuardian";
			}
		}
		public override string ServiceName {
			get {
				return Global.GuardianUrl;
			}
		}
		public string Id {
			get;
			set;
		}
		public string Eid
		{
			get {
				return EnDeCryptHelp.Encrypt (Id);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (Eaction + Eid + Key, Key);
			}
		}
	}
}

