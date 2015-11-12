package md5f2eb740d50080e0aab25ea61de4875c2;


public class ChargeOilActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Activitys.Finance.ChargeOilActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ChargeOilActivity.class, __md_methods);
	}


	public ChargeOilActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ChargeOilActivity.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Activitys.Finance.ChargeOilActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
