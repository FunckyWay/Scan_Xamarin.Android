using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']"
	[global::Android.Runtime.Register ("com/google/zxing/common/BitArray", DoNotGenerateAcw=true)]
	public sealed partial class BitArray : global::Java.Lang.Object, global::Java.Lang.ICloneable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/BitArray", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitArray); }
		}

		internal BitArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/constructor[@name='BitArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BitArray (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BitArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/constructor[@name='BitArray' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitArray ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BitArray)) {
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

		static IntPtr id_getSize;
		public unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSize);
				} finally {
				}
			}
		}

		static IntPtr id_getSizeInBytes;
		public unsafe int SizeInBytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='getSizeInBytes' and count(parameter)=0]"
			[Register ("getSizeInBytes", "()I", "GetGetSizeInBytesHandler")]
			get {
				if (id_getSizeInBytes == IntPtr.Zero)
					id_getSizeInBytes = JNIEnv.GetMethodID (class_ref, "getSizeInBytes", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSizeInBytes);
				} finally {
				}
			}
		}

		static IntPtr id_appendBit_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='appendBit' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("appendBit", "(Z)V", "")]
		public unsafe void AppendBit (bool p0)
		{
			if (id_appendBit_Z == IntPtr.Zero)
				id_appendBit_Z = JNIEnv.GetMethodID (class_ref, "appendBit", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_appendBit_Z, __args);
			} finally {
			}
		}

		static IntPtr id_appendBitArray_Lcom_google_zxing_common_BitArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='appendBitArray' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitArray']]"
		[Register ("appendBitArray", "(Lcom/google/zxing/common/BitArray;)V", "")]
		public unsafe void AppendBitArray (global::Com.Google.Zxing.Common.BitArray p0)
		{
			if (id_appendBitArray_Lcom_google_zxing_common_BitArray_ == IntPtr.Zero)
				id_appendBitArray_Lcom_google_zxing_common_BitArray_ = JNIEnv.GetMethodID (class_ref, "appendBitArray", "(Lcom/google/zxing/common/BitArray;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_appendBitArray_Lcom_google_zxing_common_BitArray_, __args);
			} finally {
			}
		}

		static IntPtr id_appendBits_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='appendBits' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("appendBits", "(II)V", "")]
		public unsafe void AppendBits (int p0, int p1)
		{
			if (id_appendBits_II == IntPtr.Zero)
				id_appendBits_II = JNIEnv.GetMethodID (class_ref, "appendBits", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_appendBits_II, __args);
			} finally {
			}
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			} finally {
			}
		}

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/google/zxing/common/BitArray;", "")]
		public unsafe global::Com.Google.Zxing.Common.BitArray Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/google/zxing/common/BitArray;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_flip_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='flip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("flip", "(I)V", "")]
		public unsafe void Flip (int p0)
		{
			if (id_flip_I == IntPtr.Zero)
				id_flip_I = JNIEnv.GetMethodID (class_ref, "flip", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_flip_I, __args);
			} finally {
			}
		}

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Z", "")]
		public unsafe bool Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod  (Handle, id_get_I, __args);
			} finally {
			}
		}

		static IntPtr id_getBitArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='getBitArray' and count(parameter)=0]"
		[Register ("getBitArray", "()[I", "")]
		public unsafe int[] GetBitArray ()
		{
			if (id_getBitArray == IntPtr.Zero)
				id_getBitArray = JNIEnv.GetMethodID (class_ref, "getBitArray", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBitArray), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_getNextSet_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='getNextSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getNextSet", "(I)I", "")]
		public unsafe int GetNextSet (int p0)
		{
			if (id_getNextSet_I == IntPtr.Zero)
				id_getNextSet_I = JNIEnv.GetMethodID (class_ref, "getNextSet", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod  (Handle, id_getNextSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_getNextUnset_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='getNextUnset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getNextUnset", "(I)I", "")]
		public unsafe int GetNextUnset (int p0)
		{
			if (id_getNextUnset_I == IntPtr.Zero)
				id_getNextUnset_I = JNIEnv.GetMethodID (class_ref, "getNextUnset", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod  (Handle, id_getNextUnset_I, __args);
			} finally {
			}
		}

		static IntPtr id_isRange_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='isRange' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("isRange", "(IIZ)Z", "")]
		public unsafe bool IsRange (int p0, int p1, bool p2)
		{
			if (id_isRange_IIZ == IntPtr.Zero)
				id_isRange_IIZ = JNIEnv.GetMethodID (class_ref, "isRange", "(IIZ)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallBooleanMethod  (Handle, id_isRange_IIZ, __args);
			} finally {
			}
		}

		static IntPtr id_reverse;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='reverse' and count(parameter)=0]"
		[Register ("reverse", "()V", "")]
		public unsafe void Reverse ()
		{
			if (id_reverse == IntPtr.Zero)
				id_reverse = JNIEnv.GetMethodID (class_ref, "reverse", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_reverse);
			} finally {
			}
		}

		static IntPtr id_set_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='set' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("set", "(I)V", "")]
		public unsafe void Set (int p0)
		{
			if (id_set_I == IntPtr.Zero)
				id_set_I = JNIEnv.GetMethodID (class_ref, "set", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_set_I, __args);
			} finally {
			}
		}

		static IntPtr id_setBulk_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='setBulk' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setBulk", "(II)V", "")]
		public unsafe void SetBulk (int p0, int p1)
		{
			if (id_setBulk_II == IntPtr.Zero)
				id_setBulk_II = JNIEnv.GetMethodID (class_ref, "setBulk", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setBulk_II, __args);
			} finally {
			}
		}

		static IntPtr id_setRange_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='setRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setRange", "(II)V", "")]
		public unsafe void SetRange (int p0, int p1)
		{
			if (id_setRange_II == IntPtr.Zero)
				id_setRange_II = JNIEnv.GetMethodID (class_ref, "setRange", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setRange_II, __args);
			} finally {
			}
		}

		static IntPtr id_toBytes_IarrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='toBytes' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("toBytes", "(I[BII)V", "")]
		public unsafe void ToBytes (int p0, byte[] p1, int p2, int p3)
		{
			if (id_toBytes_IarrayBII == IntPtr.Zero)
				id_toBytes_IarrayBII = JNIEnv.GetMethodID (class_ref, "toBytes", "(I[BII)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod  (Handle, id_toBytes_IarrayBII, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_xor_Lcom_google_zxing_common_BitArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='xor' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitArray']]"
		[Register ("xor", "(Lcom/google/zxing/common/BitArray;)V", "")]
		public unsafe void Xor (global::Com.Google.Zxing.Common.BitArray p0)
		{
			if (id_xor_Lcom_google_zxing_common_BitArray_ == IntPtr.Zero)
				id_xor_Lcom_google_zxing_common_BitArray_ = JNIEnv.GetMethodID (class_ref, "xor", "(Lcom/google/zxing/common/BitArray;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_xor_Lcom_google_zxing_common_BitArray_, __args);
			} finally {
			}
		}

	}
}
