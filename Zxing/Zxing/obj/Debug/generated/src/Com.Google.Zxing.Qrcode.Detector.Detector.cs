using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Qrcode.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/detector/Detector", DoNotGenerateAcw=true)]
	public partial class Detector : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/qrcode/detector/Detector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Detector); }
		}

		protected Detector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_common_BitMatrix_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/constructor[@name='Detector' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;)V", "")]
		public unsafe Detector (global::Com.Google.Zxing.Common.BitMatrix p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Detector)) {
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

		static IntPtr id_getImage;
		protected unsafe global::Com.Google.Zxing.Common.BitMatrix Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Lcom/google/zxing/common/BitMatrix;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Lcom/google/zxing/common/BitMatrix;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod  (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getResultPointCallback;
		protected unsafe global::Com.Google.Zxing.IResultPointCallback ResultPointCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='getResultPointCallback' and count(parameter)=0]"
			[Register ("getResultPointCallback", "()Lcom/google/zxing/ResultPointCallback;", "GetGetResultPointCallbackHandler")]
			get {
				if (id_getResultPointCallback == IntPtr.Zero)
					id_getResultPointCallback = JNIEnv.GetMethodID (class_ref, "getResultPointCallback", "()Lcom/google/zxing/ResultPointCallback;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.IResultPointCallback> (JNIEnv.CallObjectMethod  (Handle, id_getResultPointCallback), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_calculateModuleSize_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='calculateModuleSize' and count(parameter)=3 and parameter[1][@type='com.google.zxing.ResultPoint'] and parameter[2][@type='com.google.zxing.ResultPoint'] and parameter[3][@type='com.google.zxing.ResultPoint']]"
		[Register ("calculateModuleSize", "(Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;)F", "")]
		protected unsafe float CalculateModuleSize (global::Com.Google.Zxing.ResultPoint p0, global::Com.Google.Zxing.ResultPoint p1, global::Com.Google.Zxing.ResultPoint p2)
		{
			if (id_calculateModuleSize_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_ == IntPtr.Zero)
				id_calculateModuleSize_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_ = JNIEnv.GetMethodID (class_ref, "calculateModuleSize", "(Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;)F");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				float __ret = JNIEnv.CallFloatMethod  (Handle, id_calculateModuleSize_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_detect;
#pragma warning disable 0169
		static Delegate GetDetectHandler ()
		{
			if (cb_detect == null)
				cb_detect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Detect);
			return cb_detect;
		}

		static IntPtr n_Detect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.Qrcode.Detector.Detector __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Detector.Detector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Detect ());
		}
#pragma warning restore 0169

		static IntPtr id_detect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='detect' and count(parameter)=0]"
		[Register ("detect", "()Lcom/google/zxing/common/DetectorResult;", "GetDetectHandler")]
		public virtual unsafe global::Com.Google.Zxing.Common.DetectorResult Detect ()
		{
			if (id_detect == IntPtr.Zero)
				id_detect = JNIEnv.GetMethodID (class_ref, "detect", "()Lcom/google/zxing/common/DetectorResult;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DetectorResult> (JNIEnv.CallObjectMethod  (Handle, id_detect), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DetectorResult> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detect", "()Lcom/google/zxing/common/DetectorResult;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_detect_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='detect' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("detect", "(Ljava/util/Map;)Lcom/google/zxing/common/DetectorResult;", "")]
		public unsafe global::Com.Google.Zxing.Common.DetectorResult Detect (global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p0)
		{
			if (id_detect_Ljava_util_Map_ == IntPtr.Zero)
				id_detect_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "detect", "(Ljava/util/Map;)Lcom/google/zxing/common/DetectorResult;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.Common.DetectorResult __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DetectorResult> (JNIEnv.CallObjectMethod  (Handle, id_detect_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_findAlignmentInRegion_FIIF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='findAlignmentInRegion' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float']]"
		[Register ("findAlignmentInRegion", "(FIIF)Lcom/google/zxing/qrcode/detector/AlignmentPattern;", "")]
		protected unsafe global::Com.Google.Zxing.Qrcode.Detector.AlignmentPattern FindAlignmentInRegion (float p0, int p1, int p2, float p3)
		{
			if (id_findAlignmentInRegion_FIIF == IntPtr.Zero)
				id_findAlignmentInRegion_FIIF = JNIEnv.GetMethodID (class_ref, "findAlignmentInRegion", "(FIIF)Lcom/google/zxing/qrcode/detector/AlignmentPattern;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Detector.AlignmentPattern> (JNIEnv.CallObjectMethod  (Handle, id_findAlignmentInRegion_FIIF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_processFinderPatternInfo_Lcom_google_zxing_qrcode_detector_FinderPatternInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='Detector']/method[@name='processFinderPatternInfo' and count(parameter)=1 and parameter[1][@type='com.google.zxing.qrcode.detector.FinderPatternInfo']]"
		[Register ("processFinderPatternInfo", "(Lcom/google/zxing/qrcode/detector/FinderPatternInfo;)Lcom/google/zxing/common/DetectorResult;", "")]
		protected unsafe global::Com.Google.Zxing.Common.DetectorResult ProcessFinderPatternInfo (global::Com.Google.Zxing.Qrcode.Detector.FinderPatternInfo p0)
		{
			if (id_processFinderPatternInfo_Lcom_google_zxing_qrcode_detector_FinderPatternInfo_ == IntPtr.Zero)
				id_processFinderPatternInfo_Lcom_google_zxing_qrcode_detector_FinderPatternInfo_ = JNIEnv.GetMethodID (class_ref, "processFinderPatternInfo", "(Lcom/google/zxing/qrcode/detector/FinderPatternInfo;)Lcom/google/zxing/common/DetectorResult;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Zxing.Common.DetectorResult __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DetectorResult> (JNIEnv.CallObjectMethod  (Handle, id_processFinderPatternInfo_Lcom_google_zxing_qrcode_detector_FinderPatternInfo_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
