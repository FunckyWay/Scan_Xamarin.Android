using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']"
	[global::Android.Runtime.Register ("com/google/zxing/common/DecoderResult", DoNotGenerateAcw=true)]
	public sealed partial class DecoderResult : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/DecoderResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecoderResult); }
		}

		internal DecoderResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBLjava_lang_String_Ljava_util_List_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/constructor[@name='DecoderResult' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;byte[]&gt;'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "([BLjava/lang/String;Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe DecoderResult (byte[] p0, string p1, global::System.Collections.Generic.IList<byte[]> p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (DecoderResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BLjava/lang/String;Ljava/util/List;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([BLjava/lang/String;Ljava/util/List;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_arrayBLjava_lang_String_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_arrayBLjava_lang_String_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "([BLjava/lang/String;Ljava/util/List;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBLjava_lang_String_Ljava_util_List_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayBLjava_lang_String_Ljava_util_List_Ljava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ctor_arrayBLjava_lang_String_Ljava_util_List_Ljava_lang_String_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/constructor[@name='DecoderResult' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;byte[]&gt;'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register (".ctor", "([BLjava/lang/String;Ljava/util/List;Ljava/lang/String;II)V", "")]
		public unsafe DecoderResult (byte[] p0, string p1, global::System.Collections.Generic.IList<byte[]> p2, string p3, int p4, int p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (DecoderResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BLjava/lang/String;Ljava/util/List;Ljava/lang/String;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([BLjava/lang/String;Ljava/util/List;Ljava/lang/String;II)V", __args);
					return;
				}

				if (id_ctor_arrayBLjava_lang_String_Ljava_util_List_Ljava_lang_String_II == IntPtr.Zero)
					id_ctor_arrayBLjava_lang_String_Ljava_util_List_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "<init>", "([BLjava/lang/String;Ljava/util/List;Ljava/lang/String;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBLjava_lang_String_Ljava_util_List_Ljava_lang_String_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayBLjava_lang_String_Ljava_util_List_Ljava_lang_String_II, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getByteSegments;
		public unsafe global::System.Collections.Generic.IList<byte[]> ByteSegments {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getByteSegments' and count(parameter)=0]"
			[Register ("getByteSegments", "()Ljava/util/List;", "GetGetByteSegmentsHandler")]
			get {
				if (id_getByteSegments == IntPtr.Zero)
					id_getByteSegments = JNIEnv.GetMethodID (class_ref, "getByteSegments", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<byte[]>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getByteSegments), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getECLevel;
		public unsafe string ECLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getECLevel' and count(parameter)=0]"
			[Register ("getECLevel", "()Ljava/lang/String;", "GetGetECLevelHandler")]
			get {
				if (id_getECLevel == IntPtr.Zero)
					id_getECLevel = JNIEnv.GetMethodID (class_ref, "getECLevel", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getECLevel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getErasures;
		static IntPtr id_setErasures_Ljava_lang_Integer_;
		public unsafe global::Java.Lang.Integer Erasures {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getErasures' and count(parameter)=0]"
			[Register ("getErasures", "()Ljava/lang/Integer;", "GetGetErasuresHandler")]
			get {
				if (id_getErasures == IntPtr.Zero)
					id_getErasures = JNIEnv.GetMethodID (class_ref, "getErasures", "()Ljava/lang/Integer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getErasures), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='setErasures' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setErasures", "(Ljava/lang/Integer;)V", "GetSetErasures_Ljava_lang_Integer_Handler")]
			set {
				if (id_setErasures_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setErasures_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setErasures", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setErasures_Ljava_lang_Integer_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getErrorsCorrected;
		static IntPtr id_setErrorsCorrected_Ljava_lang_Integer_;
		public unsafe global::Java.Lang.Integer ErrorsCorrected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getErrorsCorrected' and count(parameter)=0]"
			[Register ("getErrorsCorrected", "()Ljava/lang/Integer;", "GetGetErrorsCorrectedHandler")]
			get {
				if (id_getErrorsCorrected == IntPtr.Zero)
					id_getErrorsCorrected = JNIEnv.GetMethodID (class_ref, "getErrorsCorrected", "()Ljava/lang/Integer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getErrorsCorrected), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='setErrorsCorrected' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setErrorsCorrected", "(Ljava/lang/Integer;)V", "GetSetErrorsCorrected_Ljava_lang_Integer_Handler")]
			set {
				if (id_setErrorsCorrected_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setErrorsCorrected_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setErrorsCorrected", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setErrorsCorrected_Ljava_lang_Integer_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_hasStructuredAppend;
		public unsafe bool HasStructuredAppend {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='hasStructuredAppend' and count(parameter)=0]"
			[Register ("hasStructuredAppend", "()Z", "GetHasStructuredAppendHandler")]
			get {
				if (id_hasStructuredAppend == IntPtr.Zero)
					id_hasStructuredAppend = JNIEnv.GetMethodID (class_ref, "hasStructuredAppend", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_hasStructuredAppend);
				} finally {
				}
			}
		}

		static IntPtr id_getOther;
		static IntPtr id_setOther_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Other {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getOther' and count(parameter)=0]"
			[Register ("getOther", "()Ljava/lang/Object;", "GetGetOtherHandler")]
			get {
				if (id_getOther == IntPtr.Zero)
					id_getOther = JNIEnv.GetMethodID (class_ref, "getOther", "()Ljava/lang/Object;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getOther), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='setOther' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setOther", "(Ljava/lang/Object;)V", "GetSetOther_Ljava_lang_Object_Handler")]
			set {
				if (id_setOther_Ljava_lang_Object_ == IntPtr.Zero)
					id_setOther_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setOther", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setOther_Ljava_lang_Object_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getStructuredAppendParity;
		public unsafe int StructuredAppendParity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getStructuredAppendParity' and count(parameter)=0]"
			[Register ("getStructuredAppendParity", "()I", "GetGetStructuredAppendParityHandler")]
			get {
				if (id_getStructuredAppendParity == IntPtr.Zero)
					id_getStructuredAppendParity = JNIEnv.GetMethodID (class_ref, "getStructuredAppendParity", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getStructuredAppendParity);
				} finally {
				}
			}
		}

		static IntPtr id_getStructuredAppendSequenceNumber;
		public unsafe int StructuredAppendSequenceNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getStructuredAppendSequenceNumber' and count(parameter)=0]"
			[Register ("getStructuredAppendSequenceNumber", "()I", "GetGetStructuredAppendSequenceNumberHandler")]
			get {
				if (id_getStructuredAppendSequenceNumber == IntPtr.Zero)
					id_getStructuredAppendSequenceNumber = JNIEnv.GetMethodID (class_ref, "getStructuredAppendSequenceNumber", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getStructuredAppendSequenceNumber);
				} finally {
				}
			}
		}

		static IntPtr id_getText;
		public unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				if (id_getText == IntPtr.Zero)
					id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getText), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRawBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DecoderResult']/method[@name='getRawBytes' and count(parameter)=0]"
		[Register ("getRawBytes", "()[B", "")]
		public unsafe byte[] GetRawBytes ()
		{
			if (id_getRawBytes == IntPtr.Zero)
				id_getRawBytes = JNIEnv.GetMethodID (class_ref, "getRawBytes", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getRawBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
