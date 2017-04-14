using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Qrcode.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/encoder/QRCode", DoNotGenerateAcw=true)]
	public sealed partial class QRCode : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']/field[@name='NUM_MASK_PATTERNS']"
		[Register ("NUM_MASK_PATTERNS")]
		public const int NumMaskPatterns = (int) 8;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/qrcode/encoder/QRCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QRCode); }
		}

		internal QRCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']/constructor[@name='QRCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QRCode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (QRCode)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getECLevel;
		static IntPtr id_setECLevel_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_;
		public unsafe global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel ECLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']/method[@name='getECLevel' and count(parameter)=0]"
			[Register ("getECLevel", "()Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;", "GetGetECLevelHandler")]
			get {
				if (id_getECLevel == IntPtr.Zero)
					id_getECLevel = JNIEnv.GetMethodID (class_ref, "getECLevel", "()Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel> (JNIEnv.CallObjectMethod  (Handle, id_getECLevel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']/method[@name='setECLevel' and count(parameter)=1 and parameter[1][@type='com.google.zxing.qrcode.decoder.ErrorCorrectionLevel']]"
			[Register ("setECLevel", "(Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;)V", "GetSetECLevel_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_Handler")]
			set {
				if (id_setECLevel_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_ == IntPtr.Zero)
					id_setECLevel_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_ = JNIEnv.GetMethodID (class_ref, "setECLevel", "(Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setECLevel_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMaskPattern;
		static IntPtr id_setMaskPattern_I;
		public unsafe int MaskPattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']/method[@name='getMaskPattern' and count(parameter)=0]"
			[Register ("getMaskPattern", "()I", "GetGetMaskPatternHandler")]
			get {
				if (id_getMaskPattern == IntPtr.Zero)
					id_getMaskPattern = JNIEnv.GetMethodID (class_ref, "getMaskPattern", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getMaskPattern);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']/method[@name='setMaskPattern' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaskPattern", "(I)V", "GetSetMaskPattern_IHandler")]
			set {
				if (id_setMaskPattern_I == IntPtr.Zero)
					id_setMaskPattern_I = JNIEnv.GetMethodID (class_ref, "setMaskPattern", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setMaskPattern_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMatrix;
		static IntPtr id_setMatrix_Lcom_google_zxing_qrcode_encoder_ByteMatrix_;
		public unsafe global::Com.Google.Zxing.Qrcode.Encoder.ByteMatrix Matrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']/method[@name='getMatrix' and count(parameter)=0]"
			[Register ("getMatrix", "()Lcom/google/zxing/qrcode/encoder/ByteMatrix;", "GetGetMatrixHandler")]
			get {
				if (id_getMatrix == IntPtr.Zero)
					id_getMatrix = JNIEnv.GetMethodID (class_ref, "getMatrix", "()Lcom/google/zxing/qrcode/encoder/ByteMatrix;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Encoder.ByteMatrix> (JNIEnv.CallObjectMethod  (Handle, id_getMatrix), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']/method[@name='setMatrix' and count(parameter)=1 and parameter[1][@type='com.google.zxing.qrcode.encoder.ByteMatrix']]"
			[Register ("setMatrix", "(Lcom/google/zxing/qrcode/encoder/ByteMatrix;)V", "GetSetMatrix_Lcom_google_zxing_qrcode_encoder_ByteMatrix_Handler")]
			set {
				if (id_setMatrix_Lcom_google_zxing_qrcode_encoder_ByteMatrix_ == IntPtr.Zero)
					id_setMatrix_Lcom_google_zxing_qrcode_encoder_ByteMatrix_ = JNIEnv.GetMethodID (class_ref, "setMatrix", "(Lcom/google/zxing/qrcode/encoder/ByteMatrix;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setMatrix_Lcom_google_zxing_qrcode_encoder_ByteMatrix_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMode;
		static IntPtr id_setMode_Lcom_google_zxing_qrcode_decoder_Mode_;
		public unsafe global::Com.Google.Zxing.Qrcode.Decoder.Mode Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()Lcom/google/zxing/qrcode/decoder/Mode;", "GetGetModeHandler")]
			get {
				if (id_getMode == IntPtr.Zero)
					id_getMode = JNIEnv.GetMethodID (class_ref, "getMode", "()Lcom/google/zxing/qrcode/decoder/Mode;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (JNIEnv.CallObjectMethod  (Handle, id_getMode), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='com.google.zxing.qrcode.decoder.Mode']]"
			[Register ("setMode", "(Lcom/google/zxing/qrcode/decoder/Mode;)V", "GetSetMode_Lcom_google_zxing_qrcode_decoder_Mode_Handler")]
			set {
				if (id_setMode_Lcom_google_zxing_qrcode_decoder_Mode_ == IntPtr.Zero)
					id_setMode_Lcom_google_zxing_qrcode_decoder_Mode_ = JNIEnv.GetMethodID (class_ref, "setMode", "(Lcom/google/zxing/qrcode/decoder/Mode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setMode_Lcom_google_zxing_qrcode_decoder_Mode_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getVersion;
		static IntPtr id_setVersion_Lcom_google_zxing_qrcode_decoder_Version_;
		public unsafe global::Com.Google.Zxing.Qrcode.Decoder.Version Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Lcom/google/zxing/qrcode/decoder/Version;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Lcom/google/zxing/qrcode/decoder/Version;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Version> (JNIEnv.CallObjectMethod  (Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='com.google.zxing.qrcode.decoder.Version']]"
			[Register ("setVersion", "(Lcom/google/zxing/qrcode/decoder/Version;)V", "GetSetVersion_Lcom_google_zxing_qrcode_decoder_Version_Handler")]
			set {
				if (id_setVersion_Lcom_google_zxing_qrcode_decoder_Version_ == IntPtr.Zero)
					id_setVersion_Lcom_google_zxing_qrcode_decoder_Version_ = JNIEnv.GetMethodID (class_ref, "setVersion", "(Lcom/google/zxing/qrcode/decoder/Version;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setVersion_Lcom_google_zxing_qrcode_decoder_Version_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isValidMaskPattern_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='QRCode']/method[@name='isValidMaskPattern' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isValidMaskPattern", "(I)Z", "")]
		public static unsafe bool IsValidMaskPattern (int p0)
		{
			if (id_isValidMaskPattern_I == IntPtr.Zero)
				id_isValidMaskPattern_I = JNIEnv.GetStaticMethodID (class_ref, "isValidMaskPattern", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isValidMaskPattern_I, __args);
			} finally {
			}
		}

	}
}
