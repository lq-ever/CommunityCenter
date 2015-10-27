using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public class LoginInfoParam:BaseParam
	{
		public LoginInfoParam ()
		{
		}
		public override string Action {
			get {
				return "Login";
			}
		}
		public override string ServiceName {
			get {
				return Global.RegistLoginUrl;
			}
		}	
		public string LoginName {
			get;
			set;
		}
		public string EloginName
		{
			get{ return EnDeCryptHelp.Encrypt (LoginName);}
		}

		public string LoginPwd {
			get;
			set;
		}

		public string EloginPwd
		{
			get{ return EnDeCryptHelp.Encrypt(LoginPwd);}
		}

		public override string Md5 {
			get{
				return EnDeCryptHelp.MD5Encrypt (Eaction+EloginName+EloginPwd+Key,Key);
			}
		}
	}
}

