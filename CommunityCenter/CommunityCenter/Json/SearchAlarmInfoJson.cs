using System;

using System.Collections.Generic;
using CommunityCenter.Model.ServerType.Admin;

namespace CommunityCenter.Json
{
	public class SearchAlarmInfoJson:BaseJson
	{
		public SearchAlarmInfoJson ()
		{
			data = new AlarmInfoListdataJson ();
		}
		public AlarmInfoListdataJson data {
			get;
			set;
		}

	}
	public class AlarmInfoListdataJson
	{
		public AlarmInfoListdataJson()
		{
			items = new List<AlarmInfoListItem> ();
		}
		public int total {
			get;
			set;
		}

		public List<AlarmInfoListItem> items {
			get;
			set;
		}
	}


}

