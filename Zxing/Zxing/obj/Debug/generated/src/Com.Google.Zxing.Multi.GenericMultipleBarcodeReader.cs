using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Multi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.multi']/class[@name='GenericMultipleBarcodeReader']"
	[global::Android.Runtime.Register ("com/google/zxing/multi/GenericMultipleBarcodeReader", DoNotGenerateAcw=true)]
	public sealed partial class GenericMultipleBarcodeReader : global::Java.Lang.Object, global::Com.Google.Zxing.Multi.IMultipleBarcodeReader {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/multi/GenericMultipleBarcodeReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericMultipleBarcodeReader); }
		}

		internal GenericMultipleBarcodeReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_Reader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.multi']/class[@name='GenericMultipleBarcodeReader']/constructor[@name='GenericMultipleBarcodeReader' and count(parameter)=1 and parameter[1][@type='com.google.zxing.Reader']]"
		[Register (".ctor", "(Lcom/google/zxing/Reader;)V", "")]
		public unsafe GenericMultipleBarcodeReader (global::Com.Google.Zxing.IReader p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GenericMultipleBarcodeReader)) {
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

		static IntPtr id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi']/class[@name='GenericMultipleBarcodeReader']/method[@name='decodeMultiple' and count(parameter)=1 and parameter[1][@type='com.google.zxing.BinaryBitmap']]"
		[Register ("decodeMultiple", "(Lcom/google/zxing/BinaryBitmap;)[Lcom/google/zxing/Result;", "")]
		public unsafe global::Com.Google.Zxing.Result[] DecodeMultiple (global::Com.Google.Zxing.BinaryBitmap p0)
		{
			if (id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_ == IntPtr.Zero)
				id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_ = JNIEnv.GetMethodID (class_ref, "decodeMultiple", "(Lcom/google/zxing/BinaryBitmap;)[Lcom/google/zxing/Result;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Zxing.Result[] __ret = (global::Com.Google.Zxing.Result[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Result));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi']/class[@name='GenericMultipleBarcodeReader']/method[@name='decodeMultiple' and count(parameter)=2 and parameter[1][@type='com.google.zxing.BinaryBitmap'] and parameter[2][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decodeMultiple", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)[Lcom/google/zxing/Result;", "")]
		public unsafe global::Com.Google.Zxing.Result[] DecodeMultiple (global::Com.Google.Zxing.BinaryBitmap p0, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p1)
		{
			if (id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ == IntPtr.Zero)
				id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "decodeMultiple", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)[Lcom/google/zxing/Result;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Google.Zxing.Result[] __ret = (global::Com.Google.Zxing.Result[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Result));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
