using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.zxing']/interface[@name='Reader']"
	[Register ("com/google/zxing/Reader", "", "Com.Google.Zxing.IReaderInvoker")]
	public partial interface IReader : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/interface[@name='Reader']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.google.zxing.BinaryBitmap']]"
		[Register ("decode", "(Lcom/google/zxing/BinaryBitmap;)Lcom/google/zxing/Result;", "GetDecode_Lcom_google_zxing_BinaryBitmap_Handler:Com.Google.Zxing.IReaderInvoker, Zxing")]
		global::Com.Google.Zxing.Result Decode (global::Com.Google.Zxing.BinaryBitmap p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/interface[@name='Reader']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='com.google.zxing.BinaryBitmap'] and parameter[2][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decode", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)Lcom/google/zxing/Result;", "GetDecode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_Handler:Com.Google.Zxing.IReaderInvoker, Zxing")]
		global::Com.Google.Zxing.Result Decode (global::Com.Google.Zxing.BinaryBitmap p0, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/interface[@name='Reader']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Com.Google.Zxing.IReaderInvoker, Zxing")]
		void Reset ();

	}

	[global::Android.Runtime.Register ("com/google/zxing/Reader", DoNotGenerateAcw=true)]
	internal class IReaderInvoker : global::Java.Lang.Object, IReader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/zxing/Reader");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IReaderInvoker); }
		}

		IntPtr class_ref;

		public static IReader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.zxing.Reader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Google.Zxing.IReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.IReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.BinaryBitmap p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decode_Lcom_google_zxing_BinaryBitmap_;
		public unsafe global::Com.Google.Zxing.Result Decode (global::Com.Google.Zxing.BinaryBitmap p0)
		{
			if (id_decode_Lcom_google_zxing_BinaryBitmap_ == IntPtr.Zero)
				id_decode_Lcom_google_zxing_BinaryBitmap_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/google/zxing/BinaryBitmap;)Lcom/google/zxing/Result;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Google.Zxing.Result __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (JNIEnv.CallObjectMethod (Handle, id_decode_Lcom_google_zxing_BinaryBitmap_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetDecode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_Handler ()
		{
			if (cb_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ == null)
				cb_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_);
			return cb_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_;
		}

		static IntPtr n_Decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Zxing.IReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.IReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.BinaryBitmap p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_;
		public unsafe global::Com.Google.Zxing.Result Decode (global::Com.Google.Zxing.BinaryBitmap p0, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p1)
		{
			if (id_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ == IntPtr.Zero)
				id_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)Lcom/google/zxing/Result;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			global::Com.Google.Zxing.Result __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (JNIEnv.CallObjectMethod (Handle, id_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
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
			global::Com.Google.Zxing.IReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.IReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		IntPtr id_reset;
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			JNIEnv.CallVoidMethod (Handle, id_reset);
		}

	}

}
