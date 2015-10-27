using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='OpenClientUtil']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/utils/OpenClientUtil", DoNotGenerateAcw=true)]
	public partial class OpenClientUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/utils/OpenClientUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OpenClientUtil); }
		}

		protected OpenClientUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='OpenClientUtil']/constructor[@name='OpenClientUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OpenClientUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OpenClientUtil)) {
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

		static IntPtr id_getBaiduMapVersion_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='OpenClientUtil']/method[@name='getBaiduMapVersion' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getBaiduMapVersion", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetBaiduMapVersion (global::Android.Content.Context p0)
		{
			if (id_getBaiduMapVersion_Landroid_content_Context_ == IntPtr.Zero)
				id_getBaiduMapVersion_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getBaiduMapVersion", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getBaiduMapVersion_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLatestBaiduMapApp_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='OpenClientUtil']/method[@name='getLatestBaiduMapApp' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLatestBaiduMapApp", "(Landroid/content/Context;)V", "")]
		public static unsafe void GetLatestBaiduMapApp (global::Android.Content.Context p0)
		{
			if (id_getLatestBaiduMapApp_Landroid_content_Context_ == IntPtr.Zero)
				id_getLatestBaiduMapApp_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLatestBaiduMapApp", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getLatestBaiduMapApp_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
