using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Route {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/TransitRouteLine", DoNotGenerateAcw=true)]
	public sealed partial class TransitRouteLine : global::Com.Baidu.Mapapi.Search.Core.RouteLine {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine.TransitStep']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/TransitRouteLine$TransitStep", DoNotGenerateAcw=true)]
		public partial class TransitStep : global::Com.Baidu.Mapapi.Search.Core.RouteStep {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine.TransitStep.TransitRouteStepType']"
			[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/TransitRouteLine$TransitStep$TransitRouteStepType", DoNotGenerateAcw=true)]
			public sealed partial class TransitRouteStepType : global::Java.Lang.Enum {


				static IntPtr BUSLINE_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine.TransitStep.TransitRouteStepType']/field[@name='BUSLINE']"
				[Register ("BUSLINE")]
				public static global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType Busline {
					get {
						if (BUSLINE_jfieldId == IntPtr.Zero)
							BUSLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUSLINE", "Lcom/baidu/mapapi/search/route/TransitRouteLine$TransitStep$TransitRouteStepType;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUSLINE_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr SUBWAY_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine.TransitStep.TransitRouteStepType']/field[@name='SUBWAY']"
				[Register ("SUBWAY")]
				public static global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType Subway {
					get {
						if (SUBWAY_jfieldId == IntPtr.Zero)
							SUBWAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUBWAY", "Lcom/baidu/mapapi/search/route/TransitRouteLine$TransitStep$TransitRouteStepType;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUBWAY_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr WAKLING_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine.TransitStep.TransitRouteStepType']/field[@name='WAKLING']"
				[Register ("WAKLING")]
				public static global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType Wakling {
					get {
						if (WAKLING_jfieldId == IntPtr.Zero)
							WAKLING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WAKLING", "Lcom/baidu/mapapi/search/route/TransitRouteLine$TransitStep$TransitRouteStepType;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WAKLING_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}
				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/baidu/mapapi/search/route/TransitRouteLine$TransitStep$TransitRouteStepType", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (TransitRouteStepType); }
				}

				internal TransitRouteStepType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_valueOf_Ljava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine.TransitStep.TransitRouteStepType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/route/TransitRouteLine$TransitStep$TransitRouteStepType;", "")]
				public static unsafe global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType ValueOf (string p0)
				{
					if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
						id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/route/TransitRouteLine$TransitStep$TransitRouteStepType;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_p0);
						global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
						return __ret;
					} finally {
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}

				static IntPtr id_values;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine.TransitStep.TransitRouteStepType']/method[@name='values' and count(parameter)=0]"
				[Register ("values", "()[Lcom/baidu/mapapi/search/route/TransitRouteLine$TransitStep$TransitRouteStepType;", "")]
				public static unsafe global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType[] Values ()
				{
					if (id_values == IntPtr.Zero)
						id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/search/route/TransitRouteLine$TransitStep$TransitRouteStepType;");
					try {
						return (global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType));
					} finally {
					}
				}

			}

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/search/route/TransitRouteLine$TransitStep", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TransitStep); }
			}

			protected TransitStep (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine.TransitStep']/constructor[@name='TransitRouteLine.TransitStep' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe TransitStep ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (TransitStep)) {
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

			static Delegate cb_getEntrance;
#pragma warning disable 0169
			static Delegate GetGetEntranceHandler ()
			{
				if (cb_getEntrance == null)
					cb_getEntrance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntrance);
				return cb_getEntrance;
			}

			static IntPtr n_GetEntrance (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Entrance);
			}
#pragma warning restore 0169

			static IntPtr id_getEntrance;
			public virtual unsafe global::Com.Baidu.Mapapi.Search.Core.RouteNode Entrance {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine.TransitStep']/method[@name='getEntrance' and count(parameter)=0]"
				[Register ("getEntrance", "()Lcom/baidu/mapapi/search/core/RouteNode;", "GetGetEntranceHandler")]
				get {
					if (id_getEntrance == IntPtr.Zero)
						id_getEntrance = JNIEnv.GetMethodID (class_ref, "getEntrance", "()Lcom/baidu/mapapi/search/core/RouteNode;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallObjectMethod  (Handle, id_getEntrance), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntrance", "()Lcom/baidu/mapapi/search/core/RouteNode;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getExit;
#pragma warning disable 0169
			static Delegate GetGetExitHandler ()
			{
				if (cb_getExit == null)
					cb_getExit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExit);
				return cb_getExit;
			}

			static IntPtr n_GetExit (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Exit);
			}
#pragma warning restore 0169

			static IntPtr id_getExit;
			public virtual unsafe global::Com.Baidu.Mapapi.Search.Core.RouteNode Exit {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine.TransitStep']/method[@name='getExit' and count(parameter)=0]"
				[Register ("getExit", "()Lcom/baidu/mapapi/search/core/RouteNode;", "GetGetExitHandler")]
				get {
					if (id_getExit == IntPtr.Zero)
						id_getExit = JNIEnv.GetMethodID (class_ref, "getExit", "()Lcom/baidu/mapapi/search/core/RouteNode;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallObjectMethod  (Handle, id_getExit), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExit", "()Lcom/baidu/mapapi/search/core/RouteNode;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getInstructions;
#pragma warning disable 0169
			static Delegate GetGetInstructionsHandler ()
			{
				if (cb_getInstructions == null)
					cb_getInstructions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInstructions);
				return cb_getInstructions;
			}

			static IntPtr n_GetInstructions (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Instructions);
			}
#pragma warning restore 0169

			static IntPtr id_getInstructions;
			public virtual unsafe string Instructions {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine.TransitStep']/method[@name='getInstructions' and count(parameter)=0]"
				[Register ("getInstructions", "()Ljava/lang/String;", "GetGetInstructionsHandler")]
				get {
					if (id_getInstructions == IntPtr.Zero)
						id_getInstructions = JNIEnv.GetMethodID (class_ref, "getInstructions", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInstructions), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInstructions", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getStepType;
#pragma warning disable 0169
			static Delegate GetGetStepTypeHandler ()
			{
				if (cb_getStepType == null)
					cb_getStepType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStepType);
				return cb_getStepType;
			}

			static IntPtr n_GetStepType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.StepType);
			}
#pragma warning restore 0169

			static IntPtr id_getStepType;
			public virtual unsafe global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType StepType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine.TransitStep']/method[@name='getStepType' and count(parameter)=0]"
				[Register ("getStepType", "()Lcom/baidu/mapapi/search/route/TransitRouteLine$TransitStep$TransitRouteStepType;", "GetGetStepTypeHandler")]
				get {
					if (id_getStepType == IntPtr.Zero)
						id_getStepType = JNIEnv.GetMethodID (class_ref, "getStepType", "()Lcom/baidu/mapapi/search/route/TransitRouteLine$TransitStep$TransitRouteStepType;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType> (JNIEnv.CallObjectMethod  (Handle, id_getStepType), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep.TransitRouteStepType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStepType", "()Lcom/baidu/mapapi/search/route/TransitRouteLine$TransitStep$TransitRouteStepType;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getVehicleInfo;
#pragma warning disable 0169
			static Delegate GetGetVehicleInfoHandler ()
			{
				if (cb_getVehicleInfo == null)
					cb_getVehicleInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVehicleInfo);
				return cb_getVehicleInfo;
			}

			static IntPtr n_GetVehicleInfo (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRouteLine.TransitStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.VehicleInfo);
			}
#pragma warning restore 0169

			static IntPtr id_getVehicleInfo;
			public virtual unsafe global::Com.Baidu.Mapapi.Search.Core.VehicleInfo VehicleInfo {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine.TransitStep']/method[@name='getVehicleInfo' and count(parameter)=0]"
				[Register ("getVehicleInfo", "()Lcom/baidu/mapapi/search/core/VehicleInfo;", "GetGetVehicleInfoHandler")]
				get {
					if (id_getVehicleInfo == IntPtr.Zero)
						id_getVehicleInfo = JNIEnv.GetMethodID (class_ref, "getVehicleInfo", "()Lcom/baidu/mapapi/search/core/VehicleInfo;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.VehicleInfo> (JNIEnv.CallObjectMethod  (Handle, id_getVehicleInfo), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.VehicleInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVehicleInfo", "()Lcom/baidu/mapapi/search/core/VehicleInfo;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/route/TransitRouteLine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransitRouteLine); }
		}

		internal TransitRouteLine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getTaxitInfo;
		[Obsolete (@"deprecated")]
		public unsafe global::Com.Baidu.Mapapi.Search.Core.TaxiInfo TaxitInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRouteLine']/method[@name='getTaxitInfo' and count(parameter)=0]"
			[Register ("getTaxitInfo", "()Lcom/baidu/mapapi/search/core/TaxiInfo;", "GetGetTaxitInfoHandler")]
			get {
				if (id_getTaxitInfo == IntPtr.Zero)
					id_getTaxitInfo = JNIEnv.GetMethodID (class_ref, "getTaxitInfo", "()Lcom/baidu/mapapi/search/core/TaxiInfo;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.TaxiInfo> (JNIEnv.CallObjectMethod  (Handle, id_getTaxitInfo), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
