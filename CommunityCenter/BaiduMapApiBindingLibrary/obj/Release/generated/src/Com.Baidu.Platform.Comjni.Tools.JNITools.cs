using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.tools']/class[@name='JNITools']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/tools/JNITools", DoNotGenerateAcw=true)]
	public partial class JNITools : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/tools/JNITools", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JNITools); }
		}

		protected JNITools (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_GetToken;
		public static unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.tools']/class[@name='JNITools']/method[@name='GetToken' and count(parameter)=0]"
			[Register ("GetToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				if (id_GetToken == IntPtr.Zero)
					id_GetToken = JNIEnv.GetStaticMethodID (class_ref, "GetToken", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_GetToken), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_CoordinateEncryptEx_FFLjava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.tools']/class[@name='JNITools']/method[@name='CoordinateEncryptEx' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object']]"
		[Register ("CoordinateEncryptEx", "(FFLjava/lang/String;Ljava/lang/Object;)Z", "")]
		public static unsafe bool CoordinateEncryptEx (float p0, float p1, string p2, global::Java.Lang.Object p3)
		{
			if (id_CoordinateEncryptEx_FFLjava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_CoordinateEncryptEx_FFLjava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "CoordinateEncryptEx", "(FFLjava/lang/String;Ljava/lang/Object;)Z");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_CoordinateEncryptEx_FFLjava_lang_String_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_GetDistanceByMC_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.tools']/class[@name='JNITools']/method[@name='GetDistanceByMC' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("GetDistanceByMC", "(Ljava/lang/Object;)V", "")]
		public static unsafe void GetDistanceByMC (global::Java.Lang.Object p0)
		{
			if (id_GetDistanceByMC_Ljava_lang_Object_ == IntPtr.Zero)
				id_GetDistanceByMC_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "GetDistanceByMC", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_GetDistanceByMC_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_TransGeoStr2ComplexPt_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.tools']/class[@name='JNITools']/method[@name='TransGeoStr2ComplexPt' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("TransGeoStr2ComplexPt", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool TransGeoStr2ComplexPt (global::Java.Lang.Object p0)
		{
			if (id_TransGeoStr2ComplexPt_Ljava_lang_Object_ == IntPtr.Zero)
				id_TransGeoStr2ComplexPt_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "TransGeoStr2ComplexPt", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_TransGeoStr2ComplexPt_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_TransGeoStr2Pt_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.tools']/class[@name='JNITools']/method[@name='TransGeoStr2Pt' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("TransGeoStr2Pt", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool TransGeoStr2Pt (global::Java.Lang.Object p0)
		{
			if (id_TransGeoStr2Pt_Ljava_lang_Object_ == IntPtr.Zero)
				id_TransGeoStr2Pt_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "TransGeoStr2Pt", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_TransGeoStr2Pt_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_TransNodeStr2Pt_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.tools']/class[@name='JNITools']/method[@name='TransNodeStr2Pt' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("TransNodeStr2Pt", "(Ljava/lang/Object;)V", "")]
		public static unsafe void TransNodeStr2Pt (global::Java.Lang.Object p0)
		{
			if (id_TransNodeStr2Pt_Ljava_lang_Object_ == IntPtr.Zero)
				id_TransNodeStr2Pt_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "TransNodeStr2Pt", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_TransNodeStr2Pt_Ljava_lang_Object_, __args);
			} finally {
			}
		}

	}
}
