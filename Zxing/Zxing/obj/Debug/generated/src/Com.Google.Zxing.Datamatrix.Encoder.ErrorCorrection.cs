using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Datamatrix.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='ErrorCorrection']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/encoder/ErrorCorrection", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCorrection : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/datamatrix/encoder/ErrorCorrection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorCorrection); }
		}

		internal ErrorCorrection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_encodeECC200_Ljava_lang_String_Lcom_google_zxing_datamatrix_encoder_SymbolInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='ErrorCorrection']/method[@name='encodeECC200' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.datamatrix.encoder.SymbolInfo']]"
		[Register ("encodeECC200", "(Ljava/lang/String;Lcom/google/zxing/datamatrix/encoder/SymbolInfo;)Ljava/lang/String;", "")]
		public static unsafe string EncodeECC200 (string p0, global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo p1)
		{
			if (id_encodeECC200_Ljava_lang_String_Lcom_google_zxing_datamatrix_encoder_SymbolInfo_ == IntPtr.Zero)
				id_encodeECC200_Ljava_lang_String_Lcom_google_zxing_datamatrix_encoder_SymbolInfo_ = JNIEnv.GetStaticMethodID (class_ref, "encodeECC200", "(Ljava/lang/String;Lcom/google/zxing/datamatrix/encoder/SymbolInfo;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeECC200_Ljava_lang_String_Lcom_google_zxing_datamatrix_encoder_SymbolInfo_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
