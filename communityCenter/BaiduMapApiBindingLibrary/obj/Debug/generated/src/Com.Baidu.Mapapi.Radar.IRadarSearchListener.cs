using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Radar {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.radar']/interface[@name='RadarSearchListener']"
	[Register ("com/baidu/mapapi/radar/RadarSearchListener", "", "Com.Baidu.Mapapi.Radar.IRadarSearchListenerInvoker")]
	public partial interface IRadarSearchListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/interface[@name='RadarSearchListener']/method[@name='onGetClearInfoState' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.radar.RadarSearchError']]"
		[Register ("onGetClearInfoState", "(Lcom/baidu/mapapi/radar/RadarSearchError;)V", "GetOnGetClearInfoState_Lcom_baidu_mapapi_radar_RadarSearchError_Handler:Com.Baidu.Mapapi.Radar.IRadarSearchListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetClearInfoState (global::Com.Baidu.Mapapi.Radar.RadarSearchError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/interface[@name='RadarSearchListener']/method[@name='onGetNearbyInfoList' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.radar.RadarNearbyResult'] and parameter[2][@type='com.baidu.mapapi.radar.RadarSearchError']]"
		[Register ("onGetNearbyInfoList", "(Lcom/baidu/mapapi/radar/RadarNearbyResult;Lcom/baidu/mapapi/radar/RadarSearchError;)V", "GetOnGetNearbyInfoList_Lcom_baidu_mapapi_radar_RadarNearbyResult_Lcom_baidu_mapapi_radar_RadarSearchError_Handler:Com.Baidu.Mapapi.Radar.IRadarSearchListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetNearbyInfoList (global::Com.Baidu.Mapapi.Radar.RadarNearbyResult p0, global::Com.Baidu.Mapapi.Radar.RadarSearchError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/interface[@name='RadarSearchListener']/method[@name='onGetUploadState' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.radar.RadarSearchError']]"
		[Register ("onGetUploadState", "(Lcom/baidu/mapapi/radar/RadarSearchError;)V", "GetOnGetUploadState_Lcom_baidu_mapapi_radar_RadarSearchError_Handler:Com.Baidu.Mapapi.Radar.IRadarSearchListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetUploadState (global::Com.Baidu.Mapapi.Radar.RadarSearchError p0);

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/radar/RadarSearchListener", DoNotGenerateAcw=true)]
	internal class IRadarSearchListenerInvoker : global::Java.Lang.Object, IRadarSearchListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/radar/RadarSearchListener");
		IntPtr class_ref;

		public static IRadarSearchListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRadarSearchListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.radar.RadarSearchListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRadarSearchListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRadarSearchListenerInvoker); }
		}

		static Delegate cb_onGetClearInfoState_Lcom_baidu_mapapi_radar_RadarSearchError_;
#pragma warning disable 0169
		static Delegate GetOnGetClearInfoState_Lcom_baidu_mapapi_radar_RadarSearchError_Handler ()
		{
			if (cb_onGetClearInfoState_Lcom_baidu_mapapi_radar_RadarSearchError_ == null)
				cb_onGetClearInfoState_Lcom_baidu_mapapi_radar_RadarSearchError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetClearInfoState_Lcom_baidu_mapapi_radar_RadarSearchError_);
			return cb_onGetClearInfoState_Lcom_baidu_mapapi_radar_RadarSearchError_;
		}

		static void n_OnGetClearInfoState_Lcom_baidu_mapapi_radar_RadarSearchError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Radar.IRadarSearchListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.IRadarSearchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Radar.RadarSearchError p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetClearInfoState (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGetClearInfoState_Lcom_baidu_mapapi_radar_RadarSearchError_;
		public unsafe void OnGetClearInfoState (global::Com.Baidu.Mapapi.Radar.RadarSearchError p0)
		{
			if (id_onGetClearInfoState_Lcom_baidu_mapapi_radar_RadarSearchError_ == IntPtr.Zero)
				id_onGetClearInfoState_Lcom_baidu_mapapi_radar_RadarSearchError_ = JNIEnv.GetMethodID (class_ref, "onGetClearInfoState", "(Lcom/baidu/mapapi/radar/RadarSearchError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onGetClearInfoState_Lcom_baidu_mapapi_radar_RadarSearchError_, __args);
		}

		static Delegate cb_onGetNearbyInfoList_Lcom_baidu_mapapi_radar_RadarNearbyResult_Lcom_baidu_mapapi_radar_RadarSearchError_;
#pragma warning disable 0169
		static Delegate GetOnGetNearbyInfoList_Lcom_baidu_mapapi_radar_RadarNearbyResult_Lcom_baidu_mapapi_radar_RadarSearchError_Handler ()
		{
			if (cb_onGetNearbyInfoList_Lcom_baidu_mapapi_radar_RadarNearbyResult_Lcom_baidu_mapapi_radar_RadarSearchError_ == null)
				cb_onGetNearbyInfoList_Lcom_baidu_mapapi_radar_RadarNearbyResult_Lcom_baidu_mapapi_radar_RadarSearchError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnGetNearbyInfoList_Lcom_baidu_mapapi_radar_RadarNearbyResult_Lcom_baidu_mapapi_radar_RadarSearchError_);
			return cb_onGetNearbyInfoList_Lcom_baidu_mapapi_radar_RadarNearbyResult_Lcom_baidu_mapapi_radar_RadarSearchError_;
		}

		static void n_OnGetNearbyInfoList_Lcom_baidu_mapapi_radar_RadarNearbyResult_Lcom_baidu_mapapi_radar_RadarSearchError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Radar.IRadarSearchListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.IRadarSearchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Radar.RadarNearbyResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbyResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Radar.RadarSearchError p1 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnGetNearbyInfoList (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onGetNearbyInfoList_Lcom_baidu_mapapi_radar_RadarNearbyResult_Lcom_baidu_mapapi_radar_RadarSearchError_;
		public unsafe void OnGetNearbyInfoList (global::Com.Baidu.Mapapi.Radar.RadarNearbyResult p0, global::Com.Baidu.Mapapi.Radar.RadarSearchError p1)
		{
			if (id_onGetNearbyInfoList_Lcom_baidu_mapapi_radar_RadarNearbyResult_Lcom_baidu_mapapi_radar_RadarSearchError_ == IntPtr.Zero)
				id_onGetNearbyInfoList_Lcom_baidu_mapapi_radar_RadarNearbyResult_Lcom_baidu_mapapi_radar_RadarSearchError_ = JNIEnv.GetMethodID (class_ref, "onGetNearbyInfoList", "(Lcom/baidu/mapapi/radar/RadarNearbyResult;Lcom/baidu/mapapi/radar/RadarSearchError;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onGetNearbyInfoList_Lcom_baidu_mapapi_radar_RadarNearbyResult_Lcom_baidu_mapapi_radar_RadarSearchError_, __args);
		}

		static Delegate cb_onGetUploadState_Lcom_baidu_mapapi_radar_RadarSearchError_;
#pragma warning disable 0169
		static Delegate GetOnGetUploadState_Lcom_baidu_mapapi_radar_RadarSearchError_Handler ()
		{
			if (cb_onGetUploadState_Lcom_baidu_mapapi_radar_RadarSearchError_ == null)
				cb_onGetUploadState_Lcom_baidu_mapapi_radar_RadarSearchError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetUploadState_Lcom_baidu_mapapi_radar_RadarSearchError_);
			return cb_onGetUploadState_Lcom_baidu_mapapi_radar_RadarSearchError_;
		}

		static void n_OnGetUploadState_Lcom_baidu_mapapi_radar_RadarSearchError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Radar.IRadarSearchListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.IRadarSearchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Radar.RadarSearchError p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetUploadState (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGetUploadState_Lcom_baidu_mapapi_radar_RadarSearchError_;
		public unsafe void OnGetUploadState (global::Com.Baidu.Mapapi.Radar.RadarSearchError p0)
		{
			if (id_onGetUploadState_Lcom_baidu_mapapi_radar_RadarSearchError_ == IntPtr.Zero)
				id_onGetUploadState_Lcom_baidu_mapapi_radar_RadarSearchError_ = JNIEnv.GetMethodID (class_ref, "onGetUploadState", "(Lcom/baidu/mapapi/radar/RadarSearchError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onGetUploadState_Lcom_baidu_mapapi_radar_RadarSearchError_, __args);
		}

	}

	public partial class GetClearInfoStateEventArgs : global::System.EventArgs {

		public GetClearInfoStateEventArgs (global::Com.Baidu.Mapapi.Radar.RadarSearchError p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Mapapi.Radar.RadarSearchError p0;
		public global::Com.Baidu.Mapapi.Radar.RadarSearchError P0 {
			get { return p0; }
		}
	}

	public partial class GetNearbyInfoListEventArgs : global::System.EventArgs {

		public GetNearbyInfoListEventArgs (global::Com.Baidu.Mapapi.Radar.RadarNearbyResult p0, global::Com.Baidu.Mapapi.Radar.RadarSearchError p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Baidu.Mapapi.Radar.RadarNearbyResult p0;
		public global::Com.Baidu.Mapapi.Radar.RadarNearbyResult P0 {
			get { return p0; }
		}

		global::Com.Baidu.Mapapi.Radar.RadarSearchError p1;
		public global::Com.Baidu.Mapapi.Radar.RadarSearchError P1 {
			get { return p1; }
		}
	}

	public partial class GetUploadStateEventArgs : global::System.EventArgs {

		public GetUploadStateEventArgs (global::Com.Baidu.Mapapi.Radar.RadarSearchError p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Mapapi.Radar.RadarSearchError p0;
		public global::Com.Baidu.Mapapi.Radar.RadarSearchError P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/baidu/mapapi/radar/RadarSearchListenerImplementor")]
	internal sealed partial class IRadarSearchListenerImplementor : global::Java.Lang.Object, IRadarSearchListener {

		object sender;

		public IRadarSearchListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/radar/RadarSearchListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GetClearInfoStateEventArgs> OnGetClearInfoStateHandler;
#pragma warning restore 0649

		public void OnGetClearInfoState (global::Com.Baidu.Mapapi.Radar.RadarSearchError p0)
		{
			var __h = OnGetClearInfoStateHandler;
			if (__h != null)
				__h (sender, new GetClearInfoStateEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<GetNearbyInfoListEventArgs> OnGetNearbyInfoListHandler;
#pragma warning restore 0649

		public void OnGetNearbyInfoList (global::Com.Baidu.Mapapi.Radar.RadarNearbyResult p0, global::Com.Baidu.Mapapi.Radar.RadarSearchError p1)
		{
			var __h = OnGetNearbyInfoListHandler;
			if (__h != null)
				__h (sender, new GetNearbyInfoListEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<GetUploadStateEventArgs> OnGetUploadStateHandler;
#pragma warning restore 0649

		public void OnGetUploadState (global::Com.Baidu.Mapapi.Radar.RadarSearchError p0)
		{
			var __h = OnGetUploadStateHandler;
			if (__h != null)
				__h (sender, new GetUploadStateEventArgs (p0));
		}

		internal static bool __IsEmpty (IRadarSearchListenerImplementor value)
		{
			return value.OnGetClearInfoStateHandler == null && value.OnGetNearbyInfoListHandler == null && value.OnGetUploadStateHandler == null;
		}
	}

}
