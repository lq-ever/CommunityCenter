using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/core/TaxiInfo", DoNotGenerateAcw=true)]
	public partial class TaxiInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/core/TaxiInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TaxiInfo); }
		}

		protected TaxiInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']/constructor[@name='TaxiInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TaxiInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TaxiInfo)) {
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

		static Delegate cb_getDesc;
#pragma warning disable 0169
		static Delegate GetGetDescHandler ()
		{
			if (cb_getDesc == null)
				cb_getDesc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDesc);
			return cb_getDesc;
		}

		static IntPtr n_GetDesc (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.TaxiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Desc);
		}
#pragma warning restore 0169

		static Delegate cb_setDesc_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDesc_Ljava_lang_String_Handler ()
		{
			if (cb_setDesc_Ljava_lang_String_ == null)
				cb_setDesc_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDesc_Ljava_lang_String_);
			return cb_setDesc_Ljava_lang_String_;
		}

		static void n_SetDesc_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.TaxiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Desc = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDesc;
		static IntPtr id_setDesc_Ljava_lang_String_;
		public virtual unsafe string Desc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']/method[@name='getDesc' and count(parameter)=0]"
			[Register ("getDesc", "()Ljava/lang/String;", "GetGetDescHandler")]
			get {
				if (id_getDesc == IntPtr.Zero)
					id_getDesc = JNIEnv.GetMethodID (class_ref, "getDesc", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDesc), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDesc", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']/method[@name='setDesc' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDesc", "(Ljava/lang/String;)V", "GetSetDesc_Ljava_lang_String_Handler")]
			set {
				if (id_setDesc_Ljava_lang_String_ == IntPtr.Zero)
					id_setDesc_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDesc", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDesc_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDesc", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDistance;
#pragma warning disable 0169
		static Delegate GetGetDistanceHandler ()
		{
			if (cb_getDistance == null)
				cb_getDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDistance);
			return cb_getDistance;
		}

		static int n_GetDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.TaxiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Distance;
		}
#pragma warning restore 0169

		static Delegate cb_setDistance_I;
#pragma warning disable 0169
		static Delegate GetSetDistance_IHandler ()
		{
			if (cb_setDistance_I == null)
				cb_setDistance_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDistance_I);
			return cb_setDistance_I;
		}

		static void n_SetDistance_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.TaxiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Distance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDistance;
		static IntPtr id_setDistance_I;
		public virtual unsafe int Distance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']/method[@name='getDistance' and count(parameter)=0]"
			[Register ("getDistance", "()I", "GetGetDistanceHandler")]
			get {
				if (id_getDistance == IntPtr.Zero)
					id_getDistance = JNIEnv.GetMethodID (class_ref, "getDistance", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDistance);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDistance", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']/method[@name='setDistance' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDistance", "(I)V", "GetSetDistance_IHandler")]
			set {
				if (id_setDistance_I == IntPtr.Zero)
					id_setDistance_I = JNIEnv.GetMethodID (class_ref, "setDistance", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDistance_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDistance", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDuration);
			return cb_getDuration;
		}

		static int n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.TaxiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static Delegate cb_setDuration_I;
#pragma warning disable 0169
		static Delegate GetSetDuration_IHandler ()
		{
			if (cb_setDuration_I == null)
				cb_setDuration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDuration_I);
			return cb_setDuration_I;
		}

		static void n_SetDuration_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.TaxiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Duration = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		static IntPtr id_setDuration_I;
		public virtual unsafe int Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()I", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDuration", "(I)V", "GetSetDuration_IHandler")]
			set {
				if (id_setDuration_I == IntPtr.Zero)
					id_setDuration_I = JNIEnv.GetMethodID (class_ref, "setDuration", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDuration_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuration", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPerKMPrice;
#pragma warning disable 0169
		static Delegate GetGetPerKMPriceHandler ()
		{
			if (cb_getPerKMPrice == null)
				cb_getPerKMPrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPerKMPrice);
			return cb_getPerKMPrice;
		}

		static float n_GetPerKMPrice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.TaxiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PerKMPrice;
		}
#pragma warning restore 0169

		static Delegate cb_setPerKMPrice_F;
