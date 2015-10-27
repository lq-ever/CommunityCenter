using System;
using CommunityCenter.Common;


namespace CommunityCenter.Param
{
	public class UpdatePersonInfoParam:BaseParam
	{
		public UpdatePersonInfoParam ()
		{
		}
		public override string Action {
			get {
				return string.Empty;
			}
		}
		public override string ServiceName {
			get {
				return Global.UpdatePersonInfoUrl;
			}
		}

		public string Uid {
			get;
			set;
		}
		public string Euid
		{
			get{
				return EnDeCryptHelp.Encrypt (Uid);
			}
		}
		public string TrueName {
			get;
			set;
		}
		public string EtrueName
		{
			get{
				return EnDeCryptHelp.Encrypt (TrueName);
			}
		}
		public string IdCardNo {
			get;
			set;
		}
		public string EidCardNo
		{
			get {
				return EnDeCryptHelp.Encrypt (IdCardNo);
			}
		}
		public string Gender {
			get;
			set;
		}
		public string Egender {
			get{
				return EnDeCryptHelp.Encrypt (Gender);
			}
		}
		public string Birth {
			get;
			set;
		}
		public string Ebirth
		{
			get {
				return EnDeCryptHelp.Encrypt (Birth);
			}
		}
		public string PhoneNumberOne {
			get;
			set;
		}
		public string EphoneNumberOne
		{
			get{
				return EnDeCryptHelp.Encrypt (PhoneNumberOne);
			}
		}
		public string FixedPhone {
			get;
			set;
		}
		public string EfixedPhone
		{
			get{
				return	EnDeCryptHelp.Encrypt (FixedPhone);
			}
		}
		public string Email {
			get;
			set;
		}
		public string Eemail
		{
			get{
				return EnDeCryptHelp.Encrypt (Email);
			}
		}

		public string IdCardLocation {
			get;
			set;
		}
		public string EidCardLocation
		{
			get{
				return EnDeCryptHelp.Encrypt (IdCardLocation);
			}
		}

		public string TrueAddress {
			get;
			set;
		}

		public string EtrueAddress
		{
			get {
				return EnDeCryptHelp.Encrypt (TrueAddress);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (Euid+EtrueName+EidCardNo+Egender+Ebirth+EphoneNumberOne+EfixedPhone+Eemail+EidCardLocation+EtrueAddress+Key,Key);
			}
		}

	}
}

