using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public class RegisterInfoParam:BaseParam
	{
		public RegisterInfoParam ()
		{
		}

		public override string Action
		{
			get {
				return "Register";
			}
		}

		public override string ServiceName {
			get {
				return Global.RegistLoginUrl;
			}
		}
		public string PhoneNumber {
			get;
			set;
		}
		public string EphoneNumber
		{
			get{ return EnDeCryptHelp.Encrypt (PhoneNumber);}
		}
		public string PassWord {
			get;
			set;
		}
		public string EpassWord
		{
			get{
				return EnDeCryptHelp.Encrypt (PassWord);
			}
		}
		public string NickName {
			get;
			set;
		}
		public string EnickName
		{
			get{
				return EnDeCryptHelp.Encrypt (NickName);
			}
		}

		public override string Md5 {
			get{
				return EnDeCryptHelp.MD5Encrypt (Eaction+EphoneNumber+EpassWord+EnickName+Key,Key);
			}
		}

	


	}
}

