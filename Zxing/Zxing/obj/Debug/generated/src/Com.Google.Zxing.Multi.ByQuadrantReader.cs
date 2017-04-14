using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Multi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.multi']/class[@name='ByQuadrantReader']"
	[global::Android.Runtime.Register ("com/google/zxing/multi/ByQuadrantReader", DoNotGenerateAcw=true)]
	public sealed partial class ByQuadrantReader : global::Java.Lang.Object, global::Com.Google.Zxing.IReader {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/multi/ByQuadrantReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByQuadrantReader); }
		}

		internal ByQuadrantReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_Reader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.multi']/class[@name='ByQuadrantReader']/constructor[@name='ByQuadrantReader' and count(parameter)=1 and parameter[1][@type='com.google.zxing.Reader']]"
		[Register (".ctor", "(Lcom/google/zxing/Reader;)V", "")]
		public unsafe ByQuadrantReader (global::Com.Google.Zxing.IReader p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ByQuadrantReader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/Reader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/Reader;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_Reader_ == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_Reader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/Reader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_Reader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_Reader_, __args);
			} finally {
			}
		}

		static IntPtr id_decode_Lcom_google_zxing_BinaryBitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi']/class[@name='ByQuadrantReader']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.google.zxing.BinaryBitmap']]"
		[Register ("decode", "(Lcom/google/zxing/BinaryBitmap;)Lcom/google/zxing/Result;", "")]
		public unsafe global::Com.Google.Zxing.Result Decode (global::Com.Google.Zxing.BinaryBitmap p0)
		{
			if (id_decode_Lcom_google_zxing_BinaryBitmap_ == IntPtr.Zero)
				id_decode_Lcom_google_zxing_BinaryBitmap_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/google/zxing/BinaryBitmap;)Lcom/google/zxing/Result;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Zxing.Result __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (JNIEnv.CallObjectMethod  (Handle, id_decode_Lcom_google_zxing_BinaryBitmap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi']/class[@name='ByQuadrantReader']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='com.google.zxing.BinaryBitmap'] and parameter[2][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decode", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)Lcom/google/zxing/Result;", "")]
		public unsafe global::Com.Google.Zxing.Result Decode (global::Com.Google.Zxing.BinaryBitmap p0, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p1)
		{
			if (id_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ == IntPtr.Zero)
				id_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)Lcom/google/zxing/Result;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Google.Zxing.Result __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (JNIEnv.CallObjectMethod  (Handle, id_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi']/class[@name='ByQuadrantReader']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_reset);
			} finally {
			}
		}

	}
}
