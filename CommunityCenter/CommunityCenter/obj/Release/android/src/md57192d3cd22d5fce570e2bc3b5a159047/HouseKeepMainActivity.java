package md57192d3cd22d5fce570e2bc3b5a159047;


public class HouseKeepMainActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Activitys.HouseKeep.HouseKeepMainActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HouseKeepMainActivity.class, __md_methods);
	}


	public HouseKeepMainActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == HouseKeepMainActivity.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Activitys.HouseKeep.HouseKeepMainActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
