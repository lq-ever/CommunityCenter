using System;
using Android.Widget;
using CommunityCenter.Model;
using Android.App;
using Android.Views;

namespace CommunityCenter.Adapter
{
	public class ServerItemAdapter:ArrayAdapter<ServerTypeItem>
	{
		private Activity activity;
		public ServerItemAdapter (Activity _activity):base(_activity,0)
		{
			activity = _activity;
		}
		public override Android.Views.View GetView ( int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			ServerItemView _serverItemView = null;
			var item = GetItem (position);
			if (convertView == null) {

				convertView = LayoutInflater.From (Context).Inflate (Resource.Layout.ServerGridItemView, null);
				_serverItemView = new ServerItemView ();
				_serverItemView.img_server = convertView.FindViewById<ImageView> (Resource.Id.img_server);
				_serverItemView.tv_server= convertView.FindViewById<TextView> (Resource.Id.tv_server);


				convertView.SetTag (Resource.Id.serveritemview, (Java.Lang.Object)_serverItemView);

			} else
				_serverItemView = (ServerItemView)convertView.GetTag (Resource.Id.serveritemview);

			_serverItemView.img_server.SetImageResource (item.ServerTypeImage);
			_serverItemView.tv_server.Text = item.ServerTypeName;
			return convertView;
		}
	}

	/// <summary>
	/// server item view.组件
	/// </summary>
	public class ServerItemView:Java.Lang.Object
	{
		public TextView tv_server;
		public ImageView img_server;

	}
}

