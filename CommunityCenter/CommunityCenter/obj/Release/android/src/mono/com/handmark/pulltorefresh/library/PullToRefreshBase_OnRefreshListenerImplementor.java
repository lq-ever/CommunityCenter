package mono.com.handmark.pulltorefresh.library;


public class PullToRefreshBase_OnRefreshListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.handmark.pulltorefresh.library.PullToRefreshBase.OnRefreshListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onRefresh:(Lcom/handmark/pulltorefresh/library/PullToRefreshBase;)V:GetOnRefresh_Lcom_handmark_pulltorefresh_library_PullToRefreshBase_Handler:Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnRefreshListenerInvoker, PullToRefresh\n" +
			"";
		mono.android.Runtime.register ("Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnRefreshListenerImplementor, PullToRefresh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PullToRefreshBase_OnRefreshListenerImplementor.class, __md_methods);
	}


	public PullToRefreshBase_OnRefreshListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PullToRefreshBase_OnRefreshListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnRefreshListenerImplementor, PullToRefresh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onRefresh (com.handmark.pulltorefresh.library.PullToRefreshBase p0)
	{
		n_onRefresh (p0);
	}

	private native void n_onRefresh (com.handmark.pulltorefresh.library.PullToRefreshBase p0);

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
