using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Sug {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/interface[@name='OnGetSuggestionResultListener']"
	[Register ("com/baidu/mapapi/search/sug/OnGetSuggestionResultListener", "", "Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListenerInvoker")]
	public partial interface IOnGetSuggestionResultListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/interface[@name='OnGetSuggestionResultListener']/method[@name='onGetSuggestionResult' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.sug.SuggestionResult']]"
		[Register ("onGetSuggestionResult", "(Lcom/baidu/mapapi/search/sug/SuggestionResult;)V", "GetOnGetSuggestionResult_Lcom_baidu_mapapi_search_sug_SuggestionResult_Handler:Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetSuggestionResult (global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult p0);

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/search/sug/OnGetSuggestionResultListener", DoNotGenerateAcw=true)]
	internal class IOnGetSuggestionResultListenerInvoker : global::Java.Lang.Object, IOnGetSuggestionResultListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/search/sug/OnGetSuggestionResultListener");
		IntPtr class_ref;

		public static IOnGetSuggestionResultListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnGetSuggestionResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.search.sug.OnGetSuggestionResultListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnGetSuggestionResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnGetSuggestionResultListenerInvoker); }
		}

		static Delegate cb_onGetSuggestionResult_Lcom_baidu_mapapi_search_sug_SuggestionResult_;
#pragma warning disable 0169
		static Delegate GetOnGetSuggestionResult_Lcom_baidu_mapapi_search_sug_SuggestionResult_Handler ()
		{
			if (cb_onGetSuggestionResult_Lcom_baidu_mapapi_search_sug_SuggestionResult_ == null)
				cb_onGetSuggestionResult_Lcom_baidu_mapapi_search_sug_SuggestionResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGetSuggestionResult_Lcom_baidu_mapapi_search_sug_SuggestionResult_);
			return cb_onGetSuggestionResult_Lcom_baidu_mapapi_search_sug_SuggestionResult_;
		}

		static void n_OnGetSuggestionResult_Lcom_baidu_mapapi_search_sug_SuggestionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Sug.IOnGetSuggestionResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetSuggestionResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGetSuggestionResult_Lcom_baidu_mapapi_search_sug_SuggestionResult_;
		public unsafe void OnGetSuggestionResult (global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult p0)
		{
			if (id_onGetSuggestionResult_Lcom_baidu_mapapi_search_sug_SuggestionResult_ == IntPtr.Zero)
				id_onGetSuggestionResult_Lcom_baidu_mapapi_search_sug_SuggestionResult_ = JNIEnv.GetMethodID (class_ref, "onGetSuggestionResult", "(Lcom/baidu/mapapi/search/sug/SuggestionResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onGetSuggestionResult_Lcom_baidu_mapapi_search_sug_SuggestionResult_, __args);
		}

	}

	public partial class GetSuggestionResultEventArgs : global::System.EventArgs {

		public GetSuggestionResultEventArgs (global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult p0;
		public global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/baidu/mapapi/search/sug/OnGetSuggestionResultListenerImplementor")]
	internal sealed partial class IOnGetSuggestionResultListenerImplementor : global::Java.Lang.Object, IOnGetSuggestionResultListener {

		object sender;

		public IOnGetSuggestionResultListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/search/sug/OnGetSuggestionResultListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GetSuggestionResultEventArgs> Handler;
#pragma warning restore 0649

		public void OnGetSuggestionResult (global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new GetSuggestionResultEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnGetSuggestionResultListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
