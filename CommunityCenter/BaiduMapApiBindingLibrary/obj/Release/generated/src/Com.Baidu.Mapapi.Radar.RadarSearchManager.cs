using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Radar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/radar/RadarSearchManager", DoNotGenerateAcw=true)]
	public partial class RadarSearchManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/radar/RadarSearchManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RadarSearchManager); }
		}

		protected RadarSearchManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Baidu.Mapapi.Radar.RadarSearchManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/baidu/mapapi/radar/RadarSearchManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/baidu/mapapi/radar/RadarSearchManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_;
#pragma warning disable 0169
		static Delegate GetAddNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_Handler ()
		{
			if (cb_addNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_ == null)
				cb_addNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_);
			return cb_addNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_;
		}

		static void n_AddNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Radar.RadarSearchManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Radar.IRadarSearchListener p0 = (global::Com.Baidu.Mapapi.Radar.IRadarSearchListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.IRadarSearchListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddNearbyInfoListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']/method[@name='addNearbyInfoListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.radar.RadarSearchListener']]"
		[Register ("addNearbyInfoListener", "(Lcom/baidu/mapapi/radar/RadarSearchListener;)V", "GetAddNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_Handler")]
		public virtual unsafe void AddNearbyInfoListener (global::Com.Baidu.Mapapi.Radar.IRadarSearchListener p0)
		{
			if (id_addNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_ == IntPtr.Zero)
				id_addNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_ = JNIEnv.GetMethodID (class_ref, "addNearbyInfoListener", "(Lcom/baidu/mapapi/radar/RadarSearchListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addNearbyInfoListener", "(Lcom/baidu/mapapi/radar/RadarSearchListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_clearUserInfo;
#pragma warning disable 0169
		static Delegate GetClearUserInfoHandler ()
		{
			if (cb_clearUserInfo == null)
				cb_clearUserInfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearUserInfo);
			return cb_clearUserInfo;
		}

		static void n_ClearUserInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Radar.RadarSearchManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearUserInfo ();
		}
#pragma warning restore 0169

		static IntPtr id_clearUserInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']/method[@name='clearUserInfo' and count(parameter)=0]"
		[Register ("clearUserInfo", "()V", "GetClearUserInfoHandler")]
		public virtual unsafe void ClearUserInfo ()
		{
			if (id_clearUserInfo == IntPtr.Zero)
				id_clearUserInfo = JNIEnv.GetMethodID (class_ref, "clearUserInfo", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearUserInfo);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearUserInfo", "()V"));
			} finally {
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Radar.RadarSearchManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_nearbyInfoRequest_Lcom_baidu_mapapi_radar_RadarNearbySearchOption_;
#pragma warning disable 0169
		static Delegate GetNearbyInfoRequest_Lcom_baidu_mapapi_radar_RadarNearbySearchOption_Handler ()
		{
			if (cb_nearbyInfoRequest_Lcom_baidu_mapapi_radar_RadarNearbySearchOption_ == null)
				cb_nearbyInfoRequest_Lcom_baidu_mapapi_radar_RadarNearbySearchOption_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_NearbyInfoRequest_Lcom_baidu_mapapi_radar_RadarNearbySearchOption_);
			return cb_nearbyInfoRequest_Lcom_baidu_mapapi_radar_RadarNearbySearchOption_;
		}

		static bool n_NearbyInfoRequest_Lcom_baidu_mapapi_radar_RadarNearbySearchOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Radar.RadarSearchManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.NearbyInfoRequest (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_nearbyInfoRequest_Lcom_baidu_mapapi_radar_RadarNearbySearchOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']/method[@name='nearbyInfoRequest' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.radar.RadarNearbySearchOption']]"
		[Register ("nearbyInfoRequest", "(Lcom/baidu/mapapi/radar/RadarNearbySearchOption;)Z", "GetNearbyInfoRequest_Lcom_baidu_mapapi_radar_RadarNearbySearchOption_Handler")]
		public virtual unsafe bool NearbyInfoRequest (global::Com.Baidu.Mapapi.Radar.RadarNearbySearchOption p0)
		{
			if (id_nearbyInfoRequest_Lcom_baidu_mapapi_radar_RadarNearbySearchOption_ == IntPtr.Zero)
				id_nearbyInfoRequest_Lcom_baidu_mapapi_radar_RadarNearbySearchOption_ = JNIEnv.GetMethodID (class_ref, "nearbyInfoRequest", "(Lcom/baidu/mapapi/radar/RadarNearbySearchOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_nearbyInfoRequest_Lcom_baidu_mapapi_radar_RadarNearbySearchOption_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nearbyInfoRequest", "(Lcom/baidu/mapapi/radar/RadarNearbySearchOption;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onGetClearInfoResult_I;
#pragma warning disable 0169
		static Delegate GetOnGetClearInfoResult_IHandler ()
		{
			if (cb_onGetClearInfoResult_I == null)
				cb_onGetClearInfoResult_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnGetClearInfoResult_I);
			return cb_onGetClearInfoResult_I;
		}

		static void n_OnGetClearInfoResult_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Radar.RadarSearchManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnGetClearInfoResult (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onGetClearInfoResult_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']/method[@name='onGetClearInfoResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onGetClearInfoResult", "(I)V", "GetOnGetClearInfoResult_IHandler")]
		public virtual unsafe void OnGetClearInfoResult (int p0)
		{
			if (id_onGetClearInfoResult_I == IntPtr.Zero)
				id_onGetClearInfoResult_I = JNIEnv.GetMethodID (class_ref, "onGetClearInfoResult", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onGetClearInfoResult_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onGetClearInfoResult", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onGetNearByResult_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnGetNearByResult_Ljava_lang_String_IHandler ()
		{
			if (cb_onGetNearByResult_Ljava_lang_String_I == null)
				cb_onGetNearByResult_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnGetNearByResult_Ljava_lang_String_I);
			return cb_onGetNearByResult_Ljava_lang_String_I;
		}

		static void n_OnGetNearByResult_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Baidu.Mapapi.Radar.RadarSearchManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetNearByResult (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onGetNearByResult_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']/method[@name='onGetNearByResult' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onGetNearByResult", "(Ljava/lang/String;I)V", "GetOnGetNearByResult_Ljava_lang_String_IHandler")]
		public virtual unsafe void OnGetNearByResult (string p0, int p1)
		{
			if (id_onGetNearByResult_Ljava_lang_String_I == IntPtr.Zero)
				id_onGetNearByResult_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onGetNearByResult", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onGetNearByResult_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onGetNearByResult", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onGetUploadResult_I;
#pragma warning disable 0169
		static Delegate GetOnGetUploadResult_IHandler ()
		{
			if (cb_onGetUploadResult_I == null)
				cb_onGetUploadResult_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnGetUploadResult_I);
			return cb_onGetUploadResult_I;
		}

		static void n_OnGetUploadResult_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Radar.RadarSearchManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnGetUploadResult (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onGetUploadResult_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']/method[@name='onGetUploadResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onGetUploadResult", "(I)V", "GetOnGetUploadResult_IHandler")]
		public virtual unsafe void OnGetUploadResult (int p0)
		{
			if (id_onGetUploadResult_I == IntPtr.Zero)
				id_onGetUploadResult_I = JNIEnv.GetMethodID (class_ref, "onGetUploadResult", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onGetUploadResult_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onGetUploadResult", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_;
#pragma warning disable 0169
		static Delegate GetRemoveNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_Handler ()
		{
			if (cb_removeNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_ == null)
				cb_removeNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_);
			return cb_removeNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_;
		}

		static void n_RemoveNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Radar.RadarSearchManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Radar.IRadarSearchListener p0 = (global::Com.Baidu.Mapapi.Radar.IRadarSearchListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.IRadarSearchListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveNearbyInfoListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']/method[@name='removeNearbyInfoListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.radar.RadarSearchListener']]"
		[Register ("removeNearbyInfoListener", "(Lcom/baidu/mapapi/radar/RadarSearchListener;)V", "GetRemoveNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_Handler")]
		public virtual unsafe void RemoveNearbyInfoListener (global::Com.Baidu.Mapapi.Radar.IRadarSearchListener p0)
		{
			if (id_removeNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_ == IntPtr.Zero)
				id_removeNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_ = JNIEnv.GetMethodID (class_ref, "removeNearbyInfoListener", "(Lcom/baidu/mapapi/radar/RadarSearchListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeNearbyInfoListener_Lcom_baidu_mapapi_radar_RadarSearchListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeNearbyInfoListener", "(Lcom/baidu/mapapi/radar/RadarSearchListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUserID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserID_Ljava_lang_String_Handler ()
		{
			if (cb_setUserID_Ljava_lang_String_ == null)
				cb_setUserID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserID_Ljava_lang_String_);
			return cb_setUserID_Ljava_lang_String_;
		}

		static void n_SetUserID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Radar.RadarSearchManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUserID (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUserID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']/method[@name='setUserID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUserID", "(Ljava/lang/String;)V", "GetSetUserID_Ljava_lang_String_Handler")]
		public virtual unsafe void SetUserID (string p0)
		{
			if (id_setUserID_Ljava_lang_String_ == IntPtr.Zero)
				id_setUserID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserID", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserID_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserID", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_startUploadAuto_Lcom_baidu_mapapi_radar_RadarUploadInfoCallback_I;
#pragma warning disable 0169
		static Delegate GetStartUploadAuto_Lcom_baidu_mapapi_radar_RadarUploadInfoCallback_IHandler ()
		{
			if (cb_startUploadAuto_Lcom_baidu_mapapi_radar_RadarUploadInfoCallback_I == null)
				cb_startUploadAuto_Lcom_baidu_mapapi_radar_RadarUploadInfoCallback_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_StartUploadAuto_Lcom_baidu_mapapi_radar_RadarUploadInfoCallback_I);
			return cb_startUploadAuto_Lcom_baidu_mapapi_radar_RadarUploadInfoCallback_I;
		}

		static void n_StartUploadAuto_Lcom_baidu_mapapi_radar_RadarUploadInfoCallback_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Baidu.Mapapi.Radar.RadarSearchManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Radar.IRadarUploadInfoCallback p0 = (global::Com.Baidu.Mapapi.Radar.IRadarUploadInfoCallback)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.IRadarUploadInfoCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartUploadAuto (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startUploadAuto_Lcom_baidu_mapapi_radar_RadarUploadInfoCallback_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']/method[@name='startUploadAuto' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.radar.RadarUploadInfoCallback'] and parameter[2][@type='int']]"
		[Register ("startUploadAuto", "(Lcom/baidu/mapapi/radar/RadarUploadInfoCallback;I)V", "GetStartUploadAuto_Lcom_baidu_mapapi_radar_RadarUploadInfoCallback_IHandler")]
		public virtual unsafe void StartUploadAuto (global::Com.Baidu.Mapapi.Radar.IRadarUploadInfoCallback p0, int p1)
		{
			if (id_startUploadAuto_Lcom_baidu_mapapi_radar_RadarUploadInfoCallback_I == IntPtr.Zero)
				id_startUploadAuto_Lcom_baidu_mapapi_radar_RadarUploadInfoCallback_I = JNIEnv.GetMethodID (class_ref, "startUploadAuto", "(Lcom/baidu/mapapi/radar/RadarUploadInfoCallback;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startUploadAuto_Lcom_baidu_mapapi_radar_RadarUploadInfoCallback_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startUploadAuto", "(Lcom/baidu/mapapi/radar/RadarUploadInfoCallback;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stopUploadAuto;
#pragma warning disable 0169
		static Delegate GetStopUploadAutoHandler ()
		{
			if (cb_stopUploadAuto == null)
				cb_stopUploadAuto = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopUploadAuto);
			return cb_stopUploadAuto;
		}

		static void n_StopUploadAuto (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Radar.RadarSearchManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopUploadAuto ();
		}
#pragma warning restore 0169

		static IntPtr id_stopUploadAuto;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']/method[@name='stopUploadAuto' and count(parameter)=0]"
		[Register ("stopUploadAuto", "()V", "GetStopUploadAutoHandler")]
		public virtual unsafe void StopUploadAuto ()
		{
			if (id_stopUploadAuto == IntPtr.Zero)
				id_stopUploadAuto = JNIEnv.GetMethodID (class_ref, "stopUploadAuto", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stopUploadAuto);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopUploadAuto", "()V"));
			} finally {
			}
		}

		static Delegate cb_uploadInfoRequest_Lcom_baidu_mapapi_radar_RadarUploadInfo_;
#pragma warning disable 0169
		static Delegate GetUploadInfoRequest_Lcom_baidu_mapapi_radar_RadarUploadInfo_Handler ()
		{
			if (cb_uploadInfoRequest_Lcom_baidu_mapapi_radar_RadarUploadInfo_ == null)
				cb_uploadInfoRequest_Lcom_baidu_mapapi_radar_RadarUploadInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UploadInfoRequest_Lcom_baidu_mapapi_radar_RadarUploadInfo_);
			return cb_uploadInfoRequest_Lcom_baidu_mapapi_radar_RadarUploadInfo_;
		}

		static bool n_UploadInfoRequest_Lcom_baidu_mapapi_radar_RadarUploadInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Radar.RadarSearchManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarSearchManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Radar.RadarUploadInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarUploadInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UploadInfoRequest (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_uploadInfoRequest_Lcom_baidu_mapapi_radar_RadarUploadInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarSearchManager']/method[@name='uploadInfoRequest' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.radar.RadarUploadInfo']]"
		[Register ("uploadInfoRequest", "(Lcom/baidu/mapapi/radar/RadarUploadInfo;)Z", "GetUploadInfoRequest_Lcom_baidu_mapapi_radar_RadarUploadInfo_Handler")]
		public virtual unsafe bool UploadInfoRequest (global::Com.Baidu.Mapapi.Radar.RadarUploadInfo p0)
		{
			if (id_uploadInfoRequest_Lcom_baidu_mapapi_radar_RadarUploadInfo_ == IntPtr.Zero)
				id_uploadInfoRequest_Lcom_baidu_mapapi_radar_RadarUploadInfo_ = JNIEnv.GetMethodID (class_ref, "uploadInfoRequest", "(Lcom/baidu/mapapi/radar/RadarUploadInfo;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_uploadInfoRequest_Lcom_baidu_mapapi_radar_RadarUploadInfo_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uploadInfoRequest", "(Lcom/baidu/mapapi/radar/RadarUploadInfo;)Z"), __args);
				return __ret;
			} finally {
			}
		}

#region "Event implementation for Com.Baidu.Mapapi.Radar.IRadarSearchListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Radar.GetClearInfoStateEventArgs> GetClearInfoState {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Radar.IRadarSearchListener, global::Com.Baidu.Mapapi.Radar.IRadarSearchListenerImplementor>(
						ref weak_implementor_AddNearbyInfoListener,
						__CreateIRadarSearchListenerImplementor,
						AddNearbyInfoListener,
						__h => __h.OnGetClearInfoStateHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Radar.IRadarSearchListener, global::Com.Baidu.Mapapi.Radar.IRadarSearchListenerImplementor>(
						ref weak_implementor_AddNearbyInfoListener,
						global::Com.Baidu.Mapapi.Radar.IRadarSearchListenerImplementor.__IsEmpty,
						RemoveNearbyInfoListener,
						__h => __h.OnGetClearInfoStateHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Radar.GetNearbyInfoListEventArgs> GetNearbyInfoList {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Radar.IRadarSearchListener, global::Com.Baidu.Mapapi.Radar.IRadarSearchListenerImplementor>(
						ref weak_implementor_AddNearbyInfoListener,
						__CreateIRadarSearchListenerImplementor,
						AddNearbyInfoListener,
						__h => __h.OnGetNearbyInfoListHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Radar.IRadarSearchListener, global::Com.Baidu.Mapapi.Radar.IRadarSearchListenerImplementor>(
						ref weak_implementor_AddNearbyInfoListener,
						global::Com.Baidu.Mapapi.Radar.IRadarSearchListenerImplementor.__IsEmpty,
						RemoveNearbyInfoListener,
						__h => __h.OnGetNearbyInfoListHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Radar.GetUploadStateEventArgs> GetUploadState {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Radar.IRadarSearchListener, global::Com.Baidu.Mapapi.Radar.IRadarSearchListenerImplementor>(
						ref weak_implementor_AddNearbyInfoListener,
						__CreateIRadarSearchListenerImplementor,
						AddNearbyInfoListener,
						__h => __h.OnGetUploadStateHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Radar.IRadarSearchListener, global::Com.Baidu.Mapapi.Radar.IRadarSearchListenerImplementor>(
						ref weak_implementor_AddNearbyInfoListener,
						global::Com.Baidu.Mapapi.Radar.IRadarSearchListenerImplementor.__IsEmpty,
						RemoveNearbyInfoListener,
						__h => __h.OnGetUploadStateHandler -= value);
			}
		}

		WeakReference weak_implementor_AddNearbyInfoListener;

		global::Com.Baidu.Mapapi.Radar.IRadarSearchListenerImplementor __CreateIRadarSearchListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Radar.IRadarSearchListenerImplementor (this);
		}
#endregion
	}
}
