using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Route {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRoutePlanOption']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/WalkingRoutePlanOption", DoNotGenerateAcw=true)]
	public partial class WalkingRoutePlanOption : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/route/WalkingRoutePlanOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WalkingRoutePlanOption); }
		}

		protected WalkingRoutePlanOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRoutePlanOption']/constructor[@name='WalkingRoutePlanOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WalkingRoutePlanOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WalkingRoutePlanOption)) {
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

		static Delegate cb_from_Lcom_baidu_mapapi_search_route_PlanNode_;
#pragma warning disable 0169
		static Delegate GetFrom_Lcom_baidu_mapapi_search_route_PlanNode_Handler ()
		{
			if (cb_from_Lcom_baidu_mapapi_search_route_PlanNode_ == null)
				cb_from_Lcom_baidu_mapapi_search_route_PlanNode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_From_Lcom_baidu_mapapi_search_route_PlanNode_);
			return cb_from_Lcom_baidu_mapapi_search_route_PlanNode_;
		}

		static IntPtr n_From_Lcom_baidu_mapapi_search_route_PlanNode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Route.WalkingRoutePlanOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRoutePlanOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Route.PlanNode p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.PlanNode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.From (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_from_Lcom_baidu_mapapi_search_route_PlanNode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRoutePlanOption']/method[@name='from' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.PlanNode']]"
		[Register ("from", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/WalkingRoutePlanOption;", "GetFrom_Lcom_baidu_mapapi_search_route_PlanNode_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Route.WalkingRoutePlanOption From (global::Com.Baidu.Mapapi.Search.Route.PlanNode p0)
		{
			if (id_from_Lcom_baidu_mapapi_search_route_PlanNode_ == IntPtr.Zero)
				id_from_Lcom_baidu_mapapi_search_route_PlanNode_ = JNIEnv.GetMethodID (class_ref, "from", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/WalkingRoutePlanOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Route.WalkingRoutePlanOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRoutePlanOption> (JNIEnv.CallObjectMethod  (Handle, id_from_Lcom_baidu_mapapi_search_route_PlanNode_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRoutePlanOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "from", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/WalkingRoutePlanOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_to_Lcom_baidu_mapapi_search_route_PlanNode_;
#pragma warning disable 0169
		static Delegate GetTo_Lcom_baidu_mapapi_search_route_PlanNode_Handler ()
		{
			if (cb_to_Lcom_baidu_mapapi_search_route_PlanNode_ == null)
				cb_to_Lcom_baidu_mapapi_search_route_PlanNode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_To_Lcom_baidu_mapapi_search_route_PlanNode_);
			return cb_to_Lcom_baidu_mapapi_search_route_PlanNode_;
		}

		static IntPtr n_To_Lcom_baidu_mapapi_search_route_PlanNode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Route.WalkingRoutePlanOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRoutePlanOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Route.PlanNode p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.PlanNode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.To (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_to_Lcom_baidu_mapapi_search_route_PlanNode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRoutePlanOption']/method[@name='to' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.PlanNode']]"
		[Register ("to", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/WalkingRoutePlanOption;", "GetTo_Lcom_baidu_mapapi_search_route_PlanNode_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Route.WalkingRoutePlanOption To (global::Com.Baidu.Mapapi.Search.Route.PlanNode p0)
		{
			if (id_to_Lcom_baidu_mapapi_search_route_PlanNode_ == IntPtr.Zero)
				id_to_Lcom_baidu_mapapi_search_route_PlanNode_ = JNIEnv.GetMethodID (class_ref, "to", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/WalkingRoutePlanOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Route.WalkingRoutePlanOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRoutePlanOption> (JNIEnv.CallObjectMethod  (Handle, id_to_Lcom_baidu_mapapi_search_route_PlanNode_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRoutePlanOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "to", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/WalkingRoutePlanOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
