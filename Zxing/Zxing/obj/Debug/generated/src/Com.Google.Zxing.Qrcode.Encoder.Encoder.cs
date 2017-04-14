using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Qrcode.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='Encoder']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/encoder/Encoder", DoNotGenerateAcw=true)]
	public sealed partial class Encoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/qrcode/encoder/Encoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Encoder); }
		}

		internal Encoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_chooseMode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='Encoder']/method[@name='chooseMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("chooseMode", "(Ljava/lang/String;)Lcom/google/zxing/qrcode/decoder/Mode;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.Mode ChooseMode (string p0)
		{
			if (id_chooseMode_Ljava_lang_String_ == IntPtr.Zero)
				id_chooseMode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "chooseMode", "(Ljava/lang/String;)Lcom/google/zxing/qrcode/decoder/Mode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.Qrcode.Decoder.Mode __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_chooseMode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encode_Ljava_lang_String_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='Encoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.qrcode.decoder.ErrorCorrectionLevel']]"
		[Register ("encode", "(Ljava/lang/String;Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;)Lcom/google/zxing/qrcode/encoder/QRCode;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Encoder.QRCode Encode (string p0, global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel p1)
		{
			if (id_encode_Ljava_lang_String_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_ = JNIEnv.GetStaticMethodID (class_ref, "encode", "(Ljava/lang/String;Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;)Lcom/google/zxing/qrcode/encoder/QRCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Zxing.Qrcode.Encoder.QRCode __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Encoder.QRCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_Ljava_lang_String_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encode_Ljava_lang_String_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='Encoder']/method[@name='encode' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.qrcode.decoder.ErrorCorrectionLevel'] and parameter[3][@type='java.util.Map&lt;com.google.zxing.EncodeHintType, ?&gt;']]"
		[Register ("encode", "(Ljava/lang/String;Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;Ljava/util/Map;)Lcom/google/zxing/qrcode/encoder/QRCode;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Encoder.QRCode Encode (string p0, global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel p1, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.EncodeHintType, object> p2)
		{
			if (id_encode_Ljava_lang_String_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_Ljava_util_Map_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "encode", "(Ljava/lang/String;Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;Ljava/util/Map;)Lcom/google/zxing/qrcode/encoder/QRCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.EncodeHintType, object>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				global::Com.Google.Zxing.Qrcode.Encoder.QRCode __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Encoder.QRCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_Ljava_lang_String_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
