package md5f24a26c40d63a3a47028aca12244d2d7;


public class CustomProgressDialog
	extends android.app.Dialog
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onWindowFocusChanged:(Z)V:GetOnWindowFocusChanged_ZHandler\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Common.CustomProgressDialog, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CustomProgressDialog.class, __md_methods);
	}


	public CustomProgressDialog (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == CustomProgressDialog.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.CustomProgressDialog, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public CustomProgressDialog (android.content.Context p0, boolean p1, android.content.DialogInterface.OnCancelListener p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == CustomProgressDialog.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.CustomProgressDialog, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Boolean, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:Android.Content.IDialogInterfaceOnCancelListener, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CustomProgressDialog (android.content.Context p0, int p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == CustomProgressDialog.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.CustomProgressDialog, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public void onWindowFocusChanged (boolean p0)
	{
		n_onWindowFocusChanged (p0);
	}

	private native void n_onWindowFocusChanged (boolean p0);

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
