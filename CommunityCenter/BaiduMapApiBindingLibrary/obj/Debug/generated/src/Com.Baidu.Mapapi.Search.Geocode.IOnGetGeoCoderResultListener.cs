using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Geocode {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/interface[@name='OnGetGeoCoderResultListener']"
	[Register ("com/baidu/mapapi/search/geocode/OnGetGeoCoderResultListener", "", "Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListenerInvoker")]
	public partial interface IOnGetGeoCoderResultListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/interface[@name='OnGetGeoCoderResultListener']/method[@name='onGetGeoCodeResult' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.geocode.GeoCodeResult']]"
		[Register ("onGetGeoCodeResult", "(Lcom/baidu/mapapi/search/geocode/GeoCodeResult;)V", "GetOnGetGeoCodeResult_Lcom_baidu_mapapi_search_geocode_GeoCodeResult_Handler:Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetGeoCodeResult (global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/interface[@name='OnGetGeoCoderResultListener']/method[@name='onGetReverseGeoCodeResult' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.geocode.ReverseGeoCodeResult']]"
		[Register ("onGetReverseGeoCodeResult", "(Lcom/baidu/mapapi/search/geocode/ReverseGeoCodeResult;)V", "GetOnGetReverseGeoCodeResult_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeResult_Handler:Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetReverseGeoCodeResult (global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult p0);

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/search/geocode/OnGetGeoCoderResultListener", DoNotGenerateAcw=true)]
	internal class IOnGetGeoCoderResultListenerInvoker : global::Java.Lang.Object, IOnGetGeoCoderResultListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/search/geocode/OnGetGeoCoderResultListener");
		IntPtr class_ref;

		public static IOnGetGeoCoderResultListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnGetGeoCoderResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.search.geocode.OnGetGeoCoderResultListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnGetGeoCoderResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnGetGeoCoderResultListenerInvoker); }
		}

		static Delegate cb_onGetGeoCodeResult_Lcom_baidu_mapapi_search_geocode_GeoCodeResult_;
#pragma warning disable 0169
		static Delegate GetOnGetGeoCodeResult_Lcom_baidu_mapapi_search_geocode_GeoCodeResult_Handler ()
		{
			if (cb_onGetGeoCodeResult_Lcom_baidu_mapapi_search_geocode_GeoCodeResult_ == null)
				cb_onGetGeoCodeResult_Lcom_baidu_mapapi_search_geocode_GeoCodeResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetGeoCodeResult_Lcom_baidu_mapapi_search_geocode_GeoCodeResult_);
			return cb_onGetGeoCodeResult_Lcom_baidu_mapapi_search_geocode_GeoCodeResult_;
		}

		static void n_OnGetGeoCodeResult_Lcom_baidu_mapapi_search_geocode_GeoCodeResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetGeoCodeResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGetGeoCodeResult_Lcom_baidu_mapapi_search_geocode_GeoCodeResult_;
		public unsafe void OnGetGeoCodeResult (global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult p0)
		{
			if (id_onGetGeoCodeResult_Lcom_baidu_mapapi_search_geocode_GeoCodeResult_ == IntPtr.Zero)
				id_onGetGeoCodeResult_Lcom_baidu_mapapi_search_geocode_GeoCodeResult_ = JNIEnv.GetMethodID (class_ref, "onGetGeoCodeResult", "(Lcom/baidu/mapapi/search/geocode/GeoCodeResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onGetGeoCodeResult_Lcom_baidu_mapapi_search_geocode_GeoCodeResult_, __args);
		}

		static Delegate cb_onGetReverseGeoCodeResult_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeResult_;
#pragma warning disable 0169
		static Delegate GetOnGetReverseGeoCodeResult_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeResult_Handler ()
		{
			if (cb_onGetReverseGeoCodeResult_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeResult_ == null)
				cb_onGetReverseGeoCodeResult_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetReverseGeoCodeResult_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeResult_);
			return cb_onGetReverseGeoCodeResult_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeResult_;
		}

		static void n_OnGetReverseGeoCodeResult_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.IOnGetGeoCoderResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetReverseGeoCodeResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGetReverseGeoCodeResult_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeResult_;
		public unsafe void OnGetReverseGeoCodeResult (global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult p0)
		{
			if (id_onGetReverseGeoCodeResult_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeResult_ == IntPtr.Zero)
				id_onGetReverseGeoCodeResult_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeResult_ = JNIEnv.GetMethodID (class_ref, "onGetReverseGeoCodeResult", "(Lcom/baidu/mapapi/search/geocode/ReverseGeoCodeResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onGetReverseGeoCodeResult_Lcom_baidu_mapapi_search_geocode_ReverseGeoCodeResult_, __args);
		}

	}

	public partial class GetGeoCodeResultEventArgs : global::System.EventArgs {

		public GetGeoCodeResultEventArgs (global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult p0;
		public global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult P0 {
			get { return p0; }
		}
	}

	public partial class GetReverseGeoCodeResultEventArgs : global::System.EventArgs {

		public GetReverseGeoCodeResultEventArgs (global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult p0;
		public global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/baidu/mapapi/search/geocode/OnGetGeoCoderResultListenerImplementor")]
	internal sealed partial class IOnGetGeoCoderResultListenerImplementor : global::Java.Lang.Object, IOnGetGeoCoderResultListener {

		object sender;

		public IOnGetGeoCoderResultListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/search/geocode/OnGetGeoCoderResultListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GetGeoCodeResultEventArgs> OnGetGeoCodeResultHandler;
#pragma warning restore 0649

		public void OnGetGeoCodeResult (global::Com.Baidu.Mapapi.Search.Geocode.GeoCodeResult p0)
		{
			var __h = OnGetGeoCodeResultHandler;
			if (__h != null)
				__h (sender, new GetGeoCodeResultEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<GetReverseGeoCodeResultEventArgs> OnGetReverseGeoCodeResultHandler;
#pragma warning restore 0649

		public void OnGetReverseGeoCodeResult (global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult p0)
		{
			var __h = OnGetReverseGeoCodeResultHandler;
			if (__h != null)
				__h (sender, new GetReverseGeoCodeResultEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnGetGeoCoderResultListenerImplementor value)
		{
			return value.OnGetGeoCodeResultHandler == null && value.OnGetReverseGeoCodeResultHandler == null;
		}
	}

}
