using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Poi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiNearbySearchOption']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/poi/PoiNearbySearchOption", DoNotGenerateAcw=true)]
	public partial class PoiNearbySearchOption : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/poi/PoiNearbySearchOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PoiNearbySearchOption); }
		}

		protected PoiNearbySearchOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiNearbySearchOption']/constructor[@name='PoiNearbySearchOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PoiNearbySearchOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PoiNearbySearchOption)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_keyword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetKeyword_Ljava_lang_String_Handler ()
		{
			if (cb_keyword_Ljava_lang_String_ == null)
				cb_keyword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Keyword_Ljava_lang_String_);
			return cb_keyword_Ljava_lang_String_;
		}

		static IntPtr n_Keyword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Keyword (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_keyword_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiNearbySearchOption']/method[@name='keyword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("keyword", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;", "GetKeyword_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption Keyword (string p0)
		{
			if (id_keyword_Ljava_lang_String_ == IntPtr.Zero)
				id_keyword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "keyword", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (JNIEnv.CallObjectMethod  (Handle, id_keyword_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "keyword", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_location_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetLocation_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_location_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_location_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Location_Lcom_baidu_mapapi_model_LatLng_);
			return cb_location_Lcom_baidu_mapapi_model_LatLng_;
		}

		static IntPtr n_Location_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Location (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_location_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiNearbySearchOption']/method[@name='location' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("location", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;", "GetLocation_Lcom_baidu_mapapi_model_LatLng_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption Location (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_location_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_location_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "location", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (JNIEnv.CallObjectMethod  (Handle, id_location_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "location", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_pageCapacity_I;
#pragma warning disable 0169
		static Delegate GetPageCapacity_IHandler ()
		{
			if (cb_pageCapacity_I == null)
				cb_pageCapacity_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PageCapacity_I);
			return cb_pageCapacity_I;
		}

		static IntPtr n_PageCapacity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PageCapacity (p0));
		}
#pragma warning restore 0169

		static IntPtr id_pageCapacity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiNearbySearchOption']/method[@name='pageCapacity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pageCapacity", "(I)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;", "GetPageCapacity_IHandler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption PageCapacity (int p0)
		{
			if (id_pageCapacity_I == IntPtr.Zero)
				id_pageCapacity_I = JNIEnv.GetMethodID (class_ref, "pageCapacity", "(I)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (JNIEnv.CallObjectMethod  (Handle, id_pageCapacity_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pageCapacity", "(I)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pageNum_I;
#pragma warning disable 0169
		static Delegate GetPageNum_IHandler ()
		{
			if (cb_pageNum_I == null)
				cb_pageNum_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PageNum_I);
			return cb_pageNum_I;
		}

		static IntPtr n_PageNum_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PageNum (p0));
		}
#pragma warning restore 0169

		static IntPtr id_pageNum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiNearbySearchOption']/method[@name='pageNum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pageNum", "(I)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;", "GetPageNum_IHandler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption PageNum (int p0)
		{
			if (id_pageNum_I == IntPtr.Zero)
				id_pageNum_I = JNIEnv.GetMethodID (class_ref, "pageNum", "(I)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (JNIEnv.CallObjectMethod  (Handle, id_pageNum_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pageNum", "(I)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_radius_I;
#pragma warning disable 0169
		static Delegate GetRadius_IHandler ()
		{
			if (cb_radius_I == null)
				cb_radius_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Radius_I);
			return cb_radius_I;
		}

		static IntPtr n_Radius_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Radius (p0));
		}
#pragma warning restore 0169

		static IntPtr id_radius_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiNearbySearchOption']/method[@name='radius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("radius", "(I)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;", "GetRadius_IHandler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption Radius (int p0)
		{
			if (id_radius_I == IntPtr.Zero)
				id_radius_I = JNIEnv.GetMethodID (class_ref, "radius", "(I)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (JNIEnv.CallObjectMethod  (Handle, id_radius_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "radius", "(I)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sortType_Lcom_baidu_mapapi_search_poi_PoiSortType_;
#pragma warning disable 0169
		static Delegate GetSortType_Lcom_baidu_mapapi_search_poi_PoiSortType_Handler ()
		{
			if (cb_sortType_Lcom_baidu_mapapi_search_poi_PoiSortType_ == null)
				cb_sortType_Lcom_baidu_mapapi_search_poi_PoiSortType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SortType_Lcom_baidu_mapapi_search_poi_PoiSortType_);
			return cb_sortType_Lcom_baidu_mapapi_search_poi_PoiSortType_;
		}

		static IntPtr n_SortType_Lcom_baidu_mapapi_search_poi_PoiSortType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Poi.PoiSortType p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiSortType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SortType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sortType_Lcom_baidu_mapapi_search_poi_PoiSortType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiNearbySearchOption']/method[@name='sortType' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.poi.PoiSortType']]"
		[Register ("sortType", "(Lcom/baidu/mapapi/search/poi/PoiSortType;)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;", "GetSortType_Lcom_baidu_mapapi_search_poi_PoiSortType_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption SortType (global::Com.Baidu.Mapapi.Search.Poi.PoiSortType p0)
		{
			if (id_sortType_Lcom_baidu_mapapi_search_poi_PoiSortType_ == IntPtr.Zero)
				id_sortType_Lcom_baidu_mapapi_search_poi_PoiSortType_ = JNIEnv.GetMethodID (class_ref, "sortType", "(Lcom/baidu/mapapi/search/poi/PoiSortType;)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (JNIEnv.CallObjectMethod  (Handle, id_sortType_Lcom_baidu_mapapi_search_poi_PoiSortType_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiNearbySearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sortType", "(Lcom/baidu/mapapi/search/poi/PoiSortType;)Lcom/baidu/mapapi/search/poi/PoiNearbySearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
