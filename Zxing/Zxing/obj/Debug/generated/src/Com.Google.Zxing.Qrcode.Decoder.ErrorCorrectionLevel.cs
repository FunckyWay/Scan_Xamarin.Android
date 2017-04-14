using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Qrcode.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/decoder/ErrorCorrectionLevel", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCorrectionLevel : global::Java.Lang.Enum {


		static IntPtr H_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/field[@name='H']"
		[Register ("H")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel H {
			get {
				if (H_jfieldId == IntPtr.Zero)
					H_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "H", "Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, H_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr L_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/field[@name='L']"
		[Register ("L")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel L {
			get {
				if (L_jfieldId == IntPtr.Zero)
					L_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "L", "Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, L_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr M_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/field[@name='M']"
		[Register ("M")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel M {
			get {
				if (M_jfieldId == IntPtr.Zero)
					M_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "M", "Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, M_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Q_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/field[@name='Q']"
		[Register ("Q")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel Q {
			get {
				if (Q_jfieldId == IntPtr.Zero)
					Q_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Q", "Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Q_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/qrcode/decoder/ErrorCorrectionLevel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorCorrectionLevel); }
		}

		internal ErrorCorrectionLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getBits;
		public unsafe int Bits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/method[@name='getBits' and count(parameter)=0]"
			[Register ("getBits", "()I", "GetGetBitsHandler")]
			get {
				if (id_getBits == IntPtr.Zero)
					id_getBits = JNIEnv.GetMethodID (class_ref, "getBits", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getBits);
				} finally {
				}
			}
		}

		static IntPtr id_forBits_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/method[@name='forBits' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("forBits", "(I)Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel ForBits (int p0)
		{
			if (id_forBits_I == IntPtr.Zero)
				id_forBits_I = JNIEnv.GetStaticMethodID (class_ref, "forBits", "(I)Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_forBits_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='ErrorCorrectionLevel']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;");
			try {
				return (global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel));
			} finally {
			}
		}

	}
}
