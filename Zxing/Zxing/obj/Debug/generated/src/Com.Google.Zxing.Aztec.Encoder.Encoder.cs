using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Aztec.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='Encoder']"
	[global::Android.Runtime.Register ("com/google/zxing/aztec/encoder/Encoder", DoNotGenerateAcw=true)]
	public sealed partial class Encoder : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='Encoder']/field[@name='DEFAULT_AZTEC_LAYERS']"
		[Register ("DEFAULT_AZTEC_LAYERS")]
		public const int DefaultAztecLayers = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='Encoder']/field[@name='DEFAULT_EC_PERCENT']"
		[Register ("DEFAULT_EC_PERCENT")]
		public const int DefaultEcPercent = (int) 33;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/aztec/encoder/Encoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Encoder); }
		}

		internal Encoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='Encoder']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encode", "([B)Lcom/google/zxing/aztec/encoder/AztecCode;", "")]
		public static unsafe global::Com.Google.Zxing.Aztec.Encoder.AztecCode Encode (byte[] p0)
		{
			if (id_encode_arrayB == IntPtr.Zero)
				id_encode_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encode", "([B)Lcom/google/zxing/aztec/encoder/AztecCode;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.Aztec.Encoder.AztecCode __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.Encoder.AztecCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encode_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='Encoder']/method[@name='encode' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("encode", "([BII)Lcom/google/zxing/aztec/encoder/AztecCode;", "")]
		public static unsafe global::Com.Google.Zxing.Aztec.Encoder.AztecCode Encode (byte[] p0, int p1, int p2)
		{
			if (id_encode_arrayBII == IntPtr.Zero)
				id_encode_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "encode", "([BII)Lcom/google/zxing/aztec/encoder/AztecCode;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Google.Zxing.Aztec.Encoder.AztecCode __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Aztec.Encoder.AztecCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_arrayBII, __args), JniHandleOwnership.TransferLocalRef);
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
