using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BoundSearchInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/BoundSearchInfo", DoNotGenerateAcw=true)]
	public partial class BoundSearchInfo : global::Com.Baidu.Mapapi.Cloud.BaseCloudSearchInfo {


		static IntPtr bound_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BoundSearchInfo']/field[@name='bound']"
		[Register ("bound")]
		public string Bound {
			get {
				if (bound_jfieldId == IntPtr.Zero)
					bound_jfieldId = JNIEnv.GetFieldID (class_ref, "bound", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, bound_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bound_jfieldId == IntPtr.Zero)
					bound_jfieldId = JNIEnv.GetFieldID (class_ref, "bound", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, bound_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/cloud/BoundSearchInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BoundSearchInfo); }
		}

		protected BoundSearchInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BoundSearchInfo']/constructor[@name='BoundSearchInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BoundSearchInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BoundSearchInfo)) {
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

	}
}
