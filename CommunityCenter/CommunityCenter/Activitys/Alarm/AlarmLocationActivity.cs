
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Com.Baidu.Mapapi;
using Com.Baidu.Mapapi.Map;
using Com.Baidu.Mapapi.Model;
using Com.Baidu.Mapapi.Utils;


namespace CommunityCenter.Activitys.Alarm
{
	[Activity (Theme="@style/MyCustomTheme")]			
	public class AlarmLocationActivity : Activity
	{
		// 百度地图控件  
		private MapView mMapView = null;  
		// 百度地图对象  
		private BaiduMap bdMap;  

		private double nPosition, ePosition;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.AlarmLocationLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			InitView ();
		}
		private void InitView()
		{
			//设置标题栏

			var img_header_back = FindViewById<ImageView> (Resource.Id.img_header_back);
			img_header_back.Click += (sender, e) => 
			{
				this.Finish();
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			var bundle = Intent.Extras;
			var alarmPosition = bundle.GetString ("alarmPosition");
			if (!string.IsNullOrEmpty (alarmPosition) && alarmPosition.Contains (",")) {
				var Positions =  alarmPosition.Split(new char[]{','});
				nPosition =  Convert.ToDouble(Positions [0].Substring (1));
				ePosition =  Convert.ToDouble(Positions [1].Substring (1));
			}

			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "报警位置显示";
			mMapView = FindViewById<MapView> (Resource.Id.bmap_view);
			bdMap = mMapView.Map;
			bdMap.MapType = BaiduMap.MapTypeNormal;
			LatLng sourceLatLng = new LatLng(nPosition,ePosition);
     		// 将GPS设备采集的原始GPS坐标转换成百度坐标  
			CoordinateConverter converter  = new CoordinateConverter();  
			converter.From(Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType.Gps);  
			// sourceLatLng待转换坐标  
			converter.Coord(sourceLatLng);  
			LatLng desLatLng = converter.Convert();
			//构建MarkerOption，用于在地图上添加Marker
			//构建Marker图标  
			BitmapDescriptor bitmap = BitmapDescriptorFactory  
				.FromResource(Resource.Drawable.ic_map);  
			OverlayOptions option = new MarkerOptions().InvokePosition (desLatLng).InvokeIcon(bitmap).Draggable(true).InvokeZIndex(9);

			//在地图上添加Marker，并显示  
			bdMap.AddOverlay(option);
			// 将地图移动到覆盖物位置  
			MapStatusUpdate u = MapStatusUpdateFactory.NewLatLng(desLatLng);
			bdMap.SetMapStatus(u);

		}

		protected override void OnResume ()
		{
			base.OnResume ();
			mMapView.OnResume ();
		}

		protected override void OnPause ()
		{
			base.OnPause ();
			mMapView.OnPause ();
		}

		protected override void OnDestroy ()
		{
			mMapView.OnDestroy ();
			mMapView = null;
			base.OnDestroy ();
		}
	}
}

