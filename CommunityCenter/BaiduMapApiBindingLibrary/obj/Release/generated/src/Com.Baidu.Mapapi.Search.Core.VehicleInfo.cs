using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='VehicleInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/core/VehicleInfo", DoNotGenerateAcw=true)]
	public partial class VehicleInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/core/VehicleInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VehicleInfo); }
		}

		protected VehicleInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='VehicleInfo']/constructor[@name='VehicleInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VehicleInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VehicleInfo)) {
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

		static Delegate cb_getPassStationNum;
#pragma warning disable 0169
		static Delegate GetGetPassStationNumHandler ()
		{
			if (cb_getPassStationNum == null)
				cb_getPassStationNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPassStationNum);
			return cb_getPassStationNum;
		}

		static int n_GetPassStationNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.VehicleInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.VehicleInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PassStationNum;
		}
#pragma warning restore 0169

		static Delegate cb_setPassStationNum_I;
#pragma warning disable 0169
		static Delegate GetSetPassStationNum_IHandler ()
		{
			if (cb_setPassStationNum_I == null)
				cb_setPassStationNum_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPassStationNum_I);
			return cb_setPassStationNum_I;
		}

		static void n_SetPassStationNum_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.VehicleInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.VehicleInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PassStationNum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPassStationNum;
		static IntPtr id_setPassStationNum_I;
		public virtual unsafe int PassStationNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='VehicleInfo']/method[@name='getPassStationNum' and count(parameter)=0]"
			[Register ("getPassStationNum", "()I", "GetGetPassStationNumHandler")]
			get {
				if (id_getPassStationNum == IntPtr.Zero)
					id_getPassStationNum = JNIEnv.GetMethodID (class_ref, "getPassStationNum", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPassStationNum);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPassStationNum", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='VehicleInfo']/method[@name='setPassStationNum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPassStationNum", "(I)V", "GetSetPassStationNum_IHandler")]
			set {
				if (id_setPassStationNum_I == IntPtr.Zero)
					id_setPassStationNum_I = JNIEnv.GetMethodID (class_ref, "setPassStationNum", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPassStationNum_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassStationNum", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.VehicleInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.VehicleInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.VehicleInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.VehicleInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='VehicleInfo']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='VehicleInfo']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTotalPrice;
#pragma warning disable 0169
		static Delegate GetGetTotalPriceHandler ()
		{
			if (cb_getTotalPrice == null)
				cb_getTotalPrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalPrice);
			return cb_getTotalPrice;
		}

		static int n_GetTotalPrice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.VehicleInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.VehicleInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalPrice;
		}
#pragma warning restore 0169

		static Delegate cb_setTotalPrice_I;
#pragma warning disable 0169
		static Delegate GetSetTotalPrice_IHandler ()
		{
			if (cb_setTotalPrice_I == null)
				cb_setTotalPrice_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTotalPrice_I);
			return cb_setTotalPrice_I;
		}

		static void n_SetTotalPrice_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.VehicleInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.VehicleInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TotalPrice = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalPrice;
		static IntPtr id_setTotalPrice_I;
		public virtual unsafe int TotalPrice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='VehicleInfo']/method[@name='getTotalPrice' and count(parameter)=0]"
			[Register ("getTotalPrice", "()I", "GetGetTotalPriceHandler")]
			get {
				if (id_getTotalPrice == IntPtr.Zero)
					id_getTotalPrice = JNIEnv.GetMethodID (class_ref, "getTotalPrice", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTotalPrice);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalPrice", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='VehicleInfo']/method[@name='setTotalPrice' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTotalPrice", "(I)V", "GetSetTotalPrice_IHandler")]
			set {
				if (id_setTotalPrice_I == IntPtr.Zero)
					id_setTotalPrice_I = JNIEnv.GetMethodID (class_ref, "setTotalPrice", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTotalPrice_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotalPrice", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUid;
#pragma warning disable 0169
		static Delegate GetGetUidHandler ()
		{
			if (cb_getUid == null)
				cb_getUid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUid);
			return cb_getUid;
		}

		static IntPtr n_GetUid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.VehicleInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.VehicleInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uid);
		}
#pragma warning restore 0169

		static Delegate cb_setUid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUid_Ljava_lang_String_Handler ()
		{
			if (cb_setUid_Ljava_lang_String_ == null)
				cb_setUid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUid_Ljava_lang_String_);
			return cb_setUid_Ljava_lang_String_;
		}

		static void n_SetUid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.VehicleInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.VehicleInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Uid = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUid;
		static IntPtr id_setUid_Ljava_lang_String_;
		public virtual unsafe string Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='VehicleInfo']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()Ljava/lang/String;", "GetGetUidHandler")]
			get {
				if (id_getUid == IntPtr.Zero)
					id_getUid = JNIEnv.GetMethodID (class_ref, "getUid", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUid), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUid", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='VehicleInfo']/method[@name='setUid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUid", "(Ljava/lang/String;)V", "GetSetUid_Ljava_lang_String_Handler")]
			set {
				if (id_setUid_Ljava_lang_String_ == IntPtr.Zero)
					id_setUid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUid", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUid_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUid", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getZonePrice;
#pragma warning disable 0169
		static Delegate GetGetZonePriceHandler ()
		{
			if (cb_getZonePrice == null)
				cb_getZonePrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetZonePrice);
			return cb_getZonePrice;
		}

		static int n_GetZonePrice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.VehicleInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.VehicleInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZonePrice;
		}
#pragma warning restore 0169

		static Delegate cb_setZonePrice_I;
#pragma warning disable 0169
		static Delegate GetSetZonePrice_IHandler ()
		{
			if (cb_setZonePrice_I == null)
				cb_setZonePrice_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetZonePrice_I);
			return cb_setZonePrice_I;
		}

		static void n_SetZonePrice_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.VehicleInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.VehicleInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZonePrice = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getZonePrice;
		static IntPtr id_setZonePrice_I;
		public virtual unsafe int ZonePrice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='VehicleInfo']/method[@name='getZonePrice' and count(parameter)=0]"
			[Register ("getZonePrice", "()I", "GetGetZonePriceHandler")]
			get {
				if (id_getZonePrice == IntPtr.Zero)
					id_getZonePrice = JNIEnv.GetMethodID (class_ref, "getZonePrice", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getZonePrice);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZonePrice", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='VehicleInfo']/method[@name='setZonePrice' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setZonePrice", "(I)V", "GetSetZonePrice_IHandler")]
			set {
				if (id_setZonePrice_I == IntPtr.Zero)
					id_setZonePrice_I = JNIEnv.GetMethodID (class_ref, "setZonePrice", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setZonePrice_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZonePrice", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
