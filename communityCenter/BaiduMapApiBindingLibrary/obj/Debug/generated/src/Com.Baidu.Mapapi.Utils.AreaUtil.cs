using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='AreaUtil']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/utils/AreaUtil", DoNotGenerateAcw=true)]
	public partial class AreaUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/utils/AreaUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AreaUtil); }
		}

		protected AreaUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='AreaUtil']/constructor[@name='AreaUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AreaUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AreaUtil)) {
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

		static IntPtr id_calculateArea_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='AreaUtil']/method[@name='calculateArea' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.model.LatLng'] and parameter[2][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("calculateArea", "(Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/model/LatLng;)D", "")]
		public static unsafe double CalculateArea (global::Com.Baidu.Mapapi.Model.LatLng p0, global::Com.Baidu.Mapapi.Model.LatLng p1)
		{
			if (id_calculateArea_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_calculateArea_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetStaticMethodID (class_ref, "calculateArea", "(Lcom/baidu/mapapi/model/LatLng;Lcom/baidu/mapapi/model/LatLng;)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_calculateArea_Lcom_baidu_mapapi_model_LatLng_Lcom_baidu_mapapi_model_LatLng_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
