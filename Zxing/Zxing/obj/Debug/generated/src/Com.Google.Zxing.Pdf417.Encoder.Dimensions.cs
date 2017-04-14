using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Pdf417.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Dimensions']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/encoder/Dimensions", DoNotGenerateAcw=true)]
	public sealed partial class Dimensions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/pdf417/encoder/Dimensions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Dimensions); }
		}

		internal Dimensions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Dimensions']/constructor[@name='Dimensions' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe Dimensions (int p0, int p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (Dimensions)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIII)V", __args);
					return;
				}

				if (id_ctor_IIII == IntPtr.Zero)
					id_ctor_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_getMaxCols;
		public unsafe int MaxCols {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Dimensions']/method[@name='getMaxCols' and count(parameter)=0]"
			[Register ("getMaxCols", "()I", "GetGetMaxColsHandler")]
			get {
				if (id_getMaxCols == IntPtr.Zero)
					id_getMaxCols = JNIEnv.GetMethodID (class_ref, "getMaxCols", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getMaxCols);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxRows;
		public unsafe int MaxRows {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Dimensions']/method[@name='getMaxRows' and count(parameter)=0]"
			[Register ("getMaxRows", "()I", "GetGetMaxRowsHandler")]
			get {
				if (id_getMaxRows == IntPtr.Zero)
					id_getMaxRows = JNIEnv.GetMethodID (class_ref, "getMaxRows", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getMaxRows);
				} finally {
				}
			}
		}

		static IntPtr id_getMinCols;
		public unsafe int MinCols {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Dimensions']/method[@name='getMinCols' and count(parameter)=0]"
			[Register ("getMinCols", "()I", "GetGetMinColsHandler")]
			get {
				if (id_getMinCols == IntPtr.Zero)
					id_getMinCols = JNIEnv.GetMethodID (class_ref, "getMinCols", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getMinCols);
				} finally {
				}
			}
		}

		static IntPtr id_getMinRows;
		public unsafe int MinRows {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417.encoder']/class[@name='Dimensions']/method[@name='getMinRows' and count(parameter)=0]"
			[Register ("getMinRows", "()I", "GetGetMinRowsHandler")]
			get {
				if (id_getMinRows == IntPtr.Zero)
					id_getMinRows = JNIEnv.GetMethodID (class_ref, "getMinRows", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getMinRows);
				} finally {
				}
			}
		}

	}
}
