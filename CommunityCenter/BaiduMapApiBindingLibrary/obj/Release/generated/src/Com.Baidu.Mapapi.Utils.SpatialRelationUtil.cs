using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='SpatialRelationUtil']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/utils/SpatialRelationUtil", DoNotGenerateAcw=true)]
	public partial class SpatialRelationUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/utils/SpatialRelationUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpatialRelationUtil); }
		}

		protected SpatialRelationUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='SpatialRelationUtil']/constructor[@name='SpatialRelationUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpatialRelationUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SpatialRelationUtil)) {
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

		static IntPtr id_getNearestPointFromLine_Ljava_util_List_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='SpatialRelationUtil']/method[@name='getNearestPointFromLine' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.model.LatLng&gt;'] and parameter[2][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("getNearestPointFromLine", "(Ljava/util/List;Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/LatLng;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.LatLng GetNearestPointFromLine (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> p0, global::Com.Baidu.Mapapi.Model.LatLng p1)
		{
			if (id_getNearestPointFromLine_Ljava_util_List_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_getNearestPointFromLine_Ljava_util_List_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetStaticMethodID (class_ref, "getNearestPointFromLine", "(Ljava/util/List;Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/LatLng;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Baidu.Mapapi.Model.LatLng __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNearestPointFromLine_Ljava_util_List_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isCircleContainsPoint_Lcom_baidu_mapapi_model_LatLng_ILcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='SpatialRelationUtil']/method[@name='isCircleContainsPoint' and count(parameter)=3 and parameter[1][@type='com.baidu.mapapi.model.LatLng'] and parameter[2][@type='int'] and parameter[3][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("isCircleContainsPoint", "(Lcom/baidu/mapapi/model/LatLng;ILcom/baidu/mapapi/model/LatLng;)Z", "")]
		public static unsafe bool IsCircleContainsPoint (global::Com.Baidu.Mapapi.Model.LatLng p0, int p1, global::Com.Baidu.Mapapi.Model.LatLng p2)
		{
			if (id_isCircleContainsPoint_Lcom_baidu_mapapi_model_LatLng_ILcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_isCircleContainsPoint_Lcom_baidu_mapapi_model_LatLng_ILcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetStaticMethodID (class_ref, "isCircleContainsPoint", "(Lcom/baidu/mapapi/model/LatLng;ILcom/baidu/mapapi/model/LatLng;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCircleContainsPoint_Lcom_baidu_mapapi_model_LatLng_ILcom_baidu_mapapi_model_LatLng_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isPolygonContainsPoint_Ljava_util_List_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='SpatialRelationUtil']/method[@name='isPolygonContainsPoint' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.model.LatLng&gt;'] and parameter[2][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("isPolygonContainsPoint", "(Ljava/util/List;Lcom/baidu/mapapi/model/LatLng;)Z", "")]
		public static unsafe bool IsPolygonContainsPoint (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> p0, global::Com.Baidu.Mapapi.Model.LatLng p1)
		{
			if (id_isPolygonContainsPoint_Ljava_util_List_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_isPolygonContainsPoint_Ljava_util_List_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetStaticMethodID (class_ref, "isPolygonContainsPoint", "(Ljava/util/List;Lcom/baidu/mapapi/model/LatLng;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPolygonContainsPoint_Ljava_util_List_Lcom_baidu_mapapi_model_LatLng_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
