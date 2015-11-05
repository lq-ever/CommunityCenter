using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Cloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/cloud/CloudPoiInfo", DoNotGenerateAcw=true)]
	public partial class CloudPoiInfo : global::Java.Lang.Object {


		static IntPtr address_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/field[@name='address']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/field[@name='city']"
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

		static IntPtr distance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/field[@name='distance']"
		[Register ("distance")]
		public int Distance {
			get {
				if (distance_jfieldId == IntPtr.Zero)
					distance_jfieldId = JNIEnv.GetFieldID (class_ref, "distance", "I");
				return JNIEnv.GetIntField (Handle, distance_jfieldId);
			}
			set {
				if (distance_jfieldId == IntPtr.Zero)
					distance_jfieldId = JNIEnv.GetFieldID (class_ref, "distance", "I");
				try {
					JNIEnv.SetField (Handle, distance_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr district_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/field[@name='district']"
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

		static IntPtr extras_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/field[@name='extras']"
		[Register ("extras")]
		public global::System.Collections.IDictionary Extras {
			get {
				if (extras_jfieldId == IntPtr.Zero)
					extras_jfieldId = JNIEnv.GetFieldID (class_ref, "extras", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, extras_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (extras_jfieldId == IntPtr.Zero)
					extras_jfieldId = JNIEnv.GetFieldID (class_ref, "extras", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, extras_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr geotableId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/field[@name='geotableId']"
		[Register ("geotableId")]
		public int GeotableId {
			get {
				if (geotableId_jfieldId == IntPtr.Zero)
					geotableId_jfieldId = JNIEnv.GetFieldID (class_ref, "geotableId", "I");
				return JNIEnv.GetIntField (Handle, geotableId_jfieldId);
			}
			set {
				if (geotableId_jfieldId == IntPtr.Zero)
					geotableId_jfieldId = JNIEnv.GetFieldID (class_ref, "geotableId", "I");
				try {
					JNIEnv.SetField (Handle, geotableId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr latitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/field[@name='latitude']"
		[Register ("latitude")]
		public double Latitude {
			get {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				return JNIEnv.GetDoubleField (Handle, latitude_jfieldId);
			}
			set {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				try {
					JNIEnv.SetField (Handle, latitude_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr longitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/field[@name='longitude']"
		[Register ("longitude")]
		public double Longitude {
			get {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				return JNIEnv.GetDoubleField (Handle, longitude_jfieldId);
			}
			set {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				try {
					JNIEnv.SetField (Handle, longitude_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr province_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/field[@name='province']"
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

		static IntPtr tags_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/field[@name='tags']"
		[Register ("tags")]
		public string Tags {
			get {
				if (tags_jfieldId == IntPtr.Zero)
					tags_jfieldId = JNIEnv.GetFieldID (class_ref, "tags", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, tags_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tags_jfieldId == IntPtr.Zero)
					tags_jfieldId = JNIEnv.GetFieldID (class_ref, "tags", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, tags_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr title_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/field[@name='title']"
		[Register ("title")]
		public string Title {
			get {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, title_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, title_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr uid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/field[@name='uid']"
		[Register ("uid")]
		public int Uid {
			get {
				if (uid_jfieldId == IntPtr.Zero)
					uid_jfieldId = JNIEnv.GetFieldID (class_ref, "uid", "I");
				return JNIEnv.GetIntField (Handle, uid_jfieldId);
			}
			set {
				if (uid_jfieldId == IntPtr.Zero)
					uid_jfieldId = JNIEnv.GetFieldID (class_ref, "uid", "I");
				try {
					JNIEnv.SetField (Handle, uid_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr weight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/field[@name='weight']"
		[Register ("weight")]
		public int Weight {
			get {
				if (weight_jfieldId == IntPtr.Zero)
					weight_jfieldId = JNIEnv.GetFieldID (class_ref, "weight", "I");
				return JNIEnv.GetIntField (Handle, weight_jfieldId);
			}
			set {
				if (weight_jfieldId == IntPtr.Zero)
					weight_jfieldId = JNIEnv.GetFieldID (class_ref, "weight", "I");
				try {
					JNIEnv.SetField (Handle, weight_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/cloud/CloudPoiInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CloudPoiInfo); }
		}

		protected CloudPoiInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.cloud']/class[@name='CloudPoiInfo']/constructor[@name='CloudPoiInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CloudPoiInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CloudPoiInfo)) {
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
