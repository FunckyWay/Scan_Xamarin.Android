using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Oned.Rss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='FinderPattern']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/rss/FinderPattern", DoNotGenerateAcw=true)]
	public sealed partial class FinderPattern : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/oned/rss/FinderPattern", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FinderPattern); }
		}

		internal FinderPattern (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IarrayIIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='FinderPattern']/constructor[@name='FinderPattern' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(I[IIII)V", "")]
		public unsafe FinderPattern (int p0, int[] p1, int p2, int p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (FinderPattern)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I[IIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I[IIII)V", __args);
					return;
				}

				if (id_ctor_IarrayIIII == IntPtr.Zero)
					id_ctor_IarrayIIII = JNIEnv.GetMethodID (class_ref, "<init>", "(I[IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayIIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IarrayIIII, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_getValue;
		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='FinderPattern']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getValue);
				} finally {
				}
			}
		}

		static IntPtr id_getResultPoints;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='FinderPattern']/method[@name='getResultPoints' and count(parameter)=0]"
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

		static IntPtr id_getStartEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='FinderPattern']/method[@name='getStartEnd' and count(parameter)=0]"
		[Register ("getStartEnd", "()[I", "")]
		public unsafe int[] GetStartEnd ()
		{
			if (id_getStartEnd == IntPtr.Zero)
				id_getStartEnd = JNIEnv.GetMethodID (class_ref, "getStartEnd", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getStartEnd), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

	}
}
