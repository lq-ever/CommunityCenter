using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.util']/class[@name='JRecorder']"
	[global::Android.Runtime.Register ("cn/jpush/android/util/JRecorder", DoNotGenerateAcw=true)]
	public partial class JRecorder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/util/JRecorder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JRecorder); }
		}

		protected JRecorder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getIncreamentsRecorder_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.util']/class[@name='JRecorder']/method[@name='getIncreamentsRecorder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getIncreamentsRecorder", "(Landroid/content/Context;)Lcn/jpush/android/util/JRecorder;", "")]
		public static unsafe global::CN.Jpush.Android.Util.JRecorder GetIncreamentsRecorder (global::Android.Content.Context p0)
		{
			if (id_getIncreamentsRecorder_Landroid_content_Context_ == IntPtr.Zero)
				id_getIncreamentsRecorder_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getIncreamentsRecorder", "(Landroid/content/Context;)Lcn/jpush/android/util/JRecorder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::CN.Jpush.Android.Util.JRecorder __ret = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Util.JRecorder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIncreamentsRecorder_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getSuperpositionRecorder_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.util']/class[@name='JRecorder']/method[@name='getSuperpositionRecorder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSuperpositionRecorder", "(Landroid/content/Context;)Lcn/jpush/android/util/JRecorder;", "")]
		public static unsafe global::CN.Jpush.Android.Util.JRecorder GetSuperpositionRecorder (global::Android.Content.Context p0)
		{
			if (id_getSuperpositionRecorder_Landroid_content_Context_ == IntPtr.Zero)
				id_getSuperpositionRecorder_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getSuperpositionRecorder", "(Landroid/content/Context;)Lcn/jpush/android/util/JRecorder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::CN.Jpush.Android.Util.JRecorder __ret = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Util.JRecorder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSuperpositionRecorder_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parseRecordCommand_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.util']/class[@name='JRecorder']/method[@name='parseRecordCommand' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseRecordCommand", "(Ljava/lang/String;)V", "")]
		public static unsafe void ParseRecordCommand (string p0)
		{
			if (id_parseRecordCommand_Ljava_lang_String_ == IntPtr.Zero)
				id_parseRecordCommand_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseRecordCommand", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_parseRecordCommand_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_record_I;
#pragma warning disable 0169
		static Delegate GetRecord_IHandler ()
		{
			if (cb_record_I == null)
				cb_record_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Record_I);
			return cb_record_I;
		}

		static void n_Record_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jpush.Android.Util.JRecorder __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Util.JRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Record (p0);
		}
#pragma warning restore 0169

		static IntPtr id_record_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.util']/class[@name='JRecorder']/method[@name='record' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("record", "(I)V", "GetRecord_IHandler")]
		public virtual unsafe void Record (int p0)
		{
			if (id_record_I == IntPtr.Zero)
				id_record_I = JNIEnv.GetMethodID (class_ref, "record", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_record_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "record", "(I)V"), __args);
			} finally {
			}
		}

	}
}
