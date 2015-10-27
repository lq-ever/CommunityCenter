using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public class AdviceRecordInfoListParam:BaseParam
	{
		public AdviceRecordInfoListParam ()
		{
		}
		public override string Action {
			get {

				return "GetAdviceRecod";
			}
		}

		public override string ServiceName {
			get {
				return Global.AdviceInfoUrl;
			}
		}

		public string UId {
			get;
			set;
		}
		public string Euid
		{
			get {
				return EnDeCryptHelp.Encrypt (UId);
			}
		}
		public string AdviceType {
			get;
			set;
		}
		public string EadviceType
		{
			get{
				return EnDeCryptHelp.Encrypt (AdviceType);
			}
		}
		public string PlatformType
		{
			get{
				return "0";//个人中心
			}
		}
		public string EplatformType
		{
			get{
				return EnDeCryptHelp.Encrypt (PlatformType);
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
				return EnDeCryptHelp.MD5Encrypt(Eaction + EadviceType + Euid  + EpageIndex + EpageSize +EplatformType+ Key, Key);
			}
		}




	}
}

