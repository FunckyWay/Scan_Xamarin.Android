using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Qrcode.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='QRCodeDecoderMetaData']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/decoder/QRCodeDecoderMetaData", DoNotGenerateAcw=true)]
	public sealed partial class QRCodeDecoderMetaData : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/qrcode/decoder/QRCodeDecoderMetaData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QRCodeDecoderMetaData); }
		}

		internal QRCodeDecoderMetaData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isMirrored;
		public unsafe bool IsMirrored {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='QRCodeDecoderMetaData']/method[@name='isMirrored' and count(parameter)=0]"
			[Register ("isMirrored", "()Z", "GetIsMirroredHandler")]
			get {
				if (id_isMirrored == IntPtr.Zero)
					id_isMirrored = JNIEnv.GetMethodID (class_ref, "isMirrored", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isMirrored);
				} finally {
				}
			}
		}

		static IntPtr id_applyMirroredCorrection_arrayLcom_google_zxing_ResultPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='QRCodeDecoderMetaData']/method[@name='applyMirroredCorrection' and count(parameter)=1 and parameter[1][@type='com.google.zxing.ResultPoint[]']]"
		[Register ("applyMirroredCorrection", "([Lcom/google/zxing/ResultPoint;)V", "")]
		public unsafe void ApplyMirroredCorrection (global::Com.Google.Zxing.ResultPoint[] p0)
		{
			if (id_applyMirroredCorrection_arrayLcom_google_zxing_ResultPoint_ == IntPtr.Zero)
				id_applyMirroredCorrection_arrayLcom_google_zxing_ResultPoint_ = JNIEnv.GetMethodID (class_ref, "applyMirroredCorrection", "([Lcom/google/zxing/ResultPoint;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_applyMirroredCorrection_arrayLcom_google_zxing_ResultPoint_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
