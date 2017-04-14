using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Oned {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/OneDReader", DoNotGenerateAcw=true)]
	public abstract partial class OneDReader : global::Java.Lang.Object, global::Com.Google.Zxing.IReader {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/oned/OneDReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OneDReader); }
		}

		protected OneDReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/constructor[@name='OneDReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OneDReader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OneDReader)) {
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
			global::Com.Google.Zxing.Oned.OneDReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.BinaryBitmap p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Lcom_google_zxing_BinaryBitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='com.google.zxing.BinaryBitmap']]"
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
			global::Com.Google.Zxing.Oned.OneDReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.BinaryBitmap p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='com.google.zxing.BinaryBitmap'] and parameter[2][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decode", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)Lcom/google/zxing/Result;", "GetDecode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Google.Zxing.Result Decode (global::Com.Google.Zxing.BinaryBitmap p0, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p1)
		{
			if (id_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ == IntPtr.Zero)
				id_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)Lcom/google/zxing/Result;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Google.Zxing.Result __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (JNIEnv.CallObjectMethod  (Handle, id_decode_Lcom_google_zxing_BinaryBitmap_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Lcom/google/zxing/BinaryBitmap;Ljava/util/Map;)Lcom/google/zxing/Result;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Google.Zxing.Oned.OneDReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.Common.BitArray p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeRow (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='decodeRow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray'] and parameter[3][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decodeRow", "(ILcom/google/zxing/common/BitArray;Ljava/util/Map;)Lcom/google/zxing/Result;", "GetDecodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_Handler")]
		public abstract global::Com.Google.Zxing.Result DecodeRow (int p0, global::Com.Google.Zxing.Common.BitArray p1, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p2);

		static IntPtr id_patternMatchVariance_arrayIarrayIF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='patternMatchVariance' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='float']]"
		[Register ("patternMatchVariance", "([I[IF)F", "")]
		protected static unsafe float PatternMatchVariance (int[] p0, int[] p1, float p2)
		{
			if (id_patternMatchVariance_arrayIarrayIF == IntPtr.Zero)
				id_patternMatchVariance_arrayIarrayIF = JNIEnv.GetStaticMethodID (class_ref, "patternMatchVariance", "([I[IF)F");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_patternMatchVariance_arrayIarrayIF, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_recordPattern_Lcom_google_zxing_common_BitArray_IarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='recordPattern' and count(parameter)=3 and parameter[1][@type='com.google.zxing.common.BitArray'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("recordPattern", "(Lcom/google/zxing/common/BitArray;I[I)V", "")]
		protected static unsafe void RecordPattern (global::Com.Google.Zxing.Common.BitArray p0, int p1, int[] p2)
		{
			if (id_recordPattern_Lcom_google_zxing_common_BitArray_IarrayI == IntPtr.Zero)
				id_recordPattern_Lcom_google_zxing_common_BitArray_IarrayI = JNIEnv.GetStaticMethodID (class_ref, "recordPattern", "(Lcom/google/zxing/common/BitArray;I[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_recordPattern_Lcom_google_zxing_common_BitArray_IarrayI, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_recordPatternInReverse_Lcom_google_zxing_common_BitArray_IarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='recordPatternInReverse' and count(parameter)=3 and parameter[1][@type='com.google.zxing.common.BitArray'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("recordPatternInReverse", "(Lcom/google/zxing/common/BitArray;I[I)V", "")]
		protected static unsafe void RecordPatternInReverse (global::Com.Google.Zxing.Common.BitArray p0, int p1, int[] p2)
		{
			if (id_recordPatternInReverse_Lcom_google_zxing_common_BitArray_IarrayI == IntPtr.Zero)
				id_recordPatternInReverse_Lcom_google_zxing_common_BitArray_IarrayI = JNIEnv.GetStaticMethodID (class_ref, "recordPatternInReverse", "(Lcom/google/zxing/common/BitArray;I[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_recordPatternInReverse_Lcom_google_zxing_common_BitArray_IarrayI, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
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
			global::Com.Google.Zxing.Oned.OneDReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='reset' and count(parameter)=0]"
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

	[global::Android.Runtime.Register ("com/google/zxing/oned/OneDReader", DoNotGenerateAcw=true)]
	internal partial class OneDReaderInvoker : OneDReader {

		public OneDReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (OneDReaderInvoker); }
		}

		static IntPtr id_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='decodeRow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray'] and parameter[3][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
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
				global::Com.Google.Zxing.Result __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (JNIEnv.CallObjectMethod  (Handle, id_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

}
