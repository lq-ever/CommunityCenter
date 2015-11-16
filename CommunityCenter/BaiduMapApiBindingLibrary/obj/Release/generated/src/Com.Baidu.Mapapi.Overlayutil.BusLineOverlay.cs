using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Overlayutil {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='BusLineOverlay']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/overlayutil/BusLineOverlay", DoNotGenerateAcw=true)]
	public partial class BusLineOverlay : global::Com.Baidu.Mapapi.Overlayutil.OverlayManager {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/overlayutil/BusLineOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BusLineOverlay); }
		}

		protected BusLineOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_baidu_mapapi_map_BaiduMap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='BusLineOverlay']/constructor[@name='BusLineOverlay' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap']]"
		[Register (".ctor", "(Lcom/baidu/mapapi/map/BaiduMap;)V", "")]
		public unsafe BusLineOverlay (global::Com.Baidu.Mapapi.Map.BaiduMap p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BusLineOverlay)) {
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

		static IntPtr id_getOverlayOptions;
		public override unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.OverlayOptions> OverlayOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='BusLineOverlay']/method[@name='getOverlayOptions' and count(parameter)=0]"
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

		static Delegate cb_onBusStationClick_I;
#pragma warning disable 0169
		static Delegate GetOnBusStationClick_IHandler ()
		{
			if (cb_onBusStationClick_I == null)
				cb_onBusStationClick_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_OnBusStationClick_I);
			return cb_onBusStationClick_I;
		}

		static bool n_OnBusStationClick_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Overlayutil.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Overlayutil.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnBusStationClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onBusStationClick_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='BusLineOverlay']/method[@name='onBusStationClick' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onBusStationClick", "(I)Z", "GetOnBusStationClick_IHandler")]
		public virtual unsafe bool OnBusStationClick (int p0)
		{
			if (id_onBusStationClick_I == IntPtr.Zero)
				id_onBusStationClick_I = JNIEnv.GetMethodID (class_ref, "onBusStationClick", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_onBusStationClick_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBusStationClick", "(I)Z"), __args);
			} finally {
			}
		}

		static IntPtr id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='BusLineOverlay']/method[@name='onMarkerClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Marker']]"
		[Register ("onMarkerClick", "(Lcom/baidu/mapapi/map/Marker;)Z", "")]
		public override sealed unsafe bool OnMarkerClick (global::Com.Baidu.Mapapi.Map.Marker p0)
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
			global::Com.Baidu.Mapapi.Overlayutil.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Overlayutil.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.Polyline p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Polyline> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPolylineClick (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='BusLineOverlay']/method[@name='onPolylineClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Polyline']]"
		[Register ("onPolylineClick", "(Lcom/baidu/mapapi/map/Polyline;)Z", "GetOnPolylineClick_Lcom_baidu_mapapi_map_Polyline_Handler")]
		public override unsafe bool OnPolylineClick (global::Com.Baidu.Mapapi.Map.Polyline p0)
		{
			if (id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ == IntPtr.Zero)
				id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ = JNIEnv.GetMethodID (class_ref, "onPolylineClick", "(Lcom/baidu/mapapi/map/Polyline;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPolylineClick", "(Lcom/baidu/mapapi/map/Polyline;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setData_Lcom_baidu_mapapi_search_busline_BusLineResult_;
#pragma warning disable 0169
		static Delegate GetSetData_Lcom_baidu_mapapi_search_busline_BusLineResult_Handler ()
		{
			if (cb_setData_Lcom_baidu_mapapi_search_busline_BusLineResult_ == null)
				cb_setData_Lcom_baidu_mapapi_search_busline_BusLineResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lcom_baidu_mapapi_search_busline_BusLineResult_);
			return cb_setData_Lcom_baidu_mapapi_search_busline_BusLineResult_;
		}

		static void n_SetData_Lcom_baidu_mapapi_search_busline_BusLineResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Overlayutil.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Overlayutil.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Busline.BusLineResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setData_Lcom_baidu_mapapi_search_busline_BusLineResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.overlayutil']/class[@name='BusLineOverlay']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.busline.BusLineResult']]"
		[Register ("setData", "(Lcom/baidu/mapapi/search/busline/BusLineResult;)V", "GetSetData_Lcom_baidu_mapapi_search_busline_BusLineResult_Handler")]
		public virtual unsafe void SetData (global::Com.Baidu.Mapapi.Search.Busline.BusLineResult p0)
		{
			if (id_setData_Lcom_baidu_mapapi_search_busline_BusLineResult_ == IntPtr.Zero)
				id_setData_Lcom_baidu_mapapi_search_busline_BusLineResult_ = JNIEnv.GetMethodID (class_ref, "setData", "(Lcom/baidu/mapapi/search/busline/BusLineResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setData_Lcom_baidu_mapapi_search_busline_BusLineResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Lcom/baidu/mapapi/search/busline/BusLineResult;)V"), __args);
			} finally {
			}
		}

	}
}
