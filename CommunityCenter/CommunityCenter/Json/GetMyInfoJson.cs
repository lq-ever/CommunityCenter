using System;
using System.Collections.Generic;
using CommunityCenter.Model;

namespace CommunityCenter.Json
{
	public class GetMyInfoJson:BaseJson
	{
		public GetMyInfoJson ()
		{
			data = new List<PersonInfoItem>();
		}
		public  List<PersonInfoItem> data {
			get;
			set;
		}
	}

}

