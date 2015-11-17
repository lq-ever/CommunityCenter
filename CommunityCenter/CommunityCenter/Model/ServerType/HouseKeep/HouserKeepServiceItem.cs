using System;

namespace CommunityCenter
{
	public class HouserKeepServiceItem:Java.Lang.Object
	{
		public HouserKeepServiceItem ()
		{
			
		}
		/// <summary>
		/// 服务类型
		/// </summary>
		/// <value>The type of the service.</value>
		public ServiceType ServiceType {
			get;
			set;
		}
		/// <summary>
		/// 图像Id
		/// </summary>
		/// <value>The image identifier.</value>
		public int ImageId {
			get;
			set;
		}
		/// <summary>
		/// 服务名称
		/// </summary>
		/// <value>The name of the service.</value>
		public string ServiceName {
			get;
			set;
		}
		/// <summary>
		/// 服务描述
		/// </summary>
		/// <value>The service desc.</value>
		public string ServiceDesc {
			get;
			set;
		}
		/// <summary>
		/// 一小时费用
		/// </summary>
		/// <value>The Y hour.</value>
		public string YHour {
			get;
			set;
		}
		/// <summary>
		/// 一天费用
		/// </summary>
		/// <value>The Y day.</value>
		public string YDay {
			get;
			set;
		}
		/// <summary>
		/// 是否选择此服务
		/// </summary>
		/// <value><c>true</c> if service choosed; otherwise, <c>false</c>.</value>
		public bool ServiceChoosed {
			get;
			set;
		}

	}
}

