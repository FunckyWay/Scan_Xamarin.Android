using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Datamatrix.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/encoder/SymbolInfo", DoNotGenerateAcw=true)]
	public partial class SymbolInfo : global::Java.Lang.Object {


		static IntPtr matrixHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/field[@name='matrixHeight']"
		[Register ("matrixHeight")]
		public int MatrixHeight {
			get {
				if (matrixHeight_jfieldId == IntPtr.Zero)
					matrixHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "matrixHeight", "I");
				return JNIEnv.GetIntField (Handle, matrixHeight_jfieldId);
			}
			set {
				if (matrixHeight_jfieldId == IntPtr.Zero)
					matrixHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "matrixHeight", "I");
				try {
					JNIEnv.SetField (Handle, matrixHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr matrixWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/field[@name='matrixWidth']"
		[Register ("matrixWidth")]
		public int MatrixWidth {
			get {
				if (matrixWidth_jfieldId == IntPtr.Zero)
					matrixWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "matrixWidth", "I");
				return JNIEnv.GetIntField (Handle, matrixWidth_jfieldId);
			}
			set {
				if (matrixWidth_jfieldId == IntPtr.Zero)
					matrixWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "matrixWidth", "I");
				try {
					JNIEnv.SetField (Handle, matrixWidth_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/datamatrix/encoder/SymbolInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SymbolInfo); }
		}

		protected SymbolInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ZIIIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/constructor[@name='SymbolInfo' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register (".ctor", "(ZIIIII)V", "")]
		public unsafe SymbolInfo (bool p0, int p1, int p2, int p3, int p4, int p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (SymbolInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZIIIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZIIIII)V", __args);
					return;
				}

				if (id_ctor_ZIIIII == IntPtr.Zero)
					id_ctor_ZIIIII = JNIEnv.GetMethodID (class_ref, "<init>", "(ZIIIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZIIIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZIIIII, __args);
			} finally {
			}
		}

		static Delegate cb_getCodewordCount;
#pragma warning disable 0169
		static Delegate GetGetCodewordCountHandler ()
		{
			if (cb_getCodewordCount == null)
				cb_getCodewordCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCodewordCount);
			return cb_getCodewordCount;
		}

		static int n_GetCodewordCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CodewordCount;
		}
#pragma warning restore 0169

		static IntPtr id_getCodewordCount;
		public virtual unsafe int CodewordCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getCodewordCount' and count(parameter)=0]"
			[Register ("getCodewordCount", "()I", "GetGetCodewordCountHandler")]
			get {
				if (id_getCodewordCount == IntPtr.Zero)
					id_getCodewordCount = JNIEnv.GetMethodID (class_ref, "getCodewordCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCodewordCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodewordCount", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_getDataCapacity;
		public unsafe int DataCapacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getDataCapacity' and count(parameter)=0]"
			[Register ("getDataCapacity", "()I", "GetGetDataCapacityHandler")]
			get {
				if (id_getDataCapacity == IntPtr.Zero)
					id_getDataCapacity = JNIEnv.GetMethodID (class_ref, "getDataCapacity", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getDataCapacity);
				} finally {
				}
			}
		}

		static IntPtr id_getErrorCodewords;
		public unsafe int ErrorCodewords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getErrorCodewords' and count(parameter)=0]"
			[Register ("getErrorCodewords", "()I", "GetGetErrorCodewordsHandler")]
			get {
				if (id_getErrorCodewords == IntPtr.Zero)
					id_getErrorCodewords = JNIEnv.GetMethodID (class_ref, "getErrorCodewords", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getErrorCodewords);
				} finally {
				}
			}
		}

		static Delegate cb_getInterleavedBlockCount;
#pragma warning disable 0169
		static Delegate GetGetInterleavedBlockCountHandler ()
		{
			if (cb_getInterleavedBlockCount == null)
				cb_getInterleavedBlockCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInterleavedBlockCount);
			return cb_getInterleavedBlockCount;
		}

		static int n_GetInterleavedBlockCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InterleavedBlockCount;
		}
