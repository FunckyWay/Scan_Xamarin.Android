using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']"
	[global::Android.Runtime.Register ("com/google/zxing/EncodeHintType", DoNotGenerateAcw=true)]
	public sealed partial class EncodeHintType : global::Java.Lang.Enum {


		static IntPtr AZTEC_LAYERS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='AZTEC_LAYERS']"
		[Register ("AZTEC_LAYERS")]
		public static global::Com.Google.Zxing.EncodeHintType AztecLayers {
			get {
				if (AZTEC_LAYERS_jfieldId == IntPtr.Zero)
					AZTEC_LAYERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AZTEC_LAYERS", "Lcom/google/zxing/EncodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AZTEC_LAYERS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CHARACTER_SET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='CHARACTER_SET']"
		[Register ("CHARACTER_SET")]
		public static global::Com.Google.Zxing.EncodeHintType CharacterSet {
			get {
				if (CHARACTER_SET_jfieldId == IntPtr.Zero)
					CHARACTER_SET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHARACTER_SET", "Lcom/google/zxing/EncodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHARACTER_SET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DATA_MATRIX_SHAPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='DATA_MATRIX_SHAPE']"
		[Register ("DATA_MATRIX_SHAPE")]
		public static global::Com.Google.Zxing.EncodeHintType DataMatrixShape {
			get {
				if (DATA_MATRIX_SHAPE_jfieldId == IntPtr.Zero)
					DATA_MATRIX_SHAPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_MATRIX_SHAPE", "Lcom/google/zxing/EncodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_MATRIX_SHAPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERROR_CORRECTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='ERROR_CORRECTION']"
		[Register ("ERROR_CORRECTION")]
		public static global::Com.Google.Zxing.EncodeHintType ErrorCorrection {
			get {
				if (ERROR_CORRECTION_jfieldId == IntPtr.Zero)
					ERROR_CORRECTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_CORRECTION", "Lcom/google/zxing/EncodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_CORRECTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MARGIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='MARGIN']"
		[Register ("MARGIN")]
		public static global::Com.Google.Zxing.EncodeHintType Margin {
			get {
				if (MARGIN_jfieldId == IntPtr.Zero)
					MARGIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MARGIN", "Lcom/google/zxing/EncodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MARGIN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MAX_SIZE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='MAX_SIZE']"
		[Register ("MAX_SIZE")]
		public static global::Com.Google.Zxing.EncodeHintType MaxSize {
			get {
				if (MAX_SIZE_jfieldId == IntPtr.Zero)
					MAX_SIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_SIZE", "Lcom/google/zxing/EncodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAX_SIZE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MIN_SIZE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='MIN_SIZE']"
		[Register ("MIN_SIZE")]
		public static global::Com.Google.Zxing.EncodeHintType MinSize {
			get {
				if (MIN_SIZE_jfieldId == IntPtr.Zero)
					MIN_SIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MIN_SIZE", "Lcom/google/zxing/EncodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MIN_SIZE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PDF417_COMPACT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='PDF417_COMPACT']"
		[Register ("PDF417_COMPACT")]
		public static global::Com.Google.Zxing.EncodeHintType Pdf417Compact {
			get {
				if (PDF417_COMPACT_jfieldId == IntPtr.Zero)
					PDF417_COMPACT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PDF417_COMPACT", "Lcom/google/zxing/EncodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PDF417_COMPACT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PDF417_COMPACTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='PDF417_COMPACTION']"
		[Register ("PDF417_COMPACTION")]
		public static global::Com.Google.Zxing.EncodeHintType Pdf417Compaction {
			get {
				if (PDF417_COMPACTION_jfieldId == IntPtr.Zero)
					PDF417_COMPACTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PDF417_COMPACTION", "Lcom/google/zxing/EncodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PDF417_COMPACTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PDF417_DIMENSIONS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/field[@name='PDF417_DIMENSIONS']"
		[Register ("PDF417_DIMENSIONS")]
		public static global::Com.Google.Zxing.EncodeHintType Pdf417Dimensions {
			get {
				if (PDF417_DIMENSIONS_jfieldId == IntPtr.Zero)
					PDF417_DIMENSIONS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PDF417_DIMENSIONS", "Lcom/google/zxing/EncodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PDF417_DIMENSIONS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/EncodeHintType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EncodeHintType); }
		}

		internal EncodeHintType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/EncodeHintType;", "")]
		public static unsafe global::Com.Google.Zxing.EncodeHintType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/zxing/EncodeHintType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.EncodeHintType __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.EncodeHintType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='EncodeHintType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/EncodeHintType;", "")]
		public static unsafe global::Com.Google.Zxing.EncodeHintType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/zxing/EncodeHintType;");
			try {
				return (global::Com.Google.Zxing.EncodeHintType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.EncodeHintType));
			} finally {
			}
		}

	}
}
