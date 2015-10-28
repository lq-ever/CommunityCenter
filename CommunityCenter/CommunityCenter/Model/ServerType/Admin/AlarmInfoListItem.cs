using System;

namespace CommunityCenter.Model.ServerType.Admin
{
	public class AlarmInfoListItem:Java.Lang.Object
	{
		public AlarmInfoListItem ()
		{
		}
		public string AId {
			get;
			set;
		}
		public string AlarmTime {
			get;
			set;
		}
		public string TrueName {
			get;
			set;
		}
		public string AlarmContent {
			get;
			set;
		}
		public string Status {
			get;
			set;
		}
	}
}

