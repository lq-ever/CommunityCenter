using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.jpush.android.util']/interface[@name='JavascriptCallback']"
	[Register ("cn/jpush/android/util/JavascriptCallback", "", "CN.Jpush.Android.Util.IJavascriptCallbackInvoker")]
	public partial interface IJavascriptCallback : IJavaObject {

	}

	[global::Android.Runtime.Register ("cn/jpush/android/util/JavascriptCallback", DoNotGenerateAcw=true)]
	internal class IJavascriptCallbackInvoker : global::Java.Lang.Object, IJavascriptCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("cn/jpush/android/util/JavascriptCallback");
		IntPtr class_ref;

		public static IJavascriptCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJavascriptCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.jpush.android.util.JavascriptCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJavascriptCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IJavascriptCallbackInvoker); }
		}

	}

}
