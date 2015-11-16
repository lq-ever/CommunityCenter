using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='DefaultPushNotificationBuilder']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/DefaultPushNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class DefaultPushNotificationBuilder : global::Java.Lang.Object, global::CN.Jpush.Android.Api.IPushNotificationBuilder {


		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='DefaultPushNotificationBuilder']/field[@name='b']"
		[Register ("b")]
		protected string B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, b_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, b_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/api/DefaultPushNotificationBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultPushNotificationBuilder); }
		}

		protected DefaultPushNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='DefaultPushNotificationBuilder']/constructor[@name='DefaultPushNotificationBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultPushNotificationBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DefaultPushNotificationBuilder)) {
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

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.A ());
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='DefaultPushNotificationBuilder']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "GetAHandler")]
		public virtual unsafe string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='DefaultPushNotificationBuilder']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("a", "(Ljava/lang/String;Ljava/util/Map;)Landroid/app/Notification;", "")]
		public unsafe global::Android.App.Notification A (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_a_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/util/Map;)Landroid/app/Notification;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Android.App.Notification __ret = global::Java.Lang.Object.GetObject<global::Android.App.Notification> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
