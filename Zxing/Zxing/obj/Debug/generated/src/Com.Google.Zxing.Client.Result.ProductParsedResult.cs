using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ProductParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/ProductParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class ProductParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/client/result/ProductParsedResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProductParsedResult); }
		}

		internal ProductParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDisplayResult;
		public override unsafe string DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ProductParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
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

		static IntPtr id_getNormalizedProductID;
		public unsafe string NormalizedProductID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ProductParsedResult']/method[@name='getNormalizedProductID' and count(parameter)=0]"
			[Register ("getNormalizedProductID", "()Ljava/lang/String;", "GetGetNormalizedProductIDHandler")]
			get {
				if (id_getNormalizedProductID == IntPtr.Zero)
					id_getNormalizedProductID = JNIEnv.GetMethodID (class_ref, "getNormalizedProductID", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNormalizedProductID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getProductID;
		public unsafe string ProductID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ProductParsedResult']/method[@name='getProductID' and count(parameter)=0]"
			[Register ("getProductID", "()Ljava/lang/String;", "GetGetProductIDHandler")]
			get {
				if (id_getProductID == IntPtr.Zero)
					id_getProductID = JNIEnv.GetMethodID (class_ref, "getProductID", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProductID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
