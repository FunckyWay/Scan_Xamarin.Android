using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='EmailAddressParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/EmailAddressParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class EmailAddressParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/client/result/EmailAddressParsedResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EmailAddressParsedResult); }
		}

		internal EmailAddressParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getBody;
		public unsafe string Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='EmailAddressParsedResult']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Ljava/lang/String;", "GetGetBodyHandler")]
			get {
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDisplayResult;
		public override unsafe string DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='EmailAddressParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
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

		static IntPtr id_getEmailAddress;
		[Obsolete (@"deprecated")]
		public unsafe string EmailAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='EmailAddressParsedResult']/method[@name='getEmailAddress' and count(parameter)=0]"
			[Register ("getEmailAddress", "()Ljava/lang/String;", "GetGetEmailAddressHandler")]
			get {
				if (id_getEmailAddress == IntPtr.Zero)
					id_getEmailAddress = JNIEnv.GetMethodID (class_ref, "getEmailAddress", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEmailAddress), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMailtoURI;
		[Obsolete (@"deprecated")]
		public unsafe string MailtoURI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='EmailAddressParsedResult']/method[@name='getMailtoURI' and count(parameter)=0]"
			[Register ("getMailtoURI", "()Ljava/lang/String;", "GetGetMailtoURIHandler")]
			get {
				if (id_getMailtoURI == IntPtr.Zero)
					id_getMailtoURI = JNIEnv.GetMethodID (class_ref, "getMailtoURI", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMailtoURI), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSubject;
		public unsafe string Subject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='EmailAddressParsedResult']/method[@name='getSubject' and count(parameter)=0]"
			[Register ("getSubject", "()Ljava/lang/String;", "GetGetSubjectHandler")]
			get {
				if (id_getSubject == IntPtr.Zero)
					id_getSubject = JNIEnv.GetMethodID (class_ref, "getSubject", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSubject), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getBCCs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='EmailAddressParsedResult']/method[@name='getBCCs' and count(parameter)=0]"
		[Register ("getBCCs", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetBCCs ()
		{
			if (id_getBCCs == IntPtr.Zero)
				id_getBCCs = JNIEnv.GetMethodID (class_ref, "getBCCs", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBCCs), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_getCCs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='EmailAddressParsedResult']/method[@name='getCCs' and count(parameter)=0]"
		[Register ("getCCs", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetCCs ()
		{
			if (id_getCCs == IntPtr.Zero)
				id_getCCs = JNIEnv.GetMethodID (class_ref, "getCCs", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getCCs), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_getTos;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='EmailAddressParsedResult']/method[@name='getTos' and count(parameter)=0]"
		[Register ("getTos", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetTos ()
		{
			if (id_getTos == IntPtr.Zero)
				id_getTos = JNIEnv.GetMethodID (class_ref, "getTos", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getTos), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
