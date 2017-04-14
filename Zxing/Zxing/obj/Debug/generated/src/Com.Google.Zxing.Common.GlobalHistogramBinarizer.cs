using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GlobalHistogramBinarizer']"
	[global::Android.Runtime.Register ("com/google/zxing/common/GlobalHistogramBinarizer", DoNotGenerateAcw=true)]
	public partial class GlobalHistogramBinarizer : global::Com.Google.Zxing.Binarizer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/GlobalHistogramBinarizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlobalHistogramBinarizer); }
		}

		protected GlobalHistogramBinarizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_LuminanceSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GlobalHistogramBinarizer']/constructor[@name='GlobalHistogramBinarizer' and count(parameter)=1 and parameter[1][@type='com.google.zxing.LuminanceSource']]"
		[Register (".ctor", "(Lcom/google/zxing/LuminanceSource;)V", "")]
		public unsafe GlobalHistogramBinarizer (global::Com.Google.Zxing.LuminanceSource p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GlobalHistogramBinarizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/LuminanceSource;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/LuminanceSource;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_LuminanceSource_ == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_LuminanceSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/LuminanceSource;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_LuminanceSource_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_LuminanceSource_, __args);
			} finally {
			}
		}

		static Delegate cb_getBlackMatrix;
#pragma warning disable 0169
		static Delegate GetGetBlackMatrixHandler ()
		{
			if (cb_getBlackMatrix == null)
				cb_getBlackMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBlackMatrix);
			return cb_getBlackMatrix;
		}

		static IntPtr n_GetBlackMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.Common.GlobalHistogramBinarizer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.GlobalHistogramBinarizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BlackMatrix);
		}
#pragma warning restore 0169

		static IntPtr id_getBlackMatrix;
		public override unsafe global::Com.Google.Zxing.Common.BitMatrix BlackMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GlobalHistogramBinarizer']/method[@name='getBlackMatrix' and count(parameter)=0]"
			[Register ("getBlackMatrix", "()Lcom/google/zxing/common/BitMatrix;", "GetGetBlackMatrixHandler")]
			get {
				if (id_getBlackMatrix == IntPtr.Zero)
					id_getBlackMatrix = JNIEnv.GetMethodID (class_ref, "getBlackMatrix", "()Lcom/google/zxing/common/BitMatrix;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod  (Handle, id_getBlackMatrix), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlackMatrix", "()Lcom/google/zxing/common/BitMatrix;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createBinarizer_Lcom_google_zxing_LuminanceSource_;
#pragma warning disable 0169
		static Delegate GetCreateBinarizer_Lcom_google_zxing_LuminanceSource_Handler ()
		{
			if (cb_createBinarizer_Lcom_google_zxing_LuminanceSource_ == null)
				cb_createBinarizer_Lcom_google_zxing_LuminanceSource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateBinarizer_Lcom_google_zxing_LuminanceSource_);
			return cb_createBinarizer_Lcom_google_zxing_LuminanceSource_;
		}

		static IntPtr n_CreateBinarizer_Lcom_google_zxing_LuminanceSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Zxing.Common.GlobalHistogramBinarizer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.GlobalHistogramBinarizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.LuminanceSource p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateBinarizer (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createBinarizer_Lcom_google_zxing_LuminanceSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GlobalHistogramBinarizer']/method[@name='createBinarizer' and count(parameter)=1 and parameter[1][@type='com.google.zxing.LuminanceSource']]"
		[Register ("createBinarizer", "(Lcom/google/zxing/LuminanceSource;)Lcom/google/zxing/Binarizer;", "GetCreateBinarizer_Lcom_google_zxing_LuminanceSource_Handler")]
		public override unsafe global::Com.Google.Zxing.Binarizer CreateBinarizer (global::Com.Google.Zxing.LuminanceSource p0)
		{
			if (id_createBinarizer_Lcom_google_zxing_LuminanceSource_ == IntPtr.Zero)
				id_createBinarizer_Lcom_google_zxing_LuminanceSource_ = JNIEnv.GetMethodID (class_ref, "createBinarizer", "(Lcom/google/zxing/LuminanceSource;)Lcom/google/zxing/Binarizer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Google.Zxing.Binarizer __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Binarizer> (JNIEnv.CallObjectMethod  (Handle, id_createBinarizer_Lcom_google_zxing_LuminanceSource_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Binarizer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createBinarizer", "(Lcom/google/zxing/LuminanceSource;)Lcom/google/zxing/Binarizer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getBlackRow_ILcom_google_zxing_common_BitArray_;
#pragma warning disable 0169
		static Delegate GetGetBlackRow_ILcom_google_zxing_common_BitArray_Handler ()
		{
			if (cb_getBlackRow_ILcom_google_zxing_common_BitArray_ == null)
				cb_getBlackRow_ILcom_google_zxing_common_BitArray_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GetBlackRow_ILcom_google_zxing_common_BitArray_);
			return cb_getBlackRow_ILcom_google_zxing_common_BitArray_;
		}

		static IntPtr n_GetBlackRow_ILcom_google_zxing_common_BitArray_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Zxing.Common.GlobalHistogramBinarizer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.GlobalHistogramBinarizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.Common.BitArray p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBlackRow (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBlackRow_ILcom_google_zxing_common_BitArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GlobalHistogramBinarizer']/method[@name='getBlackRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray']]"
		[Register ("getBlackRow", "(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;", "GetGetBlackRow_ILcom_google_zxing_common_BitArray_Handler")]
		public override unsafe global::Com.Google.Zxing.Common.BitArray GetBlackRow (int p0, global::Com.Google.Zxing.Common.BitArray p1)
		{
			if (id_getBlackRow_ILcom_google_zxing_common_BitArray_ == IntPtr.Zero)
				id_getBlackRow_ILcom_google_zxing_common_BitArray_ = JNIEnv.GetMethodID (class_ref, "getBlackRow", "(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Google.Zxing.Common.BitArray __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (JNIEnv.CallObjectMethod  (Handle, id_getBlackRow_ILcom_google_zxing_common_BitArray_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlackRow", "(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
