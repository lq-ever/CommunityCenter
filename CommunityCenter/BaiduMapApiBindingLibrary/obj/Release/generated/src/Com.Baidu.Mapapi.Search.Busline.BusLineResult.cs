using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Busline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineResult']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/busline/BusLineResult", DoNotGenerateAcw=true)]
	public partial class BusLineResult : global::Com.Baidu.Mapapi.Search.Core.SearchResult {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineResult.BusStation']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/search/busline/BusLineResult$BusStation", DoNotGenerateAcw=true)]
		public partial class BusStation : global::Com.Baidu.Mapapi.Search.Core.RouteNode {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/search/busline/BusLineResult$BusStation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BusStation); }
			}

			protected BusStation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineResult.BusStation']/constructor[@name='BusLineResult.BusStation' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe BusStation ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (BusStation)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineResult.BusStep']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/search/busline/BusLineResult$BusStep", DoNotGenerateAcw=true)]
		public partial class BusStep : global::Com.Baidu.Mapapi.Search.Core.RouteStep {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/search/busline/BusLineResult$BusStep", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BusStep); }
			}

			protected BusStep (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineResult.BusStep']/constructor[@name='BusLineResult.BusStep' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe BusStep ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (BusStep)) {
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
				return JNIEnv.FindClass ("com/baidu/mapapi/search/busline/BusLineResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BusLineResult); }
		}

		protected BusLineResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBusCompany;
#pragma warning disable 0169
		static Delegate GetGetBusCompanyHandler ()
		{
			if (cb_getBusCompany == null)
				cb_getBusCompany = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBusCompany);
			return cb_getBusCompany;
		}

		static IntPtr n_GetBusCompany (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Busline.BusLineResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BusCompany);
		}
#pragma warning restore 0169

		static IntPtr id_getBusCompany;
		public virtual unsafe string BusCompany {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineResult']/method[@name='getBusCompany' and count(parameter)=0]"
			[Register ("getBusCompany", "()Ljava/lang/String;", "GetGetBusCompanyHandler")]
			get {
				if (id_getBusCompany == IntPtr.Zero)
					id_getBusCompany = JNIEnv.GetMethodID (class_ref, "getBusCompany", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBusCompany), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBusCompany", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBusLineName;
#pragma warning disable 0169
		static Delegate GetGetBusLineNameHandler ()
		{
			if (cb_getBusLineName == null)
				cb_getBusLineName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBusLineName);
			return cb_getBusLineName;
		}

		static IntPtr n_GetBusLineName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Busline.BusLineResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BusLineName);
		}
#pragma warning restore 0169

		static IntPtr id_getBusLineName;
		public virtual unsafe string BusLineName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineResult']/method[@name='getBusLineName' and count(parameter)=0]"
			[Register ("getBusLineName", "()Ljava/lang/String;", "GetGetBusLineNameHandler")]
			get {
				if (id_getBusLineName == IntPtr.Zero)
					id_getBusLineName = JNIEnv.GetMethodID (class_ref, "getBusLineName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBusLineName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBusLineName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEndTime;
#pragma warning disable 0169
		static Delegate GetGetEndTimeHandler ()
		{
			if (cb_getEndTime == null)
				cb_getEndTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndTime);
			return cb_getEndTime;
		}

		static IntPtr n_GetEndTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Busline.BusLineResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndTime);
		}
#pragma warning restore 0169

		static IntPtr id_getEndTime;
		public virtual unsafe global::Java.Util.Date EndTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineResult']/method[@name='getEndTime' and count(parameter)=0]"
			[Register ("getEndTime", "()Ljava/util/Date;", "GetGetEndTimeHandler")]
			get {
				if (id_getEndTime == IntPtr.Zero)
					id_getEndTime = JNIEnv.GetMethodID (class_ref, "getEndTime", "()Ljava/util/Date;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getEndTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndTime", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isMonthTicket;
#pragma warning disable 0169
		static Delegate GetIsMonthTicketHandler ()
		{
			if (cb_isMonthTicket == null)
				cb_isMonthTicket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMonthTicket);
			return cb_isMonthTicket;
		}

		static bool n_IsMonthTicket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Busline.BusLineResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMonthTicket;
		}
#pragma warning restore 0169

		static IntPtr id_isMonthTicket;
		public virtual unsafe bool IsMonthTicket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineResult']/method[@name='isMonthTicket' and count(parameter)=0]"
			[Register ("isMonthTicket", "()Z", "GetIsMonthTicketHandler")]
			get {
				if (id_isMonthTicket == IntPtr.Zero)
					id_isMonthTicket = JNIEnv.GetMethodID (class_ref, "isMonthTicket", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isMonthTicket);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMonthTicket", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getStartTime;
#pragma warning disable 0169
		static Delegate GetGetStartTimeHandler ()
		{
			if (cb_getStartTime == null)
				cb_getStartTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartTime);
			return cb_getStartTime;
		}

		static IntPtr n_GetStartTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Busline.BusLineResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartTime);
		}
#pragma warning restore 0169

		static IntPtr id_getStartTime;
		public virtual unsafe global::Java.Util.Date StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineResult']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()Ljava/util/Date;", "GetGetStartTimeHandler")]
			get {
				if (id_getStartTime == IntPtr.Zero)
					id_getStartTime = JNIEnv.GetMethodID (class_ref, "getStartTime", "()Ljava/util/Date;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getStartTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartTime", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStations;
#pragma warning disable 0169
		static Delegate GetGetStationsHandler ()
		{
			if (cb_getStations == null)
				cb_getStations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStations);
			return cb_getStations;
		}

		static IntPtr n_GetStations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Busline.BusLineResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult.BusStation>.ToLocalJniHandle (__this.Stations);
		}
#pragma warning restore 0169

		static IntPtr id_getStations;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult.BusStation> Stations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineResult']/method[@name='getStations' and count(parameter)=0]"
			[Register ("getStations", "()Ljava/util/List;", "GetGetStationsHandler")]
			get {
				if (id_getStations == IntPtr.Zero)
					id_getStations = JNIEnv.GetMethodID (class_ref, "getStations", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult.BusStation>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getStations), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult.BusStation>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStations", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSteps;
#pragma warning disable 0169
		static Delegate GetGetStepsHandler ()
		{
			if (cb_getSteps == null)
				cb_getSteps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSteps);
			return cb_getSteps;
		}

		static IntPtr n_GetSteps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Busline.BusLineResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult.BusStep>.ToLocalJniHandle (__this.Steps);
		}
#pragma warning restore 0169

		static IntPtr id_getSteps;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult.BusStep> Steps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineResult']/method[@name='getSteps' and count(parameter)=0]"
			[Register ("getSteps", "()Ljava/util/List;", "GetGetStepsHandler")]
			get {
				if (id_getSteps == IntPtr.Zero)
					id_getSteps = JNIEnv.GetMethodID (class_ref, "getSteps", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult.BusStep>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSteps), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult.BusStep>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSteps", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Baidu.Mapapi.Search.Busline.BusLineResult __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Busline.BusLineResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uid);
		}
#pragma warning restore 0169

		static IntPtr id_getUid;
		public virtual unsafe string Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.busline']/class[@name='BusLineResult']/method[@name='getUid' and count(parameter)=0]"
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
