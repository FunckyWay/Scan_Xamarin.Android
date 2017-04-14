using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='ReaderException']"
	[global::Android.Runtime.Register ("com/google/zxing/ReaderException", DoNotGenerateAcw=true)]
	public abstract partial class ReaderException : global::Java.Lang.Exception {


		static IntPtr isStackTrace_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing']/class[@name='ReaderException']/field[@name='isStackTrace']"
		[Register ("isStackTrace")]
		protected static bool IsStackTrace {
			get {
				if (isStackTrace_jfieldId == IntPtr.Zero)
					isStackTrace_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isStackTrace", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, isStackTrace_jfieldId);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/ReaderException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReaderException); }
		}

		protected ReaderException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fillInStackTrace;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ReaderException']/method[@name='fillInStackTrace' and count(parameter)=0]"
		[Register ("fillInStackTrace", "()Ljava/lang/Throwable;", "")]
		public override sealed unsafe global::Java.Lang.Throwable FillInStackTrace ()
		{
			if (id_fillInStackTrace == IntPtr.Zero)
				id_fillInStackTrace = JNIEnv.GetMethodID (class_ref, "fillInStackTrace", "()Ljava/lang/Throwable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod  (Handle, id_fillInStackTrace), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/ReaderException", DoNotGenerateAcw=true)]
	internal partial class ReaderExceptionInvoker : ReaderException {

		public ReaderExceptionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReaderExceptionInvoker); }
		}

	}

}
