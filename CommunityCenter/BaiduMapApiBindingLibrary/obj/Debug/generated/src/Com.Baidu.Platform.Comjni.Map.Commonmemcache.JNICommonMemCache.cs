using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Map.Commonmemcache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.map.commonmemcache']/class[@name='JNICommonMemCache']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/map/commonmemcache/JNICommonMemCache", DoNotGenerateAcw=true)]
	public partial class JNICommonMemCache : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/map/commonmemcache/JNICommonMemCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JNICommonMemCache); }
		}

		protected JNICommonMemCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comjni.map.commonmemcache']/class[@name='JNICommonMemCache']/constructor[@name='JNICommonMemCache' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JNICommonMemCache ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JNICommonMemCache)) {
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
			global::Com.Baidu.Platform.Comjni.Map.Commonmemcache.JNICommonMemCache __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Commonmemcache.JNICommonMemCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Create ();
		}
#pragma warning restore 0169

		static IntPtr id_Create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.commonmemcache']/class[@name='JNICommonMemCache']/method[@name='Create' and count(parameter)=0]"
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

		static Delegate cb_Init_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetInit_JLandroid_os_Bundle_Handler ()
		{
			if (cb_Init_JLandroid_os_Bundle_ == null)
				cb_Init_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_Init_JLandroid_os_Bundle_);
			return cb_Init_JLandroid_os_Bundle_;
		}

		static void n_Init_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Commonmemcache.JNICommonMemCache __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Commonmemcache.JNICommonMemCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_Init_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.commonmemcache']/class[@name='JNICommonMemCache']/method[@name='Init' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("Init", "(JLandroid/os/Bundle;)V", "GetInit_JLandroid_os_Bundle_Handler")]
		public virtual unsafe void Init (long p0, global::Android.OS.Bundle p1)
		{
			if (id_Init_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_Init_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "Init", "(JLandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_Init_JLandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Init", "(JLandroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

	}
}
