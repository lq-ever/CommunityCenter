
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Android.Support.V4.Widget;
using System.Threading.Tasks;
using System.Threading;

namespace CommunityCenter
{
	public class MainTabFinanceFragment : Fragment,SwipeRefreshLayout.IOnRefreshListener
	{
		private SwipeRefreshLayout swipeRefreshLayout;
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);

			base.OnCreateView (inflater, container, savedInstanceState);
			var tab_financeView = inflater.Inflate (Resource.Layout.Main_Tab_Finance, container, false);
			return tab_financeView;
		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);
			swipeRefreshLayout = View.FindViewById<SwipeRefreshLayout>(Resource.Id.swipe_container);
			swipeRefreshLayout.SetColorSchemeResources (Android.Resource.Color.HoloBlueLight, Android.Resource.Color.HoloRedLight, Android.Resource.Color.HoloOrangeLight, Android.Resource.Color.HoloGreenLight);
			swipeRefreshLayout.SetOnRefreshListener (this);
			swipeRefreshLayout.Refreshing = true;
		}
		public void OnRefresh ()
		{
			Task.Factory.StartNew (() => {
				Thread.Sleep(3000);
				swipeRefreshLayout.Refreshing = false;
			});
		}

	}
}

