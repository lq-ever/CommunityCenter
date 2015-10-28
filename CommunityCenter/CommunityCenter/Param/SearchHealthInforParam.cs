using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	/// <summary>
	/// 查询健康信息请求参数类
	/// </summary>
	public class SearchHealthInforParam:BaseParam
	{
		public SearchHealthInforParam ()
		{
		}
		public override string Action {
			get {
				return "SearchHealthInfor";
			}
		}
		public override string ServiceName {
			get {
				return Global.HealthInfoUrl;
			}
		}
		public string Id {
			get;
			set;
		}
		public string Eid
		{
			get {
				return EnDeCryptHelp.Encrypt (Id);
			}
		}
		public string SearchTime {
			get;
			set;
		}
		public string EsearchTime
		{
			get{
				return EnDeCryptHelp.Encrypt (SearchTime);
			}
		}
		public string PageIndex {
			get;
			set;
		}
		public string EpageIndex
		{
			get {
				return EnDeCryptHelp.Encrypt (PageIndex);
			}
		}
		public string PageSize {
			get {
				return "7";
			}
		}
		public string EpageSize {
			get{
				return EnDeCryptHelp.Encrypt (PageSize);
			}
		}
	    public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (Eaction + Eid + EsearchTime+EpageIndex+EpageSize + Key, Key);
			}
		}

	}
}

