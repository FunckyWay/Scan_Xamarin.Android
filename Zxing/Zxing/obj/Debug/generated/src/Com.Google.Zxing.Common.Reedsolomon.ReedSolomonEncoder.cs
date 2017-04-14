using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common.Reedsolomon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common.reedsolomon']/class[@name='ReedSolomonEncoder']"
	[global::Android.Runtime.Register ("com/google/zxing/common/reedsolomon/ReedSolomonEncoder", DoNotGenerateAcw=true)]
	public sealed partial class ReedSolomonEncoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/reedsolomon/ReedSolomonEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReedSolomonEncoder); }
		}

		internal ReedSolomonEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_common_reedsolomon_GenericGF_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common.reedsolomon']/class[@name='ReedSolomonEncoder']/constructor[@name='ReedSolomonEncoder' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.reedsolomon.GenericGF']]"
		[Register (".ctor", "(Lcom/google/zxing/common/reedsolomon/GenericGF;)V", "")]
		public unsafe ReedSolomonEncoder (global::Com.Google.Zxing.Common.Reedsolomon.GenericGF p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ReedSolomonEncoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/common/reedsolomon/GenericGF;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/common/reedsolomon/GenericGF;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_common_reedsolomon_GenericGF_ == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_common_reedsolomon_GenericGF_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/common/reedsolomon/GenericGF;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_common_reedsolomon_GenericGF_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_common_reedsolomon_GenericGF_, __args);
			} finally {
			}
		}

		static IntPtr id_encode_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common.reedsolomon']/class[@name='ReedSolomonEncoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("encode", "([II)V", "")]
		public unsafe void Encode (int[] p0, int p1)
		{
			if (id_encode_arrayII == IntPtr.Zero)
				id_encode_arrayII = JNIEnv.GetMethodID (class_ref, "encode", "([II)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_encode_arrayII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
