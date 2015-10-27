using System;

namespace CommunityCenter.Model.Alarm
{
	public class AllMyUserListItem
	{
		public AllMyUserListItem ()
		{
		}
		/// <summary>
		/// 用户Id
		/// </summary>
		/// <value>The U identifier.</value>
		public string UId {
			get;
			set;
		}
		/// <summary>
		/// 真实名称
		/// </summary>
		/// <value>The U identifier.</value>
		public string TrueName {
			get;
			set;
		}
		public override string ToString ()
		{
			return TrueName;
		}
	}
}

