package md5c0857e5fe435a540ddab77a021f29d5f;


public class RecordAdviceFragment
	extends md52068126e7314a21b5f33c083a4f743f3.BaseFragment
	implements
		mono.android.IGCUserPeer,
		android.widget.RadioGroup.OnCheckedChangeListener,
		com.handmark.pulltorefresh.library.PullToRefreshBase.OnRefreshListener2
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"n_onActivityCreated:(Landroid/os/Bundle;)V:GetOnActivityCreated_Landroid_os_Bundle_Handler\n" +
			"n_onCheckedChanged:(Landroid/widget/RadioGroup;I)V:GetOnCheckedChanged_Landroid_widget_RadioGroup_IHandler:Android.Widget.RadioGroup/IOnCheckedChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onPullDownToRefresh:(Lcom/handmark/pulltorefresh/library/PullToRefreshBase;)V:GetOnPullDownToRefresh_Lcom_handmark_pulltorefresh_library_PullToRefreshBase_Handler:Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnRefreshListener2Invoker, PullToRefresh\n" +
			"n_onPullUpToRefresh:(Lcom/handmark/pulltorefresh/library/PullToRefreshBase;)V:GetOnPullUpToRefresh_Lcom_handmark_pulltorefresh_library_PullToRefreshBase_Handler:Com.Handmark.Pulltorefresh.Library.PullToRefreshBase/IOnRefreshListener2Invoker, PullToRefresh\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Fragments.Advice.RecordAdviceFragment, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RecordAdviceFragment.class, __md_methods);
	}


	public RecordAdviceFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RecordAdviceFragment.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Fragments.Advice.RecordAdviceFragment, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);


	public void onActivityCreated (android.os.Bundle p0)
	{
		n_onActivityCreated (p0);
	}

	private native void n_onActivityCreated (android.os.Bundle p0);


	public void onCheckedChanged (android.widget.RadioGroup p0, int p1)
	{
		n_onCheckedChanged (p0, p1);
	}

	private native void n_onCheckedChanged (android.widget.RadioGroup p0, int p1);


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
