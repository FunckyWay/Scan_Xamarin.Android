using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Pdf417.Decoder.EC {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.decoder.ec']/class[@name='ModulusGF']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/decoder/ec/ModulusGF", DoNotGenerateAcw=true)]
	public sealed partial class ModulusGF : global::Java.Lang.Object {


		static IntPtr PDF417_GF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.pdf417.decoder.ec']/class[@name='ModulusGF']/field[@name='PDF417_GF']"
		[Register ("PDF417_GF")]
		public static global::Com.Google.Zxing.Pdf417.Decoder.EC.ModulusGF Pdf417Gf {
			get {
				if (PDF417_GF_jfieldId == IntPtr.Zero)
					PDF417_GF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PDF417_GF", "Lcom/google/zxing/pdf417/decoder/ec/ModulusGF;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PDF417_GF_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Pdf417.Decoder.EC.ModulusGF> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/pdf417/decoder/ec/ModulusGF", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ModulusGF); }
		}

		internal ModulusGF (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
