using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Qrcode.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='AlignmentPattern']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/detector/AlignmentPattern", DoNotGenerateAcw=true)]
	public sealed partial class AlignmentPattern : global::Com.Google.Zxing.ResultPoint {

		internal AlignmentPattern (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
