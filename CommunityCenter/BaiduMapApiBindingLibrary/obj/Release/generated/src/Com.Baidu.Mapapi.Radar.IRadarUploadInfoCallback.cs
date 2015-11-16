using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Radar {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.radar']/interface[@name='RadarUploadInfoCallback']"
	[Register ("com/baidu/mapapi/radar/RadarUploadInfoCallback", "", "Com.Baidu.Mapapi.Radar.IRadarUploadInfoCallbackInvoker")]
	public partial interface IRadarUploadInfoCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.radar']/interface[@name='RadarUploadInfoCallback']/method[@name='OnUploadInfoCallback' and count(parameter)=0]"
		[Register ("OnUploadInfoCallback", "()Lcom/baidu/mapapi/radar/RadarUploadInfo;", "GetOnUploadInfoCallbackHandler:Com.Baidu.Mapapi.Radar.IRadarUploadInfoCallbackInvoker, BaiduMapApiBindingLibrary")]
		global::Com.Baidu.Mapapi.Radar.RadarUploadInfo OnUploadInfoCallback ();

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/radar/RadarUploadInfoCallback", DoNotGenerateAcw=true)]
	internal class IRadarUploadInfoCallbackInvoker : global::Java.Lang.Object, IRadarUploadInfoCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/radar/RadarUploadInfoCallback");
		IntPtr class_ref;

		public static IRadarUploadInfoCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRadarUploadInfoCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.radar.RadarUploadInfoCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRadarUploadInfoCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRadarUploadInfoCallbackInvoker); }
		}

		static Delegate cb_OnUploadInfoCallback;
#pragma warning disable 0169
		static Delegate GetOnUploadInfoCallbackHandler ()
		{
			if (cb_OnUploadInfoCallback == null)
				cb_OnUploadInfoCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnUploadInfoCallback);
			return cb_OnUploadInfoCallback;
		}

		static IntPtr n_OnUploadInfoCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Radar.IRadarUploadInfoCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.IRadarUploadInfoCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnUploadInfoCallback ());
		}
#pragma warning restore 0169

		IntPtr id_OnUploadInfoCallback;
		public unsafe global::Com.Baidu.Mapapi.Radar.RadarUploadInfo OnUploadInfoCallback ()
		{
			if (id_OnUploadInfoCallback == IntPtr.Zero)
				id_OnUploadInfoCallback = JNIEnv.GetMethodID (class_ref, "OnUploadInfoCallback", "()Lcom/baidu/mapapi/radar/RadarUploadInfo;");
			return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Radar.RadarUploadInfo> (JNIEnv.CallObjectMethod (Handle, id_OnUploadInfoCallback), JniHandleOwnership.TransferLocalRef);
		}

	}

}
