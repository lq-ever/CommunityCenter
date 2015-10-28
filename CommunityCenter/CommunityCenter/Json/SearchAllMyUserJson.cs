using System;
using System.Collections.Generic;
using CommunityCenter.Model.ServerType.Admin;


namespace CommunityCenter.Json
{
	public class SearchAllMyUserJson:BaseJson
	{
		public SearchAllMyUserJson ()
		{
			data = new List<AllMyUserListItem> ();
		}
		public List<AllMyUserListItem> data {
			get;
			set;
		}
	}



}

