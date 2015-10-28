using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public class AlarmInfoListParam:BaseParam
	{
		public AlarmInfoListParam ()
		{
		}

		public override string Action {
			get {
				return "SearchAlarmInfor";
			}
		}

		public override string ServiceName {
			get {
				return Global.AlarmUrl;
			}
		}
		/// <summary>
		/// 报警方式
		/// </summary>
		/// <value>The type of the alarm.</value>
		public string AlarmType {
			get;
			set;
		}
		public string EalarmType
		{
			get{
				return EnDeCryptHelp.Encrypt (AlarmType);
			}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		/// <value>The user identifier.</value>
		public string UserId {
			get;
			set;
		}

		public string EuserId {
			get{
				return EnDeCryptHelp.Encrypt (UserId);
			}
		}
		/// <summary>
		/// 开始时间
		/// </summary>
		/// <value>The start time.</value>
		public string StartTime {
			get;
			set;
		}
		public string EstartTime
		{
			get {
				return EnDeCryptHelp.Encrypt (StartTime);
			}
		}
		/// <summary>
		/// 结束时间
		/// </summary>
		/// <value>The end time.</value>
		public string EndTime {
			get;
			set;
		}
		public string EendTime
		{
			get{
				return EnDeCryptHelp.Encrypt (EndTime);
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
				return EnDeCryptHelp.MD5Encrypt (Eaction + EalarmType + EuserId + EstartTime + EendTime + EpageIndex + EpageSize + Key, Key);
			}
		}


	}
}

