using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='StringUtils']"
	[global::Android.Runtime.Register ("com/google/zxing/common/StringUtils", DoNotGenerateAcw=true)]
	public sealed partial class StringUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='StringUtils']/field[@name='GB2312']"
		[Register ("GB2312")]
		public const string Gb2312 = (string) "GB2312";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.common']/class[@name='StringUtils']/field[@name='SHIFT_JIS']"
		[Register ("SHIFT_JIS")]
		public const string ShiftJis = (string) "SJIS";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/StringUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringUtils); }
		}

		internal StringUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_guessEncoding_arrayBLjava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='StringUtils']/method[@name='guessEncoding' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("guessEncoding", "([BLjava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string GuessEncoding (byte[] p0, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p1)
		{
			if (id_guessEncoding_arrayBLjava_util_Map_ == IntPtr.Zero)
				id_guessEncoding_arrayBLjava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "guessEncoding", "([BLjava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_guessEncoding_arrayBLjava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
