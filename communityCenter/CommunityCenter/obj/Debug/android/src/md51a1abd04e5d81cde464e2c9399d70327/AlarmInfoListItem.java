package md51a1abd04e5d81cde464e2c9399d70327;


public class AlarmInfoListItem
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CommunityCenter.Model.Alarm.AlarmInfoListItem, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AlarmInfoListItem.class, __md_methods);
	}


	public AlarmInfoListItem () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AlarmInfoListItem.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Model.Alarm.AlarmInfoListItem, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
