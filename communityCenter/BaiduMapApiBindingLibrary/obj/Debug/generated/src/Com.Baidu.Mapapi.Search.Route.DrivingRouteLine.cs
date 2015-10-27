using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Route {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteLine']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/DrivingRouteLine", DoNotGenerateAcw=true)]
	public partial class DrivingRouteLine : global::Com.Baidu.Mapapi.Search.Core.RouteLine {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteLine.DrivingStep']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/DrivingRouteLine$DrivingStep", DoNotGenerateAcw=true)]
		public partial class DrivingStep : global::Com.Baidu.Mapapi.Search.Core.RouteStep {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/search/route/DrivingRouteLine$DrivingStep", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DrivingStep); }
			}

			protected DrivingStep (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteLine.DrivingStep']/constructor[@name='DrivingRouteLine.DrivingStep' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DrivingStep ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DrivingStep)) {
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

			static Delegate cb_getDirection;
#pragma warning disable 0169
			static Delegate GetGetDirectionHandler ()
			{
				if (cb_getDirection == null)
					cb_getDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDirection);
				return cb_getDirection;
			}

			static int n_GetDirection (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Direction;
			}
#pragma warning restore 0169

			static IntPtr id_getDirection;
			public virtual unsafe int Direction {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteLine.DrivingStep']/method[@name='getDirection' and count(parameter)=0]"
				[Register ("getDirection", "()I", "GetGetDirectionHandler")]
				get {
					if (id_getDirection == IntPtr.Zero)
						id_getDirection = JNIEnv.GetMethodID (class_ref, "getDirection", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getDirection);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDirection", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getEntrance;
#pragma warning disable 0169
			static Delegate GetGetEntranceHandler ()
			{
				if (cb_getEntrance == null)
					cb_getEntrance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntrance);
				return cb_getEntrance;
			}

			static IntPtr n_GetEntrance (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Entrance);
			}
#pragma warning restore 0169

			static IntPtr id_getEntrance;
			public virtual unsafe global::Com.Baidu.Mapapi.Search.Core.RouteNode Entrance {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteLine.DrivingStep']/method[@name='getEntrance' and count(parameter)=0]"
				[Register ("getEntrance", "()Lcom/baidu/mapapi/search/core/RouteNode;", "GetGetEntranceHandler")]
				get {
					if (id_getEntrance == IntPtr.Zero)
						id_getEntrance = JNIEnv.GetMethodID (class_ref, "getEntrance", "()Lcom/baidu/mapapi/search/core/RouteNode;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallObjectMethod  (Handle, id_getEntrance), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntrance", "()Lcom/baidu/mapapi/search/core/RouteNode;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getEntranceInstructions;
#pragma warning disable 0169
			static Delegate GetGetEntranceInstructionsHandler ()
			{
				if (cb_getEntranceInstructions == null)
					cb_getEntranceInstructions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntranceInstructions);
				return cb_getEntranceInstructions;
			}

			static IntPtr n_GetEntranceInstructions (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.EntranceInstructions);
			}
#pragma warning restore 0169

			static IntPtr id_getEntranceInstructions;
			public virtual unsafe string EntranceInstructions {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteLine.DrivingStep']/method[@name='getEntranceInstructions' and count(parameter)=0]"
				[Register ("getEntranceInstructions", "()Ljava/lang/String;", "GetGetEntranceInstructionsHandler")]
				get {
					if (id_getEntranceInstructions == IntPtr.Zero)
						id_getEntranceInstructions = JNIEnv.GetMethodID (class_ref, "getEntranceInstructions", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEntranceInstructions), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntranceInstructions", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getExit;
#pragma warning disable 0169
			static Delegate GetGetExitHandler ()
			{
				if (cb_getExit == null)
					cb_getExit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExit);
				return cb_getExit;
			}

			static IntPtr n_GetExit (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Exit);
			}
#pragma warning restore 0169

			static IntPtr id_getExit;
			public virtual unsafe global::Com.Baidu.Mapapi.Search.Core.RouteNode Exit {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteLine.DrivingStep']/method[@name='getExit' and count(parameter)=0]"
				[Register ("getExit", "()Lcom/baidu/mapapi/search/core/RouteNode;", "GetGetExitHandler")]
				get {
					if (id_getExit == IntPtr.Zero)
						id_getExit = JNIEnv.GetMethodID (class_ref, "getExit", "()Lcom/baidu/mapapi/search/core/RouteNode;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallObjectMethod  (Handle, id_getExit), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Core.RouteNode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExit", "()Lcom/baidu/mapapi/search/core/RouteNode;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getExitInstructions;
#pragma warning disable 0169
			static Delegate GetGetExitInstructionsHandler ()
			{
				if (cb_getExitInstructions == null)
					cb_getExitInstructions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExitInstructions);
				return cb_getExitInstructions;
			}

			static IntPtr n_GetExitInstructions (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ExitInstructions);
			}
#pragma warning restore 0169

			static IntPtr id_getExitInstructions;
			public virtual unsafe string ExitInstructions {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteLine.DrivingStep']/method[@name='getExitInstructions' and count(parameter)=0]"
				[Register ("getExitInstructions", "()Ljava/lang/String;", "GetGetExitInstructionsHandler")]
				get {
					if (id_getExitInstructions == IntPtr.Zero)
						id_getExitInstructions = JNIEnv.GetMethodID (class_ref, "getExitInstructions", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getExitInstructions), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExitInstructions", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getInstructions;
#pragma warning disable 0169
			static Delegate GetGetInstructionsHandler ()
			{
				if (cb_getInstructions == null)
					cb_getInstructions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInstructions);
				return cb_getInstructions;
			}

			static IntPtr n_GetInstructions (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Instructions);
			}
#pragma warning restore 0169

			static IntPtr id_getInstructions;
			public virtual unsafe string Instructions {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteLine.DrivingStep']/method[@name='getInstructions' and count(parameter)=0]"
				[Register ("getInstructions", "()Ljava/lang/String;", "GetGetInstructionsHandler")]
				get {
					if (id_getInstructions == IntPtr.Zero)
						id_getInstructions = JNIEnv.GetMethodID (class_ref, "getInstructions", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInstructions), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInstructions", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getNumTurns;
#pragma warning disable 0169
			static Delegate GetGetNumTurnsHandler ()
			{
				if (cb_getNumTurns == null)
					cb_getNumTurns = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumTurns);
				return cb_getNumTurns;
			}

			static int n_GetNumTurns (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NumTurns;
			}
#pragma warning restore 0169

			static IntPtr id_getNumTurns;
			public virtual unsafe int NumTurns {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteLine.DrivingStep']/method[@name='getNumTurns' and count(parameter)=0]"
				[Register ("getNumTurns", "()I", "GetGetNumTurnsHandler")]
				get {
					if (id_getNumTurns == IntPtr.Zero)
						id_getNumTurns = JNIEnv.GetMethodID (class_ref, "getNumTurns", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getNumTurns);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumTurns", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getTrafficList;
#pragma warning disable 0169
			static Delegate GetGetTrafficListHandler ()
			{
				if (cb_getTrafficList == null)
					cb_getTrafficList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrafficList);
				return cb_getTrafficList;
			}

			static IntPtr n_GetTrafficList (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine.DrivingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetTrafficList ());
			}
#pragma warning restore 0169

			static IntPtr id_getTrafficList;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteLine.DrivingStep']/method[@name='getTrafficList' and count(parameter)=0]"
			[Register ("getTrafficList", "()[I", "GetGetTrafficListHandler")]
			public virtual unsafe int[] GetTrafficList ()
			{
				if (id_getTrafficList == IntPtr.Zero)
					id_getTrafficList = JNIEnv.GetMethodID (class_ref, "getTrafficList", "()[I");
				try {

					if (GetType () == ThresholdType)
						return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getTrafficList), JniHandleOwnership.TransferLocalRef, typeof (int));
					else
						return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrafficList", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/route/DrivingRouteLine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrivingRouteLine); }
		}

		protected DrivingRouteLine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isSupportTraffic;
#pragma warning disable 0169
		static Delegate GetIsSupportTrafficHandler ()
		{
			if (cb_isSupportTraffic == null)
				cb_isSupportTraffic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupportTraffic);
			return cb_isSupportTraffic;
		}

		static bool n_IsSupportTraffic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupportTraffic;
		}
#pragma warning restore 0169

		static IntPtr id_isSupportTraffic;
		[Obsolete (@"deprecated")]
		public virtual unsafe bool IsSupportTraffic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteLine']/method[@name='isSupportTraffic' and count(parameter)=0]"
			[Register ("isSupportTraffic", "()Z", "GetIsSupportTrafficHandler")]
			get {
				if (id_isSupportTraffic == IntPtr.Zero)
					id_isSupportTraffic = JNIEnv.GetMethodID (class_ref, "isSupportTraffic", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isSupportTraffic);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSupportTraffic", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getWayPoints;
#pragma warning disable 0169
		static Delegate GetGetWayPointsHandler ()
		{
			if (cb_getWayPoints == null)
				cb_getWayPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWayPoints);
			return cb_getWayPoints;
		}

		static IntPtr n_GetWayPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.DrivingRouteLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.RouteNode>.ToLocalJniHandle (__this.WayPoints);
		}
#pragma warning restore 0169

		static IntPtr id_getWayPoints;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.RouteNode> WayPoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='DrivingRouteLine']/method[@name='getWayPoints' and count(parameter)=0]"
			[Register ("getWayPoints", "()Ljava/util/List;", "GetGetWayPointsHandler")]
			get {
				if (id_getWayPoints == IntPtr.Zero)
					id_getWayPoints = JNIEnv.GetMethodID (class_ref, "getWayPoints", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.RouteNode>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getWayPoints), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.RouteNode>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWayPoints", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
