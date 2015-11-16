using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Overlayutil {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='OverlayManager']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/overlayutil/OverlayManager", DoNotGenerateAcw=true)]
	public abstract partial class OverlayManager : global::Java.Lang.Object, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/overlayutil/OverlayManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OverlayManager); }
		}

		protected OverlayManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_baidu_mapapi_map_BaiduMap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='OverlayManager']/constructor[@name='OverlayManager' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap']]"
		[Register (".ctor", "(Lcom/baidu/mapapi/map/BaiduMap;)V", "")]
		public unsafe OverlayManager (global::Com.Baidu.Mapapi.Map.BaiduMap p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (OverlayManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/baidu/mapapi/map/BaiduMap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/baidu/mapapi/map/BaiduMap;)V", __args);
					return;
				}

				if (id_ctor_Lcom_baidu_mapapi_map_BaiduMap_ == IntPtr.Zero)
					id_ctor_Lcom_baidu_mapapi_map_BaiduMap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/baidu/mapapi/map/BaiduMap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_baidu_mapapi_map_BaiduMap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_baidu_mapapi_map_BaiduMap_, __args);
			} finally {
			}
		}

		static Delegate cb_getOverlayOptions;
#pragma warning disable 0169
		static Delegate GetGetOverlayOptionsHandler ()
		{
			if (cb_getOverlayOptions == null)
				cb_getOverlayOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOverlayOptions);
			return cb_getOverlayOptions;
		}

		static IntPtr n_GetOverlayOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Overlayutil.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Overlayutil.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.OverlayOptions>.ToLocalJniHandle (__this.OverlayOptions);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.OverlayOptions> OverlayOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='OverlayManager']/method[@name='getOverlayOptions' and count(parameter)=0]"
			[Register ("getOverlayOptions", "()Ljava/util/List;", "GetGetOverlayOptionsHandler")] get;
		}

		static IntPtr id_addToMap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='OverlayManager']/method[@name='addToMap' and count(parameter)=0]"
		[Register ("addToMap", "()V", "")]
		public unsafe void AddToMap ()
		{
			if (id_addToMap == IntPtr.Zero)
				id_addToMap = JNIEnv.GetMethodID (class_ref, "addToMap", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_addToMap);
			} finally {
			}
		}

		static IntPtr id_removeFromMap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='OverlayManager']/method[@name='removeFromMap' and count(parameter)=0]"
		[Register ("removeFromMap", "()V", "")]
		public unsafe void RemoveFromMap ()
		{
			if (id_removeFromMap == IntPtr.Zero)
				id_removeFromMap = JNIEnv.GetMethodID (class_ref, "removeFromMap", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_removeFromMap);
			} finally {
			}
		}

		static Delegate cb_zoomToSpan;
#pragma warning disable 0169
		static Delegate GetZoomToSpanHandler ()
		{
			if (cb_zoomToSpan == null)
				cb_zoomToSpan = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomToSpan);
			return cb_zoomToSpan;
		}

		static void n_ZoomToSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Overlayutil.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Overlayutil.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToSpan ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomToSpan;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='OverlayManager']/method[@name='zoomToSpan' and count(parameter)=0]"
		[Register ("zoomToSpan", "()V", "GetZoomToSpanHandler")]
		public virtual unsafe void ZoomToSpan ()
		{
			if (id_zoomToSpan == IntPtr.Zero)
				id_zoomToSpan = JNIEnv.GetMethodID (class_ref, "zoomToSpan", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_zoomToSpan);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomToSpan", "()V"));
			} finally {
			}
		}

		static Delegate cb_onMarkerClick_Lcom_baidu_mapapi_map_Marker_;
#pragma warning disable 0169
		static Delegate GetOnMarkerClick_Lcom_baidu_mapapi_map_Marker_Handler ()
		{
			if (cb_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ == null)
				cb_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMarkerClick_Lcom_baidu_mapapi_map_Marker_);
			return cb_onMarkerClick_Lcom_baidu_mapapi_map_Marker_;
		}

		static bool n_OnMarkerClick_Lcom_baidu_mapapi_map_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Overlayutil.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Overlayutil.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnMarkerClick (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='OverlayManager']/method[@name='onMarkerClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Marker']]"
		[Register ("onMarkerClick", "(Lcom/baidu/mapapi/map/Marker;)Z", "GetOnMarkerClick_Lcom_baidu_mapapi_map_Marker_Handler")]
		public abstract bool OnMarkerClick (global::Com.Baidu.Mapapi.Map.Marker p0);

		static Delegate cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_;
#pragma warning disable 0169
		static Delegate GetOnPolylineClick_Lcom_baidu_mapapi_map_Polyline_Handler ()
		{
			if (cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ == null)
				cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnPolylineClick_Lcom_baidu_mapapi_map_Polyline_);
			return cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_;
		}

		static bool n_OnPolylineClick_Lcom_baidu_mapapi_map_Polyline_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Overlayutil.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Overlayutil.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.Polyline p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Polyline> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPolylineClick (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='OverlayManager']/method[@name='onPolylineClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Polyline']]"
		[Register ("onPolylineClick", "(Lcom/baidu/mapapi/map/Polyline;)Z", "GetOnPolylineClick_Lcom_baidu_mapapi_map_Polyline_Handler")]
		public abstract bool OnPolylineClick (global::Com.Baidu.Mapapi.Map.Polyline p0);

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/overlayutil/OverlayManager", DoNotGenerateAcw=true)]
	internal partial class OverlayManagerInvoker : OverlayManager {

		public OverlayManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (OverlayManagerInvoker); }
		}

		static IntPtr id_getOverlayOptions;
		public override unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.OverlayOptions> OverlayOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='OverlayManager']/method[@name='getOverlayOptions' and count(parameter)=0]"
			[Register ("getOverlayOptions", "()Ljava/util/List;", "GetGetOverlayOptionsHandler")]
			get {
				if (id_getOverlayOptions == IntPtr.Zero)
					id_getOverlayOptions = JNIEnv.GetMethodID (class_ref, "getOverlayOptions", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.OverlayOptions>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getOverlayOptions), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='OverlayManager']/method[@name='onMarkerClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Marker']]"
		[Register ("onMarkerClick", "(Lcom/baidu/mapapi/map/Marker;)Z", "GetOnMarkerClick_Lcom_baidu_mapapi_map_Marker_Handler")]
		public override unsafe bool OnMarkerClick (global::Com.Baidu.Mapapi.Map.Marker p0)
		{
			if (id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ == IntPtr.Zero)
				id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerClick", "(Lcom/baidu/mapapi/map/Marker;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='OverlayManager']/method[@name='onPolylineClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Polyline']]"
		[Register ("onPolylineClick", "(Lcom/baidu/mapapi/map/Polyline;)Z", "GetOnPolylineClick_Lcom_baidu_mapapi_map_Polyline_Handler")]
		public override unsafe bool OnPolylineClick (global::Com.Baidu.Mapapi.Map.Polyline p0)
		{
			if (id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ == IntPtr.Zero)
				id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ = JNIEnv.GetMethodID (class_ref, "onPolylineClick", "(Lcom/baidu/mapapi/map/Polyline;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_, __args);
				return __ret;
			} finally {
			}
		}

	}

}
