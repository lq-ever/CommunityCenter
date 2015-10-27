package md5f24a26c40d63a3a47028aca12244d2d7;


public class DatePickDialogUtil
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.widget.DatePicker.OnDateChangedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onDateChanged:(Landroid/widget/DatePicker;III)V:GetOnDateChanged_Landroid_widget_DatePicker_IIIHandler:Android.Widget.DatePicker/IOnDateChangedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Common.DatePickDialogUtil, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DatePickDialogUtil.class, __md_methods);
	}


	public DatePickDialogUtil () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DatePickDialogUtil.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.DatePickDialogUtil, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public DatePickDialogUtil (android.app.Activity p0, java.lang.String p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == DatePickDialogUtil.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.DatePickDialogUtil, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.Activity, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public void onDateChanged (android.widget.DatePicker p0, int p1, int p2, int p3)
	{
		n_onDateChanged (p0, p1, p2, p3);
	}

	private native void n_onDateChanged (android.widget.DatePicker p0, int p1, int p2, int p3);

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
