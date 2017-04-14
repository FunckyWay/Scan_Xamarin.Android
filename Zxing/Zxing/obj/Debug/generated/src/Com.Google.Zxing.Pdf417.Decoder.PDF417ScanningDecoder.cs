using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Pdf417.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.decoder']/class[@name='PDF417ScanningDecoder']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/decoder/PDF417ScanningDecoder", DoNotGenerateAcw=true)]
	public sealed partial class PDF417ScanningDecoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/pdf417/decoder/PDF417ScanningDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDF417ScanningDecoder); }
		}

		internal PDF417ScanningDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_decode_Lcom_google_zxing_common_BitMatrix_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.decoder']/class[@name='PDF417ScanningDecoder']/method[@name='decode' and count(parameter)=7 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='com.google.zxing.ResultPoint'] and parameter[3][@type='com.google.zxing.ResultPoint'] and parameter[4][@type='com.google.zxing.ResultPoint'] and parameter[5][@type='com.google.zxing.ResultPoint'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("decode", "(Lcom/google/zxing/common/BitMatrix;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;II)Lcom/google/zxing/common/DecoderResult;", "")]
		public static unsafe global::Com.Google.Zxing.Common.DecoderResult Decode (global::Com.Google.Zxing.Common.BitMatrix p0, global::Com.Google.Zxing.ResultPoint p1, global::Com.Google.Zxing.ResultPoint p2, global::Com.Google.Zxing.ResultPoint p3, global::Com.Google.Zxing.ResultPoint p4, int p5, int p6)
		{
			if (id_decode_Lcom_google_zxing_common_BitMatrix_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_II == IntPtr.Zero)
				id_decode_Lcom_google_zxing_common_BitMatrix_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_II = JNIEnv.GetStaticMethodID (class_ref, "decode", "(Lcom/google/zxing/common/BitMatrix;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;II)Lcom/google/zxing/common/DecoderResult;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				global::Com.Google.Zxing.Common.DecoderResult __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DecoderResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_Lcom_google_zxing_common_BitMatrix_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
