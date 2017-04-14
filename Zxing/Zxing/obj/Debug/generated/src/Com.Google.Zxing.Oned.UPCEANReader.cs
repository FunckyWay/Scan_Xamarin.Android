using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Oned {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCEANReader']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/UPCEANReader", DoNotGenerateAcw=true)]
	public abstract partial class UPCEANReader : global::Com.Google.Zxing.Oned.OneDReader {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/oned/UPCEANReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UPCEANReader); }
		}

		protected UPCEANReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCEANReader']/constructor[@name='UPCEANReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe UPCEANReader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UPCEANReader)) {
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

		static Delegate cb_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_;
#pragma warning disable 0169
		static Delegate GetDecodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_Handler ()
		{
			if (cb_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_ == null)
				cb_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_DecodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_);
			return cb_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_;
		}

		static int n_DecodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Zxing.Oned.UPCEANReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.UPCEANReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.Common.BitArray p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Java.Lang.StringBuilder p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DecodeMiddle (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCEANReader']/method[@name='decodeMiddle' and count(parameter)=3 and parameter[1][@type='com.google.zxing.common.BitArray'] and parameter[2][@type='int[]'] and parameter[3][@type='java.lang.StringBuilder']]"
		[Register ("decodeMiddle", "(Lcom/google/zxing/common/BitArray;[ILjava/lang/StringBuilder;)I", "GetDecodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_Handler")]
		protected abstract int DecodeMiddle (global::Com.Google.Zxing.Common.BitArray p0, int[] p1, global::Java.Lang.StringBuilder p2);

		static Delegate cb_decodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetDecodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_Handler ()
		{
			if (cb_decodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_ == null)
				cb_decodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_);
			return cb_decodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_;
		}

		static IntPtr n_DecodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Google.Zxing.Oned.UPCEANReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.UPCEANReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.Common.BitArray p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (native_p1, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p3 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeRow (p0, p1, p2, p3));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCEANReader']/method[@name='decodeRow' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray'] and parameter[3][@type='int[]'] and parameter[4][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decodeRow", "(ILcom/google/zxing/common/BitArray;[ILjava/util/Map;)Lcom/google/zxing/Result;", "GetDecodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_Handler")]
		public virtual unsafe global::Com.Google.Zxing.Result DecodeRow (int p0, global::Com.Google.Zxing.Common.BitArray p1, int[] p2, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p3)
		{
			if (id_decodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_ == IntPtr.Zero)
				id_decodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "decodeRow", "(ILcom/google/zxing/common/BitArray;[ILjava/util/Map;)Lcom/google/zxing/Result;");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				global::Com.Google.Zxing.Result __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (JNIEnv.CallObjectMethod  (Handle, id_decodeRow_ILcom_google_zxing_common_BitArray_arrayILjava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeRow", "(ILcom/google/zxing/common/BitArray;[ILjava/util/Map;)Lcom/google/zxing/Result;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetDecodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_Handler ()
		{
			if (cb_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_ == null)
				cb_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_DecodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_);
			return cb_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_;
		}

		static IntPtr n_DecodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Zxing.Oned.UPCEANReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.UPCEANReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.Common.BitArray p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeRow (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCEANReader']/method[@name='decodeRow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray'] and parameter[3][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decodeRow", "(ILcom/google/zxing/common/BitArray;Ljava/util/Map;)Lcom/google/zxing/Result;", "GetDecodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_Handler")]
		public override unsafe global::Com.Google.Zxing.Result DecodeRow (int p0, global::Com.Google.Zxing.Common.BitArray p1, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p2)
		{
			if (id_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_ == IntPtr.Zero)
				id_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "decodeRow", "(ILcom/google/zxing/common/BitArray;Ljava/util/Map;)Lcom/google/zxing/Result;");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				global::Com.Google.Zxing.Result __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (JNIEnv.CallObjectMethod  (Handle, id_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeRow", "(ILcom/google/zxing/common/BitArray;Ljava/util/Map;)Lcom/google/zxing/Result;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/oned/UPCEANReader", DoNotGenerateAcw=true)]
	internal partial class UPCEANReaderInvoker : UPCEANReader {

		public UPCEANReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UPCEANReaderInvoker); }
		}

		static IntPtr id_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='UPCEANReader']/method[@name='decodeMiddle' and count(parameter)=3 and parameter[1][@type='com.google.zxing.common.BitArray'] and parameter[2][@type='int[]'] and parameter[3][@type='java.lang.StringBuilder']]"
		[Register ("decodeMiddle", "(Lcom/google/zxing/common/BitArray;[ILjava/lang/StringBuilder;)I", "GetDecodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_Handler")]
		protected override unsafe int DecodeMiddle (global::Com.Google.Zxing.Common.BitArray p0, int[] p1, global::Java.Lang.StringBuilder p2)
		{
			if (id_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_ == IntPtr.Zero)
				id_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_ = JNIEnv.GetMethodID (class_ref, "decodeMiddle", "(Lcom/google/zxing/common/BitArray;[ILjava/lang/StringBuilder;)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_decodeMiddle_Lcom_google_zxing_common_BitArray_arrayILjava_lang_StringBuilder_, __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}

}
