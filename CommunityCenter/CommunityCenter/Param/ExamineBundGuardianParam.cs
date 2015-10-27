using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public class ExamineBundGuardianParam:BaseParam
	{
		public ExamineBundGuardianParam ()
		{
		}
		public override string Action {
			get {
				return "ExamineBundGuardian";
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
		public string Ifagreen {
			get;
			set;
		}
		public string Eifagreen {
			get{
				return EnDeCryptHelp.Encrypt (Ifagreen);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (Eaction+Eid+Eifagreen+Key,Key);

			}
		}
	}
}

