using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Qrcode.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPattern']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/detector/FinderPattern", DoNotGenerateAcw=true)]
	public sealed partial class FinderPattern : global::Com.Google.Zxing.ResultPoint {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/qrcode/detector/FinderPattern", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FinderPattern); }
		}

		internal FinderPattern (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getEstimatedModuleSize;
		public unsafe float EstimatedModuleSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPattern']/method[@name='getEstimatedModuleSize' and count(parameter)=0]"
			[Register ("getEstimatedModuleSize", "()F", "GetGetEstimatedModuleSizeHandler")]
			get {
				if (id_getEstimatedModuleSize == IntPtr.Zero)
					id_getEstimatedModuleSize = JNIEnv.GetMethodID (class_ref, "getEstimatedModuleSize", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getEstimatedModuleSize);
				} finally {
				}
			}
		}

	}
}
