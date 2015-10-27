package mono.com.handmark.pulltorefresh.library;


public class PullToRefreshBase_OnSmoothScrollFinishedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.handmark.pulltorefresh.library.PullToRefreshBase.OnSmoothScrollFinishedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onSmoothScrollFinished:()V:GetOnSmoothScrollFinishedHandler:Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnSmoothScrollFinishedListenerInvoker, PullToRefresh\n" +
			"";
		mono.android.Runtime.register ("Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnSmoothScrollFinishedListenerImplementor, PullToRefresh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PullToRefreshBase_OnSmoothScrollFinishedListenerImplementor.class, __md_methods);
	}


	public PullToRefreshBase_OnSmoothScrollFinishedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PullToRefreshBase_OnSmoothScrollFinishedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnSmoothScrollFinishedListenerImplementor, PullToRefresh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onSmoothScrollFinished ()
	{
		n_onSmoothScrollFinished ();
	}

	private native void n_onSmoothScrollFinished ();

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
