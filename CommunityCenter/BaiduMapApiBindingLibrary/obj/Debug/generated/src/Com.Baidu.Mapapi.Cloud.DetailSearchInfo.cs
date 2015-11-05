using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='DetailSearchInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/DetailSearchInfo", DoNotGenerateAcw=true)]
	public partial class DetailSearchInfo : global::Com.Baidu.Mapapi.Cloud.BaseSearchInfo {


		static IntPtr uid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='DetailSearchInfo']/field[@name='uid']"
		[Register ("uid")]
		public int Uid {
			get {
				if (uid_jfieldId == IntPtr.Zero)
					uid_jfieldId = JNIEnv.GetFieldID (class_ref, "uid", "I");
				return JNIEnv.GetIntField (Handle, uid_jfieldId);
			}
			set {
				if (uid_jfieldId == IntPtr.Zero)
					uid_jfieldId = JNIEnv.GetFieldID (class_ref, "uid", "I");
				try {
					JNIEnv.SetField (Handle, uid_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/cloud/DetailSearchInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DetailSearchInfo); }
		}

		protected DetailSearchInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='DetailSearchInfo']/constructor[@name='DetailSearchInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DetailSearchInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DetailSearchInfo)) {
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
