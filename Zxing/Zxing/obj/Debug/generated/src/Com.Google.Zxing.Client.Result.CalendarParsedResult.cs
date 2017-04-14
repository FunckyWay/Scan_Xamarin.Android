using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/CalendarParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class CalendarParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/client/result/CalendarParsedResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalendarParsedResult); }
		}

		internal CalendarParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/constructor[@name='CalendarParsedResult' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String[]'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='double'] and parameter[10][@type='double']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;DD)V", "")]
		public unsafe CalendarParsedResult (string p0, string p1, string p2, string p3, string p4, string p5, string[] p6, string p7, double p8, double p9)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				if (GetType () != typeof (CalendarParsedResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;DD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;DD)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_DD == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;DD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_DD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_DD, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

		static IntPtr id_getDescription;
		public unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDisplayResult;
		public override unsafe string DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
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

		static IntPtr id_getEnd;
		public unsafe global::Java.Util.Date End {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getEnd' and count(parameter)=0]"
			[Register ("getEnd", "()Ljava/util/Date;", "GetGetEndHandler")]
			get {
				if (id_getEnd == IntPtr.Zero)
					id_getEnd = JNIEnv.GetMethodID (class_ref, "getEnd", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getEnd), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isEndAllDay;
		public unsafe bool IsEndAllDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='isEndAllDay' and count(parameter)=0]"
			[Register ("isEndAllDay", "()Z", "GetIsEndAllDayHandler")]
			get {
				if (id_isEndAllDay == IntPtr.Zero)
					id_isEndAllDay = JNIEnv.GetMethodID (class_ref, "isEndAllDay", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isEndAllDay);
				} finally {
				}
			}
		}

		static IntPtr id_isStartAllDay;
		public unsafe bool IsStartAllDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='isStartAllDay' and count(parameter)=0]"
			[Register ("isStartAllDay", "()Z", "GetIsStartAllDayHandler")]
			get {
				if (id_isStartAllDay == IntPtr.Zero)
					id_isStartAllDay = JNIEnv.GetMethodID (class_ref, "isStartAllDay", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isStartAllDay);
				} finally {
				}
			}
		}

		static IntPtr id_getLatitude;
		public unsafe double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				if (id_getLatitude == IntPtr.Zero)
					id_getLatitude = JNIEnv.GetMethodID (class_ref, "getLatitude", "()D");
				try {
					return JNIEnv.CallDoubleMethod  (Handle, id_getLatitude);
				} finally {
				}
			}
		}

		static IntPtr id_getLocation;
		public unsafe string Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Ljava/lang/String;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getLongitude;
		public unsafe double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler")]
			get {
				if (id_getLongitude == IntPtr.Zero)
					id_getLongitude = JNIEnv.GetMethodID (class_ref, "getLongitude", "()D");
				try {
					return JNIEnv.CallDoubleMethod  (Handle, id_getLongitude);
				} finally {
				}
			}
		}

		static IntPtr id_getOrganizer;
		public unsafe string Organizer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getOrganizer' and count(parameter)=0]"
			[Register ("getOrganizer", "()Ljava/lang/String;", "GetGetOrganizerHandler")]
			get {
				if (id_getOrganizer == IntPtr.Zero)
					id_getOrganizer = JNIEnv.GetMethodID (class_ref, "getOrganizer", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOrganizer), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getStart;
		public unsafe global::Java.Util.Date Start {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getStart' and count(parameter)=0]"
			[Register ("getStart", "()Ljava/util/Date;", "GetGetStartHandler")]
			get {
				if (id_getStart == IntPtr.Zero)
					id_getStart = JNIEnv.GetMethodID (class_ref, "getStart", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getStart), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSummary;
		public unsafe string Summary {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getSummary' and count(parameter)=0]"
			[Register ("getSummary", "()Ljava/lang/String;", "GetGetSummaryHandler")]
			get {
				if (id_getSummary == IntPtr.Zero)
					id_getSummary = JNIEnv.GetMethodID (class_ref, "getSummary", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSummary), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAttendees;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getAttendees' and count(parameter)=0]"
		[Register ("getAttendees", "()[Ljava/lang/String;", "")]
		public unsafe string[] GetAttendees ()
		{
			if (id_getAttendees == IntPtr.Zero)
				id_getAttendees = JNIEnv.GetMethodID (class_ref, "getAttendees", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAttendees), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
