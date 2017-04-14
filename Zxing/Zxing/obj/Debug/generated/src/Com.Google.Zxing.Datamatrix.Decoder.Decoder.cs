using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Datamatrix.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Decoder']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/decoder/Decoder", DoNotGenerateAcw=true)]
	public sealed partial class Decoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/datamatrix/decoder/Decoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Decoder); }
		}

		internal Decoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Decoder']/constructor[@name='Decoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Decoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Decoder)) {
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

		static IntPtr id_decode_arrayarrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Decoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='boolean[][]']]"
		[Register ("decode", "([[Z)Lcom/google/zxing/common/DecoderResult;", "")]
		public unsafe global::Com.Google.Zxing.Common.DecoderResult Decode (bool[][] p0)
		{
			if (id_decode_arrayarrayZ == IntPtr.Zero)
				id_decode_arrayarrayZ = JNIEnv.GetMethodID (class_ref, "decode", "([[Z)Lcom/google/zxing/common/DecoderResult;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.Common.DecoderResult __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DecoderResult> (JNIEnv.CallObjectMethod  (Handle, id_decode_arrayarrayZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_decode_Lcom_google_zxing_common_BitMatrix_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Decoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register ("decode", "(Lcom/google/zxing/common/BitMatrix;)Lcom/google/zxing/common/DecoderResult;", "")]
		public unsafe global::Com.Google.Zxing.Common.DecoderResult Decode (global::Com.Google.Zxing.Common.BitMatrix p0)
		{
			if (id_decode_Lcom_google_zxing_common_BitMatrix_ == IntPtr.Zero)
				id_decode_Lcom_google_zxing_common_BitMatrix_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/google/zxing/common/BitMatrix;)Lcom/google/zxing/common/DecoderResult;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Zxing.Common.DecoderResult __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DecoderResult> (JNIEnv.CallObjectMethod  (Handle, id_decode_Lcom_google_zxing_common_BitMatrix_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
