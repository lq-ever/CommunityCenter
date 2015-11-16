using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Poi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiBoundSearchOption']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/poi/PoiBoundSearchOption", DoNotGenerateAcw=true)]
	public partial class PoiBoundSearchOption : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/poi/PoiBoundSearchOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PoiBoundSearchOption); }
		}

		protected PoiBoundSearchOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiBoundSearchOption']/constructor[@name='PoiBoundSearchOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PoiBoundSearchOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PoiBoundSearchOption)) {
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

		static Delegate cb_bound_Lcom_baidu_mapapi_model_LatLngBounds_;
#pragma warning disable 0169
		static Delegate GetBound_Lcom_baidu_mapapi_model_LatLngBounds_Handler ()
		{
			if (cb_bound_Lcom_baidu_mapapi_model_LatLngBounds_ == null)
				cb_bound_Lcom_baidu_mapapi_model_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Bound_Lcom_baidu_mapapi_model_LatLngBounds_);
			return cb_bound_Lcom_baidu_mapapi_model_LatLngBounds_;
		}

		static IntPtr n_Bound_Lcom_baidu_mapapi_model_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLngBounds p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLngBounds> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Bound (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_bound_Lcom_baidu_mapapi_model_LatLngBounds_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiBoundSearchOption']/method[@name='bound' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds']]"
		[Register ("bound", "(Lcom/baidu/mapapi/model/LatLngBounds;)Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;", "GetBound_Lcom_baidu_mapapi_model_LatLngBounds_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption Bound (global::Com.Baidu.Mapapi.Model.LatLngBounds p0)
		{
			if (id_bound_Lcom_baidu_mapapi_model_LatLngBounds_ == IntPtr.Zero)
				id_bound_Lcom_baidu_mapapi_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "bound", "(Lcom/baidu/mapapi/model/LatLngBounds;)Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption> (JNIEnv.CallObjectMethod  (Handle, id_bound_Lcom_baidu_mapapi_model_LatLngBounds_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bound", "(Lcom/baidu/mapapi/model/LatLngBounds;)Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Keyword (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_keyword_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiBoundSearchOption']/method[@name='keyword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("keyword", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;", "GetKeyword_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption Keyword (string p0)
		{
			if (id_keyword_Ljava_lang_String_ == IntPtr.Zero)
				id_keyword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "keyword", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption> (JNIEnv.CallObjectMethod  (Handle, id_keyword_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "keyword", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PageCapacity (p0));
		}
#pragma warning restore 0169

		static IntPtr id_pageCapacity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiBoundSearchOption']/method[@name='pageCapacity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pageCapacity", "(I)Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;", "GetPageCapacity_IHandler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption PageCapacity (int p0)
		{
			if (id_pageCapacity_I == IntPtr.Zero)
				id_pageCapacity_I = JNIEnv.GetMethodID (class_ref, "pageCapacity", "(I)Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption> (JNIEnv.CallObjectMethod  (Handle, id_pageCapacity_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pageCapacity", "(I)Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PageNum (p0));
		}
#pragma warning restore 0169

		static IntPtr id_pageNum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiBoundSearchOption']/method[@name='pageNum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pageNum", "(I)Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;", "GetPageNum_IHandler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption PageNum (int p0)
		{
			if (id_pageNum_I == IntPtr.Zero)
				id_pageNum_I = JNIEnv.GetMethodID (class_ref, "pageNum", "(I)Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption> (JNIEnv.CallObjectMethod  (Handle, id_pageNum_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiBoundSearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pageNum", "(I)Lcom/baidu/mapapi/search/poi/PoiBoundSearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
