using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public abstract class BaseParam
	{
		public string Key
		{
			get{
				return Global.AndroidKey;
			}
		}

		/// <summary>
		/// 方法名
		/// </summary>
		/// <value>The action.</value>
		public abstract string Action {
			get;

		}

		public string Eaction
		{
			get{ return EnDeCryptHelp.Encrypt (Action);}
		}


		public abstract string ServiceName {
			get;
		}

		/// <summary>
		/// 后台处理程序文件Url
		/// </summary>
		/// <value>The API handler.</value>
		public string Url {
			get {
				return Global.AndroidReleaseServerPath+ServiceName;
				//return Global.AndroidLocalServerPath + ServiceName;
			}

		}

		public abstract string Md5 {
			get;
		}



	}
}

