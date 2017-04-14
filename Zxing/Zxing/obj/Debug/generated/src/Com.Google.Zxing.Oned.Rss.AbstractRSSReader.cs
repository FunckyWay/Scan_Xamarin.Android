using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Oned.Rss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/rss/AbstractRSSReader", DoNotGenerateAcw=true)]
	public abstract partial class AbstractRSSReader : global::Com.Google.Zxing.Oned.OneDReader {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/oned/rss/AbstractRSSReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractRSSReader); }
		}

		protected AbstractRSSReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/constructor[@name='AbstractRSSReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe AbstractRSSReader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AbstractRSSReader)) {
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

		static IntPtr id_count_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='count' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("count", "([I)I", "")]
		protected static unsafe int Count (int[] p0)
		{
			if (id_count_arrayI == IntPtr.Zero)
				id_count_arrayI = JNIEnv.GetStaticMethodID (class_ref, "count", "([I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_count_arrayI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_decrement_arrayIarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='decrement' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='float[]']]"
		[Register ("decrement", "([I[F)V", "")]
		protected static unsafe void Decrement (int[] p0, float[] p1)
		{
			if (id_decrement_arrayIarrayF == IntPtr.Zero)
				id_decrement_arrayIarrayF = JNIEnv.GetStaticMethodID (class_ref, "decrement", "([I[F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_decrement_arrayIarrayF, __args);
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

		static IntPtr id_getDataCharacterCounters;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='getDataCharacterCounters' and count(parameter)=0]"
		[Register ("getDataCharacterCounters", "()[I", "")]
		protected unsafe int[] GetDataCharacterCounters ()
		{
			if (id_getDataCharacterCounters == IntPtr.Zero)
				id_getDataCharacterCounters = JNIEnv.GetMethodID (class_ref, "getDataCharacterCounters", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getDataCharacterCounters), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_getDecodeFinderCounters;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='getDecodeFinderCounters' and count(parameter)=0]"
		[Register ("getDecodeFinderCounters", "()[I", "")]
		protected unsafe int[] GetDecodeFinderCounters ()
		{
			if (id_getDecodeFinderCounters == IntPtr.Zero)
				id_getDecodeFinderCounters = JNIEnv.GetMethodID (class_ref, "getDecodeFinderCounters", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getDecodeFinderCounters), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_getEvenCounts;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='getEvenCounts' and count(parameter)=0]"
		[Register ("getEvenCounts", "()[I", "")]
		protected unsafe int[] GetEvenCounts ()
		{
			if (id_getEvenCounts == IntPtr.Zero)
				id_getEvenCounts = JNIEnv.GetMethodID (class_ref, "getEvenCounts", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getEvenCounts), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_getEvenRoundingErrors;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='getEvenRoundingErrors' and count(parameter)=0]"
		[Register ("getEvenRoundingErrors", "()[F", "")]
		protected unsafe float[] GetEvenRoundingErrors ()
		{
			if (id_getEvenRoundingErrors == IntPtr.Zero)
				id_getEvenRoundingErrors = JNIEnv.GetMethodID (class_ref, "getEvenRoundingErrors", "()[F");
			try {
				return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getEvenRoundingErrors), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static IntPtr id_getOddCounts;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='getOddCounts' and count(parameter)=0]"
		[Register ("getOddCounts", "()[I", "")]
		protected unsafe int[] GetOddCounts ()
		{
			if (id_getOddCounts == IntPtr.Zero)
				id_getOddCounts = JNIEnv.GetMethodID (class_ref, "getOddCounts", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getOddCounts), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_getOddRoundingErrors;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='getOddRoundingErrors' and count(parameter)=0]"
		[Register ("getOddRoundingErrors", "()[F", "")]
		protected unsafe float[] GetOddRoundingErrors ()
		{
			if (id_getOddRoundingErrors == IntPtr.Zero)
				id_getOddRoundingErrors = JNIEnv.GetMethodID (class_ref, "getOddRoundingErrors", "()[F");
			try {
				return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getOddRoundingErrors), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static IntPtr id_increment_arrayIarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='increment' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='float[]']]"
		[Register ("increment", "([I[F)V", "")]
		protected static unsafe void Increment (int[] p0, float[] p1)
		{
			if (id_increment_arrayIarrayF == IntPtr.Zero)
				id_increment_arrayIarrayF = JNIEnv.GetStaticMethodID (class_ref, "increment", "([I[F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_increment_arrayIarrayF, __args);
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

		static IntPtr id_isFinderPattern_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='isFinderPattern' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("isFinderPattern", "([I)Z", "")]
		protected static unsafe bool IsFinderPattern (int[] p0)
		{
			if (id_isFinderPattern_arrayI == IntPtr.Zero)
				id_isFinderPattern_arrayI = JNIEnv.GetStaticMethodID (class_ref, "isFinderPattern", "([I)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isFinderPattern_arrayI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_parseFinderValue_arrayIarrayarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='parseFinderValue' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[][]']]"
		[Register ("parseFinderValue", "([I[[I)I", "")]
		protected static unsafe int ParseFinderValue (int[] p0, int[][] p1)
		{
			if (id_parseFinderValue_arrayIarrayarrayI == IntPtr.Zero)
				id_parseFinderValue_arrayIarrayarrayI = JNIEnv.GetStaticMethodID (class_ref, "parseFinderValue", "([I[[I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_parseFinderValue_arrayIarrayarrayI, __args);
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

	}

	[global::Android.Runtime.Register ("com/google/zxing/oned/rss/AbstractRSSReader", DoNotGenerateAcw=true)]
	internal partial class AbstractRSSReaderInvoker : AbstractRSSReader {

		public AbstractRSSReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractRSSReaderInvoker); }
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
