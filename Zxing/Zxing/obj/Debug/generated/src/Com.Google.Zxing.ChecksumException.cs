using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='ChecksumException']"
	[global::Android.Runtime.Register ("com/google/zxing/ChecksumException", DoNotGenerateAcw=true)]
	public sealed partial class ChecksumException : global::Com.Google.Zxing.ReaderException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/ChecksumException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChecksumException); }
		}

		internal ChecksumException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getChecksumInstance;
		public static unsafe global::Com.Google.Zxing.ChecksumException ChecksumInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ChecksumException']/method[@name='getChecksumInstance' and count(parameter)=0]"
			[Register ("getChecksumInstance", "()Lcom/google/zxing/ChecksumException;", "GetGetChecksumInstanceHandler")]
			get {
				if (id_getChecksumInstance == IntPtr.Zero)
					id_getChecksumInstance = JNIEnv.GetStaticMethodID (class_ref, "getChecksumInstance", "()Lcom/google/zxing/ChecksumException;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ChecksumException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getChecksumInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getChecksumInstance_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ChecksumException']/method[@name='getChecksumInstance' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getChecksumInstance", "(Ljava/lang/Throwable;)Lcom/google/zxing/ChecksumException;", "")]
		public static unsafe global::Com.Google.Zxing.ChecksumException GetChecksumInstance (global::Java.Lang.Throwable p0)
		{
			if (id_getChecksumInstance_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getChecksumInstance_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "getChecksumInstance", "(Ljava/lang/Throwable;)Lcom/google/zxing/ChecksumException;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Zxing.ChecksumException __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ChecksumException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getChecksumInstance_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
