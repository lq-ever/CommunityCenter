package md5bc18a9952b1e4ff0d7a77163aaeb6411;


public class HealthInfoListAdapter
	extends android.widget.ArrayAdapter
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Adapter.HealthInfoListAdapter, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HealthInfoListAdapter.class, __md_methods);
	}


	public HealthInfoListAdapter (android.content.Context p0, int p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == HealthInfoListAdapter.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Adapter.HealthInfoListAdapter, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public HealthInfoListAdapter (android.content.Context p0, int p1, java.util.List p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == HealthInfoListAdapter.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Adapter.HealthInfoListAdapter, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Collections.Generic.IList`1<T>, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public android.view.View getView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (int p0, android.view.View p1, android.view.ViewGroup p2);

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
