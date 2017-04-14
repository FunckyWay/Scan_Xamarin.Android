using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Qrcode.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/decoder/Mode", DoNotGenerateAcw=true)]
	public sealed partial class Mode : global::Java.Lang.Enum {


		static IntPtr ALPHANUMERIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='ALPHANUMERIC']"
		[Register ("ALPHANUMERIC")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode Alphanumeric {
			get {
				if (ALPHANUMERIC_jfieldId == IntPtr.Zero)
					ALPHANUMERIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALPHANUMERIC", "Lcom/google/zxing/qrcode/decoder/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALPHANUMERIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BYTE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='BYTE']"
		[Register ("BYTE")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode Byte {
			get {
				if (BYTE_jfieldId == IntPtr.Zero)
					BYTE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTE", "Lcom/google/zxing/qrcode/decoder/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BYTE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ECI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='ECI']"
		[Register ("ECI")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode Eci {
			get {
				if (ECI_jfieldId == IntPtr.Zero)
					ECI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ECI", "Lcom/google/zxing/qrcode/decoder/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ECI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FNC1_FIRST_POSITION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='FNC1_FIRST_POSITION']"
		[Register ("FNC1_FIRST_POSITION")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode Fnc1FirstPosition {
			get {
				if (FNC1_FIRST_POSITION_jfieldId == IntPtr.Zero)
					FNC1_FIRST_POSITION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FNC1_FIRST_POSITION", "Lcom/google/zxing/qrcode/decoder/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FNC1_FIRST_POSITION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FNC1_SECOND_POSITION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='FNC1_SECOND_POSITION']"
		[Register ("FNC1_SECOND_POSITION")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode Fnc1SecondPosition {
			get {
				if (FNC1_SECOND_POSITION_jfieldId == IntPtr.Zero)
					FNC1_SECOND_POSITION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FNC1_SECOND_POSITION", "Lcom/google/zxing/qrcode/decoder/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FNC1_SECOND_POSITION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HANZI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='HANZI']"
		[Register ("HANZI")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode Hanzi {
			get {
				if (HANZI_jfieldId == IntPtr.Zero)
					HANZI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HANZI", "Lcom/google/zxing/qrcode/decoder/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HANZI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr KANJI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='KANJI']"
		[Register ("KANJI")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode Kanji {
			get {
				if (KANJI_jfieldId == IntPtr.Zero)
					KANJI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KANJI", "Lcom/google/zxing/qrcode/decoder/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KANJI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NUMERIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='NUMERIC']"
		[Register ("NUMERIC")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode Numeric {
			get {
				if (NUMERIC_jfieldId == IntPtr.Zero)
					NUMERIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NUMERIC", "Lcom/google/zxing/qrcode/decoder/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NUMERIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STRUCTURED_APPEND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='STRUCTURED_APPEND']"
		[Register ("STRUCTURED_APPEND")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode StructuredAppend {
			get {
				if (STRUCTURED_APPEND_jfieldId == IntPtr.Zero)
					STRUCTURED_APPEND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRUCTURED_APPEND", "Lcom/google/zxing/qrcode/decoder/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRUCTURED_APPEND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TERMINATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/field[@name='TERMINATOR']"
		[Register ("TERMINATOR")]
		public static global::Com.Google.Zxing.Qrcode.Decoder.Mode Terminator {
			get {
				if (TERMINATOR_jfieldId == IntPtr.Zero)
					TERMINATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TERMINATOR", "Lcom/google/zxing/qrcode/decoder/Mode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TERMINATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/qrcode/decoder/Mode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Mode); }
		}

		internal Mode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getBits;
		public unsafe int Bits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/method[@name='getBits' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/method[@name='forBits' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("forBits", "(I)Lcom/google/zxing/qrcode/decoder/Mode;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.Mode ForBits (int p0)
		{
			if (id_forBits_I == IntPtr.Zero)
				id_forBits_I = JNIEnv.GetStaticMethodID (class_ref, "forBits", "(I)Lcom/google/zxing/qrcode/decoder/Mode;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_forBits_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getCharacterCountBits_Lcom_google_zxing_qrcode_decoder_Version_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/method[@name='getCharacterCountBits' and count(parameter)=1 and parameter[1][@type='com.google.zxing.qrcode.decoder.Version']]"
		[Register ("getCharacterCountBits", "(Lcom/google/zxing/qrcode/decoder/Version;)I", "")]
		public unsafe int GetCharacterCountBits (global::Com.Google.Zxing.Qrcode.Decoder.Version p0)
		{
			if (id_getCharacterCountBits_Lcom_google_zxing_qrcode_decoder_Version_ == IntPtr.Zero)
				id_getCharacterCountBits_Lcom_google_zxing_qrcode_decoder_Version_ = JNIEnv.GetMethodID (class_ref, "getCharacterCountBits", "(Lcom/google/zxing/qrcode/decoder/Version;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_getCharacterCountBits_Lcom_google_zxing_qrcode_decoder_Version_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/qrcode/decoder/Mode;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.Mode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/zxing/qrcode/decoder/Mode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.Qrcode.Decoder.Mode __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Mode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Mode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/qrcode/decoder/Mode;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.Mode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/zxing/qrcode/decoder/Mode;");
			try {
				return (global::Com.Google.Zxing.Qrcode.Decoder.Mode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Qrcode.Decoder.Mode));
			} finally {
			}
		}

	}
}
