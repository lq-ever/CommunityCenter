using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Utils.Poi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='BaiduMapPoiSearch']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/utils/poi/BaiduMapPoiSearch", DoNotGenerateAcw=true)]
	public partial class BaiduMapPoiSearch : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/utils/poi/BaiduMapPoiSearch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaiduMapPoiSearch); }
		}

		protected BaiduMapPoiSearch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='BaiduMapPoiSearch']/constructor[@name='BaiduMapPoiSearch' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaiduMapPoiSearch ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaiduMapPoiSearch)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='BaiduMapPoiSearch']/method[@name='finish' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static IntPtr id_openBaiduMapPoiDetialsPage_Lcom_baidu_mapapi_utils_poi_PoiParaOption_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='BaiduMapPoiSearch']/method[@name='openBaiduMapPoiDetialsPage' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.utils.poi.PoiParaOption'] and parameter[2][@type='android.content.Context']]"
		[Register ("openBaiduMapPoiDetialsPage", "(Lcom/baidu/mapapi/utils/poi/PoiParaOption;Landroid/content/Context;)Z", "")]
		public static unsafe bool OpenBaiduMapPoiDetialsPage (global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption p0, global::Android.Content.Context p1)
		{
			if (id_openBaiduMapPoiDetialsPage_Lcom_baidu_mapapi_utils_poi_PoiParaOption_Landroid_content_Context_ == IntPtr.Zero)
				id_openBaiduMapPoiDetialsPage_Lcom_baidu_mapapi_utils_poi_PoiParaOption_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "openBaiduMapPoiDetialsPage", "(Lcom/baidu/mapapi/utils/poi/PoiParaOption;Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_openBaiduMapPoiDetialsPage_Lcom_baidu_mapapi_utils_poi_PoiParaOption_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_openBaiduMapPoiNearbySearch_Lcom_baidu_mapapi_utils_poi_PoiParaOption_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='BaiduMapPoiSearch']/method[@name='openBaiduMapPoiNearbySearch' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.utils.poi.PoiParaOption'] and parameter[2][@type='android.content.Context']]"
		[Register ("openBaiduMapPoiNearbySearch", "(Lcom/baidu/mapapi/utils/poi/PoiParaOption;Landroid/content/Context;)Z", "")]
		public static unsafe bool OpenBaiduMapPoiNearbySearch (global::Com.Baidu.Mapapi.Utils.Poi.PoiParaOption p0, global::Android.Content.Context p1)
		{
			if (id_openBaiduMapPoiNearbySearch_Lcom_baidu_mapapi_utils_poi_PoiParaOption_Landroid_content_Context_ == IntPtr.Zero)
				id_openBaiduMapPoiNearbySearch_Lcom_baidu_mapapi_utils_poi_PoiParaOption_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "openBaiduMapPoiNearbySearch", "(Lcom/baidu/mapapi/utils/poi/PoiParaOption;Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_openBaiduMapPoiNearbySearch_Lcom_baidu_mapapi_utils_poi_PoiParaOption_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setSupportWebPoi_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.poi']/class[@name='BaiduMapPoiSearch']/method[@name='setSupportWebPoi' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSupportWebPoi", "(Z)V", "")]
		public static unsafe void SetSupportWebPoi (bool p0)
		{
			if (id_setSupportWebPoi_Z == IntPtr.Zero)
				id_setSupportWebPoi_Z = JNIEnv.GetStaticMethodID (class_ref, "setSupportWebPoi", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSupportWebPoi_Z, __args);
			} finally {
			}
		}

	}
}
