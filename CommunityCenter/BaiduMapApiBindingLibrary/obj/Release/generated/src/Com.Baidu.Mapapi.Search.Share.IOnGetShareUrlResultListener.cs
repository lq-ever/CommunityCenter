using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Share {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.search.share']/interface[@name='OnGetShareUrlResultListener']"
	[Register ("com/baidu/mapapi/search/share/OnGetShareUrlResultListener", "", "Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListenerInvoker")]
	public partial interface IOnGetShareUrlResultListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.share']/interface[@name='OnGetShareUrlResultListener']/method[@name='onGetLocationShareUrlResult' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.share.ShareUrlResult']]"
		[Register ("onGetLocationShareUrlResult", "(Lcom/baidu/mapapi/search/share/ShareUrlResult;)V", "GetOnGetLocationShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_Handler:Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetLocationShareUrlResult (global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.share']/interface[@name='OnGetShareUrlResultListener']/method[@name='onGetPoiDetailShareUrlResult' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.share.ShareUrlResult']]"
		[Register ("onGetPoiDetailShareUrlResult", "(Lcom/baidu/mapapi/search/share/ShareUrlResult;)V", "GetOnGetPoiDetailShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_Handler:Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetPoiDetailShareUrlResult (global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult p0);

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/search/share/OnGetShareUrlResultListener", DoNotGenerateAcw=true)]
	internal class IOnGetShareUrlResultListenerInvoker : global::Java.Lang.Object, IOnGetShareUrlResultListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/search/share/OnGetShareUrlResultListener");
		IntPtr class_ref;

		public static IOnGetShareUrlResultListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnGetShareUrlResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.search.share.OnGetShareUrlResultListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnGetShareUrlResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnGetShareUrlResultListenerInvoker); }
		}

		static Delegate cb_onGetLocationShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_;
#pragma warning disable 0169
		static Delegate GetOnGetLocationShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_Handler ()
		{
			if (cb_onGetLocationShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_ == null)
				cb_onGetLocationShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetLocationShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_);
			return cb_onGetLocationShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_;
		}

		static void n_OnGetLocationShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetLocationShareUrlResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGetLocationShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_;
		public unsafe void OnGetLocationShareUrlResult (global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult p0)
		{
			if (id_onGetLocationShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_ == IntPtr.Zero)
				id_onGetLocationShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_ = JNIEnv.GetMethodID (class_ref, "onGetLocationShareUrlResult", "(Lcom/baidu/mapapi/search/share/ShareUrlResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onGetLocationShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_, __args);
		}

		static Delegate cb_onGetPoiDetailShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_;
#pragma warning disable 0169
		static Delegate GetOnGetPoiDetailShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_Handler ()
		{
			if (cb_onGetPoiDetailShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_ == null)
				cb_onGetPoiDetailShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetPoiDetailShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_);
			return cb_onGetPoiDetailShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_;
		}

		static void n_OnGetPoiDetailShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.IOnGetShareUrlResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetPoiDetailShareUrlResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGetPoiDetailShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_;
		public unsafe void OnGetPoiDetailShareUrlResult (global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult p0)
		{
			if (id_onGetPoiDetailShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_ == IntPtr.Zero)
				id_onGetPoiDetailShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_ = JNIEnv.GetMethodID (class_ref, "onGetPoiDetailShareUrlResult", "(Lcom/baidu/mapapi/search/share/ShareUrlResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onGetPoiDetailShareUrlResult_Lcom_baidu_mapapi_search_share_ShareUrlResult_, __args);
		}

	}

	public partial class GetLocationShareUrlResultEventArgs : global::System.EventArgs {

		public GetLocationShareUrlResultEventArgs (global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult p0;
		public global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult P0 {
			get { return p0; }
		}
	}

	public partial class GetPoiDetailShareUrlResultEventArgs : global::System.EventArgs {

		public GetPoiDetailShareUrlResultEventArgs (global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult p0;
		public global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/baidu/mapapi/search/share/OnGetShareUrlResultListenerImplementor")]
	internal sealed partial class IOnGetShareUrlResultListenerImplementor : global::Java.Lang.Object, IOnGetShareUrlResultListener {

		object sender;

		public IOnGetShareUrlResultListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/search/share/OnGetShareUrlResultListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GetLocationShareUrlResultEventArgs> OnGetLocationShareUrlResultHandler;
#pragma warning restore 0649

		public void OnGetLocationShareUrlResult (global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult p0)
		{
			var __h = OnGetLocationShareUrlResultHandler;
			if (__h != null)
				__h (sender, new GetLocationShareUrlResultEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<GetPoiDetailShareUrlResultEventArgs> OnGetPoiDetailShareUrlResultHandler;
#pragma warning restore 0649

		public void OnGetPoiDetailShareUrlResult (global::Com.Baidu.Mapapi.Search.Share.ShareUrlResult p0)
		{
			var __h = OnGetPoiDetailShareUrlResultHandler;
			if (__h != null)
				__h (sender, new GetPoiDetailShareUrlResultEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnGetShareUrlResultListenerImplementor value)
		{
			return value.OnGetLocationShareUrlResultHandler == null && value.OnGetPoiDetailShareUrlResultHandler == null;
		}
	}

}
