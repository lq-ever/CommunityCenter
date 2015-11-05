using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Busline {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/interface[@name='OnGetBusLineSearchResultListener']"
	[Register ("com/baidu/mapapi/search/busline/OnGetBusLineSearchResultListener", "", "Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListenerInvoker")]
	public partial interface IOnGetBusLineSearchResultListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/interface[@name='OnGetBusLineSearchResultListener']/method[@name='onGetBusLineResult' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.busline.BusLineResult']]"
		[Register ("onGetBusLineResult", "(Lcom/baidu/mapapi/search/busline/BusLineResult;)V", "GetOnGetBusLineResult_Lcom_baidu_mapapi_search_busline_BusLineResult_Handler:Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetBusLineResult (global::Com.Baidu.Mapapi.Search.Busline.BusLineResult p0);

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/search/busline/OnGetBusLineSearchResultListener", DoNotGenerateAcw=true)]
	internal class IOnGetBusLineSearchResultListenerInvoker : global::Java.Lang.Object, IOnGetBusLineSearchResultListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/search/busline/OnGetBusLineSearchResultListener");
		IntPtr class_ref;

		public static IOnGetBusLineSearchResultListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnGetBusLineSearchResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.search.busline.OnGetBusLineSearchResultListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnGetBusLineSearchResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnGetBusLineSearchResultListenerInvoker); }
		}

		static Delegate cb_onGetBusLineResult_Lcom_baidu_mapapi_search_busline_BusLineResult_;
#pragma warning disable 0169
		static Delegate GetOnGetBusLineResult_Lcom_baidu_mapapi_search_busline_BusLineResult_Handler ()
		{
			if (cb_onGetBusLineResult_Lcom_baidu_mapapi_search_busline_BusLineResult_ == null)
				cb_onGetBusLineResult_Lcom_baidu_mapapi_search_busline_BusLineResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetBusLineResult_Lcom_baidu_mapapi_search_busline_BusLineResult_);
			return cb_onGetBusLineResult_Lcom_baidu_mapapi_search_busline_BusLineResult_;
		}

		static void n_OnGetBusLineResult_Lcom_baidu_mapapi_search_busline_BusLineResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.IOnGetBusLineSearchResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Busline.BusLineResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetBusLineResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGetBusLineResult_Lcom_baidu_mapapi_search_busline_BusLineResult_;
		public unsafe void OnGetBusLineResult (global::Com.Baidu.Mapapi.Search.Busline.BusLineResult p0)
		{
			if (id_onGetBusLineResult_Lcom_baidu_mapapi_search_busline_BusLineResult_ == IntPtr.Zero)
				id_onGetBusLineResult_Lcom_baidu_mapapi_search_busline_BusLineResult_ = JNIEnv.GetMethodID (class_ref, "onGetBusLineResult", "(Lcom/baidu/mapapi/search/busline/BusLineResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onGetBusLineResult_Lcom_baidu_mapapi_search_busline_BusLineResult_, __args);
		}

	}

	public partial class GetBusLineSearchResultEventArgs : global::System.EventArgs {

		public GetBusLineSearchResultEventArgs (global::Com.Baidu.Mapapi.Search.Busline.BusLineResult p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Mapapi.Search.Busline.BusLineResult p0;
		public global::Com.Baidu.Mapapi.Search.Busline.BusLineResult P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/baidu/mapapi/search/busline/OnGetBusLineSearchResultListenerImplementor")]
	internal sealed partial class IOnGetBusLineSearchResultListenerImplementor : global::Java.Lang.Object, IOnGetBusLineSearchResultListener {

		object sender;

		public IOnGetBusLineSearchResultListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/search/busline/OnGetBusLineSearchResultListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GetBusLineSearchResultEventArgs> Handler;
#pragma warning restore 0649

		public void OnGetBusLineResult (global::Com.Baidu.Mapapi.Search.Busline.BusLineResult p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new GetBusLineSearchResultEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnGetBusLineSearchResultListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
