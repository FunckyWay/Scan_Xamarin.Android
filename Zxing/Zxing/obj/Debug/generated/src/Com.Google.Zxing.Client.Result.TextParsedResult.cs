using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='TextParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/TextParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class TextParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/client/result/TextParsedResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextParsedResult); }
		}

		internal TextParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='TextParsedResult']/constructor[@name='TextParsedResult' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe TextParsedResult (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (TextParsedResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getDisplayResult;
		public override unsafe string DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='TextParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
			[Register ("getDisplayResult", "()Ljava/lang/String;", "GetGetDisplayResultHandler")]
			get {
				if (id_getDisplayResult == IntPtr.Zero)
					id_getDisplayResult = JNIEnv.GetMethodID (class_ref, "getDisplayResult", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDisplayResult), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getLanguage;
		public unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='TextParsedResult']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				if (id_getLanguage == IntPtr.Zero)
					id_getLanguage = JNIEnv.GetMethodID (class_ref, "getLanguage", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLanguage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getText;
		public unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='TextParsedResult']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				if (id_getText == IntPtr.Zero)
					id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getText), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
