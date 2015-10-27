using System;

namespace CommunityCenter.Json
{
	public class RegisterJson:BaseJson
	{
		public RegisterJson ()
		{
			data = new LoginJsonData ();
		}
		public LoginJsonData data {
			get;
			set;
		}
	}
}

