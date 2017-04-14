using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Aztec.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='HighLevelEncoder']"
	[global::Android.Runtime.Register ("com/google/zxing/aztec/encoder/HighLevelEncoder", DoNotGenerateAcw=true)]
	public sealed partial class HighLevelEncoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/aztec/encoder/HighLevelEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HighLevelEncoder); }
		}

		internal HighLevelEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='HighLevelEncoder']/constructor[@name='HighLevelEncoder' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe HighLevelEncoder (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (HighLevelEncoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='HighLevelEncoder']/method[@name='encode' and count(parameter)=0]"
		[Register ("encode", "()Lcom/google/zxing/common/BitArray;", "")]
		public unsafe global::Com.Google.Zxing.Common.BitArray Encode ()
		{
			if (id_encode == IntPtr.Zero)
				id_encode = JNIEnv.GetMethodID (class_ref, "encode", "()Lcom/google/zxing/common/BitArray;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (JNIEnv.CallObjectMethod  (Handle, id_encode), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
