using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='MonochromeRectangleDetector']"
	[global::Android.Runtime.Register ("com/google/zxing/common/detector/MonochromeRectangleDetector", DoNotGenerateAcw=true)]
	public sealed partial class MonochromeRectangleDetector : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/detector/MonochromeRectangleDetector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MonochromeRectangleDetector); }
		}

		internal MonochromeRectangleDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_common_BitMatrix_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='MonochromeRectangleDetector']/constructor[@name='MonochromeRectangleDetector' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;)V", "")]
		public unsafe MonochromeRectangleDetector (global::Com.Google.Zxing.Common.BitMatrix p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MonochromeRectangleDetector)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='MonochromeRectangleDetector']/method[@name='detect' and count(parameter)=0]"
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
