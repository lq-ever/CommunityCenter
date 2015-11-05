using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Route {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRouteLine']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/WalkingRouteLine", DoNotGenerateAcw=true)]
	public partial class WalkingRouteLine : global::Com.Baidu.Mapapi.Search.Core.RouteLine {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRouteLine.WalkingStep']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/WalkingRouteLine$WalkingStep", DoNotGenerateAcw=true)]
		public partial class WalkingStep : global::Com.Baidu.Mapapi.Search.Core.RouteStep {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/search/route/WalkingRouteLine$WalkingStep", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WalkingStep); }
			}

			protected WalkingStep (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRouteLine.WalkingStep']/constructor[@name='WalkingRouteLine.WalkingStep' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe WalkingStep ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (WalkingStep)) {
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
				global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine.WalkingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine.WalkingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Direction;
			}
#pragma warning restore 0169

			static IntPtr id_getDirection;
			public virtual unsafe int Direction {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRouteLine.WalkingStep']/method[@name='getDirection' and count(parameter)=0]"
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

			static Delegate cb_getEntraceInstructions;
#pragma warning disable 0169
			static Delegate GetGetEntraceInstructionsHandler ()
			{
				if (cb_getEntraceInstructions == null)
					cb_getEntraceInstructions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntraceInstructions);
				return cb_getEntraceInstructions;
			}

			static IntPtr n_GetEntraceInstructions (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine.WalkingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine.WalkingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.EntraceInstructions);
			}
#pragma warning restore 0169

			static IntPtr id_getEntraceInstructions;
			public virtual unsafe string EntraceInstructions {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRouteLine.WalkingStep']/method[@name='getEntraceInstructions' and count(parameter)=0]"
				[Register ("getEntraceInstructions", "()Ljava/lang/String;", "GetGetEntraceInstructionsHandler")]
				get {
					if (id_getEntraceInstructions == IntPtr.Zero)
						id_getEntraceInstructions = JNIEnv.GetMethodID (class_ref, "getEntraceInstructions", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEntraceInstructions), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntraceInstructions", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine.WalkingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine.WalkingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Entrance);
			}
#pragma warning restore 0169

			static IntPtr id_getEntrance;
			public virtual unsafe global::Com.Baidu.Mapapi.Search.Core.RouteNode Entrance {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRouteLine.WalkingStep']/method[@name='getEntrance' and count(parameter)=0]"
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
				global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine.WalkingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine.WalkingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Exit);
			}
#pragma warning restore 0169

			static IntPtr id_getExit;
			public virtual unsafe global::Com.Baidu.Mapapi.Search.Core.RouteNode Exit {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRouteLine.WalkingStep']/method[@name='getExit' and count(parameter)=0]"
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
				global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine.WalkingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine.WalkingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ExitInstructions);
			}
#pragma warning restore 0169

			static IntPtr id_getExitInstructions;
			public virtual unsafe string ExitInstructions {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRouteLine.WalkingStep']/method[@name='getExitInstructions' and count(parameter)=0]"
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
				global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine.WalkingStep __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.WalkingRouteLine.WalkingStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Instructions);
			}
#pragma warning restore 0169

			static IntPtr id_getInstructions;
			public virtual unsafe string Instructions {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='WalkingRouteLine.WalkingStep']/method[@name='getInstructions' and count(parameter)=0]"
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

		}

		protected WalkingRouteLine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
