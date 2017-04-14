using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/ParsedResultType", DoNotGenerateAcw=true)]
	public sealed partial class ParsedResultType : global::Java.Lang.Enum {


		static IntPtr ADDRESSBOOK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='ADDRESSBOOK']"
		[Register ("ADDRESSBOOK")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType Addressbook {
			get {
				if (ADDRESSBOOK_jfieldId == IntPtr.Zero)
					ADDRESSBOOK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADDRESSBOOK", "Lcom/google/zxing/client/result/ParsedResultType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADDRESSBOOK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CALENDAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='CALENDAR']"
		[Register ("CALENDAR")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType Calendar {
			get {
				if (CALENDAR_jfieldId == IntPtr.Zero)
					CALENDAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CALENDAR", "Lcom/google/zxing/client/result/ParsedResultType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CALENDAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMAIL_ADDRESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='EMAIL_ADDRESS']"
		[Register ("EMAIL_ADDRESS")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType EmailAddress {
			get {
				if (EMAIL_ADDRESS_jfieldId == IntPtr.Zero)
					EMAIL_ADDRESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMAIL_ADDRESS", "Lcom/google/zxing/client/result/ParsedResultType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMAIL_ADDRESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr GEO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='GEO']"
		[Register ("GEO")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType Geo {
			get {
				if (GEO_jfieldId == IntPtr.Zero)
					GEO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GEO", "Lcom/google/zxing/client/result/ParsedResultType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GEO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISBN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='ISBN']"
		[Register ("ISBN")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType Isbn {
			get {
				if (ISBN_jfieldId == IntPtr.Zero)
					ISBN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISBN", "Lcom/google/zxing/client/result/ParsedResultType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISBN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PRODUCT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='PRODUCT']"
		[Register ("PRODUCT")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType Product {
			get {
				if (PRODUCT_jfieldId == IntPtr.Zero)
					PRODUCT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRODUCT", "Lcom/google/zxing/client/result/ParsedResultType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRODUCT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SMS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='SMS']"
		[Register ("SMS")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType Sms {
			get {
				if (SMS_jfieldId == IntPtr.Zero)
					SMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SMS", "Lcom/google/zxing/client/result/ParsedResultType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SMS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='TEL']"
		[Register ("TEL")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType Tel {
			get {
				if (TEL_jfieldId == IntPtr.Zero)
					TEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEL", "Lcom/google/zxing/client/result/ParsedResultType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='TEXT']"
		[Register ("TEXT")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType Text {
			get {
				if (TEXT_jfieldId == IntPtr.Zero)
					TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT", "Lcom/google/zxing/client/result/ParsedResultType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr URI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='URI']"
		[Register ("URI")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType Uri {
			get {
				if (URI_jfieldId == IntPtr.Zero)
					URI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "URI", "Lcom/google/zxing/client/result/ParsedResultType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, URI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='VIN']"
		[Register ("VIN")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType Vin {
			get {
				if (VIN_jfieldId == IntPtr.Zero)
					VIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIN", "Lcom/google/zxing/client/result/ParsedResultType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WIFI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/field[@name='WIFI']"
		[Register ("WIFI")]
		public static global::Com.Google.Zxing.Client.Result.ParsedResultType Wifi {
			get {
				if (WIFI_jfieldId == IntPtr.Zero)
					WIFI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIFI", "Lcom/google/zxing/client/result/ParsedResultType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIFI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/client/result/ParsedResultType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParsedResultType); }
		}

		internal ParsedResultType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/client/result/ParsedResultType;", "")]
		public static unsafe global::Com.Google.Zxing.Client.Result.ParsedResultType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/zxing/client/result/ParsedResultType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.Client.Result.ParsedResultType __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Client.Result.ParsedResultType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ParsedResultType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/client/result/ParsedResultType;", "")]
		public static unsafe global::Com.Google.Zxing.Client.Result.ParsedResultType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/zxing/client/result/ParsedResultType;");
			try {
				return (global::Com.Google.Zxing.Client.Result.ParsedResultType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Client.Result.ParsedResultType));
			} finally {
			}
		}

	}
}
