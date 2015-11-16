using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Poi {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/interface[@name='OnGetPoiSearchResultListener']"
	[Register ("com/baidu/mapapi/search/poi/OnGetPoiSearchResultListener", "", "Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListenerInvoker")]
	public partial interface IOnGetPoiSearchResultListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/interface[@name='OnGetPoiSearchResultListener']/method[@name='onGetPoiDetailResult' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.poi.PoiDetailResult']]"
		[Register ("onGetPoiDetailResult", "(Lcom/baidu/mapapi/search/poi/PoiDetailResult;)V", "GetOnGetPoiDetailResult_Lcom_baidu_mapapi_search_poi_PoiDetailResult_Handler:Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetPoiDetailResult (global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/interface[@name='OnGetPoiSearchResultListener']/method[@name='onGetPoiResult' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.poi.PoiResult']]"
		[Register ("onGetPoiResult", "(Lcom/baidu/mapapi/search/poi/PoiResult;)V", "GetOnGetPoiResult_Lcom_baidu_mapapi_search_poi_PoiResult_Handler:Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetPoiResult (global::Com.Baidu.Mapapi.Search.Poi.PoiResult p0);

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/search/poi/OnGetPoiSearchResultListener", DoNotGenerateAcw=true)]
	internal class IOnGetPoiSearchResultListenerInvoker : global::Java.Lang.Object, IOnGetPoiSearchResultListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/search/poi/OnGetPoiSearchResultListener");
		IntPtr class_ref;

		public static IOnGetPoiSearchResultListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnGetPoiSearchResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.search.poi.OnGetPoiSearchResultListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnGetPoiSearchResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnGetPoiSearchResultListenerInvoker); }
		}

		static Delegate cb_onGetPoiDetailResult_Lcom_baidu_mapapi_search_poi_PoiDetailResult_;
#pragma warning disable 0169
		static Delegate GetOnGetPoiDetailResult_Lcom_baidu_mapapi_search_poi_PoiDetailResult_Handler ()
		{
			if (cb_onGetPoiDetailResult_Lcom_baidu_mapapi_search_poi_PoiDetailResult_ == null)
				cb_onGetPoiDetailResult_Lcom_baidu_mapapi_search_poi_PoiDetailResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetPoiDetailResult_Lcom_baidu_mapapi_search_poi_PoiDetailResult_);
			return cb_onGetPoiDetailResult_Lcom_baidu_mapapi_search_poi_PoiDetailResult_;
		}

		static void n_OnGetPoiDetailResult_Lcom_baidu_mapapi_search_poi_PoiDetailResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetPoiDetailResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGetPoiDetailResult_Lcom_baidu_mapapi_search_poi_PoiDetailResult_;
		public unsafe void OnGetPoiDetailResult (global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult p0)
		{
			if (id_onGetPoiDetailResult_Lcom_baidu_mapapi_search_poi_PoiDetailResult_ == IntPtr.Zero)
				id_onGetPoiDetailResult_Lcom_baidu_mapapi_search_poi_PoiDetailResult_ = JNIEnv.GetMethodID (class_ref, "onGetPoiDetailResult", "(Lcom/baidu/mapapi/search/poi/PoiDetailResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onGetPoiDetailResult_Lcom_baidu_mapapi_search_poi_PoiDetailResult_, __args);
		}

		static Delegate cb_onGetPoiResult_Lcom_baidu_mapapi_search_poi_PoiResult_;
#pragma warning disable 0169
		static Delegate GetOnGetPoiResult_Lcom_baidu_mapapi_search_poi_PoiResult_Handler ()
		{
			if (cb_onGetPoiResult_Lcom_baidu_mapapi_search_poi_PoiResult_ == null)
				cb_onGetPoiResult_Lcom_baidu_mapapi_search_poi_PoiResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetPoiResult_Lcom_baidu_mapapi_search_poi_PoiResult_);
			return cb_onGetPoiResult_Lcom_baidu_mapapi_search_poi_PoiResult_;
		}

		static void n_OnGetPoiResult_Lcom_baidu_mapapi_search_poi_PoiResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.IOnGetPoiSearchResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Poi.PoiResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetPoiResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGetPoiResult_Lcom_baidu_mapapi_search_poi_PoiResult_;
		public unsafe void OnGetPoiResult (global::Com.Baidu.Mapapi.Search.Poi.PoiResult p0)
		{
			if (id_onGetPoiResult_Lcom_baidu_mapapi_search_poi_PoiResult_ == IntPtr.Zero)
				id_onGetPoiResult_Lcom_baidu_mapapi_search_poi_PoiResult_ = JNIEnv.GetMethodID (class_ref, "onGetPoiResult", "(Lcom/baidu/mapapi/search/poi/PoiResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onGetPoiResult_Lcom_baidu_mapapi_search_poi_PoiResult_, __args);
		}

	}

	public partial class GetPoiDetailResultEventArgs : global::System.EventArgs {

		public GetPoiDetailResultEventArgs (global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult p0;
		public global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult P0 {
			get { return p0; }
		}
	}

	public partial class GetPoiResultEventArgs : global::System.EventArgs {

		public GetPoiResultEventArgs (global::Com.Baidu.Mapapi.Search.Poi.PoiResult p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Mapapi.Search.Poi.PoiResult p0;
		public global::Com.Baidu.Mapapi.Search.Poi.PoiResult P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/baidu/mapapi/search/poi/OnGetPoiSearchResultListenerImplementor")]
	internal sealed partial class IOnGetPoiSearchResultListenerImplementor : global::Java.Lang.Object, IOnGetPoiSearchResultListener {

		object sender;

		public IOnGetPoiSearchResultListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/search/poi/OnGetPoiSearchResultListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GetPoiDetailResultEventArgs> OnGetPoiDetailResultHandler;
#pragma warning restore 0649

		public void OnGetPoiDetailResult (global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult p0)
		{
			var __h = OnGetPoiDetailResultHandler;
			if (__h != null)
				__h (sender, new GetPoiDetailResultEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<GetPoiResultEventArgs> OnGetPoiResultHandler;
#pragma warning restore 0649

		public void OnGetPoiResult (global::Com.Baidu.Mapapi.Search.Poi.PoiResult p0)
		{
			var __h = OnGetPoiResultHandler;
			if (__h != null)
				__h (sender, new GetPoiResultEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnGetPoiSearchResultListenerImplementor value)
		{
			return value.OnGetPoiDetailResultHandler == null && value.OnGetPoiResultHandler == null;
		}
	}

}
