using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Aztec.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.aztec.detector']/class[@name='Detector']"
	[global::Android.Runtime.Register ("com/google/zxing/aztec/detector/Detector", DoNotGenerateAcw=true)]
	public sealed partial class Detector : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.aztec.detector']/class[@name='Detector.Point']"
		[global::Android.Runtime.Register ("com/google/zxing/aztec/detector/Detector$Point", DoNotGenerateAcw=true)]
		public sealed partial class Point : global::Java.Lang.Object {

			internal Point (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/aztec/detector/Detector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Detector); }
		}

		internal Detector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_common_BitMatrix_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.aztec.detector']/class[@name='Detector']/constructor[@name='Detector' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;)V", "")]
		public unsafe Detector (global::Com.Google.Zxing.Common.BitMatrix p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Detector)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/common/BitMatrix;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/common/BitMatrix;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_common_BitMatrix_ == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_common_BitMatrix_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/common/BitMatrix;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_, __args);
			} finally {
			}
		}

		static IntPtr id_detect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.detector']/class[@name='Detector']/method[@name='detect' and count(parameter)=0]"
		[Register ("detect", "()Lcom/google/zxing/aztec/AztecDetectorResult;", "")]
		public unsafe global::Com.Google.Zxing.Aztec.AztecDetectorResult Detect ()
		{
			if (id_detect == IntPtr.Zero)
				id_detect = JNIEnv.GetMethodID (class_ref, "detect", "()Lcom/google/zxing/aztec/AztecDetectorResult;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.AztecDetectorResult> (JNIEnv.CallObjectMethod  (Handle, id_detect), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_detect_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.detector']/class[@name='Detector']/method[@name='detect' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("detect", "(Z)Lcom/google/zxing/aztec/AztecDetectorResult;", "")]
		public unsafe global::Com.Google.Zxing.Aztec.AztecDetectorResult Detect (bool p0)
		{
			if (id_detect_Z == IntPtr.Zero)
				id_detect_Z = JNIEnv.GetMethodID (class_ref, "detect", "(Z)Lcom/google/zxing/aztec/AztecDetectorResult;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.AztecDetectorResult> (JNIEnv.CallObjectMethod  (Handle, id_detect_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
