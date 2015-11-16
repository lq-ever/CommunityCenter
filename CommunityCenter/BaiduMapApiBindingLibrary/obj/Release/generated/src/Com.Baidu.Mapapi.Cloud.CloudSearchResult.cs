using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudSearchResult']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/CloudSearchResult", DoNotGenerateAcw=true)]
	public partial class CloudSearchResult : global::Com.Baidu.Mapapi.Cloud.BaseSearchResult {


		static IntPtr poiList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudSearchResult']/field[@name='poiList']"
		[Register ("poiList")]
		public global::System.Collections.IList PoiList {
			get {
				if (poiList_jfieldId == IntPtr.Zero)
					poiList_jfieldId = JNIEnv.GetFieldID (class_ref, "poiList", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, poiList_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (poiList_jfieldId == IntPtr.Zero)
					poiList_jfieldId = JNIEnv.GetFieldID (class_ref, "poiList", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, poiList_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/cloud/CloudSearchResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CloudSearchResult); }
		}

		protected CloudSearchResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudSearchResult']/constructor[@name='CloudSearchResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CloudSearchResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CloudSearchResult)) {
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
