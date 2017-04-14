using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Pdf417.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='BarcodeMatrix']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/encoder/BarcodeMatrix", DoNotGenerateAcw=true)]
	public sealed partial class BarcodeMatrix : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/pdf417/encoder/BarcodeMatrix", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BarcodeMatrix); }
		}

		internal BarcodeMatrix (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getMatrix;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='BarcodeMatrix']/method[@name='getMatrix' and count(parameter)=0]"
		[Register ("getMatrix", "()[[B", "")]
		public unsafe byte[][] GetMatrix ()
		{
			if (id_getMatrix == IntPtr.Zero)
				id_getMatrix = JNIEnv.GetMethodID (class_ref, "getMatrix", "()[[B");
			try {
				return (byte[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getMatrix), JniHandleOwnership.TransferLocalRef, typeof (byte[]));
			} finally {
			}
		}

		static IntPtr id_getScaledMatrix_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='BarcodeMatrix']/method[@name='getScaledMatrix' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getScaledMatrix", "(II)[[B", "")]
		public unsafe byte[][] GetScaledMatrix (int p0, int p1)
		{
			if (id_getScaledMatrix_II == IntPtr.Zero)
				id_getScaledMatrix_II = JNIEnv.GetMethodID (class_ref, "getScaledMatrix", "(II)[[B");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return (byte[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getScaledMatrix_II, __args), JniHandleOwnership.TransferLocalRef, typeof (byte[]));
			} finally {
			}
		}

	}
}
