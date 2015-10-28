package md5bc18a9952b1e4ff0d7a77163aaeb6411;


public class AlarmItemView
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CommunityCenter.Adapter.AlarmItemView, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AlarmItemView.class, __md_methods);
	}


	public AlarmItemView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AlarmItemView.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Adapter.AlarmItemView, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
