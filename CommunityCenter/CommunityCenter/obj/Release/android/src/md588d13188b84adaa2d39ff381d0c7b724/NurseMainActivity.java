package md588d13188b84adaa2d39ff381d0c7b724;


public class NurseMainActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Activitys.Nurse.NurseMainActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NurseMainActivity.class, __md_methods);
	}


	public NurseMainActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == NurseMainActivity.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Activitys.Nurse.NurseMainActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
