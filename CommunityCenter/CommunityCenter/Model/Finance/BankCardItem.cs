using System;

namespace CommunityCenter.Model.Finance
{
	public class BankCardItem
	{
		public BankCardItem ()
		{
		}
		/// <summary>
		/// 银行卡卡号
		/// </summary>
		/// <value>The bank card no.</value>
		public string BankCardNo {
			get;
			set;
		}
		/// <summary>
		/// 银行卡图片地址
		/// </summary>
		/// <value>The bank card image URL.</value>
		public string BankCardImageUrl {
			get;
			set;
		}
		/// <summary>
		/// 银行卡类型Id
		/// </summary>
		/// <value>The bank card type identifier.</value>
		public string BankCardTypeId {
			get; 
			set;
		}

		public string BankCardTypeDesc {
			get;
			set;
		}

	}
}

