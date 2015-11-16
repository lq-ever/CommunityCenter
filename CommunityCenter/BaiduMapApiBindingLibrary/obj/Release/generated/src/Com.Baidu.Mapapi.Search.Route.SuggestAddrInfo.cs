using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Search.Route {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='SuggestAddrInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/search/route/SuggestAddrInfo", DoNotGenerateAcw=true)]
	public partial class SuggestAddrInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/search/route/SuggestAddrInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SuggestAddrInfo); }
		}

		protected SuggestAddrInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='SuggestAddrInfo']/constructor[@name='SuggestAddrInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SuggestAddrInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SuggestAddrInfo)) {
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

		static Delegate cb_getSuggestEndCity;
#pragma warning disable 0169
		static Delegate GetGetSuggestEndCityHandler ()
		{
			if (cb_getSuggestEndCity == null)
				cb_getSuggestEndCity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuggestEndCity);
			return cb_getSuggestEndCity;
		}

		static IntPtr n_GetSuggestEndCity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.CityInfo>.ToLocalJniHandle (__this.SuggestEndCity);
		}
#pragma warning restore 0169

		static IntPtr id_getSuggestEndCity;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.CityInfo> SuggestEndCity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='SuggestAddrInfo']/method[@name='getSuggestEndCity' and count(parameter)=0]"
			[Register ("getSuggestEndCity", "()Ljava/util/List;", "GetGetSuggestEndCityHandler")]
			get {
				if (id_getSuggestEndCity == IntPtr.Zero)
					id_getSuggestEndCity = JNIEnv.GetMethodID (class_ref, "getSuggestEndCity", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.CityInfo>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSuggestEndCity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.CityInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuggestEndCity", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSuggestEndNode;
#pragma warning disable 0169
		static Delegate GetGetSuggestEndNodeHandler ()
		{
			if (cb_getSuggestEndNode == null)
				cb_getSuggestEndNode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuggestEndNode);
			return cb_getSuggestEndNode;
		}

		static IntPtr n_GetSuggestEndNode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>.ToLocalJniHandle (__this.SuggestEndNode);
		}
#pragma warning restore 0169

		static IntPtr id_getSuggestEndNode;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo> SuggestEndNode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='SuggestAddrInfo']/method[@name='getSuggestEndNode' and count(parameter)=0]"
			[Register ("getSuggestEndNode", "()Ljava/util/List;", "GetGetSuggestEndNodeHandler")]
			get {
				if (id_getSuggestEndNode == IntPtr.Zero)
					id_getSuggestEndNode = JNIEnv.GetMethodID (class_ref, "getSuggestEndNode", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSuggestEndNode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuggestEndNode", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSuggestStartCity;
#pragma warning disable 0169
		static Delegate GetGetSuggestStartCityHandler ()
		{
			if (cb_getSuggestStartCity == null)
				cb_getSuggestStartCity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuggestStartCity);
			return cb_getSuggestStartCity;
		}

		static IntPtr n_GetSuggestStartCity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.CityInfo>.ToLocalJniHandle (__this.SuggestStartCity);
		}
#pragma warning restore 0169

		static IntPtr id_getSuggestStartCity;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.CityInfo> SuggestStartCity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='SuggestAddrInfo']/method[@name='getSuggestStartCity' and count(parameter)=0]"
			[Register ("getSuggestStartCity", "()Ljava/util/List;", "GetGetSuggestStartCityHandler")]
			get {
				if (id_getSuggestStartCity == IntPtr.Zero)
					id_getSuggestStartCity = JNIEnv.GetMethodID (class_ref, "getSuggestStartCity", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.CityInfo>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSuggestStartCity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.CityInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuggestStartCity", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSuggestStartNode;
#pragma warning disable 0169
		static Delegate GetGetSuggestStartNodeHandler ()
		{
			if (cb_getSuggestStartNode == null)
				cb_getSuggestStartNode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuggestStartNode);
			return cb_getSuggestStartNode;
		}

		static IntPtr n_GetSuggestStartNode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>.ToLocalJniHandle (__this.SuggestStartNode);
		}
#pragma warning restore 0169

		static IntPtr id_getSuggestStartNode;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo> SuggestStartNode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='SuggestAddrInfo']/method[@name='getSuggestStartNode' and count(parameter)=0]"
			[Register ("getSuggestStartNode", "()Ljava/util/List;", "GetGetSuggestStartNodeHandler")]
			get {
				if (id_getSuggestStartNode == IntPtr.Zero)
					id_getSuggestStartNode = JNIEnv.GetMethodID (class_ref, "getSuggestStartNode", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSuggestStartNode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuggestStartNode", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSuggestWpCity;
#pragma warning disable 0169
		static Delegate GetGetSuggestWpCityHandler ()
		{
			if (cb_getSuggestWpCity == null)
				cb_getSuggestWpCity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuggestWpCity);
			return cb_getSuggestWpCity;
		}

		static IntPtr n_GetSuggestWpCity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.CityInfo>>.ToLocalJniHandle (__this.SuggestWpCity);
		}
#pragma warning restore 0169

		static IntPtr id_getSuggestWpCity;
		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.CityInfo>> SuggestWpCity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='SuggestAddrInfo']/method[@name='getSuggestWpCity' and count(parameter)=0]"
			[Register ("getSuggestWpCity", "()Ljava/util/List;", "GetGetSuggestWpCityHandler")]
			get {
				if (id_getSuggestWpCity == IntPtr.Zero)
					id_getSuggestWpCity = JNIEnv.GetMethodID (class_ref, "getSuggestWpCity", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.CityInfo>>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSuggestWpCity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.CityInfo>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuggestWpCity", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSuggestWpNode;
#pragma warning disable 0169
		static Delegate GetGetSuggestWpNodeHandler ()
		{
			if (cb_getSuggestWpNode == null)
				cb_getSuggestWpNode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuggestWpNode);
			return cb_getSuggestWpNode;
		}

		static IntPtr n_GetSuggestWpNode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Search.Route.SuggestAddrInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>>.ToLocalJniHandle (__this.SuggestWpNode);
		}
#pragma warning restore 0169

		static IntPtr id_getSuggestWpNode;
		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>> SuggestWpNode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.search.route']/class[@name='SuggestAddrInfo']/method[@name='getSuggestWpNode' and count(parameter)=0]"
			[Register ("getSuggestWpNode", "()Ljava/util/List;", "GetGetSuggestWpNodeHandler")]
			get {
				if (id_getSuggestWpNode == IntPtr.Zero)
					id_getSuggestWpNode = JNIEnv.GetMethodID (class_ref, "getSuggestWpNode", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSuggestWpNode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Search.Core.PoiInfo>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuggestWpNode", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
