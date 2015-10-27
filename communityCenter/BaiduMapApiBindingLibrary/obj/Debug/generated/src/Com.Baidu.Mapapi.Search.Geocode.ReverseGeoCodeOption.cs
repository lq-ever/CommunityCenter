using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Geocode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeOption']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/geocode/ReverseGeoCodeOption", DoNotGenerateAcw=true)]
	public partial class ReverseGeoCodeOption : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/geocode/ReverseGeoCodeOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReverseGeoCodeOption); }
		}

		protected ReverseGeoCodeOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeOption']/constructor[@name='ReverseGeoCodeOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReverseGeoCodeOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ReverseGeoCodeOption)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_location_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetLocation_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_location_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_location_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Location_Lcom_baidu_mapapi_model_LatLng_);
			return cb_location_Lcom_baidu_mapapi_model_LatLng_;
		}

		static IntPtr n_Location_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Location (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_location_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeOption']/method[@name='location' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("location", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/geocode/ReverseGeoCodeOption;", "GetLocation_Lcom_baidu_mapapi_model_LatLng_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeOption Location (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_location_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_location_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "location", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/geocode/ReverseGeoCodeOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeOption> (JNIEnv.CallObjectMethod  (Handle, id_location_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "location", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/search/geocode/ReverseGeoCodeOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
