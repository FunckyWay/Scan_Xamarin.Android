using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']"
	[global::Android.Runtime.Register ("com/google/zxing/common/GridSampler", DoNotGenerateAcw=true)]
	public abstract partial class GridSampler : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/GridSampler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GridSampler); }
		}

		protected GridSampler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/constructor[@name='GridSampler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GridSampler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GridSampler)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::Com.Google.Zxing.Common.GridSampler Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/google/zxing/common/GridSampler;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/google/zxing/common/GridSampler;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.GridSampler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_checkAndNudgePoints_Lcom_google_zxing_common_BitMatrix_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/method[@name='checkAndNudgePoints' and count(parameter)=2 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='float[]']]"
		[Register ("checkAndNudgePoints", "(Lcom/google/zxing/common/BitMatrix;[F)V", "")]
		protected static unsafe void CheckAndNudgePoints (global::Com.Google.Zxing.Common.BitMatrix p0, float[] p1)
		{
			if (id_checkAndNudgePoints_Lcom_google_zxing_common_BitMatrix_arrayF == IntPtr.Zero)
				id_checkAndNudgePoints_Lcom_google_zxing_common_BitMatrix_arrayF = JNIEnv.GetStaticMethodID (class_ref, "checkAndNudgePoints", "(Lcom/google/zxing/common/BitMatrix;[F)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkAndNudgePoints_Lcom_google_zxing_common_BitMatrix_arrayF, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_;
#pragma warning disable 0169
		static Delegate GetSampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_Handler ()
		{
			if (cb_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_ == null)
				cb_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_SampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_);
			return cb_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_;
		}

		static IntPtr n_SampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Google.Zxing.Common.GridSampler __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.GridSampler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.Common.BitMatrix p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.Common.PerspectiveTransform p3 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.PerspectiveTransform> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SampleGrid (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/method[@name='sampleGrid' and count(parameter)=4 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.google.zxing.common.PerspectiveTransform']]"
		[Register ("sampleGrid", "(Lcom/google/zxing/common/BitMatrix;IILcom/google/zxing/common/PerspectiveTransform;)Lcom/google/zxing/common/BitMatrix;", "GetSampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_Handler")]
		public abstract global::Com.Google.Zxing.Common.BitMatrix SampleGrid (global::Com.Google.Zxing.Common.BitMatrix p0, int p1, int p2, global::Com.Google.Zxing.Common.PerspectiveTransform p3);

		static IntPtr id_setGridSampler_Lcom_google_zxing_common_GridSampler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/method[@name='setGridSampler' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.GridSampler']]"
		[Register ("setGridSampler", "(Lcom/google/zxing/common/GridSampler;)V", "")]
		public static unsafe void SetGridSampler (global::Com.Google.Zxing.Common.GridSampler p0)
		{
			if (id_setGridSampler_Lcom_google_zxing_common_GridSampler_ == IntPtr.Zero)
				id_setGridSampler_Lcom_google_zxing_common_GridSampler_ = JNIEnv.GetStaticMethodID (class_ref, "setGridSampler", "(Lcom/google/zxing/common/GridSampler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setGridSampler_Lcom_google_zxing_common_GridSampler_, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/common/GridSampler", DoNotGenerateAcw=true)]
	internal partial class GridSamplerInvoker : GridSampler {

		public GridSamplerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (GridSamplerInvoker); }
		}

		static IntPtr id_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='GridSampler']/method[@name='sampleGrid' and count(parameter)=4 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.google.zxing.common.PerspectiveTransform']]"
		[Register ("sampleGrid", "(Lcom/google/zxing/common/BitMatrix;IILcom/google/zxing/common/PerspectiveTransform;)Lcom/google/zxing/common/BitMatrix;", "GetSampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_Handler")]
		public override unsafe global::Com.Google.Zxing.Common.BitMatrix SampleGrid (global::Com.Google.Zxing.Common.BitMatrix p0, int p1, int p2, global::Com.Google.Zxing.Common.PerspectiveTransform p3)
		{
			if (id_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_ == IntPtr.Zero)
				id_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_ = JNIEnv.GetMethodID (class_ref, "sampleGrid", "(Lcom/google/zxing/common/BitMatrix;IILcom/google/zxing/common/PerspectiveTransform;)Lcom/google/zxing/common/BitMatrix;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Com.Google.Zxing.Common.BitMatrix __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod  (Handle, id_sampleGrid_Lcom_google_zxing_common_BitMatrix_IILcom_google_zxing_common_PerspectiveTransform_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
