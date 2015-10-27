using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public class AdviceWriteParam:BaseParam
	{
		public AdviceWriteParam ()
		{
		}
		public override string Action {
			get {
				return "WriteAdvice";
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
		public string EadviceType {
			get {
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
		public string AdviceTitle {
			get;
			set;
		}
		public string EadviceTitle
		{
			get{
				return EnDeCryptHelp.Encrypt (AdviceTitle);
			}
		}
		public string AdviceContent {
			get;
			set;
		}
		public string EadviceContent
		{
			get{
				return EnDeCryptHelp.Encrypt (AdviceContent);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (Eaction + EadviceType+EadviceTitle+EadviceContent + Euid + EplatformType+Key, Key);
			}
		}

	}
}

