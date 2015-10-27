using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public class SendCodeParam:BaseParam
	{
		public SendCodeParam ()
		{
		}
		public override string Action {
			get {
				return "SendCode";
			}
		}
		public override string ServiceName {
			get {
				return Global.RegistLoginUrl;
			}
		}
		public string PhoneNumberOne {
			get;
			set;
		}
		public string EphoneNumberOne
		{
			get{
				return EnDeCryptHelp.Encrypt (PhoneNumberOne);
			}
		}
		public string Type {
			get;
			set;
		}
		public string Etype
		{
			get{
				return EnDeCryptHelp.Encrypt (Type);
			}
		}

		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (EphoneNumberOne + Etype + Eaction + Key, Key);
			}
		}
	}
}

