using System;
using CommunityCenter.Common;
namespace CommunityCenter.Param
{
	public class GuardianDetailInfoParam:BaseParam
	{
		//监护人详情
		public GuardianDetailInfoParam ()
		{
		}
		public override string Action {
			get {
				return "SeachUserDetail";
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
		public string Eid {
			get{
				return EnDeCryptHelp.Encrypt (Id);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (Eaction+Eid+Key,Key);
			}
		}
	}
}

