using System;
using CommunityCenter.Common;


namespace CommunityCenter.Model
{
	public class PersonInfoItem
	{
		public PersonInfoItem ()
		{
			
		}
		public string UId {
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
		public string IDNumber {
			get;
			set;
		}
		public string PayPassword {
			get;
			set;
		}
		public string Password {
			get;
			set;
		}
		public string Gender {
			get;
			set;
		}
		public string Age {
			get;
			set;
		}
		public string PhoneNumberOne {
			get;
			set;
		}
		public string PhoneNumberTwo {
			get;
			set;
		}
		public string TelePhoneNumber {
			get;
			set;
		}
		public string Email {
			get;
			set;
		}
		public string MailActivation {
			get;
			set;
		}
		public string QQ {
			get;
			set;
		}
		public string QQTakenId {
			get;
			set;
		}
		public string RegisterTime {
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
		/// <summary>
		/// 详细地址
		/// </summary>
		/// <value>The contact address.</value>
		public string ContactAddress {
			get;
			set;
		}
		public string IDAddress {
			get;
			set;
		}
		public string GlyphPassword {
			get;
			set;
		}
		public string IsDelete {
			get;
			set;
		}
		public string DeleteTime {
			get;
			set;
		}
		public string DeleteUserId {
			get;
			set;
		}
		public string HaveFinance {
			get;
			set;
		}
		public string Height {
			get;
			set;
		}
		public string Weight {
			get;
			set;
		}
		public string ChronicDisease {
			get;
			set;
		}
		public string HereditaryDisease {
			get;
			set;
		}
		public string ChronicDiseaseOther {
			get;
			set;
		}
		public string HereditaryDiseaseOther {
			get;
			set;
		}
		public string CId {
			get;
			set;
		}
		public string GlyphPayPassword {
			get;
			set;
		}
	}
}

