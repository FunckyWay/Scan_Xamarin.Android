using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']"
	[global::Android.Runtime.Register ("com/google/zxing/common/BitMatrix", DoNotGenerateAcw=true)]
	public sealed partial class BitMatrix : global::Java.Lang.Object, global::Java.Lang.ICloneable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/BitMatrix", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitMatrix); }
		}

		internal BitMatrix (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/constructor[@name='BitMatrix' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe BitMatrix (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BitMatrix)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/constructor[@name='BitMatrix' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BitMatrix (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BitMatrix)) {
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

		static IntPtr id_getHeight;
		public unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getHeight' and count(parameter)=0]"
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

		static IntPtr id_getRowSize;
		public unsafe int RowSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getRowSize' and count(parameter)=0]"
			[Register ("getRowSize", "()I", "GetGetRowSizeHandler")]
			get {
				if (id_getRowSize == IntPtr.Zero)
					id_getRowSize = JNIEnv.GetMethodID (class_ref, "getRowSize", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getRowSize);
				} finally {
				}
			}
		}

		static IntPtr id_getWidth;
		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getWidth' and count(parameter)=0]"
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

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='clear' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/google/zxing/common/BitMatrix;", "")]
		public unsafe global::Com.Google.Zxing.Common.BitMatrix Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/google/zxing/common/BitMatrix;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_flip_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='flip' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("flip", "(II)V", "")]
		public unsafe void Flip (int p0, int p1)
		{
			if (id_flip_II == IntPtr.Zero)
				id_flip_II = JNIEnv.GetMethodID (class_ref, "flip", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_flip_II, __args);
			} finally {
			}
		}

		static IntPtr id_get_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='get' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("get", "(II)Z", "")]
		public unsafe bool Get (int p0, int p1)
		{
			if (id_get_II == IntPtr.Zero)
				id_get_II = JNIEnv.GetMethodID (class_ref, "get", "(II)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallBooleanMethod  (Handle, id_get_II, __args);
			} finally {
			}
		}

		static IntPtr id_getBottomRightOnBit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getBottomRightOnBit' and count(parameter)=0]"
		[Register ("getBottomRightOnBit", "()[I", "")]
		public unsafe int[] GetBottomRightOnBit ()
		{
			if (id_getBottomRightOnBit == IntPtr.Zero)
				id_getBottomRightOnBit = JNIEnv.GetMethodID (class_ref, "getBottomRightOnBit", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBottomRightOnBit), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_getEnclosingRectangle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getEnclosingRectangle' and count(parameter)=0]"
		[Register ("getEnclosingRectangle", "()[I", "")]
		public unsafe int[] GetEnclosingRectangle ()
		{
			if (id_getEnclosingRectangle == IntPtr.Zero)
				id_getEnclosingRectangle = JNIEnv.GetMethodID (class_ref, "getEnclosingRectangle", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getEnclosingRectangle), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_getRow_ILcom_google_zxing_common_BitArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray']]"
		[Register ("getRow", "(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;", "")]
		public unsafe global::Com.Google.Zxing.Common.BitArray GetRow (int p0, global::Com.Google.Zxing.Common.BitArray p1)
		{
			if (id_getRow_ILcom_google_zxing_common_BitArray_ == IntPtr.Zero)
				id_getRow_ILcom_google_zxing_common_BitArray_ = JNIEnv.GetMethodID (class_ref, "getRow", "(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Zxing.Common.BitArray __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (JNIEnv.CallObjectMethod  (Handle, id_getRow_ILcom_google_zxing_common_BitArray_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTopLeftOnBit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='getTopLeftOnBit' and count(parameter)=0]"
		[Register ("getTopLeftOnBit", "()[I", "")]
		public unsafe int[] GetTopLeftOnBit ()
		{
			if (id_getTopLeftOnBit == IntPtr.Zero)
				id_getTopLeftOnBit = JNIEnv.GetMethodID (class_ref, "getTopLeftOnBit", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getTopLeftOnBit), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_parse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='parse' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/google/zxing/common/BitMatrix;", "")]
		public static unsafe global::Com.Google.Zxing.Common.BitMatrix Parse (string p0, string p1, string p2)
		{
			if (id_parse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/google/zxing/common/BitMatrix;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Com.Google.Zxing.Common.BitMatrix __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_rotate180;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='rotate180' and count(parameter)=0]"
		[Register ("rotate180", "()V", "")]
		public unsafe void Rotate180 ()
		{
			if (id_rotate180 == IntPtr.Zero)
				id_rotate180 = JNIEnv.GetMethodID (class_ref, "rotate180", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_rotate180);
			} finally {
			}
		}

		static IntPtr id_set_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("set", "(II)V", "")]
		public unsafe void Set (int p0, int p1)
		{
			if (id_set_II == IntPtr.Zero)
				id_set_II = JNIEnv.GetMethodID (class_ref, "set", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_set_II, __args);
			} finally {
			}
		}

		static IntPtr id_setRegion_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='setRegion' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setRegion", "(IIII)V", "")]
		public unsafe void SetRegion (int p0, int p1, int p2, int p3)
		{
			if (id_setRegion_IIII == IntPtr.Zero)
				id_setRegion_IIII = JNIEnv.GetMethodID (class_ref, "setRegion", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod  (Handle, id_setRegion_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_setRow_ILcom_google_zxing_common_BitArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='setRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray']]"
		[Register ("setRow", "(ILcom/google/zxing/common/BitArray;)V", "")]
		public unsafe void SetRow (int p0, global::Com.Google.Zxing.Common.BitArray p1)
		{
			if (id_setRow_ILcom_google_zxing_common_BitArray_ == IntPtr.Zero)
				id_setRow_ILcom_google_zxing_common_BitArray_ = JNIEnv.GetMethodID (class_ref, "setRow", "(ILcom/google/zxing/common/BitArray;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setRow_ILcom_google_zxing_common_BitArray_, __args);
			} finally {
			}
		}

		static IntPtr id_toString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='toString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("toString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string ToString (string p0, string p1)
		{
			if (id_toString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_toString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_toString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='toString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("toString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string ToString (string p0, string p1, string p2)
		{
			if (id_toString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_toString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_unset_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='unset' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("unset", "(II)V", "")]
		public unsafe void Unset (int p0, int p1)
		{
			if (id_unset_II == IntPtr.Zero)
				id_unset_II = JNIEnv.GetMethodID (class_ref, "unset", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_unset_II, __args);
			} finally {
			}
		}

		static IntPtr id_xor_Lcom_google_zxing_common_BitMatrix_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitMatrix']/method[@name='xor' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register ("xor", "(Lcom/google/zxing/common/BitMatrix;)V", "")]
		public unsafe void Xor (global::Com.Google.Zxing.Common.BitMatrix p0)
		{
			if (id_xor_Lcom_google_zxing_common_BitMatrix_ == IntPtr.Zero)
				id_xor_Lcom_google_zxing_common_BitMatrix_ = JNIEnv.GetMethodID (class_ref, "xor", "(Lcom/google/zxing/common/BitMatrix;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_xor_Lcom_google_zxing_common_BitMatrix_, __args);
			} finally {
			}
		}

	}
}
