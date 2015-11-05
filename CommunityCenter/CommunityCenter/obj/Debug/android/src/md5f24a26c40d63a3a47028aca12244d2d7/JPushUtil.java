package md5f24a26c40d63a3a47028aca12244d2d7;


public class JPushUtil
	extends cn.jpush.android.api.InstrumentedActivity
	implements
		mono.android.IGCUserPeer,
		cn.jpush.android.api.TagAliasCallback
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_gotResult:(ILjava/lang/String;Ljava/util/Set;)V:GetGotResult_ILjava_lang_String_Ljava_util_Set_Handler:CN.Jpush.Android.Api.ITagAliasCallbackInvoker, JPushBindingLibrary\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Common.JPushUtil, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", JPushUtil.class, __md_methods);
	}


	public JPushUtil () throws java.lang.Throwable
	{
		super ();
		if (getClass () == JPushUtil.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.JPushUtil, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public JPushUtil (android.content.Context p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == JPushUtil.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.JPushUtil, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void gotResult (int p0, java.lang.String p1, java.util.Set p2)
	{
		n_gotResult (p0, p1, p2);
	}

	private native void n_gotResult (int p0, java.lang.String p1, java.util.Set p2);

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
