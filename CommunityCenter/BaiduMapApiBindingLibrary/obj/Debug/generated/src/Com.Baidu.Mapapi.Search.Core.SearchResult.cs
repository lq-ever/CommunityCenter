using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/core/SearchResult", DoNotGenerateAcw=true)]
	public partial class SearchResult : global::Java.Lang.Object {


		static IntPtr error_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult']/field[@name='error']"
		[Register ("error")]
		public global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO Error {
			get {
				if (error_jfieldId == IntPtr.Zero)
					error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, error_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (error_jfieldId == IntPtr.Zero)
					error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, error_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/search/core/SearchResult$ERRORNO", DoNotGenerateAcw=true)]
		public sealed partial class ERRORNO : global::Java.Lang.Enum {


			static IntPtr AMBIGUOUS_KEYWORD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']/field[@name='AMBIGUOUS_KEYWORD']"
			[Register ("AMBIGUOUS_KEYWORD")]
			public static global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO AmbiguousKeyword {
				get {
					if (AMBIGUOUS_KEYWORD_jfieldId == IntPtr.Zero)
						AMBIGUOUS_KEYWORD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AMBIGUOUS_KEYWORD", "Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AMBIGUOUS_KEYWORD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AMBIGUOUS_ROURE_ADDR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']/field[@name='AMBIGUOUS_ROURE_ADDR']"
			[Register ("AMBIGUOUS_ROURE_ADDR")]
			public static global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO AmbiguousRoureAddr {
				get {
					if (AMBIGUOUS_ROURE_ADDR_jfieldId == IntPtr.Zero)
						AMBIGUOUS_ROURE_ADDR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AMBIGUOUS_ROURE_ADDR", "Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AMBIGUOUS_ROURE_ADDR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr KEY_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']/field[@name='KEY_ERROR']"
			[Register ("KEY_ERROR")]
			public static global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO KeyError {
				get {
					if (KEY_ERROR_jfieldId == IntPtr.Zero)
						KEY_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY_ERROR", "Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KEY_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NETWORK_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']/field[@name='NETWORK_ERROR']"
			[Register ("NETWORK_ERROR")]
			public static global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO NetworkError {
				get {
					if (NETWORK_ERROR_jfieldId == IntPtr.Zero)
						NETWORK_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_ERROR", "Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NETWORK_TIME_OUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']/field[@name='NETWORK_TIME_OUT']"
			[Register ("NETWORK_TIME_OUT")]
			public static global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO NetworkTimeOut {
				get {
					if (NETWORK_TIME_OUT_jfieldId == IntPtr.Zero)
						NETWORK_TIME_OUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_TIME_OUT", "Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_TIME_OUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NOT_SUPPORT_BUS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']/field[@name='NOT_SUPPORT_BUS']"
			[Register ("NOT_SUPPORT_BUS")]
			public static global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO NotSupportBus {
				get {
					if (NOT_SUPPORT_BUS_jfieldId == IntPtr.Zero)
						NOT_SUPPORT_BUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_SUPPORT_BUS", "Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_SUPPORT_BUS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NOT_SUPPORT_BUS_2CITY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']/field[@name='NOT_SUPPORT_BUS_2CITY']"
			[Register ("NOT_SUPPORT_BUS_2CITY")]
			public static global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO NotSupportBus2city {
				get {
					if (NOT_SUPPORT_BUS_2CITY_jfieldId == IntPtr.Zero)
						NOT_SUPPORT_BUS_2CITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_SUPPORT_BUS_2CITY", "Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_SUPPORT_BUS_2CITY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NO_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']/field[@name='NO_ERROR']"
			[Register ("NO_ERROR")]
			public static global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO NoError {
				get {
					if (NO_ERROR_jfieldId == IntPtr.Zero)
						NO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_ERROR", "Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PERMISSION_UNFINISHED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']/field[@name='PERMISSION_UNFINISHED']"
			[Register ("PERMISSION_UNFINISHED")]
			public static global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO PermissionUnfinished {
				get {
					if (PERMISSION_UNFINISHED_jfieldId == IntPtr.Zero)
						PERMISSION_UNFINISHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSION_UNFINISHED", "Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PERMISSION_UNFINISHED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RESULT_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']/field[@name='RESULT_NOT_FOUND']"
			[Register ("RESULT_NOT_FOUND")]
			public static global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO ResultNotFound {
				get {
					if (RESULT_NOT_FOUND_jfieldId == IntPtr.Zero)
						RESULT_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESULT_NOT_FOUND", "Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESULT_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ST_EN_TOO_NEAR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']/field[@name='ST_EN_TOO_NEAR']"
			[Register ("ST_EN_TOO_NEAR")]
			public static global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO StEnTooNear {
				get {
					if (ST_EN_TOO_NEAR_jfieldId == IntPtr.Zero)
						ST_EN_TOO_NEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ST_EN_TOO_NEAR", "Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ST_EN_TOO_NEAR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/search/core/SearchResult$ERRORNO", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ERRORNO); }
			}

			internal ERRORNO (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult.ERRORNO']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;");
				try {
					return (global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/core/SearchResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SearchResult); }
		}

		protected SearchResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult']/constructor[@name='SearchResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SearchResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SearchResult)) {
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

		static IntPtr id_ctor_Lcom_baidu_mapapi_search_core_SearchResult_ERRORNO_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='SearchResult']/constructor[@name='SearchResult' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.core.SearchResult.ERRORNO']]"
		[Register (".ctor", "(Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;)V", "")]
		public unsafe SearchResult (global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SearchResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;)V", __args);
					return;
				}

				if (id_ctor_Lcom_baidu_mapapi_search_core_SearchResult_ERRORNO_ == IntPtr.Zero)
					id_ctor_Lcom_baidu_mapapi_search_core_SearchResult_ERRORNO_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_baidu_mapapi_search_core_SearchResult_ERRORNO_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_baidu_mapapi_search_core_SearchResult_ERRORNO_, __args);
			} finally {
			}
		}

	}
}
