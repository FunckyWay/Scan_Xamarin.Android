using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']"
	[global::Android.Runtime.Register ("com/google/zxing/Result", DoNotGenerateAcw=true)]
	public sealed partial class Result : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/Result", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Result); }
		}

		internal Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_arrayBarrayLcom_google_zxing_ResultPoint_Lcom_google_zxing_BarcodeFormat_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/constructor[@name='Result' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.google.zxing.ResultPoint[]'] and parameter[4][@type='com.google.zxing.BarcodeFormat']]"
		[Register (".ctor", "(Ljava/lang/String;[B[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;)V", "")]
		public unsafe Result (string p0, byte[] p1, global::Com.Google.Zxing.ResultPoint[] p2, global::Com.Google.Zxing.BarcodeFormat p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (Result)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;[B[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;[B[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_arrayBarrayLcom_google_zxing_ResultPoint_Lcom_google_zxing_BarcodeFormat_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_arrayBarrayLcom_google_zxing_ResultPoint_Lcom_google_zxing_BarcodeFormat_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[B[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_arrayBarrayLcom_google_zxing_ResultPoint_Lcom_google_zxing_BarcodeFormat_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_arrayBarrayLcom_google_zxing_ResultPoint_Lcom_google_zxing_BarcodeFormat_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_arrayBarrayLcom_google_zxing_ResultPoint_Lcom_google_zxing_BarcodeFormat_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/constructor[@name='Result' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.google.zxing.ResultPoint[]'] and parameter[4][@type='com.google.zxing.BarcodeFormat'] and parameter[5][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;[B[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;J)V", "")]
		public unsafe Result (string p0, byte[] p1, global::Com.Google.Zxing.ResultPoint[] p2, global::Com.Google.Zxing.BarcodeFormat p3, long p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (Result)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;[B[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;[B[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_arrayBarrayLcom_google_zxing_ResultPoint_Lcom_google_zxing_BarcodeFormat_J == IntPtr.Zero)
					id_ctor_Ljava_lang_String_arrayBarrayLcom_google_zxing_ResultPoint_Lcom_google_zxing_BarcodeFormat_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[B[Lcom/google/zxing/ResultPoint;Lcom/google/zxing/BarcodeFormat;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_arrayBarrayLcom_google_zxing_ResultPoint_Lcom_google_zxing_BarcodeFormat_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_arrayBarrayLcom_google_zxing_ResultPoint_Lcom_google_zxing_BarcodeFormat_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_getBarcodeFormat;
		public unsafe global::Com.Google.Zxing.BarcodeFormat BarcodeFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='getBarcodeFormat' and count(parameter)=0]"
			[Register ("getBarcodeFormat", "()Lcom/google/zxing/BarcodeFormat;", "GetGetBarcodeFormatHandler")]
			get {
				if (id_getBarcodeFormat == IntPtr.Zero)
					id_getBarcodeFormat = JNIEnv.GetMethodID (class_ref, "getBarcodeFormat", "()Lcom/google/zxing/BarcodeFormat;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BarcodeFormat> (JNIEnv.CallObjectMethod  (Handle, id_getBarcodeFormat), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getResultMetadata;
		public unsafe global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.ResultMetadataType, global::Java.Lang.Object> ResultMetadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='getResultMetadata' and count(parameter)=0]"
			[Register ("getResultMetadata", "()Ljava/util/Map;", "GetGetResultMetadataHandler")]
			get {
				if (id_getResultMetadata == IntPtr.Zero)
					id_getResultMetadata = JNIEnv.GetMethodID (class_ref, "getResultMetadata", "()Ljava/util/Map;");
				try {
					return global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.ResultMetadataType, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getResultMetadata), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getText;
		public unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='getText' and count(parameter)=0]"
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

		static IntPtr id_getTimestamp;
		public unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "GetGetTimestampHandler")]
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()J");
				try {
					return JNIEnv.CallLongMethod  (Handle, id_getTimestamp);
				} finally {
				}
			}
		}

		static IntPtr id_addResultPoints_arrayLcom_google_zxing_ResultPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='addResultPoints' and count(parameter)=1 and parameter[1][@type='com.google.zxing.ResultPoint[]']]"
		[Register ("addResultPoints", "([Lcom/google/zxing/ResultPoint;)V", "")]
		public unsafe void AddResultPoints (global::Com.Google.Zxing.ResultPoint[] p0)
		{
			if (id_addResultPoints_arrayLcom_google_zxing_ResultPoint_ == IntPtr.Zero)
				id_addResultPoints_arrayLcom_google_zxing_ResultPoint_ = JNIEnv.GetMethodID (class_ref, "addResultPoints", "([Lcom/google/zxing/ResultPoint;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_addResultPoints_arrayLcom_google_zxing_ResultPoint_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getRawBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='getRawBytes' and count(parameter)=0]"
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

		static IntPtr id_getResultPoints;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='getResultPoints' and count(parameter)=0]"
		[Register ("getResultPoints", "()[Lcom/google/zxing/ResultPoint;", "")]
		public unsafe global::Com.Google.Zxing.ResultPoint[] GetResultPoints ()
		{
			if (id_getResultPoints == IntPtr.Zero)
				id_getResultPoints = JNIEnv.GetMethodID (class_ref, "getResultPoints", "()[Lcom/google/zxing/ResultPoint;");
			try {
				return (global::Com.Google.Zxing.ResultPoint[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getResultPoints), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.ResultPoint));
			} finally {
			}
		}

		static IntPtr id_putAllMetadata_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='putAllMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;com.google.zxing.ResultMetadataType, java.lang.Object&gt;']]"
		[Register ("putAllMetadata", "(Ljava/util/Map;)V", "")]
		public unsafe void PutAllMetadata (global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.ResultMetadataType, global::Java.Lang.Object> p0)
		{
			if (id_putAllMetadata_Ljava_util_Map_ == IntPtr.Zero)
				id_putAllMetadata_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "putAllMetadata", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.ResultMetadataType, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_putAllMetadata_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_putMetadata_Lcom_google_zxing_ResultMetadataType_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='Result']/method[@name='putMetadata' and count(parameter)=2 and parameter[1][@type='com.google.zxing.ResultMetadataType'] and parameter[2][@type='java.lang.Object']]"
		[Register ("putMetadata", "(Lcom/google/zxing/ResultMetadataType;Ljava/lang/Object;)V", "")]
		public unsafe void PutMetadata (global::Com.Google.Zxing.ResultMetadataType p0, global::Java.Lang.Object p1)
		{
			if (id_putMetadata_Lcom_google_zxing_ResultMetadataType_Ljava_lang_Object_ == IntPtr.Zero)
				id_putMetadata_Lcom_google_zxing_ResultMetadataType_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "putMetadata", "(Lcom/google/zxing/ResultMetadataType;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_putMetadata_Lcom_google_zxing_ResultMetadataType_Ljava_lang_Object_, __args);
			} finally {
			}
		}

	}
}
