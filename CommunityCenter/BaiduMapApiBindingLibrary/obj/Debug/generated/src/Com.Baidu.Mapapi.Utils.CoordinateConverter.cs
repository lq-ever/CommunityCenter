using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='CoordinateConverter']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/utils/CoordinateConverter", DoNotGenerateAcw=true)]
	public partial class CoordinateConverter : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='CoordinateConverter.CoordType']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/utils/CoordinateConverter$CoordType", DoNotGenerateAcw=true)]
		public sealed partial class CoordType : global::Java.Lang.Enum {


			static IntPtr COMMON_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='CoordinateConverter.CoordType']/field[@name='COMMON']"
			[Register ("COMMON")]
			public static global::Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType Common {
				get {
					if (COMMON_jfieldId == IntPtr.Zero)
						COMMON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMMON", "Lcom/baidu/mapapi/utils/CoordinateConverter$CoordType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMMON_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GPS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='CoordinateConverter.CoordType']/field[@name='GPS']"
			[Register ("GPS")]
			public static global::Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType Gps {
				get {
					if (GPS_jfieldId == IntPtr.Zero)
						GPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GPS", "Lcom/baidu/mapapi/utils/CoordinateConverter$CoordType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GPS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/utils/CoordinateConverter$CoordType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CoordType); }
			}

			internal CoordType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='CoordinateConverter.CoordType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/CoordinateConverter$CoordType;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/CoordinateConverter$CoordType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='CoordinateConverter.CoordType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/utils/CoordinateConverter$CoordType;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/utils/CoordinateConverter$CoordType;");
				try {
					return (global::Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/utils/CoordinateConverter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CoordinateConverter); }
		}

		protected CoordinateConverter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='CoordinateConverter']/constructor[@name='CoordinateConverter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CoordinateConverter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CoordinateConverter)) {
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

		static Delegate cb_convert;
#pragma warning disable 0169
		static Delegate GetConvertHandler ()
		{
			if (cb_convert == null)
				cb_convert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Convert);
			return cb_convert;
		}

		static IntPtr n_Convert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Utils.CoordinateConverter __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.CoordinateConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Convert ());
		}
#pragma warning restore 0169

		static IntPtr id_convert;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='CoordinateConverter']/method[@name='convert' and count(parameter)=0]"
		[Register ("convert", "()Lcom/baidu/mapapi/model/LatLng;", "GetConvertHandler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng Convert ()
		{
			if (id_convert == IntPtr.Zero)
				id_convert = JNIEnv.GetMethodID (class_ref, "convert", "()Lcom/baidu/mapapi/model/LatLng;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_convert), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convert", "()Lcom/baidu/mapapi/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_coord_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetCoord_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_coord_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_coord_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Coord_Lcom_baidu_mapapi_model_LatLng_);
			return cb_coord_Lcom_baidu_mapapi_model_LatLng_;
		}

		static IntPtr n_Coord_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Utils.CoordinateConverter __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.CoordinateConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Coord (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_coord_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='CoordinateConverter']/method[@name='coord' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("coord", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/utils/CoordinateConverter;", "GetCoord_Lcom_baidu_mapapi_model_LatLng_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Utils.CoordinateConverter Coord (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_coord_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_coord_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "coord", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/utils/CoordinateConverter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Utils.CoordinateConverter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.CoordinateConverter> (JNIEnv.CallObjectMethod  (Handle, id_coord_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.CoordinateConverter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "coord", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/utils/CoordinateConverter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_from_Lcom_baidu_mapapi_utils_CoordinateConverter_CoordType_;
#pragma warning disable 0169
		static Delegate GetFrom_Lcom_baidu_mapapi_utils_CoordinateConverter_CoordType_Handler ()
		{
			if (cb_from_Lcom_baidu_mapapi_utils_CoordinateConverter_CoordType_ == null)
				cb_from_Lcom_baidu_mapapi_utils_CoordinateConverter_CoordType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_From_Lcom_baidu_mapapi_utils_CoordinateConverter_CoordType_);
			return cb_from_Lcom_baidu_mapapi_utils_CoordinateConverter_CoordType_;
		}

		static IntPtr n_From_Lcom_baidu_mapapi_utils_CoordinateConverter_CoordType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Utils.CoordinateConverter __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.CoordinateConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.From (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_from_Lcom_baidu_mapapi_utils_CoordinateConverter_CoordType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='CoordinateConverter']/method[@name='from' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.utils.CoordinateConverter.CoordType']]"
		[Register ("from", "(Lcom/baidu/mapapi/utils/CoordinateConverter$CoordType;)Lcom/baidu/mapapi/utils/CoordinateConverter;", "GetFrom_Lcom_baidu_mapapi_utils_CoordinateConverter_CoordType_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Utils.CoordinateConverter From (global::Com.Baidu.Mapapi.Utils.CoordinateConverter.CoordType p0)
		{
			if (id_from_Lcom_baidu_mapapi_utils_CoordinateConverter_CoordType_ == IntPtr.Zero)
				id_from_Lcom_baidu_mapapi_utils_CoordinateConverter_CoordType_ = JNIEnv.GetMethodID (class_ref, "from", "(Lcom/baidu/mapapi/utils/CoordinateConverter$CoordType;)Lcom/baidu/mapapi/utils/CoordinateConverter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Utils.CoordinateConverter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.CoordinateConverter> (JNIEnv.CallObjectMethod  (Handle, id_from_Lcom_baidu_mapapi_utils_CoordinateConverter_CoordType_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.CoordinateConverter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "from", "(Lcom/baidu/mapapi/utils/CoordinateConverter$CoordType;)Lcom/baidu/mapapi/utils/CoordinateConverter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
