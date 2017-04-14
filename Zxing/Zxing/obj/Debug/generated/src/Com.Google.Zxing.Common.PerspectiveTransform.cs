using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='PerspectiveTransform']"
	[global::Android.Runtime.Register ("com/google/zxing/common/PerspectiveTransform", DoNotGenerateAcw=true)]
	public sealed partial class PerspectiveTransform : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/PerspectiveTransform", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PerspectiveTransform); }
		}

		internal PerspectiveTransform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_quadrilateralToSquare_FFFFFFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='PerspectiveTransform']/method[@name='quadrilateralToSquare' and count(parameter)=8 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float']]"
		[Register ("quadrilateralToSquare", "(FFFFFFFF)Lcom/google/zxing/common/PerspectiveTransform;", "")]
		public static unsafe global::Com.Google.Zxing.Common.PerspectiveTransform QuadrilateralToSquare (float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7)
		{
			if (id_quadrilateralToSquare_FFFFFFFF == IntPtr.Zero)
				id_quadrilateralToSquare_FFFFFFFF = JNIEnv.GetStaticMethodID (class_ref, "quadrilateralToSquare", "(FFFFFFFF)Lcom/google/zxing/common/PerspectiveTransform;");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.PerspectiveTransform> (JNIEnv.CallStaticObjectMethod  (class_ref, id_quadrilateralToSquare_FFFFFFFF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_squareToQuadrilateral_FFFFFFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='PerspectiveTransform']/method[@name='squareToQuadrilateral' and count(parameter)=8 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float']]"
		[Register ("squareToQuadrilateral", "(FFFFFFFF)Lcom/google/zxing/common/PerspectiveTransform;", "")]
		public static unsafe global::Com.Google.Zxing.Common.PerspectiveTransform SquareToQuadrilateral (float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7)
		{
			if (id_squareToQuadrilateral_FFFFFFFF == IntPtr.Zero)
				id_squareToQuadrilateral_FFFFFFFF = JNIEnv.GetStaticMethodID (class_ref, "squareToQuadrilateral", "(FFFFFFFF)Lcom/google/zxing/common/PerspectiveTransform;");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.PerspectiveTransform> (JNIEnv.CallStaticObjectMethod  (class_ref, id_squareToQuadrilateral_FFFFFFFF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_transformPoints_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='PerspectiveTransform']/method[@name='transformPoints' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("transformPoints", "([F)V", "")]
		public unsafe void TransformPoints (float[] p0)
		{
			if (id_transformPoints_arrayF == IntPtr.Zero)
				id_transformPoints_arrayF = JNIEnv.GetMethodID (class_ref, "transformPoints", "([F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_transformPoints_arrayF, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_transformPoints_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='PerspectiveTransform']/method[@name='transformPoints' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register ("transformPoints", "([F[F)V", "")]
		public unsafe void TransformPoints (float[] p0, float[] p1)
		{
			if (id_transformPoints_arrayFarrayF == IntPtr.Zero)
				id_transformPoints_arrayFarrayF = JNIEnv.GetMethodID (class_ref, "transformPoints", "([F[F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_transformPoints_arrayFarrayF, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
