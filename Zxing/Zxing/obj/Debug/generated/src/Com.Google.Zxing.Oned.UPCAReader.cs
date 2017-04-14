using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Oned {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCAReader']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/UPCAReader", DoNotGenerateAcw=true)]
	public sealed partial class UPCAReader : global::Com.Google.Zxing.Oned.UPCEANReader {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/oned/UPCAReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UPCAReader); }
		}

		internal UPCAReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCAReader']/constructor[@name='UPCAReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UPCAReader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UPCAReader)) {
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

		static IntPtr id_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCAReader']/method[@name='decodeMiddle' and count(parameter)=3 and parameter[1][@type='com.google.zxing.common.BitArray'] and parameter[2][@type='int[]'] and parameter[3][@type='java.lang.StringBuilder']]"
		[Register ("decodeMiddle", "(Lcom/google/zxing/common/BitArray;[ILjava/lang/StringBuilder;)I", "")]
		protected override unsafe int DecodeMiddle (global::Com.Google.Zxing.Common.BitArray p0, int[] p1, global::Java.Lang.StringBuilder p2)
		{
			if (id_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_ == IntPtr.Zero)
				id_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_ = JNIEnv.GetMethodID (class_ref, "decodeMiddle", "(Lcom/google/zxing/common/BitArray;[ILjava/lang/StringBuilder;)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_, __args);
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
