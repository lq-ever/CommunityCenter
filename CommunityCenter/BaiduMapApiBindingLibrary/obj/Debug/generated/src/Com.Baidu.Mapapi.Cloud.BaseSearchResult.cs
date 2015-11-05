using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchResult']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/BaseSearchResult", DoNotGenerateAcw=true)]
	public abstract partial class BaseSearchResult : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchResult']/field[@name='STATUS_CODE_NETWORK_ERROR']"
		[Register ("STATUS_CODE_NETWORK_ERROR")]
		public const int StatusCodeNetworkError = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchResult']/field[@name='STATUS_CODE_NETWORK_TIME_OUT']"
		[Register ("STATUS_CODE_NETWORK_TIME_OUT")]
		public const int StatusCodeNetworkTimeOut = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchResult']/field[@name='STATUS_CODE_RESULT_NOTFOUND']"
		[Register ("STATUS_CODE_RESULT_NOTFOUND")]
		public const int StatusCodeResultNotfound = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchResult']/field[@name='STATUS_CODE_SUCCEED']"
		[Register ("STATUS_CODE_SUCCEED")]
		public const int StatusCodeSucceed = (int) 0;

		static IntPtr size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchResult']/field[@name='size']"
		[Register ("size")]
		public int Size {
			get {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "I");
				return JNIEnv.GetIntField (Handle, size_jfieldId);
			}
			set {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "I");
				try {
					JNIEnv.SetField (Handle, size_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr status_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchResult']/field[@name='status']"
		[Register ("status")]
		public int Status {
			get {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "I");
				return JNIEnv.GetIntField (Handle, status_jfieldId);
			}
			set {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "I");
				try {
					JNIEnv.SetField (Handle, status_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr total_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchResult']/field[@name='total']"
		[Register ("total")]
		public int Total {
			get {
				if (total_jfieldId == IntPtr.Zero)
					total_jfieldId = JNIEnv.GetFieldID (class_ref, "total", "I");
				return JNIEnv.GetIntField (Handle, total_jfieldId);
			}
			set {
				if (total_jfieldId == IntPtr.Zero)
					total_jfieldId = JNIEnv.GetFieldID (class_ref, "total", "I");
				try {
					JNIEnv.SetField (Handle, total_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/cloud/BaseSearchResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseSearchResult); }
		}

		protected BaseSearchResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseSearchResult']/constructor[@name='BaseSearchResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseSearchResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaseSearchResult)) {
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

	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/BaseSearchResult", DoNotGenerateAcw=true)]
	internal partial class BaseSearchResultInvoker : BaseSearchResult {

		public BaseSearchResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseSearchResultInvoker); }
		}

	}

}
