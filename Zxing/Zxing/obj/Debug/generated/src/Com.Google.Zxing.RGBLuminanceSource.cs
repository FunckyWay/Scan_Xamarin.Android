using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='RGBLuminanceSource']"
	[global::Android.Runtime.Register ("com/google/zxing/RGBLuminanceSource", DoNotGenerateAcw=true)]
	public sealed partial class RGBLuminanceSource : global::Com.Google.Zxing.LuminanceSource {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/RGBLuminanceSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RGBLuminanceSource); }
		}

		internal RGBLuminanceSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIarrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='RGBLuminanceSource']/constructor[@name='RGBLuminanceSource' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register (".ctor", "(II[I)V", "")]
		public unsafe RGBLuminanceSource (int p0, int p1, int[] p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (RGBLuminanceSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II[I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II[I)V", __args);
					return;
				}

				if (id_ctor_IIarrayI == IntPtr.Zero)
					id_ctor_IIarrayI = JNIEnv.GetMethodID (class_ref, "<init>", "(II[I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIarrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIarrayI, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_getMatrix;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='RGBLuminanceSource']/method[@name='getMatrix' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='RGBLuminanceSource']/method[@name='getRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
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
