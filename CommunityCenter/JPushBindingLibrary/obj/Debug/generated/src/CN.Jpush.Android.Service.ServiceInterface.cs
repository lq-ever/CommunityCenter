using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']"
	[global::Android.Runtime.Register ("cn/jpush/android/service/ServiceInterface", DoNotGenerateAcw=true)]
	public partial class ServiceInterface : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/service/ServiceInterface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServiceInterface); }
		}

		protected ServiceInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/constructor[@name='ServiceInterface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ServiceInterface ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ServiceInterface)) {
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "")]
		public static unsafe bool A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_a);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)V", "")]
		public static unsafe void A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;ZLjava/lang/String;)V", "")]
		public static unsafe void A (global::Android.Content.Context p0, bool p1, string p2)
		{
			if (id_a_Landroid_content_Context_ZLjava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ZLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;ZLjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_ZLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_a_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("a", "(Landroid/content/Context;I)V", "")]
		public static unsafe void A (global::Android.Content.Context p0, int p1)
		{
			if (id_a_Landroid_content_Context_I == IntPtr.Zero)
				id_a_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("a", "(Landroid/content/Context;IIII)Z", "")]
		public static unsafe bool A (global::Android.Content.Context p0, int p1, int p2, int p3, int p4)
		{
			if (id_a_Landroid_content_Context_IIII == IntPtr.Zero)
				id_a_Landroid_content_Context_IIII = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;IIII)Z");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Landroid_content_Context_IIII, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void A (global::Android.Content.Context p0, string p1)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_a_Landroid_content_Context_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("a", "(Landroid/content/Context;Lorg/json/JSONObject;)V", "")]
		public static unsafe void A (global::Android.Content.Context p0, global::Org.Json.JSONObject p1)
		{
			if (id_a_Landroid_content_Context_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public static unsafe void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_a_Ljava_lang_String_ILandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Context']]"
		[Register ("a", "(Ljava/lang/String;ILandroid/content/Context;)V", "")]
		public static unsafe void A (string p0, int p1, global::Android.Content.Context p2)
		{
			if (id_a_Ljava_lang_String_ILandroid_content_Context_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ILandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;ILandroid/content/Context;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_String_ILandroid_content_Context_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_a_Ljava_lang_String_ILjava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.content.Context']]"
		[Register ("a", "(Ljava/lang/String;ILjava/lang/String;Landroid/content/Context;)V", "")]
		public static unsafe void A (string p0, int p1, string p2, global::Android.Content.Context p3)
		{
			if (id_a_Ljava_lang_String_ILjava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ILjava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;ILjava/lang/String;Landroid/content/Context;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_String_ILjava_lang_String_Landroid_content_Context_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/lang/String;", "")]
		public static unsafe string B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetStaticMethodID (class_ref, "b", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_b_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("b", "(Landroid/content/Context;)V", "")]
		public static unsafe void B (global::Android.Content.Context p0)
		{
			if (id_b_Landroid_content_Context_ == IntPtr.Zero)
				id_b_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_b_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("b", "(Landroid/content/Context;I)V", "")]
		public static unsafe void B (global::Android.Content.Context p0, int p1)
		{
			if (id_b_Landroid_content_Context_I == IntPtr.Zero)
				id_b_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_b_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;)V", "")]
		public static unsafe void B (string p0)
		{
			if (id_b_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_c_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("c", "(Landroid/content/Context;)V", "")]
		public static unsafe void C (global::Android.Content.Context p0)
		{
			if (id_c_Landroid_content_Context_ == IntPtr.Zero)
				id_c_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_c_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='c' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("c", "(Landroid/content/Context;I)V", "")]
		public static unsafe void C (global::Android.Content.Context p0, int p1)
		{
			if (id_c_Landroid_content_Context_I == IntPtr.Zero)
				id_c_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_c_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='c' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("c", "(I)V", "")]
		public static unsafe void C (int p0)
		{
			if (id_c_I == IntPtr.Zero)
				id_c_I = JNIEnv.GetStaticMethodID (class_ref, "c", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_c_I, __args);
			} finally {
			}
		}

		static IntPtr id_d_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='d' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("d", "(Landroid/content/Context;)V", "")]
		public static unsafe void D (global::Android.Content.Context p0)
		{
			if (id_d_Landroid_content_Context_ == IntPtr.Zero)
				id_d_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_d_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='d' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("d", "(Landroid/content/Context;I)V", "")]
		public static unsafe void D (global::Android.Content.Context p0, int p1)
		{
			if (id_d_Landroid_content_Context_I == IntPtr.Zero)
				id_d_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "d", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_d_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='d' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("d", "(I)V", "")]
		public static unsafe void D (int p0)
		{
			if (id_d_I == IntPtr.Zero)
				id_d_I = JNIEnv.GetStaticMethodID (class_ref, "d", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_I, __args);
			} finally {
			}
		}

		static IntPtr id_e_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='e' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("e", "(Landroid/content/Context;)V", "")]
		public static unsafe void E (global::Android.Content.Context p0)
		{
			if (id_e_Landroid_content_Context_ == IntPtr.Zero)
				id_e_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_f_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='f' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("f", "(Landroid/content/Context;)V", "")]
		public static unsafe void F (global::Android.Content.Context p0)
		{
			if (id_f_Landroid_content_Context_ == IntPtr.Zero)
				id_f_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "f", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_f_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_g_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='g' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("g", "(Landroid/content/Context;)V", "")]
		public static unsafe void G (global::Android.Content.Context p0)
		{
			if (id_g_Landroid_content_Context_ == IntPtr.Zero)
				id_g_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "g", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_g_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_h_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='h' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("h", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool H (global::Android.Content.Context p0)
		{
			if (id_h_Landroid_content_Context_ == IntPtr.Zero)
				id_h_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "h", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_h_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_i_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='i' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("i", "(Landroid/content/Context;)I", "")]
		public static unsafe int I (global::Android.Content.Context p0)
		{
			if (id_i_Landroid_content_Context_ == IntPtr.Zero)
				id_i_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_i_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_j_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='j' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("j", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool J (global::Android.Content.Context p0)
		{
			if (id_j_Landroid_content_Context_ == IntPtr.Zero)
				id_j_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "j", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_j_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
