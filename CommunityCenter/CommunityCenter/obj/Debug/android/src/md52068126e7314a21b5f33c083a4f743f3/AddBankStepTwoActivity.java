package md52068126e7314a21b5f33c083a4f743f3;


public class AddBankStepTwoActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onActivityResult:(IILandroid/content/Intent;)V:GetOnActivityResult_IILandroid_content_Intent_Handler\n" +
			"n_finish:()V:GetFinishHandler\n" +
			"n_onStop:()V:GetOnStopHandler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.AddBankStepTwoActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AddBankStepTwoActivity.class, __md_methods);
	}


	public AddBankStepTwoActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AddBankStepTwoActivity.class)
			mono.android.TypeManager.Activate ("CommunityCenter.AddBankStepTwoActivity, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onActivityResult (int p0, int p1, android.content.Intent p2)
	{
		n_onActivityResult (p0, p1, p2);
	}

	private native void n_onActivityResult (int p0, int p1, android.content.Intent p2);


	public void finish ()
	{
		n_finish ();
	}

	private native void n_finish ();


	public void onStop ()
	{
		n_onStop ();
	}

	private native void n_onStop ();


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();

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
