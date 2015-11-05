using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Utils.Route {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/utils/route/RouteParaOption", DoNotGenerateAcw=true)]
	public partial class RouteParaOption : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption.EBusStrategyType']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType", DoNotGenerateAcw=true)]
		public sealed partial class EBusStrategyType : global::Java.Lang.Enum {


			static IntPtr bus_no_subway_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption.EBusStrategyType']/field[@name='bus_no_subway']"
			[Register ("bus_no_subway")]
			public static global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType BusNoSubway {
				get {
					if (bus_no_subway_jfieldId == IntPtr.Zero)
						bus_no_subway_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bus_no_subway", "Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, bus_no_subway_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr bus_recommend_way_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption.EBusStrategyType']/field[@name='bus_recommend_way']"
			[Register ("bus_recommend_way")]
			public static global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType BusRecommendWay {
				get {
					if (bus_recommend_way_jfieldId == IntPtr.Zero)
						bus_recommend_way_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bus_recommend_way", "Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, bus_recommend_way_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr bus_time_first_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption.EBusStrategyType']/field[@name='bus_time_first']"
			[Register ("bus_time_first")]
			public static global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType BusTimeFirst {
				get {
					if (bus_time_first_jfieldId == IntPtr.Zero)
						bus_time_first_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bus_time_first", "Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, bus_time_first_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr bus_transfer_little_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption.EBusStrategyType']/field[@name='bus_transfer_little']"
			[Register ("bus_transfer_little")]
			public static global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType BusTransferLittle {
				get {
					if (bus_transfer_little_jfieldId == IntPtr.Zero)
						bus_transfer_little_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bus_transfer_little", "Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, bus_transfer_little_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr bus_walk_little_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption.EBusStrategyType']/field[@name='bus_walk_little']"
			[Register ("bus_walk_little")]
			public static global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType BusWalkLittle {
				get {
					if (bus_walk_little_jfieldId == IntPtr.Zero)
						bus_walk_little_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bus_walk_little", "Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, bus_walk_little_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EBusStrategyType); }
			}

			internal EBusStrategyType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption.EBusStrategyType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption.EBusStrategyType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;");
				try {
					return (global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/utils/route/RouteParaOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RouteParaOption); }
		}

		protected RouteParaOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']/constructor[@name='RouteParaOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RouteParaOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RouteParaOption)) {
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

		static Delegate cb_getBusStrategyType;
#pragma warning disable 0169
		static Delegate GetGetBusStrategyTypeHandler ()
		{
			if (cb_getBusStrategyType == null)
				cb_getBusStrategyType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBusStrategyType);
			return cb_getBusStrategyType;
		}

		static IntPtr n_GetBusStrategyType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BusStrategyType);
		}
#pragma warning restore 0169

		static IntPtr id_getBusStrategyType;
		public virtual unsafe global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType BusStrategyType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']/method[@name='getBusStrategyType' and count(parameter)=0]"
			[Register ("getBusStrategyType", "()Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;", "GetGetBusStrategyTypeHandler")]
			get {
				if (id_getBusStrategyType == IntPtr.Zero)
					id_getBusStrategyType = JNIEnv.GetMethodID (class_ref, "getBusStrategyType", "()Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType> (JNIEnv.CallObjectMethod  (Handle, id_getBusStrategyType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBusStrategyType", "()Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCityName;
#pragma warning disable 0169
		static Delegate GetGetCityNameHandler ()
		{
			if (cb_getCityName == null)
				cb_getCityName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCityName);
			return cb_getCityName;
		}

		static IntPtr n_GetCityName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CityName);
		}
#pragma warning restore 0169

		static IntPtr id_getCityName;
		public virtual unsafe string CityName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']/method[@name='getCityName' and count(parameter)=0]"
			[Register ("getCityName", "()Ljava/lang/String;", "GetGetCityNameHandler")]
			get {
				if (id_getCityName == IntPtr.Zero)
					id_getCityName = JNIEnv.GetMethodID (class_ref, "getCityName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCityName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCityName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEndName;
#pragma warning disable 0169
		static Delegate GetGetEndNameHandler ()
		{
			if (cb_getEndName == null)
				cb_getEndName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndName);
			return cb_getEndName;
		}

		static IntPtr n_GetEndName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EndName);
		}
#pragma warning restore 0169

		static IntPtr id_getEndName;
		public virtual unsafe string EndName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']/method[@name='getEndName' and count(parameter)=0]"
			[Register ("getEndName", "()Ljava/lang/String;", "GetGetEndNameHandler")]
			get {
				if (id_getEndName == IntPtr.Zero)
					id_getEndName = JNIEnv.GetMethodID (class_ref, "getEndName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEndName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEndPoint;
#pragma warning disable 0169
		static Delegate GetGetEndPointHandler ()
		{
			if (cb_getEndPoint == null)
				cb_getEndPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndPoint);
			return cb_getEndPoint;
		}

		static IntPtr n_GetEndPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndPoint);
		}
#pragma warning restore 0169

		static IntPtr id_getEndPoint;
		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng EndPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']/method[@name='getEndPoint' and count(parameter)=0]"
			[Register ("getEndPoint", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetEndPointHandler")]
			get {
				if (id_getEndPoint == IntPtr.Zero)
					id_getEndPoint = JNIEnv.GetMethodID (class_ref, "getEndPoint", "()Lcom/baidu/mapapi/model/LatLng;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getEndPoint), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndPoint", "()Lcom/baidu/mapapi/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStartName;
#pragma warning disable 0169
		static Delegate GetGetStartNameHandler ()
		{
			if (cb_getStartName == null)
				cb_getStartName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartName);
			return cb_getStartName;
		}

		static IntPtr n_GetStartName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StartName);
		}
#pragma warning restore 0169

		static IntPtr id_getStartName;
		public virtual unsafe string StartName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']/method[@name='getStartName' and count(parameter)=0]"
			[Register ("getStartName", "()Ljava/lang/String;", "GetGetStartNameHandler")]
			get {
				if (id_getStartName == IntPtr.Zero)
					id_getStartName = JNIEnv.GetMethodID (class_ref, "getStartName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStartName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStartPoint;
#pragma warning disable 0169
		static Delegate GetGetStartPointHandler ()
		{
			if (cb_getStartPoint == null)
				cb_getStartPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartPoint);
			return cb_getStartPoint;
		}

		static IntPtr n_GetStartPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartPoint);
		}
#pragma warning restore 0169

		static IntPtr id_getStartPoint;
		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng StartPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']/method[@name='getStartPoint' and count(parameter)=0]"
			[Register ("getStartPoint", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetStartPointHandler")]
			get {
				if (id_getStartPoint == IntPtr.Zero)
					id_getStartPoint = JNIEnv.GetMethodID (class_ref, "getStartPoint", "()Lcom/baidu/mapapi/model/LatLng;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getStartPoint), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartPoint", "()Lcom/baidu/mapapi/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_busStrategyType_Lcom_baidu_mapapi_utils_route_RouteParaOption_EBusStrategyType_;
#pragma warning disable 0169
		static Delegate GetInvokeBusStrategyType_Lcom_baidu_mapapi_utils_route_RouteParaOption_EBusStrategyType_Handler ()
		{
			if (cb_busStrategyType_Lcom_baidu_mapapi_utils_route_RouteParaOption_EBusStrategyType_ == null)
				cb_busStrategyType_Lcom_baidu_mapapi_utils_route_RouteParaOption_EBusStrategyType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeBusStrategyType_Lcom_baidu_mapapi_utils_route_RouteParaOption_EBusStrategyType_);
			return cb_busStrategyType_Lcom_baidu_mapapi_utils_route_RouteParaOption_EBusStrategyType_;
		}

		static IntPtr n_InvokeBusStrategyType_Lcom_baidu_mapapi_utils_route_RouteParaOption_EBusStrategyType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeBusStrategyType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_busStrategyType_Lcom_baidu_mapapi_utils_route_RouteParaOption_EBusStrategyType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']/method[@name='busStrategyType' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.utils.route.RouteParaOption.EBusStrategyType']]"
		[Register ("busStrategyType", "(Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;)Lcom/baidu/mapapi/utils/route/RouteParaOption;", "GetInvokeBusStrategyType_Lcom_baidu_mapapi_utils_route_RouteParaOption_EBusStrategyType_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption InvokeBusStrategyType (global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption.EBusStrategyType p0)
		{
			if (id_busStrategyType_Lcom_baidu_mapapi_utils_route_RouteParaOption_EBusStrategyType_ == IntPtr.Zero)
				id_busStrategyType_Lcom_baidu_mapapi_utils_route_RouteParaOption_EBusStrategyType_ = JNIEnv.GetMethodID (class_ref, "busStrategyType", "(Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;)Lcom/baidu/mapapi/utils/route/RouteParaOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (JNIEnv.CallObjectMethod  (Handle, id_busStrategyType_Lcom_baidu_mapapi_utils_route_RouteParaOption_EBusStrategyType_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "busStrategyType", "(Lcom/baidu/mapapi/utils/route/RouteParaOption$EBusStrategyType;)Lcom/baidu/mapapi/utils/route/RouteParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_cityName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeCityName_Ljava_lang_String_Handler ()
		{
			if (cb_cityName_Ljava_lang_String_ == null)
				cb_cityName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeCityName_Ljava_lang_String_);
			return cb_cityName_Ljava_lang_String_;
		}

		static IntPtr n_InvokeCityName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeCityName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_cityName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']/method[@name='cityName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("cityName", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/route/RouteParaOption;", "GetInvokeCityName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption InvokeCityName (string p0)
		{
			if (id_cityName_Ljava_lang_String_ == IntPtr.Zero)
				id_cityName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cityName", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/route/RouteParaOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (JNIEnv.CallObjectMethod  (Handle, id_cityName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cityName", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/route/RouteParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_endName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeEndName_Ljava_lang_String_Handler ()
		{
			if (cb_endName_Ljava_lang_String_ == null)
				cb_endName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeEndName_Ljava_lang_String_);
			return cb_endName_Ljava_lang_String_;
		}

		static IntPtr n_InvokeEndName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeEndName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_endName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']/method[@name='endName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("endName", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/route/RouteParaOption;", "GetInvokeEndName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption InvokeEndName (string p0)
		{
			if (id_endName_Ljava_lang_String_ == IntPtr.Zero)
				id_endName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "endName", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/route/RouteParaOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (JNIEnv.CallObjectMethod  (Handle, id_endName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endName", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/route/RouteParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_endPoint_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetInvokeEndPoint_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_endPoint_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_endPoint_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeEndPoint_Lcom_baidu_mapapi_model_LatLng_);
			return cb_endPoint_Lcom_baidu_mapapi_model_LatLng_;
		}

		static IntPtr n_InvokeEndPoint_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeEndPoint (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_endPoint_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']/method[@name='endPoint' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("endPoint", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/utils/route/RouteParaOption;", "GetInvokeEndPoint_Lcom_baidu_mapapi_model_LatLng_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption InvokeEndPoint (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_endPoint_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_endPoint_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "endPoint", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/utils/route/RouteParaOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (JNIEnv.CallObjectMethod  (Handle, id_endPoint_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endPoint", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/utils/route/RouteParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_startName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeStartName_Ljava_lang_String_Handler ()
		{
			if (cb_startName_Ljava_lang_String_ == null)
				cb_startName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeStartName_Ljava_lang_String_);
			return cb_startName_Ljava_lang_String_;
		}

		static IntPtr n_InvokeStartName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeStartName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']/method[@name='startName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startName", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/route/RouteParaOption;", "GetInvokeStartName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption InvokeStartName (string p0)
		{
			if (id_startName_Ljava_lang_String_ == IntPtr.Zero)
				id_startName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startName", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/route/RouteParaOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (JNIEnv.CallObjectMethod  (Handle, id_startName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startName", "(Ljava/lang/String;)Lcom/baidu/mapapi/utils/route/RouteParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_startPoint_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetInvokeStartPoint_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_startPoint_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_startPoint_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeStartPoint_Lcom_baidu_mapapi_model_LatLng_);
			return cb_startPoint_Lcom_baidu_mapapi_model_LatLng_;
		}

		static IntPtr n_InvokeStartPoint_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeStartPoint (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startPoint_Lcom_baidu_mapapi_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils.route']/class[@name='RouteParaOption']/method[@name='startPoint' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("startPoint", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/utils/route/RouteParaOption;", "GetInvokeStartPoint_Lcom_baidu_mapapi_model_LatLng_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption InvokeStartPoint (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			if (id_startPoint_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
				id_startPoint_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "startPoint", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/utils/route/RouteParaOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (JNIEnv.CallObjectMethod  (Handle, id_startPoint_Lcom_baidu_mapapi_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.Route.RouteParaOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startPoint", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/utils/route/RouteParaOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
