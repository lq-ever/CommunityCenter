
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
using Com.Handmark.Pulltorefresh.Library;

namespace CommunityCenter
{
	public class MainTabFinanceFragment : BaseFragment
	{
		private PullToRefreshScrollView pull_refresh_scroll_finance;
		private TextView tv_totalAssets,tv_availableAssets,tv_frozenAssets;
		private RelativeLayout rl_charge,rl_withDraw,rl_bankCards,rl_DealRecords;
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


		}

		public override void LasyloadData ()
		{
			
		}


	}
}

