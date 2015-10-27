using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public class GetAppVersionParam:BaseParam
	{
		public GetAppVersionParam ()
		{
		}
		public override string Action {
			get {
				return string.Empty;
			}
		}
		public override string ServiceName {
			get {
				return Global.GetAppVersionUrl;
			}
		}
		public string AppPlatform {
			get{
				return Global.app_platform;
			}
		}
		public string EappPlatform
		{
			get{
				return EnDeCryptHelp.Encrypt (AppPlatform);
			}
		}
		public string PackageName
		{
			get{
				return Global.package_name;
			}
		}
		public string EpackageName
		{
			get{
				return EnDeCryptHelp.Encrypt (PackageName);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (EappPlatform + EpackageName + Key, Key);
			}
		}
	}
}

