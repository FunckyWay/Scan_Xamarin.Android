using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Datamatrix.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='HighLevelEncoder']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/encoder/HighLevelEncoder", DoNotGenerateAcw=true)]
	public sealed partial class HighLevelEncoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/datamatrix/encoder/HighLevelEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HighLevelEncoder); }
		}

		internal HighLevelEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_determineConsecutiveDigitCount_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='HighLevelEncoder']/method[@name='determineConsecutiveDigitCount' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int']]"
		[Register ("determineConsecutiveDigitCount", "(Ljava/lang/CharSequence;I)I", "")]
		public static unsafe int DetermineConsecutiveDigitCount (global::Java.Lang.ICharSequence p0, int p1)
		{
			if (id_determineConsecutiveDigitCount_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_determineConsecutiveDigitCount_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "determineConsecutiveDigitCount", "(Ljava/lang/CharSequence;I)I");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_determineConsecutiveDigitCount_Ljava_lang_CharSequence_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public static int DetermineConsecutiveDigitCount (string p0, int p1)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			int __result = DetermineConsecutiveDigitCount (jls_p0, p1);
			if (jls_p0 != null) jls_p0.Dispose ();
			return __result;
		}

		static IntPtr id_encodeHighLevel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='HighLevelEncoder']/method[@name='encodeHighLevel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeHighLevel", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EncodeHighLevel (string p0)
		{
			if (id_encodeHighLevel_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeHighLevel_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeHighLevel", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeHighLevel_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encodeHighLevel_Ljava_lang_String_Lcom_google_zxing_datamatrix_encoder_SymbolShapeHint_Lcom_google_zxing_Dimension_Lcom_google_zxing_Dimension_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='HighLevelEncoder']/method[@name='encodeHighLevel' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.datamatrix.encoder.SymbolShapeHint'] and parameter[3][@type='com.google.zxing.Dimension'] and parameter[4][@type='com.google.zxing.Dimension']]"
		[Register ("encodeHighLevel", "(Ljava/lang/String;Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;Lcom/google/zxing/Dimension;Lcom/google/zxing/Dimension;)Ljava/lang/String;", "")]
		public static unsafe string EncodeHighLevel (string p0, global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint p1, global::Com.Google.Zxing.Dimension p2, global::Com.Google.Zxing.Dimension p3)
		{
			if (id_encodeHighLevel_Ljava_lang_String_Lcom_google_zxing_datamatrix_encoder_SymbolShapeHint_Lcom_google_zxing_Dimension_Lcom_google_zxing_Dimension_ == IntPtr.Zero)
				id_encodeHighLevel_Ljava_lang_String_Lcom_google_zxing_datamatrix_encoder_SymbolShapeHint_Lcom_google_zxing_Dimension_Lcom_google_zxing_Dimension_ = JNIEnv.GetStaticMethodID (class_ref, "encodeHighLevel", "(Ljava/lang/String;Lcom/google/zxing/datamatrix/encoder/SymbolShapeHint;Lcom/google/zxing/Dimension;Lcom/google/zxing/Dimension;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeHighLevel_Ljava_lang_String_Lcom_google_zxing_datamatrix_encoder_SymbolShapeHint_Lcom_google_zxing_Dimension_Lcom_google_zxing_Dimension_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
