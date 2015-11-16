using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseCloudSearchInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/BaseCloudSearchInfo", DoNotGenerateAcw=true)]
	public abstract partial class BaseCloudSearchInfo : global::Com.Baidu.Mapapi.Cloud.BaseSearchInfo {


		static IntPtr filter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseCloudSearchInfo']/field[@name='filter']"
		[Register ("filter")]
		public string Filter {
			get {
				if (filter_jfieldId == IntPtr.Zero)
					filter_jfieldId = JNIEnv.GetFieldID (class_ref, "filter", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, filter_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (filter_jfieldId == IntPtr.Zero)
					filter_jfieldId = JNIEnv.GetFieldID (class_ref, "filter", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, filter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr pageIndex_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseCloudSearchInfo']/field[@name='pageIndex']"
		[Register ("pageIndex")]
		public int PageIndex {
			get {
				if (pageIndex_jfieldId == IntPtr.Zero)
					pageIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "pageIndex", "I");
				return JNIEnv.GetIntField (Handle, pageIndex_jfieldId);
			}
			set {
				if (pageIndex_jfieldId == IntPtr.Zero)
					pageIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "pageIndex", "I");
				try {
					JNIEnv.SetField (Handle, pageIndex_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr pageSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseCloudSearchInfo']/field[@name='pageSize']"
		[Register ("pageSize")]
		public int PageSize {
			get {
				if (pageSize_jfieldId == IntPtr.Zero)
					pageSize_jfieldId = JNIEnv.GetFieldID (class_ref, "pageSize", "I");
				return JNIEnv.GetIntField (Handle, pageSize_jfieldId);
			}
			set {
				if (pageSize_jfieldId == IntPtr.Zero)
					pageSize_jfieldId = JNIEnv.GetFieldID (class_ref, "pageSize", "I");
				try {
					JNIEnv.SetField (Handle, pageSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr q_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseCloudSearchInfo']/field[@name='q']"
		[Register ("q")]
		public string Q {
			get {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetFieldID (class_ref, "q", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, q_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetFieldID (class_ref, "q", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, q_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sortby_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseCloudSearchInfo']/field[@name='sortby']"
		[Register ("sortby")]
		public string Sortby {
			get {
				if (sortby_jfieldId == IntPtr.Zero)
					sortby_jfieldId = JNIEnv.GetFieldID (class_ref, "sortby", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sortby_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sortby_jfieldId == IntPtr.Zero)
					sortby_jfieldId = JNIEnv.GetFieldID (class_ref, "sortby", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, sortby_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr tags_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseCloudSearchInfo']/field[@name='tags']"
		[Register ("tags")]
		public string Tags {
			get {
				if (tags_jfieldId == IntPtr.Zero)
					tags_jfieldId = JNIEnv.GetFieldID (class_ref, "tags", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, tags_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tags_jfieldId == IntPtr.Zero)
					tags_jfieldId = JNIEnv.GetFieldID (class_ref, "tags", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, tags_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/cloud/BaseCloudSearchInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseCloudSearchInfo); }
		}

		protected BaseCloudSearchInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='BaseCloudSearchInfo']/constructor[@name='BaseCloudSearchInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseCloudSearchInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaseCloudSearchInfo)) {
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

	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/BaseCloudSearchInfo", DoNotGenerateAcw=true)]
	internal partial class BaseCloudSearchInfoInvoker : BaseCloudSearchInfo {

		public BaseCloudSearchInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseCloudSearchInfoInvoker); }
		}

	}

}
