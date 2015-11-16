package md5bc18a9952b1e4ff0d7a77163aaeb6411;


public class AnimateFirstDisplayListener
	extends com.nostra13.universalimageloader.core.listener.SimpleImageLoadingListener
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onLoadingComplete:(Ljava/lang/String;Landroid/view/View;Landroid/graphics/Bitmap;)V:GetOnLoadingComplete_Ljava_lang_String_Landroid_view_View_Landroid_graphics_Bitmap_Handler\n" +
			"";
		mono.android.Runtime.register ("CommunityCenter.Adapter.AnimateFirstDisplayListener, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AnimateFirstDisplayListener.class, __md_methods);
	}


	public AnimateFirstDisplayListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AnimateFirstDisplayListener.class)
			mono.android.TypeManager.Activate ("CommunityCenter.Adapter.AnimateFirstDisplayListener, CommunityCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onLoadingComplete (java.lang.String p0, android.view.View p1, android.graphics.Bitmap p2)
	{
		n_onLoadingComplete (p0, p1, p2);
	}

	private native void n_onLoadingComplete (java.lang.String p0, android.view.View p1, android.graphics.Bitmap p2);

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
