using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Navi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='BaiduMapNavigation']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/navi/BaiduMapNavigation", DoNotGenerateAcw=true)]
	public partial class BaiduMapNavigation : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/navi/BaiduMapNavigation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaiduMapNavigation); }
		}

		protected BaiduMapNavigation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='BaiduMapNavigation']/constructor[@name='BaiduMapNavigation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaiduMapNavigation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaiduMapNavigation)) {
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

		static IntPtr id_openBaiduMapNavi_Lcom_baidu_mapapi_navi_NaviParaOption_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='BaiduMapNavigation']/method[@name='openBaiduMapNavi' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.navi.NaviParaOption'] and parameter[2][@type='android.content.Context']]"
		[Register ("openBaiduMapNavi", "(Lcom/baidu/mapapi/navi/NaviParaOption;Landroid/content/Context;)Z", "")]
		public static unsafe bool OpenBaiduMapNavi (global::Com.Baidu.Mapapi.Navi.NaviParaOption p0, global::Android.Content.Context p1)
		{
			if (id_openBaiduMapNavi_Lcom_baidu_mapapi_navi_NaviParaOption_Landroid_content_Context_ == IntPtr.Zero)
				id_openBaiduMapNavi_Lcom_baidu_mapapi_navi_NaviParaOption_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "openBaiduMapNavi", "(Lcom/baidu/mapapi/navi/NaviParaOption;Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_openBaiduMapNavi_Lcom_baidu_mapapi_navi_NaviParaOption_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_openWebBaiduMapNavi_Lcom_baidu_mapapi_navi_NaviParaOption_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='BaiduMapNavigation']/method[@name='openWebBaiduMapNavi' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.navi.NaviParaOption'] and parameter[2][@type='android.content.Context']]"
		[Obsolete (@"deprecated")]
		[Register ("openWebBaiduMapNavi", "(Lcom/baidu/mapapi/navi/NaviParaOption;Landroid/content/Context;)V", "")]
		public static unsafe void OpenWebBaiduMapNavi (global::Com.Baidu.Mapapi.Navi.NaviParaOption p0, global::Android.Content.Context p1)
		{
			if (id_openWebBaiduMapNavi_Lcom_baidu_mapapi_navi_NaviParaOption_Landroid_content_Context_ == IntPtr.Zero)
				id_openWebBaiduMapNavi_Lcom_baidu_mapapi_navi_NaviParaOption_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "openWebBaiduMapNavi", "(Lcom/baidu/mapapi/navi/NaviParaOption;Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_openWebBaiduMapNavi_Lcom_baidu_mapapi_navi_NaviParaOption_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_setSupportWebNavi_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='BaiduMapNavigation']/method[@name='setSupportWebNavi' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSupportWebNavi", "(Z)V", "")]
		public static unsafe void SetSupportWebNavi (bool p0)
		{
			if (id_setSupportWebNavi_Z == IntPtr.Zero)
				id_setSupportWebNavi_Z = JNIEnv.GetStaticMethodID (class_ref, "setSupportWebNavi", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSupportWebNavi_Z, __args);
			} finally {
			}
		}

	}
}
