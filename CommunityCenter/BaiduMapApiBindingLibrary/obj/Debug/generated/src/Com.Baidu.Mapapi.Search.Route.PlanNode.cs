using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Route {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='PlanNode']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/PlanNode", DoNotGenerateAcw=true)]
	public partial class PlanNode : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/route/PlanNode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlanNode); }
		}

		protected PlanNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_withCityNameAndPlaceName_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='PlanNode']/method[@name='withCityNameAndPlaceName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("withCityNameAndPlaceName", "(Ljava/lang/String;Ljava/lang/String;)Lcom/baidu/mapapi/search/route/PlanNode;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Search.Route.PlanNode WithCityNameAndPlaceName (string p0, string p1)
		{
			if (id_withCityNameAndPlaceName_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_withCityNameAndPlaceName_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "withCityNameAndPlaceName", "(Ljava/lang/String;Ljava/lang/String;)Lcom/baidu/mapapi/search/route/PlanNode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Baidu.Mapapi.Search.Route.PlanNode __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.PlanNode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_withCityNameAndPlaceName_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_withLocation_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='PlanNode']/method[@name='withLocation' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("withLocation", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/route/PlanNode;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Search.Route.PlanNode WithLocation (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_withLocation_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_withLocation_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetStaticMethodID (class_ref, "withLocation", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/route/PlanNode;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Search.Route.PlanNode __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.PlanNode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_withLocation_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
