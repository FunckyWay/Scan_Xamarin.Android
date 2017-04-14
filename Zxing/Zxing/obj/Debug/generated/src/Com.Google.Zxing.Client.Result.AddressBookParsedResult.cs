using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/AddressBookParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class AddressBookParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/client/result/AddressBookParsedResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AddressBookParsedResult); }
		}

		internal AddressBookParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/constructor[@name='AddressBookParsedResult' and count(parameter)=7 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='java.lang.String[]'] and parameter[7][@type='java.lang.String[]']]"
		[Register (".ctor", "([Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public unsafe AddressBookParsedResult (string[] p0, string[] p1, string[] p2, string[] p3, string[] p4, string[] p5, string[] p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				if (GetType () != typeof (AddressBookParsedResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
					id_ctor_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
			}
		}

		static IntPtr id_getBirthday;
		public unsafe string Birthday {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getBirthday' and count(parameter)=0]"
			[Register ("getBirthday", "()Ljava/lang/String;", "GetGetBirthdayHandler")]
			get {
				if (id_getBirthday == IntPtr.Zero)
					id_getBirthday = JNIEnv.GetMethodID (class_ref, "getBirthday", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBirthday), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDisplayResult;
		public override unsafe string DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
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

		static IntPtr id_getInstantMessenger;
		public unsafe string InstantMessenger {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getInstantMessenger' and count(parameter)=0]"
			[Register ("getInstantMessenger", "()Ljava/lang/String;", "GetGetInstantMessengerHandler")]
			get {
				if (id_getInstantMessenger == IntPtr.Zero)
					id_getInstantMessenger = JNIEnv.GetMethodID (class_ref, "getInstantMessenger", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInstantMessenger), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getNote;
		public unsafe string Note {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getNote' and count(parameter)=0]"
			[Register ("getNote", "()Ljava/lang/String;", "GetGetNoteHandler")]
			get {
				if (id_getNote == IntPtr.Zero)
					id_getNote = JNIEnv.GetMethodID (class_ref, "getNote", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNote), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getOrg;
		public unsafe string Org {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getOrg' and count(parameter)=0]"
			[Register ("getOrg", "()Ljava/lang/String;", "GetGetOrgHandler")]
			get {
				if (id_getOrg == IntPtr.Zero)
					id_getOrg = JNIEnv.GetMethodID (class_ref, "getOrg", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOrg), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPronunciation;
		public unsafe string Pronunciation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getPronunciation' and count(parameter)=0]"
			[Register ("getPronunciation", "()Ljava/lang/String;", "GetGetPronunciationHandler")]
			get {
				if (id_getPronunciation == IntPtr.Zero)
					id_getPronunciation = JNIEnv.GetMethodID (class_ref, "getPronunciation", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPronunciation), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTitle;
		public unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getTitle' and count(parameter)=0]"
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

		static IntPtr id_getAddressTypes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getAddressTypes' and count(parameter)=0]"
		[Register ("getAddressTypes", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetAddressTypes ()
		{
			if (id_getAddressTypes == IntPtr.Zero)
				id_getAddressTypes = JNIEnv.GetMethodID (class_ref, "getAddressTypes", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAddressTypes), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_getAddresses;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getAddresses' and count(parameter)=0]"
		[Register ("getAddresses", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetAddresses ()
		{
			if (id_getAddresses == IntPtr.Zero)
				id_getAddresses = JNIEnv.GetMethodID (class_ref, "getAddresses", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAddresses), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_getEmailTypes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getEmailTypes' and count(parameter)=0]"
		[Register ("getEmailTypes", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetEmailTypes ()
		{
			if (id_getEmailTypes == IntPtr.Zero)
				id_getEmailTypes = JNIEnv.GetMethodID (class_ref, "getEmailTypes", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getEmailTypes), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_getEmails;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getEmails' and count(parameter)=0]"
		[Register ("getEmails", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetEmails ()
		{
			if (id_getEmails == IntPtr.Zero)
				id_getEmails = JNIEnv.GetMethodID (class_ref, "getEmails", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getEmails), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_getGeo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getGeo' and count(parameter)=0]"
		[Register ("getGeo", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetGeo ()
		{
			if (id_getGeo == IntPtr.Zero)
				id_getGeo = JNIEnv.GetMethodID (class_ref, "getGeo", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getGeo), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_getNames;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getNames' and count(parameter)=0]"
		[Register ("getNames", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetNames ()
		{
			if (id_getNames == IntPtr.Zero)
				id_getNames = JNIEnv.GetMethodID (class_ref, "getNames", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getNames), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_getNicknames;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getNicknames' and count(parameter)=0]"
		[Register ("getNicknames", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetNicknames ()
		{
			if (id_getNicknames == IntPtr.Zero)
				id_getNicknames = JNIEnv.GetMethodID (class_ref, "getNicknames", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getNicknames), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_getPhoneNumbers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getPhoneNumbers' and count(parameter)=0]"
		[Register ("getPhoneNumbers", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetPhoneNumbers ()
		{
			if (id_getPhoneNumbers == IntPtr.Zero)
				id_getPhoneNumbers = JNIEnv.GetMethodID (class_ref, "getPhoneNumbers", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPhoneNumbers), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_getPhoneTypes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getPhoneTypes' and count(parameter)=0]"
		[Register ("getPhoneTypes", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetPhoneTypes ()
		{
			if (id_getPhoneTypes == IntPtr.Zero)
				id_getPhoneTypes = JNIEnv.GetMethodID (class_ref, "getPhoneTypes", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPhoneTypes), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_getURLs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getURLs' and count(parameter)=0]"
		[Register ("getURLs", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetURLs ()
		{
			if (id_getURLs == IntPtr.Zero)
				id_getURLs = JNIEnv.GetMethodID (class_ref, "getURLs", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getURLs), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
