package md5f24a26c40d63a3a47028aca12244d2d7;


public class TimePickDialogUtil
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.widget.TimePicker.OnTimeChangedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onTimeChanged:(Landroid/widget/TimePicker;II)V:GetOnTimeChanged_Landroid_widget_TimePicker_IIHandler:Android.Widget.TimePicker/IOnTimeChangedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Common.TimePickDialogUtil, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TimePickDialogUtil.class, __md_methods);
	}


	public TimePickDialogUtil () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TimePickDialogUtil.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.TimePickDialogUtil, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public TimePickDialogUtil (android.app.Activity p0, java.lang.String p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == TimePickDialogUtil.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.TimePickDialogUtil, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.Activity, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public void onTimeChanged (android.widget.TimePicker p0, int p1, int p2)
	{
		n_onTimeChanged (p0, p1, p2);
	}

	private native void n_onTimeChanged (android.widget.TimePicker p0, int p1, int p2);

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
