using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public class UpdateMyInfoParam:BaseParam
	{
		public UpdateMyInfoParam ()
		{
		}
		public override string Action {
			get {
				return string.Empty;
			}
		}
		public override string ServiceName {
			get {
				return Global.UpdatePersonInfoUrl;
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
		public string ParamType {
			get;
			set;
		}
		public string EparamType
		{
			get{
				return EnDeCryptHelp.Encrypt (ParamType);
			}
		}
		public string ParamValue {
			get;
			set;
		}
		public string EparamValue
		{
			get{
				return EnDeCryptHelp.Encrypt (ParamValue);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (Euid + EparamType + EparamValue + Key, Key);
			}
		}
	}
}

