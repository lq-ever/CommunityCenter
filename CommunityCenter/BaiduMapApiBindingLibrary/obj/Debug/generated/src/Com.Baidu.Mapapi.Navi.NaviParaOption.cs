using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Navi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='NaviParaOption']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/navi/NaviParaOption", DoNotGenerateAcw=true)]
	public partial class NaviParaOption : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/navi/NaviParaOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NaviParaOption); }
		}

		protected NaviParaOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='NaviParaOption']/constructor[@name='NaviParaOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NaviParaOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NaviParaOption)) {
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

		static Delegate cb_getEndName;
#pragma warning disable 0169
		static Delegate GetGetEndNameHandler ()
		{
			if (cb_getEndName == null)
				cb_getEndName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndName);
			return cb_getEndName;
		}

		static IntPtr n_GetEndName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Navi.NaviParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EndName);
		}
#pragma warning restore 0169

		static IntPtr id_getEndName;
		public virtual unsafe string EndName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='NaviParaOption']/method[@name='getEndName' and count(parameter)=0]"
			[Register ("getEndName", "()Ljava/lang/String;", "GetGetEndNameHandler")]
			get {
				if (id_getEndName == IntPtr.Zero)
					id_getEndName = JNIEnv.GetMethodID (class_ref, "getEndName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEndName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEndPoint;
#pragma warning disable 0169
		static Delegate GetGetEndPointHandler ()
		{
			if (cb_getEndPoint == null)
				cb_getEndPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndPoint);
			return cb_getEndPoint;
		}

		static IntPtr n_GetEndPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Navi.NaviParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndPoint);
		}
#pragma warning restore 0169

		static IntPtr id_getEndPoint;
		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng EndPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='NaviParaOption']/method[@name='getEndPoint' and count(parameter)=0]"
			[Register ("getEndPoint", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetEndPointHandler")]
			get {
				if (id_getEndPoint == IntPtr.Zero)
					id_getEndPoint = JNIEnv.GetMethodID (class_ref, "getEndPoint", "()Lcom/baidu/mapapi/model/LatLng;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getEndPoint), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndPoint", "()Lcom/baidu/mapapi/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStartName;
#pragma warning disable 0169
		static Delegate GetGetStartNameHandler ()
		{
			if (cb_getStartName == null)
				cb_getStartName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartName);
			return cb_getStartName;
		}

		static IntPtr n_GetStartName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Navi.NaviParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StartName);
		}
#pragma warning restore 0169

		static IntPtr id_getStartName;
		public virtual unsafe string StartName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='NaviParaOption']/method[@name='getStartName' and count(parameter)=0]"
			[Register ("getStartName", "()Ljava/lang/String;", "GetGetStartNameHandler")]
			get {
				if (id_getStartName == IntPtr.Zero)
					id_getStartName = JNIEnv.GetMethodID (class_ref, "getStartName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStartName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStartPoint;
#pragma warning disable 0169
		static Delegate GetGetStartPointHandler ()
		{
			if (cb_getStartPoint == null)
				cb_getStartPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartPoint);
			return cb_getStartPoint;
		}

		static IntPtr n_GetStartPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Navi.NaviParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartPoint);
		}
#pragma warning restore 0169

		static IntPtr id_getStartPoint;
		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng StartPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='NaviParaOption']/method[@name='getStartPoint' and count(parameter)=0]"
			[Register ("getStartPoint", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetStartPointHandler")]
			get {
				if (id_getStartPoint == IntPtr.Zero)
					id_getStartPoint = JNIEnv.GetMethodID (class_ref, "getStartPoint", "()Lcom/baidu/mapapi/model/LatLng;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getStartPoint), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartPoint", "()Lcom/baidu/mapapi/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_endName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeEndName_Ljava_lang_String_Handler ()
		{
			if (cb_endName_Ljava_lang_String_ == null)
				cb_endName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeEndName_Ljava_lang_String_);
			return cb_endName_Ljava_lang_String_;
		}

		static IntPtr n_InvokeEndName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Navi.NaviParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeEndName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_endName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='NaviParaOption']/method[@name='endName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("endName", "(Ljava/lang/String;)Lcom/baidu/mapapi/navi/NaviParaOption;", "GetInvokeEndName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Navi.NaviParaOption InvokeEndName (string p0)
		{
			if (id_endName_Ljava_lang_String_ == IntPtr.Zero)
				id_endName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "endName", "(Ljava/lang/String;)Lcom/baidu/mapapi/navi/NaviParaOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Navi.NaviParaOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (JNIEnv.CallObjectMethod  (Handle, id_endName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endName", "(Ljava/lang/String;)Lcom/baidu/mapapi/navi/NaviParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_endPoint_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetInvokeEndPoint_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_endPoint_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_endPoint_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeEndPoint_Lcom_baidu_mapapi_model_LatLng_);
			return cb_endPoint_Lcom_baidu_mapapi_model_LatLng_;
		}

		static IntPtr n_InvokeEndPoint_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Navi.NaviParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeEndPoint (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_endPoint_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='NaviParaOption']/method[@name='endPoint' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("endPoint", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/navi/NaviParaOption;", "GetInvokeEndPoint_Lcom_baidu_mapapi_model_LatLng_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Navi.NaviParaOption InvokeEndPoint (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_endPoint_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_endPoint_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "endPoint", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/navi/NaviParaOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Navi.NaviParaOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (JNIEnv.CallObjectMethod  (Handle, id_endPoint_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endPoint", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/navi/NaviParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_startName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeStartName_Ljava_lang_String_Handler ()
		{
			if (cb_startName_Ljava_lang_String_ == null)
				cb_startName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeStartName_Ljava_lang_String_);
			return cb_startName_Ljava_lang_String_;
		}

		static IntPtr n_InvokeStartName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Navi.NaviParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeStartName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='NaviParaOption']/method[@name='startName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startName", "(Ljava/lang/String;)Lcom/baidu/mapapi/navi/NaviParaOption;", "GetInvokeStartName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Navi.NaviParaOption InvokeStartName (string p0)
		{
			if (id_startName_Ljava_lang_String_ == IntPtr.Zero)
				id_startName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startName", "(Ljava/lang/String;)Lcom/baidu/mapapi/navi/NaviParaOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Navi.NaviParaOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (JNIEnv.CallObjectMethod  (Handle, id_startName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startName", "(Ljava/lang/String;)Lcom/baidu/mapapi/navi/NaviParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_startPoint_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetInvokeStartPoint_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_startPoint_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_startPoint_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeStartPoint_Lcom_baidu_mapapi_model_LatLng_);
			return cb_startPoint_Lcom_baidu_mapapi_model_LatLng_;
		}

		static IntPtr n_InvokeStartPoint_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Navi.NaviParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeStartPoint (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startPoint_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.navi']/class[@name='NaviParaOption']/method[@name='startPoint' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("startPoint", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/navi/NaviParaOption;", "GetInvokeStartPoint_Lcom_baidu_mapapi_model_LatLng_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Navi.NaviParaOption InvokeStartPoint (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_startPoint_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_startPoint_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "startPoint", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/navi/NaviParaOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Navi.NaviParaOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (JNIEnv.CallObjectMethod  (Handle, id_startPoint_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Navi.NaviParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startPoint", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/navi/NaviParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
