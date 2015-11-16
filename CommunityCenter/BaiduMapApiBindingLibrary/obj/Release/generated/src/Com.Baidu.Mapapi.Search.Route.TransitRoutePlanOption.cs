using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Route {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/TransitRoutePlanOption", DoNotGenerateAcw=true)]
	public partial class TransitRoutePlanOption : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption.TransitPolicy']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/TransitRoutePlanOption$TransitPolicy", DoNotGenerateAcw=true)]
		public sealed partial class TransitPolicy : global::Java.Lang.Enum {


			static IntPtr EBUS_NO_SUBWAY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption.TransitPolicy']/field[@name='EBUS_NO_SUBWAY']"
			[Register ("EBUS_NO_SUBWAY")]
			public static global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy EbusNoSubway {
				get {
					if (EBUS_NO_SUBWAY_jfieldId == IntPtr.Zero)
						EBUS_NO_SUBWAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EBUS_NO_SUBWAY", "Lcom/baidu/mapapi/search/route/TransitRoutePlanOption$TransitPolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EBUS_NO_SUBWAY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EBUS_TIME_FIRST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption.TransitPolicy']/field[@name='EBUS_TIME_FIRST']"
			[Register ("EBUS_TIME_FIRST")]
			public static global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy EbusTimeFirst {
				get {
					if (EBUS_TIME_FIRST_jfieldId == IntPtr.Zero)
						EBUS_TIME_FIRST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EBUS_TIME_FIRST", "Lcom/baidu/mapapi/search/route/TransitRoutePlanOption$TransitPolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EBUS_TIME_FIRST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EBUS_TRANSFER_FIRST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption.TransitPolicy']/field[@name='EBUS_TRANSFER_FIRST']"
			[Register ("EBUS_TRANSFER_FIRST")]
			public static global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy EbusTransferFirst {
				get {
					if (EBUS_TRANSFER_FIRST_jfieldId == IntPtr.Zero)
						EBUS_TRANSFER_FIRST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EBUS_TRANSFER_FIRST", "Lcom/baidu/mapapi/search/route/TransitRoutePlanOption$TransitPolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EBUS_TRANSFER_FIRST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EBUS_WALK_FIRST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption.TransitPolicy']/field[@name='EBUS_WALK_FIRST']"
			[Register ("EBUS_WALK_FIRST")]
			public static global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy EbusWalkFirst {
				get {
					if (EBUS_WALK_FIRST_jfieldId == IntPtr.Zero)
						EBUS_WALK_FIRST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EBUS_WALK_FIRST", "Lcom/baidu/mapapi/search/route/TransitRoutePlanOption$TransitPolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EBUS_WALK_FIRST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/search/route/TransitRoutePlanOption$TransitPolicy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TransitPolicy); }
			}

			internal TransitPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getInt;
			public unsafe int Int {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption.TransitPolicy']/method[@name='getInt' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption.TransitPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption$TransitPolicy;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption$TransitPolicy;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption.TransitPolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/search/route/TransitRoutePlanOption$TransitPolicy;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/search/route/TransitRoutePlanOption$TransitPolicy;");
				try {
					return (global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/route/TransitRoutePlanOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransitRoutePlanOption); }
		}

		protected TransitRoutePlanOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption']/constructor[@name='TransitRoutePlanOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TransitRoutePlanOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TransitRoutePlanOption)) {
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

		static Delegate cb_city_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCity_Ljava_lang_String_Handler ()
		{
			if (cb_city_Ljava_lang_String_ == null)
				cb_city_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_City_Ljava_lang_String_);
			return cb_city_Ljava_lang_String_;
		}

		static IntPtr n_City_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.City (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_city_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption']/method[@name='city' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("city", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;", "GetCity_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption City (string p0)
		{
			if (id_city_Ljava_lang_String_ == IntPtr.Zero)
				id_city_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "city", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption> (JNIEnv.CallObjectMethod  (Handle, id_city_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "city", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Route.PlanNode p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.PlanNode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.From (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_from_Lcom_baidu_mapapi_search_route_PlanNode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption']/method[@name='from' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.PlanNode']]"
		[Register ("from", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;", "GetFrom_Lcom_baidu_mapapi_search_route_PlanNode_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption From (global::Com.Baidu.Mapapi.Search.Route.PlanNode p0)
		{
			if (id_from_Lcom_baidu_mapapi_search_route_PlanNode_ == IntPtr.Zero)
				id_from_Lcom_baidu_mapapi_search_route_PlanNode_ = JNIEnv.GetMethodID (class_ref, "from", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption> (JNIEnv.CallObjectMethod  (Handle, id_from_Lcom_baidu_mapapi_search_route_PlanNode_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "from", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_policy_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_TransitPolicy_;
#pragma warning disable 0169
		static Delegate GetPolicy_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_TransitPolicy_Handler ()
		{
			if (cb_policy_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_TransitPolicy_ == null)
				cb_policy_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_TransitPolicy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Policy_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_TransitPolicy_);
			return cb_policy_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_TransitPolicy_;
		}

		static IntPtr n_Policy_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_TransitPolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Policy (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_policy_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_TransitPolicy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption']/method[@name='policy' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.TransitRoutePlanOption.TransitPolicy']]"
		[Register ("policy", "(Lcom/baidu/mapapi/search/route/TransitRoutePlanOption$TransitPolicy;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;", "GetPolicy_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_TransitPolicy_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption Policy (global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption.TransitPolicy p0)
		{
			if (id_policy_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_TransitPolicy_ == IntPtr.Zero)
				id_policy_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_TransitPolicy_ = JNIEnv.GetMethodID (class_ref, "policy", "(Lcom/baidu/mapapi/search/route/TransitRoutePlanOption$TransitPolicy;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption> (JNIEnv.CallObjectMethod  (Handle, id_policy_Lcom_baidu_mapapi_search_route_TransitRoutePlanOption_TransitPolicy_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "policy", "(Lcom/baidu/mapapi/search/route/TransitRoutePlanOption$TransitPolicy;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Search.Route.PlanNode p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.PlanNode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.To (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_to_Lcom_baidu_mapapi_search_route_PlanNode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='TransitRoutePlanOption']/method[@name='to' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.route.PlanNode']]"
		[Register ("to", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;", "GetTo_Lcom_baidu_mapapi_search_route_PlanNode_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption To (global::Com.Baidu.Mapapi.Search.Route.PlanNode p0)
		{
			if (id_to_Lcom_baidu_mapapi_search_route_PlanNode_ == IntPtr.Zero)
				id_to_Lcom_baidu_mapapi_search_route_PlanNode_ = JNIEnv.GetMethodID (class_ref, "to", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption> (JNIEnv.CallObjectMethod  (Handle, id_to_Lcom_baidu_mapapi_search_route_PlanNode_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.TransitRoutePlanOption> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "to", "(Lcom/baidu/mapapi/search/route/PlanNode;)Lcom/baidu/mapapi/search/route/TransitRoutePlanOption;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
