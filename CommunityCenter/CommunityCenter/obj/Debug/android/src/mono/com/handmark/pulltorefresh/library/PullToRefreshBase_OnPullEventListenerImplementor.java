package mono.com.handmark.pulltorefresh.library;


public class PullToRefreshBase_OnPullEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.handmark.pulltorefresh.library.PullToRefreshBase.OnPullEventListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onPullEvent:(Lcom/handmark/pulltorefresh/library/PullToRefreshBase;Lcom/handmark/pulltorefresh/library/PullToRefreshBase$State;Lcom/handmark/pulltorefresh/library/PullToRefreshBase$Mode;)V:GetOnPullEvent_Lcom_handmark_pulltorefresh_library_PullToRefreshBase_Lcom_handmark_pulltorefresh_library_PullToRefreshBase_State_Lcom_handmark_pulltorefresh_library_PullToRefreshBase_Mode_Handler:Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnPullEventListenerInvoker, PullToRefresh\n" +
			"";
		mono.android.Runtime.register ("Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnPullEventListenerImplementor, PullToRefresh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PullToRefreshBase_OnPullEventListenerImplementor.class, __md_methods);
	}


	public PullToRefreshBase_OnPullEventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PullToRefreshBase_OnPullEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnPullEventListenerImplementor, PullToRefresh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onPullEvent (com.handmark.pulltorefresh.library.PullToRefreshBase p0, com.handmark.pulltorefresh.library.PullToRefreshBase.State p1, com.handmark.pulltorefresh.library.PullToRefreshBase.Mode p2)
	{
		n_onPullEvent (p0, p1, p2);
	}

	private native void n_onPullEvent (com.handmark.pulltorefresh.library.PullToRefreshBase p0, com.handmark.pulltorefresh.library.PullToRefreshBase.State p1, com.handmark.pulltorefresh.library.PullToRefreshBase.Mode p2);

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
