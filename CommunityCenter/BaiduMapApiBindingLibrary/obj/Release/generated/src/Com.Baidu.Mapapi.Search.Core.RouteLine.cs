using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/core/RouteLine", DoNotGenerateAcw=true)]
	public partial class RouteLine : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/core/RouteLine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RouteLine); }
		}

		protected RouteLine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']/constructor[@name='RouteLine' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RouteLine ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RouteLine)) {
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

		static Delegate cb_getAllStep;
#pragma warning disable 0169
		static Delegate GetGetAllStepHandler ()
		{
			if (cb_getAllStep == null)
				cb_getAllStep = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllStep);
			return cb_getAllStep;
		}

		static IntPtr n_GetAllStep (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.AllStep);
		}
#pragma warning restore 0169

		static IntPtr id_getAllStep;
		public virtual unsafe global::System.Collections.IList AllStep {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']/method[@name='getAllStep' and count(parameter)=0]"
			[Register ("getAllStep", "()Ljava/util/List;", "GetGetAllStepHandler")]
			get {
				if (id_getAllStep == IntPtr.Zero)
					id_getAllStep = JNIEnv.GetMethodID (class_ref, "getAllStep", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAllStep), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllStep", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDistance;
#pragma warning disable 0169
		static Delegate GetGetDistanceHandler ()
		{
			if (cb_getDistance == null)
				cb_getDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDistance);
			return cb_getDistance;
		}

		static int n_GetDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Distance;
		}
#pragma warning restore 0169

		static Delegate cb_setDistance_I;
#pragma warning disable 0169
		static Delegate GetSetDistance_IHandler ()
		{
			if (cb_setDistance_I == null)
				cb_setDistance_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDistance_I);
			return cb_setDistance_I;
		}

		static void n_SetDistance_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Distance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDistance;
		static IntPtr id_setDistance_I;
		public virtual unsafe int Distance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']/method[@name='getDistance' and count(parameter)=0]"
			[Register ("getDistance", "()I", "GetGetDistanceHandler")]
			get {
				if (id_getDistance == IntPtr.Zero)
					id_getDistance = JNIEnv.GetMethodID (class_ref, "getDistance", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDistance);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDistance", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']/method[@name='setDistance' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDistance", "(I)V", "GetSetDistance_IHandler")]
			set {
				if (id_setDistance_I == IntPtr.Zero)
					id_setDistance_I = JNIEnv.GetMethodID (class_ref, "setDistance", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDistance_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDistance", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDuration);
			return cb_getDuration;
		}

		static int n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static Delegate cb_setDuration_I;
#pragma warning disable 0169
		static Delegate GetSetDuration_IHandler ()
		{
			if (cb_setDuration_I == null)
				cb_setDuration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDuration_I);
			return cb_setDuration_I;
		}

		static void n_SetDuration_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Duration = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		static IntPtr id_setDuration_I;
		public virtual unsafe int Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()I", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDuration", "(I)V", "GetSetDuration_IHandler")]
			set {
				if (id_setDuration_I == IntPtr.Zero)
					id_setDuration_I = JNIEnv.GetMethodID (class_ref, "setDuration", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDuration_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuration", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStarting;
#pragma warning disable 0169
		static Delegate GetGetStartingHandler ()
		{
			if (cb_getStarting == null)
				cb_getStarting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStarting);
			return cb_getStarting;
		}

		static IntPtr n_GetStarting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Starting);
		}
#pragma warning restore 0169

		static Delegate cb_setStarting_Lcom_baidu_mapapi_search_core_RouteNode_;
