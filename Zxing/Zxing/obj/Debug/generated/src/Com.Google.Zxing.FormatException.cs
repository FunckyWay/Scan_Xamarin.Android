using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='FormatException']"
	[global::Android.Runtime.Register ("com/google/zxing/FormatException", DoNotGenerateAcw=true)]
	public sealed partial class FormatException : global::Com.Google.Zxing.ReaderException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/FormatException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FormatException); }
		}

		internal FormatException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getFormatInstance;
		public static unsafe global::Com.Google.Zxing.FormatException FormatInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='FormatException']/method[@name='getFormatInstance' and count(parameter)=0]"
			[Register ("getFormatInstance", "()Lcom/google/zxing/FormatException;", "GetGetFormatInstanceHandler")]
			get {
				if (id_getFormatInstance == IntPtr.Zero)
					id_getFormatInstance = JNIEnv.GetStaticMethodID (class_ref, "getFormatInstance", "()Lcom/google/zxing/FormatException;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.FormatException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFormatInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFormatInstance_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='FormatException']/method[@name='getFormatInstance' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getFormatInstance", "(Ljava/lang/Throwable;)Lcom/google/zxing/FormatException;", "")]
		public static unsafe global::Com.Google.Zxing.FormatException GetFormatInstance (global::Java.Lang.Throwable p0)
		{
			if (id_getFormatInstance_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getFormatInstance_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "getFormatInstance", "(Ljava/lang/Throwable;)Lcom/google/zxing/FormatException;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Zxing.FormatException __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.FormatException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFormatInstance_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
