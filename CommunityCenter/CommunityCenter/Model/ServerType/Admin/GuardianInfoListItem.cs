using System;
using CommunityCenter.Common;


namespace CommunityCenter.Model.ServerType.Admin
{
	/// <summary>
	/// 监护人列表对象.
	/// </summary>
	public class GuardianInfoListItem:Java.Lang.Object
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EldYoungAndroidApp.Model.Guardian.GuardianInfoListItem"/> class.
		/// </summary>
		public GuardianInfoListItem ()
		{
		}

		public string Id {
			get;
			set;
		}
		public string UId {
			get;
			set;
		}
		public string HeadImgUrl {
			get;
			set;
		}

		public string HeadImgReleaseUrl
		{
			get{
				return Global.AndroidReleaseHeadImgPre + HeadImgUrl;
			}
		}
		public string TrueName {
			get;
			set;
		}

		public Sex  Sex {
			get {
				return Gender == "男" ? Sex.Male : Sex.Female;
			}


		}

		public string Gender {
			get;
			set;
		}

		public string PhoneNumberOne {
			get;
			set;
		}

		public string ContactAddress {
			get;
			set;
		}

	}
}

