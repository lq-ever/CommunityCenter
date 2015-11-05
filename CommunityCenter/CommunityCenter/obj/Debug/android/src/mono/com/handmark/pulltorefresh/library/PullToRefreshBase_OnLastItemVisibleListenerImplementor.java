package mono.com.handmark.pulltorefresh.library;


public class PullToRefreshBase_OnLastItemVisibleListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.handmark.pulltorefresh.library.PullToRefreshBase.OnLastItemVisibleListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onLastItemVisible:()V:GetOnLastItemVisibleHandler:Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnLastItemVisibleListenerInvoker, PullToRefresh\n" +
			"";
		mono.android.Runtime.register ("Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnLastItemVisibleListenerImplementor, PullToRefresh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PullToRefreshBase_OnLastItemVisibleListenerImplementor.class, __md_methods);
	}


	public PullToRefreshBase_OnLastItemVisibleListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PullToRefreshBase_OnLastItemVisibleListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnLastItemVisibleListenerImplementor, PullToRefresh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onLastItemVisible ()
	{
		n_onLastItemVisible ();
	}

	private native void n_onLastItemVisible ();

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
