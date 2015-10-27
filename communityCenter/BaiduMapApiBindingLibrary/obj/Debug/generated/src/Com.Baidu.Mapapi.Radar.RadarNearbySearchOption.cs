using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Radar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchOption']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/radar/RadarNearbySearchOption", DoNotGenerateAcw=true)]
	public partial class RadarNearbySearchOption : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/radar/RadarNearbySearchOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RadarNearbySearchOption); }
		}

		protected RadarNearbySearchOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchOption']/constructor[@name='RadarNearbySearchOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RadarNearbySearchOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RadarNearbySearchOption)) {
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

		static Delegate cb_centerPt_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetCenterPt_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_centerPt_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_centerPt_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CenterPt_Lcom_baidu_mapapi_model_LatLng_);
			return cb_centerPt_Lcom_baidu_mapapi_model_LatLng_;
		}

		static IntPtr n_CenterPt_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CenterPt (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_centerPt_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchOption']/method[@name='centerPt' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("centerPt", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;", "GetCenterPt_Lcom_baidu_mapapi_model_LatLng_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption CenterPt (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_centerPt_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_centerPt_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "centerPt", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (JNIEnv.CallObjectMethod  (Handle, id_centerPt_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "centerPt", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_pageCapacity_I;
#pragma warning disable 0169
		static Delegate GetPageCapacity_IHandler ()
		{
			if (cb_pageCapacity_I == null)
				cb_pageCapacity_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PageCapacity_I);
			return cb_pageCapacity_I;
		}

		static IntPtr n_PageCapacity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PageCapacity (p0));
		}
#pragma warning restore 0169

		static IntPtr id_pageCapacity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchOption']/method[@name='pageCapacity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pageCapacity", "(I)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;", "GetPageCapacity_IHandler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption PageCapacity (int p0)
		{
			if (id_pageCapacity_I == IntPtr.Zero)
				id_pageCapacity_I = JNIEnv.GetMethodID (class_ref, "pageCapacity", "(I)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (JNIEnv.CallObjectMethod  (Handle, id_pageCapacity_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pageCapacity", "(I)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pageNum_I;
#pragma warning disable 0169
		static Delegate GetPageNum_IHandler ()
		{
			if (cb_pageNum_I == null)
				cb_pageNum_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PageNum_I);
			return cb_pageNum_I;
		}

		static IntPtr n_PageNum_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PageNum (p0));
		}
#pragma warning restore 0169

		static IntPtr id_pageNum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchOption']/method[@name='pageNum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pageNum", "(I)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;", "GetPageNum_IHandler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption PageNum (int p0)
		{
			if (id_pageNum_I == IntPtr.Zero)
				id_pageNum_I = JNIEnv.GetMethodID (class_ref, "pageNum", "(I)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (JNIEnv.CallObjectMethod  (Handle, id_pageNum_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pageNum", "(I)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_radius_I;
#pragma warning disable 0169
		static Delegate GetRadius_IHandler ()
		{
			if (cb_radius_I == null)
				cb_radius_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Radius_I);
			return cb_radius_I;
		}

		static IntPtr n_Radius_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Radius (p0));
		}
#pragma warning restore 0169

		static IntPtr id_radius_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchOption']/method[@name='radius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("radius", "(I)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;", "GetRadius_IHandler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption Radius (int p0)
		{
			if (id_radius_I == IntPtr.Zero)
				id_radius_I = JNIEnv.GetMethodID (class_ref, "radius", "(I)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (JNIEnv.CallObjectMethod  (Handle, id_radius_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "radius", "(I)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sortType_Lcom_baidu_mapapi_radar_RadarNearbySearchSortType_;
#pragma warning disable 0169
		static Delegate GetSortType_Lcom_baidu_mapapi_radar_RadarNearbySearchSortType_Handler ()
		{
			if (cb_sortType_Lcom_baidu_mapapi_radar_RadarNearbySearchSortType_ == null)
				cb_sortType_Lcom_baidu_mapapi_radar_RadarNearbySearchSortType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SortType_Lcom_baidu_mapapi_radar_RadarNearbySearchSortType_);
			return cb_sortType_Lcom_baidu_mapapi_radar_RadarNearbySearchSortType_;
		}

		static IntPtr n_SortType_Lcom_baidu_mapapi_radar_RadarNearbySearchSortType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SortType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sortType_Lcom_baidu_mapapi_radar_RadarNearbySearchSortType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchOption']/method[@name='sortType' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.radar.RadarNearbySearchSortType']]"
		[Register ("sortType", "(Lcom/baidu/mapapi/radar/RadarNearbySearchSortType;)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;", "GetSortType_Lcom_baidu_mapapi_radar_RadarNearbySearchSortType_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption SortType (global::Com.Baidu.Mapapi.Radar.RadarNearbySearchSortType p0)
		{
			if (id_sortType_Lcom_baidu_mapapi_radar_RadarNearbySearchSortType_ == IntPtr.Zero)
				id_sortType_Lcom_baidu_mapapi_radar_RadarNearbySearchSortType_ = JNIEnv.GetMethodID (class_ref, "sortType", "(Lcom/baidu/mapapi/radar/RadarNearbySearchSortType;)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (JNIEnv.CallObjectMethod  (Handle, id_sortType_Lcom_baidu_mapapi_radar_RadarNearbySearchSortType_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sortType", "(Lcom/baidu/mapapi/radar/RadarNearbySearchSortType;)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_timeRange_Ljava_util_Date_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetTimeRange_Ljava_util_Date_Ljava_util_Date_Handler ()
		{
			if (cb_timeRange_Ljava_util_Date_Ljava_util_Date_ == null)
				cb_timeRange_Ljava_util_Date_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_TimeRange_Ljava_util_Date_Ljava_util_Date_);
			return cb_timeRange_Ljava_util_Date_Ljava_util_Date_;
		}

		static IntPtr n_TimeRange_Ljava_util_Date_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TimeRange (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_timeRange_Ljava_util_Date_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbySearchOption']/method[@name='timeRange' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.util.Date']]"
		[Register ("timeRange", "(Ljava/util/Date;Ljava/util/Date;)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;", "GetTimeRange_Ljava_util_Date_Ljava_util_Date_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption TimeRange (global::Java.Util.Date p0, global::Java.Util.Date p1)
		{
			if (id_timeRange_Ljava_util_Date_Ljava_util_Date_ == IntPtr.Zero)
				id_timeRange_Ljava_util_Date_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "timeRange", "(Ljava/util/Date;Ljava/util/Date;)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (JNIEnv.CallObjectMethod  (Handle, id_timeRange_Ljava_util_Date_Ljava_util_Date_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "timeRange", "(Ljava/util/Date;Ljava/util/Date;)Lcom/baidu/mapapi/radar/RadarNearbySearchOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
