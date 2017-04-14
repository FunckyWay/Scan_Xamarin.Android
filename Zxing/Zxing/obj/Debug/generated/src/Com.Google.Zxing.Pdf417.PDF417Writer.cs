using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Pdf417 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Writer']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/PDF417Writer", DoNotGenerateAcw=true)]
	public sealed partial class PDF417Writer : global::Java.Lang.Object, global::Com.Google.Zxing.IWriter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/pdf417/PDF417Writer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDF417Writer); }
		}

		internal PDF417Writer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Writer']/constructor[@name='PDF417Writer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PDF417Writer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PDF417Writer)) {
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

		static IntPtr id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Writer']/method[@name='encode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.BarcodeFormat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;II)Lcom/google/zxing/common/BitMatrix;", "")]
		public unsafe global::Com.Google.Zxing.Common.BitMatrix Encode (string p0, global::Com.Google.Zxing.BarcodeFormat p1, int p2, int p3)
		{
			if (id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II == IntPtr.Zero)
				id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;II)Lcom/google/zxing/common/BitMatrix;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Com.Google.Zxing.Common.BitMatrix __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod  (Handle, id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417Writer']/method[@name='encode' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.BarcodeFormat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.util.Map&lt;com.google.zxing.EncodeHintType, ?&gt;']]"
		[Register ("encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;IILjava/util/Map;)Lcom/google/zxing/common/BitMatrix;", "")]
		public unsafe global::Com.Google.Zxing.Common.BitMatrix Encode (string p0, global::Com.Google.Zxing.BarcodeFormat p1, int p2, int p3, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.EncodeHintType, object> p4)
		{
			if (id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;IILjava/util/Map;)Lcom/google/zxing/common/BitMatrix;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.EncodeHintType, object>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				global::Com.Google.Zxing.Common.BitMatrix __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod  (Handle, id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}
}
