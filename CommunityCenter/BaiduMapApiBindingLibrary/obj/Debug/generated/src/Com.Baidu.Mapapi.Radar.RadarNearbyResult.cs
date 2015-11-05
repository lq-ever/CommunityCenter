using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Radar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyResult']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/radar/RadarNearbyResult", DoNotGenerateAcw=true)]
	public partial class RadarNearbyResult : global::Java.Lang.Object {


		static IntPtr infoList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyResult']/field[@name='infoList']"
		[Register ("infoList")]
		public global::System.Collections.IList InfoList {
			get {
				if (infoList_jfieldId == IntPtr.Zero)
					infoList_jfieldId = JNIEnv.GetFieldID (class_ref, "infoList", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, infoList_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (infoList_jfieldId == IntPtr.Zero)
					infoList_jfieldId = JNIEnv.GetFieldID (class_ref, "infoList", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, infoList_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr pageIndex_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyResult']/field[@name='pageIndex']"
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

		static IntPtr pageNum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyResult']/field[@name='pageNum']"
		[Register ("pageNum")]
		public int PageNum {
			get {
				if (pageNum_jfieldId == IntPtr.Zero)
					pageNum_jfieldId = JNIEnv.GetFieldID (class_ref, "pageNum", "I");
				return JNIEnv.GetIntField (Handle, pageNum_jfieldId);
			}
			set {
				if (pageNum_jfieldId == IntPtr.Zero)
					pageNum_jfieldId = JNIEnv.GetFieldID (class_ref, "pageNum", "I");
				try {
					JNIEnv.SetField (Handle, pageNum_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr totalNum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyResult']/field[@name='totalNum']"
		[Register ("totalNum")]
		public int TotalNum {
			get {
				if (totalNum_jfieldId == IntPtr.Zero)
					totalNum_jfieldId = JNIEnv.GetFieldID (class_ref, "totalNum", "I");
				return JNIEnv.GetIntField (Handle, totalNum_jfieldId);
			}
			set {
				if (totalNum_jfieldId == IntPtr.Zero)
					totalNum_jfieldId = JNIEnv.GetFieldID (class_ref, "totalNum", "I");
				try {
					JNIEnv.SetField (Handle, totalNum_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/radar/RadarNearbyResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RadarNearbyResult); }
		}

		protected RadarNearbyResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyResult']/constructor[@name='RadarNearbyResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RadarNearbyResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RadarNearbyResult)) {
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
