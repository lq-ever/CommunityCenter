using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Radar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchError']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/radar/RadarSearchError", DoNotGenerateAcw=true)]
	public sealed partial class RadarSearchError : global::Java.Lang.Enum {


		static IntPtr RADAR_AK_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchError']/field[@name='RADAR_AK_ERROR']"
		[Register ("RADAR_AK_ERROR")]
		public static global::Com.Baidu.Mapapi.Radar.RadarSearchError RadarAkError {
			get {
				if (RADAR_AK_ERROR_jfieldId == IntPtr.Zero)
					RADAR_AK_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RADAR_AK_ERROR", "Lcom/baidu/mapapi/radar/RadarSearchError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RADAR_AK_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RADAR_AK_NOT_BIND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchError']/field[@name='RADAR_AK_NOT_BIND']"
		[Register ("RADAR_AK_NOT_BIND")]
		public static global::Com.Baidu.Mapapi.Radar.RadarSearchError RadarAkNotBind {
			get {
				if (RADAR_AK_NOT_BIND_jfieldId == IntPtr.Zero)
					RADAR_AK_NOT_BIND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RADAR_AK_NOT_BIND", "Lcom/baidu/mapapi/radar/RadarSearchError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RADAR_AK_NOT_BIND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RADAR_FORBID_BY_ADMIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchError']/field[@name='RADAR_FORBID_BY_ADMIN']"
		[Register ("RADAR_FORBID_BY_ADMIN")]
		public static global::Com.Baidu.Mapapi.Radar.RadarSearchError RadarForbidByAdmin {
			get {
				if (RADAR_FORBID_BY_ADMIN_jfieldId == IntPtr.Zero)
					RADAR_FORBID_BY_ADMIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RADAR_FORBID_BY_ADMIN", "Lcom/baidu/mapapi/radar/RadarSearchError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RADAR_FORBID_BY_ADMIN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RADAR_FORBID_BY_USER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchError']/field[@name='RADAR_FORBID_BY_USER']"
		[Register ("RADAR_FORBID_BY_USER")]
		public static global::Com.Baidu.Mapapi.Radar.RadarSearchError RadarForbidByUser {
			get {
				if (RADAR_FORBID_BY_USER_jfieldId == IntPtr.Zero)
					RADAR_FORBID_BY_USER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RADAR_FORBID_BY_USER", "Lcom/baidu/mapapi/radar/RadarSearchError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RADAR_FORBID_BY_USER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RADAR_NETWORK_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchError']/field[@name='RADAR_NETWORK_ERROR']"
		[Register ("RADAR_NETWORK_ERROR")]
		public static global::Com.Baidu.Mapapi.Radar.RadarSearchError RadarNetworkError {
			get {
				if (RADAR_NETWORK_ERROR_jfieldId == IntPtr.Zero)
					RADAR_NETWORK_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RADAR_NETWORK_ERROR", "Lcom/baidu/mapapi/radar/RadarSearchError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RADAR_NETWORK_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RADAR_NETWORK_TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchError']/field[@name='RADAR_NETWORK_TIMEOUT']"
		[Register ("RADAR_NETWORK_TIMEOUT")]
		public static global::Com.Baidu.Mapapi.Radar.RadarSearchError RadarNetworkTimeout {
			get {
				if (RADAR_NETWORK_TIMEOUT_jfieldId == IntPtr.Zero)
					RADAR_NETWORK_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RADAR_NETWORK_TIMEOUT", "Lcom/baidu/mapapi/radar/RadarSearchError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RADAR_NETWORK_TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RADAR_NO_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchError']/field[@name='RADAR_NO_ERROR']"
		[Register ("RADAR_NO_ERROR")]
		public static global::Com.Baidu.Mapapi.Radar.RadarSearchError RadarNoError {
			get {
				if (RADAR_NO_ERROR_jfieldId == IntPtr.Zero)
					RADAR_NO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RADAR_NO_ERROR", "Lcom/baidu/mapapi/radar/RadarSearchError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RADAR_NO_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RADAR_NO_RESULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchError']/field[@name='RADAR_NO_RESULT']"
		[Register ("RADAR_NO_RESULT")]
		public static global::Com.Baidu.Mapapi.Radar.RadarSearchError RadarNoResult {
			get {
				if (RADAR_NO_RESULT_jfieldId == IntPtr.Zero)
					RADAR_NO_RESULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RADAR_NO_RESULT", "Lcom/baidu/mapapi/radar/RadarSearchError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RADAR_NO_RESULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RADAR_PERMISSION_UNFINISHED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchError']/field[@name='RADAR_PERMISSION_UNFINISHED']"
		[Register ("RADAR_PERMISSION_UNFINISHED")]
		public static global::Com.Baidu.Mapapi.Radar.RadarSearchError RadarPermissionUnfinished {
			get {
				if (RADAR_PERMISSION_UNFINISHED_jfieldId == IntPtr.Zero)
					RADAR_PERMISSION_UNFINISHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RADAR_PERMISSION_UNFINISHED", "Lcom/baidu/mapapi/radar/RadarSearchError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RADAR_PERMISSION_UNFINISHED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RADAR_USERID_NOT_EXIST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchError']/field[@name='RADAR_USERID_NOT_EXIST']"
		[Register ("RADAR_USERID_NOT_EXIST")]
		public static global::Com.Baidu.Mapapi.Radar.RadarSearchError RadarUseridNotExist {
			get {
				if (RADAR_USERID_NOT_EXIST_jfieldId == IntPtr.Zero)
					RADAR_USERID_NOT_EXIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RADAR_USERID_NOT_EXIST", "Lcom/baidu/mapapi/radar/RadarSearchError;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RADAR_USERID_NOT_EXIST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/radar/RadarSearchError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RadarSearchError); }
		}

		internal RadarSearchError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/radar/RadarSearchError;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Radar.RadarSearchError ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/radar/RadarSearchError;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Radar.RadarSearchError __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchError']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/baidu/mapapi/radar/RadarSearchError;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Radar.RadarSearchError[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/radar/RadarSearchError;");
			try {
				return (global::Com.Baidu.Mapapi.Radar.RadarSearchError[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Radar.RadarSearchError));
			} finally {
			}
		}

	}
}
