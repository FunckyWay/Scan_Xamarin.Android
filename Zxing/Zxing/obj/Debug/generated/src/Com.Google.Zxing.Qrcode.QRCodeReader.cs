using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Qrcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode']/class[@name='QRCodeReader']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/QRCodeReader", DoNotGenerateAcw=true)]
	public partial class QRCodeReader : global::Java.Lang.Object, global::Com.Google.Zxing.IReader {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/qrcode/QRCodeReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QRCodeReader); }
		}

		protected QRCodeReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.qrcode']/class[@name='QRCodeReader']/constructor[@name='QRCodeReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QRCodeReader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (QRCodeReader)) {
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

		static IntPtr id_getDecoder;
		protected unsafe global::Com.Google.Zxing.Qrcode.Decoder.Decoder Decoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode']/class[@name='QRCodeReader']/method[@name='getDecoder' and count(parameter)=0]"
			[Register ("getDecoder", "()Lcom/google/zxing/qrcode/decoder/Decoder;", "GetGetDecoderHandler")]
			get {
				if (id_getDecoder == IntPtr.Zero)
					id_getDecoder = JNIEnv.GetMethodID (class_ref, "getDecoder", "()Lcom/google/zxing/qrcode/decoder/Decoder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Decoder> (JNIEnv.CallObjectMethod  (Handle, id_getDecoder), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_decode_Lcom_google_zxing_BinaryBitmap_;
#pragma warning disable 0169
		static Delegate GetDecode_Lcom_google_zxing_BinaryBitmap_Handler ()
		{
			if (cb_decode_Lcom_google_zxing_BinaryBitmap_ == null)
				cb_decode_Lcom_google_zxing_BinaryBitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Lcom_google_zxing_BinaryBitmap_);
			return cb_decode_Lcom_google_zxing_BinaryBitmap_;
		}

		static IntPtr n_Decode_Lcom_google_zxing_BinaryBitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Zxing.Qrcode.QRCodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.QRCodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.BinaryBitmap p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Lcom_google_zxing_BinaryBitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode']/class[@name='QRCodeReader']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.google.zxing.BinaryBitmap']]"
		[Register ("decode", "(Lcom/google/zxing/BinaryBitmap;)Lcom/google/zxing/Result;", "GetDecode_Lcom_google_zxing_BinaryBitmap_Handler")]
		public virtual unsafe global::Com.Google.Zxing.Result Decode (global::Com.Google.Zxing.BinaryBitmap p0)
		{
			if (id_decode_Lcom_google_zxing_BinaryBitmap_ == IntPtr.Zero)
				id_decode_Lcom_google_zxing_BinaryBitmap_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/google/zxing/BinaryBitmap;)Lcom/google/zxing/Result;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Google.Zxing.Result __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (JNIEnv.CallObjectMethod  (Handle, id_decode_Lcom_google_zxing_BinaryBitmap_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Lcom/google/zxing/BinaryBitmap;)Lcom/google/zxing/Result;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode']/class[@name='QRCodeReader']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='com.google.zxing.BinaryBitmap'] and parameter[2][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
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

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.Qrcode.QRCodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.QRCodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode']/class[@name='QRCodeReader']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

	}
}
