using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']"
	[global::Android.Runtime.Register ("com/google/zxing/common/CharacterSetECI", DoNotGenerateAcw=true)]
	public sealed partial class CharacterSetECI : global::Java.Lang.Enum {


		static IntPtr ASCII_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ASCII']"
		[Register ("ASCII")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Ascii {
			get {
				if (ASCII_jfieldId == IntPtr.Zero)
					ASCII_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASCII", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASCII_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Big5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='Big5']"
		[Register ("Big5")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Big5 {
			get {
				if (Big5_jfieldId == IntPtr.Zero)
					Big5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Big5", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Big5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Cp1250_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='Cp1250']"
		[Register ("Cp1250")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Cp1250 {
			get {
				if (Cp1250_jfieldId == IntPtr.Zero)
					Cp1250_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Cp1250", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Cp1250_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Cp1251_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='Cp1251']"
		[Register ("Cp1251")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Cp1251 {
			get {
				if (Cp1251_jfieldId == IntPtr.Zero)
					Cp1251_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Cp1251", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Cp1251_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Cp1252_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='Cp1252']"
		[Register ("Cp1252")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Cp1252 {
			get {
				if (Cp1252_jfieldId == IntPtr.Zero)
					Cp1252_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Cp1252", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Cp1252_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Cp1256_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='Cp1256']"
		[Register ("Cp1256")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Cp1256 {
			get {
				if (Cp1256_jfieldId == IntPtr.Zero)
					Cp1256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Cp1256", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Cp1256_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Cp437_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='Cp437']"
		[Register ("Cp437")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Cp437 {
			get {
				if (Cp437_jfieldId == IntPtr.Zero)
					Cp437_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Cp437", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Cp437_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EUC_KR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='EUC_KR']"
		[Register ("EUC_KR")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI EucKr {
			get {
				if (EUC_KR_jfieldId == IntPtr.Zero)
					EUC_KR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EUC_KR", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EUC_KR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr GB18030_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='GB18030']"
		[Register ("GB18030")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Gb18030 {
			get {
				if (GB18030_jfieldId == IntPtr.Zero)
					GB18030_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GB18030", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GB18030_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_1']"
		[Register ("ISO8859_1")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso88591 {
			get {
				if (ISO8859_1_jfieldId == IntPtr.Zero)
					ISO8859_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_1", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_10_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_10']"
		[Register ("ISO8859_10")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso885910 {
			get {
				if (ISO8859_10_jfieldId == IntPtr.Zero)
					ISO8859_10_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_10", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_10_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_11_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_11']"
		[Register ("ISO8859_11")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso885911 {
			get {
				if (ISO8859_11_jfieldId == IntPtr.Zero)
					ISO8859_11_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_11", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_11_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_13_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_13']"
		[Register ("ISO8859_13")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso885913 {
			get {
				if (ISO8859_13_jfieldId == IntPtr.Zero)
					ISO8859_13_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_13", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_13_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_14_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_14']"
		[Register ("ISO8859_14")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso885914 {
			get {
				if (ISO8859_14_jfieldId == IntPtr.Zero)
					ISO8859_14_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_14", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_14_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_15_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_15']"
		[Register ("ISO8859_15")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso885915 {
			get {
				if (ISO8859_15_jfieldId == IntPtr.Zero)
					ISO8859_15_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_15", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_15_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_16_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_16']"
		[Register ("ISO8859_16")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso885916 {
			get {
				if (ISO8859_16_jfieldId == IntPtr.Zero)
					ISO8859_16_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_16", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_16_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_2']"
		[Register ("ISO8859_2")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso88592 {
			get {
				if (ISO8859_2_jfieldId == IntPtr.Zero)
					ISO8859_2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_2", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_3']"
		[Register ("ISO8859_3")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso88593 {
			get {
				if (ISO8859_3_jfieldId == IntPtr.Zero)
					ISO8859_3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_3", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_3_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_4_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_4']"
		[Register ("ISO8859_4")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso88594 {
			get {
				if (ISO8859_4_jfieldId == IntPtr.Zero)
					ISO8859_4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_4", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_4_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_5']"
		[Register ("ISO8859_5")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso88595 {
			get {
				if (ISO8859_5_jfieldId == IntPtr.Zero)
					ISO8859_5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_5", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_6_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_6']"
		[Register ("ISO8859_6")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso88596 {
			get {
				if (ISO8859_6_jfieldId == IntPtr.Zero)
					ISO8859_6_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_6", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_6_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_7_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_7']"
		[Register ("ISO8859_7")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso88597 {
			get {
				if (ISO8859_7_jfieldId == IntPtr.Zero)
					ISO8859_7_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_7", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_7_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_8']"
		[Register ("ISO8859_8")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso88598 {
			get {
				if (ISO8859_8_jfieldId == IntPtr.Zero)
					ISO8859_8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_8", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_8_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO8859_9_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='ISO8859_9']"
		[Register ("ISO8859_9")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Iso88599 {
			get {
				if (ISO8859_9_jfieldId == IntPtr.Zero)
					ISO8859_9_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO8859_9", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO8859_9_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SJIS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='SJIS']"
		[Register ("SJIS")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Sjis {
			get {
				if (SJIS_jfieldId == IntPtr.Zero)
					SJIS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SJIS", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SJIS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UTF8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='UTF8']"
		[Register ("UTF8")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI Utf8 {
			get {
				if (UTF8_jfieldId == IntPtr.Zero)
					UTF8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UTF8", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UTF8_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UnicodeBigUnmarked_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/field[@name='UnicodeBigUnmarked']"
		[Register ("UnicodeBigUnmarked")]
		public static global::Com.Google.Zxing.Common.CharacterSetECI UnicodeBigUnmarked {
			get {
				if (UnicodeBigUnmarked_jfieldId == IntPtr.Zero)
					UnicodeBigUnmarked_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UnicodeBigUnmarked", "Lcom/google/zxing/common/CharacterSetECI;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UnicodeBigUnmarked_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/CharacterSetECI", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharacterSetECI); }
		}

		internal CharacterSetECI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getValue);
				} finally {
				}
			}
		}

		static IntPtr id_getCharacterSetECIByName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/method[@name='getCharacterSetECIByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCharacterSetECIByName", "(Ljava/lang/String;)Lcom/google/zxing/common/CharacterSetECI;", "")]
		public static unsafe global::Com.Google.Zxing.Common.CharacterSetECI GetCharacterSetECIByName (string p0)
		{
			if (id_getCharacterSetECIByName_Ljava_lang_String_ == IntPtr.Zero)
				id_getCharacterSetECIByName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCharacterSetECIByName", "(Ljava/lang/String;)Lcom/google/zxing/common/CharacterSetECI;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.Common.CharacterSetECI __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCharacterSetECIByName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getCharacterSetECIByValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/method[@name='getCharacterSetECIByValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCharacterSetECIByValue", "(I)Lcom/google/zxing/common/CharacterSetECI;", "")]
		public static unsafe global::Com.Google.Zxing.Common.CharacterSetECI GetCharacterSetECIByValue (int p0)
		{
			if (id_getCharacterSetECIByValue_I == IntPtr.Zero)
				id_getCharacterSetECIByValue_I = JNIEnv.GetStaticMethodID (class_ref, "getCharacterSetECIByValue", "(I)Lcom/google/zxing/common/CharacterSetECI;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCharacterSetECIByValue_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/zxing/common/CharacterSetECI;", "")]
		public static unsafe global::Com.Google.Zxing.Common.CharacterSetECI ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/zxing/common/CharacterSetECI;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Zxing.Common.CharacterSetECI __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.CharacterSetECI> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='CharacterSetECI']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/zxing/common/CharacterSetECI;", "")]
		public static unsafe global::Com.Google.Zxing.Common.CharacterSetECI[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/zxing/common/CharacterSetECI;");
			try {
				return (global::Com.Google.Zxing.Common.CharacterSetECI[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Common.CharacterSetECI));
			} finally {
			}
		}

	}
}
