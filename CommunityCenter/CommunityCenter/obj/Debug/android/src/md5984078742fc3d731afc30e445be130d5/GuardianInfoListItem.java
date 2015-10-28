package md5984078742fc3d731afc30e445be130d5;


public class GuardianInfoListItem
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CommunityCenter.Model.ServerType.Admin.GuardianInfoListItem, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GuardianInfoListItem.class, __md_methods);
	}


	public GuardianInfoListItem () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GuardianInfoListItem.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Model.ServerType.Admin.GuardianInfoListItem, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
