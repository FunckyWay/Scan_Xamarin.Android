using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Oned {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/OneDimensionalCodeWriter", DoNotGenerateAcw=true)]
	public abstract partial class OneDimensionalCodeWriter : global::Java.Lang.Object, global::Com.Google.Zxing.IWriter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/oned/OneDimensionalCodeWriter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OneDimensionalCodeWriter); }
		}

		protected OneDimensionalCodeWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/constructor[@name='OneDimensionalCodeWriter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OneDimensionalCodeWriter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OneDimensionalCodeWriter)) {
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

		static Delegate cb_getDefaultMargin;
#pragma warning disable 0169
		static Delegate GetGetDefaultMarginHandler ()
		{
			if (cb_getDefaultMargin == null)
				cb_getDefaultMargin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDefaultMargin);
			return cb_getDefaultMargin;
		}

		static int n_GetDefaultMargin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.Oned.OneDimensionalCodeWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDimensionalCodeWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultMargin;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultMargin;
		public virtual unsafe int DefaultMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/method[@name='getDefaultMargin' and count(parameter)=0]"
			[Register ("getDefaultMargin", "()I", "GetGetDefaultMarginHandler")]
			get {
				if (id_getDefaultMargin == IntPtr.Zero)
					id_getDefaultMargin = JNIEnv.GetMethodID (class_ref, "getDefaultMargin", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDefaultMargin);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultMargin", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_appendPattern_arrayZIarrayIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/method[@name='appendPattern' and count(parameter)=4 and parameter[1][@type='boolean[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='boolean']]"
		[Register ("appendPattern", "([ZI[IZ)I", "")]
		protected static unsafe int AppendPattern (bool[] p0, int p1, int[] p2, bool p3)
		{
			if (id_appendPattern_arrayZIarrayIZ == IntPtr.Zero)
				id_appendPattern_arrayZIarrayIZ = JNIEnv.GetStaticMethodID (class_ref, "appendPattern", "([ZI[IZ)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_appendPattern_arrayZIarrayIZ, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_encode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Handler ()
		{
			if (cb_encode_Ljava_lang_String_ == null)
				cb_encode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_String_);
			return cb_encode_Ljava_lang_String_;
		}

		static IntPtr n_Encode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Zxing.Oned.OneDimensionalCodeWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDimensionalCodeWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)[Z", "GetEncode_Ljava_lang_String_Handler")]
		public abstract bool[] Encode (string p0);

		static IntPtr id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/method[@name='encode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.BarcodeFormat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;II)Lcom/google/zxing/common/BitMatrix;", "")]
		public unsafe global::Com.Google.Zxing.Common.BitMatrix Encode (string p0, global::Com.Google.Zxing.BarcodeFormat p1, int p2, int p3)
		{
			if (id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II == IntPtr.Zero)
				id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;II)Lcom/google/zxing/common/BitMatrix;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Com.Google.Zxing.Common.BitMatrix __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod  (Handle, id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_Handler ()
		{
			if (cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ == null)
				cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_Encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_);
			return cb_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_;
		}

		static IntPtr n_Encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, IntPtr native_p4)
		{
			global::Com.Google.Zxing.Oned.OneDimensionalCodeWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.OneDimensionalCodeWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.BarcodeFormat p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.EncodeHintType, object>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/method[@name='encode' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.zxing.BarcodeFormat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.util.Map&lt;com.google.zxing.EncodeHintType, ?&gt;']]"
		[Register ("encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;IILjava/util/Map;)Lcom/google/zxing/common/BitMatrix;", "GetEncode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_Handler")]
		public virtual unsafe global::Com.Google.Zxing.Common.BitMatrix Encode (string p0, global::Com.Google.Zxing.BarcodeFormat p1, int p2, int p3, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.EncodeHintType, object> p4)
		{
			if (id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;IILjava/util/Map;)Lcom/google/zxing/common/BitMatrix;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.EncodeHintType, object>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);

				global::Com.Google.Zxing.Common.BitMatrix __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod  (Handle, id_encode_Ljava_lang_String_Lcom_google_zxing_BarcodeFormat_IILjava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;Lcom/google/zxing/BarcodeFormat;IILjava/util/Map;)Lcom/google/zxing/common/BitMatrix;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/oned/OneDimensionalCodeWriter", DoNotGenerateAcw=true)]
	internal partial class OneDimensionalCodeWriterInvoker : OneDimensionalCodeWriter {

		public OneDimensionalCodeWriterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (OneDimensionalCodeWriterInvoker); }
		}

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDimensionalCodeWriter']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)[Z", "GetEncode_Ljava_lang_String_Handler")]
		public override unsafe bool[] Encode (string p0)
		{
			if (id_encode_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;)[Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_encode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
