using System;

namespace CommunityCenter
{
	public class WeekItem
	{
		public WeekItem ()
		{
		}
		public WeekType Week {
			get;
			set;
		}
		public string WeekDesc {
			get;
			set;
		}
		public override string ToString ()
		{
			return WeekDesc;
		}
	}
}

