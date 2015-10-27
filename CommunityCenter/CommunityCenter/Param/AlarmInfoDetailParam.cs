using System;
using CommunityCenter.Common;
namespace CommunityCenter.Param
{
	public class AlarmInfoDetailParam:BaseParam
	{
		public AlarmInfoDetailParam ()
		{
		}
		public override string Action {
			get {
				return "SearchAlarmDetailInfor";
			}
		}
		public override string ServiceName {
			get {
				return Global.AlarmUrl;
			}
		}
		/// <summary>
		/// 报警Id
		/// </summary>
		/// <value>A identifier.</value>
		public string AId {
			get;
			set;
		}
		public string EaId
		{
			get{
				return EnDeCryptHelp.Encrypt (AId);
			}
		}

		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (EaId + Eaction + Key, Key);
			}
		}
	}
}

