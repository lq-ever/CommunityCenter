package md52068126e7314a21b5f33c083a4f743f3;


public class SplashActivity
	extends cn.jpush.android.api.InstrumentedActivity
	implements
		mono.android.IGCUserPeer,
		android.content.DialogInterface.OnKeyListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"n_onKey:(Landroid/content/DialogInterface;ILandroid/view/KeyEvent;)Z:GetOnKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_Handler:Android.Content.IDialogInterfaceOnKeyListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.SplashActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SplashActivity.class, __md_methods);
	}


	public SplashActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SplashActivity.class)
			mono.android.TypeManager.Activate ("CommunityCenter.SplashActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();


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
