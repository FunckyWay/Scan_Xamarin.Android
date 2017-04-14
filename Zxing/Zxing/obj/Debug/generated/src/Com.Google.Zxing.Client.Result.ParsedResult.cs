using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/ParsedResult", DoNotGenerateAcw=true)]
	public abstract partial class ParsedResult : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/client/result/ParsedResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParsedResult); }
		}

		protected ParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_client_result_ParsedResultType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResult']/constructor[@name='ParsedResult' and count(parameter)=1 and parameter[1][@type='com.google.zxing.client.result.ParsedResultType']]"
		[Register (".ctor", "(Lcom/google/zxing/client/result/ParsedResultType;)V", "")]
		protected unsafe ParsedResult (global::Com.Google.Zxing.Client.Result.ParsedResultType p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ParsedResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/client/result/ParsedResultType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/client/result/ParsedResultType;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_client_result_ParsedResultType_ == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_client_result_ParsedResultType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/client/result/ParsedResultType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_client_result_ParsedResultType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_client_result_ParsedResultType_, __args);
			} finally {
			}
		}

		static Delegate cb_getDisplayResult;
#pragma warning disable 0169
		static Delegate GetGetDisplayResultHandler ()
		{
			if (cb_getDisplayResult == null)
				cb_getDisplayResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayResult);
			return cb_getDisplayResult;
		}

		static IntPtr n_GetDisplayResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.Client.Result.ParsedResult __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayResult);
		}
#pragma warning restore 0169

		public abstract string DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
			[Register ("getDisplayResult", "()Ljava/lang/String;", "GetGetDisplayResultHandler")] get;
		}

		static IntPtr id_getType;
		public unsafe global::Com.Google.Zxing.Client.Result.ParsedResultType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResult']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/google/zxing/client/result/ParsedResultType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/google/zxing/client/result/ParsedResultType;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_maybeAppend_Ljava_lang_String_Ljava_lang_StringBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResult']/method[@name='maybeAppend' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.StringBuilder']]"
		[Register ("maybeAppend", "(Ljava/lang/String;Ljava/lang/StringBuilder;)V", "")]
		public static unsafe void MaybeAppend (string p0, global::Java.Lang.StringBuilder p1)
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResult']/method[@name='maybeAppend' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.StringBuilder']]"
		[Register ("maybeAppend", "([Ljava/lang/String;Ljava/lang/StringBuilder;)V", "")]
		public static unsafe void MaybeAppend (string[] p0, global::Java.Lang.StringBuilder p1)
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

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResult']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/client/result/ParsedResult", DoNotGenerateAcw=true)]
	internal partial class ParsedResultInvoker : ParsedResult {

		public ParsedResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParsedResultInvoker); }
		}

		static IntPtr id_getDisplayResult;
		public override unsafe string DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
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

	}

}
