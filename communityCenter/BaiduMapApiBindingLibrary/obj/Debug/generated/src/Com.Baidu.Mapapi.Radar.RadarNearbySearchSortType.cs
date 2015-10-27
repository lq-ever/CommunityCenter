using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Radar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchSortType']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/radar/RadarNearbySearchSortType", DoNotGenerateAcw=true)]
	public sealed partial class RadarNearbySearchSortType : global::Java.Lang.Enum {


		static IntPtr distance_from_far_to_near_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchSortType']/field[@name='distance_from_far_to_near']"
		[Register ("distance_from_far_to_near")]
		public static global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType DistanceFromFarToNear {
			get {
				if (distance_from_far_to_near_jfieldId == IntPtr.Zero)
					distance_from_far_to_near_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "distance_from_far_to_near", "Lcom/baidu/mapapi/radar/RadarNearbySearchSortType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, distance_from_far_to_near_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr distance_from_near_to_far_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchSortType']/field[@name='distance_from_near_to_far']"
		[Register ("distance_from_near_to_far")]
		public static global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType DistanceFromNearToFar {
			get {
				if (distance_from_near_to_far_jfieldId == IntPtr.Zero)
					distance_from_near_to_far_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "distance_from_near_to_far", "Lcom/baidu/mapapi/radar/RadarNearbySearchSortType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, distance_from_near_to_far_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr time_from_past_to_recent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchSortType']/field[@name='time_from_past_to_recent']"
		[Register ("time_from_past_to_recent")]
		public static global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType TimeFromPastToRecent {
			get {
				if (time_from_past_to_recent_jfieldId == IntPtr.Zero)
					time_from_past_to_recent_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "time_from_past_to_recent", "Lcom/baidu/mapapi/radar/RadarNearbySearchSortType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, time_from_past_to_recent_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr time_from_recent_to_past_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchSortType']/field[@name='time_from_recent_to_past']"
		[Register ("time_from_recent_to_past")]
		public static global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType TimeFromRecentToPast {
			get {
				if (time_from_recent_to_past_jfieldId == IntPtr.Zero)
					time_from_recent_to_past_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "time_from_recent_to_past", "Lcom/baidu/mapapi/radar/RadarNearbySearchSortType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, time_from_recent_to_past_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/radar/RadarNearbySearchSortType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RadarNearbySearchSortType); }
		}

		internal RadarNearbySearchSortType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchSortType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/radar/RadarNearbySearchSortType;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/radar/RadarNearbySearchSortType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchSortType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/baidu/mapapi/radar/RadarNearbySearchSortType;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/radar/RadarNearbySearchSortType;");
			try {
				return (global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType));
			} finally {
			}
		}

	}
}
