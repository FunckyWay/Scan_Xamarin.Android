using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Multi.Qrcode.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.multi.qrcode.detector']/class[@name='MultiDetector']"
	[global::Android.Runtime.Register ("com/google/zxing/multi/qrcode/detector/MultiDetector", DoNotGenerateAcw=true)]
	public sealed partial class MultiDetector : global::Com.Google.Zxing.Qrcode.Detector.Detector {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/multi/qrcode/detector/MultiDetector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiDetector); }
		}

		internal MultiDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_common_BitMatrix_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.multi.qrcode.detector']/class[@name='MultiDetector']/constructor[@name='MultiDetector' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;)V", "")]
		public unsafe MultiDetector (global::Com.Google.Zxing.Common.BitMatrix p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MultiDetector)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/common/BitMatrix;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/common/BitMatrix;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_common_BitMatrix_ == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_common_BitMatrix_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/common/BitMatrix;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_, __args);
			} finally {
			}
		}

		static IntPtr id_detectMulti_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi.qrcode.detector']/class[@name='MultiDetector']/method[@name='detectMulti' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("detectMulti", "(Ljava/util/Map;)[Lcom/google/zxing/common/DetectorResult;", "")]
		public unsafe global::Com.Google.Zxing.Common.DetectorResult[] DetectMulti (global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p0)
		{
			if (id_detectMulti_Ljava_util_Map_ == IntPtr.Zero)
				id_detectMulti_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "detectMulti", "(Ljava/util/Map;)[Lcom/google/zxing/common/DetectorResult;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.Common.DetectorResult[] __ret = (global::Com.Google.Zxing.Common.DetectorResult[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_detectMulti_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Common.DetectorResult));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
