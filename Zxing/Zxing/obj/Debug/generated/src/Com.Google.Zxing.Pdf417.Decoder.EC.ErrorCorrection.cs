using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Pdf417.Decoder.EC {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.decoder.ec']/class[@name='ErrorCorrection']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/decoder/ec/ErrorCorrection", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCorrection : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/pdf417/decoder/ec/ErrorCorrection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorCorrection); }
		}

		internal ErrorCorrection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.pdf417.decoder.ec']/class[@name='ErrorCorrection']/constructor[@name='ErrorCorrection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorCorrection ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ErrorCorrection)) {
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

		static IntPtr id_decode_arrayIIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.decoder.ec']/class[@name='ErrorCorrection']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("decode", "([II[I)I", "")]
		public unsafe int Decode (int[] p0, int p1, int[] p2)
		{
			if (id_decode_arrayIIarrayI == IntPtr.Zero)
				id_decode_arrayIIarrayI = JNIEnv.GetMethodID (class_ref, "decode", "([II[I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_decode_arrayIIarrayI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
