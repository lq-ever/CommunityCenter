package md5c7257cdfcb795366cce7847d1656b9e0;


public class GuardianApplyActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		com.handmark.pulltorefresh.library.PullToRefreshBase.OnRefreshListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onWindowFocusChanged:(Z)V:GetOnWindowFocusChanged_ZHandler\n" +
			"n_onRefresh:(Lcom/handmark/pulltorefresh/library/PullToRefreshBase;)V:GetOnRefresh_Lcom_handmark_pulltorefresh_library_PullToRefreshBase_Handler:Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnRefreshListenerInvoker, PullToRefresh\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Activitys.ServerType.Admin.GuardianApplyActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GuardianApplyActivity.class, __md_methods);
	}


	public GuardianApplyActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GuardianApplyActivity.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Activitys.ServerType.Admin.GuardianApplyActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onWindowFocusChanged (boolean p0)
	{
		n_onWindowFocusChanged (p0);
	}

	private native void n_onWindowFocusChanged (boolean p0);


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
