using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Geocode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCodeResult']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/geocode/GeoCodeResult", DoNotGenerateAcw=true)]
	public partial class GeoCodeResult : global::Com.Baidu.Mapapi.Search.Core.SearchResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/geocode/GeoCodeResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeoCodeResult); }
		}

		protected GeoCodeResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		static Delegate cb_setAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setAddress_Ljava_lang_String_ == null)
				cb_setAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAddress_Ljava_lang_String_);
			return cb_setAddress_Ljava_lang_String_;
		}

		static void n_SetAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Address = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAddress;
		static IntPtr id_setAddress_Ljava_lang_String_;
		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCodeResult']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler")]
			get {
				if (id_getAddress == IntPtr.Zero)
					id_getAddress = JNIEnv.GetMethodID (class_ref, "getAddress", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCodeResult']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAddress", "(Ljava/lang/String;)V", "GetSetAddress_Ljava_lang_String_Handler")]
			set {
				if (id_setAddress_Ljava_lang_String_ == IntPtr.Zero)
					id_setAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAddress", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAddress_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAddress", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='GeoCodeResult']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Lcom/baidu/mapapi/model/LatLng;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()Lcom/baidu/mapapi/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
