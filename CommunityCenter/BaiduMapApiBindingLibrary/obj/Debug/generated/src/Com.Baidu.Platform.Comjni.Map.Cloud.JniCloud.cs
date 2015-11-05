using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Map.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.map.cloud']/class[@name='JniCloud']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/map/cloud/JniCloud", DoNotGenerateAcw=true)]
	public partial class JniCloud : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/map/cloud/JniCloud", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JniCloud); }
		}

		protected JniCloud (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comjni.map.cloud']/class[@name='JniCloud']/constructor[@name='JniCloud' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JniCloud ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JniCloud)) {
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

		static Delegate cb_cloudDetailSearch_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetCloudDetailSearch_JLandroid_os_Bundle_Handler ()
		{
			if (cb_cloudDetailSearch_JLandroid_os_Bundle_ == null)
				cb_cloudDetailSearch_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_CloudDetailSearch_JLandroid_os_Bundle_);
			return cb_cloudDetailSearch_JLandroid_os_Bundle_;
		}

		static void n_CloudDetailSearch_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Cloud.JniCloud __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Cloud.JniCloud> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CloudDetailSearch (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_cloudDetailSearch_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.cloud']/class[@name='JniCloud']/method[@name='cloudDetailSearch' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("cloudDetailSearch", "(JLandroid/os/Bundle;)V", "GetCloudDetailSearch_JLandroid_os_Bundle_Handler")]
		public virtual unsafe void CloudDetailSearch (long p0, global::Android.OS.Bundle p1)
		{
			if (id_cloudDetailSearch_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_cloudDetailSearch_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "cloudDetailSearch", "(JLandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cloudDetailSearch_JLandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cloudDetailSearch", "(JLandroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_cloudSearch_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetCloudSearch_JLandroid_os_Bundle_Handler ()
		{
			if (cb_cloudSearch_JLandroid_os_Bundle_ == null)
				cb_cloudSearch_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_CloudSearch_JLandroid_os_Bundle_);
			return cb_cloudSearch_JLandroid_os_Bundle_;
		}

		static void n_CloudSearch_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Cloud.JniCloud __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Cloud.JniCloud> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CloudSearch (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_cloudSearch_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.cloud']/class[@name='JniCloud']/method[@name='cloudSearch' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("cloudSearch", "(JLandroid/os/Bundle;)V", "GetCloudSearch_JLandroid_os_Bundle_Handler")]
		public virtual unsafe void CloudSearch (long p0, global::Android.OS.Bundle p1)
		{
			if (id_cloudSearch_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_cloudSearch_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "cloudSearch", "(JLandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cloudSearch_JLandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cloudSearch", "(JLandroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_create == null)
				cb_create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Create);
			return cb_create;
		}

		static long n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comjni.Map.Cloud.JniCloud __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Cloud.JniCloud> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Create ();
		}
#pragma warning restore 0169

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.cloud']/class[@name='JniCloud']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()J", "GetCreateHandler")]
		public virtual unsafe long Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetMethodID (class_ref, "create", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_create);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "()J"));
			} finally {
			}
		}

		static Delegate cb_getSearchResult_JI;
#pragma warning disable 0169
		static Delegate GetGetSearchResult_JIHandler ()
		{
			if (cb_getSearchResult_JI == null)
				cb_getSearchResult_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, IntPtr>) n_GetSearchResult_JI);
			return cb_getSearchResult_JI;
		}

		static IntPtr n_GetSearchResult_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Cloud.JniCloud __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Cloud.JniCloud> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetSearchResult (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_getSearchResult_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.cloud']/class[@name='JniCloud']/method[@name='getSearchResult' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("getSearchResult", "(JI)Ljava/lang/String;", "GetGetSearchResult_JIHandler")]
		public virtual unsafe string GetSearchResult (long p0, int p1)
		{
			if (id_getSearchResult_JI == IntPtr.Zero)
				id_getSearchResult_JI = JNIEnv.GetMethodID (class_ref, "getSearchResult", "(JI)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSearchResult_JI, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSearchResult", "(JI)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_release_J;
#pragma warning disable 0169
		static Delegate GetRelease_JHandler ()
		{
			if (cb_release_J == null)
				cb_release_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int>) n_Release_J);
			return cb_release_J;
		}

		static int n_Release_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Cloud.JniCloud __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Cloud.JniCloud> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Release (p0);
		}
#pragma warning restore 0169

		static IntPtr id_release_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.cloud']/class[@name='JniCloud']/method[@name='release' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("release", "(J)I", "GetRelease_JHandler")]
		public virtual unsafe int Release (long p0)
		{
			if (id_release_J == IntPtr.Zero)
				id_release_J = JNIEnv.GetMethodID (class_ref, "release", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_release_J, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "(J)I"), __args);
			} finally {
			}
		}

	}
}
