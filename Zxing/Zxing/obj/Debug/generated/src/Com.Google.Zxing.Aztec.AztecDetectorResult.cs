using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Aztec {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.aztec']/class[@name='AztecDetectorResult']"
	[global::Android.Runtime.Register ("com/google/zxing/aztec/AztecDetectorResult", DoNotGenerateAcw=true)]
	public sealed partial class AztecDetectorResult : global::Com.Google.Zxing.Common.DetectorResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/aztec/AztecDetectorResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AztecDetectorResult); }
		}

		internal AztecDetectorResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_common_BitMatrix_arrayLcom_google_zxing_ResultPoint_ZII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.aztec']/class[@name='AztecDetectorResult']/constructor[@name='AztecDetectorResult' and count(parameter)=5 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='com.google.zxing.ResultPoint[]'] and parameter[3][@type='boolean'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;[Lcom/google/zxing/ResultPoint;ZII)V", "")]
		public unsafe AztecDetectorResult (global::Com.Google.Zxing.Common.BitMatrix p0, global::Com.Google.Zxing.ResultPoint[] p1, bool p2, int p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (AztecDetectorResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/common/BitMatrix;[Lcom/google/zxing/ResultPoint;ZII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/common/BitMatrix;[Lcom/google/zxing/ResultPoint;ZII)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_common_BitMatrix_arrayLcom_google_zxing_ResultPoint_ZII == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_common_BitMatrix_arrayLcom_google_zxing_ResultPoint_ZII = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/common/BitMatrix;[Lcom/google/zxing/ResultPoint;ZII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_arrayLcom_google_zxing_ResultPoint_ZII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_arrayLcom_google_zxing_ResultPoint_ZII, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_isCompact;
		public unsafe bool IsCompact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec']/class[@name='AztecDetectorResult']/method[@name='isCompact' and count(parameter)=0]"
			[Register ("isCompact", "()Z", "GetIsCompactHandler")]
			get {
				if (id_isCompact == IntPtr.Zero)
					id_isCompact = JNIEnv.GetMethodID (class_ref, "isCompact", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isCompact);
				} finally {
				}
			}
		}

		static IntPtr id_getNbDatablocks;
		public unsafe int NbDatablocks {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec']/class[@name='AztecDetectorResult']/method[@name='getNbDatablocks' and count(parameter)=0]"
			[Register ("getNbDatablocks", "()I", "GetGetNbDatablocksHandler")]
			get {
				if (id_getNbDatablocks == IntPtr.Zero)
					id_getNbDatablocks = JNIEnv.GetMethodID (class_ref, "getNbDatablocks", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getNbDatablocks);
				} finally {
				}
			}
		}

		static IntPtr id_getNbLayers;
		public unsafe int NbLayers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec']/class[@name='AztecDetectorResult']/method[@name='getNbLayers' and count(parameter)=0]"
			[Register ("getNbLayers", "()I", "GetGetNbLayersHandler")]
			get {
				if (id_getNbLayers == IntPtr.Zero)
					id_getNbLayers = JNIEnv.GetMethodID (class_ref, "getNbLayers", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getNbLayers);
				} finally {
				}
			}
		}

	}
}
