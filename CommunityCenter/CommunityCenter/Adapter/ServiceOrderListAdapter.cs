using System;
using Android.Widget;
using Android.App;
using Android.Views;

namespace CommunityCenter
{
	public class ServiceOrderListAdapter:ArrayAdapter<ServiceOrderInfoListItem>
	{
		private Activity activity;
		public ServiceOrderListAdapter (Activity _activity):base(_activity,0)
		{
			activity = _activity;
		}
		/// <param name="position">The position of the item within the adapter's data set of the item whose view
		///  we want.</param>
		/// <summary>
		/// 获取列表视图
		/// </summary>
		/// <returns>The view.</returns>
		/// <param name="convertView">Convert view.</param>
		/// <param name="parent">Parent.</param>
		public override Android.Views.View GetView ( int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			ServiceOrderListItemView _serviceOrderListItemView = null;
			var item = GetItem (position);
			if (convertView == null) {

				convertView = LayoutInflater.From (Context).Inflate (Resource.Layout.serviceOrderListItemView, null);
				_serviceOrderListItemView = new ServiceOrderListItemView ();
				_serviceOrderListItemView.tv_OrderSponsor = convertView.FindViewById<TextView> (Resource.Id.tv_OrderSponsor);
				_serviceOrderListItemView.tv_OrderAmmount = convertView.FindViewById<TextView> (Resource.Id.tv_OrderAmmount);
				_serviceOrderListItemView.tv_OrderTime = convertView.FindViewById<TextView> (Resource.Id.tv_OrderTime);
				_serviceOrderListItemView.tv_OrderPlaces = convertView.FindViewById<TextView> (Resource.Id.tv_OrderPlaces);
				convertView.SetTag (Resource.Id.serviceorderlistitemview, (Java.Lang.Object)_serviceOrderListItemView);

			} else
				_serviceOrderListItemView = (ServiceOrderListItemView)convertView.GetTag (Resource.Id.serviceorderlistitemview);
			//赋值


			return convertView;
		}


	}

	/// <summary>
	/// alarm item view.组件
	/// </summary>
	public class ServiceOrderListItemView:Java.Lang.Object
	{
		public TextView tv_OrderSponsor;
		public TextView tv_OrderAmmount;
		public TextView tv_OrderTime;
		public TextView tv_OrderPlaces;
	}
}

