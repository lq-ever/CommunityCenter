using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Radar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/radar/RadarNearbyInfo", DoNotGenerateAcw=true)]
	public partial class RadarNearbyInfo : global::Java.Lang.Object {


		static IntPtr comments_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyInfo']/field[@name='comments']"
		[Register ("comments")]
		public string Comments {
			get {
				if (comments_jfieldId == IntPtr.Zero)
					comments_jfieldId = JNIEnv.GetFieldID (class_ref, "comments", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, comments_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (comments_jfieldId == IntPtr.Zero)
					comments_jfieldId = JNIEnv.GetFieldID (class_ref, "comments", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, comments_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr distance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyInfo']/field[@name='distance']"
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

		static IntPtr mobileName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyInfo']/field[@name='mobileName']"
		[Register ("mobileName")]
		public string MobileName {
			get {
				if (mobileName_jfieldId == IntPtr.Zero)
					mobileName_jfieldId = JNIEnv.GetFieldID (class_ref, "mobileName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mobileName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mobileName_jfieldId == IntPtr.Zero)
					mobileName_jfieldId = JNIEnv.GetFieldID (class_ref, "mobileName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mobileName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mobileOS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyInfo']/field[@name='mobileOS']"
		[Register ("mobileOS")]
		public string MobileOS {
			get {
				if (mobileOS_jfieldId == IntPtr.Zero)
					mobileOS_jfieldId = JNIEnv.GetFieldID (class_ref, "mobileOS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mobileOS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mobileOS_jfieldId == IntPtr.Zero)
					mobileOS_jfieldId = JNIEnv.GetFieldID (class_ref, "mobileOS", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mobileOS_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr pt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyInfo']/field[@name='pt']"
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

		static IntPtr timeStamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyInfo']/field[@name='timeStamp']"
		[Register ("timeStamp")]
		public global::Java.Util.Date TimeStamp {
			get {
				if (timeStamp_jfieldId == IntPtr.Zero)
					timeStamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timeStamp", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, timeStamp_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (timeStamp_jfieldId == IntPtr.Zero)
					timeStamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timeStamp", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, timeStamp_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr userID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyInfo']/field[@name='userID']"
		[Register ("userID")]
		public string UserID {
			get {
				if (userID_jfieldId == IntPtr.Zero)
					userID_jfieldId = JNIEnv.GetFieldID (class_ref, "userID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, userID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (userID_jfieldId == IntPtr.Zero)
					userID_jfieldId = JNIEnv.GetFieldID (class_ref, "userID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, userID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/radar/RadarNearbyInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RadarNearbyInfo); }
		}

		protected RadarNearbyInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.radar']/class[@name='RadarNearbyInfo']/constructor[@name='RadarNearbyInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RadarNearbyInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RadarNearbyInfo)) {
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
