using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptor']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/BitmapDescriptor", DoNotGenerateAcw=true)]
	public sealed partial class BitmapDescriptor : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/BitmapDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapDescriptor); }
		}

		internal BitmapDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptor']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "")]
		public unsafe void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_recycle);
			} finally {
			}
		}

	}
}
