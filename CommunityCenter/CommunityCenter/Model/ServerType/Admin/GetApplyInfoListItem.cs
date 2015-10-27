using System;
using CommunityCenter.Common;


namespace CommunityCenter.Model.ServerType.Admin
{
	public class GetApplyInfoListItem:Java.Lang.Object
	{
		public GetApplyInfoListItem ()
		{
		}
		public string Id {
			get;
			set;
		}
		public string IsPass {
			get;
			set;
		}
		public string UserName {
			get;
			set;
		}
		public string TrueName {
			get;
			set;
		}
		public string PhoneNumberOne {
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
		public Sex  Sex {
			get {
				return Gender == "0" ? Sex.Male : Sex.Female;
			}


		}

		public string Gender {
			get;
			set;
		}
		public string UId {
			get;
			set;
		}
		public string GId {
			get;
			set;
		}

		/// <summary>
		/// 申请的留言
		/// </summary>
		/// <value>The remark.</value>
		public string Remark {
			get;
			set;
		}

		public string CreateTime {
			get;
			set;
		}
		/// <summary>
		/// 绑定方向:作为监护人1，被监护人0
		/// </summary>
		/// <value>The bind deriction.</value>
		public int BindDeriction
		{
			get {
				if (UId == Global.MyInfo.UId && GId == Global.MyInfo.UId)//特殊情况，自己申请自己为监护人
					return 1;
				return UId == Global.MyInfo.UId ? 0 : 1;
			}
		}
	}
}

