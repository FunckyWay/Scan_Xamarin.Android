using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Multi {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.zxing.multi']/interface[@name='MultipleBarcodeReader']"
	[Register ("com/google/zxing/multi/MultipleBarcodeReader", "", "Com.Google.Zxing.Multi.IMultipleBarcodeReaderInvoker")]
	public partial interface IMultipleBarcodeReader : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi']/interface[@name='MultipleBarcodeReader']/method[@name='decodeMultiple' and count(parameter)=1 and parameter[1][@type='com.google.zxing.BinaryBitmap']]"
		[Register ("decodeMultiple", "(Lcom/google/zxing/BinaryBitmap;)[Lcom/google/zxing/Result;", "GetDecodeMultiple_Lcom_google_zxing_BinaryBitmap_Handler:Com.Google.Zxing.Multi.IMultipleBarcodeReaderInvoker, Zxing")]
		global::Com.Google.Zxing.Result[] DecodeMultiple (global::Com.Google.Zxing.BinaryBitmap p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.multi']/interface[@name='MultipleBarcodeReader']/method[@name='decodeMultiple' and count(parameter)=2 and parameter[1][@type='com.google.zxing.BinaryBitmap'] and parameter[2][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decodeMultiple", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)[Lcom/google/zxing/Result;", "GetDecodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_Handler:Com.Google.Zxing.Multi.IMultipleBarcodeReaderInvoker, Zxing")]
		global::Com.Google.Zxing.Result[] DecodeMultiple (global::Com.Google.Zxing.BinaryBitmap p0, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p1);

	}

	[global::Android.Runtime.Register ("com/google/zxing/multi/MultipleBarcodeReader", DoNotGenerateAcw=true)]
	internal class IMultipleBarcodeReaderInvoker : global::Java.Lang.Object, IMultipleBarcodeReader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/zxing/multi/MultipleBarcodeReader");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMultipleBarcodeReaderInvoker); }
		}

		IntPtr class_ref;

		public static IMultipleBarcodeReader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMultipleBarcodeReader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.zxing.multi.MultipleBarcodeReader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMultipleBarcodeReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_decodeMultiple_Lcom_google_zxing_BinaryBitmap_;
#pragma warning disable 0169
		static Delegate GetDecodeMultiple_Lcom_google_zxing_BinaryBitmap_Handler ()
		{
			if (cb_decodeMultiple_Lcom_google_zxing_BinaryBitmap_ == null)
				cb_decodeMultiple_Lcom_google_zxing_BinaryBitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeMultiple_Lcom_google_zxing_BinaryBitmap_);
			return cb_decodeMultiple_Lcom_google_zxing_BinaryBitmap_;
		}

		static IntPtr n_DecodeMultiple_Lcom_google_zxing_BinaryBitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Zxing.Multi.IMultipleBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Multi.IMultipleBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.BinaryBitmap p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.DecodeMultiple (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_;
		public unsafe global::Com.Google.Zxing.Result[] DecodeMultiple (global::Com.Google.Zxing.BinaryBitmap p0)
		{
			if (id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_ == IntPtr.Zero)
				id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_ = JNIEnv.GetMethodID (class_ref, "decodeMultiple", "(Lcom/google/zxing/BinaryBitmap;)[Lcom/google/zxing/Result;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Google.Zxing.Result[] __ret = (global::Com.Google.Zxing.Result[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Result));
			return __ret;
		}

		static Delegate cb_decodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetDecodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_Handler ()
		{
			if (cb_decodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ == null)
				cb_decodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_);
			return cb_decodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_;
		}

		static IntPtr n_DecodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Zxing.Multi.IMultipleBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Multi.IMultipleBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.BinaryBitmap p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.DecodeMultiple (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_;
		public unsafe global::Com.Google.Zxing.Result[] DecodeMultiple (global::Com.Google.Zxing.BinaryBitmap p0, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p1)
		{
			if (id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ == IntPtr.Zero)
				id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "decodeMultiple", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)[Lcom/google/zxing/Result;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			global::Com.Google.Zxing.Result[] __ret = (global::Com.Google.Zxing.Result[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_decodeMultiple_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Result));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
