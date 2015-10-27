using System;
using System.Collections.Generic;
using CommunityCenter.Model.ServerType.Admin;


namespace CommunityCenter.Json
{
	public class GetApplyInfoJson:BaseJson
	{
		public GetApplyInfoJson ()
		{
			data = new List<GetApplyInfoListItem> ();
		}
		public List<GetApplyInfoListItem> data {
			get;
			set;
		}
	}
}

