using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Route {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='RoutePlanSearch']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/RoutePlanSearch", DoNotGenerateAcw=true)]
	public sealed partial class RoutePlanSearch : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/route/RoutePlanSearch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RoutePlanSearch); }
		}

		internal RoutePlanSearch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='RoutePlanSearch']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "")]
		public unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_destroy);
			} finally {
			}
		}

		static IntPtr id_drivingSearch_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='RoutePlanSearch']/method[@name='drivingSearch' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.DrivingRoutePlanOption']]"
		[Register ("drivingSearch", "(Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;)Z", "")]
		public unsafe bool DrivingSearch (global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption p0)
		{
			if (id_drivingSearch_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_ == IntPtr.Zero)
				id_drivingSearch_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_ = JNIEnv.GetMethodID (class_ref, "drivingSearch", "(Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_drivingSearch_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='RoutePlanSearch']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/baidu/mapapi/search/route/RoutePlanSearch;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Search.Route.RoutePlanSearch NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/baidu/mapapi/search/route/RoutePlanSearch;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.RoutePlanSearch> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setOnGetRoutePlanResultListener_Lcom_baidu_mapapi_search_route_OnGetRoutePlanResultListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='RoutePlanSearch']/method[@name='setOnGetRoutePlanResultListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.OnGetRoutePlanResultListener']]"
		[Register ("setOnGetRoutePlanResultListener", "(Lcom/baidu/mapapi/search/route/OnGetRoutePlanResultListener;)V", "")]
		public unsafe void SetOnGetRoutePlanResultListener (global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener p0)
		{
			if (id_setOnGetRoutePlanResultListener_Lcom_baidu_mapapi_search_route_OnGetRoutePlanResultListener_ == IntPtr.Zero)
				id_setOnGetRoutePlanResultListener_Lcom_baidu_mapapi_search_route_OnGetRoutePlanResultListener_ = JNIEnv.GetMethodID (class_ref, "setOnGetRoutePlanResultListener", "(Lcom/baidu/mapapi/search/route/OnGetRoutePlanResultListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setOnGetRoutePlanResultListener_Lcom_baidu_mapapi_search_route_OnGetRoutePlanResultListener_, __args);
			} finally {
			}
		}

		static IntPtr id_transitSearch_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='RoutePlanSearch']/method[@name='transitSearch' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.TransitRoutePlanOption']]"
		[Register ("transitSearch", "(Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;)Z", "")]
		public unsafe bool TransitSearch (global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption p0)
		{
			if (id_transitSearch_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_ == IntPtr.Zero)
				id_transitSearch_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_ = JNIEnv.GetMethodID (class_ref, "transitSearch", "(Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_transitSearch_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_walkingSearch_Lcom_baidu_mapapi_search_route_WalkingRoutePlanOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='RoutePlanSearch']/method[@name='walkingSearch' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.WalkingRoutePlanOption']]"
		[Register ("walkingSearch", "(Lcom/baidu/mapapi/search/route/WalkingRoutePlanOption;)Z", "")]
		public unsafe bool WalkingSearch (global::Com.Baidu.Mapapi.Search.Route.WalkingRoutePlanOption p0)
		{
			if (id_walkingSearch_Lcom_baidu_mapapi_search_route_WalkingRoutePlanOption_ == IntPtr.Zero)
				id_walkingSearch_Lcom_baidu_mapapi_search_route_WalkingRoutePlanOption_ = JNIEnv.GetMethodID (class_ref, "walkingSearch", "(Lcom/baidu/mapapi/search/route/WalkingRoutePlanOption;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_walkingSearch_Lcom_baidu_mapapi_search_route_WalkingRoutePlanOption_, __args);
				return __ret;
			} finally {
			}
		}

#region "Event implementation for Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Search.Route.GetDrivingRouteResultEventArgs> GetDrivingRouteResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener, global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerImplementor>(
						ref weak_implementor_SetOnGetRoutePlanResultListener,
						__CreateIOnGetRoutePlanResultListenerImplementor,
						SetOnGetRoutePlanResultListener,
						__h => __h.OnGetDrivingRouteResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener, global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerImplementor>(
						ref weak_implementor_SetOnGetRoutePlanResultListener,
						global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerImplementor.__IsEmpty,
						__v => SetOnGetRoutePlanResultListener (null),
						__h => __h.OnGetDrivingRouteResultHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Search.Route.GetTransitRouteResultEventArgs> GetTransitRouteResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener, global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerImplementor>(
						ref weak_implementor_SetOnGetRoutePlanResultListener,
						__CreateIOnGetRoutePlanResultListenerImplementor,
						SetOnGetRoutePlanResultListener,
						__h => __h.OnGetTransitRouteResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener, global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerImplementor>(
						ref weak_implementor_SetOnGetRoutePlanResultListener,
						global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerImplementor.__IsEmpty,
						__v => SetOnGetRoutePlanResultListener (null),
						__h => __h.OnGetTransitRouteResultHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Search.Route.GetWalkingRouteResultEventArgs> GetWalkingRouteResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener, global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerImplementor>(
						ref weak_implementor_SetOnGetRoutePlanResultListener,
						__CreateIOnGetRoutePlanResultListenerImplementor,
						SetOnGetRoutePlanResultListener,
						__h => __h.OnGetWalkingRouteResultHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener, global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerImplementor>(
						ref weak_implementor_SetOnGetRoutePlanResultListener,
						global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerImplementor.__IsEmpty,
						__v => SetOnGetRoutePlanResultListener (null),
						__h => __h.OnGetWalkingRouteResultHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnGetRoutePlanResultListener;

		global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerImplementor __CreateIOnGetRoutePlanResultListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerImplementor (this);
		}
#endregion
	}
}
