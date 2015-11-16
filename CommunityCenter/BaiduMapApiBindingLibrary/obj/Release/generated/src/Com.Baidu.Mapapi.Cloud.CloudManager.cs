using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudManager']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/CloudManager", DoNotGenerateAcw=true)]
	public partial class CloudManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/cloud/CloudManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CloudManager); }
		}

		protected CloudManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudManager']/constructor[@name='CloudManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CloudManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CloudManager)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::Com.Baidu.Mapapi.Cloud.CloudManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/baidu/mapapi/cloud/CloudManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/baidu/mapapi/cloud/CloudManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.CloudManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_boundSearch_Lcom_baidu_mapapi_cloud_BoundSearchInfo_;
#pragma warning disable 0169
		static Delegate GetBoundSearch_Lcom_baidu_mapapi_cloud_BoundSearchInfo_Handler ()
		{
			if (cb_boundSearch_Lcom_baidu_mapapi_cloud_BoundSearchInfo_ == null)
				cb_boundSearch_Lcom_baidu_mapapi_cloud_BoundSearchInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_BoundSearch_Lcom_baidu_mapapi_cloud_BoundSearchInfo_);
			return cb_boundSearch_Lcom_baidu_mapapi_cloud_BoundSearchInfo_;
		}

		static bool n_BoundSearch_Lcom_baidu_mapapi_cloud_BoundSearchInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Cloud.CloudManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.CloudManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Cloud.BoundSearchInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.BoundSearchInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.BoundSearch (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_boundSearch_Lcom_baidu_mapapi_cloud_BoundSearchInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudManager']/method[@name='boundSearch' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.cloud.BoundSearchInfo']]"
		[Register ("boundSearch", "(Lcom/baidu/mapapi/cloud/BoundSearchInfo;)Z", "GetBoundSearch_Lcom_baidu_mapapi_cloud_BoundSearchInfo_Handler")]
		public virtual unsafe bool BoundSearch (global::Com.Baidu.Mapapi.Cloud.BoundSearchInfo p0)
		{
			if (id_boundSearch_Lcom_baidu_mapapi_cloud_BoundSearchInfo_ == IntPtr.Zero)
				id_boundSearch_Lcom_baidu_mapapi_cloud_BoundSearchInfo_ = JNIEnv.GetMethodID (class_ref, "boundSearch", "(Lcom/baidu/mapapi/cloud/BoundSearchInfo;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_boundSearch_Lcom_baidu_mapapi_cloud_BoundSearchInfo_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "boundSearch", "(Lcom/baidu/mapapi/cloud/BoundSearchInfo;)Z"), __args);
				return __ret;
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
			global::Com.Baidu.Mapapi.Cloud.CloudManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.CloudManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudManager']/method[@name='destroy' and count(parameter)=0]"
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

		static Delegate cb_detailSearch_Lcom_baidu_mapapi_cloud_DetailSearchInfo_;
#pragma warning disable 0169
		static Delegate GetDetailSearch_Lcom_baidu_mapapi_cloud_DetailSearchInfo_Handler ()
		{
			if (cb_detailSearch_Lcom_baidu_mapapi_cloud_DetailSearchInfo_ == null)
				cb_detailSearch_Lcom_baidu_mapapi_cloud_DetailSearchInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DetailSearch_Lcom_baidu_mapapi_cloud_DetailSearchInfo_);
			return cb_detailSearch_Lcom_baidu_mapapi_cloud_DetailSearchInfo_;
		}

		static bool n_DetailSearch_Lcom_baidu_mapapi_cloud_DetailSearchInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Cloud.CloudManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.CloudManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Cloud.DetailSearchInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.DetailSearchInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DetailSearch (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_detailSearch_Lcom_baidu_mapapi_cloud_DetailSearchInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudManager']/method[@name='detailSearch' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.cloud.DetailSearchInfo']]"
		[Register ("detailSearch", "(Lcom/baidu/mapapi/cloud/DetailSearchInfo;)Z", "GetDetailSearch_Lcom_baidu_mapapi_cloud_DetailSearchInfo_Handler")]
		public virtual unsafe bool DetailSearch (global::Com.Baidu.Mapapi.Cloud.DetailSearchInfo p0)
		{
			if (id_detailSearch_Lcom_baidu_mapapi_cloud_DetailSearchInfo_ == IntPtr.Zero)
				id_detailSearch_Lcom_baidu_mapapi_cloud_DetailSearchInfo_ = JNIEnv.GetMethodID (class_ref, "detailSearch", "(Lcom/baidu/mapapi/cloud/DetailSearchInfo;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_detailSearch_Lcom_baidu_mapapi_cloud_DetailSearchInfo_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detailSearch", "(Lcom/baidu/mapapi/cloud/DetailSearchInfo;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_init_Lcom_baidu_mapapi_cloud_CloudListener_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_baidu_mapapi_cloud_CloudListener_Handler ()
		{
			if (cb_init_Lcom_baidu_mapapi_cloud_CloudListener_ == null)
				cb_init_Lcom_baidu_mapapi_cloud_CloudListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Lcom_baidu_mapapi_cloud_CloudListener_);
			return cb_init_Lcom_baidu_mapapi_cloud_CloudListener_;
		}

		static void n_Init_Lcom_baidu_mapapi_cloud_CloudListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Cloud.CloudManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.CloudManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Cloud.ICloudListener p0 = (global::Com.Baidu.Mapapi.Cloud.ICloudListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.ICloudListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_Lcom_baidu_mapapi_cloud_CloudListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudManager']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.cloud.CloudListener']]"
		[Register ("init", "(Lcom/baidu/mapapi/cloud/CloudListener;)V", "GetInit_Lcom_baidu_mapapi_cloud_CloudListener_Handler")]
		public virtual unsafe void Init (global::Com.Baidu.Mapapi.Cloud.ICloudListener p0)
		{
			if (id_init_Lcom_baidu_mapapi_cloud_CloudListener_ == IntPtr.Zero)
				id_init_Lcom_baidu_mapapi_cloud_CloudListener_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/baidu/mapapi/cloud/CloudListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_init_Lcom_baidu_mapapi_cloud_CloudListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lcom/baidu/mapapi/cloud/CloudListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_localSearch_Lcom_baidu_mapapi_cloud_LocalSearchInfo_;
#pragma warning disable 0169
		static Delegate GetLocalSearch_Lcom_baidu_mapapi_cloud_LocalSearchInfo_Handler ()
		{
			if (cb_localSearch_Lcom_baidu_mapapi_cloud_LocalSearchInfo_ == null)
				cb_localSearch_Lcom_baidu_mapapi_cloud_LocalSearchInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_LocalSearch_Lcom_baidu_mapapi_cloud_LocalSearchInfo_);
			return cb_localSearch_Lcom_baidu_mapapi_cloud_LocalSearchInfo_;
		}

		static bool n_LocalSearch_Lcom_baidu_mapapi_cloud_LocalSearchInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Cloud.CloudManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.CloudManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Cloud.LocalSearchInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.LocalSearchInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LocalSearch (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_localSearch_Lcom_baidu_mapapi_cloud_LocalSearchInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudManager']/method[@name='localSearch' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.cloud.LocalSearchInfo']]"
		[Register ("localSearch", "(Lcom/baidu/mapapi/cloud/LocalSearchInfo;)Z", "GetLocalSearch_Lcom_baidu_mapapi_cloud_LocalSearchInfo_Handler")]
		public virtual unsafe bool LocalSearch (global::Com.Baidu.Mapapi.Cloud.LocalSearchInfo p0)
		{
			if (id_localSearch_Lcom_baidu_mapapi_cloud_LocalSearchInfo_ == IntPtr.Zero)
				id_localSearch_Lcom_baidu_mapapi_cloud_LocalSearchInfo_ = JNIEnv.GetMethodID (class_ref, "localSearch", "(Lcom/baidu/mapapi/cloud/LocalSearchInfo;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_localSearch_Lcom_baidu_mapapi_cloud_LocalSearchInfo_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "localSearch", "(Lcom/baidu/mapapi/cloud/LocalSearchInfo;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_nearbySearch_Lcom_baidu_mapapi_cloud_NearbySearchInfo_;
#pragma warning disable 0169
		static Delegate GetNearbySearch_Lcom_baidu_mapapi_cloud_NearbySearchInfo_Handler ()
		{
			if (cb_nearbySearch_Lcom_baidu_mapapi_cloud_NearbySearchInfo_ == null)
				cb_nearbySearch_Lcom_baidu_mapapi_cloud_NearbySearchInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_NearbySearch_Lcom_baidu_mapapi_cloud_NearbySearchInfo_);
			return cb_nearbySearch_Lcom_baidu_mapapi_cloud_NearbySearchInfo_;
		}

		static bool n_NearbySearch_Lcom_baidu_mapapi_cloud_NearbySearchInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Cloud.CloudManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.CloudManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Cloud.NearbySearchInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.NearbySearchInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.NearbySearch (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_nearbySearch_Lcom_baidu_mapapi_cloud_NearbySearchInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudManager']/method[@name='nearbySearch' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.cloud.NearbySearchInfo']]"
		[Register ("nearbySearch", "(Lcom/baidu/mapapi/cloud/NearbySearchInfo;)Z", "GetNearbySearch_Lcom_baidu_mapapi_cloud_NearbySearchInfo_Handler")]
		public virtual unsafe bool NearbySearch (global::Com.Baidu.Mapapi.Cloud.NearbySearchInfo p0)
		{
			if (id_nearbySearch_Lcom_baidu_mapapi_cloud_NearbySearchInfo_ == IntPtr.Zero)
				id_nearbySearch_Lcom_baidu_mapapi_cloud_NearbySearchInfo_ = JNIEnv.GetMethodID (class_ref, "nearbySearch", "(Lcom/baidu/mapapi/cloud/NearbySearchInfo;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_nearbySearch_Lcom_baidu_mapapi_cloud_NearbySearchInfo_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nearbySearch", "(Lcom/baidu/mapapi/cloud/NearbySearchInfo;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
