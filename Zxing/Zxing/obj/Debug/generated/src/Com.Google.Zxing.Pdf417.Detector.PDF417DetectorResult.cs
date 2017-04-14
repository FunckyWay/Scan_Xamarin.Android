using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Pdf417.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.detector']/class[@name='PDF417DetectorResult']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/detector/PDF417DetectorResult", DoNotGenerateAcw=true)]
	public sealed partial class PDF417DetectorResult : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/pdf417/detector/PDF417DetectorResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDF417DetectorResult); }
		}

		internal PDF417DetectorResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_common_BitMatrix_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.pdf417.detector']/class[@name='PDF417DetectorResult']/constructor[@name='PDF417DetectorResult' and count(parameter)=2 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='java.util.List&lt;com.google.zxing.ResultPoint[]&gt;']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;Ljava/util/List;)V", "")]
		public unsafe PDF417DetectorResult (global::Com.Google.Zxing.Common.BitMatrix p0, global::System.Collections.Generic.IList<global::Com.Google.Zxing.ResultPoint[]> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Google.Zxing.ResultPoint[]>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (PDF417DetectorResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/common/BitMatrix;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/common/BitMatrix;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_common_BitMatrix_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_common_BitMatrix_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/common/BitMatrix;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getBits;
		public unsafe global::Com.Google.Zxing.Common.BitMatrix Bits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.detector']/class[@name='PDF417DetectorResult']/method[@name='getBits' and count(parameter)=0]"
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
		public unsafe global::System.Collections.Generic.IList<global::Com.Google.Zxing.ResultPoint[]> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.detector']/class[@name='PDF417DetectorResult']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Google.Zxing.ResultPoint[]>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
