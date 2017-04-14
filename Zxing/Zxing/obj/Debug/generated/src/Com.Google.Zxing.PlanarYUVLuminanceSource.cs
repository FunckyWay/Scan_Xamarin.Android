using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']"
	[global::Android.Runtime.Register ("com/google/zxing/PlanarYUVLuminanceSource", DoNotGenerateAcw=true)]
	public sealed partial class PlanarYUVLuminanceSource : global::Com.Google.Zxing.LuminanceSource {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/PlanarYUVLuminanceSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlanarYUVLuminanceSource); }
		}

		internal PlanarYUVLuminanceSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBIIIIIIZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']/constructor[@name='PlanarYUVLuminanceSource' and count(parameter)=8 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='boolean']]"
		[Register (".ctor", "([BIIIIIIZ)V", "")]
		public unsafe PlanarYUVLuminanceSource (byte[] p0, int p1, int p2, int p3, int p4, int p5, int p6, bool p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				if (GetType () != typeof (PlanarYUVLuminanceSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BIIIIIIZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([BIIIIIIZ)V", __args);
					return;
				}

				if (id_ctor_arrayBIIIIIIZ == IntPtr.Zero)
					id_ctor_arrayBIIIIIIZ = JNIEnv.GetMethodID (class_ref, "<init>", "([BIIIIIIZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBIIIIIIZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayBIIIIIIZ, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getThumbnailHeight;
		public unsafe int ThumbnailHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']/method[@name='getThumbnailHeight' and count(parameter)=0]"
			[Register ("getThumbnailHeight", "()I", "GetGetThumbnailHeightHandler")]
			get {
				if (id_getThumbnailHeight == IntPtr.Zero)
					id_getThumbnailHeight = JNIEnv.GetMethodID (class_ref, "getThumbnailHeight", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getThumbnailHeight);
				} finally {
				}
			}
		}

		static IntPtr id_getThumbnailWidth;
		public unsafe int ThumbnailWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']/method[@name='getThumbnailWidth' and count(parameter)=0]"
			[Register ("getThumbnailWidth", "()I", "GetGetThumbnailWidthHandler")]
			get {
				if (id_getThumbnailWidth == IntPtr.Zero)
					id_getThumbnailWidth = JNIEnv.GetMethodID (class_ref, "getThumbnailWidth", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getThumbnailWidth);
				} finally {
				}
			}
		}

		static IntPtr id_getMatrix;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']/method[@name='getMatrix' and count(parameter)=0]"
		[Register ("getMatrix", "()[B", "")]
		public override unsafe byte[] GetMatrix ()
		{
			if (id_getMatrix == IntPtr.Zero)
				id_getMatrix = JNIEnv.GetMethodID (class_ref, "getMatrix", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getMatrix), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getRow_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']/method[@name='getRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("getRow", "(I[B)[B", "")]
		public override unsafe byte[] GetRow (int p0, byte[] p1)
		{
			if (id_getRow_IarrayB == IntPtr.Zero)
				id_getRow_IarrayB = JNIEnv.GetMethodID (class_ref, "getRow", "(I[B)[B");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getRow_IarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_renderThumbnail;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']/method[@name='renderThumbnail' and count(parameter)=0]"
		[Register ("renderThumbnail", "()[I", "")]
		public unsafe int[] RenderThumbnail ()
		{
			if (id_renderThumbnail == IntPtr.Zero)
				id_renderThumbnail = JNIEnv.GetMethodID (class_ref, "renderThumbnail", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_renderThumbnail), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

	}
}
