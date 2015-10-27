using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Poi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/poi/PoiDetailResult", DoNotGenerateAcw=true)]
	public partial class PoiDetailResult : global::Com.Baidu.Mapapi.Search.Core.SearchResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/poi/PoiDetailResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PoiDetailResult); }
		}

		protected PoiDetailResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_baidu_mapapi_search_core_SearchResult_ERRORNO_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/constructor[@name='PoiDetailResult' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.search.core.SearchResult.ERRORNO']]"
		[Register (".ctor", "(Lcom/baidu/mapapi/search/core/SearchResult$ERRORNO;)V", "")]
		public unsafe PoiDetailResult (global::Com.Baidu.Mapapi.Search.Core.SearchResult.ERRORNO p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (PoiDetailResult)) {
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

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		static IntPtr id_getAddress;
		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler")]
			get {
				if (id_getAddress == IntPtr.Zero)
					id_getAddress = JNIEnv.GetMethodID (class_ref, "getAddress", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCheckinNum;
#pragma warning disable 0169
		static Delegate GetGetCheckinNumHandler ()
		{
			if (cb_getCheckinNum == null)
				cb_getCheckinNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCheckinNum);
			return cb_getCheckinNum;
		}

		static int n_GetCheckinNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckinNum;
		}
#pragma warning restore 0169

		static IntPtr id_getCheckinNum;
		public virtual unsafe int CheckinNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getCheckinNum' and count(parameter)=0]"
			[Register ("getCheckinNum", "()I", "GetGetCheckinNumHandler")]
			get {
				if (id_getCheckinNum == IntPtr.Zero)
					id_getCheckinNum = JNIEnv.GetMethodID (class_ref, "getCheckinNum", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCheckinNum);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCheckinNum", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCommentNum;
#pragma warning disable 0169
		static Delegate GetGetCommentNumHandler ()
		{
			if (cb_getCommentNum == null)
				cb_getCommentNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCommentNum);
			return cb_getCommentNum;
		}

		static int n_GetCommentNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CommentNum;
		}
#pragma warning restore 0169

		static IntPtr id_getCommentNum;
		public virtual unsafe int CommentNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getCommentNum' and count(parameter)=0]"
			[Register ("getCommentNum", "()I", "GetGetCommentNumHandler")]
			get {
				if (id_getCommentNum == IntPtr.Zero)
					id_getCommentNum = JNIEnv.GetMethodID (class_ref, "getCommentNum", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCommentNum);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommentNum", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDetailUrl;
#pragma warning disable 0169
		static Delegate GetGetDetailUrlHandler ()
		{
			if (cb_getDetailUrl == null)
				cb_getDetailUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDetailUrl);
			return cb_getDetailUrl;
		}

		static IntPtr n_GetDetailUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DetailUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getDetailUrl;
		public virtual unsafe string DetailUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getDetailUrl' and count(parameter)=0]"
			[Register ("getDetailUrl", "()Ljava/lang/String;", "GetGetDetailUrlHandler")]
			get {
				if (id_getDetailUrl == IntPtr.Zero)
					id_getDetailUrl = JNIEnv.GetMethodID (class_ref, "getDetailUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDetailUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDetailUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEnvironmentRating;
#pragma warning disable 0169
		static Delegate GetGetEnvironmentRatingHandler ()
		{
			if (cb_getEnvironmentRating == null)
				cb_getEnvironmentRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetEnvironmentRating);
			return cb_getEnvironmentRating;
		}

		static double n_GetEnvironmentRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnvironmentRating;
		}
#pragma warning restore 0169

		static IntPtr id_getEnvironmentRating;
		public virtual unsafe double EnvironmentRating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getEnvironmentRating' and count(parameter)=0]"
			[Register ("getEnvironmentRating", "()D", "GetGetEnvironmentRatingHandler")]
			get {
				if (id_getEnvironmentRating == IntPtr.Zero)
					id_getEnvironmentRating = JNIEnv.GetMethodID (class_ref, "getEnvironmentRating", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getEnvironmentRating);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEnvironmentRating", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getFacilityRating;
#pragma warning disable 0169
		static Delegate GetGetFacilityRatingHandler ()
		{
			if (cb_getFacilityRating == null)
				cb_getFacilityRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetFacilityRating);
			return cb_getFacilityRating;
		}

		static double n_GetFacilityRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FacilityRating;
		}
