using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Oned {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='MultiFormatUPCEANReader']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/MultiFormatUPCEANReader", DoNotGenerateAcw=true)]
	public sealed partial class MultiFormatUPCEANReader : global::Com.Google.Zxing.Oned.OneDReader {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/oned/MultiFormatUPCEANReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiFormatUPCEANReader); }
		}

		internal MultiFormatUPCEANReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='MultiFormatUPCEANReader']/constructor[@name='MultiFormatUPCEANReader' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe MultiFormatUPCEANReader (global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (MultiFormatUPCEANReader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_decodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='MultiFormatUPCEANReader']/method[@name='decodeRow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray'] and parameter[3][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decodeRow", "(ILcom/google/zxing/common/BitArray;Ljava/util/Map;)Lcom/google/zxing/Result;", "")]
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
