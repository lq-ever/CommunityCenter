using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Route {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRouteResult']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/WalkingRouteResult", DoNotGenerateAcw=true)]
	public partial class WalkingRouteResult : global::Com.Baidu.Mapapi.Search.Core.SearchResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/route/WalkingRouteResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WalkingRouteResult); }
		}

		protected WalkingRouteResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getRouteLines;
#pragma warning disable 0169
		static Delegate GetGetRouteLinesHandler ()
		{
			if (cb_getRouteLines == null)
				cb_getRouteLines = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRouteLines);
			return cb_getRouteLines;
		}

		static IntPtr n_GetRouteLines (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine>.ToLocalJniHandle (__this.RouteLines);
		}
#pragma warning restore 0169

		static IntPtr id_getRouteLines;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine> RouteLines {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRouteResult']/method[@name='getRouteLines' and count(parameter)=0]"
			[Register ("getRouteLines", "()Ljava/util/List;", "GetGetRouteLinesHandler")]
			get {
				if (id_getRouteLines == IntPtr.Zero)
					id_getRouteLines = JNIEnv.GetMethodID (class_ref, "getRouteLines", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRouteLines), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRouteLines", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSuggestAddrInfo;
#pragma warning disable 0169
		static Delegate GetGetSuggestAddrInfoHandler ()
		{
			if (cb_getSuggestAddrInfo == null)
				cb_getSuggestAddrInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuggestAddrInfo);
			return cb_getSuggestAddrInfo;
		}

		static IntPtr n_GetSuggestAddrInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SuggestAddrInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getSuggestAddrInfo;
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo SuggestAddrInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRouteResult']/method[@name='getSuggestAddrInfo' and count(parameter)=0]"
			[Register ("getSuggestAddrInfo", "()Lcom/baidu/mapapi/search/route/SuggestAddrInfo;", "GetGetSuggestAddrInfoHandler")]
			get {
				if (id_getSuggestAddrInfo == IntPtr.Zero)
					id_getSuggestAddrInfo = JNIEnv.GetMethodID (class_ref, "getSuggestAddrInfo", "()Lcom/baidu/mapapi/search/route/SuggestAddrInfo;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo> (JNIEnv.CallObjectMethod  (Handle, id_getSuggestAddrInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuggestAddrInfo", "()Lcom/baidu/mapapi/search/route/SuggestAddrInfo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTaxiInfo;
#pragma warning disable 0169
		static Delegate GetGetTaxiInfoHandler ()
		{
			if (cb_getTaxiInfo == null)
				cb_getTaxiInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTaxiInfo);
			return cb_getTaxiInfo;
		}

		static IntPtr n_GetTaxiInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TaxiInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getTaxiInfo;
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Core.TaxiInfo TaxiInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRouteResult']/method[@name='getTaxiInfo' and count(parameter)=0]"
			[Register ("getTaxiInfo", "()Lcom/baidu/mapapi/search/core/TaxiInfo;", "GetGetTaxiInfoHandler")]
			get {
				if (id_getTaxiInfo == IntPtr.Zero)
					id_getTaxiInfo = JNIEnv.GetMethodID (class_ref, "getTaxiInfo", "()Lcom/baidu/mapapi/search/core/TaxiInfo;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (JNIEnv.CallObjectMethod  (Handle, id_getTaxiInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaxiInfo", "()Lcom/baidu/mapapi/search/core/TaxiInfo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
