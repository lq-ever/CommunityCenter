using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/core/PoiInfo", DoNotGenerateAcw=true)]
	public partial class PoiInfo : global::Java.Lang.Object {


		static IntPtr address_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo']/field[@name='address']"
		[Register ("address")]
		public string Address {
			get {
				if (address_jfieldId == IntPtr.Zero)
					address_jfieldId = JNIEnv.GetFieldID (class_ref, "address", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, address_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (address_jfieldId == IntPtr.Zero)
					address_jfieldId = JNIEnv.GetFieldID (class_ref, "address", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, address_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr city_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo']/field[@name='city']"
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

		static IntPtr hasCaterDetails_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo']/field[@name='hasCaterDetails']"
		[Register ("hasCaterDetails")]
		public bool HasCaterDetails {
			get {
				if (hasCaterDetails_jfieldId == IntPtr.Zero)
					hasCaterDetails_jfieldId = JNIEnv.GetFieldID (class_ref, "hasCaterDetails", "Z");
				return JNIEnv.GetBooleanField (Handle, hasCaterDetails_jfieldId);
			}
			set {
				if (hasCaterDetails_jfieldId == IntPtr.Zero)
					hasCaterDetails_jfieldId = JNIEnv.GetFieldID (class_ref, "hasCaterDetails", "Z");
				try {
					JNIEnv.SetField (Handle, hasCaterDetails_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isPano_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo']/field[@name='isPano']"
		[Register ("isPano")]
		public bool IsPano {
			get {
				if (isPano_jfieldId == IntPtr.Zero)
					isPano_jfieldId = JNIEnv.GetFieldID (class_ref, "isPano", "Z");
				return JNIEnv.GetBooleanField (Handle, isPano_jfieldId);
			}
			set {
				if (isPano_jfieldId == IntPtr.Zero)
					isPano_jfieldId = JNIEnv.GetFieldID (class_ref, "isPano", "Z");
				try {
					JNIEnv.SetField (Handle, isPano_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr location_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo']/field[@name='location']"
		[Register ("location")]
		public global::Com.Baidu.Mapapi.Model.LatLng Location {
			get {
				if (location_jfieldId == IntPtr.Zero)
					location_jfieldId = JNIEnv.GetFieldID (class_ref, "location", "Lcom/baidu/mapapi/model/LatLng;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, location_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (location_jfieldId == IntPtr.Zero)
					location_jfieldId = JNIEnv.GetFieldID (class_ref, "location", "Lcom/baidu/mapapi/model/LatLng;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, location_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr phoneNum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo']/field[@name='phoneNum']"
		[Register ("phoneNum")]
		public string PhoneNum {
			get {
				if (phoneNum_jfieldId == IntPtr.Zero)
					phoneNum_jfieldId = JNIEnv.GetFieldID (class_ref, "phoneNum", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, phoneNum_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (phoneNum_jfieldId == IntPtr.Zero)
					phoneNum_jfieldId = JNIEnv.GetFieldID (class_ref, "phoneNum", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, phoneNum_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr postCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo']/field[@name='postCode']"
		[Register ("postCode")]
		public string PostCode {
			get {
				if (postCode_jfieldId == IntPtr.Zero)
					postCode_jfieldId = JNIEnv.GetFieldID (class_ref, "postCode", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, postCode_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (postCode_jfieldId == IntPtr.Zero)
					postCode_jfieldId = JNIEnv.GetFieldID (class_ref, "postCode", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, postCode_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo']/field[@name='type']"
		[Register ("type")]
		public global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/baidu/mapapi/search/core/PoiInfo$POITYPE;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, type_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/baidu/mapapi/search/core/PoiInfo$POITYPE;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr uid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo']/field[@name='uid']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo.POITYPE']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/search/core/PoiInfo$POITYPE", DoNotGenerateAcw=true)]
		public sealed partial class POITYPE : global::Java.Lang.Enum {


			static IntPtr BUS_LINE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo.POITYPE']/field[@name='BUS_LINE']"
			[Register ("BUS_LINE")]
			public static global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE BusLine {
				get {
					if (BUS_LINE_jfieldId == IntPtr.Zero)
						BUS_LINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUS_LINE", "Lcom/baidu/mapapi/search/core/PoiInfo$POITYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUS_LINE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BUS_STATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo.POITYPE']/field[@name='BUS_STATION']"
			[Register ("BUS_STATION")]
			public static global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE BusStation {
				get {
					if (BUS_STATION_jfieldId == IntPtr.Zero)
						BUS_STATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUS_STATION", "Lcom/baidu/mapapi/search/core/PoiInfo$POITYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUS_STATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr POINT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo.POITYPE']/field[@name='POINT']"
			[Register ("POINT")]
			public static global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE Point {
				get {
					if (POINT_jfieldId == IntPtr.Zero)
						POINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POINT", "Lcom/baidu/mapapi/search/core/PoiInfo$POITYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POINT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUBWAY_LINE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo.POITYPE']/field[@name='SUBWAY_LINE']"
			[Register ("SUBWAY_LINE")]
			public static global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE SubwayLine {
				get {
					if (SUBWAY_LINE_jfieldId == IntPtr.Zero)
						SUBWAY_LINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUBWAY_LINE", "Lcom/baidu/mapapi/search/core/PoiInfo$POITYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUBWAY_LINE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUBWAY_STATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo.POITYPE']/field[@name='SUBWAY_STATION']"
			[Register ("SUBWAY_STATION")]
			public static global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE SubwayStation {
				get {
					if (SUBWAY_STATION_jfieldId == IntPtr.Zero)
						SUBWAY_STATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUBWAY_STATION", "Lcom/baidu/mapapi/search/core/PoiInfo$POITYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUBWAY_STATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/search/core/PoiInfo$POITYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (POITYPE); }
			}

			internal POITYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getInt;
			public unsafe int Int {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo.POITYPE']/method[@name='getInt' and count(parameter)=0]"
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

			static IntPtr id_fromInt_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo.POITYPE']/method[@name='fromInt' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromInt", "(I)Lcom/baidu/mapapi/search/core/PoiInfo$POITYPE;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE FromInt (int p0)
			{
				if (id_fromInt_I == IntPtr.Zero)
					id_fromInt_I = JNIEnv.GetStaticMethodID (class_ref, "fromInt", "(I)Lcom/baidu/mapapi/search/core/PoiInfo$POITYPE;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromInt_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo.POITYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/core/PoiInfo$POITYPE;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/search/core/PoiInfo$POITYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo.POITYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/search/core/PoiInfo$POITYPE;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/baidu/mapapi/search/core/PoiInfo$POITYPE;");
				try {
					return (global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Search.Core.PoiInfo.POITYPE));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/core/PoiInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PoiInfo); }
		}

		protected PoiInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.core']/class[@name='PoiInfo']/constructor[@name='PoiInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PoiInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PoiInfo)) {
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
}
