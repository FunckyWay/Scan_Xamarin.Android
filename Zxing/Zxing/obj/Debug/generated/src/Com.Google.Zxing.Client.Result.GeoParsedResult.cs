using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='GeoParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/GeoParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class GeoParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/client/result/GeoParsedResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeoParsedResult); }
		}

		internal GeoParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAltitude;
		public unsafe double Altitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='GeoParsedResult']/method[@name='getAltitude' and count(parameter)=0]"
			[Register ("getAltitude", "()D", "GetGetAltitudeHandler")]
			get {
				if (id_getAltitude == IntPtr.Zero)
					id_getAltitude = JNIEnv.GetMethodID (class_ref, "getAltitude", "()D");
				try {
					return JNIEnv.CallDoubleMethod  (Handle, id_getAltitude);
				} finally {
				}
			}
		}

		static IntPtr id_getDisplayResult;
		public override unsafe string DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='GeoParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
			[Register ("getDisplayResult", "()Ljava/lang/String;", "GetGetDisplayResultHandler")]
			get {
				if (id_getDisplayResult == IntPtr.Zero)
					id_getDisplayResult = JNIEnv.GetMethodID (class_ref, "getDisplayResult", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDisplayResult), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getGeoURI;
		public unsafe string GeoURI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='GeoParsedResult']/method[@name='getGeoURI' and count(parameter)=0]"
			[Register ("getGeoURI", "()Ljava/lang/String;", "GetGetGeoURIHandler")]
			get {
				if (id_getGeoURI == IntPtr.Zero)
					id_getGeoURI = JNIEnv.GetMethodID (class_ref, "getGeoURI", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getGeoURI), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getLatitude;
		public unsafe double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='GeoParsedResult']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				if (id_getLatitude == IntPtr.Zero)
					id_getLatitude = JNIEnv.GetMethodID (class_ref, "getLatitude", "()D");
				try {
					return JNIEnv.CallDoubleMethod  (Handle, id_getLatitude);
				} finally {
				}
			}
		}

		static IntPtr id_getLongitude;
		public unsafe double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='GeoParsedResult']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler")]
			get {
				if (id_getLongitude == IntPtr.Zero)
					id_getLongitude = JNIEnv.GetMethodID (class_ref, "getLongitude", "()D");
				try {
					return JNIEnv.CallDoubleMethod  (Handle, id_getLongitude);
				} finally {
				}
			}
		}

		static IntPtr id_getQuery;
		public unsafe string Query {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='GeoParsedResult']/method[@name='getQuery' and count(parameter)=0]"
			[Register ("getQuery", "()Ljava/lang/String;", "GetGetQueryHandler")]
			get {
				if (id_getQuery == IntPtr.Zero)
					id_getQuery = JNIEnv.GetMethodID (class_ref, "getQuery", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getQuery), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