#pragma warning disable 0169
		static Delegate GetSetStarting_Lcom_baidu_mapapi_search_core_RouteNode_Handler ()
		{
			if (cb_setStarting_Lcom_baidu_mapapi_search_core_RouteNode_ == null)
				cb_setStarting_Lcom_baidu_mapapi_search_core_RouteNode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStarting_Lcom_baidu_mapapi_search_core_RouteNode_);
			return cb_setStarting_Lcom_baidu_mapapi_search_core_RouteNode_;
		}

		static void n_SetStarting_Lcom_baidu_mapapi_search_core_RouteNode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Core.RouteNode p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Starting = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStarting;
		static IntPtr id_setStarting_Lcom_baidu_mapapi_search_core_RouteNode_;
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Core.RouteNode Starting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']/method[@name='getStarting' and count(parameter)=0]"
			[Register ("getStarting", "()Lcom/baidu/mapapi/search/core/RouteNode;", "GetGetStartingHandler")]
			get {
				if (id_getStarting == IntPtr.Zero)
					id_getStarting = JNIEnv.GetMethodID (class_ref, "getStarting", "()Lcom/baidu/mapapi/search/core/RouteNode;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallObjectMethod  (Handle, id_getStarting), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStarting", "()Lcom/baidu/mapapi/search/core/RouteNode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']/method[@name='setStarting' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.core.RouteNode']]"
			[Register ("setStarting", "(Lcom/baidu/mapapi/search/core/RouteNode;)V", "GetSetStarting_Lcom_baidu_mapapi_search_core_RouteNode_Handler")]
			set {
				if (id_setStarting_Lcom_baidu_mapapi_search_core_RouteNode_ == IntPtr.Zero)
					id_setStarting_Lcom_baidu_mapapi_search_core_RouteNode_ = JNIEnv.GetMethodID (class_ref, "setStarting", "(Lcom/baidu/mapapi/search/core/RouteNode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setStarting_Lcom_baidu_mapapi_search_core_RouteNode_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStarting", "(Lcom/baidu/mapapi/search/core/RouteNode;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTerminal;
#pragma warning disable 0169
		static Delegate GetGetTerminalHandler ()
		{
			if (cb_getTerminal == null)
				cb_getTerminal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTerminal);
			return cb_getTerminal;
		}

		static IntPtr n_GetTerminal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Terminal);
		}
#pragma warning restore 0169

		static Delegate cb_setTerminal_Lcom_baidu_mapapi_search_core_RouteNode_;
#pragma warning disable 0169
		static Delegate GetSetTerminal_Lcom_baidu_mapapi_search_core_RouteNode_Handler ()
		{
			if (cb_setTerminal_Lcom_baidu_mapapi_search_core_RouteNode_ == null)
				cb_setTerminal_Lcom_baidu_mapapi_search_core_RouteNode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTerminal_Lcom_baidu_mapapi_search_core_RouteNode_);
			return cb_setTerminal_Lcom_baidu_mapapi_search_core_RouteNode_;
		}

		static void n_SetTerminal_Lcom_baidu_mapapi_search_core_RouteNode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Core.RouteNode p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Terminal = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTerminal;
		static IntPtr id_setTerminal_Lcom_baidu_mapapi_search_core_RouteNode_;
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Core.RouteNode Terminal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']/method[@name='getTerminal' and count(parameter)=0]"
			[Register ("getTerminal", "()Lcom/baidu/mapapi/search/core/RouteNode;", "GetGetTerminalHandler")]
			get {
				if (id_getTerminal == IntPtr.Zero)
					id_getTerminal = JNIEnv.GetMethodID (class_ref, "getTerminal", "()Lcom/baidu/mapapi/search/core/RouteNode;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallObjectMethod  (Handle, id_getTerminal), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTerminal", "()Lcom/baidu/mapapi/search/core/RouteNode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']/method[@name='setTerminal' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.core.RouteNode']]"
			[Register ("setTerminal", "(Lcom/baidu/mapapi/search/core/RouteNode;)V", "GetSetTerminal_Lcom_baidu_mapapi_search_core_RouteNode_Handler")]
			set {
				if (id_setTerminal_Lcom_baidu_mapapi_search_core_RouteNode_ == IntPtr.Zero)
					id_setTerminal_Lcom_baidu_mapapi_search_core_RouteNode_ = JNIEnv.GetMethodID (class_ref, "setTerminal", "(Lcom/baidu/mapapi/search/core/RouteNode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTerminal_Lcom_baidu_mapapi_search_core_RouteNode_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTerminal", "(Lcom/baidu/mapapi/search/core/RouteNode;)V"), __args);
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
			global::Com.Baidu.Mapapi.Search.Core.RouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Baidu.Mapapi.Search.Core.RouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']/method[@name='getTitle' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_setSteps_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSteps_Ljava_util_List_Handler ()
		{
			if (cb_setSteps_Ljava_util_List_ == null)
				cb_setSteps_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSteps_Ljava_util_List_);
			return cb_setSteps_Ljava_util_List_;
		}

		static void n_SetSteps_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSteps (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSteps_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteLine']/method[@name='setSteps' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register ("setSteps", "(Ljava/util/List;)V", "GetSetSteps_Ljava_util_List_Handler")]
		public virtual unsafe void SetSteps (global::System.Collections.IList p0)
		{
			if (id_setSteps_Ljava_util_List_ == IntPtr.Zero)
				id_setSteps_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setSteps", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSteps_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSteps", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
