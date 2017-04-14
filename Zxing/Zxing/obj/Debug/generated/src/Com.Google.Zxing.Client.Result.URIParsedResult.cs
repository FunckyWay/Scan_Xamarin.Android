using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='URIParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/URIParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class URIParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/client/result/URIParsedResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (URIParsedResult); }
		}

		internal URIParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='URIParsedResult']/constructor[@name='URIParsedResult' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe URIParsedResult (string p0, string p1)
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
				if (GetType () != typeof (URIParsedResult)) {
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='URIParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
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

		static IntPtr id_isPossiblyMaliciousURI;
		public unsafe bool IsPossiblyMaliciousURI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='URIParsedResult']/method[@name='isPossiblyMaliciousURI' and count(parameter)=0]"
			[Register ("isPossiblyMaliciousURI", "()Z", "GetIsPossiblyMaliciousURIHandler")]
			get {
				if (id_isPossiblyMaliciousURI == IntPtr.Zero)
					id_isPossiblyMaliciousURI = JNIEnv.GetMethodID (class_ref, "isPossiblyMaliciousURI", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isPossiblyMaliciousURI);
				} finally {
				}
			}
		}

		static IntPtr id_getTitle;
		public unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='URIParsedResult']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getURI;
		public unsafe string URI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='URIParsedResult']/method[@name='getURI' and count(parameter)=0]"
			[Register ("getURI", "()Ljava/lang/String;", "GetGetURIHandler")]
			get {
				if (id_getURI == IntPtr.Zero)
					id_getURI = JNIEnv.GetMethodID (class_ref, "getURI", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getURI), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
