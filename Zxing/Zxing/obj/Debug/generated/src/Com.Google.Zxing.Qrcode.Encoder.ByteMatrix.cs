using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Qrcode.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='ByteMatrix']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/encoder/ByteMatrix", DoNotGenerateAcw=true)]
	public sealed partial class ByteMatrix : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/qrcode/encoder/ByteMatrix", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteMatrix); }
		}

		internal ByteMatrix (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='ByteMatrix']/constructor[@name='ByteMatrix' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe ByteMatrix (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ByteMatrix)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static IntPtr id_getHeight;
		public unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='ByteMatrix']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getHeight);
				} finally {
				}
			}
		}

		static IntPtr id_getWidth;
		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='ByteMatrix']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getWidth);
				} finally {
				}
			}
		}

		static IntPtr id_clear_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='ByteMatrix']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("clear", "(B)V", "")]
		public unsafe void Clear (sbyte p0)
		{
			if (id_clear_B == IntPtr.Zero)
				id_clear_B = JNIEnv.GetMethodID (class_ref, "clear", "(B)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_clear_B, __args);
			} finally {
			}
		}

		static IntPtr id_get_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='ByteMatrix']/method[@name='get' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("get", "(II)B", "")]
		public unsafe sbyte Get (int p0, int p1)
		{
			if (id_get_II == IntPtr.Zero)
				id_get_II = JNIEnv.GetMethodID (class_ref, "get", "(II)B");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallByteMethod  (Handle, id_get_II, __args);
			} finally {
			}
		}

		static IntPtr id_getArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='ByteMatrix']/method[@name='getArray' and count(parameter)=0]"
		[Register ("getArray", "()[[B", "")]
		public unsafe byte[][] GetArray ()
		{
			if (id_getArray == IntPtr.Zero)
				id_getArray = JNIEnv.GetMethodID (class_ref, "getArray", "()[[B");
			try {
				return (byte[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getArray), JniHandleOwnership.TransferLocalRef, typeof (byte[]));
			} finally {
			}
		}

		static IntPtr id_set_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='ByteMatrix']/method[@name='set' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("set", "(IIZ)V", "")]
		public unsafe void Set (int p0, int p1, bool p2)
		{
			if (id_set_IIZ == IntPtr.Zero)
				id_set_IIZ = JNIEnv.GetMethodID (class_ref, "set", "(IIZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_set_IIZ, __args);
			} finally {
			}
		}

		static IntPtr id_set_IIB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='ByteMatrix']/method[@name='set' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte']]"
		[Register ("set", "(IIB)V", "")]
		public unsafe void Set (int p0, int p1, sbyte p2)
		{
			if (id_set_IIB == IntPtr.Zero)
				id_set_IIB = JNIEnv.GetMethodID (class_ref, "set", "(IIB)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_set_IIB, __args);
			} finally {
			}
		}

		static IntPtr id_set_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.encoder']/class[@name='ByteMatrix']/method[@name='set' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("set", "(III)V", "")]
		public unsafe void Set (int p0, int p1, int p2)
		{
			if (id_set_III == IntPtr.Zero)
				id_set_III = JNIEnv.GetMethodID (class_ref, "set", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_set_III, __args);
			} finally {
			}
		}

	}
}
