using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Datamatrix.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='DefaultPlacement']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/encoder/DefaultPlacement", DoNotGenerateAcw=true)]
	public partial class DefaultPlacement : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/datamatrix/encoder/DefaultPlacement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultPlacement); }
		}

		protected DefaultPlacement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_CharSequence_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='DefaultPlacement']/constructor[@name='DefaultPlacement' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/CharSequence;II)V", "")]
		public unsafe DefaultPlacement (global::Java.Lang.ICharSequence p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (DefaultPlacement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/CharSequence;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/CharSequence;II)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_CharSequence_II == IntPtr.Zero)
					id_ctor_Ljava_lang_CharSequence_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/CharSequence;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_CharSequence_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_CharSequence_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		[Register (".ctor", "(Ljava/lang/CharSequence;II)V", "")]
		public unsafe DefaultPlacement (string p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (DefaultPlacement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/CharSequence;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/CharSequence;II)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_CharSequence_II == IntPtr.Zero)
					id_ctor_Ljava_lang_CharSequence_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/CharSequence;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_CharSequence_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_CharSequence_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getBit_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='DefaultPlacement']/method[@name='getBit' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getBit", "(II)Z", "")]
		public unsafe bool GetBit (int p0, int p1)
		{
			if (id_getBit_II == IntPtr.Zero)
				id_getBit_II = JNIEnv.GetMethodID (class_ref, "getBit", "(II)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallBooleanMethod  (Handle, id_getBit_II, __args);
			} finally {
			}
		}

		static IntPtr id_place;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.encoder']/class[@name='DefaultPlacement']/method[@name='place' and count(parameter)=0]"
		[Register ("place", "()V", "")]
		public unsafe void Place ()
		{
			if (id_place == IntPtr.Zero)
				id_place = JNIEnv.GetMethodID (class_ref, "place", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_place);
			} finally {
			}
		}

	}
}
