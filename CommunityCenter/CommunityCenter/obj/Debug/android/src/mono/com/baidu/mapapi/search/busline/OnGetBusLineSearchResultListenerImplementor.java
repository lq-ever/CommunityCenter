package mono.com.baidu.mapapi.search.busline;


public class OnGetBusLineSearchResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.search.busline.OnGetBusLineSearchResultListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onGetBusLineResult:(Lcom/baidu/mapapi/search/busline/BusLineResult;)V:GetOnGetBusLineResult_Lcom_baidu_mapapi_search_busline_BusLineResult_Handler:Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListenerInvoker, BaiduMapApiBindingLibrary\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListenerImplementor, BaiduMapApiBindingLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnGetBusLineSearchResultListenerImplementor.class, __md_methods);
	}


	public OnGetBusLineSearchResultListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnGetBusLineSearchResultListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListenerImplementor, BaiduMapApiBindingLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onGetBusLineResult (com.baidu.mapapi.search.busline.BusLineResult p0)
	{
		n_onGetBusLineResult (p0);
	}

	private native void n_onGetBusLineResult (com.baidu.mapapi.search.busline.BusLineResult p0);

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
