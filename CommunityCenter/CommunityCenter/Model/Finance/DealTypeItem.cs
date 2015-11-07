using System;

namespace CommunityCenter.Model.Finance
{
	public class DealTypeItem
	{
		public DealTypeItem ()
		{
		}
		public string DealTypeId {
			get;
			set;
		}
		public string DealTypeDesc {
			get;
			set;
		}

		public override string ToString ()
		{
			return DealTypeDesc;
		}
	}
}

