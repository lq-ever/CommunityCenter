using System;

namespace CommunityCenter.Json
{
	public class GetAppVersionJson:BaseJson
	{
		public GetAppVersionJson ()
		{
			data = new VersionJsonData ();
		}
		public VersionJsonData data {
			get;
			set;
		}
	
	}
	public class VersionJsonData
	{
		public string AppFilePath {
			get;
			set;
		}
		public string AppServerVersionCode {
			get;
			set;
		}
	}
}

 