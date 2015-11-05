package md5bc18a9952b1e4ff0d7a77163aaeb6411;


public class GuiderViewPageAdapter
	extends android.support.v4.view.PagerAdapter
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_destroyItem:(Landroid/view/ViewGroup;ILjava/lang/Object;)V:GetDestroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_Handler\n" +
			"n_finishUpdate:(Landroid/view/View;)V:GetFinishUpdate_Landroid_view_View_Handler\n" +
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_instantiateItem:(Landroid/view/ViewGroup;I)Ljava/lang/Object;:GetInstantiateItem_Landroid_view_ViewGroup_IHandler\n" +
			"n_isViewFromObject:(Landroid/view/View;Ljava/lang/Object;)Z:GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler\n" +
			"n_restoreState:(Landroid/os/Parcelable;Ljava/lang/ClassLoader;)V:GetRestoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_Handler\n" +
			"n_startUpdate:(Landroid/view/View;)V:GetStartUpdate_Landroid_view_View_Handler\n" +
			"n_saveState:()Landroid/os/Parcelable;:GetSaveStateHandler\n" +
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Adapter.GuiderViewPageAdapter, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GuiderViewPageAdapter.class, __md_methods);
	}


	public GuiderViewPageAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GuiderViewPageAdapter.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Adapter.GuiderViewPageAdapter, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void destroyItem (android.view.ViewGroup p0, int p1, java.lang.Object p2)
	{
		n_destroyItem (p0, p1, p2);
	}

	private native void n_destroyItem (android.view.ViewGroup p0, int p1, java.lang.Object p2);


	public void finishUpdate (android.view.View p0)
	{
		n_finishUpdate (p0);
	}

	private native void n_finishUpdate (android.view.View p0);


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public java.lang.Object instantiateItem (android.view.ViewGroup p0, int p1)
	{
		return n_instantiateItem (p0, p1);
	}

	private native java.lang.Object n_instantiateItem (android.view.ViewGroup p0, int p1);


	public boolean isViewFromObject (android.view.View p0, java.lang.Object p1)
	{
		return n_isViewFromObject (p0, p1);
	}

	private native boolean n_isViewFromObject (android.view.View p0, java.lang.Object p1);


	public void restoreState (android.os.Parcelable p0, java.lang.ClassLoader p1)
	{
		n_restoreState (p0, p1);
	}

	private native void n_restoreState (android.os.Parcelable p0, java.lang.ClassLoader p1);


	public void startUpdate (android.view.View p0)
	{
		n_startUpdate (p0);
	}

	private native void n_startUpdate (android.view.View p0);


	public android.os.Parcelable saveState ()
	{
		return n_saveState ();
	}

	private native android.os.Parcelable n_saveState ();


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

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
