using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteNode']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/core/RouteNode", DoNotGenerateAcw=true)]
	public partial class RouteNode : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/core/RouteNode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RouteNode); }
		}

		protected RouteNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteNode']/constructor[@name='RouteNode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RouteNode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RouteNode)) {
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

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteNode __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static Delegate cb_setLocation_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_setLocation_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_setLocation_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Lcom_baidu_mapapi_model_LatLng_);
			return cb_setLocation_Lcom_baidu_mapapi_model_LatLng_;
		}

		static void n_SetLocation_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteNode __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Location = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		static IntPtr id_setLocation_Lcom_baidu_mapapi_model_LatLng_;
		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteNode']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Lcom/baidu/mapapi/model/LatLng;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()Lcom/baidu/mapapi/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteNode']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("setLocation", "(Lcom/baidu/mapapi/model/LatLng;)V", "GetSetLocation_Lcom_baidu_mapapi_model_LatLng_Handler")]
			set {
				if (id_setLocation_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
					id_setLocation_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Lcom/baidu/mapapi/model/LatLng;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLocation_Lcom_baidu_mapapi_model_LatLng_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Lcom/baidu/mapapi/model/LatLng;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteNode __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteNode __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteNode']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteNode']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUid;
#pragma warning disable 0169
		static Delegate GetGetUidHandler ()
		{
			if (cb_getUid == null)
				cb_getUid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUid);
			return cb_getUid;
		}

		static IntPtr n_GetUid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteNode __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uid);
		}
#pragma warning restore 0169

		static Delegate cb_setUid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUid_Ljava_lang_String_Handler ()
		{
			if (cb_setUid_Ljava_lang_String_ == null)
				cb_setUid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUid_Ljava_lang_String_);
			return cb_setUid_Ljava_lang_String_;
		}

		static void n_SetUid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteNode __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Uid = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUid;
		static IntPtr id_setUid_Ljava_lang_String_;
		public virtual unsafe string Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteNode']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()Ljava/lang/String;", "GetGetUidHandler")]
			get {
				if (id_getUid == IntPtr.Zero)
					id_getUid = JNIEnv.GetMethodID (class_ref, "getUid", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUid), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUid", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteNode']/method[@name='setUid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUid", "(Ljava/lang/String;)V", "GetSetUid_Ljava_lang_String_Handler")]
			set {
				if (id_setUid_Ljava_lang_String_ == IntPtr.Zero)
					id_setUid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUid", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUid_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUid", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_location_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteNode']/method[@name='location' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("location", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/core/RouteNode;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Search.Core.RouteNode InvokeLocation (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_location_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_location_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetStaticMethodID (class_ref, "location", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/core/RouteNode;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Baidu.Mapapi.Search.Core.RouteNode __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_location_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_titleAndLocation_Ljava_lang_String_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteNode']/method[@name='titleAndLocation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("titleAndLocation", "(Ljava/lang/String;Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/core/RouteNode;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Search.Core.RouteNode TitleAndLocation (string p0, global::Com.Baidu.Mapapi.Model.LatLng p1)
		{
			if (id_titleAndLocation_Ljava_lang_String_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_titleAndLocation_Ljava_lang_String_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetStaticMethodID (class_ref, "titleAndLocation", "(Ljava/lang/String;Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/core/RouteNode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Baidu.Mapapi.Search.Core.RouteNode __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_titleAndLocation_Ljava_lang_String_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
