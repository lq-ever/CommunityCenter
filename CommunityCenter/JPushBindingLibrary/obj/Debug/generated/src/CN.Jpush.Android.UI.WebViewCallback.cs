using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='WebViewCallback']"
	[global::Android.Runtime.Register ("cn/jpush/android/ui/WebViewCallback", DoNotGenerateAcw=true)]
	public partial class WebViewCallback : global::Java.Lang.Object, global::CN.Jpush.Android.Util.IJavascriptCallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/ui/WebViewCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebViewCallback); }
		}

		protected WebViewCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_click_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClick_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_click_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_click_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Click_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_click_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Click_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jpush.Android.UI.WebViewCallback __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.WebViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Click (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_click_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='WebViewCallback']/method[@name='click' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("click", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetClick_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Click (string p0, string p1, string p2)
		{
			if (id_click_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_click_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "click", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_click_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "click", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.UI.WebViewCallback __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.WebViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='WebViewCallback']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_createShortcut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateShortcut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_createShortcut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_createShortcut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateShortcut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_createShortcut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CreateShortcut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jpush.Android.UI.WebViewCallback __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.WebViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CreateShortcut (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_createShortcut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='WebViewCallback']/method[@name='createShortcut' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("createShortcut", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetCreateShortcut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void CreateShortcut (string p0, string p1, string p2)
		{
			if (id_createShortcut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createShortcut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createShortcut", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_createShortcut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createShortcut", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_download_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDownload_Ljava_lang_String_Handler ()
		{
			if (cb_download_Ljava_lang_String_ == null)
				cb_download_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Download_Ljava_lang_String_);
			return cb_download_Ljava_lang_String_;
		}

		static void n_Download_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.UI.WebViewCallback __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.WebViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Download (p0);
		}
#pragma warning restore 0169

		static IntPtr id_download_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='WebViewCallback']/method[@name='download' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("download", "(Ljava/lang/String;)V", "GetDownload_Ljava_lang_String_Handler")]
		public virtual unsafe void Download (string p0)
		{
			if (id_download_Ljava_lang_String_ == IntPtr.Zero)
				id_download_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "download", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_download_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "download", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_download_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDownload_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_download_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_download_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Download_Ljava_lang_String_Ljava_lang_String_);
			return cb_download_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Download_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jpush.Android.UI.WebViewCallback __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.WebViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Download (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_download_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='WebViewCallback']/method[@name='download' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("download", "(Ljava/lang/String;Ljava/lang/String;)V", "GetDownload_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Download (string p0, string p1)
		{
			if (id_download_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_download_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "download", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_download_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "download", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_download_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDownload_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_download_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_download_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Download_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_download_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Download_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jpush.Android.UI.WebViewCallback __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.WebViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Download (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_download_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='WebViewCallback']/method[@name='download' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("download", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetDownload_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Download (string p0, string p1, string p2)
		{
			if (id_download_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_download_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "download", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_download_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "download", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_executeMsgMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExecuteMsgMessage_Ljava_lang_String_Handler ()
		{
			if (cb_executeMsgMessage_Ljava_lang_String_ == null)
				cb_executeMsgMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ExecuteMsgMessage_Ljava_lang_String_);
			return cb_executeMsgMessage_Ljava_lang_String_;
		}

		static void n_ExecuteMsgMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.UI.WebViewCallback __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.WebViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteMsgMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_executeMsgMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='WebViewCallback']/method[@name='executeMsgMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("executeMsgMessage", "(Ljava/lang/String;)V", "GetExecuteMsgMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void ExecuteMsgMessage (string p0)
		{
			if (id_executeMsgMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_executeMsgMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "executeMsgMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_executeMsgMessage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "executeMsgMessage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_showToast_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowToast_Ljava_lang_String_Handler ()
		{
			if (cb_showToast_Ljava_lang_String_ == null)
				cb_showToast_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowToast_Ljava_lang_String_);
			return cb_showToast_Ljava_lang_String_;
		}

		static void n_ShowToast_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.UI.WebViewCallback __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.WebViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowToast (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showToast_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='WebViewCallback']/method[@name='showToast' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showToast", "(Ljava/lang/String;)V", "GetShowToast_Ljava_lang_String_Handler")]
		public virtual unsafe void ShowToast (string p0)
		{
			if (id_showToast_Ljava_lang_String_ == IntPtr.Zero)
				id_showToast_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showToast", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showToast_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showToast", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_startActivityByIntent_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartActivityByIntent_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_startActivityByIntent_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_startActivityByIntent_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActivityByIntent_Ljava_lang_String_Ljava_lang_String_);
			return cb_startActivityByIntent_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_StartActivityByIntent_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jpush.Android.UI.WebViewCallback __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.WebViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityByIntent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startActivityByIntent_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='WebViewCallback']/method[@name='startActivityByIntent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("startActivityByIntent", "(Ljava/lang/String;Ljava/lang/String;)V", "GetStartActivityByIntent_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void StartActivityByIntent (string p0, string p1)
		{
			if (id_startActivityByIntent_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_startActivityByIntent_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startActivityByIntent", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startActivityByIntent_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startActivityByIntent", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_startActivityByName_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartActivityByName_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_startActivityByName_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_startActivityByName_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActivityByName_Ljava_lang_String_Ljava_lang_String_);
			return cb_startActivityByName_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_StartActivityByName_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jpush.Android.UI.WebViewCallback __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.WebViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityByName (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startActivityByName_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='WebViewCallback']/method[@name='startActivityByName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("startActivityByName", "(Ljava/lang/String;Ljava/lang/String;)V", "GetStartActivityByName_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void StartActivityByName (string p0, string p1)
		{
			if (id_startActivityByName_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_startActivityByName_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startActivityByName", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startActivityByName_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startActivityByName", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_startMainActivity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartMainActivity_Ljava_lang_String_Handler ()
		{
			if (cb_startMainActivity_Ljava_lang_String_ == null)
				cb_startMainActivity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartMainActivity_Ljava_lang_String_);
			return cb_startMainActivity_Ljava_lang_String_;
		}

		static void n_StartMainActivity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.UI.WebViewCallback __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.WebViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartMainActivity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startMainActivity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='WebViewCallback']/method[@name='startMainActivity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startMainActivity", "(Ljava/lang/String;)V", "GetStartMainActivity_Ljava_lang_String_Handler")]
		public virtual unsafe void StartMainActivity (string p0)
		{
			if (id_startMainActivity_Ljava_lang_String_ == IntPtr.Zero)
				id_startMainActivity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startMainActivity", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startMainActivity_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startMainActivity", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_triggerNativeAction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTriggerNativeAction_Ljava_lang_String_Handler ()
		{
			if (cb_triggerNativeAction_Ljava_lang_String_ == null)
				cb_triggerNativeAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TriggerNativeAction_Ljava_lang_String_);
			return cb_triggerNativeAction_Ljava_lang_String_;
		}

		static void n_TriggerNativeAction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.UI.WebViewCallback __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.WebViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TriggerNativeAction (p0);
		}
#pragma warning restore 0169

		static IntPtr id_triggerNativeAction_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='WebViewCallback']/method[@name='triggerNativeAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("triggerNativeAction", "(Ljava/lang/String;)V", "GetTriggerNativeAction_Ljava_lang_String_Handler")]
		public virtual unsafe void TriggerNativeAction (string p0)
		{
			if (id_triggerNativeAction_Ljava_lang_String_ == IntPtr.Zero)
				id_triggerNativeAction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "triggerNativeAction", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_triggerNativeAction_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "triggerNativeAction", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
