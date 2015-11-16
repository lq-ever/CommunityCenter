using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Share {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='ShareUrlSearch']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/share/ShareUrlSearch", DoNotGenerateAcw=true)]
	public partial class ShareUrlSearch : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/share/ShareUrlSearch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShareUrlSearch); }
		}

		protected ShareUrlSearch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Share.ShareUrlSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.ShareUrlSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='ShareUrlSearch']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='ShareUrlSearch']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/baidu/mapapi/search/share/ShareUrlSearch;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Search.Share.ShareUrlSearch NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/baidu/mapapi/search/share/ShareUrlSearch;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.ShareUrlSearch> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_requestLocationShareUrl_Lcom_baidu_mapapi_search_share_LocationShareURLOption_;
#pragma warning disable 0169
		static Delegate GetRequestLocationShareUrl_Lcom_baidu_mapapi_search_share_LocationShareURLOption_Handler ()
		{
			if (cb_requestLocationShareUrl_Lcom_baidu_mapapi_search_share_LocationShareURLOption_ == null)
				cb_requestLocationShareUrl_Lcom_baidu_mapapi_search_share_LocationShareURLOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RequestLocationShareUrl_Lcom_baidu_mapapi_search_share_LocationShareURLOption_);
			return cb_requestLocationShareUrl_Lcom_baidu_mapapi_search_share_LocationShareURLOption_;
		}

		static bool n_RequestLocationShareUrl_Lcom_baidu_mapapi_search_share_LocationShareURLOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Share.ShareUrlSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.ShareUrlSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RequestLocationShareUrl (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_requestLocationShareUrl_Lcom_baidu_mapapi_search_share_LocationShareURLOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='ShareUrlSearch']/method[@name='requestLocationShareUrl' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.share.LocationShareURLOption']]"
		[Register ("requestLocationShareUrl", "(Lcom/baidu/mapapi/search/share/LocationShareURLOption;)Z", "GetRequestLocationShareUrl_Lcom_baidu_mapapi_search_share_LocationShareURLOption_Handler")]
		public virtual unsafe bool RequestLocationShareUrl (global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption p0)
		{
			if (id_requestLocationShareUrl_Lcom_baidu_mapapi_search_share_LocationShareURLOption_ == IntPtr.Zero)
				id_requestLocationShareUrl_Lcom_baidu_mapapi_search_share_LocationShareURLOption_ = JNIEnv.GetMethodID (class_ref, "requestLocationShareUrl", "(Lcom/baidu/mapapi/search/share/LocationShareURLOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_requestLocationShareUrl_Lcom_baidu_mapapi_search_share_LocationShareURLOption_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestLocationShareUrl", "(Lcom/baidu/mapapi/search/share/LocationShareURLOption;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_requestPoiDetailShareUrl_Lcom_baidu_mapapi_search_share_PoiDetailShareURLOption_;
#pragma warning disable 0169
		static Delegate GetRequestPoiDetailShareUrl_Lcom_baidu_mapapi_search_share_PoiDetailShareURLOption_Handler ()
		{
			if (cb_requestPoiDetailShareUrl_Lcom_baidu_mapapi_search_share_PoiDetailShareURLOption_ == null)
				cb_requestPoiDetailShareUrl_Lcom_baidu_mapapi_search_share_PoiDetailShareURLOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RequestPoiDetailShareUrl_Lcom_baidu_mapapi_search_share_PoiDetailShareURLOption_);
			return cb_requestPoiDetailShareUrl_Lcom_baidu_mapapi_search_share_PoiDetailShareURLOption_;
		}

		static bool n_RequestPoiDetailShareUrl_Lcom_baidu_mapapi_search_share_PoiDetailShareURLOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Share.ShareUrlSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.ShareUrlSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Share.PoiDetailShareURLOption p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.PoiDetailShareURLOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RequestPoiDetailShareUrl (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_requestPoiDetailShareUrl_Lcom_baidu_mapapi_search_share_PoiDetailShareURLOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='ShareUrlSearch']/method[@name='requestPoiDetailShareUrl' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.share.PoiDetailShareURLOption']]"
		[Register ("requestPoiDetailShareUrl", "(Lcom/baidu/mapapi/search/share/PoiDetailShareURLOption;)Z", "GetRequestPoiDetailShareUrl_Lcom_baidu_mapapi_search_share_PoiDetailShareURLOption_Handler")]
		public virtual unsafe bool RequestPoiDetailShareUrl (global::Com.Baidu.Mapapi.Search.Share.PoiDetailShareURLOption p0)
		{
			if (id_requestPoiDetailShareUrl_Lcom_baidu_mapapi_search_share_PoiDetailShareURLOption_ == IntPtr.Zero)
				id_requestPoiDetailShareUrl_Lcom_baidu_mapapi_search_share_PoiDetailShareURLOption_ = JNIEnv.GetMethodID (class_ref, "requestPoiDetailShareUrl", "(Lcom/baidu/mapapi/search/share/PoiDetailShareURLOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_requestPoiDetailShareUrl_Lcom_baidu_mapapi_search_share_PoiDetailShareURLOption_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestPoiDetailShareUrl", "(Lcom/baidu/mapapi/search/share/PoiDetailShareURLOption;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setOnGetShareUrlResultListener_Lcom_baidu_mapapi_search_share_OnGetShareUrlResultListener_;
#pragma warning disable 0169
		static Delegate GetSetOnGetShareUrlResultListener_Lcom_baidu_mapapi_search_share_OnGetShareUrlResultListener_Handler ()
		{
			if (cb_setOnGetShareUrlResultListener_Lcom_baidu_mapapi_search_share_OnGetShareUrlResultListener_ == null)
				cb_setOnGetShareUrlResultListener_Lcom_baidu_mapapi_search_share_OnGetShareUrlResultListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnGetShareUrlResultListener_Lcom_baidu_mapapi_search_share_OnGetShareUrlResultListener_);
			return cb_setOnGetShareUrlResultListener_Lcom_baidu_mapapi_search_share_OnGetShareUrlResultListener_;
		}

		static void n_SetOnGetShareUrlResultListener_Lcom_baidu_mapapi_search_share_OnGetShareUrlResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Share.ShareUrlSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.ShareUrlSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListener p0 = (global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnGetShareUrlResultListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnGetShareUrlResultListener_Lcom_baidu_mapapi_search_share_OnGetShareUrlResultListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='ShareUrlSearch']/method[@name='setOnGetShareUrlResultListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.share.OnGetShareUrlResultListener']]"
		[Register ("setOnGetShareUrlResultListener", "(Lcom/baidu/mapapi/search/share/OnGetShareUrlResultListener;)V", "GetSetOnGetShareUrlResultListener_Lcom_baidu_mapapi_search_share_OnGetShareUrlResultListener_Handler")]
		public virtual unsafe void SetOnGetShareUrlResultListener (global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListener p0)
		{
			if (id_setOnGetShareUrlResultListener_Lcom_baidu_mapapi_search_share_OnGetShareUrlResultListener_ == IntPtr.Zero)
				id_setOnGetShareUrlResultListener_Lcom_baidu_mapapi_search_share_OnGetShareUrlResultListener_ = JNIEnv.GetMethodID (class_ref, "setOnGetShareUrlResultListener", "(Lcom/baidu/mapapi/search/share/OnGetShareUrlResultListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnGetShareUrlResultListener_Lcom_baidu_mapapi_search_share_OnGetShareUrlResultListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnGetShareUrlResultListener", "(Lcom/baidu/mapapi/search/share/OnGetShareUrlResultListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Search.Share.GetLocationShareUrlResultEventArgs> GetLocationShareUrlResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListener, global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListenerImplementor>(
						ref weak_implementor_SetOnGetShareUrlResultListener,
						__CreateIOnGetShareUrlResultListenerImplementor,
						SetOnGetShareUrlResultListener,
						__h => __h.OnGetLocationShareUrlResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListener, global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListenerImplementor>(
						ref weak_implementor_SetOnGetShareUrlResultListener,
						global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListenerImplementor.__IsEmpty,
						__v => SetOnGetShareUrlResultListener (null),
						__h => __h.OnGetLocationShareUrlResultHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Search.Share.GetPoiDetailShareUrlResultEventArgs> GetPoiDetailShareUrlResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListener, global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListenerImplementor>(
						ref weak_implementor_SetOnGetShareUrlResultListener,
						__CreateIOnGetShareUrlResultListenerImplementor,
						SetOnGetShareUrlResultListener,
						__h => __h.OnGetPoiDetailShareUrlResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListener, global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListenerImplementor>(
						ref weak_implementor_SetOnGetShareUrlResultListener,
						global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListenerImplementor.__IsEmpty,
						__v => SetOnGetShareUrlResultListener (null),
						__h => __h.OnGetPoiDetailShareUrlResultHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnGetShareUrlResultListener;

		global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListenerImplementor __CreateIOnGetShareUrlResultListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListenerImplementor (this);
		}
#endregion
	}
}
