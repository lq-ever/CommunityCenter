using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Geocode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeResult']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/geocode/ReverseGeoCodeResult", DoNotGenerateAcw=true)]
	public partial class ReverseGeoCodeResult : global::Com.Baidu.Mapapi.Search.Core.SearchResult {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeResult.AddressComponent']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/search/geocode/ReverseGeoCodeResult$AddressComponent", DoNotGenerateAcw=true)]
		public partial class AddressComponent : global::Java.Lang.Object {


			static IntPtr city_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeResult.AddressComponent']/field[@name='city']"
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

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeResult.AddressComponent']/field[@name='district']"
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

			static IntPtr province_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeResult.AddressComponent']/field[@name='province']"
			[Register ("province")]
			public string Province {
				get {
					if (province_jfieldId == IntPtr.Zero)
						province_jfieldId = JNIEnv.GetFieldID (class_ref, "province", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, province_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (province_jfieldId == IntPtr.Zero)
						province_jfieldId = JNIEnv.GetFieldID (class_ref, "province", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, province_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr street_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeResult.AddressComponent']/field[@name='street']"
			[Register ("street")]
			public string Street {
				get {
					if (street_jfieldId == IntPtr.Zero)
						street_jfieldId = JNIEnv.GetFieldID (class_ref, "street", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, street_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (street_jfieldId == IntPtr.Zero)
						street_jfieldId = JNIEnv.GetFieldID (class_ref, "street", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, street_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr streetNumber_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeResult.AddressComponent']/field[@name='streetNumber']"
			[Register ("streetNumber")]
			public string StreetNumber {
				get {
					if (streetNumber_jfieldId == IntPtr.Zero)
						streetNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "streetNumber", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, streetNumber_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (streetNumber_jfieldId == IntPtr.Zero)
						streetNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "streetNumber", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, streetNumber_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/search/geocode/ReverseGeoCodeResult$AddressComponent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AddressComponent); }
			}

			protected AddressComponent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeResult.AddressComponent']/constructor[@name='ReverseGeoCodeResult.AddressComponent' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AddressComponent ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (AddressComponent)) {
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
				return JNIEnv.FindClass ("com/baidu/mapapi/search/geocode/ReverseGeoCodeResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReverseGeoCodeResult); }
		}

		protected ReverseGeoCodeResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		static IntPtr id_getAddress;
		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeResult']/method[@name='getAddress' and count(parameter)=0]"
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

		static Delegate cb_getAddressDetail;
#pragma warning disable 0169
		static Delegate GetGetAddressDetailHandler ()
		{
			if (cb_getAddressDetail == null)
				cb_getAddressDetail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddressDetail);
			return cb_getAddressDetail;
		}

		static IntPtr n_GetAddressDetail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddressDetail);
		}
#pragma warning restore 0169

		static IntPtr id_getAddressDetail;
		public virtual unsafe global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult.AddressComponent AddressDetail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeResult']/method[@name='getAddressDetail' and count(parameter)=0]"
			[Register ("getAddressDetail", "()Lcom/baidu/mapapi/search/geocode/ReverseGeoCodeResult$AddressComponent;", "GetGetAddressDetailHandler")]
			get {
				if (id_getAddressDetail == IntPtr.Zero)
					id_getAddressDetail = JNIEnv.GetMethodID (class_ref, "getAddressDetail", "()Lcom/baidu/mapapi/search/geocode/ReverseGeoCodeResult$AddressComponent;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult.AddressComponent> (JNIEnv.CallObjectMethod  (Handle, id_getAddressDetail), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult.AddressComponent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddressDetail", "()Lcom/baidu/mapapi/search/geocode/ReverseGeoCodeResult$AddressComponent;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBusinessCircle;
#pragma warning disable 0169
		static Delegate GetGetBusinessCircleHandler ()
		{
			if (cb_getBusinessCircle == null)
				cb_getBusinessCircle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBusinessCircle);
			return cb_getBusinessCircle;
		}

		static IntPtr n_GetBusinessCircle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BusinessCircle);
		}
#pragma warning restore 0169

		static IntPtr id_getBusinessCircle;
		public virtual unsafe string BusinessCircle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeResult']/method[@name='getBusinessCircle' and count(parameter)=0]"
			[Register ("getBusinessCircle", "()Ljava/lang/String;", "GetGetBusinessCircleHandler")]
			get {
				if (id_getBusinessCircle == IntPtr.Zero)
					id_getBusinessCircle = JNIEnv.GetMethodID (class_ref, "getBusinessCircle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBusinessCircle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBusinessCircle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeResult']/method[@name='getLocation' and count(parameter)=0]"
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

		static Delegate cb_getPoiList;
#pragma warning disable 0169
		static Delegate GetGetPoiListHandler ()
		{
			if (cb_getPoiList == null)
				cb_getPoiList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoiList);
			return cb_getPoiList;
		}

		static IntPtr n_GetPoiList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Geocode.ReverseGeoCodeResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>.ToLocalJniHandle (__this.PoiList);
		}
#pragma warning restore 0169

		static IntPtr id_getPoiList;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo> PoiList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.geocode']/class[@name='ReverseGeoCodeResult']/method[@name='getPoiList' and count(parameter)=0]"
			[Register ("getPoiList", "()Ljava/util/List;", "GetGetPoiListHandler")]
			get {
				if (id_getPoiList == IntPtr.Zero)
					id_getPoiList = JNIEnv.GetMethodID (class_ref, "getPoiList", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoiList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoiList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
