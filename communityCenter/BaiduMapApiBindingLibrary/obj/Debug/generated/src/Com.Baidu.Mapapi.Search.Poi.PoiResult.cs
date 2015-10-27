using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Poi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiResult']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/poi/PoiResult", DoNotGenerateAcw=true)]
	public partial class PoiResult : global::Com.Baidu.Mapapi.Search.Core.SearchResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/poi/PoiResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PoiResult); }
		}

		protected PoiResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAllPoi;
#pragma warning disable 0169
		static Delegate GetGetAllPoiHandler ()
		{
			if (cb_getAllPoi == null)
				cb_getAllPoi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllPoi);
			return cb_getAllPoi;
		}

		static IntPtr n_GetAllPoi (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>.ToLocalJniHandle (__this.AllPoi);
		}
#pragma warning restore 0169

		static IntPtr id_getAllPoi;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo> AllPoi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiResult']/method[@name='getAllPoi' and count(parameter)=0]"
			[Register ("getAllPoi", "()Ljava/util/List;", "GetGetAllPoiHandler")]
			get {
				if (id_getAllPoi == IntPtr.Zero)
					id_getAllPoi = JNIEnv.GetMethodID (class_ref, "getAllPoi", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAllPoi), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllPoi", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentPageCapacity;
#pragma warning disable 0169
		static Delegate GetGetCurrentPageCapacityHandler ()
		{
			if (cb_getCurrentPageCapacity == null)
				cb_getCurrentPageCapacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentPageCapacity);
			return cb_getCurrentPageCapacity;
		}

		static int n_GetCurrentPageCapacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPageCapacity;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPageCapacity;
		public virtual unsafe int CurrentPageCapacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiResult']/method[@name='getCurrentPageCapacity' and count(parameter)=0]"
			[Register ("getCurrentPageCapacity", "()I", "GetGetCurrentPageCapacityHandler")]
			get {
				if (id_getCurrentPageCapacity == IntPtr.Zero)
					id_getCurrentPageCapacity = JNIEnv.GetMethodID (class_ref, "getCurrentPageCapacity", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCurrentPageCapacity);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPageCapacity", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentPageNum;
#pragma warning disable 0169
		static Delegate GetGetCurrentPageNumHandler ()
		{
			if (cb_getCurrentPageNum == null)
				cb_getCurrentPageNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentPageNum);
			return cb_getCurrentPageNum;
		}

		static int n_GetCurrentPageNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPageNum;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPageNum;
		public virtual unsafe int CurrentPageNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiResult']/method[@name='getCurrentPageNum' and count(parameter)=0]"
			[Register ("getCurrentPageNum", "()I", "GetGetCurrentPageNumHandler")]
			get {
				if (id_getCurrentPageNum == IntPtr.Zero)
					id_getCurrentPageNum = JNIEnv.GetMethodID (class_ref, "getCurrentPageNum", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCurrentPageNum);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPageNum", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSuggestCityList;
#pragma warning disable 0169
		static Delegate GetGetSuggestCityListHandler ()
		{
			if (cb_getSuggestCityList == null)
				cb_getSuggestCityList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuggestCityList);
			return cb_getSuggestCityList;
		}

		static IntPtr n_GetSuggestCityList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.CityInfo>.ToLocalJniHandle (__this.SuggestCityList);
		}
#pragma warning restore 0169

		static IntPtr id_getSuggestCityList;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.CityInfo> SuggestCityList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiResult']/method[@name='getSuggestCityList' and count(parameter)=0]"
			[Register ("getSuggestCityList", "()Ljava/util/List;", "GetGetSuggestCityListHandler")]
			get {
				if (id_getSuggestCityList == IntPtr.Zero)
					id_getSuggestCityList = JNIEnv.GetMethodID (class_ref, "getSuggestCityList", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.CityInfo>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSuggestCityList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.CityInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuggestCityList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTotalPageNum;
#pragma warning disable 0169
		static Delegate GetGetTotalPageNumHandler ()
		{
			if (cb_getTotalPageNum == null)
				cb_getTotalPageNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalPageNum);
			return cb_getTotalPageNum;
		}

		static int n_GetTotalPageNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalPageNum;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalPageNum;
		public virtual unsafe int TotalPageNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiResult']/method[@name='getTotalPageNum' and count(parameter)=0]"
			[Register ("getTotalPageNum", "()I", "GetGetTotalPageNumHandler")]
			get {
				if (id_getTotalPageNum == IntPtr.Zero)
					id_getTotalPageNum = JNIEnv.GetMethodID (class_ref, "getTotalPageNum", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTotalPageNum);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalPageNum", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTotalPoiNum;
#pragma warning disable 0169
		static Delegate GetGetTotalPoiNumHandler ()
		{
			if (cb_getTotalPoiNum == null)
				cb_getTotalPoiNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalPoiNum);
			return cb_getTotalPoiNum;
		}

		static int n_GetTotalPoiNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalPoiNum;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalPoiNum;
		public virtual unsafe int TotalPoiNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiResult']/method[@name='getTotalPoiNum' and count(parameter)=0]"
			[Register ("getTotalPoiNum", "()I", "GetGetTotalPoiNumHandler")]
			get {
				if (id_getTotalPoiNum == IntPtr.Zero)
					id_getTotalPoiNum = JNIEnv.GetMethodID (class_ref, "getTotalPoiNum", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTotalPoiNum);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalPoiNum", "()I"));
				} finally {
				}
			}
		}

	}
}
