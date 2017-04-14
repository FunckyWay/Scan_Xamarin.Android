using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Pdf417 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/PDF417Common", DoNotGenerateAcw=true)]
	public sealed partial class PDF417Common : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='BARS_IN_MODULE']"
		[Register ("BARS_IN_MODULE")]
		public const int BarsInModule = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='MAX_CODEWORDS_IN_BARCODE']"
		[Register ("MAX_CODEWORDS_IN_BARCODE")]
		public const int MaxCodewordsInBarcode = (int) 928;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='MAX_ROWS_IN_BARCODE']"
		[Register ("MAX_ROWS_IN_BARCODE")]
		public const int MaxRowsInBarcode = (int) 90;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='MIN_ROWS_IN_BARCODE']"
		[Register ("MIN_ROWS_IN_BARCODE")]
		public const int MinRowsInBarcode = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='MODULES_IN_CODEWORD']"
		[Register ("MODULES_IN_CODEWORD")]
		public const int ModulesInCodeword = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='MODULES_IN_STOP_PATTERN']"
		[Register ("MODULES_IN_STOP_PATTERN")]
		public const int ModulesInStopPattern = (int) 18;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='NUMBER_OF_CODEWORDS']"
		[Register ("NUMBER_OF_CODEWORDS")]
		public const int NumberOfCodewords = (int) 929;

		static IntPtr SYMBOL_TABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/field[@name='SYMBOL_TABLE']"
		[Register ("SYMBOL_TABLE")]
		public static IList<int> SymbolTable {
			get {
				if (SYMBOL_TABLE_jfieldId == IntPtr.Zero)
					SYMBOL_TABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYMBOL_TABLE", "[I");
				return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, SYMBOL_TABLE_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/pdf417/PDF417Common", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDF417Common); }
		}

		internal PDF417Common (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getBitCountSum_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/method[@name='getBitCountSum' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("getBitCountSum", "([I)I", "")]
		public static unsafe int GetBitCountSum (int[] p0)
		{
			if (id_getBitCountSum_arrayI == IntPtr.Zero)
				id_getBitCountSum_arrayI = JNIEnv.GetStaticMethodID (class_ref, "getBitCountSum", "([I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getBitCountSum_arrayI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getCodeword_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/method[@name='getCodeword' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCodeword", "(I)I", "")]
		public static unsafe int GetCodeword (int p0)
		{
			if (id_getCodeword_I == IntPtr.Zero)
				id_getCodeword_I = JNIEnv.GetStaticMethodID (class_ref, "getCodeword", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getCodeword_I, __args);
			} finally {
			}
		}

		static IntPtr id_toIntArray_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Common']/method[@name='toIntArray' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.Integer&gt;']]"
		[Register ("toIntArray", "(Ljava/util/Collection;)[I", "")]
		public static unsafe int[] ToIntArray (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p0)
		{
			if (id_toIntArray_Ljava_util_Collection_ == IntPtr.Zero)
				id_toIntArray_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "toIntArray", "(Ljava/util/Collection;)[I");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toIntArray_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
