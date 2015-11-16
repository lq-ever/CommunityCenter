package md5f24a26c40d63a3a47028aca12244d2d7;


public class UpdateManager
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		android.content.DialogInterface.OnKeyListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onKey:(Landroid/content/DialogInterface;ILandroid/view/KeyEvent;)Z:GetOnKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_Handler:Android.Content.IDialogInterfaceOnKeyListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Common.UpdateManager, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", UpdateManager.class, __md_methods);
	}


	public UpdateManager () throws java.lang.Throwable
	{
		super ();
		if (getClass () == UpdateManager.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.UpdateManager, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public UpdateManager (android.content.Context p0, boolean p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == UpdateManager.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.UpdateManager, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Boolean, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public boolean onKey (android.content.DialogInterface p0, int p1, android.view.KeyEvent p2)
	{
		return n_onKey (p0, p1, p2);
	}

	private native boolean n_onKey (android.content.DialogInterface p0, int p1, android.view.KeyEvent p2);

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
