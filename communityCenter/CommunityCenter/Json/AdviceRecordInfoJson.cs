using System;
using System.Collections.Generic;
using CommunityCenter.Model;


namespace CommunityCenter.Json
{
	public class AdviceRecordInfoJson:BaseJson
	{
		public AdviceRecordInfoJson ()
		{
			data = new AdviceRecordListInfoDataJson ();
		}
		public AdviceRecordListInfoDataJson data {
			get;
			set;
		}
	}

	public class AdviceRecordListInfoDataJson
	{
		public AdviceRecordListInfoDataJson()
		{
			items = new List<AdviceRecordInfoItem> ();
		}
		public int total {
			get;
			set;
		}
		public List<AdviceRecordInfoItem> items {
			get;
			set;
		}
	}
}

