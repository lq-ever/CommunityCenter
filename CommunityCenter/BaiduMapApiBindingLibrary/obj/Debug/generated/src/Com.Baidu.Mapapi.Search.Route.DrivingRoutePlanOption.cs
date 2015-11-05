using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Route {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/DrivingRoutePlanOption", DoNotGenerateAcw=true)]
	public partial class DrivingRoutePlanOption : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingPolicy']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingPolicy", DoNotGenerateAcw=true)]
		public sealed partial class DrivingPolicy : global::Java.Lang.Enum {


			static IntPtr ECAR_AVOID_JAM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingPolicy']/field[@name='ECAR_AVOID_JAM']"
			[Register ("ECAR_AVOID_JAM")]
			public static global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy EcarAvoidJam {
				get {
					if (ECAR_AVOID_JAM_jfieldId == IntPtr.Zero)
						ECAR_AVOID_JAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ECAR_AVOID_JAM", "Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingPolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ECAR_AVOID_JAM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ECAR_DIS_FIRST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingPolicy']/field[@name='ECAR_DIS_FIRST']"
			[Register ("ECAR_DIS_FIRST")]
			public static global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy EcarDisFirst {
				get {
					if (ECAR_DIS_FIRST_jfieldId == IntPtr.Zero)
						ECAR_DIS_FIRST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ECAR_DIS_FIRST", "Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingPolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ECAR_DIS_FIRST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ECAR_FEE_FIRST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingPolicy']/field[@name='ECAR_FEE_FIRST']"
			[Register ("ECAR_FEE_FIRST")]
			public static global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy EcarFeeFirst {
				get {
					if (ECAR_FEE_FIRST_jfieldId == IntPtr.Zero)
						ECAR_FEE_FIRST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ECAR_FEE_FIRST", "Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingPolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ECAR_FEE_FIRST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ECAR_TIME_FIRST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingPolicy']/field[@name='ECAR_TIME_FIRST']"
			[Register ("ECAR_TIME_FIRST")]
			public static global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy EcarTimeFirst {
				get {
					if (ECAR_TIME_FIRST_jfieldId == IntPtr.Zero)
						ECAR_TIME_FIRST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ECAR_TIME_FIRST", "Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingPolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ECAR_TIME_FIRST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingPolicy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DrivingPolicy); }
			}

			internal DrivingPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getInt;
			public unsafe int Int {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingPolicy']/method[@name='getInt' and count(parameter)=0]"
				[Register ("getInt", "()I", "GetGetIntHandler")]
				get {
					if (id_getInt == IntPtr.Zero)
						id_getInt = JNIEnv.GetMethodID (class_ref, "getInt", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getInt);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingPolicy;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingPolicy;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingPolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingPolicy;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingPolicy;");
				try {
					return (global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingTrafficPolicy']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingTrafficPolicy", DoNotGenerateAcw=true)]
		public sealed partial class DrivingTrafficPolicy : global::Java.Lang.Enum {


			static IntPtr ROUTE_PATH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingTrafficPolicy']/field[@name='ROUTE_PATH']"
			[Register ("ROUTE_PATH")]
			public static global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingTrafficPolicy RoutePath {
				get {
					if (ROUTE_PATH_jfieldId == IntPtr.Zero)
						ROUTE_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROUTE_PATH", "Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingTrafficPolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ROUTE_PATH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingTrafficPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ROUTE_PATH_AND_TRAFFIC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingTrafficPolicy']/field[@name='ROUTE_PATH_AND_TRAFFIC']"
			[Register ("ROUTE_PATH_AND_TRAFFIC")]
			public static global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingTrafficPolicy RoutePathAndTraffic {
				get {
					if (ROUTE_PATH_AND_TRAFFIC_jfieldId == IntPtr.Zero)
						ROUTE_PATH_AND_TRAFFIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROUTE_PATH_AND_TRAFFIC", "Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingTrafficPolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ROUTE_PATH_AND_TRAFFIC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingTrafficPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingTrafficPolicy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DrivingTrafficPolicy); }
			}

			internal DrivingTrafficPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getInt;
			public unsafe int Int {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingTrafficPolicy']/method[@name='getInt' and count(parameter)=0]"
				[Register ("getInt", "()I", "GetGetIntHandler")]
				get {
					if (id_getInt == IntPtr.Zero)
						id_getInt = JNIEnv.GetMethodID (class_ref, "getInt", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getInt);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingTrafficPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingTrafficPolicy;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingTrafficPolicy ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingTrafficPolicy;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingTrafficPolicy __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingTrafficPolicy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption.DrivingTrafficPolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingTrafficPolicy;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingTrafficPolicy[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingTrafficPolicy;");
				try {
					return (global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingTrafficPolicy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingTrafficPolicy));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/route/DrivingRoutePlanOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrivingRoutePlanOption); }
		}

		protected DrivingRoutePlanOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption']/constructor[@name='DrivingRoutePlanOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DrivingRoutePlanOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DrivingRoutePlanOption)) {
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

		static Delegate cb_from_Lcom_baidu_mapapi_search_route_PlanNode_;
#pragma warning disable 0169
		static Delegate GetFrom_Lcom_baidu_mapapi_search_route_PlanNode_Handler ()
		{
			if (cb_from_Lcom_baidu_mapapi_search_route_PlanNode_ == null)
				cb_from_Lcom_baidu_mapapi_search_route_PlanNode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_From_Lcom_baidu_mapapi_search_route_PlanNode_);
			return cb_from_Lcom_baidu_mapapi_search_route_PlanNode_;
		}

		static IntPtr n_From_Lcom_baidu_mapapi_search_route_PlanNode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Route.PlanNode p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.PlanNode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.From (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_from_Lcom_baidu_mapapi_search_route_PlanNode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption']/method[@name='from' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.PlanNode']]"
		[Register ("from", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;", "GetFrom_Lcom_baidu_mapapi_search_route_PlanNode_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption From (global::Com.Baidu.Mapapi.Search.Route.PlanNode p0)
		{
			if (id_from_Lcom_baidu_mapapi_search_route_PlanNode_ == IntPtr.Zero)
				id_from_Lcom_baidu_mapapi_search_route_PlanNode_ = JNIEnv.GetMethodID (class_ref, "from", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (JNIEnv.CallObjectMethod  (Handle, id_from_Lcom_baidu_mapapi_search_route_PlanNode_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "from", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_passBy_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetPassBy_Ljava_util_List_Handler ()
		{
			if (cb_passBy_Ljava_util_List_ == null)
				cb_passBy_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PassBy_Ljava_util_List_);
			return cb_passBy_Ljava_util_List_;
		}

		static IntPtr n_PassBy_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Route.PlanNode>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PassBy (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_passBy_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption']/method[@name='passBy' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.search.route.PlanNode&gt;']]"
		[Register ("passBy", "(Ljava/util/List;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;", "GetPassBy_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption PassBy (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Route.PlanNode> p0)
		{
			if (id_passBy_Ljava_util_List_ == IntPtr.Zero)
				id_passBy_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "passBy", "(Ljava/util/List;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Route.PlanNode>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (JNIEnv.CallObjectMethod  (Handle, id_passBy_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "passBy", "(Ljava/util/List;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_policy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingPolicy_;
#pragma warning disable 0169
		static Delegate GetPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingPolicy_Handler ()
		{
			if (cb_policy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingPolicy_ == null)
				cb_policy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingPolicy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Policy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingPolicy_);
			return cb_policy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingPolicy_;
		}

		static IntPtr n_Policy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingPolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Policy (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_policy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingPolicy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption']/method[@name='policy' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.DrivingRoutePlanOption.DrivingPolicy']]"
		[Register ("policy", "(Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingPolicy;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;", "GetPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingPolicy_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption Policy (global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingPolicy p0)
		{
			if (id_policy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingPolicy_ == IntPtr.Zero)
				id_policy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingPolicy_ = JNIEnv.GetMethodID (class_ref, "policy", "(Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingPolicy;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (JNIEnv.CallObjectMethod  (Handle, id_policy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingPolicy_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "policy", "(Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingPolicy;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_to_Lcom_baidu_mapapi_search_route_PlanNode_;
#pragma warning disable 0169
		static Delegate GetTo_Lcom_baidu_mapapi_search_route_PlanNode_Handler ()
		{
			if (cb_to_Lcom_baidu_mapapi_search_route_PlanNode_ == null)
				cb_to_Lcom_baidu_mapapi_search_route_PlanNode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_To_Lcom_baidu_mapapi_search_route_PlanNode_);
			return cb_to_Lcom_baidu_mapapi_search_route_PlanNode_;
		}

		static IntPtr n_To_Lcom_baidu_mapapi_search_route_PlanNode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Route.PlanNode p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.PlanNode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.To (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_to_Lcom_baidu_mapapi_search_route_PlanNode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption']/method[@name='to' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.PlanNode']]"
		[Register ("to", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;", "GetTo_Lcom_baidu_mapapi_search_route_PlanNode_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption To (global::Com.Baidu.Mapapi.Search.Route.PlanNode p0)
		{
			if (id_to_Lcom_baidu_mapapi_search_route_PlanNode_ == IntPtr.Zero)
				id_to_Lcom_baidu_mapapi_search_route_PlanNode_ = JNIEnv.GetMethodID (class_ref, "to", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (JNIEnv.CallObjectMethod  (Handle, id_to_Lcom_baidu_mapapi_search_route_PlanNode_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "to", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_trafficPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingTrafficPolicy_;
#pragma warning disable 0169
		static Delegate GetTrafficPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingTrafficPolicy_Handler ()
		{
			if (cb_trafficPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingTrafficPolicy_ == null)
				cb_trafficPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingTrafficPolicy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TrafficPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingTrafficPolicy_);
			return cb_trafficPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingTrafficPolicy_;
		}

		static IntPtr n_TrafficPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingTrafficPolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingTrafficPolicy p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingTrafficPolicy> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TrafficPolicy (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_trafficPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingTrafficPolicy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRoutePlanOption']/method[@name='trafficPolicy' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.DrivingRoutePlanOption.DrivingTrafficPolicy']]"
		[Register ("trafficPolicy", "(Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingTrafficPolicy;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;", "GetTrafficPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingTrafficPolicy_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption TrafficPolicy (global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption.DrivingTrafficPolicy p0)
		{
			if (id_trafficPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingTrafficPolicy_ == IntPtr.Zero)
				id_trafficPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingTrafficPolicy_ = JNIEnv.GetMethodID (class_ref, "trafficPolicy", "(Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingTrafficPolicy;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (JNIEnv.CallObjectMethod  (Handle, id_trafficPolicy_Lcom_baidu_mapapi_search_route_DrivingRoutePlanOption_DrivingTrafficPolicy_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRoutePlanOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trafficPolicy", "(Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption$DrivingTrafficPolicy;)Lcom/baidu/mapapi/search/route/DrivingRoutePlanOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
