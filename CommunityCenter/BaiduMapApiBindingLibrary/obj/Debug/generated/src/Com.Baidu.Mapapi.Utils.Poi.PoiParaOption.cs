using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Utils.Poi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='PoiParaOption']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/utils/poi/PoiParaOption", DoNotGenerateAcw=true)]
	public partial class PoiParaOption : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/utils/poi/PoiParaOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PoiParaOption); }
		}

		protected PoiParaOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='PoiParaOption']/constructor[@name='PoiParaOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PoiParaOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PoiParaOption)) {
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

		static Delegate cb_getCenter;
#pragma warning disable 0169
		static Delegate GetGetCenterHandler ()
		{
			if (cb_getCenter == null)
				cb_getCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenter);
			return cb_getCenter;
		}

		static IntPtr n_GetCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Center);
		}
#pragma warning restore 0169

		static IntPtr id_getCenter;
		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='PoiParaOption']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetCenterHandler")]
			get {
				if (id_getCenter == IntPtr.Zero)
					id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()Lcom/baidu/mapapi/model/LatLng;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getCenter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCenter", "()Lcom/baidu/mapapi/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		static IntPtr id_getKey;
		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='PoiParaOption']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRadius);
			return cb_getRadius;
		}

		static int n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

		static IntPtr id_getRadius;
		public virtual unsafe int Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='PoiParaOption']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()I", "GetGetRadiusHandler")]
			get {
				if (id_getRadius == IntPtr.Zero)
					id_getRadius = JNIEnv.GetMethodID (class_ref, "getRadius", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRadius);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRadius", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getUid;
#pragma warning disable 0169
		static Delegate GetGetUidHandler ()
		{
			if (cb_getUid == null)
				cb_getUid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUid);
			return cb_getUid;
		}

		static IntPtr n_GetUid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uid);
		}
#pragma warning restore 0169

		static IntPtr id_getUid;
		public virtual unsafe string Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='PoiParaOption']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()Ljava/lang/String;", "GetGetUidHandler")]
			get {
				if (id_getUid == IntPtr.Zero)
					id_getUid = JNIEnv.GetMethodID (class_ref, "getUid", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUid), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUid", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_center_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetInvokeCenter_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_center_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_center_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeCenter_Lcom_baidu_mapapi_model_LatLng_);
			return cb_center_Lcom_baidu_mapapi_model_LatLng_;
		}

		static IntPtr n_InvokeCenter_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeCenter (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_center_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='PoiParaOption']/method[@name='center' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("center", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/utils/poi/PoiParaOption;", "GetInvokeCenter_Lcom_baidu_mapapi_model_LatLng_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption InvokeCenter (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_center_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_center_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "center", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/utils/poi/PoiParaOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (JNIEnv.CallObjectMethod  (Handle, id_center_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "center", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/utils/poi/PoiParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_key_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeKey_Ljava_lang_String_Handler ()
		{
			if (cb_key_Ljava_lang_String_ == null)
				cb_key_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeKey_Ljava_lang_String_);
			return cb_key_Ljava_lang_String_;
		}

		static IntPtr n_InvokeKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_key_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='PoiParaOption']/method[@name='key' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("key", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/poi/PoiParaOption;", "GetInvokeKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption InvokeKey (string p0)
		{
			if (id_key_Ljava_lang_String_ == IntPtr.Zero)
				id_key_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "key", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/poi/PoiParaOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (JNIEnv.CallObjectMethod  (Handle, id_key_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "key", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/poi/PoiParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_radius_I;
#pragma warning disable 0169
		static Delegate GetInvokeRadius_IHandler ()
		{
			if (cb_radius_I == null)
				cb_radius_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeRadius_I);
			return cb_radius_I;
		}

		static IntPtr n_InvokeRadius_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeRadius (p0));
		}
#pragma warning restore 0169

		static IntPtr id_radius_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='PoiParaOption']/method[@name='radius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("radius", "(I)Lcom/baidu/mapapi/utils/poi/PoiParaOption;", "GetInvokeRadius_IHandler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption InvokeRadius (int p0)
		{
			if (id_radius_I == IntPtr.Zero)
				id_radius_I = JNIEnv.GetMethodID (class_ref, "radius", "(I)Lcom/baidu/mapapi/utils/poi/PoiParaOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (JNIEnv.CallObjectMethod  (Handle, id_radius_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "radius", "(I)Lcom/baidu/mapapi/utils/poi/PoiParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_uid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeUid_Ljava_lang_String_Handler ()
		{
			if (cb_uid_Ljava_lang_String_ == null)
				cb_uid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeUid_Ljava_lang_String_);
			return cb_uid_Ljava_lang_String_;
		}

		static IntPtr n_InvokeUid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeUid (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_uid_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='PoiParaOption']/method[@name='uid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("uid", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/poi/PoiParaOption;", "GetInvokeUid_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption InvokeUid (string p0)
		{
			if (id_uid_Ljava_lang_String_ == IntPtr.Zero)
				id_uid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "uid", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/poi/PoiParaOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (JNIEnv.CallObjectMethod  (Handle, id_uid_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uid", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/poi/PoiParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
