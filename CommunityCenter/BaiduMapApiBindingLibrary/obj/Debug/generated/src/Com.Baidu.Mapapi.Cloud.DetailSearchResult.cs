using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='DetailSearchResult']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/DetailSearchResult", DoNotGenerateAcw=true)]
	public partial class DetailSearchResult : global::Com.Baidu.Mapapi.Cloud.BaseSearchResult {


		static IntPtr poiInfo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='DetailSearchResult']/field[@name='poiInfo']"
		[Register ("poiInfo")]
		public global::Com.Baidu.Mapapi.Cloud.CloudPoiInfo PoiInfo {
			get {
				if (poiInfo_jfieldId == IntPtr.Zero)
					poiInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "poiInfo", "Lcom/baidu/mapapi/cloud/CloudPoiInfo;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, poiInfo_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.CloudPoiInfo> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (poiInfo_jfieldId == IntPtr.Zero)
					poiInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "poiInfo", "Lcom/baidu/mapapi/cloud/CloudPoiInfo;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, poiInfo_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/cloud/DetailSearchResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DetailSearchResult); }
		}

		protected DetailSearchResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='DetailSearchResult']/constructor[@name='DetailSearchResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DetailSearchResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DetailSearchResult)) {
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
