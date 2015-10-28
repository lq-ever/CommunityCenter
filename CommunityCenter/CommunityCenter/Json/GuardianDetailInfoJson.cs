using System;
using System.Collections.Generic;
using CommunityCenter.Model.ServerType.Admin;

namespace CommunityCenter.Json
{
	public class GuardianDetailInfoJson:BaseJson 
	{
		public GuardianDetailInfoJson ()
		{
			data = new List<GuardianDetailInfoItem> ();
		}
		public List<GuardianDetailInfoItem> data {
			get;
			set;
		}
	}
}

