using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Pdf417.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/encoder/Compaction", DoNotGenerateAcw=true)]
	public sealed partial class Compaction : global::Java.Lang.Enum {


		static IntPtr AUTO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']/field[@name='AUTO']"
		[Register ("AUTO")]
		public static global::Com.Google.Zxing.Pdf417.Encoder.Compaction Auto {
			get {
				if (AUTO_jfieldId == IntPtr.Zero)
					AUTO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTO", "Lcom/google/zxing/pdf417/encoder/Compaction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Encoder.Compaction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BYTE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']/field[@name='BYTE']"
		[Register ("BYTE")]
		public static global::Com.Google.Zxing.Pdf417.Encoder.Compaction Byte {
			get {
				if (BYTE_jfieldId == IntPtr.Zero)
					BYTE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTE", "Lcom/google/zxing/pdf417/encoder/Compaction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BYTE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Encoder.Compaction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NUMERIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']/field[@name='NUMERIC']"
		[Register ("NUMERIC")]
		public static global::Com.Google.Zxing.Pdf417.Encoder.Compaction Numeric {
			get {
				if (NUMERIC_jfieldId == IntPtr.Zero)
					NUMERIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NUMERIC", "Lcom/google/zxing/pdf417/encoder/Compaction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NUMERIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Encoder.Compaction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']/field[@name='TEXT']"
		[Register ("TEXT")]
		public static global::Com.Google.Zxing.Pdf417.Encoder.Compaction Text {
			get {
				if (TEXT_jfieldId == IntPtr.Zero)
					TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT", "Lcom/google/zxing/pdf417/encoder/Compaction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Encoder.Compaction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/pdf417/encoder/Compaction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Compaction); }
		}

		internal Compaction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/pdf417/encoder/Compaction;", "")]
		public static unsafe global::Com.Google.Zxing.Pdf417.Encoder.Compaction ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/zxing/pdf417/encoder/Compaction;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.Pdf417.Encoder.Compaction __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Encoder.Compaction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Compaction']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/pdf417/encoder/Compaction;", "")]
		public static unsafe global::Com.Google.Zxing.Pdf417.Encoder.Compaction[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/zxing/pdf417/encoder/Compaction;");
			try {
				return (global::Com.Google.Zxing.Pdf417.Encoder.Compaction[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Pdf417.Encoder.Compaction));
			} finally {
			}
		}

	}
}
