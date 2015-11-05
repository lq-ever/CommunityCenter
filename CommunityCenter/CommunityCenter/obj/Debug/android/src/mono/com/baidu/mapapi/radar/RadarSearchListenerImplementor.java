package mono.com.baidu.mapapi.radar;


public class RadarSearchListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.radar.RadarSearchListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onGetClearInfoState:(Lcom/baidu/mapapi/radar/RadarSearchError;)V:GetOnGetClearInfoState_Lcom_baidu_mapapi_radar_RadarSearchError_Handler:Com.Baidu.Mapapi.Radar.IRadarSearchListenerInvoker, BaiduMapApiBindingLibrary\n" +
			"n_onGetNearbyInfoList:(Lcom/baidu/mapapi/radar/RadarNearbyResult;Lcom/baidu/mapapi/radar/RadarSearchError;)V:GetOnGetNearbyInfoList_Lcom_baidu_mapapi_radar_RadarNearbyResult_Lcom_baidu_mapapi_radar_RadarSearchError_Handler:Com.Baidu.Mapapi.Radar.IRadarSearchListenerInvoker, BaiduMapApiBindingLibrary\n" +
			"n_onGetUploadState:(Lcom/baidu/mapapi/radar/RadarSearchError;)V:GetOnGetUploadState_Lcom_baidu_mapapi_radar_RadarSearchError_Handler:Com.Baidu.Mapapi.Radar.IRadarSearchListenerInvoker, BaiduMapApiBindingLibrary\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Radar.IRadarSearchListenerImplementor, BaiduMapApiBindingLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RadarSearchListenerImplementor.class, __md_methods);
	}


	public RadarSearchListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RadarSearchListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Radar.IRadarSearchListenerImplementor, BaiduMapApiBindingLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onGetClearInfoState (com.baidu.mapapi.radar.RadarSearchError p0)
	{
		n_onGetClearInfoState (p0);
	}

	private native void n_onGetClearInfoState (com.baidu.mapapi.radar.RadarSearchError p0);


	public void onGetNearbyInfoList (com.baidu.mapapi.radar.RadarNearbyResult p0, com.baidu.mapapi.radar.RadarSearchError p1)
	{
		n_onGetNearbyInfoList (p0, p1);
	}

	private native void n_onGetNearbyInfoList (com.baidu.mapapi.radar.RadarNearbyResult p0, com.baidu.mapapi.radar.RadarSearchError p1);


	public void onGetUploadState (com.baidu.mapapi.radar.RadarSearchError p0)
	{
		n_onGetUploadState (p0);
	}

	private native void n_onGetUploadState (com.baidu.mapapi.radar.RadarSearchError p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
