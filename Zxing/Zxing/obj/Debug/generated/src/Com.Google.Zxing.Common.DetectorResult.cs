using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DetectorResult']"
	[global::Android.Runtime.Register ("com/google/zxing/common/DetectorResult", DoNotGenerateAcw=true)]
	public partial class DetectorResult : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/DetectorResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DetectorResult); }
		}

		protected DetectorResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_common_BitMatrix_arrayLcom_google_zxing_ResultPoint_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DetectorResult']/constructor[@name='DetectorResult' and count(parameter)=2 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='com.google.zxing.ResultPoint[]']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;[Lcom/google/zxing/ResultPoint;)V", "")]
		public unsafe DetectorResult (global::Com.Google.Zxing.Common.BitMatrix p0, global::Com.Google.Zxing.ResultPoint[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (DetectorResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/common/BitMatrix;[Lcom/google/zxing/ResultPoint;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/common/BitMatrix;[Lcom/google/zxing/ResultPoint;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_common_BitMatrix_arrayLcom_google_zxing_ResultPoint_ == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_common_BitMatrix_arrayLcom_google_zxing_ResultPoint_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/common/BitMatrix;[Lcom/google/zxing/ResultPoint;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_arrayLcom_google_zxing_ResultPoint_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_arrayLcom_google_zxing_ResultPoint_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_getBits;
		public unsafe global::Com.Google.Zxing.Common.BitMatrix Bits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DetectorResult']/method[@name='getBits' and count(parameter)=0]"
			[Register ("getBits", "()Lcom/google/zxing/common/BitMatrix;", "GetGetBitsHandler")]
			get {
				if (id_getBits == IntPtr.Zero)
					id_getBits = JNIEnv.GetMethodID (class_ref, "getBits", "()Lcom/google/zxing/common/BitMatrix;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod  (Handle, id_getBits), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPoints;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DetectorResult']/method[@name='getPoints' and count(parameter)=0]"
		[Register ("getPoints", "()[Lcom/google/zxing/ResultPoint;", "")]
		public unsafe global::Com.Google.Zxing.ResultPoint[] GetPoints ()
		{
			if (id_getPoints == IntPtr.Zero)
				id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()[Lcom/google/zxing/ResultPoint;");
			try {
				return (global::Com.Google.Zxing.ResultPoint[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.ResultPoint));
			} finally {
			}
		}

	}
}
