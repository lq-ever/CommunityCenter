using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Poi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiSortType']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/poi/PoiSortType", DoNotGenerateAcw=true)]
	public sealed partial class PoiSortType : global::Java.Lang.Enum {


		static IntPtr comprehensive_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiSortType']/field[@name='comprehensive']"
		[Register ("comprehensive")]
		public static global::Com.Baidu.Mapapi.Search.Poi.PoiSortType Comprehensive {
			get {
				if (comprehensive_jfieldId == IntPtr.Zero)
					comprehensive_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "comprehensive", "Lcom/baidu/mapapi/search/poi/PoiSortType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, comprehensive_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiSortType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr distance_from_near_to_far_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiSortType']/field[@name='distance_from_near_to_far']"
		[Register ("distance_from_near_to_far")]
		public static global::Com.Baidu.Mapapi.Search.Poi.PoiSortType DistanceFromNearToFar {
			get {
				if (distance_from_near_to_far_jfieldId == IntPtr.Zero)
					distance_from_near_to_far_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "distance_from_near_to_far", "Lcom/baidu/mapapi/search/poi/PoiSortType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, distance_from_near_to_far_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiSortType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/poi/PoiSortType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PoiSortType); }
		}

		internal PoiSortType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiSortType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/poi/PoiSortType;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Search.Poi.PoiSortType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/poi/PoiSortType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Baidu.Mapapi.Search.Poi.PoiSortType __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiSortType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiSortType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/baidu/mapapi/search/poi/PoiSortType;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Search.Poi.PoiSortType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/search/poi/PoiSortType;");
			try {
				return (global::Com.Baidu.Mapapi.Search.Poi.PoiSortType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Search.Poi.PoiSortType));
			} finally {
			}
		}

	}
}
