using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Geocode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCodeOption']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/geocode/GeoCodeOption", DoNotGenerateAcw=true)]
	public partial class GeoCodeOption : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/geocode/GeoCodeOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeoCodeOption); }
		}

		protected GeoCodeOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCodeOption']/constructor[@name='GeoCodeOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GeoCodeOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GeoCodeOption)) {
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

		static Delegate cb_address_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddress_Ljava_lang_String_Handler ()
		{
			if (cb_address_Ljava_lang_String_ == null)
				cb_address_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Address_Ljava_lang_String_);
			return cb_address_Ljava_lang_String_;
		}

		static IntPtr n_Address_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Address (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_address_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCodeOption']/method[@name='address' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("address", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/geocode/GeoCodeOption;", "GetAddress_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption Address (string p0)
		{
			if (id_address_Ljava_lang_String_ == IntPtr.Zero)
				id_address_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "address", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/geocode/GeoCodeOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption> (JNIEnv.CallObjectMethod  (Handle, id_address_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "address", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/geocode/GeoCodeOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_city_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCity_Ljava_lang_String_Handler ()
		{
			if (cb_city_Ljava_lang_String_ == null)
				cb_city_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_City_Ljava_lang_String_);
			return cb_city_Ljava_lang_String_;
		}

		static IntPtr n_City_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.City (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_city_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCodeOption']/method[@name='city' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("city", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/geocode/GeoCodeOption;", "GetCity_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption City (string p0)
		{
			if (id_city_Ljava_lang_String_ == IntPtr.Zero)
				id_city_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "city", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/geocode/GeoCodeOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption> (JNIEnv.CallObjectMethod  (Handle, id_city_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "city", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/geocode/GeoCodeOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
