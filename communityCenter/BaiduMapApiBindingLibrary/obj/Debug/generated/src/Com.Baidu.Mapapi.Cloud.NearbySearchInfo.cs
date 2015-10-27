using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='NearbySearchInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/NearbySearchInfo", DoNotGenerateAcw=true)]
	public partial class NearbySearchInfo : global::Com.Baidu.Mapapi.Cloud.BaseCloudSearchInfo {


		static IntPtr location_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='NearbySearchInfo']/field[@name='location']"
		[Register ("location")]
		public string Location {
			get {
				if (location_jfieldId == IntPtr.Zero)
					location_jfieldId = JNIEnv.GetFieldID (class_ref, "location", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, location_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (location_jfieldId == IntPtr.Zero)
					location_jfieldId = JNIEnv.GetFieldID (class_ref, "location", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, location_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr radius_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='NearbySearchInfo']/field[@name='radius']"
		[Register ("radius")]
		public int Radius {
			get {
				if (radius_jfieldId == IntPtr.Zero)
					radius_jfieldId = JNIEnv.GetFieldID (class_ref, "radius", "I");
				return JNIEnv.GetIntField (Handle, radius_jfieldId);
			}
			set {
				if (radius_jfieldId == IntPtr.Zero)
					radius_jfieldId = JNIEnv.GetFieldID (class_ref, "radius", "I");
				try {
					JNIEnv.SetField (Handle, radius_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/cloud/NearbySearchInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NearbySearchInfo); }
		}

		protected NearbySearchInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='NearbySearchInfo']/constructor[@name='NearbySearchInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NearbySearchInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NearbySearchInfo)) {
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