#pragma warning disable 0169
		static Delegate GetSetPerKMPrice_FHandler ()
		{
			if (cb_setPerKMPrice_F == null)
				cb_setPerKMPrice_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPerKMPrice_F);
			return cb_setPerKMPrice_F;
		}

		static void n_SetPerKMPrice_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.TaxiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PerKMPrice = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPerKMPrice;
		static IntPtr id_setPerKMPrice_F;
		public virtual unsafe float PerKMPrice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']/method[@name='getPerKMPrice' and count(parameter)=0]"
			[Register ("getPerKMPrice", "()F", "GetGetPerKMPriceHandler")]
			get {
				if (id_getPerKMPrice == IntPtr.Zero)
					id_getPerKMPrice = JNIEnv.GetMethodID (class_ref, "getPerKMPrice", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getPerKMPrice);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPerKMPrice", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']/method[@name='setPerKMPrice' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPerKMPrice", "(F)V", "GetSetPerKMPrice_FHandler")]
			set {
				if (id_setPerKMPrice_F == IntPtr.Zero)
					id_setPerKMPrice_F = JNIEnv.GetMethodID (class_ref, "setPerKMPrice", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPerKMPrice_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPerKMPrice", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStartPrice;
#pragma warning disable 0169
		static Delegate GetGetStartPriceHandler ()
		{
			if (cb_getStartPrice == null)
				cb_getStartPrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetStartPrice);
			return cb_getStartPrice;
		}

		static float n_GetStartPrice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.TaxiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartPrice;
		}
#pragma warning restore 0169

		static Delegate cb_setStartPrice_F;
#pragma warning disable 0169
		static Delegate GetSetStartPrice_FHandler ()
		{
			if (cb_setStartPrice_F == null)
				cb_setStartPrice_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetStartPrice_F);
			return cb_setStartPrice_F;
		}

		static void n_SetStartPrice_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.TaxiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartPrice = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStartPrice;
		static IntPtr id_setStartPrice_F;
		public virtual unsafe float StartPrice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']/method[@name='getStartPrice' and count(parameter)=0]"
			[Register ("getStartPrice", "()F", "GetGetStartPriceHandler")]
			get {
				if (id_getStartPrice == IntPtr.Zero)
					id_getStartPrice = JNIEnv.GetMethodID (class_ref, "getStartPrice", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getStartPrice);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartPrice", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']/method[@name='setStartPrice' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setStartPrice", "(F)V", "GetSetStartPrice_FHandler")]
			set {
				if (id_setStartPrice_F == IntPtr.Zero)
					id_setStartPrice_F = JNIEnv.GetMethodID (class_ref, "setStartPrice", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setStartPrice_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartPrice", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotalPrice;
#pragma warning disable 0169
		static Delegate GetGetTotalPriceHandler ()
		{
			if (cb_getTotalPrice == null)
				cb_getTotalPrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetTotalPrice);
			return cb_getTotalPrice;
		}

		static float n_GetTotalPrice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.TaxiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalPrice;
		}
#pragma warning restore 0169

		static Delegate cb_setTotalPrice_F;
#pragma warning disable 0169
		static Delegate GetSetTotalPrice_FHandler ()
		{
			if (cb_setTotalPrice_F == null)
				cb_setTotalPrice_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTotalPrice_F);
			return cb_setTotalPrice_F;
		}

		static void n_SetTotalPrice_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.TaxiInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TotalPrice = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalPrice;
		static IntPtr id_setTotalPrice_F;
		public virtual unsafe float TotalPrice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']/method[@name='getTotalPrice' and count(parameter)=0]"
			[Register ("getTotalPrice", "()F", "GetGetTotalPriceHandler")]
			get {
				if (id_getTotalPrice == IntPtr.Zero)
					id_getTotalPrice = JNIEnv.GetMethodID (class_ref, "getTotalPrice", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getTotalPrice);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalPrice", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='TaxiInfo']/method[@name='setTotalPrice' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTotalPrice", "(F)V", "GetSetTotalPrice_FHandler")]
			set {
				if (id_setTotalPrice_F == IntPtr.Zero)
					id_setTotalPrice_F = JNIEnv.GetMethodID (class_ref, "setTotalPrice", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTotalPrice_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotalPrice", "(F)V"), __args);
				} finally {
				}
			}
		}

	}
}
