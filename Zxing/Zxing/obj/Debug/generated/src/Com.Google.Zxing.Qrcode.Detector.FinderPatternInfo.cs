using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Qrcode.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternInfo']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/detector/FinderPatternInfo", DoNotGenerateAcw=true)]
	public sealed partial class FinderPatternInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/qrcode/detector/FinderPatternInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FinderPatternInfo); }
		}

		internal FinderPatternInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLcom_google_zxing_qrcode_detector_FinderPattern_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternInfo']/constructor[@name='FinderPatternInfo' and count(parameter)=1 and parameter[1][@type='com.google.zxing.qrcode.detector.FinderPattern[]']]"
		[Register (".ctor", "([Lcom/google/zxing/qrcode/detector/FinderPattern;)V", "")]
		public unsafe FinderPatternInfo (global::Com.Google.Zxing.Qrcode.Detector.FinderPattern[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (FinderPatternInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Lcom/google/zxing/qrcode/detector/FinderPattern;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([Lcom/google/zxing/qrcode/detector/FinderPattern;)V", __args);
					return;
				}

				if (id_ctor_arrayLcom_google_zxing_qrcode_detector_FinderPattern_ == IntPtr.Zero)
					id_ctor_arrayLcom_google_zxing_qrcode_detector_FinderPattern_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lcom/google/zxing/qrcode/detector/FinderPattern;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLcom_google_zxing_qrcode_detector_FinderPattern_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayLcom_google_zxing_qrcode_detector_FinderPattern_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getBottomLeft;
		public unsafe global::Com.Google.Zxing.Qrcode.Detector.FinderPattern BottomLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternInfo']/method[@name='getBottomLeft' and count(parameter)=0]"
			[Register ("getBottomLeft", "()Lcom/google/zxing/qrcode/detector/FinderPattern;", "GetGetBottomLeftHandler")]
			get {
				if (id_getBottomLeft == IntPtr.Zero)
					id_getBottomLeft = JNIEnv.GetMethodID (class_ref, "getBottomLeft", "()Lcom/google/zxing/qrcode/detector/FinderPattern;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Detector.FinderPattern> (JNIEnv.CallObjectMethod  (Handle, id_getBottomLeft), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTopLeft;
		public unsafe global::Com.Google.Zxing.Qrcode.Detector.FinderPattern TopLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternInfo']/method[@name='getTopLeft' and count(parameter)=0]"
			[Register ("getTopLeft", "()Lcom/google/zxing/qrcode/detector/FinderPattern;", "GetGetTopLeftHandler")]
			get {
				if (id_getTopLeft == IntPtr.Zero)
					id_getTopLeft = JNIEnv.GetMethodID (class_ref, "getTopLeft", "()Lcom/google/zxing/qrcode/detector/FinderPattern;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Detector.FinderPattern> (JNIEnv.CallObjectMethod  (Handle, id_getTopLeft), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTopRight;
		public unsafe global::Com.Google.Zxing.Qrcode.Detector.FinderPattern TopRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternInfo']/method[@name='getTopRight' and count(parameter)=0]"
			[Register ("getTopRight", "()Lcom/google/zxing/qrcode/detector/FinderPattern;", "GetGetTopRightHandler")]
			get {
				if (id_getTopRight == IntPtr.Zero)
					id_getTopRight = JNIEnv.GetMethodID (class_ref, "getTopRight", "()Lcom/google/zxing/qrcode/detector/FinderPattern;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Detector.FinderPattern> (JNIEnv.CallObjectMethod  (Handle, id_getTopRight), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
