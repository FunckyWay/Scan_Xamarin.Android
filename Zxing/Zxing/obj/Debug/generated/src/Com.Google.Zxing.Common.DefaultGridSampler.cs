using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DefaultGridSampler']"
	[global::Android.Runtime.Register ("com/google/zxing/common/DefaultGridSampler", DoNotGenerateAcw=true)]
	public sealed partial class DefaultGridSampler : global::Com.Google.Zxing.Common.GridSampler {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/DefaultGridSampler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultGridSampler); }
		}

		internal DefaultGridSampler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DefaultGridSampler']/constructor[@name='DefaultGridSampler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultGridSampler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DefaultGridSampler)) {
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

		static IntPtr id_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DefaultGridSampler']/method[@name='sampleGrid' and count(parameter)=4 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.google.zxing.common.PerspectiveTransform']]"
		[Register ("sampleGrid", "(Lcom/google/zxing/common/BitMatrix;IILcom/google/zxing/common/PerspectiveTransform;)Lcom/google/zxing/common/BitMatrix;", "")]
		public override unsafe global::Com.Google.Zxing.Common.BitMatrix SampleGrid (global::Com.Google.Zxing.Common.BitMatrix p0, int p1, int p2, global::Com.Google.Zxing.Common.PerspectiveTransform p3)
		{
			if (id_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_ == IntPtr.Zero)
				id_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_ = JNIEnv.GetMethodID (class_ref, "sampleGrid", "(Lcom/google/zxing/common/BitMatrix;IILcom/google/zxing/common/PerspectiveTransform;)Lcom/google/zxing/common/BitMatrix;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Com.Google.Zxing.Common.BitMatrix __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod  (Handle, id_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
