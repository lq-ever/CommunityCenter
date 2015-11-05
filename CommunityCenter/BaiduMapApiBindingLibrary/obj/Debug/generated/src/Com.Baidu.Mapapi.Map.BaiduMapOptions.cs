using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMapOptions", DoNotGenerateAcw=true)]
	public sealed partial class BaiduMapOptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/map/BaiduMapOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaiduMapOptions); }
		}

		internal BaiduMapOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/constructor[@name='BaiduMapOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaiduMapOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaiduMapOptions)) {
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

		static IntPtr id_compassEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='compassEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("compassEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions CompassEnabled (bool p0)
		{
			if (id_compassEnabled_Z == IntPtr.Zero)
				id_compassEnabled_Z = JNIEnv.GetMethodID (class_ref, "compassEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_compassEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_mapStatus_Lcom_baidu_mapapi_map_MapStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='mapStatus' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
		[Register ("mapStatus", "(Lcom/baidu/mapapi/map/MapStatus;)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions MapStatus (global::Com.Baidu.Mapapi.Map.MapStatus p0)
		{
			if (id_mapStatus_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
				id_mapStatus_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "mapStatus", "(Lcom/baidu/mapapi/map/MapStatus;)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Map.BaiduMapOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_mapStatus_Lcom_baidu_mapapi_map_MapStatus_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mapType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='mapType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("mapType", "(I)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions MapType (int p0)
		{
			if (id_mapType_I == IntPtr.Zero)
				id_mapType_I = JNIEnv.GetMethodID (class_ref, "mapType", "(I)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_mapType_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_overlookingGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='overlookingGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("overlookingGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions OverlookingGesturesEnabled (bool p0)
		{
			if (id_overlookingGesturesEnabled_Z == IntPtr.Zero)
				id_overlookingGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "overlookingGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_overlookingGesturesEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_rotateGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='rotateGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("rotateGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions RotateGesturesEnabled (bool p0)
		{
			if (id_rotateGesturesEnabled_Z == IntPtr.Zero)
				id_rotateGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "rotateGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_rotateGesturesEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_scaleControlEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='scaleControlEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("scaleControlEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ScaleControlEnabled (bool p0)
		{
			if (id_scaleControlEnabled_Z == IntPtr.Zero)
				id_scaleControlEnabled_Z = JNIEnv.GetMethodID (class_ref, "scaleControlEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_scaleControlEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_scrollGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='scrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("scrollGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ScrollGesturesEnabled (bool p0)
		{
			if (id_scrollGesturesEnabled_Z == IntPtr.Zero)
				id_scrollGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "scrollGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_scrollGesturesEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zoomControlsEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='zoomControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("zoomControlsEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ZoomControlsEnabled (bool p0)
		{
			if (id_zoomControlsEnabled_Z == IntPtr.Zero)
				id_zoomControlsEnabled_Z = JNIEnv.GetMethodID (class_ref, "zoomControlsEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_zoomControlsEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zoomGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='zoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("zoomGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ZoomGesturesEnabled (bool p0)
		{
			if (id_zoomGesturesEnabled_Z == IntPtr.Zero)
				id_zoomGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "zoomGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (JNIEnv.CallObjectMethod  (Handle, id_zoomGesturesEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
