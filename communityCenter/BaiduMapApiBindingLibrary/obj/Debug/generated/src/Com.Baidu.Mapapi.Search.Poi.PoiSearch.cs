using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Poi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiSearch']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/poi/PoiSearch", DoNotGenerateAcw=true)]
	public partial class PoiSearch : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/poi/PoiSearch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PoiSearch); }
		}

		protected PoiSearch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Baidu.Mapapi.Search.Poi.PoiSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiSearch']/method[@name='destroy' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiSearch']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/baidu/mapapi/search/poi/PoiSearch;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Search.Poi.PoiSearch NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/baidu/mapapi/search/poi/PoiSearch;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiSearch> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_searchInBound_Lcom_baidu_mapapi_search_poi_PoiBoundSearchOption_;
#pragma warning disable 0169
		static Delegate GetSearchInBound_Lcom_baidu_mapapi_search_poi_PoiBoundSearchOption_Handler ()
		{
			if (cb_searchInBound_Lcom_baidu_mapapi_search_poi_PoiBoundSearchOption_ == null)
				cb_searchInBound_Lcom_baidu_mapapi_search_poi_PoiBoundSearchOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SearchInBound_Lcom_baidu_mapapi_search_poi_PoiBoundSearchOption_);
			return cb_searchInBound_Lcom_baidu_mapapi_search_poi_PoiBoundSearchOption_;
		}

		static bool n_SearchInBound_Lcom_baidu_mapapi_search_poi_PoiBoundSearchOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SearchInBound (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_searchInBound_Lcom_baidu_mapapi_search_poi_PoiBoundSearchOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiSearch']/method[@name='searchInBound' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.poi.PoiBoundSearchOption']]"
		[Register ("searchInBound", "(Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;)Z", "GetSearchInBound_Lcom_baidu_mapapi_search_poi_PoiBoundSearchOption_Handler")]
		public virtual unsafe bool SearchInBound (global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption p0)
		{
			if (id_searchInBound_Lcom_baidu_mapapi_search_poi_PoiBoundSearchOption_ == IntPtr.Zero)
				id_searchInBound_Lcom_baidu_mapapi_search_poi_PoiBoundSearchOption_ = JNIEnv.GetMethodID (class_ref, "searchInBound", "(Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_searchInBound_Lcom_baidu_mapapi_search_poi_PoiBoundSearchOption_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "searchInBound", "(Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_searchInCity_Lcom_baidu_mapapi_search_poi_PoiCitySearchOption_;
#pragma warning disable 0169
		static Delegate GetSearchInCity_Lcom_baidu_mapapi_search_poi_PoiCitySearchOption_Handler ()
		{
			if (cb_searchInCity_Lcom_baidu_mapapi_search_poi_PoiCitySearchOption_ == null)
				cb_searchInCity_Lcom_baidu_mapapi_search_poi_PoiCitySearchOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SearchInCity_Lcom_baidu_mapapi_search_poi_PoiCitySearchOption_);
			return cb_searchInCity_Lcom_baidu_mapapi_search_poi_PoiCitySearchOption_;
		}

		static bool n_SearchInCity_Lcom_baidu_mapapi_search_poi_PoiCitySearchOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Poi.PoiCitySearchOption p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiCitySearchOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SearchInCity (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_searchInCity_Lcom_baidu_mapapi_search_poi_PoiCitySearchOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiSearch']/method[@name='searchInCity' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.poi.PoiCitySearchOption']]"
		[Register ("searchInCity", "(Lcom/baidu/mapapi/search/poi/PoiCitySearchOption;)Z", "GetSearchInCity_Lcom_baidu_mapapi_search_poi_PoiCitySearchOption_Handler")]
		public virtual unsafe bool SearchInCity (global::Com.Baidu.Mapapi.Search.Poi.PoiCitySearchOption p0)
		{
			if (id_searchInCity_Lcom_baidu_mapapi_search_poi_PoiCitySearchOption_ == IntPtr.Zero)
				id_searchInCity_Lcom_baidu_mapapi_search_poi_PoiCitySearchOption_ = JNIEnv.GetMethodID (class_ref, "searchInCity", "(Lcom/baidu/mapapi/search/poi/PoiCitySearchOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_searchInCity_Lcom_baidu_mapapi_search_poi_PoiCitySearchOption_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "searchInCity", "(Lcom/baidu/mapapi/search/poi/PoiCitySearchOption;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_searchNearby_Lcom_baidu_mapapi_search_poi_PoiNearbySearchOption_;
#pragma warning disable 0169
		static Delegate GetSearchNearby_Lcom_baidu_mapapi_search_poi_PoiNearbySearchOption_Handler ()
		{
			if (cb_searchNearby_Lcom_baidu_mapapi_search_poi_PoiNearbySearchOption_ == null)
				cb_searchNearby_Lcom_baidu_mapapi_search_poi_PoiNearbySearchOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SearchNearby_Lcom_baidu_mapapi_search_poi_PoiNearbySearchOption_);
			return cb_searchNearby_Lcom_baidu_mapapi_search_poi_PoiNearbySearchOption_;
		}

		static bool n_SearchNearby_Lcom_baidu_mapapi_search_poi_PoiNearbySearchOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SearchNearby (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_searchNearby_Lcom_baidu_mapapi_search_poi_PoiNearbySearchOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiSearch']/method[@name='searchNearby' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.poi.PoiNearbySearchOption']]"
		[Register ("searchNearby", "(Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;)Z", "GetSearchNearby_Lcom_baidu_mapapi_search_poi_PoiNearbySearchOption_Handler")]
		public virtual unsafe bool SearchNearby (global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption p0)
		{
			if (id_searchNearby_Lcom_baidu_mapapi_search_poi_PoiNearbySearchOption_ == IntPtr.Zero)
				id_searchNearby_Lcom_baidu_mapapi_search_poi_PoiNearbySearchOption_ = JNIEnv.GetMethodID (class_ref, "searchNearby", "(Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_searchNearby_Lcom_baidu_mapapi_search_poi_PoiNearbySearchOption_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "searchNearby", "(Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_searchPoiDetail_Lcom_baidu_mapapi_search_poi_PoiDetailSearchOption_;
#pragma warning disable 0169
		static Delegate GetSearchPoiDetail_Lcom_baidu_mapapi_search_poi_PoiDetailSearchOption_Handler ()
		{
			if (cb_searchPoiDetail_Lcom_baidu_mapapi_search_poi_PoiDetailSearchOption_ == null)
				cb_searchPoiDetail_Lcom_baidu_mapapi_search_poi_PoiDetailSearchOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SearchPoiDetail_Lcom_baidu_mapapi_search_poi_PoiDetailSearchOption_);
			return cb_searchPoiDetail_Lcom_baidu_mapapi_search_poi_PoiDetailSearchOption_;
		}

		static bool n_SearchPoiDetail_Lcom_baidu_mapapi_search_poi_PoiDetailSearchOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailSearchOption p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailSearchOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SearchPoiDetail (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_searchPoiDetail_Lcom_baidu_mapapi_search_poi_PoiDetailSearchOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiSearch']/method[@name='searchPoiDetail' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.poi.PoiDetailSearchOption']]"
		[Register ("searchPoiDetail", "(Lcom/baidu/mapapi/search/poi/PoiDetailSearchOption;)Z", "GetSearchPoiDetail_Lcom_baidu_mapapi_search_poi_PoiDetailSearchOption_Handler")]
		public virtual unsafe bool SearchPoiDetail (global::Com.Baidu.Mapapi.Search.Poi.PoiDetailSearchOption p0)
		{
			if (id_searchPoiDetail_Lcom_baidu_mapapi_search_poi_PoiDetailSearchOption_ == IntPtr.Zero)
				id_searchPoiDetail_Lcom_baidu_mapapi_search_poi_PoiDetailSearchOption_ = JNIEnv.GetMethodID (class_ref, "searchPoiDetail", "(Lcom/baidu/mapapi/search/poi/PoiDetailSearchOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_searchPoiDetail_Lcom_baidu_mapapi_search_poi_PoiDetailSearchOption_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "searchPoiDetail", "(Lcom/baidu/mapapi/search/poi/PoiDetailSearchOption;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setOnGetPoiSearchResultListener_Lcom_baidu_mapapi_search_poi_OnGetPoiSearchResultListener_;
#pragma warning disable 0169
		static Delegate GetSetOnGetPoiSearchResultListener_Lcom_baidu_mapapi_search_poi_OnGetPoiSearchResultListener_Handler ()
		{
			if (cb_setOnGetPoiSearchResultListener_Lcom_baidu_mapapi_search_poi_OnGetPoiSearchResultListener_ == null)
				cb_setOnGetPoiSearchResultListener_Lcom_baidu_mapapi_search_poi_OnGetPoiSearchResultListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnGetPoiSearchResultListener_Lcom_baidu_mapapi_search_poi_OnGetPoiSearchResultListener_);
			return cb_setOnGetPoiSearchResultListener_Lcom_baidu_mapapi_search_poi_OnGetPoiSearchResultListener_;
		}

		static void n_SetOnGetPoiSearchResultListener_Lcom_baidu_mapapi_search_poi_OnGetPoiSearchResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiSearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiSearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListener p0 = (global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnGetPoiSearchResultListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnGetPoiSearchResultListener_Lcom_baidu_mapapi_search_poi_OnGetPoiSearchResultListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiSearch']/method[@name='setOnGetPoiSearchResultListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.poi.OnGetPoiSearchResultListener']]"
		[Register ("setOnGetPoiSearchResultListener", "(Lcom/baidu/mapapi/search/poi/OnGetPoiSearchResultListener;)V", "GetSetOnGetPoiSearchResultListener_Lcom_baidu_mapapi_search_poi_OnGetPoiSearchResultListener_Handler")]
		public virtual unsafe void SetOnGetPoiSearchResultListener (global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListener p0)
		{
			if (id_setOnGetPoiSearchResultListener_Lcom_baidu_mapapi_search_poi_OnGetPoiSearchResultListener_ == IntPtr.Zero)
				id_setOnGetPoiSearchResultListener_Lcom_baidu_mapapi_search_poi_OnGetPoiSearchResultListener_ = JNIEnv.GetMethodID (class_ref, "setOnGetPoiSearchResultListener", "(Lcom/baidu/mapapi/search/poi/OnGetPoiSearchResultListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnGetPoiSearchResultListener_Lcom_baidu_mapapi_search_poi_OnGetPoiSearchResultListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnGetPoiSearchResultListener", "(Lcom/baidu/mapapi/search/poi/OnGetPoiSearchResultListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Search.Poi.GetPoiDetailResultEventArgs> GetPoiDetailResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListener, global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListenerImplementor>(
						ref weak_implementor_SetOnGetPoiSearchResultListener,
						__CreateIOnGetPoiSearchResultListenerImplementor,
						SetOnGetPoiSearchResultListener,
						__h => __h.OnGetPoiDetailResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListener, global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListenerImplementor>(
						ref weak_implementor_SetOnGetPoiSearchResultListener,
						global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListenerImplementor.__IsEmpty,
						__v => SetOnGetPoiSearchResultListener (null),
						__h => __h.OnGetPoiDetailResultHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Search.Poi.GetPoiResultEventArgs> GetPoiResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListener, global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListenerImplementor>(
						ref weak_implementor_SetOnGetPoiSearchResultListener,
						__CreateIOnGetPoiSearchResultListenerImplementor,
						SetOnGetPoiSearchResultListener,
						__h => __h.OnGetPoiResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListener, global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListenerImplementor>(
						ref weak_implementor_SetOnGetPoiSearchResultListener,
						global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListenerImplementor.__IsEmpty,
						__v => SetOnGetPoiSearchResultListener (null),
						__h => __h.OnGetPoiResultHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnGetPoiSearchResultListener;

		global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListenerImplementor __CreateIOnGetPoiSearchResultListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListenerImplementor (this);
		}
#endregion
	}
}
