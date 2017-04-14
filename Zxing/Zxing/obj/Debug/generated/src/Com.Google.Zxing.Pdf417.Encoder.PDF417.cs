using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Pdf417.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/encoder/PDF417", DoNotGenerateAcw=true)]
	public sealed partial class PDF417 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/pdf417/encoder/PDF417", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDF417); }
		}

		internal PDF417 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/constructor[@name='PDF417' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe PDF417 (bool p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (PDF417)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Z)V", __args);
					return;
				}

				if (id_ctor_Z == IntPtr.Zero)
					id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Z, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/constructor[@name='PDF417' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PDF417 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PDF417)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getBarcodeMatrix;
		public unsafe global::Com.Google.Zxing.Pdf417.Encoder.BarcodeMatrix BarcodeMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/method[@name='getBarcodeMatrix' and count(parameter)=0]"
			[Register ("getBarcodeMatrix", "()Lcom/google/zxing/pdf417/encoder/BarcodeMatrix;", "GetGetBarcodeMatrixHandler")]
			get {
				if (id_getBarcodeMatrix == IntPtr.Zero)
					id_getBarcodeMatrix = JNIEnv.GetMethodID (class_ref, "getBarcodeMatrix", "()Lcom/google/zxing/pdf417/encoder/BarcodeMatrix;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Encoder.BarcodeMatrix> (JNIEnv.CallObjectMethod  (Handle, id_getBarcodeMatrix), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_generateBarcodeLogic_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/method[@name='generateBarcodeLogic' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("generateBarcodeLogic", "(Ljava/lang/String;I)V", "")]
		public unsafe void GenerateBarcodeLogic (string p0, int p1)
		{
			if (id_generateBarcodeLogic_Ljava_lang_String_I == IntPtr.Zero)
				id_generateBarcodeLogic_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "generateBarcodeLogic", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_generateBarcodeLogic_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setCompact_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/method[@name='setCompact' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCompact", "(Z)V", "")]
		public unsafe void SetCompact (bool p0)
		{
			if (id_setCompact_Z == IntPtr.Zero)
				id_setCompact_Z = JNIEnv.GetMethodID (class_ref, "setCompact", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setCompact_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setCompaction_Lcom_google_zxing_pdf417_encoder_Compaction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/method[@name='setCompaction' and count(parameter)=1 and parameter[1][@type='com.google.zxing.pdf417.encoder.Compaction']]"
		[Register ("setCompaction", "(Lcom/google/zxing/pdf417/encoder/Compaction;)V", "")]
		public unsafe void SetCompaction (global::Com.Google.Zxing.Pdf417.Encoder.Compaction p0)
		{
			if (id_setCompaction_Lcom_google_zxing_pdf417_encoder_Compaction_ == IntPtr.Zero)
				id_setCompaction_Lcom_google_zxing_pdf417_encoder_Compaction_ = JNIEnv.GetMethodID (class_ref, "setCompaction", "(Lcom/google/zxing/pdf417/encoder/Compaction;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setCompaction_Lcom_google_zxing_pdf417_encoder_Compaction_, __args);
			} finally {
			}
		}

		static IntPtr id_setDimensions_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/method[@name='setDimensions' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setDimensions", "(IIII)V", "")]
		public unsafe void SetDimensions (int p0, int p1, int p2, int p3)
		{
			if (id_setDimensions_IIII == IntPtr.Zero)
				id_setDimensions_IIII = JNIEnv.GetMethodID (class_ref, "setDimensions", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod  (Handle, id_setDimensions_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_setEncoding_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='PDF417']/method[@name='setEncoding' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register ("setEncoding", "(Ljava/nio/charset/Charset;)V", "")]
		public unsafe void SetEncoding (global::Java.Nio.Charset.Charset p0)
		{
			if (id_setEncoding_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_setEncoding_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "setEncoding", "(Ljava/nio/charset/Charset;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setEncoding_Ljava_nio_charset_Charset_, __args);
			} finally {
			}
		}

	}
}
