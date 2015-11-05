using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Geocode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCoder']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/geocode/GeoCoder", DoNotGenerateAcw=true)]
	public partial class GeoCoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/geocode/GeoCoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeoCoder); }
		}

		protected GeoCoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Baidu.Mapapi.Search.Geocode.GeoCoder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCoder']/method[@name='destroy' and count(parameter)=0]"
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

		static Delegate cb_geocode_Lcom_baidu_mapapi_search_geocode_GeoCodeOption_;
#pragma warning disable 0169
		static Delegate GetGeocode_Lcom_baidu_mapapi_search_geocode_GeoCodeOption_Handler ()
		{
			if (cb_geocode_Lcom_baidu_mapapi_search_geocode_GeoCodeOption_ == null)
				cb_geocode_Lcom_baidu_mapapi_search_geocode_GeoCodeOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Geocode_Lcom_baidu_mapapi_search_geocode_GeoCodeOption_);
			return cb_geocode_Lcom_baidu_mapapi_search_geocode_GeoCodeOption_;
		}

		static bool n_Geocode_Lcom_baidu_mapapi_search_geocode_GeoCodeOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.GeoCoder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Geocode (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_geocode_Lcom_baidu_mapapi_search_geocode_GeoCodeOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCoder']/method[@name='geocode' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.geocode.GeoCodeOption']]"
		[Register ("geocode", "(Lcom/baidu/mapapi/search/geocode/GeoCodeOption;)Z", "GetGeocode_Lcom_baidu_mapapi_search_geocode_GeoCodeOption_Handler")]
		public virtual unsafe bool Geocode (global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption p0)
		{
			if (id_geocode_Lcom_baidu_mapapi_search_geocode_GeoCodeOption_ == IntPtr.Zero)
				id_geocode_Lcom_baidu_mapapi_search_geocode_GeoCodeOption_ = JNIEnv.GetMethodID (class_ref, "geocode", "(Lcom/baidu/mapapi/search/geocode/GeoCodeOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_geocode_Lcom_baidu_mapapi_search_geocode_GeoCodeOption_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "geocode", "(Lcom/baidu/mapapi/search/geocode/GeoCodeOption;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCoder']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/baidu/mapapi/search/geocode/GeoCoder;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Search.Geocode.GeoCoder NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/baidu/mapapi/search/geocode/GeoCoder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCoder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reverseGeoCode_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeOption_;
#pragma warning disable 0169
		static Delegate GetReverseGeoCode_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeOption_Handler ()
		{
			if (cb_reverseGeoCode_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeOption_ == null)
				cb_reverseGeoCode_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ReverseGeoCode_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeOption_);
			return cb_reverseGeoCode_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeOption_;
		}

		static bool n_ReverseGeoCode_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.GeoCoder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeOption p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ReverseGeoCode (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_reverseGeoCode_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCoder']/method[@name='reverseGeoCode' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.geocode.ReverseGeoCodeOption']]"
		[Register ("reverseGeoCode", "(Lcom/baidu/mapapi/search/geocode/ReverseGeoCodeOption;)Z", "GetReverseGeoCode_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeOption_Handler")]
		public virtual unsafe bool ReverseGeoCode (global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeOption p0)
		{
			if (id_reverseGeoCode_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeOption_ == IntPtr.Zero)
				id_reverseGeoCode_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeOption_ = JNIEnv.GetMethodID (class_ref, "reverseGeoCode", "(Lcom/baidu/mapapi/search/geocode/ReverseGeoCodeOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_reverseGeoCode_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeOption_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reverseGeoCode", "(Lcom/baidu/mapapi/search/geocode/ReverseGeoCodeOption;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setOnGetGeoCodeResultListener_Lcom_baidu_mapapi_search_geocode_OnGetGeoCoderResultListener_;
#pragma warning disable 0169
		static Delegate GetSetOnGetGeoCodeResultListener_Lcom_baidu_mapapi_search_geocode_OnGetGeoCoderResultListener_Handler ()
		{
			if (cb_setOnGetGeoCodeResultListener_Lcom_baidu_mapapi_search_geocode_OnGetGeoCoderResultListener_ == null)
				cb_setOnGetGeoCodeResultListener_Lcom_baidu_mapapi_search_geocode_OnGetGeoCoderResultListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnGetGeoCodeResultListener_Lcom_baidu_mapapi_search_geocode_OnGetGeoCoderResultListener_);
			return cb_setOnGetGeoCodeResultListener_Lcom_baidu_mapapi_search_geocode_OnGetGeoCoderResultListener_;
		}

		static void n_SetOnGetGeoCodeResultListener_Lcom_baidu_mapapi_search_geocode_OnGetGeoCoderResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.GeoCoder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListener p0 = (global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnGetGeoCodeResultListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnGetGeoCodeResultListener_Lcom_baidu_mapapi_search_geocode_OnGetGeoCoderResultListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCoder']/method[@name='setOnGetGeoCodeResultListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.geocode.OnGetGeoCoderResultListener']]"
		[Register ("setOnGetGeoCodeResultListener", "(Lcom/baidu/mapapi/search/geocode/OnGetGeoCoderResultListener;)V", "GetSetOnGetGeoCodeResultListener_Lcom_baidu_mapapi_search_geocode_OnGetGeoCoderResultListener_Handler")]
		public virtual unsafe void SetOnGetGeoCodeResultListener (global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListener p0)
		{
			if (id_setOnGetGeoCodeResultListener_Lcom_baidu_mapapi_search_geocode_OnGetGeoCoderResultListener_ == IntPtr.Zero)
				id_setOnGetGeoCodeResultListener_Lcom_baidu_mapapi_search_geocode_OnGetGeoCoderResultListener_ = JNIEnv.GetMethodID (class_ref, "setOnGetGeoCodeResultListener", "(Lcom/baidu/mapapi/search/geocode/OnGetGeoCoderResultListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnGetGeoCodeResultListener_Lcom_baidu_mapapi_search_geocode_OnGetGeoCoderResultListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnGetGeoCodeResultListener", "(Lcom/baidu/mapapi/search/geocode/OnGetGeoCoderResultListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Search.Geocode.GetGeoCodeResultEventArgs> GetGeoCodeResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListener, global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListenerImplementor>(
						ref weak_implementor_SetOnGetGeoCodeResultListener,
						__CreateIOnGetGeoCoderResultListenerImplementor,
						SetOnGetGeoCodeResultListener,
						__h => __h.OnGetGeoCodeResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListener, global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListenerImplementor>(
						ref weak_implementor_SetOnGetGeoCodeResultListener,
						global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListenerImplementor.__IsEmpty,
						__v => SetOnGetGeoCodeResultListener (null),
						__h => __h.OnGetGeoCodeResultHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Search.Geocode.GetReverseGeoCodeResultEventArgs> GetReverseGeoCodeResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListener, global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListenerImplementor>(
						ref weak_implementor_SetOnGetGeoCodeResultListener,
						__CreateIOnGetGeoCoderResultListenerImplementor,
						SetOnGetGeoCodeResultListener,
						__h => __h.OnGetReverseGeoCodeResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListener, global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListenerImplementor>(
						ref weak_implementor_SetOnGetGeoCodeResultListener,
						global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListenerImplementor.__IsEmpty,
						__v => SetOnGetGeoCodeResultListener (null),
						__h => __h.OnGetReverseGeoCodeResultHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnGetGeoCodeResultListener;

		global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListenerImplementor __CreateIOnGetGeoCoderResultListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListenerImplementor (this);
		}
#endregion
	}
}
