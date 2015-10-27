using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='CityInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/core/CityInfo", DoNotGenerateAcw=true)]
	public partial class CityInfo : global::Java.Lang.Object {


		static IntPtr city_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='CityInfo']/field[@name='city']"
		[Register ("city")]
		public string City {
			get {
				if (city_jfieldId == IntPtr.Zero)
					city_jfieldId = JNIEnv.GetFieldID (class_ref, "city", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, city_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (city_jfieldId == IntPtr.Zero)
					city_jfieldId = JNIEnv.GetFieldID (class_ref, "city", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, city_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr num_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='CityInfo']/field[@name='num']"
		[Register ("num")]
		public int Num {
			get {
				if (num_jfieldId == IntPtr.Zero)
					num_jfieldId = JNIEnv.GetFieldID (class_ref, "num", "I");
				return JNIEnv.GetIntField (Handle, num_jfieldId);
			}
			set {
				if (num_jfieldId == IntPtr.Zero)
					num_jfieldId = JNIEnv.GetFieldID (class_ref, "num", "I");
				try {
					JNIEnv.SetField (Handle, num_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/core/CityInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CityInfo); }
		}

		protected CityInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='CityInfo']/constructor[@name='CityInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CityInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CityInfo)) {
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
