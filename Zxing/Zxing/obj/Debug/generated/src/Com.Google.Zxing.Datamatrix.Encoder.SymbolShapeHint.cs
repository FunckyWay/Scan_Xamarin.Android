using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Datamatrix.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolShapeHint']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/encoder/SymbolShapeHint", DoNotGenerateAcw=true)]
	public sealed partial class SymbolShapeHint : global::Java.Lang.Enum {


		static IntPtr FORCE_NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolShapeHint']/field[@name='FORCE_NONE']"
		[Register ("FORCE_NONE")]
		public static global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint ForceNone {
			get {
				if (FORCE_NONE_jfieldId == IntPtr.Zero)
					FORCE_NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORCE_NONE", "Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORCE_NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FORCE_RECTANGLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolShapeHint']/field[@name='FORCE_RECTANGLE']"
		[Register ("FORCE_RECTANGLE")]
		public static global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint ForceRectangle {
			get {
				if (FORCE_RECTANGLE_jfieldId == IntPtr.Zero)
					FORCE_RECTANGLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORCE_RECTANGLE", "Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORCE_RECTANGLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FORCE_SQUARE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolShapeHint']/field[@name='FORCE_SQUARE']"
		[Register ("FORCE_SQUARE")]
		public static global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint ForceSquare {
			get {
				if (FORCE_SQUARE_jfieldId == IntPtr.Zero)
					FORCE_SQUARE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORCE_SQUARE", "Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORCE_SQUARE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/datamatrix/encoder/SymbolShapeHint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SymbolShapeHint); }
		}

		internal SymbolShapeHint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolShapeHint']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolShapeHint']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;");
			try {
				return (global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint));
			} finally {
			}
		}

	}
}
