using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteStep']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/core/RouteStep", DoNotGenerateAcw=true)]
	public partial class RouteStep : global::Java.Lang.Object {


		static IntPtr mWayPoints_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteStep']/field[@name='mWayPoints']"
		[Register ("mWayPoints")]
		protected global::System.Collections.IList MWayPoints {
			get {
				if (mWayPoints_jfieldId == IntPtr.Zero)
					mWayPoints_jfieldId = JNIEnv.GetFieldID (class_ref, "mWayPoints", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mWayPoints_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mWayPoints_jfieldId == IntPtr.Zero)
					mWayPoints_jfieldId = JNIEnv.GetFieldID (class_ref, "mWayPoints", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mWayPoints_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/core/RouteStep", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RouteStep); }
		}

		protected RouteStep (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteStep']/constructor[@name='RouteStep' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RouteStep ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RouteStep)) {
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
			global::Com.Baidu.Mapapi.Search.Core.RouteStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Baidu.Mapapi.Search.Core.RouteStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Distance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDistance;
		static IntPtr id_setDistance_I;
		public virtual unsafe int Distance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteStep']/method[@name='getDistance' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteStep']/method[@name='setDistance' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Baidu.Mapapi.Search.Core.RouteStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Baidu.Mapapi.Search.Core.RouteStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Duration = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		static IntPtr id_setDuration_I;
		public virtual unsafe int Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteStep']/method[@name='getDuration' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteStep']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getWayPoints;
#pragma warning disable 0169
		static Delegate GetGetWayPointsHandler ()
		{
			if (cb_getWayPoints == null)
				cb_getWayPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWayPoints);
			return cb_getWayPoints;
		}

		static IntPtr n_GetWayPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (__this.WayPoints);
		}
#pragma warning restore 0169

		static Delegate cb_setWayPoints_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetWayPoints_Ljava_util_List_Handler ()
		{
			if (cb_setWayPoints_Ljava_util_List_ == null)
				cb_setWayPoints_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWayPoints_Ljava_util_List_);
			return cb_setWayPoints_Ljava_util_List_;
		}

		static void n_SetWayPoints_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Core.RouteStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WayPoints = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWayPoints;
		static IntPtr id_setWayPoints_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> WayPoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteStep']/method[@name='getWayPoints' and count(parameter)=0]"
			[Register ("getWayPoints", "()Ljava/util/List;", "GetGetWayPointsHandler")]
			get {
				if (id_getWayPoints == IntPtr.Zero)
					id_getWayPoints = JNIEnv.GetMethodID (class_ref, "getWayPoints", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getWayPoints), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWayPoints", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='RouteStep']/method[@name='setWayPoints' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.model.LatLng&gt;']]"
			[Register ("setWayPoints", "(Ljava/util/List;)V", "GetSetWayPoints_Ljava_util_List_Handler")]
			set {
				if (id_setWayPoints_Ljava_util_List_ == IntPtr.Zero)
					id_setWayPoints_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setWayPoints", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWayPoints_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWayPoints", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
