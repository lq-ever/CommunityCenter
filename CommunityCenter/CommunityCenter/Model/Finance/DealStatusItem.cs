using System;

namespace CommunityCenter.Model.Finance
{
	public class DealStatusItem
	{
		public DealStatusItem ()
		{
		}
		public string DealStatusId {
			get;
			set;
		}
		public string DealStatusDesc {
			get;
			set;
		}
		public override string ToString ()
		{
			return DealStatusDesc;
		}
	}
}

