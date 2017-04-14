using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='HybridBinarizer']"
	[global::Android.Runtime.Register ("com/google/zxing/common/HybridBinarizer", DoNotGenerateAcw=true)]
	public sealed partial class HybridBinarizer : global::Com.Google.Zxing.Common.GlobalHistogramBinarizer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/HybridBinarizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HybridBinarizer); }
		}

		internal HybridBinarizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_LuminanceSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='HybridBinarizer']/constructor[@name='HybridBinarizer' and count(parameter)=1 and parameter[1][@type='com.google.zxing.LuminanceSource']]"
		[Register (".ctor", "(Lcom/google/zxing/LuminanceSource;)V", "")]
		public unsafe HybridBinarizer (global::Com.Google.Zxing.LuminanceSource p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (HybridBinarizer)) {
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

	}
}
