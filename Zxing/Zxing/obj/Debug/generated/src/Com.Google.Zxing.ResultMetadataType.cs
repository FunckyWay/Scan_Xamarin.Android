using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']"
	[global::Android.Runtime.Register ("com/google/zxing/ResultMetadataType", DoNotGenerateAcw=true)]
	public sealed partial class ResultMetadataType : global::Java.Lang.Enum {


		static IntPtr BYTE_SEGMENTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='BYTE_SEGMENTS']"
		[Register ("BYTE_SEGMENTS")]
		public static global::Com.Google.Zxing.ResultMetadataType ByteSegments {
			get {
				if (BYTE_SEGMENTS_jfieldId == IntPtr.Zero)
					BYTE_SEGMENTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTE_SEGMENTS", "Lcom/google/zxing/ResultMetadataType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BYTE_SEGMENTS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERROR_CORRECTION_LEVEL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='ERROR_CORRECTION_LEVEL']"
		[Register ("ERROR_CORRECTION_LEVEL")]
		public static global::Com.Google.Zxing.ResultMetadataType ErrorCorrectionLevel {
			get {
				if (ERROR_CORRECTION_LEVEL_jfieldId == IntPtr.Zero)
					ERROR_CORRECTION_LEVEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_CORRECTION_LEVEL", "Lcom/google/zxing/ResultMetadataType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_CORRECTION_LEVEL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISSUE_NUMBER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='ISSUE_NUMBER']"
		[Register ("ISSUE_NUMBER")]
		public static global::Com.Google.Zxing.ResultMetadataType IssueNumber {
			get {
				if (ISSUE_NUMBER_jfieldId == IntPtr.Zero)
					ISSUE_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISSUE_NUMBER", "Lcom/google/zxing/ResultMetadataType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISSUE_NUMBER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ORIENTATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='ORIENTATION']"
		[Register ("ORIENTATION")]
		public static global::Com.Google.Zxing.ResultMetadataType Orientation {
			get {
				if (ORIENTATION_jfieldId == IntPtr.Zero)
					ORIENTATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ORIENTATION", "Lcom/google/zxing/ResultMetadataType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ORIENTATION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OTHER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='OTHER']"
		[Register ("OTHER")]
		public static global::Com.Google.Zxing.ResultMetadataType Other {
			get {
				if (OTHER_jfieldId == IntPtr.Zero)
					OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/google/zxing/ResultMetadataType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PDF417_EXTRA_METADATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='PDF417_EXTRA_METADATA']"
		[Register ("PDF417_EXTRA_METADATA")]
		public static global::Com.Google.Zxing.ResultMetadataType Pdf417ExtraMetadata {
			get {
				if (PDF417_EXTRA_METADATA_jfieldId == IntPtr.Zero)
					PDF417_EXTRA_METADATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PDF417_EXTRA_METADATA", "Lcom/google/zxing/ResultMetadataType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PDF417_EXTRA_METADATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr POSSIBLE_COUNTRY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='POSSIBLE_COUNTRY']"
		[Register ("POSSIBLE_COUNTRY")]
		public static global::Com.Google.Zxing.ResultMetadataType PossibleCountry {
			get {
				if (POSSIBLE_COUNTRY_jfieldId == IntPtr.Zero)
					POSSIBLE_COUNTRY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POSSIBLE_COUNTRY", "Lcom/google/zxing/ResultMetadataType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POSSIBLE_COUNTRY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STRUCTURED_APPEND_PARITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='STRUCTURED_APPEND_PARITY']"
		[Register ("STRUCTURED_APPEND_PARITY")]
		public static global::Com.Google.Zxing.ResultMetadataType StructuredAppendParity {
			get {
				if (STRUCTURED_APPEND_PARITY_jfieldId == IntPtr.Zero)
					STRUCTURED_APPEND_PARITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRUCTURED_APPEND_PARITY", "Lcom/google/zxing/ResultMetadataType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRUCTURED_APPEND_PARITY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STRUCTURED_APPEND_SEQUENCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='STRUCTURED_APPEND_SEQUENCE']"
		[Register ("STRUCTURED_APPEND_SEQUENCE")]
		public static global::Com.Google.Zxing.ResultMetadataType StructuredAppendSequence {
			get {
				if (STRUCTURED_APPEND_SEQUENCE_jfieldId == IntPtr.Zero)
					STRUCTURED_APPEND_SEQUENCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRUCTURED_APPEND_SEQUENCE", "Lcom/google/zxing/ResultMetadataType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRUCTURED_APPEND_SEQUENCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SUGGESTED_PRICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='SUGGESTED_PRICE']"
		[Register ("SUGGESTED_PRICE")]
		public static global::Com.Google.Zxing.ResultMetadataType SuggestedPrice {
			get {
				if (SUGGESTED_PRICE_jfieldId == IntPtr.Zero)
					SUGGESTED_PRICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUGGESTED_PRICE", "Lcom/google/zxing/ResultMetadataType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUGGESTED_PRICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UPC_EAN_EXTENSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/field[@name='UPC_EAN_EXTENSION']"
		[Register ("UPC_EAN_EXTENSION")]
		public static global::Com.Google.Zxing.ResultMetadataType UpcEanExtension {
			get {
				if (UPC_EAN_EXTENSION_jfieldId == IntPtr.Zero)
					UPC_EAN_EXTENSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPC_EAN_EXTENSION", "Lcom/google/zxing/ResultMetadataType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPC_EAN_EXTENSION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/ResultMetadataType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResultMetadataType); }
		}

		internal ResultMetadataType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/ResultMetadataType;", "")]
		public static unsafe global::Com.Google.Zxing.ResultMetadataType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/zxing/ResultMetadataType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.ResultMetadataType __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultMetadataType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultMetadataType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/ResultMetadataType;", "")]
		public static unsafe global::Com.Google.Zxing.ResultMetadataType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/zxing/ResultMetadataType;");
			try {
				return (global::Com.Google.Zxing.ResultMetadataType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.ResultMetadataType));
			} finally {
			}
		}

	}
}
