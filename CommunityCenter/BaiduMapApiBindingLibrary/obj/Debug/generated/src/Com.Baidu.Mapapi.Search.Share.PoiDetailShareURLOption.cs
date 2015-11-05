using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Share {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='PoiDetailShareURLOption']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/share/PoiDetailShareURLOption", DoNotGenerateAcw=true)]
	public partial class PoiDetailShareURLOption : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/share/PoiDetailShareURLOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PoiDetailShareURLOption); }
		}

		protected PoiDetailShareURLOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='PoiDetailShareURLOption']/constructor[@name='PoiDetailShareURLOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PoiDetailShareURLOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PoiDetailShareURLOption)) {
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

		static Delegate cb_poiUid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPoiUid_Ljava_lang_String_Handler ()
		{
			if (cb_poiUid_Ljava_lang_String_ == null)
				cb_poiUid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PoiUid_Ljava_lang_String_);
			return cb_poiUid_Ljava_lang_String_;
		}

		static IntPtr n_PoiUid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Share.PoiDetailShareURLOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.PoiDetailShareURLOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PoiUid (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_poiUid_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.share']/class[@name='PoiDetailShareURLOption']/method[@name='poiUid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("poiUid", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/share/PoiDetailShareURLOption;", "GetPoiUid_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Share.PoiDetailShareURLOption PoiUid (string p0)
		{
			if (id_poiUid_Ljava_lang_String_ == IntPtr.Zero)
				id_poiUid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "poiUid", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/share/PoiDetailShareURLOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Search.Share.PoiDetailShareURLOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.PoiDetailShareURLOption> (JNIEnv.CallObjectMethod  (Handle, id_poiUid_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.PoiDetailShareURLOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "poiUid", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/share/PoiDetailShareURLOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