#pragma warning restore 0169

		static IntPtr id_getInterleavedBlockCount;
		public virtual unsafe int InterleavedBlockCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getInterleavedBlockCount' and count(parameter)=0]"
			[Register ("getInterleavedBlockCount", "()I", "GetGetInterleavedBlockCountHandler")]
			get {
				if (id_getInterleavedBlockCount == IntPtr.Zero)
					id_getInterleavedBlockCount = JNIEnv.GetMethodID (class_ref, "getInterleavedBlockCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getInterleavedBlockCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInterleavedBlockCount", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_getSymbolDataHeight;
		public unsafe int SymbolDataHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getSymbolDataHeight' and count(parameter)=0]"
			[Register ("getSymbolDataHeight", "()I", "GetGetSymbolDataHeightHandler")]
			get {
				if (id_getSymbolDataHeight == IntPtr.Zero)
					id_getSymbolDataHeight = JNIEnv.GetMethodID (class_ref, "getSymbolDataHeight", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSymbolDataHeight);
				} finally {
				}
			}
		}

		static IntPtr id_getSymbolDataWidth;
		public unsafe int SymbolDataWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getSymbolDataWidth' and count(parameter)=0]"
			[Register ("getSymbolDataWidth", "()I", "GetGetSymbolDataWidthHandler")]
			get {
				if (id_getSymbolDataWidth == IntPtr.Zero)
					id_getSymbolDataWidth = JNIEnv.GetMethodID (class_ref, "getSymbolDataWidth", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSymbolDataWidth);
				} finally {
				}
			}
		}

		static IntPtr id_getSymbolHeight;
		public unsafe int SymbolHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getSymbolHeight' and count(parameter)=0]"
			[Register ("getSymbolHeight", "()I", "GetGetSymbolHeightHandler")]
			get {
				if (id_getSymbolHeight == IntPtr.Zero)
					id_getSymbolHeight = JNIEnv.GetMethodID (class_ref, "getSymbolHeight", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSymbolHeight);
				} finally {
				}
			}
		}

		static IntPtr id_getSymbolWidth;
		public unsafe int SymbolWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getSymbolWidth' and count(parameter)=0]"
			[Register ("getSymbolWidth", "()I", "GetGetSymbolWidthHandler")]
			get {
				if (id_getSymbolWidth == IntPtr.Zero)
					id_getSymbolWidth = JNIEnv.GetMethodID (class_ref, "getSymbolWidth", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSymbolWidth);
				} finally {
				}
			}
		}

		static Delegate cb_getDataLengthForInterleavedBlock_I;
