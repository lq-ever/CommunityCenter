using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Route {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteResult']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/DrivingRouteResult", DoNotGenerateAcw=true)]
	public sealed partial class DrivingRouteResult : global::Com.Baidu.Mapapi.Search.Core.SearchResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/route/DrivingRouteResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrivingRouteResult); }
		}

		internal DrivingRouteResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getRouteLines;
		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine> RouteLines {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteResult']/method[@name='getRouteLines' and count(parameter)=0]"
			[Register ("getRouteLines", "()Ljava/util/List;", "GetGetRouteLinesHandler")]
			get {
				if (id_getRouteLines == IntPtr.Zero)
					id_getRouteLines = JNIEnv.GetMethodID (class_ref, "getRouteLines", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRouteLines), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSuggestAddrInfo;
		public unsafe global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo SuggestAddrInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteResult']/method[@name='getSuggestAddrInfo' and count(parameter)=0]"
			[Register ("getSuggestAddrInfo", "()Lcom/baidu/mapapi/search/route/SuggestAddrInfo;", "GetGetSuggestAddrInfoHandler")]
			get {
				if (id_getSuggestAddrInfo == IntPtr.Zero)
					id_getSuggestAddrInfo = JNIEnv.GetMethodID (class_ref, "getSuggestAddrInfo", "()Lcom/baidu/mapapi/search/route/SuggestAddrInfo;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo> (JNIEnv.CallObjectMethod  (Handle, id_getSuggestAddrInfo), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTaxiInfo;
		public unsafe global::Com.Baidu.Mapapi.Search.Core.TaxiInfo TaxiInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteResult']/method[@name='getTaxiInfo' and count(parameter)=0]"
			[Register ("getTaxiInfo", "()Lcom/baidu/mapapi/search/core/TaxiInfo;", "GetGetTaxiInfoHandler")]
			get {
				if (id_getTaxiInfo == IntPtr.Zero)
					id_getTaxiInfo = JNIEnv.GetMethodID (class_ref, "getTaxiInfo", "()Lcom/baidu/mapapi/search/core/TaxiInfo;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (JNIEnv.CallObjectMethod  (Handle, id_getTaxiInfo), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
