using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Busline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineSearch']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/busline/BusLineSearch", DoNotGenerateAcw=true)]
	public partial class BusLineSearch : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/busline/BusLineSearch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BusLineSearch); }
		}

		protected BusLineSearch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Baidu.Mapapi.Search.Busline.BusLineSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineSearch']/method[@name='destroy' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineSearch']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/baidu/mapapi/search/busline/BusLineSearch;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Search.Busline.BusLineSearch NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/baidu/mapapi/search/busline/BusLineSearch;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineSearch> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_searchBusLine_Lcom_baidu_mapapi_search_busline_BusLineSearchOption_;
#pragma warning disable 0169
		static Delegate GetSearchBusLine_Lcom_baidu_mapapi_search_busline_BusLineSearchOption_Handler ()
		{
			if (cb_searchBusLine_Lcom_baidu_mapapi_search_busline_BusLineSearchOption_ == null)
				cb_searchBusLine_Lcom_baidu_mapapi_search_busline_BusLineSearchOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SearchBusLine_Lcom_baidu_mapapi_search_busline_BusLineSearchOption_);
			return cb_searchBusLine_Lcom_baidu_mapapi_search_busline_BusLineSearchOption_;
		}

		static bool n_SearchBusLine_Lcom_baidu_mapapi_search_busline_BusLineSearchOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Busline.BusLineSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Busline.BusLineSearchOption p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineSearchOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SearchBusLine (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_searchBusLine_Lcom_baidu_mapapi_search_busline_BusLineSearchOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineSearch']/method[@name='searchBusLine' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.busline.BusLineSearchOption']]"
		[Register ("searchBusLine", "(Lcom/baidu/mapapi/search/busline/BusLineSearchOption;)Z", "GetSearchBusLine_Lcom_baidu_mapapi_search_busline_BusLineSearchOption_Handler")]
		public virtual unsafe bool SearchBusLine (global::Com.Baidu.Mapapi.Search.Busline.BusLineSearchOption p0)
		{
			if (id_searchBusLine_Lcom_baidu_mapapi_search_busline_BusLineSearchOption_ == IntPtr.Zero)
				id_searchBusLine_Lcom_baidu_mapapi_search_busline_BusLineSearchOption_ = JNIEnv.GetMethodID (class_ref, "searchBusLine", "(Lcom/baidu/mapapi/search/busline/BusLineSearchOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_searchBusLine_Lcom_baidu_mapapi_search_busline_BusLineSearchOption_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "searchBusLine", "(Lcom/baidu/mapapi/search/busline/BusLineSearchOption;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setOnGetBusLineSearchResultListener_Lcom_baidu_mapapi_search_busline_OnGetBusLineSearchResultListener_;
#pragma warning disable 0169
		static Delegate GetSetOnGetBusLineSearchResultListener_Lcom_baidu_mapapi_search_busline_OnGetBusLineSearchResultListener_Handler ()
		{
			if (cb_setOnGetBusLineSearchResultListener_Lcom_baidu_mapapi_search_busline_OnGetBusLineSearchResultListener_ == null)
				cb_setOnGetBusLineSearchResultListener_Lcom_baidu_mapapi_search_busline_OnGetBusLineSearchResultListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnGetBusLineSearchResultListener_Lcom_baidu_mapapi_search_busline_OnGetBusLineSearchResultListener_);
			return cb_setOnGetBusLineSearchResultListener_Lcom_baidu_mapapi_search_busline_OnGetBusLineSearchResultListener_;
		}

		static void n_SetOnGetBusLineSearchResultListener_Lcom_baidu_mapapi_search_busline_OnGetBusLineSearchResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Busline.BusLineSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListener p0 = (global::Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnGetBusLineSearchResultListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnGetBusLineSearchResultListener_Lcom_baidu_mapapi_search_busline_OnGetBusLineSearchResultListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineSearch']/method[@name='setOnGetBusLineSearchResultListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.busline.OnGetBusLineSearchResultListener']]"
		[Register ("setOnGetBusLineSearchResultListener", "(Lcom/baidu/mapapi/search/busline/OnGetBusLineSearchResultListener;)V", "GetSetOnGetBusLineSearchResultListener_Lcom_baidu_mapapi_search_busline_OnGetBusLineSearchResultListener_Handler")]
		public virtual unsafe void SetOnGetBusLineSearchResultListener (global::Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListener p0)
		{
			if (id_setOnGetBusLineSearchResultListener_Lcom_baidu_mapapi_search_busline_OnGetBusLineSearchResultListener_ == IntPtr.Zero)
				id_setOnGetBusLineSearchResultListener_Lcom_baidu_mapapi_search_busline_OnGetBusLineSearchResultListener_ = JNIEnv.GetMethodID (class_ref, "setOnGetBusLineSearchResultListener", "(Lcom/baidu/mapapi/search/busline/OnGetBusLineSearchResultListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnGetBusLineSearchResultListener_Lcom_baidu_mapapi_search_busline_OnGetBusLineSearchResultListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnGetBusLineSearchResultListener", "(Lcom/baidu/mapapi/search/busline/OnGetBusLineSearchResultListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Search.Busline.GetBusLineSearchResultEventArgs> GetBusLineSearchResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListener, global::Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListenerImplementor>(
						ref weak_implementor_SetOnGetBusLineSearchResultListener,
						__CreateIOnGetBusLineSearchResultListenerImplementor,
						SetOnGetBusLineSearchResultListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListener, global::Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListenerImplementor>(
						ref weak_implementor_SetOnGetBusLineSearchResultListener,
						global::Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListenerImplementor.__IsEmpty,
						__v => SetOnGetBusLineSearchResultListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnGetBusLineSearchResultListener;

		global::Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListenerImplementor __CreateIOnGetBusLineSearchResultListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListenerImplementor (this);
		}
#endregion
	}
}
