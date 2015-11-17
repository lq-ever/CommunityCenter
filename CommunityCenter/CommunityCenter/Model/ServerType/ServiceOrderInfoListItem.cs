using System;

namespace CommunityCenter
{
	public class ServiceOrderInfoListItem
	{
		public ServiceOrderInfoListItem ()
		{
		}
		/// <summary>
		/// 服务预约号
		/// </summary>
		/// <value>The service order no.</value>
		public string ServiceOrderNo {
			get;
			set;
		}
		public string ServiceOrderType {
			get;
			set;
		}
		public string ServiceOrderStatus {
			get;
			set;
		}
		public string ServiceOrderAmmount {
			get;
			set;
		}
		public string ServiceOrderTime {
			get;
			set;
		}
		public string ServiceOrderPlaces {
			get;
			set;
		}
		public string ServiceOrderDesc {
			get;
			set;
		}
	}
}

