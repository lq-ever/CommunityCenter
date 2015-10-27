using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLng']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/model/LatLng", DoNotGenerateAcw=true)]
	public sealed partial class LatLng : global::Java.Lang.Object {


		static IntPtr latitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLng']/field[@name='latitude']"
		[Register ("latitude")]
		public double Latitude {
			get {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				return JNIEnv.GetDoubleField (Handle, latitude_jfieldId);
			}
			set {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				try {
					JNIEnv.SetField (Handle, latitude_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr longitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLng']/field[@name='longitude']"
		[Register ("longitude")]
		public double Longitude {
			get {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				return JNIEnv.GetDoubleField (Handle, longitude_jfieldId);
			}
			set {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				try {
					JNIEnv.SetField (Handle, longitude_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/model/LatLng", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LatLng); }
		}

		internal LatLng (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='LatLng']/constructor[@name='LatLng' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe LatLng (double p0, double p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (LatLng)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(DD)V", __args);
					return;
				}

				if (id_ctor_DD == IntPtr.Zero)
					id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_DD, __args);
			} finally {
			}
		}

	}
}
