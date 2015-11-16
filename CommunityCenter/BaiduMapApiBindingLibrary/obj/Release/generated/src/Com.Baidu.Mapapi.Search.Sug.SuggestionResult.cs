using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Sug {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionResult']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/sug/SuggestionResult", DoNotGenerateAcw=true)]
	public partial class SuggestionResult : global::Com.Baidu.Mapapi.Search.Core.SearchResult {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionResult.SuggestionInfo']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/search/sug/SuggestionResult$SuggestionInfo", DoNotGenerateAcw=true)]
		public partial class SuggestionInfo : global::Java.Lang.Object {


			static IntPtr city_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionResult.SuggestionInfo']/field[@name='city']"
			[Register ("city")]
			public string City {
				get {
					if (city_jfieldId == IntPtr.Zero)
						city_jfieldId = JNIEnv.GetFieldID (class_ref, "city", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, city_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (city_jfieldId == IntPtr.Zero)
						city_jfieldId = JNIEnv.GetFieldID (class_ref, "city", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, city_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr district_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionResult.SuggestionInfo']/field[@name='district']"
			[Register ("district")]
			public string District {
				get {
					if (district_jfieldId == IntPtr.Zero)
						district_jfieldId = JNIEnv.GetFieldID (class_ref, "district", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, district_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (district_jfieldId == IntPtr.Zero)
						district_jfieldId = JNIEnv.GetFieldID (class_ref, "district", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, district_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr key_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionResult.SuggestionInfo']/field[@name='key']"
			[Register ("key")]
			public string Key {
				get {
					if (key_jfieldId == IntPtr.Zero)
						key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, key_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (key_jfieldId == IntPtr.Zero)
						key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, key_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr pt_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionResult.SuggestionInfo']/field[@name='pt']"
			[Register ("pt")]
			public global::Com.Baidu.Mapapi.Model.LatLng Pt {
				get {
					if (pt_jfieldId == IntPtr.Zero)
						pt_jfieldId = JNIEnv.GetFieldID (class_ref, "pt", "Lcom/baidu/mapapi/model/LatLng;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, pt_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (pt_jfieldId == IntPtr.Zero)
						pt_jfieldId = JNIEnv.GetFieldID (class_ref, "pt", "Lcom/baidu/mapapi/model/LatLng;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, pt_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr uid_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionResult.SuggestionInfo']/field[@name='uid']"
			[Register ("uid")]
			public string Uid {
				get {
					if (uid_jfieldId == IntPtr.Zero)
						uid_jfieldId = JNIEnv.GetFieldID (class_ref, "uid", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, uid_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (uid_jfieldId == IntPtr.Zero)
						uid_jfieldId = JNIEnv.GetFieldID (class_ref, "uid", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, uid_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/search/sug/SuggestionResult$SuggestionInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SuggestionInfo); }
			}

			protected SuggestionInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionResult.SuggestionInfo']/constructor[@name='SuggestionResult.SuggestionInfo' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SuggestionInfo ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (SuggestionInfo)) {
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

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/sug/SuggestionResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SuggestionResult); }
		}

		protected SuggestionResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionResult']/constructor[@name='SuggestionResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SuggestionResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SuggestionResult)) {
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

		static Delegate cb_getAllSuggestions;
#pragma warning disable 0169
		static Delegate GetGetAllSuggestionsHandler ()
		{
			if (cb_getAllSuggestions == null)
				cb_getAllSuggestions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllSuggestions);
			return cb_getAllSuggestions;
		}

		static IntPtr n_GetAllSuggestions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult.SuggestionInfo>.ToLocalJniHandle (__this.AllSuggestions);
		}
#pragma warning restore 0169

		static IntPtr id_getAllSuggestions;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult.SuggestionInfo> AllSuggestions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.sug']/class[@name='SuggestionResult']/method[@name='getAllSuggestions' and count(parameter)=0]"
			[Register ("getAllSuggestions", "()Ljava/util/List;", "GetGetAllSuggestionsHandler")]
			get {
				if (id_getAllSuggestions == IntPtr.Zero)
					id_getAllSuggestions = JNIEnv.GetMethodID (class_ref, "getAllSuggestions", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult.SuggestionInfo>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAllSuggestions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Sug.SuggestionResult.SuggestionInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllSuggestions", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
