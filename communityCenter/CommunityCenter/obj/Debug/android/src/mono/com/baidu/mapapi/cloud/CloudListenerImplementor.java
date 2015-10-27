package mono.com.baidu.mapapi.cloud;


public class CloudListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.cloud.CloudListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onGetDetailSearchResult:(Lcom/baidu/mapapi/cloud/DetailSearchResult;I)V:GetOnGetDetailSearchResult_Lcom_baidu_mapapi_cloud_DetailSearchResult_IHandler:Com.Baidu.Mapapi.Cloud.ICloudListenerInvoker, BaiduMapApiBindingLibrary\n" +
			"n_onGetSearchResult:(Lcom/baidu/mapapi/cloud/CloudSearchResult;I)V:GetOnGetSearchResult_Lcom_baidu_mapapi_cloud_CloudSearchResult_IHandler:Com.Baidu.Mapapi.Cloud.ICloudListenerInvoker, BaiduMapApiBindingLibrary\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Cloud.ICloudListenerImplementor, BaiduMapApiBindingLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CloudListenerImplementor.class, __md_methods);
	}


	public CloudListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CloudListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Cloud.ICloudListenerImplementor, BaiduMapApiBindingLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onGetDetailSearchResult (com.baidu.mapapi.cloud.DetailSearchResult p0, int p1)
	{
		n_onGetDetailSearchResult (p0, p1);
	}

	private native void n_onGetDetailSearchResult (com.baidu.mapapi.cloud.DetailSearchResult p0, int p1);


	public void onGetSearchResult (com.baidu.mapapi.cloud.CloudSearchResult p0, int p1)
	{
		n_onGetSearchResult (p0, p1);
	}

	private native void n_onGetSearchResult (com.baidu.mapapi.cloud.CloudSearchResult p0, int p1);

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
