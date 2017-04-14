using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Common.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='MathUtils']"
	[global::Android.Runtime.Register ("com/google/zxing/common/detector/MathUtils", DoNotGenerateAcw=true)]
	public sealed partial class MathUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/common/detector/MathUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MathUtils); }
		}

		internal MathUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_distance_FFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='MathUtils']/method[@name='distance' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("distance", "(FFFF)F", "")]
		public static unsafe float Distance (float p0, float p1, float p2, float p3)
		{
			if (id_distance_FFFF == IntPtr.Zero)
				id_distance_FFFF = JNIEnv.GetStaticMethodID (class_ref, "distance", "(FFFF)F");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_distance_FFFF, __args);
			} finally {
			}
		}

		static IntPtr id_distance_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='MathUtils']/method[@name='distance' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("distance", "(IIII)F", "")]
		public static unsafe float Distance (int p0, int p1, int p2, int p3)
		{
			if (id_distance_IIII == IntPtr.Zero)
				id_distance_IIII = JNIEnv.GetStaticMethodID (class_ref, "distance", "(IIII)F");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_distance_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_round_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='MathUtils']/method[@name='round' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("round", "(F)I", "")]
		public static unsafe int Round (float p0)
		{
			if (id_round_F == IntPtr.Zero)
				id_round_F = JNIEnv.GetStaticMethodID (class_ref, "round", "(F)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_round_F, __args);
			} finally {
			}
		}

	}
}
