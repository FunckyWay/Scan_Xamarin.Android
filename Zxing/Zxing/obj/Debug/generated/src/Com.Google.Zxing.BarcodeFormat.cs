using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']"
	[global::Android.Runtime.Register ("com/google/zxing/BarcodeFormat", DoNotGenerateAcw=true)]
	public sealed partial class BarcodeFormat : global::Java.Lang.Enum {


		static IntPtr AZTEC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='AZTEC']"
		[Register ("AZTEC")]
		public static global::Com.Google.Zxing.BarcodeFormat Aztec {
			get {
				if (AZTEC_jfieldId == IntPtr.Zero)
					AZTEC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AZTEC", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AZTEC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CODABAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='CODABAR']"
		[Register ("CODABAR")]
		public static global::Com.Google.Zxing.BarcodeFormat Codabar {
			get {
				if (CODABAR_jfieldId == IntPtr.Zero)
					CODABAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CODABAR", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CODABAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CODE_128_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='CODE_128']"
		[Register ("CODE_128")]
		public static global::Com.Google.Zxing.BarcodeFormat Code128 {
			get {
				if (CODE_128_jfieldId == IntPtr.Zero)
					CODE_128_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CODE_128", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CODE_128_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CODE_39_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='CODE_39']"
		[Register ("CODE_39")]
		public static global::Com.Google.Zxing.BarcodeFormat Code39 {
			get {
				if (CODE_39_jfieldId == IntPtr.Zero)
					CODE_39_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CODE_39", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CODE_39_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CODE_93_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='CODE_93']"
		[Register ("CODE_93")]
		public static global::Com.Google.Zxing.BarcodeFormat Code93 {
			get {
				if (CODE_93_jfieldId == IntPtr.Zero)
					CODE_93_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CODE_93", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CODE_93_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DATA_MATRIX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='DATA_MATRIX']"
		[Register ("DATA_MATRIX")]
		public static global::Com.Google.Zxing.BarcodeFormat DataMatrix {
			get {
				if (DATA_MATRIX_jfieldId == IntPtr.Zero)
					DATA_MATRIX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_MATRIX", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_MATRIX_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EAN_13_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='EAN_13']"
		[Register ("EAN_13")]
		public static global::Com.Google.Zxing.BarcodeFormat Ean13 {
			get {
				if (EAN_13_jfieldId == IntPtr.Zero)
					EAN_13_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EAN_13", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EAN_13_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EAN_8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='EAN_8']"
		[Register ("EAN_8")]
		public static global::Com.Google.Zxing.BarcodeFormat Ean8 {
			get {
				if (EAN_8_jfieldId == IntPtr.Zero)
					EAN_8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EAN_8", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EAN_8_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ITF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='ITF']"
		[Register ("ITF")]
		public static global::Com.Google.Zxing.BarcodeFormat Itf {
			get {
				if (ITF_jfieldId == IntPtr.Zero)
					ITF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ITF", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ITF_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MAXICODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='MAXICODE']"
		[Register ("MAXICODE")]
		public static global::Com.Google.Zxing.BarcodeFormat Maxicode {
			get {
				if (MAXICODE_jfieldId == IntPtr.Zero)
					MAXICODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAXICODE", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAXICODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PDF_417_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='PDF_417']"
		[Register ("PDF_417")]
		public static global::Com.Google.Zxing.BarcodeFormat Pdf417 {
			get {
				if (PDF_417_jfieldId == IntPtr.Zero)
					PDF_417_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PDF_417", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PDF_417_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr QR_CODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='QR_CODE']"
		[Register ("QR_CODE")]
		public static global::Com.Google.Zxing.BarcodeFormat QrCode {
			get {
				if (QR_CODE_jfieldId == IntPtr.Zero)
					QR_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QR_CODE", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QR_CODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RSS_14_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='RSS_14']"
		[Register ("RSS_14")]
		public static global::Com.Google.Zxing.BarcodeFormat Rss14 {
			get {
				if (RSS_14_jfieldId == IntPtr.Zero)
					RSS_14_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RSS_14", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RSS_14_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RSS_EXPANDED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='RSS_EXPANDED']"
		[Register ("RSS_EXPANDED")]
		public static global::Com.Google.Zxing.BarcodeFormat RssExpanded {
			get {
				if (RSS_EXPANDED_jfieldId == IntPtr.Zero)
					RSS_EXPANDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RSS_EXPANDED", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RSS_EXPANDED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UPC_A_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='UPC_A']"
		[Register ("UPC_A")]
		public static global::Com.Google.Zxing.BarcodeFormat UpcA {
			get {
				if (UPC_A_jfieldId == IntPtr.Zero)
					UPC_A_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPC_A", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPC_A_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UPC_E_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='UPC_E']"
		[Register ("UPC_E")]
		public static global::Com.Google.Zxing.BarcodeFormat UpcE {
			get {
				if (UPC_E_jfieldId == IntPtr.Zero)
					UPC_E_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPC_E", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPC_E_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UPC_EAN_EXTENSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/field[@name='UPC_EAN_EXTENSION']"
		[Register ("UPC_EAN_EXTENSION")]
		public static global::Com.Google.Zxing.BarcodeFormat UpcEanExtension {
			get {
				if (UPC_EAN_EXTENSION_jfieldId == IntPtr.Zero)
					UPC_EAN_EXTENSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPC_EAN_EXTENSION", "Lcom/google/zxing/BarcodeFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPC_EAN_EXTENSION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/BarcodeFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BarcodeFormat); }
		}

		internal BarcodeFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/BarcodeFormat;", "")]
		public static unsafe global::Com.Google.Zxing.BarcodeFormat ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/zxing/BarcodeFormat;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.BarcodeFormat __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BarcodeFormat']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/BarcodeFormat;", "")]
		public static unsafe global::Com.Google.Zxing.BarcodeFormat[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/zxing/BarcodeFormat;");
			try {
				return (global::Com.Google.Zxing.BarcodeFormat[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.BarcodeFormat));
			} finally {
			}
		}

	}
}
