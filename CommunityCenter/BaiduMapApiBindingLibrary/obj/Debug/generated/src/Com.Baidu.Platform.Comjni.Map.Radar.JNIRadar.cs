using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Map.Radar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.map.radar']/class[@name='JNIRadar']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/map/radar/JNIRadar", DoNotGenerateAcw=true)]
	public partial class JNIRadar : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/map/radar/JNIRadar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JNIRadar); }
		}

		protected JNIRadar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comjni.map.radar']/class[@name='JNIRadar']/constructor[@name='JNIRadar' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JNIRadar ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JNIRadar)) {
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

		static Delegate cb_Create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_Create == null)
				cb_Create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Create);
			return cb_Create;
		}

		static long n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comjni.Map.Radar.JNIRadar __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Radar.JNIRadar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Create ();
		}
#pragma warning restore 0169

		static IntPtr id_Create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.radar']/class[@name='JNIRadar']/method[@name='Create' and count(parameter)=0]"
		[Register ("Create", "()J", "GetCreateHandler")]
		public virtual unsafe long Create ()
		{
			if (id_Create == IntPtr.Zero)
				id_Create = JNIEnv.GetMethodID (class_ref, "Create", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_Create);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Create", "()J"));
			} finally {
			}
		}

		static Delegate cb_GetRadarResult_JI;
#pragma warning disable 0169
		static Delegate GetGetRadarResult_JIHandler ()
		{
			if (cb_GetRadarResult_JI == null)
				cb_GetRadarResult_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, IntPtr>) n_GetRadarResult_JI);
			return cb_GetRadarResult_JI;
		}

		static IntPtr n_GetRadarResult_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Radar.JNIRadar __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Radar.JNIRadar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetRadarResult (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_GetRadarResult_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.radar']/class[@name='JNIRadar']/method[@name='GetRadarResult' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("GetRadarResult", "(JI)Ljava/lang/String;", "GetGetRadarResult_JIHandler")]
		public virtual unsafe string GetRadarResult (long p0, int p1)
		{
			if (id_GetRadarResult_JI == IntPtr.Zero)
				id_GetRadarResult_JI = JNIEnv.GetMethodID (class_ref, "GetRadarResult", "(JI)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetRadarResult_JI, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetRadarResult", "(JI)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_Release_J;
#pragma warning disable 0169
		static Delegate GetRelease_JHandler ()
		{
			if (cb_Release_J == null)
				cb_Release_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int>) n_Release_J);
			return cb_Release_J;
		}

		static int n_Release_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Radar.JNIRadar __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Radar.JNIRadar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Release (p0);
		}
#pragma warning restore 0169

		static IntPtr id_Release_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.radar']/class[@name='JNIRadar']/method[@name='Release' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Release", "(J)I", "GetRelease_JHandler")]
		public virtual unsafe int Release (long p0)
		{
			if (id_Release_J == IntPtr.Zero)
				id_Release_J = JNIEnv.GetMethodID (class_ref, "Release", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_Release_J, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Release", "(J)I"), __args);
			} finally {
			}
		}

		static Delegate cb_SendClearLocationInfoRequest_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendClearLocationInfoRequest_JLandroid_os_Bundle_Handler ()
		{
			if (cb_SendClearLocationInfoRequest_JLandroid_os_Bundle_ == null)
				cb_SendClearLocationInfoRequest_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_SendClearLocationInfoRequest_JLandroid_os_Bundle_);
			return cb_SendClearLocationInfoRequest_JLandroid_os_Bundle_;
		}

		static bool n_SendClearLocationInfoRequest_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Radar.JNIRadar __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Radar.JNIRadar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendClearLocationInfoRequest (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SendClearLocationInfoRequest_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.radar']/class[@name='JNIRadar']/method[@name='SendClearLocationInfoRequest' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("SendClearLocationInfoRequest", "(JLandroid/os/Bundle;)Z", "GetSendClearLocationInfoRequest_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool SendClearLocationInfoRequest (long p0, global::Android.OS.Bundle p1)
		{
			if (id_SendClearLocationInfoRequest_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_SendClearLocationInfoRequest_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "SendClearLocationInfoRequest", "(JLandroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SendClearLocationInfoRequest_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SendClearLocationInfoRequest", "(JLandroid/os/Bundle;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SendGetLocationInfosNearbyRequest_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendGetLocationInfosNearbyRequest_JLandroid_os_Bundle_Handler ()
		{
			if (cb_SendGetLocationInfosNearbyRequest_JLandroid_os_Bundle_ == null)
				cb_SendGetLocationInfosNearbyRequest_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_SendGetLocationInfosNearbyRequest_JLandroid_os_Bundle_);
			return cb_SendGetLocationInfosNearbyRequest_JLandroid_os_Bundle_;
		}

		static bool n_SendGetLocationInfosNearbyRequest_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Radar.JNIRadar __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Radar.JNIRadar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendGetLocationInfosNearbyRequest (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SendGetLocationInfosNearbyRequest_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.radar']/class[@name='JNIRadar']/method[@name='SendGetLocationInfosNearbyRequest' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("SendGetLocationInfosNearbyRequest", "(JLandroid/os/Bundle;)Z", "GetSendGetLocationInfosNearbyRequest_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool SendGetLocationInfosNearbyRequest (long p0, global::Android.OS.Bundle p1)
		{
			if (id_SendGetLocationInfosNearbyRequest_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_SendGetLocationInfosNearbyRequest_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "SendGetLocationInfosNearbyRequest", "(JLandroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SendGetLocationInfosNearbyRequest_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SendGetLocationInfosNearbyRequest", "(JLandroid/os/Bundle;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SendUploadLocationInfoRequest_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendUploadLocationInfoRequest_JLandroid_os_Bundle_Handler ()
		{
			if (cb_SendUploadLocationInfoRequest_JLandroid_os_Bundle_ == null)
				cb_SendUploadLocationInfoRequest_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_SendUploadLocationInfoRequest_JLandroid_os_Bundle_);
			return cb_SendUploadLocationInfoRequest_JLandroid_os_Bundle_;
		}

		static bool n_SendUploadLocationInfoRequest_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Radar.JNIRadar __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Radar.JNIRadar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendUploadLocationInfoRequest (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SendUploadLocationInfoRequest_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.radar']/class[@name='JNIRadar']/method[@name='SendUploadLocationInfoRequest' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("SendUploadLocationInfoRequest", "(JLandroid/os/Bundle;)Z", "GetSendUploadLocationInfoRequest_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool SendUploadLocationInfoRequest (long p0, global::Android.OS.Bundle p1)
		{
			if (id_SendUploadLocationInfoRequest_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_SendUploadLocationInfoRequest_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "SendUploadLocationInfoRequest", "(JLandroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SendUploadLocationInfoRequest_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SendUploadLocationInfoRequest", "(JLandroid/os/Bundle;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
