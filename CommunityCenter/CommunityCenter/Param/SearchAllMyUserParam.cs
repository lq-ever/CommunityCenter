using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public class SearchAllMyUserParam:BaseParam
	{
		public SearchAllMyUserParam ()
		{
		}
		public override string Action {
			get {
				return "SearchAllMyUser";
			}
		}
		public override string ServiceName {
			get {
				return Global.AlarmUrl;
			}
		}
		public string UserId {
			get;
			set;
		}
		public string EuserId
		{
			get{
				return	EnDeCryptHelp.Encrypt (UserId);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (EuserId + Eaction + Key, Key);
			}
		}
	}
}

