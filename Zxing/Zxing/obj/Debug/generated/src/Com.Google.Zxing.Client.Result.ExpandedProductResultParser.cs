using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductResultParser']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/ExpandedProductResultParser", DoNotGenerateAcw=true)]
	public sealed partial class ExpandedProductResultParser : global::Com.Google.Zxing.Client.Result.ResultParser {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/client/result/ExpandedProductResultParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExpandedProductResultParser); }
		}

		internal ExpandedProductResultParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductResultParser']/constructor[@name='ExpandedProductResultParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExpandedProductResultParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ExpandedProductResultParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_parse_Lcom_google_zxing_Result_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductResultParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.google.zxing.Result']]"
		[Register ("parse", "(Lcom/google/zxing/Result;)Lcom/google/zxing/client/result/ExpandedProductParsedResult;", "")]
		public unsafe global::Com.Google.Zxing.Client.Result.ExpandedProductParsedResult Parse (global::Com.Google.Zxing.Result p0)
		{
			if (id_parse_Lcom_google_zxing_Result_ == IntPtr.Zero)
				id_parse_Lcom_google_zxing_Result_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lcom/google/zxing/Result;)Lcom/google/zxing/client/result/ExpandedProductParsedResult;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Zxing.Client.Result.ExpandedProductParsedResult __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ExpandedProductParsedResult> (JNIEnv.CallObjectMethod  (Handle, id_parse_Lcom_google_zxing_Result_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
