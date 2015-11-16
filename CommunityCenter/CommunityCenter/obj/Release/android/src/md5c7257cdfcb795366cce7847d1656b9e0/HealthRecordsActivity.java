package md5c7257cdfcb795366cce7847d1656b9e0;


public class HealthRecordsActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		com.handmark.pulltorefresh.library.PullToRefreshBase.OnRefreshListener2,
		android.widget.AdapterView.OnItemSelectedListener,
		android.view.View.OnFocusChangeListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onPullDownToRefresh:(Lcom/handmark/pulltorefresh/library/PullToRefreshBase;)V:GetOnPullDownToRefresh_Lcom_handmark_pulltorefresh_library_PullToRefreshBase_Handler:Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnRefreshListener2Invoker, PullToRefresh\n" +
			"n_onPullUpToRefresh:(Lcom/handmark/pulltorefresh/library/PullToRefreshBase;)V:GetOnPullUpToRefresh_Lcom_handmark_pulltorefresh_library_PullToRefreshBase_Handler:Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnRefreshListener2Invoker, PullToRefresh\n" +
			"n_onItemSelected:(Landroid/widget/AdapterView;Landroid/view/View;IJ)V:GetOnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJHandler:Android.Widget.AdapterView/IOnItemSelectedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onNothingSelected:(Landroid/widget/AdapterView;)V:GetOnNothingSelected_Landroid_widget_AdapterView_Handler:Android.Widget.AdapterView/IOnItemSelectedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onFocusChange:(Landroid/view/View;Z)V:GetOnFocusChange_Landroid_view_View_ZHandler:Android.Views.View/IOnFocusChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Activitys.ServerType.Admin.HealthRecordsActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HealthRecordsActivity.class, __md_methods);
	}


	public HealthRecordsActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == HealthRecordsActivity.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Activitys.ServerType.Admin.HealthRecordsActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


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


	public void onItemSelected (android.widget.AdapterView p0, android.view.View p1, int p2, long p3)
	{
		n_onItemSelected (p0, p1, p2, p3);
	}

	private native void n_onItemSelected (android.widget.AdapterView p0, android.view.View p1, int p2, long p3);


	public void onNothingSelected (android.widget.AdapterView p0)
	{
		n_onNothingSelected (p0);
	}

	private native void n_onNothingSelected (android.widget.AdapterView p0);


	public void onFocusChange (android.view.View p0, boolean p1)
	{
		n_onFocusChange (p0, p1);
	}

	private native void n_onFocusChange (android.view.View p0, boolean p1);

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
