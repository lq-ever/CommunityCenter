using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Radar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarUploadInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/radar/RadarUploadInfo", DoNotGenerateAcw=true)]
	public partial class RadarUploadInfo : global::Java.Lang.Object {


		static IntPtr comments_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarUploadInfo']/field[@name='comments']"
		[Register ("comments")]
		public string Comments {
			get {
				if (comments_jfieldId == IntPtr.Zero)
					comments_jfieldId = JNIEnv.GetFieldID (class_ref, "comments", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, comments_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (comments_jfieldId == IntPtr.Zero)
					comments_jfieldId = JNIEnv.GetFieldID (class_ref, "comments", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, comments_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr pt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarUploadInfo']/field[@name='pt']"
		[Register ("pt")]
		public global::Com.Baidu.Mapapi.Model.LatLng Pt {
			get {
				if (pt_jfieldId == IntPtr.Zero)
					pt_jfieldId = JNIEnv.GetFieldID (class_ref, "pt", "Lcom/baidu/mapapi/model/LatLng;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, pt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pt_jfieldId == IntPtr.Zero)
					pt_jfieldId = JNIEnv.GetFieldID (class_ref, "pt", "Lcom/baidu/mapapi/model/LatLng;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, pt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/radar/RadarUploadInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RadarUploadInfo); }
		}

		protected RadarUploadInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarUploadInfo']/constructor[@name='RadarUploadInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RadarUploadInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RadarUploadInfo)) {
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
