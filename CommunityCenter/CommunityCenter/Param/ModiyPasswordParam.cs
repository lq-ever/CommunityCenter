using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public class ModiyPasswordParam:BaseParam
	{
		public ModiyPasswordParam ()
		{
		}
		public override string Action {
			get {
				return "ModiyPassword";
			}
		}
		public override string ServiceName {
			get {
				return Global.RegistLoginUrl;
			}
		}
		public string UId {
			get;
			set;
		}
		public string Euid
		{
			get{
				return EnDeCryptHelp.Encrypt (UId);
			}
		}

		public string Password {
			get;
			set;
		}

		public string Epassword
		{
			get{
				return EnDeCryptHelp.Encrypt (Password);
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
				return EnDeCryptHelp.MD5Encrypt (Euid + Epassword + Etype + Eaction + Key, Key);
			}
		}

	}
}

