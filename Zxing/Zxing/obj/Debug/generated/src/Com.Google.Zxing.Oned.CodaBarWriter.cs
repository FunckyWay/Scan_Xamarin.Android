using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Oned {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='CodaBarWriter']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/CodaBarWriter", DoNotGenerateAcw=true)]
	public sealed partial class CodaBarWriter : global::Com.Google.Zxing.Oned.OneDimensionalCodeWriter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/oned/CodaBarWriter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CodaBarWriter); }
		}

		internal CodaBarWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='CodaBarWriter']/constructor[@name='CodaBarWriter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CodaBarWriter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CodaBarWriter)) {
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

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='CodaBarWriter']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)[Z", "")]
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
