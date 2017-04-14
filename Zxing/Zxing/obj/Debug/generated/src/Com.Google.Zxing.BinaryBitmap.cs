using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']"
	[global::Android.Runtime.Register ("com/google/zxing/BinaryBitmap", DoNotGenerateAcw=true)]
	public sealed partial class BinaryBitmap : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/BinaryBitmap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BinaryBitmap); }
		}

		internal BinaryBitmap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_Binarizer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/constructor[@name='BinaryBitmap' and count(parameter)=1 and parameter[1][@type='com.google.zxing.Binarizer']]"
		[Register (".ctor", "(Lcom/google/zxing/Binarizer;)V", "")]
		public unsafe BinaryBitmap (global::Com.Google.Zxing.Binarizer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BinaryBitmap)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/Binarizer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/Binarizer;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_Binarizer_ == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_Binarizer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/Binarizer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_Binarizer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_Binarizer_, __args);
			} finally {
			}
		}

		static IntPtr id_getBlackMatrix;
		public unsafe global::Com.Google.Zxing.Common.BitMatrix BlackMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='getBlackMatrix' and count(parameter)=0]"
			[Register ("getBlackMatrix", "()Lcom/google/zxing/common/BitMatrix;", "GetGetBlackMatrixHandler")]
			get {
				if (id_getBlackMatrix == IntPtr.Zero)
					id_getBlackMatrix = JNIEnv.GetMethodID (class_ref, "getBlackMatrix", "()Lcom/google/zxing/common/BitMatrix;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod  (Handle, id_getBlackMatrix), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getHeight;
		public unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='getHeight' and count(parameter)=0]"
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

		static IntPtr id_isCropSupported;
		public unsafe bool IsCropSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='isCropSupported' and count(parameter)=0]"
			[Register ("isCropSupported", "()Z", "GetIsCropSupportedHandler")]
			get {
				if (id_isCropSupported == IntPtr.Zero)
					id_isCropSupported = JNIEnv.GetMethodID (class_ref, "isCropSupported", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isCropSupported);
				} finally {
				}
			}
		}

		static IntPtr id_isRotateSupported;
		public unsafe bool IsRotateSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='isRotateSupported' and count(parameter)=0]"
			[Register ("isRotateSupported", "()Z", "GetIsRotateSupportedHandler")]
			get {
				if (id_isRotateSupported == IntPtr.Zero)
					id_isRotateSupported = JNIEnv.GetMethodID (class_ref, "isRotateSupported", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isRotateSupported);
				} finally {
				}
			}
		}

		static IntPtr id_getWidth;
		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='getWidth' and count(parameter)=0]"
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

		static IntPtr id_crop_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='crop' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("crop", "(IIII)Lcom/google/zxing/BinaryBitmap;", "")]
		public unsafe global::Com.Google.Zxing.BinaryBitmap Crop (int p0, int p1, int p2, int p3)
		{
			if (id_crop_IIII == IntPtr.Zero)
				id_crop_IIII = JNIEnv.GetMethodID (class_ref, "crop", "(IIII)Lcom/google/zxing/BinaryBitmap;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (JNIEnv.CallObjectMethod  (Handle, id_crop_IIII, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getBlackRow_ILcom_google_zxing_common_BitArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='getBlackRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray']]"
		[Register ("getBlackRow", "(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;", "")]
		public unsafe global::Com.Google.Zxing.Common.BitArray GetBlackRow (int p0, global::Com.Google.Zxing.Common.BitArray p1)
		{
			if (id_getBlackRow_ILcom_google_zxing_common_BitArray_ == IntPtr.Zero)
				id_getBlackRow_ILcom_google_zxing_common_BitArray_ = JNIEnv.GetMethodID (class_ref, "getBlackRow", "(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Zxing.Common.BitArray __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (JNIEnv.CallObjectMethod  (Handle, id_getBlackRow_ILcom_google_zxing_common_BitArray_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_rotateCounterClockwise;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='rotateCounterClockwise' and count(parameter)=0]"
		[Register ("rotateCounterClockwise", "()Lcom/google/zxing/BinaryBitmap;", "")]
		public unsafe global::Com.Google.Zxing.BinaryBitmap RotateCounterClockwise ()
		{
			if (id_rotateCounterClockwise == IntPtr.Zero)
				id_rotateCounterClockwise = JNIEnv.GetMethodID (class_ref, "rotateCounterClockwise", "()Lcom/google/zxing/BinaryBitmap;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (JNIEnv.CallObjectMethod  (Handle, id_rotateCounterClockwise), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_rotateCounterClockwise45;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='rotateCounterClockwise45' and count(parameter)=0]"
		[Register ("rotateCounterClockwise45", "()Lcom/google/zxing/BinaryBitmap;", "")]
		public unsafe global::Com.Google.Zxing.BinaryBitmap RotateCounterClockwise45 ()
		{
			if (id_rotateCounterClockwise45 == IntPtr.Zero)
				id_rotateCounterClockwise45 = JNIEnv.GetMethodID (class_ref, "rotateCounterClockwise45", "()Lcom/google/zxing/BinaryBitmap;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (JNIEnv.CallObjectMethod  (Handle, id_rotateCounterClockwise45), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
