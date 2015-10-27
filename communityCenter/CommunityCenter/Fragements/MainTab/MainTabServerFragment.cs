
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
using CommunityCenter.Adapter;
using CommunityCenter.Model;
using CommunityCenter.Common;

namespace CommunityCenter.Fragments.MainTab
{
	public class MainTabServerFragment : Fragment
	{
		private GridView gv_server;
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
			var tab_serverView = inflater.Inflate (Resource.Layout.Main_Tab_Server, container, false);
			return tab_serverView;
		}
		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);
			InitView ();
		}
		private void InitView()
		{
			gv_server = View.FindViewById<GridView> (Resource.Id.gv_server);
			var adapter = new ServerItemAdapter (Activity);

			adapter.Add(new ServerTypeItem(){ServerTypeName="管理员",ServerTypeImage= Resource.Drawable.Icon});
			adapter.Add (new ServerTypeItem (){ ServerTypeName = "跑腿", ServerTypeImage = Resource.Drawable.Icon });
			adapter.Add(new ServerTypeItem(){ServerTypeName="护理",ServerTypeImage= Resource.Drawable.Icon});
			adapter.Add (new ServerTypeItem (){ ServerTypeName = "家政", ServerTypeImage = Resource.Drawable.Icon });
			gv_server.Adapter = adapter;
			//gridview 单击事件
			gv_server.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => 
			{
				var clickServerType = adapter.GetItem(e.Position).ServerTypeName;
				if(EldYoungUtil.HasLogin)
				{
					Activity.StartActivity(ServerTargetActivityFactory.CreateServerTargetFactory(clickServerType));
					Activity.OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
				}
				else
				{
					EldYoungUtil.StartLoginActivity(Activity);
				}
			};

		}
	}
}

