using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.cloud']/interface[@name='CloudListener']"
	[Register ("com/baidu/mapapi/cloud/CloudListener", "", "Com.Baidu.Mapapi.Cloud.ICloudListenerInvoker")]
	public partial interface ICloudListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.cloud']/interface[@name='CloudListener']/method[@name='onGetDetailSearchResult' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.cloud.DetailSearchResult'] and parameter[2][@type='int']]"
		[Register ("onGetDetailSearchResult", "(Lcom/baidu/mapapi/cloud/DetailSearchResult;I)V", "GetOnGetDetailSearchResult_Lcom_baidu_mapapi_cloud_DetailSearchResult_IHandler:Com.Baidu.Mapapi.Cloud.ICloudListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetDetailSearchResult (global::Com.Baidu.Mapapi.Cloud.DetailSearchResult p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.cloud']/interface[@name='CloudListener']/method[@name='onGetSearchResult' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.cloud.CloudSearchResult'] and parameter[2][@type='int']]"
		[Register ("onGetSearchResult", "(Lcom/baidu/mapapi/cloud/CloudSearchResult;I)V", "GetOnGetSearchResult_Lcom_baidu_mapapi_cloud_CloudSearchResult_IHandler:Com.Baidu.Mapapi.Cloud.ICloudListenerInvoker, BaiduMapApiBindingLibrary")]
		void OnGetSearchResult (global::Com.Baidu.Mapapi.Cloud.CloudSearchResult p0, int p1);

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/CloudListener", DoNotGenerateAcw=true)]
	internal class ICloudListenerInvoker : global::Java.Lang.Object, ICloudListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/cloud/CloudListener");
		IntPtr class_ref;

		public static ICloudListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICloudListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.cloud.CloudListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICloudListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICloudListenerInvoker); }
		}

		static Delegate cb_onGetDetailSearchResult_Lcom_baidu_mapapi_cloud_DetailSearchResult_I;
#pragma warning disable 0169
		static Delegate GetOnGetDetailSearchResult_Lcom_baidu_mapapi_cloud_DetailSearchResult_IHandler ()
		{
			if (cb_onGetDetailSearchResult_Lcom_baidu_mapapi_cloud_DetailSearchResult_I == null)
				cb_onGetDetailSearchResult_Lcom_baidu_mapapi_cloud_DetailSearchResult_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnGetDetailSearchResult_Lcom_baidu_mapapi_cloud_DetailSearchResult_I);
			return cb_onGetDetailSearchResult_Lcom_baidu_mapapi_cloud_DetailSearchResult_I;
		}

		static void n_OnGetDetailSearchResult_Lcom_baidu_mapapi_cloud_DetailSearchResult_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Baidu.Mapapi.Cloud.ICloudListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.ICloudListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Cloud.DetailSearchResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.DetailSearchResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetDetailSearchResult (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onGetDetailSearchResult_Lcom_baidu_mapapi_cloud_DetailSearchResult_I;
		public unsafe void OnGetDetailSearchResult (global::Com.Baidu.Mapapi.Cloud.DetailSearchResult p0, int p1)
		{
			if (id_onGetDetailSearchResult_Lcom_baidu_mapapi_cloud_DetailSearchResult_I == IntPtr.Zero)
				id_onGetDetailSearchResult_Lcom_baidu_mapapi_cloud_DetailSearchResult_I = JNIEnv.GetMethodID (class_ref, "onGetDetailSearchResult", "(Lcom/baidu/mapapi/cloud/DetailSearchResult;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onGetDetailSearchResult_Lcom_baidu_mapapi_cloud_DetailSearchResult_I, __args);
		}

		static Delegate cb_onGetSearchResult_Lcom_baidu_mapapi_cloud_CloudSearchResult_I;
#pragma warning disable 0169
		static Delegate GetOnGetSearchResult_Lcom_baidu_mapapi_cloud_CloudSearchResult_IHandler ()
		{
			if (cb_onGetSearchResult_Lcom_baidu_mapapi_cloud_CloudSearchResult_I == null)
				cb_onGetSearchResult_Lcom_baidu_mapapi_cloud_CloudSearchResult_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnGetSearchResult_Lcom_baidu_mapapi_cloud_CloudSearchResult_I);
			return cb_onGetSearchResult_Lcom_baidu_mapapi_cloud_CloudSearchResult_I;
		}

		static void n_OnGetSearchResult_Lcom_baidu_mapapi_cloud_CloudSearchResult_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Baidu.Mapapi.Cloud.ICloudListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.ICloudListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Cloud.CloudSearchResult p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Cloud.CloudSearchResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetSearchResult (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onGetSearchResult_Lcom_baidu_mapapi_cloud_CloudSearchResult_I;
		public unsafe void OnGetSearchResult (global::Com.Baidu.Mapapi.Cloud.CloudSearchResult p0, int p1)
		{
			if (id_onGetSearchResult_Lcom_baidu_mapapi_cloud_CloudSearchResult_I == IntPtr.Zero)
				id_onGetSearchResult_Lcom_baidu_mapapi_cloud_CloudSearchResult_I = JNIEnv.GetMethodID (class_ref, "onGetSearchResult", "(Lcom/baidu/mapapi/cloud/CloudSearchResult;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onGetSearchResult_Lcom_baidu_mapapi_cloud_CloudSearchResult_I, __args);
		}

	}

	public partial class GetDetailSearchResultEventArgs : global::System.EventArgs {

		public GetDetailSearchResultEventArgs (global::Com.Baidu.Mapapi.Cloud.DetailSearchResult p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Baidu.Mapapi.Cloud.DetailSearchResult p0;
		public global::Com.Baidu.Mapapi.Cloud.DetailSearchResult P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	public partial class GetSearchResultEventArgs : global::System.EventArgs {

		public GetSearchResultEventArgs (global::Com.Baidu.Mapapi.Cloud.CloudSearchResult p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Baidu.Mapapi.Cloud.CloudSearchResult p0;
		public global::Com.Baidu.Mapapi.Cloud.CloudSearchResult P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/baidu/mapapi/cloud/CloudListenerImplementor")]
	internal sealed partial class ICloudListenerImplementor : global::Java.Lang.Object, ICloudListener {

		object sender;

		public ICloudListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/cloud/CloudListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GetDetailSearchResultEventArgs> OnGetDetailSearchResultHandler;
#pragma warning restore 0649

		public void OnGetDetailSearchResult (global::Com.Baidu.Mapapi.Cloud.DetailSearchResult p0, int p1)
		{
			var __h = OnGetDetailSearchResultHandler;
			if (__h != null)
				__h (sender, new GetDetailSearchResultEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<GetSearchResultEventArgs> OnGetSearchResultHandler;
#pragma warning restore 0649

		public void OnGetSearchResult (global::Com.Baidu.Mapapi.Cloud.CloudSearchResult p0, int p1)
		{
			var __h = OnGetSearchResultHandler;
			if (__h != null)
				__h (sender, new GetSearchResultEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ICloudListenerImplementor value)
		{
			return value.OnGetDetailSearchResultHandler == null && value.OnGetSearchResultHandler == null;
		}
	}

}
