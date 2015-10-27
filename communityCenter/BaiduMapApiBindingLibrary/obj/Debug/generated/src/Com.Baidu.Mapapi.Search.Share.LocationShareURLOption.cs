using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Share {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='LocationShareURLOption']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/share/LocationShareURLOption", DoNotGenerateAcw=true)]
	public partial class LocationShareURLOption : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/share/LocationShareURLOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationShareURLOption); }
		}

		protected LocationShareURLOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='LocationShareURLOption']/constructor[@name='LocationShareURLOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocationShareURLOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LocationShareURLOption)) {
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
			global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Location (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_location_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='LocationShareURLOption']/method[@name='location' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("location", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/share/LocationShareURLOption;", "GetLocation_Lcom_baidu_mapapi_model_LatLng_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption Location (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_location_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_location_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "location", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/share/LocationShareURLOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption> (JNIEnv.CallObjectMethod  (Handle, id_location_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "location", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/share/LocationShareURLOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_name_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetName_Ljava_lang_String_Handler ()
		{
			if (cb_name_Ljava_lang_String_ == null)
				cb_name_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Name_Ljava_lang_String_);
			return cb_name_Ljava_lang_String_;
		}

		static IntPtr n_Name_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Name (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_name_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='LocationShareURLOption']/method[@name='name' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("name", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/share/LocationShareURLOption;", "GetName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption Name (string p0)
		{
			if (id_name_Ljava_lang_String_ == IntPtr.Zero)
				id_name_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "name", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/share/LocationShareURLOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption> (JNIEnv.CallObjectMethod  (Handle, id_name_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "name", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/share/LocationShareURLOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_snippet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSnippet_Ljava_lang_String_Handler ()
		{
			if (cb_snippet_Ljava_lang_String_ == null)
				cb_snippet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Snippet_Ljava_lang_String_);
			return cb_snippet_Ljava_lang_String_;
		}

		static IntPtr n_Snippet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Snippet (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_snippet_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='LocationShareURLOption']/method[@name='snippet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("snippet", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/share/LocationShareURLOption;", "GetSnippet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption Snippet (string p0)
		{
			if (id_snippet_Ljava_lang_String_ == IntPtr.Zero)
				id_snippet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "snippet", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/share/LocationShareURLOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption> (JNIEnv.CallObjectMethod  (Handle, id_snippet_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.LocationShareURLOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "snippet", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/share/LocationShareURLOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