#pragma warning disable 0169
		static Delegate GetGetDataLengthForInterleavedBlock_IHandler ()
		{
			if (cb_getDataLengthForInterleavedBlock_I == null)
				cb_getDataLengthForInterleavedBlock_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetDataLengthForInterleavedBlock_I);
			return cb_getDataLengthForInterleavedBlock_I;
		}

		static int n_GetDataLengthForInterleavedBlock_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDataLengthForInterleavedBlock (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDataLengthForInterleavedBlock_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getDataLengthForInterleavedBlock' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDataLengthForInterleavedBlock", "(I)I", "GetGetDataLengthForInterleavedBlock_IHandler")]
		public virtual unsafe int GetDataLengthForInterleavedBlock (int p0)
		{
			if (id_getDataLengthForInterleavedBlock_I == IntPtr.Zero)
				id_getDataLengthForInterleavedBlock_I = JNIEnv.GetMethodID (class_ref, "getDataLengthForInterleavedBlock", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDataLengthForInterleavedBlock_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataLengthForInterleavedBlock", "(I)I"), __args);
			} finally {
			}
		}

		static IntPtr id_getErrorLengthForInterleavedBlock_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='getErrorLengthForInterleavedBlock' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getErrorLengthForInterleavedBlock", "(I)I", "")]
		public unsafe int GetErrorLengthForInterleavedBlock (int p0)
		{
			if (id_getErrorLengthForInterleavedBlock_I == IntPtr.Zero)
				id_getErrorLengthForInterleavedBlock_I = JNIEnv.GetMethodID (class_ref, "getErrorLengthForInterleavedBlock", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod  (Handle, id_getErrorLengthForInterleavedBlock_I, __args);
			} finally {
			}
		}

		static IntPtr id_lookup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='lookup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("lookup", "(I)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo Lookup (int p0)
		{
			if (id_lookup_I == IntPtr.Zero)
				id_lookup_I = JNIEnv.GetStaticMethodID (class_ref, "lookup", "(I)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_lookup_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_lookup_IZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='lookup' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("lookup", "(IZZ)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo Lookup (int p0, bool p1, bool p2)
		{
			if (id_lookup_IZZ == IntPtr.Zero)
				id_lookup_IZZ = JNIEnv.GetStaticMethodID (class_ref, "lookup", "(IZZ)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_lookup_IZZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_lookup_ILcom_google_zxing_datamatrix_encoder_SymbolShapeHint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='lookup' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.datamatrix.encoder.SymbolShapeHint']]"
		[Register ("lookup", "(ILcom/google/zxing/datamatrix/encoder/SymbolShapeHint;)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo Lookup (int p0, global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint p1)
		{
			if (id_lookup_ILcom_google_zxing_datamatrix_encoder_SymbolShapeHint_ == IntPtr.Zero)
				id_lookup_ILcom_google_zxing_datamatrix_encoder_SymbolShapeHint_ = JNIEnv.GetStaticMethodID (class_ref, "lookup", "(ILcom/google/zxing/datamatrix/encoder/SymbolShapeHint;)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_lookup_ILcom_google_zxing_datamatrix_encoder_SymbolShapeHint_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_lookup_ILcom_google_zxing_datamatrix_encoder_SymbolShapeHint_Lcom_google_zxing_Dimension_Lcom_google_zxing_Dimension_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='lookup' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.datamatrix.encoder.SymbolShapeHint'] and parameter[3][@type='com.google.zxing.Dimension'] and parameter[4][@type='com.google.zxing.Dimension'] and parameter[5][@type='boolean']]"
		[Register ("lookup", "(ILcom/google/zxing/datamatrix/encoder/SymbolShapeHint;Lcom/google/zxing/Dimension;Lcom/google/zxing/Dimension;Z)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo Lookup (int p0, global::Com.Google.Zxing.Datamatrix.Encoder.SymbolShapeHint p1, global::Com.Google.Zxing.Dimension p2, global::Com.Google.Zxing.Dimension p3, bool p4)
		{
			if (id_lookup_ILcom_google_zxing_datamatrix_encoder_SymbolShapeHint_Lcom_google_zxing_Dimension_Lcom_google_zxing_Dimension_Z == IntPtr.Zero)
				id_lookup_ILcom_google_zxing_datamatrix_encoder_SymbolShapeHint_Lcom_google_zxing_Dimension_Lcom_google_zxing_Dimension_Z = JNIEnv.GetStaticMethodID (class_ref, "lookup", "(ILcom/google/zxing/datamatrix/encoder/SymbolShapeHint;Lcom/google/zxing/Dimension;Lcom/google/zxing/Dimension;Z)Lcom/google/zxing/datamatrix/encoder/SymbolInfo;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_lookup_ILcom_google_zxing_datamatrix_encoder_SymbolShapeHint_Lcom_google_zxing_Dimension_Lcom_google_zxing_Dimension_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_overrideSymbolSet_arrayLcom_google_zxing_datamatrix_encoder_SymbolInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='overrideSymbolSet' and count(parameter)=1 and parameter[1][@type='com.google.zxing.datamatrix.encoder.SymbolInfo[]']]"
		[Register ("overrideSymbolSet", "([Lcom/google/zxing/datamatrix/encoder/SymbolInfo;)V", "")]
		public static unsafe void OverrideSymbolSet (global::Com.Google.Zxing.Datamatrix.Encoder.SymbolInfo[] p0)
		{
			if (id_overrideSymbolSet_arrayLcom_google_zxing_datamatrix_encoder_SymbolInfo_ == IntPtr.Zero)
				id_overrideSymbolSet_arrayLcom_google_zxing_datamatrix_encoder_SymbolInfo_ = JNIEnv.GetStaticMethodID (class_ref, "overrideSymbolSet", "([Lcom/google/zxing/datamatrix/encoder/SymbolInfo;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_overrideSymbolSet_arrayLcom_google_zxing_datamatrix_encoder_SymbolInfo_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='SymbolInfo']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
