using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']"
	[global::Android.Runtime.Register ("cn/jpush/android/service/PushService", DoNotGenerateAcw=true)]
	public partial class PushService : global::Android.App.Service {


		static IntPtr h_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='h']"
		[Register ("h")]
		public static long H {
			get {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "J");
				return JNIEnv.GetStaticLongField (class_ref, h_jfieldId);
			}
			set {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "J");
				try {
					JNIEnv.SetStaticField (class_ref, h_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr i_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='i']"
		[Register ("i")]
		public static int I {
			get {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "i", "I");
				return JNIEnv.GetStaticIntField (class_ref, i_jfieldId);
			}
			set {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "i", "I");
				try {
					JNIEnv.SetStaticField (class_ref, i_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr j_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='j']"
		[Register ("j")]
		public static long J {
			get {
				if (j_jfieldId == IntPtr.Zero)
					j_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j", "J");
				return JNIEnv.GetStaticLongField (class_ref, j_jfieldId);
			}
			set {
				if (j_jfieldId == IntPtr.Zero)
					j_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j", "J");
				try {
					JNIEnv.SetStaticField (class_ref, j_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr k_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='k']"
		[Register ("k")]
		public static long K {
			get {
				if (k_jfieldId == IntPtr.Zero)
					k_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "k", "J");
				return JNIEnv.GetStaticLongField (class_ref, k_jfieldId);
			}
			set {
				if (k_jfieldId == IntPtr.Zero)
					k_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "k", "J");
				try {
					JNIEnv.SetStaticField (class_ref, k_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr l_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='l']"
		[Register ("l")]
		public static long L {
			get {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "l", "J");
				return JNIEnv.GetStaticLongField (class_ref, l_jfieldId);
			}
			set {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "l", "J");
				try {
					JNIEnv.SetStaticField (class_ref, l_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='m']"
		[Register ("m")]
		public static long M {
			get {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "m", "J");
				return JNIEnv.GetStaticLongField (class_ref, m_jfieldId);
			}
			set {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "m", "J");
				try {
					JNIEnv.SetStaticField (class_ref, m_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr n_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='n']"
		[Register ("n")]
		public static long N {
			get {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "n", "J");
				return JNIEnv.GetStaticLongField (class_ref, n_jfieldId);
			}
			set {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "n", "J");
				try {
					JNIEnv.SetStaticField (class_ref, n_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr o_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='o']"
		[Register ("o")]
		public static string O {
			get {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "o", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, o_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "o", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, o_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr p_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='p']"
		[Register ("p")]
		public static int P {
			get {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "p", "I");
				return JNIEnv.GetStaticIntField (class_ref, p_jfieldId);
			}
			set {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "p", "I");
				try {
					JNIEnv.SetStaticField (class_ref, p_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr q_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='q']"
		[Register ("q")]
		public static string Q {
			get {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "q", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, q_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "q", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, q_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr r_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='r']"
		[Register ("r")]
		public static bool R {
			get {
				if (r_jfieldId == IntPtr.Zero)
					r_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "r", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, r_jfieldId);
			}
			set {
				if (r_jfieldId == IntPtr.Zero)
					r_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "r", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, r_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr s_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='s']"
		[Register ("s")]
		public static bool S {
			get {
				if (s_jfieldId == IntPtr.Zero)
					s_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "s", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, s_jfieldId);
			}
			set {
				if (s_jfieldId == IntPtr.Zero)
					s_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "s", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, s_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr t_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='t']"
		[Register ("t")]
		protected static long T {
			get {
				if (t_jfieldId == IntPtr.Zero)
					t_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "t", "J");
				return JNIEnv.GetStaticLongField (class_ref, t_jfieldId);
			}
			set {
				if (t_jfieldId == IntPtr.Zero)
					t_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "t", "J");
				try {
					JNIEnv.SetStaticField (class_ref, t_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr u_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='u']"
		[Register ("u")]
		protected static string U {
			get {
				if (u_jfieldId == IntPtr.Zero)
					u_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "u", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, u_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (u_jfieldId == IntPtr.Zero)
					u_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "u", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, u_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr v_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='v']"
		[Register ("v")]
		protected static string V {
			get {
				if (v_jfieldId == IntPtr.Zero)
					v_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "v", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, v_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (v_jfieldId == IntPtr.Zero)
					v_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "v", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, v_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr w_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='w']"
		[Register ("w")]
		protected long W {
			get {
				if (w_jfieldId == IntPtr.Zero)
					w_jfieldId = JNIEnv.GetFieldID (class_ref, "w", "J");
				return JNIEnv.GetLongField (Handle, w_jfieldId);
			}
			set {
				if (w_jfieldId == IntPtr.Zero)
					w_jfieldId = JNIEnv.GetFieldID (class_ref, "w", "J");
				try {
					JNIEnv.SetField (Handle, w_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/field[@name='x']"
		[Register ("x")]
		protected IList<byte> X {
			get {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, x_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, x_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/service/PushService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushService); }
		}

		protected PushService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/constructor[@name='PushService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PushService)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='a' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)J", "")]
		public static unsafe long A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_a_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "")]
		public static unsafe void A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetStaticMethodID (class_ref, "a", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Z, __args);
			} finally {
			}
		}

		static IntPtr id_a_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)V", "")]
		public static unsafe void A (int p0)
		{
			if (id_a_I == IntPtr.Zero)
				id_a_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_I, __args);
			} finally {
			}
		}

		static IntPtr id_a_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='a' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(ILjava/lang/String;)V", "")]
		protected unsafe void A (int p0, string p1)
		{
			if (id_a_ILjava_lang_String_ == IntPtr.Zero)
				id_a_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_a_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='b' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("b", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string B (global::Android.Content.Context p0)
		{
			if (id_b_Landroid_content_Context_ == IntPtr.Zero)
				id_b_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_b_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='b' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("b", "(Z)V", "")]
		public static unsafe void B (bool p0)
		{
			if (id_b_Z == IntPtr.Zero)
				id_b_Z = JNIEnv.GetStaticMethodID (class_ref, "b", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Z, __args);
			} finally {
			}
		}

		static IntPtr id_b_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='b' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("b", "(I)V", "")]
		public static unsafe void B (int p0)
		{
			if (id_b_I == IntPtr.Zero)
				id_b_I = JNIEnv.GetStaticMethodID (class_ref, "b", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_b_I, __args);
			} finally {
			}
		}

		static IntPtr id_b_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "")]
		public static unsafe bool C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetStaticMethodID (class_ref, "c", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_c);
			} finally {
			}
		}

		static IntPtr id_c_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("c", "(Landroid/content/Context;)Z", "")]
		protected static unsafe bool C (global::Android.Content.Context p0)
		{
			if (id_c_Landroid_content_Context_ == IntPtr.Zero)
				id_c_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_c_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_c_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='c' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("c", "(Z)V", "")]
		public static unsafe void C (bool p0)
		{
			if (id_c_Z == IntPtr.Zero)
				id_c_Z = JNIEnv.GetStaticMethodID (class_ref, "c", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Z, __args);
			} finally {
			}
		}

		static IntPtr id_c_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='c' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static IntPtr id_c_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("c", "(Ljava/lang/String;)V", "")]
		public static unsafe void C (string p0)
		{
			if (id_c_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()V", "")]
		protected unsafe void D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_d);
			} finally {
			}
		}

		static IntPtr id_d_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='d' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("d", "(Z)V", "")]
		public static unsafe void D (bool p0)
		{
			if (id_d_Z == IntPtr.Zero)
				id_d_Z = JNIEnv.GetStaticMethodID (class_ref, "d", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Z, __args);
			} finally {
			}
		}

		static IntPtr id_d_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='d' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static IntPtr id_d_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;)V", "")]
		public static unsafe void D (string p0)
		{
			if (id_d_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()V", "")]
		protected unsafe void E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_e);
			} finally {
			}
		}

		static IntPtr id_e_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='e' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("e", "(Z)V", "")]
		public unsafe void E (bool p0)
		{
			if (id_e_Z == IntPtr.Zero)
				id_e_Z = JNIEnv.GetMethodID (class_ref, "e", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_e_Z, __args);
			} finally {
			}
		}

		static IntPtr id_e_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='e' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("e", "(I)V", "")]
		protected unsafe void E (int p0)
		{
			if (id_e_I == IntPtr.Zero)
				id_e_I = JNIEnv.GetMethodID (class_ref, "e", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_e_I, __args);
			} finally {
			}
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()V", "")]
		protected unsafe void F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_f);
			} finally {
			}
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()V", "")]
		protected unsafe void G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_g);
			} finally {
			}
		}

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Service.PushService __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.PushService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.OS.IBinder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_onBind_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
