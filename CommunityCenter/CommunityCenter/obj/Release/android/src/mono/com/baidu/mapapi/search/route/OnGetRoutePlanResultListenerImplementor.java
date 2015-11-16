package mono.com.baidu.mapapi.search.route;


public class OnGetRoutePlanResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.search.route.OnGetRoutePlanResultListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onGetDrivingRouteResult:(Lcom/baidu/mapapi/search/route/DrivingRouteResult;)V:GetOnGetDrivingRouteResult_Lcom_baidu_mapapi_search_route_DrivingRouteResult_Handler:Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerInvoker, BaiduMapApiBindingLibrary\n" +
			"n_onGetTransitRouteResult:(Lcom/baidu/mapapi/search/route/TransitRouteResult;)V:GetOnGetTransitRouteResult_Lcom_baidu_mapapi_search_route_TransitRouteResult_Handler:Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerInvoker, BaiduMapApiBindingLibrary\n" +
			"n_onGetWalkingRouteResult:(Lcom/baidu/mapapi/search/route/WalkingRouteResult;)V:GetOnGetWalkingRouteResult_Lcom_baidu_mapapi_search_route_WalkingRouteResult_Handler:Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerInvoker, BaiduMapApiBindingLibrary\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerImplementor, BaiduMapApiBindingLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnGetRoutePlanResultListenerImplementor.class, __md_methods);
	}


	public OnGetRoutePlanResultListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnGetRoutePlanResultListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerImplementor, BaiduMapApiBindingLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onGetDrivingRouteResult (com.baidu.mapapi.search.route.DrivingRouteResult p0)
	{
		n_onGetDrivingRouteResult (p0);
	}

	private native void n_onGetDrivingRouteResult (com.baidu.mapapi.search.route.DrivingRouteResult p0);


	public void onGetTransitRouteResult (com.baidu.mapapi.search.route.TransitRouteResult p0)
	{
		n_onGetTransitRouteResult (p0);
	}

	private native void n_onGetTransitRouteResult (com.baidu.mapapi.search.route.TransitRouteResult p0);


	public void onGetWalkingRouteResult (com.baidu.mapapi.search.route.WalkingRouteResult p0)
	{
		n_onGetWalkingRouteResult (p0);
	}

	private native void n_onGetWalkingRouteResult (com.baidu.mapapi.search.route.WalkingRouteResult p0);

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
