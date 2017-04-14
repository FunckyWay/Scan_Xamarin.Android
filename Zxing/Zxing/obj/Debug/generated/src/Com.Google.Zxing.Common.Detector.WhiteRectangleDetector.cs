using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='WhiteRectangleDetector']"
	[global::Android.Runtime.Register ("com/google/zxing/common/detector/WhiteRectangleDetector", DoNotGenerateAcw=true)]
	public sealed partial class WhiteRectangleDetector : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/detector/WhiteRectangleDetector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WhiteRectangleDetector); }
		}

		internal WhiteRectangleDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_common_BitMatrix_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='WhiteRectangleDetector']/constructor[@name='WhiteRectangleDetector' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;)V", "")]
		public unsafe WhiteRectangleDetector (global::Com.Google.Zxing.Common.BitMatrix p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (WhiteRectangleDetector)) {
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

		static IntPtr id_ctor_Lcom_google_zxing_common_BitMatrix_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='WhiteRectangleDetector']/constructor[@name='WhiteRectangleDetector' and count(parameter)=4 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;III)V", "")]
		public unsafe WhiteRectangleDetector (global::Com.Google.Zxing.Common.BitMatrix p0, int p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (WhiteRectangleDetector)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/common/BitMatrix;III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/common/BitMatrix;III)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_common_BitMatrix_III == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_common_BitMatrix_III = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/common/BitMatrix;III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_III, __args);
			} finally {
			}
		}

		static IntPtr id_detect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='WhiteRectangleDetector']/method[@name='detect' and count(parameter)=0]"
		[Register ("detect", "()[Lcom/google/zxing/ResultPoint;", "")]
		public unsafe global::Com.Google.Zxing.ResultPoint[] Detect ()
		{
			if (id_detect == IntPtr.Zero)
				id_detect = JNIEnv.GetMethodID (class_ref, "detect", "()[Lcom/google/zxing/ResultPoint;");
			try {
				return (global::Com.Google.Zxing.ResultPoint[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_detect), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.ResultPoint));
			} finally {
			}
		}

	}
}
