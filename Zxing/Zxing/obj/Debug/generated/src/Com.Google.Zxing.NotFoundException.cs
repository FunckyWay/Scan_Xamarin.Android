using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='NotFoundException']"
	[global::Android.Runtime.Register ("com/google/zxing/NotFoundException", DoNotGenerateAcw=true)]
	public sealed partial class NotFoundException : global::Com.Google.Zxing.ReaderException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/NotFoundException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotFoundException); }
		}

		internal NotFoundException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getNotFoundInstance;
		public static unsafe global::Com.Google.Zxing.NotFoundException NotFoundInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='NotFoundException']/method[@name='getNotFoundInstance' and count(parameter)=0]"
			[Register ("getNotFoundInstance", "()Lcom/google/zxing/NotFoundException;", "GetGetNotFoundInstanceHandler")]
			get {
				if (id_getNotFoundInstance == IntPtr.Zero)
					id_getNotFoundInstance = JNIEnv.GetStaticMethodID (class_ref, "getNotFoundInstance", "()Lcom/google/zxing/NotFoundException;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.NotFoundException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNotFoundInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
