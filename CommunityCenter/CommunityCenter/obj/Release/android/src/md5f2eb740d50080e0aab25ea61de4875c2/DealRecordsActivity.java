package md5f2eb740d50080e0aab25ea61de4875c2;


public class DealRecordsActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		com.handmark.pulltorefresh.library.PullToRefreshBase.OnRefreshListener2
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onActivityResult:(IILandroid/content/Intent;)V:GetOnActivityResult_IILandroid_content_Intent_Handler\n" +
			"n_onPullDownToRefresh:(Lcom/handmark/pulltorefresh/library/PullToRefreshBase;)V:GetOnPullDownToRefresh_Lcom_handmark_pulltorefresh_library_PullToRefreshBase_Handler:Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnRefreshListener2Invoker, PullToRefresh\n" +
			"n_onPullUpToRefresh:(Lcom/handmark/pulltorefresh/library/PullToRefreshBase;)V:GetOnPullUpToRefresh_Lcom_handmark_pulltorefresh_library_PullToRefreshBase_Handler:Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnRefreshListener2Invoker, PullToRefresh\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Activitys.Finance.DealRecordsActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DealRecordsActivity.class, __md_methods);
	}


	public DealRecordsActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DealRecordsActivity.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Activitys.Finance.DealRecordsActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onActivityResult (int p0, int p1, android.content.Intent p2)
	{
		n_onActivityResult (p0, p1, p2);
	}

	private native void n_onActivityResult (int p0, int p1, android.content.Intent p2);


	public void onPullDownToRefresh (com.handmark.pulltorefresh.library.PullToRefreshBase p0)
	{
		n_onPullDownToRefresh (p0);
	}

	private native void n_onPullDownToRefresh (com.handmark.pulltorefresh.library.PullToRefreshBase p0);


	public void onPullUpToRefresh (com.handmark.pulltorefresh.library.PullToRefreshBase p0)
	{
		n_onPullUpToRefresh (p0);
	}

	private native void n_onPullUpToRefresh (com.handmark.pulltorefresh.library.PullToRefreshBase p0);

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
