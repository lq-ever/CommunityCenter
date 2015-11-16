using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Route {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.search.route']/interface[@name='OnGetRoutePlanResultListener']"
	[Register ("com/baidu/mapapi/search/route/OnGetRoutePlanResultListener", "", "Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerInvoker")]
	public partial interface IOnGetRoutePlanResultListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/interface[@name='OnGetRoutePlanResultListener']/method[@name='onGetDrivingRouteResult' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.DrivingRouteResult']]"
		[Register ("onGetDrivingRouteResult", "(Lcom/baidu/mapapi/search/route/DrivingRouteResult;)V", "GetOnGetDrivingRouteResult_Lcom_baidu_mapapi_search_route_DrivingRouteResult_Handler:Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetDrivingRouteResult (global::Com.Baidu.Mapapi.Search.Route.DrivingRouteResult p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/interface[@name='OnGetRoutePlanResultListener']/method[@name='onGetTransitRouteResult' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.TransitRouteResult']]"
		[Register ("onGetTransitRouteResult", "(Lcom/baidu/mapapi/search/route/TransitRouteResult;)V", "GetOnGetTransitRouteResult_Lcom_baidu_mapapi_search_route_TransitRouteResult_Handler:Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetTransitRouteResult (global::Com.Baidu.Mapapi.Search.Route.TransitRouteResult p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/interface[@name='OnGetRoutePlanResultListener']/method[@name='onGetWalkingRouteResult' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.WalkingRouteResult']]"
		[Register ("onGetWalkingRouteResult", "(Lcom/baidu/mapapi/search/route/WalkingRouteResult;)V", "GetOnGetWalkingRouteResult_Lcom_baidu_mapapi_search_route_WalkingRouteResult_Handler:Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetWalkingRouteResult (global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult p0);

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/OnGetRoutePlanResultListener", DoNotGenerateAcw=true)]
	internal class IOnGetRoutePlanResultListenerInvoker : global::Java.Lang.Object, IOnGetRoutePlanResultListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/search/route/OnGetRoutePlanResultListener");
		IntPtr class_ref;

		public static IOnGetRoutePlanResultListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnGetRoutePlanResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.search.route.OnGetRoutePlanResultListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnGetRoutePlanResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnGetRoutePlanResultListenerInvoker); }
		}

		static Delegate cb_onGetDrivingRouteResult_Lcom_baidu_mapapi_search_route_DrivingRouteResult_;
#pragma warning disable 0169
		static Delegate GetOnGetDrivingRouteResult_Lcom_baidu_mapapi_search_route_DrivingRouteResult_Handler ()
		{
			if (cb_onGetDrivingRouteResult_Lcom_baidu_mapapi_search_route_DrivingRouteResult_ == null)
				cb_onGetDrivingRouteResult_Lcom_baidu_mapapi_search_route_DrivingRouteResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetDrivingRouteResult_Lcom_baidu_mapapi_search_route_DrivingRouteResult_);
			return cb_onGetDrivingRouteResult_Lcom_baidu_mapapi_search_route_DrivingRouteResult_;
		}

		static void n_OnGetDrivingRouteResult_Lcom_baidu_mapapi_search_route_DrivingRouteResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Route.DrivingRouteResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRouteResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetDrivingRouteResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGetDrivingRouteResult_Lcom_baidu_mapapi_search_route_DrivingRouteResult_;
		public unsafe void OnGetDrivingRouteResult (global::Com.Baidu.Mapapi.Search.Route.DrivingRouteResult p0)
		{
			if (id_onGetDrivingRouteResult_Lcom_baidu_mapapi_search_route_DrivingRouteResult_ == IntPtr.Zero)
				id_onGetDrivingRouteResult_Lcom_baidu_mapapi_search_route_DrivingRouteResult_ = JNIEnv.GetMethodID (class_ref, "onGetDrivingRouteResult", "(Lcom/baidu/mapapi/search/route/DrivingRouteResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onGetDrivingRouteResult_Lcom_baidu_mapapi_search_route_DrivingRouteResult_, __args);
		}

		static Delegate cb_onGetTransitRouteResult_Lcom_baidu_mapapi_search_route_TransitRouteResult_;
#pragma warning disable 0169
		static Delegate GetOnGetTransitRouteResult_Lcom_baidu_mapapi_search_route_TransitRouteResult_Handler ()
		{
			if (cb_onGetTransitRouteResult_Lcom_baidu_mapapi_search_route_TransitRouteResult_ == null)
				cb_onGetTransitRouteResult_Lcom_baidu_mapapi_search_route_TransitRouteResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetTransitRouteResult_Lcom_baidu_mapapi_search_route_TransitRouteResult_);
			return cb_onGetTransitRouteResult_Lcom_baidu_mapapi_search_route_TransitRouteResult_;
		}

		static void n_OnGetTransitRouteResult_Lcom_baidu_mapapi_search_route_TransitRouteResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Route.TransitRouteResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRouteResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetTransitRouteResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGetTransitRouteResult_Lcom_baidu_mapapi_search_route_TransitRouteResult_;
		public unsafe void OnGetTransitRouteResult (global::Com.Baidu.Mapapi.Search.Route.TransitRouteResult p0)
		{
			if (id_onGetTransitRouteResult_Lcom_baidu_mapapi_search_route_TransitRouteResult_ == IntPtr.Zero)
				id_onGetTransitRouteResult_Lcom_baidu_mapapi_search_route_TransitRouteResult_ = JNIEnv.GetMethodID (class_ref, "onGetTransitRouteResult", "(Lcom/baidu/mapapi/search/route/TransitRouteResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onGetTransitRouteResult_Lcom_baidu_mapapi_search_route_TransitRouteResult_, __args);
		}

		static Delegate cb_onGetWalkingRouteResult_Lcom_baidu_mapapi_search_route_WalkingRouteResult_;
#pragma warning disable 0169
		static Delegate GetOnGetWalkingRouteResult_Lcom_baidu_mapapi_search_route_WalkingRouteResult_Handler ()
		{
			if (cb_onGetWalkingRouteResult_Lcom_baidu_mapapi_search_route_WalkingRouteResult_ == null)
				cb_onGetWalkingRouteResult_Lcom_baidu_mapapi_search_route_WalkingRouteResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetWalkingRouteResult_Lcom_baidu_mapapi_search_route_WalkingRouteResult_);
			return cb_onGetWalkingRouteResult_Lcom_baidu_mapapi_search_route_WalkingRouteResult_;
		}

		static void n_OnGetWalkingRouteResult_Lcom_baidu_mapapi_search_route_WalkingRouteResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.IOnGetRoutePlanResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetWalkingRouteResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGetWalkingRouteResult_Lcom_baidu_mapapi_search_route_WalkingRouteResult_;
		public unsafe void OnGetWalkingRouteResult (global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult p0)
		{
			if (id_onGetWalkingRouteResult_Lcom_baidu_mapapi_search_route_WalkingRouteResult_ == IntPtr.Zero)
				id_onGetWalkingRouteResult_Lcom_baidu_mapapi_search_route_WalkingRouteResult_ = JNIEnv.GetMethodID (class_ref, "onGetWalkingRouteResult", "(Lcom/baidu/mapapi/search/route/WalkingRouteResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onGetWalkingRouteResult_Lcom_baidu_mapapi_search_route_WalkingRouteResult_, __args);
		}

	}

	public partial class GetDrivingRouteResultEventArgs : global::System.EventArgs {

		public GetDrivingRouteResultEventArgs (global::Com.Baidu.Mapapi.Search.Route.DrivingRouteResult p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Mapapi.Search.Route.DrivingRouteResult p0;
		public global::Com.Baidu.Mapapi.Search.Route.DrivingRouteResult P0 {
			get { return p0; }
		}
	}

	public partial class GetTransitRouteResultEventArgs : global::System.EventArgs {

		public GetTransitRouteResultEventArgs (global::Com.Baidu.Mapapi.Search.Route.TransitRouteResult p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Mapapi.Search.Route.TransitRouteResult p0;
		public global::Com.Baidu.Mapapi.Search.Route.TransitRouteResult P0 {
			get { return p0; }
		}
	}

	public partial class GetWalkingRouteResultEventArgs : global::System.EventArgs {

		public GetWalkingRouteResultEventArgs (global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult p0;
		public global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/baidu/mapapi/search/route/OnGetRoutePlanResultListenerImplementor")]
	internal sealed partial class IOnGetRoutePlanResultListenerImplementor : global::Java.Lang.Object, IOnGetRoutePlanResultListener {

		object sender;

		public IOnGetRoutePlanResultListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/search/route/OnGetRoutePlanResultListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GetDrivingRouteResultEventArgs> OnGetDrivingRouteResultHandler;
#pragma warning restore 0649

		public void OnGetDrivingRouteResult (global::Com.Baidu.Mapapi.Search.Route.DrivingRouteResult p0)
		{
			var __h = OnGetDrivingRouteResultHandler;
			if (__h != null)
				__h (sender, new GetDrivingRouteResultEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<GetTransitRouteResultEventArgs> OnGetTransitRouteResultHandler;
#pragma warning restore 0649

		public void OnGetTransitRouteResult (global::Com.Baidu.Mapapi.Search.Route.TransitRouteResult p0)
		{
			var __h = OnGetTransitRouteResultHandler;
			if (__h != null)
				__h (sender, new GetTransitRouteResultEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<GetWalkingRouteResultEventArgs> OnGetWalkingRouteResultHandler;
#pragma warning restore 0649

		public void OnGetWalkingRouteResult (global::Com.Baidu.Mapapi.Search.Route.WalkingRouteResult p0)
		{
			var __h = OnGetWalkingRouteResultHandler;
			if (__h != null)
				__h (sender, new GetWalkingRouteResultEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnGetRoutePlanResultListenerImplementor value)
		{
			return value.OnGetDrivingRouteResultHandler == null && value.OnGetTransitRouteResultHandler == null && value.OnGetWalkingRouteResultHandler == null;
		}
	}

}
