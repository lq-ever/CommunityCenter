using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Platform.Comjni.Map.Search {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']"
	[global::Android.Runtime.Register ("com/baidu/platform/comjni/map/search/JNISearch", DoNotGenerateAcw=true)]
	public partial class JNISearch : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/platform/comjni/map/search/JNISearch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JNISearch); }
		}

		protected JNISearch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/constructor[@name='JNISearch' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JNISearch ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JNISearch)) {
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

		static Delegate cb_AreaSearch_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetAreaSearch_JLandroid_os_Bundle_Handler ()
		{
			if (cb_AreaSearch_JLandroid_os_Bundle_ == null)
				cb_AreaSearch_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_AreaSearch_JLandroid_os_Bundle_);
			return cb_AreaSearch_JLandroid_os_Bundle_;
		}

		static bool n_AreaSearch_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AreaSearch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AreaSearch_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='AreaSearch' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("AreaSearch", "(JLandroid/os/Bundle;)Z", "GetAreaSearch_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool AreaSearch (long p0, global::Android.OS.Bundle p1)
		{
			if (id_AreaSearch_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_AreaSearch_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "AreaSearch", "(JLandroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_AreaSearch_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AreaSearch", "(JLandroid/os/Bundle;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_BusLineDetailSearch_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBusLineDetailSearch_JLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_BusLineDetailSearch_JLjava_lang_String_Ljava_lang_String_ == null)
				cb_BusLineDetailSearch_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, bool>) n_BusLineDetailSearch_JLjava_lang_String_Ljava_lang_String_);
			return cb_BusLineDetailSearch_JLjava_lang_String_Ljava_lang_String_;
		}

		static bool n_BusLineDetailSearch_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.BusLineDetailSearch (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_BusLineDetailSearch_JLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='BusLineDetailSearch' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("BusLineDetailSearch", "(JLjava/lang/String;Ljava/lang/String;)Z", "GetBusLineDetailSearch_JLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool BusLineDetailSearch (long p0, string p1, string p2)
		{
			if (id_BusLineDetailSearch_JLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_BusLineDetailSearch_JLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "BusLineDetailSearch", "(JLjava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_BusLineDetailSearch_JLjava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "BusLineDetailSearch", "(JLjava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_Create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_Create == null)
				cb_Create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Create);
			return cb_Create;
		}

		static long n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Create ();
		}
#pragma warning restore 0169

		static IntPtr id_Create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='Create' and count(parameter)=0]"
		[Register ("Create", "()J", "GetCreateHandler")]
		public virtual unsafe long Create ()
		{
			if (id_Create == IntPtr.Zero)
				id_Create = JNIEnv.GetMethodID (class_ref, "Create", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_Create);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Create", "()J"));
			} finally {
			}
		}

		static Delegate cb_ForceSearchByCityName_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetForceSearchByCityName_JLandroid_os_Bundle_Handler ()
		{
			if (cb_ForceSearchByCityName_JLandroid_os_Bundle_ == null)
				cb_ForceSearchByCityName_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_ForceSearchByCityName_JLandroid_os_Bundle_);
			return cb_ForceSearchByCityName_JLandroid_os_Bundle_;
		}

		static bool n_ForceSearchByCityName_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ForceSearchByCityName (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ForceSearchByCityName_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='ForceSearchByCityName' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("ForceSearchByCityName", "(JLandroid/os/Bundle;)Z", "GetForceSearchByCityName_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool ForceSearchByCityName (long p0, global::Android.OS.Bundle p1)
		{
			if (id_ForceSearchByCityName_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_ForceSearchByCityName_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "ForceSearchByCityName", "(JLandroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_ForceSearchByCityName_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ForceSearchByCityName", "(JLandroid/os/Bundle;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_GetSearchResult_JI;
#pragma warning disable 0169
		static Delegate GetGetSearchResult_JIHandler ()
		{
			if (cb_GetSearchResult_JI == null)
				cb_GetSearchResult_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, IntPtr>) n_GetSearchResult_JI);
			return cb_GetSearchResult_JI;
		}

		static IntPtr n_GetSearchResult_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetSearchResult (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_GetSearchResult_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='GetSearchResult' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("GetSearchResult", "(JI)Ljava/lang/String;", "GetGetSearchResult_JIHandler")]
		public virtual unsafe string GetSearchResult (long p0, int p1)
		{
			if (id_GetSearchResult_JI == IntPtr.Zero)
				id_GetSearchResult_JI = JNIEnv.GetMethodID (class_ref, "GetSearchResult", "(JI)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetSearchResult_JI, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSearchResult", "(JI)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_MapBoundSearch_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetMapBoundSearch_JLandroid_os_Bundle_Handler ()
		{
			if (cb_MapBoundSearch_JLandroid_os_Bundle_ == null)
				cb_MapBoundSearch_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_MapBoundSearch_JLandroid_os_Bundle_);
			return cb_MapBoundSearch_JLandroid_os_Bundle_;
		}

		static bool n_MapBoundSearch_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MapBoundSearch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_MapBoundSearch_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='MapBoundSearch' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("MapBoundSearch", "(JLandroid/os/Bundle;)Z", "GetMapBoundSearch_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool MapBoundSearch (long p0, global::Android.OS.Bundle p1)
		{
			if (id_MapBoundSearch_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_MapBoundSearch_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "MapBoundSearch", "(JLandroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_MapBoundSearch_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "MapBoundSearch", "(JLandroid/os/Bundle;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_POIDetailSearchPlace_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPOIDetailSearchPlace_JLjava_lang_String_Handler ()
		{
			if (cb_POIDetailSearchPlace_JLjava_lang_String_ == null)
				cb_POIDetailSearchPlace_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_POIDetailSearchPlace_JLjava_lang_String_);
			return cb_POIDetailSearchPlace_JLjava_lang_String_;
		}

		static bool n_POIDetailSearchPlace_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.POIDetailSearchPlace (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_POIDetailSearchPlace_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='POIDetailSearchPlace' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("POIDetailSearchPlace", "(JLjava/lang/String;)Z", "GetPOIDetailSearchPlace_JLjava_lang_String_Handler")]
		public virtual unsafe bool POIDetailSearchPlace (long p0, string p1)
		{
			if (id_POIDetailSearchPlace_JLjava_lang_String_ == IntPtr.Zero)
				id_POIDetailSearchPlace_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "POIDetailSearchPlace", "(JLjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_POIDetailSearchPlace_JLjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "POIDetailSearchPlace", "(JLjava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_PoiDetailShareUrlSearch_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPoiDetailShareUrlSearch_JLjava_lang_String_Handler ()
		{
			if (cb_PoiDetailShareUrlSearch_JLjava_lang_String_ == null)
				cb_PoiDetailShareUrlSearch_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_PoiDetailShareUrlSearch_JLjava_lang_String_);
			return cb_PoiDetailShareUrlSearch_JLjava_lang_String_;
		}

		static bool n_PoiDetailShareUrlSearch_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PoiDetailShareUrlSearch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_PoiDetailShareUrlSearch_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='PoiDetailShareUrlSearch' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("PoiDetailShareUrlSearch", "(JLjava/lang/String;)Z", "GetPoiDetailShareUrlSearch_JLjava_lang_String_Handler")]
		public virtual unsafe bool PoiDetailShareUrlSearch (long p0, string p1)
		{
			if (id_PoiDetailShareUrlSearch_JLjava_lang_String_ == IntPtr.Zero)
				id_PoiDetailShareUrlSearch_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "PoiDetailShareUrlSearch", "(JLjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_PoiDetailShareUrlSearch_JLjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "PoiDetailShareUrlSearch", "(JLjava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_PoiRGCShareUrlSearch_JIILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPoiRGCShareUrlSearch_JIILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_PoiRGCShareUrlSearch_JIILjava_lang_String_Ljava_lang_String_ == null)
				cb_PoiRGCShareUrlSearch_JIILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, int, IntPtr, IntPtr, bool>) n_PoiRGCShareUrlSearch_JIILjava_lang_String_Ljava_lang_String_);
			return cb_PoiRGCShareUrlSearch_JIILjava_lang_String_Ljava_lang_String_;
		}

		static bool n_PoiRGCShareUrlSearch_JIILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PoiRGCShareUrlSearch (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_PoiRGCShareUrlSearch_JIILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='PoiRGCShareUrlSearch' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("PoiRGCShareUrlSearch", "(JIILjava/lang/String;Ljava/lang/String;)Z", "GetPoiRGCShareUrlSearch_JIILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool PoiRGCShareUrlSearch (long p0, int p1, int p2, string p3, string p4)
		{
			if (id_PoiRGCShareUrlSearch_JIILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_PoiRGCShareUrlSearch_JIILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "PoiRGCShareUrlSearch", "(JIILjava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_PoiRGCShareUrlSearch_JIILjava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "PoiRGCShareUrlSearch", "(JIILjava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_Release_J;
#pragma warning disable 0169
		static Delegate GetRelease_JHandler ()
		{
			if (cb_Release_J == null)
				cb_Release_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int>) n_Release_J);
			return cb_Release_J;
		}

		static int n_Release_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Release (p0);
		}
#pragma warning restore 0169

		static IntPtr id_Release_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='Release' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Release", "(J)I", "GetRelease_JHandler")]
		public virtual unsafe int Release (long p0)
		{
			if (id_Release_J == IntPtr.Zero)
				id_Release_J = JNIEnv.GetMethodID (class_ref, "Release", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_Release_J, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Release", "(J)I"), __args);
			} finally {
			}
		}

		static Delegate cb_ReverseGeocodeSearch_JII;
#pragma warning disable 0169
		static Delegate GetReverseGeocodeSearch_JIIHandler ()
		{
			if (cb_ReverseGeocodeSearch_JII == null)
				cb_ReverseGeocodeSearch_JII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, int, bool>) n_ReverseGeocodeSearch_JII);
			return cb_ReverseGeocodeSearch_JII;
		}

		static bool n_ReverseGeocodeSearch_JII (IntPtr jnienv, IntPtr native__this, long p0, int p1, int p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReverseGeocodeSearch (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_ReverseGeocodeSearch_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='ReverseGeocodeSearch' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ReverseGeocodeSearch", "(JII)Z", "GetReverseGeocodeSearch_JIIHandler")]
		public virtual unsafe bool ReverseGeocodeSearch (long p0, int p1, int p2)
		{
			if (id_ReverseGeocodeSearch_JII == IntPtr.Zero)
				id_ReverseGeocodeSearch_JII = JNIEnv.GetMethodID (class_ref, "ReverseGeocodeSearch", "(JII)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_ReverseGeocodeSearch_JII, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReverseGeocodeSearch", "(JII)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_RoutePlanByBus_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRoutePlanByBus_JLandroid_os_Bundle_Handler ()
		{
			if (cb_RoutePlanByBus_JLandroid_os_Bundle_ == null)
				cb_RoutePlanByBus_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_RoutePlanByBus_JLandroid_os_Bundle_);
			return cb_RoutePlanByBus_JLandroid_os_Bundle_;
		}

		static bool n_RoutePlanByBus_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RoutePlanByBus (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RoutePlanByBus_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='RoutePlanByBus' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("RoutePlanByBus", "(JLandroid/os/Bundle;)Z", "GetRoutePlanByBus_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool RoutePlanByBus (long p0, global::Android.OS.Bundle p1)
		{
			if (id_RoutePlanByBus_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_RoutePlanByBus_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "RoutePlanByBus", "(JLandroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_RoutePlanByBus_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RoutePlanByBus", "(JLandroid/os/Bundle;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RoutePlanByCar_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRoutePlanByCar_JLandroid_os_Bundle_Handler ()
		{
			if (cb_RoutePlanByCar_JLandroid_os_Bundle_ == null)
				cb_RoutePlanByCar_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_RoutePlanByCar_JLandroid_os_Bundle_);
			return cb_RoutePlanByCar_JLandroid_os_Bundle_;
		}

		static bool n_RoutePlanByCar_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RoutePlanByCar (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RoutePlanByCar_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='RoutePlanByCar' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("RoutePlanByCar", "(JLandroid/os/Bundle;)Z", "GetRoutePlanByCar_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool RoutePlanByCar (long p0, global::Android.OS.Bundle p1)
		{
			if (id_RoutePlanByCar_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_RoutePlanByCar_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "RoutePlanByCar", "(JLandroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_RoutePlanByCar_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RoutePlanByCar", "(JLandroid/os/Bundle;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_RoutePlanByFoot_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRoutePlanByFoot_JLandroid_os_Bundle_Handler ()
		{
			if (cb_RoutePlanByFoot_JLandroid_os_Bundle_ == null)
				cb_RoutePlanByFoot_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_RoutePlanByFoot_JLandroid_os_Bundle_);
			return cb_RoutePlanByFoot_JLandroid_os_Bundle_;
		}

		static bool n_RoutePlanByFoot_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RoutePlanByFoot (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RoutePlanByFoot_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='RoutePlanByFoot' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("RoutePlanByFoot", "(JLandroid/os/Bundle;)Z", "GetRoutePlanByFoot_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool RoutePlanByFoot (long p0, global::Android.OS.Bundle p1)
		{
			if (id_RoutePlanByFoot_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_RoutePlanByFoot_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "RoutePlanByFoot", "(JLandroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_RoutePlanByFoot_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RoutePlanByFoot", "(JLandroid/os/Bundle;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_SuggestionSearch_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSuggestionSearch_JLandroid_os_Bundle_Handler ()
		{
			if (cb_SuggestionSearch_JLandroid_os_Bundle_ == null)
				cb_SuggestionSearch_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_SuggestionSearch_JLandroid_os_Bundle_);
			return cb_SuggestionSearch_JLandroid_os_Bundle_;
		}

		static bool n_SuggestionSearch_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SuggestionSearch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SuggestionSearch_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='SuggestionSearch' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("SuggestionSearch", "(JLandroid/os/Bundle;)Z", "GetSuggestionSearch_JLandroid_os_Bundle_Handler")]
		public virtual unsafe bool SuggestionSearch (long p0, global::Android.OS.Bundle p1)
		{
			if (id_SuggestionSearch_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_SuggestionSearch_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "SuggestionSearch", "(JLandroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SuggestionSearch_JLandroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SuggestionSearch", "(JLandroid/os/Bundle;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_geocode_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGeocode_JLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_geocode_JLjava_lang_String_Ljava_lang_String_ == null)
				cb_geocode_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, bool>) n_Geocode_JLjava_lang_String_Ljava_lang_String_);
			return cb_geocode_JLjava_lang_String_Ljava_lang_String_;
		}

		static bool n_Geocode_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Platform.Comjni.Map.Search.JNISearch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Geocode (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_geocode_JLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.platform.comjni.map.search']/class[@name='JNISearch']/method[@name='geocode' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("geocode", "(JLjava/lang/String;Ljava/lang/String;)Z", "GetGeocode_JLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool Geocode (long p0, string p1, string p2)
		{
			if (id_geocode_JLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_geocode_JLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "geocode", "(JLjava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_geocode_JLjava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "geocode", "(JLjava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
