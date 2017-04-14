using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/ResultParser", DoNotGenerateAcw=true)]
	public abstract partial class ResultParser : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/client/result/ResultParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResultParser); }
		}

		protected ResultParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/constructor[@name='ResultParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResultParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ResultParser)) {
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

		static IntPtr id_getMassagedText_Lcom_google_zxing_Result_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='getMassagedText' and count(parameter)=1 and parameter[1][@type='com.google.zxing.Result']]"
		[Register ("getMassagedText", "(Lcom/google/zxing/Result;)Ljava/lang/String;", "")]
		protected static unsafe string GetMassagedText (global::Com.Google.Zxing.Result p0)
		{
			if (id_getMassagedText_Lcom_google_zxing_Result_ == IntPtr.Zero)
				id_getMassagedText_Lcom_google_zxing_Result_ = JNIEnv.GetStaticMethodID (class_ref, "getMassagedText", "(Lcom/google/zxing/Result;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMassagedText_Lcom_google_zxing_Result_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isStringOfDigits_Ljava_lang_CharSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='isStringOfDigits' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int']]"
		[Register ("isStringOfDigits", "(Ljava/lang/CharSequence;I)Z", "")]
		protected static unsafe bool IsStringOfDigits (global::Java.Lang.ICharSequence p0, int p1)
		{
			if (id_isStringOfDigits_Ljava_lang_CharSequence_I == IntPtr.Zero)
				id_isStringOfDigits_Ljava_lang_CharSequence_I = JNIEnv.GetStaticMethodID (class_ref, "isStringOfDigits", "(Ljava/lang/CharSequence;I)Z");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isStringOfDigits_Ljava_lang_CharSequence_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		protected static bool IsStringOfDigits (string p0, int p1)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			bool __result = IsStringOfDigits (jls_p0, p1);
			if (jls_p0 != null) jls_p0.Dispose ();
			return __result;
		}

		static IntPtr id_isSubstringOfDigits_Ljava_lang_CharSequence_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='isSubstringOfDigits' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("isSubstringOfDigits", "(Ljava/lang/CharSequence;II)Z", "")]
		protected static unsafe bool IsSubstringOfDigits (global::Java.Lang.ICharSequence p0, int p1, int p2)
		{
			if (id_isSubstringOfDigits_Ljava_lang_CharSequence_II == IntPtr.Zero)
				id_isSubstringOfDigits_Ljava_lang_CharSequence_II = JNIEnv.GetStaticMethodID (class_ref, "isSubstringOfDigits", "(Ljava/lang/CharSequence;II)Z");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSubstringOfDigits_Ljava_lang_CharSequence_II, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		protected static bool IsSubstringOfDigits (string p0, int p1, int p2)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			bool __result = IsSubstringOfDigits (jls_p0, p1, p2);
			if (jls_p0 != null) jls_p0.Dispose ();
			return __result;
		}

		static IntPtr id_maybeAppend_Ljava_lang_String_Ljava_lang_StringBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='maybeAppend' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.StringBuilder']]"
		[Register ("maybeAppend", "(Ljava/lang/String;Ljava/lang/StringBuilder;)V", "")]
		protected static unsafe void MaybeAppend (string p0, global::Java.Lang.StringBuilder p1)
		{
			if (id_maybeAppend_Ljava_lang_String_Ljava_lang_StringBuilder_ == IntPtr.Zero)
				id_maybeAppend_Ljava_lang_String_Ljava_lang_StringBuilder_ = JNIEnv.GetStaticMethodID (class_ref, "maybeAppend", "(Ljava/lang/String;Ljava/lang/StringBuilder;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_maybeAppend_Ljava_lang_String_Ljava_lang_StringBuilder_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_maybeAppend_arrayLjava_lang_String_Ljava_lang_StringBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='maybeAppend' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.StringBuilder']]"
		[Register ("maybeAppend", "([Ljava/lang/String;Ljava/lang/StringBuilder;)V", "")]
		protected static unsafe void MaybeAppend (string[] p0, global::Java.Lang.StringBuilder p1)
		{
			if (id_maybeAppend_arrayLjava_lang_String_Ljava_lang_StringBuilder_ == IntPtr.Zero)
				id_maybeAppend_arrayLjava_lang_String_Ljava_lang_StringBuilder_ = JNIEnv.GetStaticMethodID (class_ref, "maybeAppend", "([Ljava/lang/String;Ljava/lang/StringBuilder;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_maybeAppend_arrayLjava_lang_String_Ljava_lang_StringBuilder_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_maybeWrap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='maybeWrap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("maybeWrap", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		protected static unsafe string[] MaybeWrap (string p0)
		{
			if (id_maybeWrap_Ljava_lang_String_ == IntPtr.Zero)
				id_maybeWrap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "maybeWrap", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_maybeWrap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_parse_Lcom_google_zxing_Result_;
#pragma warning disable 0169
		static Delegate GetParse_Lcom_google_zxing_Result_Handler ()
		{
			if (cb_parse_Lcom_google_zxing_Result_ == null)
				cb_parse_Lcom_google_zxing_Result_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Parse_Lcom_google_zxing_Result_);
			return cb_parse_Lcom_google_zxing_Result_;
		}

		static IntPtr n_Parse_Lcom_google_zxing_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Zxing.Client.Result.ResultParser __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ResultParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.Result p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.google.zxing.Result']]"
		[Register ("parse", "(Lcom/google/zxing/Result;)Lcom/google/zxing/client/result/ParsedResult;", "GetParse_Lcom_google_zxing_Result_Handler")]
		public abstract global::Com.Google.Zxing.Client.Result.ParsedResult Parse (global::Com.Google.Zxing.Result p0);

		static IntPtr id_parseHexDigit_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='parseHexDigit' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("parseHexDigit", "(C)I", "")]
		protected static unsafe int ParseHexDigit (char p0)
		{
			if (id_parseHexDigit_C == IntPtr.Zero)
				id_parseHexDigit_C = JNIEnv.GetStaticMethodID (class_ref, "parseHexDigit", "(C)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_parseHexDigit_C, __args);
			} finally {
			}
		}

		static IntPtr id_parseResult_Lcom_google_zxing_Result_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='parseResult' and count(parameter)=1 and parameter[1][@type='com.google.zxing.Result']]"
		[Register ("parseResult", "(Lcom/google/zxing/Result;)Lcom/google/zxing/client/result/ParsedResult;", "")]
		public static unsafe global::Com.Google.Zxing.Client.Result.ParsedResult ParseResult (global::Com.Google.Zxing.Result p0)
		{
			if (id_parseResult_Lcom_google_zxing_Result_ == IntPtr.Zero)
				id_parseResult_Lcom_google_zxing_Result_ = JNIEnv.GetStaticMethodID (class_ref, "parseResult", "(Lcom/google/zxing/Result;)Lcom/google/zxing/client/result/ParsedResult;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Zxing.Client.Result.ParsedResult __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseResult_Lcom_google_zxing_Result_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_unescapeBackslash_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='unescapeBackslash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unescapeBackslash", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		protected static unsafe string UnescapeBackslash (string p0)
		{
			if (id_unescapeBackslash_Ljava_lang_String_ == IntPtr.Zero)
				id_unescapeBackslash_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unescapeBackslash", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_unescapeBackslash_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/client/result/ResultParser", DoNotGenerateAcw=true)]
	internal partial class ResultParserInvoker : ResultParser {

		public ResultParserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResultParserInvoker); }
		}

		static IntPtr id_parse_Lcom_google_zxing_Result_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ResultParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.google.zxing.Result']]"
		[Register ("parse", "(Lcom/google/zxing/Result;)Lcom/google/zxing/client/result/ParsedResult;", "GetParse_Lcom_google_zxing_Result_Handler")]
		public override unsafe global::Com.Google.Zxing.Client.Result.ParsedResult Parse (global::Com.Google.Zxing.Result p0)
		{
			if (id_parse_Lcom_google_zxing_Result_ == IntPtr.Zero)
				id_parse_Lcom_google_zxing_Result_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lcom/google/zxing/Result;)Lcom/google/zxing/client/result/ParsedResult;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Zxing.Client.Result.ParsedResult __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResult> (JNIEnv.CallObjectMethod  (Handle, id_parse_Lcom_google_zxing_Result_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