#pragma warning restore 0169

		static IntPtr id_getFacilityRating;
		public virtual unsafe double FacilityRating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getFacilityRating' and count(parameter)=0]"
			[Register ("getFacilityRating", "()D", "GetGetFacilityRatingHandler")]
			get {
				if (id_getFacilityRating == IntPtr.Zero)
					id_getFacilityRating = JNIEnv.GetMethodID (class_ref, "getFacilityRating", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getFacilityRating);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFacilityRating", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getFavoriteNum;
#pragma warning disable 0169
		static Delegate GetGetFavoriteNumHandler ()
		{
			if (cb_getFavoriteNum == null)
				cb_getFavoriteNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFavoriteNum);
			return cb_getFavoriteNum;
		}

		static int n_GetFavoriteNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FavoriteNum;
		}
#pragma warning restore 0169

		static IntPtr id_getFavoriteNum;
		public virtual unsafe int FavoriteNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getFavoriteNum' and count(parameter)=0]"
			[Register ("getFavoriteNum", "()I", "GetGetFavoriteNumHandler")]
			get {
				if (id_getFavoriteNum == IntPtr.Zero)
					id_getFavoriteNum = JNIEnv.GetMethodID (class_ref, "getFavoriteNum", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getFavoriteNum);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFavoriteNum", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getGrouponNum;
#pragma warning disable 0169
		static Delegate GetGetGrouponNumHandler ()
		{
			if (cb_getGrouponNum == null)
				cb_getGrouponNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGrouponNum);
			return cb_getGrouponNum;
		}

		static int n_GetGrouponNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GrouponNum;
		}
#pragma warning restore 0169

		static IntPtr id_getGrouponNum;
		public virtual unsafe int GrouponNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getGrouponNum' and count(parameter)=0]"
			[Register ("getGrouponNum", "()I", "GetGetGrouponNumHandler")]
			get {
				if (id_getGrouponNum == IntPtr.Zero)
					id_getGrouponNum = JNIEnv.GetMethodID (class_ref, "getGrouponNum", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getGrouponNum);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGrouponNum", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getHygieneRating;
#pragma warning disable 0169
		static Delegate GetGetHygieneRatingHandler ()
		{
			if (cb_getHygieneRating == null)
				cb_getHygieneRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetHygieneRating);
			return cb_getHygieneRating;
		}

		static double n_GetHygieneRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HygieneRating;
		}
#pragma warning restore 0169

		static IntPtr id_getHygieneRating;
		public virtual unsafe double HygieneRating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getHygieneRating' and count(parameter)=0]"
			[Register ("getHygieneRating", "()D", "GetGetHygieneRatingHandler")]
			get {
				if (id_getHygieneRating == IntPtr.Zero)
					id_getHygieneRating = JNIEnv.GetMethodID (class_ref, "getHygieneRating", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getHygieneRating);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHygieneRating", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getImageNum;
#pragma warning disable 0169
		static Delegate GetGetImageNumHandler ()
		{
			if (cb_getImageNum == null)
				cb_getImageNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImageNum);
			return cb_getImageNum;
		}

		static int n_GetImageNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageNum;
		}
#pragma warning restore 0169

		static IntPtr id_getImageNum;
		public virtual unsafe int ImageNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getImageNum' and count(parameter)=0]"
			[Register ("getImageNum", "()I", "GetGetImageNumHandler")]
			get {
				if (id_getImageNum == IntPtr.Zero)
					id_getImageNum = JNIEnv.GetMethodID (class_ref, "getImageNum", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getImageNum);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageNum", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Lcom/baidu/mapapi/model/LatLng;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()Lcom/baidu/mapapi/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOverallRating;
#pragma warning disable 0169
		static Delegate GetGetOverallRatingHandler ()
		{
			if (cb_getOverallRating == null)
				cb_getOverallRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetOverallRating);
			return cb_getOverallRating;
		}

		static double n_GetOverallRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OverallRating;
		}
#pragma warning restore 0169

		static IntPtr id_getOverallRating;
		public virtual unsafe double OverallRating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getOverallRating' and count(parameter)=0]"
			[Register ("getOverallRating", "()D", "GetGetOverallRatingHandler")]
			get {
				if (id_getOverallRating == IntPtr.Zero)
					id_getOverallRating = JNIEnv.GetMethodID (class_ref, "getOverallRating", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getOverallRating);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOverallRating", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getPrice;
#pragma warning disable 0169
		static Delegate GetGetPriceHandler ()
		{
			if (cb_getPrice == null)
				cb_getPrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetPrice);
			return cb_getPrice;
		}

		static double n_GetPrice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Price;
		}
