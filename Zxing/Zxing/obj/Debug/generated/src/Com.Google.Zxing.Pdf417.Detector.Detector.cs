using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Pdf417.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.detector']/class[@name='Detector']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/detector/Detector", DoNotGenerateAcw=true)]
	public sealed partial class Detector : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/pdf417/detector/Detector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Detector); }
		}

		internal Detector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_detect_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.detector']/class[@name='Detector']/method[@name='detect' and count(parameter)=3 and parameter[1][@type='com.google.zxing.BinaryBitmap'] and parameter[2][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;'] and parameter[3][@type='boolean']]"
		[Register ("detect", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;Z)Lcom/google/zxing/pdf417/detector/PDF417DetectorResult;", "")]
		public static unsafe global::Com.Google.Zxing.Pdf417.Detector.PDF417DetectorResult Detect (global::Com.Google.Zxing.BinaryBitmap p0, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p1, bool p2)
		{
			if (id_detect_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_Z == IntPtr.Zero)
				id_detect_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_Z = JNIEnv.GetStaticMethodID (class_ref, "detect", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;Z)Lcom/google/zxing/pdf417/detector/PDF417DetectorResult;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Com.Google.Zxing.Pdf417.Detector.PDF417DetectorResult __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Detector.PDF417DetectorResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_detect_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
