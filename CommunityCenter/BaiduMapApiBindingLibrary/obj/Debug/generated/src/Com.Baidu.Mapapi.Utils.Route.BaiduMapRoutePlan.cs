using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Utils.Route {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='BaiduMapRoutePlan']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/utils/route/BaiduMapRoutePlan", DoNotGenerateAcw=true)]
	public partial class BaiduMapRoutePlan : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/utils/route/BaiduMapRoutePlan", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaiduMapRoutePlan); }
		}

		protected BaiduMapRoutePlan (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='BaiduMapRoutePlan']/constructor[@name='BaiduMapRoutePlan' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaiduMapRoutePlan ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaiduMapRoutePlan)) {
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

		static IntPtr id_finish_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='BaiduMapRoutePlan']/method[@name='finish' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("finish", "(Landroid/content/Context;)V", "")]
		public static unsafe void Finish (global::Android.Content.Context p0)
		{
			if (id_finish_Landroid_content_Context_ == IntPtr.Zero)
				id_finish_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "finish", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_finish_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_openBaiduMapDrivingRoute_Lcom_baidu_mapapi_utils_route_RouteParaOption_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='BaiduMapRoutePlan']/method[@name='openBaiduMapDrivingRoute' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.utils.route.RouteParaOption'] and parameter[2][@type='android.content.Context']]"
		[Register ("openBaiduMapDrivingRoute", "(Lcom/baidu/mapapi/utils/route/RouteParaOption;Landroid/content/Context;)Z", "")]
		public static unsafe bool OpenBaiduMapDrivingRoute (global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption p0, global::Android.Content.Context p1)
		{
			if (id_openBaiduMapDrivingRoute_Lcom_baidu_mapapi_utils_route_RouteParaOption_Landroid_content_Context_ == IntPtr.Zero)
				id_openBaiduMapDrivingRoute_Lcom_baidu_mapapi_utils_route_RouteParaOption_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "openBaiduMapDrivingRoute", "(Lcom/baidu/mapapi/utils/route/RouteParaOption;Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_openBaiduMapDrivingRoute_Lcom_baidu_mapapi_utils_route_RouteParaOption_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_openBaiduMapTransitRoute_Lcom_baidu_mapapi_utils_route_RouteParaOption_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='BaiduMapRoutePlan']/method[@name='openBaiduMapTransitRoute' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.utils.route.RouteParaOption'] and parameter[2][@type='android.content.Context']]"
		[Register ("openBaiduMapTransitRoute", "(Lcom/baidu/mapapi/utils/route/RouteParaOption;Landroid/content/Context;)Z", "")]
		public static unsafe bool OpenBaiduMapTransitRoute (global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption p0, global::Android.Content.Context p1)
		{
			if (id_openBaiduMapTransitRoute_Lcom_baidu_mapapi_utils_route_RouteParaOption_Landroid_content_Context_ == IntPtr.Zero)
				id_openBaiduMapTransitRoute_Lcom_baidu_mapapi_utils_route_RouteParaOption_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "openBaiduMapTransitRoute", "(Lcom/baidu/mapapi/utils/route/RouteParaOption;Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_openBaiduMapTransitRoute_Lcom_baidu_mapapi_utils_route_RouteParaOption_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_openBaiduMapWalkingRoute_Lcom_baidu_mapapi_utils_route_RouteParaOption_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='BaiduMapRoutePlan']/method[@name='openBaiduMapWalkingRoute' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.utils.route.RouteParaOption'] and parameter[2][@type='android.content.Context']]"
		[Register ("openBaiduMapWalkingRoute", "(Lcom/baidu/mapapi/utils/route/RouteParaOption;Landroid/content/Context;)Z", "")]
		public static unsafe bool OpenBaiduMapWalkingRoute (global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption p0, global::Android.Content.Context p1)
		{
			if (id_openBaiduMapWalkingRoute_Lcom_baidu_mapapi_utils_route_RouteParaOption_Landroid_content_Context_ == IntPtr.Zero)
				id_openBaiduMapWalkingRoute_Lcom_baidu_mapapi_utils_route_RouteParaOption_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "openBaiduMapWalkingRoute", "(Lcom/baidu/mapapi/utils/route/RouteParaOption;Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_openBaiduMapWalkingRoute_Lcom_baidu_mapapi_utils_route_RouteParaOption_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setSupportWebRoute_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='BaiduMapRoutePlan']/method[@name='setSupportWebRoute' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSupportWebRoute", "(Z)V", "")]
		public static unsafe void SetSupportWebRoute (bool p0)
		{
			if (id_setSupportWebRoute_Z == IntPtr.Zero)
				id_setSupportWebRoute_Z = JNIEnv.GetStaticMethodID (class_ref, "setSupportWebRoute", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSupportWebRoute_Z, __args);
			} finally {
			}
		}

	}
}
