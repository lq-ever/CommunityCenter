using System;
using CommunityCenter.Common;
namespace CommunityCenter.Param
{
	public class GetMyInfoParam:BaseParam
	{
		public GetMyInfoParam ()
		{
		}
		public override string Action {
			get {
				return "GetMyInfo";
			}
		}
		public override string ServiceName {
			get {
				return Global.RegistLoginUrl;
			}
		}
		public string Uid {
			get;
			set;
		}
		public string Euid
		{
			get{
				return EnDeCryptHelp.Encrypt (Uid);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (Eaction + Euid + Key, Key);
			}
		}
	}
}

