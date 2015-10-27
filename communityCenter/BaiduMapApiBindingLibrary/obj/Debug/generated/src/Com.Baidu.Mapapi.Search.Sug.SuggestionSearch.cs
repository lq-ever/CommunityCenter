using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Sug {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionSearch']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/sug/SuggestionSearch", DoNotGenerateAcw=true)]
	public partial class SuggestionSearch : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/sug/SuggestionSearch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SuggestionSearch); }
		}

		protected SuggestionSearch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Baidu.Mapapi.Search.Sug.SuggestionSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Sug.SuggestionSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionSearch']/method[@name='destroy' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionSearch']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/baidu/mapapi/search/sug/SuggestionSearch;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Search.Sug.SuggestionSearch NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/baidu/mapapi/search/sug/SuggestionSearch;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Sug.SuggestionSearch> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_requestSuggestion_Lcom_baidu_mapapi_search_sug_SuggestionSearchOption_;
#pragma warning disable 0169
		static Delegate GetRequestSuggestion_Lcom_baidu_mapapi_search_sug_SuggestionSearchOption_Handler ()
		{
			if (cb_requestSuggestion_Lcom_baidu_mapapi_search_sug_SuggestionSearchOption_ == null)
				cb_requestSuggestion_Lcom_baidu_mapapi_search_sug_SuggestionSearchOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RequestSuggestion_Lcom_baidu_mapapi_search_sug_SuggestionSearchOption_);
			return cb_requestSuggestion_Lcom_baidu_mapapi_search_sug_SuggestionSearchOption_;
		}

		static bool n_RequestSuggestion_Lcom_baidu_mapapi_search_sug_SuggestionSearchOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Sug.SuggestionSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Sug.SuggestionSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Sug.SuggestionSearchOption p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Sug.SuggestionSearchOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RequestSuggestion (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_requestSuggestion_Lcom_baidu_mapapi_search_sug_SuggestionSearchOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionSearch']/method[@name='requestSuggestion' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.sug.SuggestionSearchOption']]"
		[Register ("requestSuggestion", "(Lcom/baidu/mapapi/search/sug/SuggestionSearchOption;)Z", "GetRequestSuggestion_Lcom_baidu_mapapi_search_sug_SuggestionSearchOption_Handler")]
		public virtual unsafe bool RequestSuggestion (global::Com.Baidu.Mapapi.Search.Sug.SuggestionSearchOption p0)
		{
			if (id_requestSuggestion_Lcom_baidu_mapapi_search_sug_SuggestionSearchOption_ == IntPtr.Zero)
				id_requestSuggestion_Lcom_baidu_mapapi_search_sug_SuggestionSearchOption_ = JNIEnv.GetMethodID (class_ref, "requestSuggestion", "(Lcom/baidu/mapapi/search/sug/SuggestionSearchOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_requestSuggestion_Lcom_baidu_mapapi_search_sug_SuggestionSearchOption_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestSuggestion", "(Lcom/baidu/mapapi/search/sug/SuggestionSearchOption;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setOnGetSuggestionResultListener_Lcom_baidu_mapapi_search_sug_OnGetSuggestionResultListener_;
#pragma warning disable 0169
		static Delegate GetSetOnGetSuggestionResultListener_Lcom_baidu_mapapi_search_sug_OnGetSuggestionResultListener_Handler ()
		{
			if (cb_setOnGetSuggestionResultListener_Lcom_baidu_mapapi_search_sug_OnGetSuggestionResultListener_ == null)
				cb_setOnGetSuggestionResultListener_Lcom_baidu_mapapi_search_sug_OnGetSuggestionResultListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnGetSuggestionResultListener_Lcom_baidu_mapapi_search_sug_OnGetSuggestionResultListener_);
			return cb_setOnGetSuggestionResultListener_Lcom_baidu_mapapi_search_sug_OnGetSuggestionResultListener_;
		}

		static void n_SetOnGetSuggestionResultListener_Lcom_baidu_mapapi_search_sug_OnGetSuggestionResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Sug.SuggestionSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Sug.SuggestionSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListener p0 = (global::Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnGetSuggestionResultListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnGetSuggestionResultListener_Lcom_baidu_mapapi_search_sug_OnGetSuggestionResultListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionSearch']/method[@name='setOnGetSuggestionResultListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.sug.OnGetSuggestionResultListener']]"
		[Register ("setOnGetSuggestionResultListener", "(Lcom/baidu/mapapi/search/sug/OnGetSuggestionResultListener;)V", "GetSetOnGetSuggestionResultListener_Lcom_baidu_mapapi_search_sug_OnGetSuggestionResultListener_Handler")]
		public virtual unsafe void SetOnGetSuggestionResultListener (global::Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListener p0)
		{
			if (id_setOnGetSuggestionResultListener_Lcom_baidu_mapapi_search_sug_OnGetSuggestionResultListener_ == IntPtr.Zero)
				id_setOnGetSuggestionResultListener_Lcom_baidu_mapapi_search_sug_OnGetSuggestionResultListener_ = JNIEnv.GetMethodID (class_ref, "setOnGetSuggestionResultListener", "(Lcom/baidu/mapapi/search/sug/OnGetSuggestionResultListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnGetSuggestionResultListener_Lcom_baidu_mapapi_search_sug_OnGetSuggestionResultListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnGetSuggestionResultListener", "(Lcom/baidu/mapapi/search/sug/OnGetSuggestionResultListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Search.Sug.GetSuggestionResultEventArgs> GetSuggestionResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListener, global::Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListenerImplementor>(
						ref weak_implementor_SetOnGetSuggestionResultListener,
						__CreateIOnGetSuggestionResultListenerImplementor,
						SetOnGetSuggestionResultListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListener, global::Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListenerImplementor>(
						ref weak_implementor_SetOnGetSuggestionResultListener,
						global::Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListenerImplementor.__IsEmpty,
						__v => SetOnGetSuggestionResultListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnGetSuggestionResultListener;

		global::Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListenerImplementor __CreateIOnGetSuggestionResultListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListenerImplementor (this);
		}
#endregion
	}
}
