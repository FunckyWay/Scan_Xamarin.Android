using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Multi.Qrcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.multi.qrcode']/class[@name='QRCodeMultiReader']"
	[global::Android.Runtime.Register ("com/google/zxing/multi/qrcode/QRCodeMultiReader", DoNotGenerateAcw=true)]
	public sealed partial class QRCodeMultiReader : global::Com.Google.Zxing.Qrcode.QRCodeReader, global::Com.Google.Zxing.Multi.IMultipleBarcodeReader {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.multi.qrcode']/class[@name='QRCodeMultiReader.SAComparator']"
		[global::Android.Runtime.Register ("com/google/zxing/multi/qrcode/QRCodeMultiReader$SAComparator", DoNotGenerateAcw=true)]
		public sealed partial class SAComparator : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Util.IComparator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/zxing/multi/qrcode/QRCodeMultiReader$SAComparator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SAComparator); }
			}

			internal SAComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_compare_Lcom_google_zxing_Result_Lcom_google_zxing_Result_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi.qrcode']/class[@name='QRCodeMultiReader.SAComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='com.google.zxing.Result'] and parameter[2][@type='com.google.zxing.Result']]"
			[Register ("compare", "(Lcom/google/zxing/Result;Lcom/google/zxing/Result;)I", "")]
			public unsafe int Compare (global::Com.Google.Zxing.Result p0, global::Com.Google.Zxing.Result p1)
			{
				if (id_compare_Lcom_google_zxing_Result_Lcom_google_zxing_Result_ == IntPtr.Zero)
					id_compare_Lcom_google_zxing_Result_Lcom_google_zxing_Result_ = JNIEnv.GetMethodID (class_ref, "compare", "(Lcom/google/zxing/Result;Lcom/google/zxing/Result;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					int __ret = JNIEnv.CallIntMethod  (Handle, id_compare_Lcom_google_zxing_Result_Lcom_google_zxing_Result_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_compare_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi.qrcode']/class[@name='QRCodeMultiReader.SAComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
			[Register ("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", "")]
			public unsafe int Compare (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			{
				if (id_compare_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					int __ret = JNIEnv.CallIntMethod  (Handle, id_compare_Ljava_lang_Object_Ljava_lang_Object_, __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/multi/qrcode/QRCodeMultiReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QRCodeMultiReader); }
		}

		internal QRCodeMultiReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.multi.qrcode']/class[@name='QRCodeMultiReader']/constructor[@name='QRCodeMultiReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QRCodeMultiReader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (QRCodeMultiReader)) {
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

		static IntPtr id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi.qrcode']/class[@name='QRCodeMultiReader']/method[@name='decodeMultiple' and count(parameter)=1 and parameter[1][@type='com.google.zxing.BinaryBitmap']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi.qrcode']/class[@name='QRCodeMultiReader']/method[@name='decodeMultiple' and count(parameter)=2 and parameter[1][@type='com.google.zxing.BinaryBitmap'] and parameter[2][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
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
