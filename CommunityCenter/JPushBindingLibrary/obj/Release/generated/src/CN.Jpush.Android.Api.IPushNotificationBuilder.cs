using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.jpush.android.api']/interface[@name='PushNotificationBuilder']"
	[Register ("cn/jpush/android/api/PushNotificationBuilder", "", "CN.Jpush.Android.Api.IPushNotificationBuilderInvoker")]
	public partial interface IPushNotificationBuilder : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/interface[@name='PushNotificationBuilder']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "GetAHandler:CN.Jpush.Android.Api.IPushNotificationBuilderInvoker, JPushBindingLibrary")]
		string A ();

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/interface[@name='PushNotificationBuilder']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("a", "(Ljava/lang/String;Ljava/util/Map;)Landroid/app/Notification;", "GetA_Ljava_lang_String_Ljava_util_Map_Handler:CN.Jpush.Android.Api.IPushNotificationBuilderInvoker, JPushBindingLibrary")]
		global::Android.App.Notification A (string p0, global::System.Collections.Generic.IDictionary<string, string> p1);

	}

	[global::Android.Runtime.Register ("cn/jpush/android/api/PushNotificationBuilder", DoNotGenerateAcw=true)]
	internal class IPushNotificationBuilderInvoker : global::Java.Lang.Object, IPushNotificationBuilder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("cn/jpush/android/api/PushNotificationBuilder");
		IntPtr class_ref;

		public static IPushNotificationBuilder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPushNotificationBuilder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.jpush.android.api.PushNotificationBuilder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPushNotificationBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPushNotificationBuilderInvoker); }
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
			global::CN.Jpush.Android.Api.IPushNotificationBuilder __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.IPushNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.A ());
		}
#pragma warning restore 0169

		IntPtr id_a;
		public unsafe string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_a_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_a_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_a_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_Ljava_util_Map_);
			return cb_a_Ljava_lang_String_Ljava_util_Map_;
		}

		static IntPtr n_A_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jpush.Android.Api.IPushNotificationBuilder __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.IPushNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.A (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_a_Ljava_lang_String_Ljava_util_Map_;
		public unsafe global::Android.App.Notification A (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_a_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/util/Map;)Landroid/app/Notification;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Android.App.Notification __ret = global::Java.Lang.Object.GetObject<global::Android.App.Notification> (JNIEnv.CallObjectMethod (Handle, id_a_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
