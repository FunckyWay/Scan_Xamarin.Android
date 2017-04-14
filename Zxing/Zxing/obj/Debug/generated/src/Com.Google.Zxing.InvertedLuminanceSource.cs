using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='InvertedLuminanceSource']"
	[global::Android.Runtime.Register ("com/google/zxing/InvertedLuminanceSource", DoNotGenerateAcw=true)]
	public sealed partial class InvertedLuminanceSource : global::Com.Google.Zxing.LuminanceSource {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/InvertedLuminanceSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InvertedLuminanceSource); }
		}

		internal InvertedLuminanceSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_LuminanceSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='InvertedLuminanceSource']/constructor[@name='InvertedLuminanceSource' and count(parameter)=1 and parameter[1][@type='com.google.zxing.LuminanceSource']]"
		[Register (".ctor", "(Lcom/google/zxing/LuminanceSource;)V", "")]
		public unsafe InvertedLuminanceSource (global::Com.Google.Zxing.LuminanceSource p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (InvertedLuminanceSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/LuminanceSource;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/LuminanceSource;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_LuminanceSource_ == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_LuminanceSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/LuminanceSource;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_LuminanceSource_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_LuminanceSource_, __args);
			} finally {
			}
		}

		static IntPtr id_getMatrix;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='InvertedLuminanceSource']/method[@name='getMatrix' and count(parameter)=0]"
		[Register ("getMatrix", "()[B", "")]
		public override unsafe byte[] GetMatrix ()
		{
			if (id_getMatrix == IntPtr.Zero)
				id_getMatrix = JNIEnv.GetMethodID (class_ref, "getMatrix", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getMatrix), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getRow_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='InvertedLuminanceSource']/method[@name='getRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("getRow", "(I[B)[B", "")]
		public override unsafe byte[] GetRow (int p0, byte[] p1)
		{
			if (id_getRow_IarrayB == IntPtr.Zero)
				id_getRow_IarrayB = JNIEnv.GetMethodID (class_ref, "getRow", "(I[B)[B");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getRow_IarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
