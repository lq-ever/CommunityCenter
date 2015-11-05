using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/BaseSearchInfo", DoNotGenerateAcw=true)]
	public abstract partial class BaseSearchInfo : global::Java.Lang.Object {


		static IntPtr ak_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchInfo']/field[@name='ak']"
		[Register ("ak")]
		public string Ak {
			get {
				if (ak_jfieldId == IntPtr.Zero)
					ak_jfieldId = JNIEnv.GetFieldID (class_ref, "ak", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, ak_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ak_jfieldId == IntPtr.Zero)
					ak_jfieldId = JNIEnv.GetFieldID (class_ref, "ak", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, ak_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr geoTableId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchInfo']/field[@name='geoTableId']"
		[Register ("geoTableId")]
		public int GeoTableId {
			get {
				if (geoTableId_jfieldId == IntPtr.Zero)
					geoTableId_jfieldId = JNIEnv.GetFieldID (class_ref, "geoTableId", "I");
				return JNIEnv.GetIntField (Handle, geoTableId_jfieldId);
			}
			set {
				if (geoTableId_jfieldId == IntPtr.Zero)
					geoTableId_jfieldId = JNIEnv.GetFieldID (class_ref, "geoTableId", "I");
				try {
					JNIEnv.SetField (Handle, geoTableId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchInfo']/field[@name='sn']"
		[Register ("sn")]
		public string Sn {
			get {
				if (sn_jfieldId == IntPtr.Zero)
					sn_jfieldId = JNIEnv.GetFieldID (class_ref, "sn", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sn_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sn_jfieldId == IntPtr.Zero)
					sn_jfieldId = JNIEnv.GetFieldID (class_ref, "sn", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, sn_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/cloud/BaseSearchInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseSearchInfo); }
		}

		protected BaseSearchInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchInfo']/constructor[@name='BaseSearchInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseSearchInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaseSearchInfo)) {
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

	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/BaseSearchInfo", DoNotGenerateAcw=true)]
	internal partial class BaseSearchInfoInvoker : BaseSearchInfo {

		public BaseSearchInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseSearchInfoInvoker); }
		}

	}

}
