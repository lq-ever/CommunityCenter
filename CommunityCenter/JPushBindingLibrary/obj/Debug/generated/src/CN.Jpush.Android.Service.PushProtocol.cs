using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']"
	[global::Android.Runtime.Register ("cn/jpush/android/service/PushProtocol", DoNotGenerateAcw=true)]
	public partial class PushProtocol : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/service/PushProtocol", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushProtocol); }
		}

		protected PushProtocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_GetSdkVersion;
		public static unsafe int SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='GetSdkVersion' and count(parameter)=0]"
			[Register ("GetSdkVersion", "()I", "GetGetSdkVersionHandler")]
			get {
				if (id_GetSdkVersion == IntPtr.Zero)
					id_GetSdkVersion = JNIEnv.GetStaticMethodID (class_ref, "GetSdkVersion", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_GetSdkVersion);
				} finally {
				}
			}
		}

		static IntPtr id_Close_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='Close' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Close", "(J)I", "")]
		public static unsafe int Close (long p0)
		{
			if (id_Close_J == IntPtr.Zero)
				id_Close_J = JNIEnv.GetStaticMethodID (class_ref, "Close", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_Close_J, __args);
			} finally {
			}
		}

		static IntPtr id_EnChannel_JJLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='EnChannel' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("EnChannel", "(JJLjava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int EnChannel (long p0, long p1, string p2, string p3)
		{
			if (id_EnChannel_JJLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_EnChannel_JJLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "EnChannel", "(JJLjava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_EnChannel_JJLjava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_GetEsg_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='GetEsg' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("GetEsg", "(J)Ljava/lang/String;", "")]
		public static unsafe string GetEsg (long p0)
		{
			if (id_GetEsg_J == IntPtr.Zero)
				id_GetEsg_J = JNIEnv.GetStaticMethodID (class_ref, "GetEsg", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_GetEsg_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_HbJPush_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='HbJPush' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("HbJPush", "(JJ)I", "")]
		public static unsafe int HbJPush (long p0, long p1)
		{
			if (id_HbJPush_JJ == IntPtr.Zero)
				id_HbJPush_JJ = JNIEnv.GetStaticMethodID (class_ref, "HbJPush", "(JJ)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_HbJPush_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_InitConn;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='InitConn' and count(parameter)=0]"
		[Register ("InitConn", "()J", "")]
		public static unsafe long InitConn ()
		{
			if (id_InitConn == IntPtr.Zero)
				id_InitConn = JNIEnv.GetStaticMethodID (class_ref, "InitConn", "()J");
			try {
				return JNIEnv.CallStaticLongMethod  (class_ref, id_InitConn);
			} finally {
			}
		}

		static IntPtr id_InitPush_JLjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='InitPush' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("InitPush", "(JLjava/lang/String;I)I", "")]
		public static unsafe int InitPush (long p0, string p1, int p2)
		{
			if (id_InitPush_JLjava_lang_String_I == IntPtr.Zero)
				id_InitPush_JLjava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "InitPush", "(JLjava/lang/String;I)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_InitPush_JLjava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_LogPushWithBack_JarrayBJLjava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='LogPushWithBack' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='long']]"
		[Register ("LogPushWithBack", "(J[BJLjava/lang/String;Ljava/lang/String;J)I", "")]
		public static unsafe int LogPushWithBack (long p0, byte[] p1, long p2, string p3, string p4, long p5)
		{
			if (id_LogPushWithBack_JarrayBJLjava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_LogPushWithBack_JarrayBJLjava_lang_String_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "LogPushWithBack", "(J[BJLjava/lang/String;Ljava/lang/String;J)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_LogPushWithBack_JarrayBJLjava_lang_String_Ljava_lang_String_J, __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_MsgResponse_JIJBJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='MsgResponse' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='byte'] and parameter[5][@type='long']]"
		[Register ("MsgResponse", "(JIJBJ)I", "")]
		public static unsafe int MsgResponse (long p0, int p1, long p2, sbyte p3, long p4)
		{
			if (id_MsgResponse_JIJBJ == IntPtr.Zero)
				id_MsgResponse_JIJBJ = JNIEnv.GetStaticMethodID (class_ref, "MsgResponse", "(JIJBJ)I");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_MsgResponse_JIJBJ, __args);
			} finally {
			}
		}

		static IntPtr id_PushTime_JJLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='PushTime' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("PushTime", "(JJLjava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int PushTime (long p0, long p1, string p2, string p3)
		{
			if (id_PushTime_JJLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_PushTime_JJLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PushTime", "(JJLjava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_PushTime_JJLjava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_RecvPush_JarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='RecvPush' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("RecvPush", "(J[BI)I", "")]
		public static unsafe int RecvPush (long p0, byte[] p1, int p2)
		{
			if (id_RecvPush_JarrayBI == IntPtr.Zero)
				id_RecvPush_JarrayBI = JNIEnv.GetStaticMethodID (class_ref, "RecvPush", "(J[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_RecvPush_JarrayBI, __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_RegPush_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='RegPush' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("RegPush", "(JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int RegPush (long p0, string p1, string p2, string p3, string p4)
		{
			if (id_RegPush_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_RegPush_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "RegPush", "(JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_RegPush_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_RepPush_JJBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='RepPush' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='byte'] and parameter[4][@type='java.lang.String']]"
		[Register ("RepPush", "(JJBLjava/lang/String;)I", "")]
		public static unsafe int RepPush (long p0, long p1, sbyte p2, string p3)
		{
			if (id_RepPush_JJBLjava_lang_String_ == IntPtr.Zero)
				id_RepPush_JJBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "RepPush", "(JJBLjava/lang/String;)I");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_RepPush_JJBLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_Stop_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='Stop' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Stop", "(J)I", "")]
		public static unsafe int Stop (long p0)
		{
			if (id_Stop_J == IntPtr.Zero)
				id_Stop_J = JNIEnv.GetStaticMethodID (class_ref, "Stop", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_Stop_J, __args);
			} finally {
			}
		}

		static IntPtr id_TagAlias_JJLjava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='TagAlias' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register ("TagAlias", "(JJLjava/lang/String;Ljava/lang/String;I)I", "")]
		public static unsafe int TagAlias (long p0, long p1, string p2, string p3, int p4)
		{
			if (id_TagAlias_JJLjava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_TagAlias_JJLjava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "TagAlias", "(JJLjava/lang/String;Ljava/lang/String;I)I");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_TagAlias_JJLjava_lang_String_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_UnChnelId_JJLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='PushProtocol']/method[@name='UnChnelId' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("UnChnelId", "(JJLjava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int UnChnelId (long p0, long p1, string p2, string p3)
		{
			if (id_UnChnelId_JJLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_UnChnelId_JJLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "UnChnelId", "(JJLjava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_UnChnelId_JJLjava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