#pragma warning restore 0169

		static IntPtr id_getPrice;
		public virtual unsafe double Price {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getPrice' and count(parameter)=0]"
			[Register ("getPrice", "()D", "GetGetPriceHandler")]
			get {
				if (id_getPrice == IntPtr.Zero)
					id_getPrice = JNIEnv.GetMethodID (class_ref, "getPrice", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getPrice);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrice", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getServiceRating;
#pragma warning disable 0169
		static Delegate GetGetServiceRatingHandler ()
		{
			if (cb_getServiceRating == null)
				cb_getServiceRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetServiceRating);
			return cb_getServiceRating;
		}

		static double n_GetServiceRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ServiceRating;
		}
#pragma warning restore 0169

		static IntPtr id_getServiceRating;
		public virtual unsafe double ServiceRating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getServiceRating' and count(parameter)=0]"
			[Register ("getServiceRating", "()D", "GetGetServiceRatingHandler")]
			get {
				if (id_getServiceRating == IntPtr.Zero)
					id_getServiceRating = JNIEnv.GetMethodID (class_ref, "getServiceRating", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getServiceRating);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServiceRating", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getShopHours;
#pragma warning disable 0169
		static Delegate GetGetShopHoursHandler ()
		{
			if (cb_getShopHours == null)
				cb_getShopHours = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShopHours);
			return cb_getShopHours;
		}

		static IntPtr n_GetShopHours (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ShopHours);
		}
#pragma warning restore 0169

		static IntPtr id_getShopHours;
		public virtual unsafe string ShopHours {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getShopHours' and count(parameter)=0]"
			[Register ("getShopHours", "()Ljava/lang/String;", "GetGetShopHoursHandler")]
			get {
				if (id_getShopHours == IntPtr.Zero)
					id_getShopHours = JNIEnv.GetMethodID (class_ref, "getShopHours", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getShopHours), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShopHours", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tag);
		}
#pragma warning restore 0169

		static IntPtr id_getTag;
		public virtual unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "GetGetTagHandler")]
			get {
				if (id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTag", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTasteRating;
#pragma warning disable 0169
		static Delegate GetGetTasteRatingHandler ()
		{
			if (cb_getTasteRating == null)
				cb_getTasteRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetTasteRating);
			return cb_getTasteRating;
		}

		static double n_GetTasteRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TasteRating;
		}
#pragma warning restore 0169

		static IntPtr id_getTasteRating;
		public virtual unsafe double TasteRating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getTasteRating' and count(parameter)=0]"
			[Register ("getTasteRating", "()D", "GetGetTasteRatingHandler")]
			get {
				if (id_getTasteRating == IntPtr.Zero)
					id_getTasteRating = JNIEnv.GetMethodID (class_ref, "getTasteRating", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getTasteRating);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTasteRating", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getTechnologyRating;
#pragma warning disable 0169
		static Delegate GetGetTechnologyRatingHandler ()
		{
			if (cb_getTechnologyRating == null)
				cb_getTechnologyRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetTechnologyRating);
			return cb_getTechnologyRating;
		}

		static double n_GetTechnologyRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TechnologyRating;
		}
#pragma warning restore 0169

		static IntPtr id_getTechnologyRating;
		public virtual unsafe double TechnologyRating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getTechnologyRating' and count(parameter)=0]"
			[Register ("getTechnologyRating", "()D", "GetGetTechnologyRatingHandler")]
			get {
				if (id_getTechnologyRating == IntPtr.Zero)
					id_getTechnologyRating = JNIEnv.GetMethodID (class_ref, "getTechnologyRating", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getTechnologyRating);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTechnologyRating", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getTelephone;
#pragma warning disable 0169
		static Delegate GetGetTelephoneHandler ()
		{
			if (cb_getTelephone == null)
				cb_getTelephone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTelephone);
			return cb_getTelephone;
		}

		static IntPtr n_GetTelephone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Telephone);
		}
#pragma warning restore 0169

		static IntPtr id_getTelephone;
		public virtual unsafe string Telephone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getTelephone' and count(parameter)=0]"
			[Register ("getTelephone", "()Ljava/lang/String;", "GetGetTelephoneHandler")]
			get {
				if (id_getTelephone == IntPtr.Zero)
					id_getTelephone = JNIEnv.GetMethodID (class_ref, "getTelephone", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTelephone), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTelephone", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUid;
#pragma warning disable 0169
		static Delegate GetGetUidHandler ()
		{
			if (cb_getUid == null)
				cb_getUid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUid);
			return cb_getUid;
		}

		static IntPtr n_GetUid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Poi.PoiDetailResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uid);
		}
#pragma warning restore 0169

		static IntPtr id_getUid;
		public virtual unsafe string Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.poi']/class[@name='PoiDetailResult']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()Ljava/lang/String;", "GetGetUidHandler")]
			get {
				if (id_getUid == IntPtr.Zero)
					id_getUid = JNIEnv.GetMethodID (class_ref, "getUid", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUid), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUid", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
