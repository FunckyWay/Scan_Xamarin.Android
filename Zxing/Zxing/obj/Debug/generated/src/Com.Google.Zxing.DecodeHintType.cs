using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']"
	[global::Android.Runtime.Register ("com/google/zxing/DecodeHintType", DoNotGenerateAcw=true)]
	public sealed partial class DecodeHintType : global::Java.Lang.Enum {


		static IntPtr ALLOWED_EAN_EXTENSIONS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='ALLOWED_EAN_EXTENSIONS']"
		[Register ("ALLOWED_EAN_EXTENSIONS")]
		public static global::Com.Google.Zxing.DecodeHintType AllowedEanExtensions {
			get {
				if (ALLOWED_EAN_EXTENSIONS_jfieldId == IntPtr.Zero)
					ALLOWED_EAN_EXTENSIONS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALLOWED_EAN_EXTENSIONS", "Lcom/google/zxing/DecodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALLOWED_EAN_EXTENSIONS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ALLOWED_LENGTHS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='ALLOWED_LENGTHS']"
		[Register ("ALLOWED_LENGTHS")]
		public static global::Com.Google.Zxing.DecodeHintType AllowedLengths {
			get {
				if (ALLOWED_LENGTHS_jfieldId == IntPtr.Zero)
					ALLOWED_LENGTHS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALLOWED_LENGTHS", "Lcom/google/zxing/DecodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALLOWED_LENGTHS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ASSUME_CODE_39_CHECK_DIGIT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='ASSUME_CODE_39_CHECK_DIGIT']"
		[Register ("ASSUME_CODE_39_CHECK_DIGIT")]
		public static global::Com.Google.Zxing.DecodeHintType AssumeCode39CheckDigit {
			get {
				if (ASSUME_CODE_39_CHECK_DIGIT_jfieldId == IntPtr.Zero)
					ASSUME_CODE_39_CHECK_DIGIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASSUME_CODE_39_CHECK_DIGIT", "Lcom/google/zxing/DecodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASSUME_CODE_39_CHECK_DIGIT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ASSUME_GS1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='ASSUME_GS1']"
		[Register ("ASSUME_GS1")]
		public static global::Com.Google.Zxing.DecodeHintType AssumeGs1 {
			get {
				if (ASSUME_GS1_jfieldId == IntPtr.Zero)
					ASSUME_GS1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASSUME_GS1", "Lcom/google/zxing/DecodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASSUME_GS1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CHARACTER_SET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='CHARACTER_SET']"
		[Register ("CHARACTER_SET")]
		public static global::Com.Google.Zxing.DecodeHintType CharacterSet {
			get {
				if (CHARACTER_SET_jfieldId == IntPtr.Zero)
					CHARACTER_SET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHARACTER_SET", "Lcom/google/zxing/DecodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHARACTER_SET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NEED_RESULT_POINT_CALLBACK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='NEED_RESULT_POINT_CALLBACK']"
		[Register ("NEED_RESULT_POINT_CALLBACK")]
		public static global::Com.Google.Zxing.DecodeHintType NeedResultPointCallback {
			get {
				if (NEED_RESULT_POINT_CALLBACK_jfieldId == IntPtr.Zero)
					NEED_RESULT_POINT_CALLBACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEED_RESULT_POINT_CALLBACK", "Lcom/google/zxing/DecodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEED_RESULT_POINT_CALLBACK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OTHER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='OTHER']"
		[Register ("OTHER")]
		public static global::Com.Google.Zxing.DecodeHintType Other {
			get {
				if (OTHER_jfieldId == IntPtr.Zero)
					OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/google/zxing/DecodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr POSSIBLE_FORMATS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='POSSIBLE_FORMATS']"
		[Register ("POSSIBLE_FORMATS")]
		public static global::Com.Google.Zxing.DecodeHintType PossibleFormats {
			get {
				if (POSSIBLE_FORMATS_jfieldId == IntPtr.Zero)
					POSSIBLE_FORMATS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POSSIBLE_FORMATS", "Lcom/google/zxing/DecodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POSSIBLE_FORMATS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PURE_BARCODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='PURE_BARCODE']"
		[Register ("PURE_BARCODE")]
		public static global::Com.Google.Zxing.DecodeHintType PureBarcode {
			get {
				if (PURE_BARCODE_jfieldId == IntPtr.Zero)
					PURE_BARCODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PURE_BARCODE", "Lcom/google/zxing/DecodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PURE_BARCODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RETURN_CODABAR_START_END_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='RETURN_CODABAR_START_END']"
		[Register ("RETURN_CODABAR_START_END")]
		public static global::Com.Google.Zxing.DecodeHintType ReturnCodabarStartEnd {
			get {
				if (RETURN_CODABAR_START_END_jfieldId == IntPtr.Zero)
					RETURN_CODABAR_START_END_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RETURN_CODABAR_START_END", "Lcom/google/zxing/DecodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RETURN_CODABAR_START_END_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TRY_HARDER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/field[@name='TRY_HARDER']"
		[Register ("TRY_HARDER")]
		public static global::Com.Google.Zxing.DecodeHintType TryHarder {
			get {
				if (TRY_HARDER_jfieldId == IntPtr.Zero)
					TRY_HARDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRY_HARDER", "Lcom/google/zxing/DecodeHintType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRY_HARDER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/DecodeHintType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecodeHintType); }
		}

		internal DecodeHintType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValueType;
		public unsafe global::Java.Lang.Class ValueType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/method[@name='getValueType' and count(parameter)=0]"
			[Register ("getValueType", "()Ljava/lang/Class;", "GetGetValueTypeHandler")]
			get {
				if (id_getValueType == IntPtr.Zero)
					id_getValueType = JNIEnv.GetMethodID (class_ref, "getValueType", "()Ljava/lang/Class;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod  (Handle, id_getValueType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/DecodeHintType;", "")]
		public static unsafe global::Com.Google.Zxing.DecodeHintType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/zxing/DecodeHintType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.DecodeHintType __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.DecodeHintType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='DecodeHintType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/DecodeHintType;", "")]
		public static unsafe global::Com.Google.Zxing.DecodeHintType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/zxing/DecodeHintType;");
			try {
				return (global::Com.Google.Zxing.DecodeHintType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.DecodeHintType));
			} finally {
			}
		}

	}
}
