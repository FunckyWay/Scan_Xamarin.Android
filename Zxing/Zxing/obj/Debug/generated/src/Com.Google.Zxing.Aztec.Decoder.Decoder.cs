using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Aztec.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.aztec.decoder']/class[@name='Decoder']"
	[global::Android.Runtime.Register ("com/google/zxing/aztec/decoder/Decoder", DoNotGenerateAcw=true)]
	public sealed partial class Decoder : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.aztec.decoder']/class[@name='Decoder.Table']"
		[global::Android.Runtime.Register ("com/google/zxing/aztec/decoder/Decoder$Table", DoNotGenerateAcw=true)]
		public sealed partial class Table : global::Java.Lang.Enum {


			static IntPtr BINARY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.aztec.decoder']/class[@name='Decoder.Table']/field[@name='BINARY']"
			[Register ("BINARY")]
			public static global::Com.Google.Zxing.Aztec.Decoder.Decoder.Table Binary {
				get {
					if (BINARY_jfieldId == IntPtr.Zero)
						BINARY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BINARY", "Lcom/google/zxing/aztec/decoder/Decoder$Table;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BINARY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.Decoder.Decoder.Table> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DIGIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.aztec.decoder']/class[@name='Decoder.Table']/field[@name='DIGIT']"
			[Register ("DIGIT")]
			public static global::Com.Google.Zxing.Aztec.Decoder.Decoder.Table Digit {
				get {
					if (DIGIT_jfieldId == IntPtr.Zero)
						DIGIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIGIT", "Lcom/google/zxing/aztec/decoder/Decoder$Table;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DIGIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.Decoder.Decoder.Table> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOWER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.aztec.decoder']/class[@name='Decoder.Table']/field[@name='LOWER']"
			[Register ("LOWER")]
			public static global::Com.Google.Zxing.Aztec.Decoder.Decoder.Table Lower {
				get {
					if (LOWER_jfieldId == IntPtr.Zero)
						LOWER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWER", "Lcom/google/zxing/aztec/decoder/Decoder$Table;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOWER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.Decoder.Decoder.Table> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MIXED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.aztec.decoder']/class[@name='Decoder.Table']/field[@name='MIXED']"
			[Register ("MIXED")]
			public static global::Com.Google.Zxing.Aztec.Decoder.Decoder.Table Mixed {
				get {
					if (MIXED_jfieldId == IntPtr.Zero)
						MIXED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MIXED", "Lcom/google/zxing/aztec/decoder/Decoder$Table;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MIXED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.Decoder.Decoder.Table> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PUNCT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.aztec.decoder']/class[@name='Decoder.Table']/field[@name='PUNCT']"
			[Register ("PUNCT")]
			public static global::Com.Google.Zxing.Aztec.Decoder.Decoder.Table Punct {
				get {
					if (PUNCT_jfieldId == IntPtr.Zero)
						PUNCT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUNCT", "Lcom/google/zxing/aztec/decoder/Decoder$Table;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PUNCT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.Decoder.Decoder.Table> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UPPER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.aztec.decoder']/class[@name='Decoder.Table']/field[@name='UPPER']"
			[Register ("UPPER")]
			public static global::Com.Google.Zxing.Aztec.Decoder.Decoder.Table Upper {
				get {
					if (UPPER_jfieldId == IntPtr.Zero)
						UPPER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPPER", "Lcom/google/zxing/aztec/decoder/Decoder$Table;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPPER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.Decoder.Decoder.Table> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/zxing/aztec/decoder/Decoder$Table", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Table); }
			}

			internal Table (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/aztec/decoder/Decoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Decoder); }
		}

		internal Decoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.aztec.decoder']/class[@name='Decoder']/constructor[@name='Decoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Decoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Decoder)) {
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

		static IntPtr id_decode_Lcom_google_zxing_aztec_AztecDetectorResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.decoder']/class[@name='Decoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.google.zxing.aztec.AztecDetectorResult']]"
		[Register ("decode", "(Lcom/google/zxing/aztec/AztecDetectorResult;)Lcom/google/zxing/common/DecoderResult;", "")]
		public unsafe global::Com.Google.Zxing.Common.DecoderResult Decode (global::Com.Google.Zxing.Aztec.AztecDetectorResult p0)
		{
			if (id_decode_Lcom_google_zxing_aztec_AztecDetectorResult_ == IntPtr.Zero)
				id_decode_Lcom_google_zxing_aztec_AztecDetectorResult_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/google/zxing/aztec/AztecDetectorResult;)Lcom/google/zxing/common/DecoderResult;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Zxing.Common.DecoderResult __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DecoderResult> (JNIEnv.CallObjectMethod  (Handle, id_decode_Lcom_google_zxing_aztec_AztecDetectorResult_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_highLevelDecode_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.decoder']/class[@name='Decoder']/method[@name='highLevelDecode' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("highLevelDecode", "([Z)Ljava/lang/String;", "")]
		public static unsafe string HighLevelDecode (bool[] p0)
		{
			if (id_highLevelDecode_arrayZ == IntPtr.Zero)
				id_highLevelDecode_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "highLevelDecode", "([Z)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_highLevelDecode_arrayZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
