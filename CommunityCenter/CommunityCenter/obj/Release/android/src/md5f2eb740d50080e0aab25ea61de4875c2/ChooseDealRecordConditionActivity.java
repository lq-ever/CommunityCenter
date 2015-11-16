package md5f2eb740d50080e0aab25ea61de4875c2;


public class ChooseDealRecordConditionActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		android.widget.AdapterView.OnItemSelectedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onBackPressed:()V:GetOnBackPressedHandler\n" +
			"n_onItemSelected:(Landroid/widget/AdapterView;Landroid/view/View;IJ)V:GetOnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJHandler:Android.Widget.AdapterView/IOnItemSelectedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onNothingSelected:(Landroid/widget/AdapterView;)V:GetOnNothingSelected_Landroid_widget_AdapterView_Handler:Android.Widget.AdapterView/IOnItemSelectedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Activitys.Finance.ChooseDealRecordConditionActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ChooseDealRecordConditionActivity.class, __md_methods);
	}


	public ChooseDealRecordConditionActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ChooseDealRecordConditionActivity.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Activitys.Finance.ChooseDealRecordConditionActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onBackPressed ()
	{
		n_onBackPressed ();
	}

	private native void n_onBackPressed ();


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
