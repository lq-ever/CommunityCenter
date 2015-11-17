package md52068126e7314a21b5f33c083a4f743f3;


public class HouseKeepServiceItemView
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CommunityCenter.HouseKeepServiceItemView, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HouseKeepServiceItemView.class, __md_methods);
	}


	public HouseKeepServiceItemView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == HouseKeepServiceItemView.class)
			mono.android.TypeManager.Activate ("CommunityCenter.HouseKeepServiceItemView, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
