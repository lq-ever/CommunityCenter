package md5f24a26c40d63a3a47028aca12244d2d7;


public class SelectPicPopWindow
	extends android.widget.PopupWindow
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CommunityCenter.Common.SelectPicPopWindow, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SelectPicPopWindow.class, __md_methods);
	}


	public SelectPicPopWindow () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SelectPicPopWindow.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.SelectPicPopWindow, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public SelectPicPopWindow (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == SelectPicPopWindow.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.SelectPicPopWindow, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public SelectPicPopWindow (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == SelectPicPopWindow.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.SelectPicPopWindow, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}

	public SelectPicPopWindow (android.app.Activity p0, android.view.View.OnClickListener p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == SelectPicPopWindow.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Common.SelectPicPopWindow, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.Activity, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Views.View/IOnClickListener, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
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
