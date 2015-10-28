using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public class MineGuardianInfoListParam:BaseParam
	{
		public MineGuardianInfoListParam ()
		{
		}
		public override string Action {
			get {
				return "MineCustodyUsers";
			}
		}
		public override string ServiceName {
			get {
				return Global.GuardianUrl;
			}
		}
		public string UserId {
			get;
			set;
		}
		public string EuserId
		{
			get{
				return EnDeCryptHelp.Encrypt (UserId);
			}
		}

		/// <summary>
		/// 当前页码
		/// </summary>
		/// <value>The index of the page.</value>
		public string PageIndex {
			get;
			set;
		}
		public string EpageIndex
		{
			get{
				return EnDeCryptHelp.Encrypt(PageIndex);
			}
		}
		/// <summary>
		/// 每页数
		/// </summary>
		/// <value>The size of the page.</value>
		public string PageSize
		{
			get{
				return "6";
			}
		}
		public string EpageSize
		{
			get {
				return EnDeCryptHelp.Encrypt (PageSize);
			}
		}

		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (Eaction + EuserId + EpageIndex + EpageSize + Key, Key);
			}
		}

	}
}

