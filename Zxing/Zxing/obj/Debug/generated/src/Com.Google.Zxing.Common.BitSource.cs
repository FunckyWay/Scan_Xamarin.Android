using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitSource']"
	[global::Android.Runtime.Register ("com/google/zxing/common/BitSource", DoNotGenerateAcw=true)]
	public sealed partial class BitSource : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/BitSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitSource); }
		}

		internal BitSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitSource']/constructor[@name='BitSource' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe BitSource (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (BitSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getBitOffset;
		public unsafe int BitOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitSource']/method[@name='getBitOffset' and count(parameter)=0]"
			[Register ("getBitOffset", "()I", "GetGetBitOffsetHandler")]
			get {
				if (id_getBitOffset == IntPtr.Zero)
					id_getBitOffset = JNIEnv.GetMethodID (class_ref, "getBitOffset", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getBitOffset);
				} finally {
				}
			}
		}

		static IntPtr id_getByteOffset;
		public unsafe int ByteOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitSource']/method[@name='getByteOffset' and count(parameter)=0]"
			[Register ("getByteOffset", "()I", "GetGetByteOffsetHandler")]
			get {
				if (id_getByteOffset == IntPtr.Zero)
					id_getByteOffset = JNIEnv.GetMethodID (class_ref, "getByteOffset", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getByteOffset);
				} finally {
				}
			}
		}

		static IntPtr id_available;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitSource']/method[@name='available' and count(parameter)=0]"
		[Register ("available", "()I", "")]
		public unsafe int Available ()
		{
			if (id_available == IntPtr.Zero)
				id_available = JNIEnv.GetMethodID (class_ref, "available", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_available);
			} finally {
			}
		}

		static IntPtr id_readBits_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitSource']/method[@name='readBits' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readBits", "(I)I", "")]
		public unsafe int ReadBits (int p0)
		{
			if (id_readBits_I == IntPtr.Zero)
				id_readBits_I = JNIEnv.GetMethodID (class_ref, "readBits", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod  (Handle, id_readBits_I, __args);
			} finally {
			}
		}

	}
}
