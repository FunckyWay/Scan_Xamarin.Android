using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']"
	[global::Android.Runtime.Register ("com/google/zxing/ResultPoint", DoNotGenerateAcw=true)]
	public partial class ResultPoint : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/ResultPoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResultPoint); }
		}

		protected ResultPoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/constructor[@name='ResultPoint' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public unsafe ResultPoint (float p0, float p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ResultPoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(FF)V", __args);
					return;
				}

				if (id_ctor_FF == IntPtr.Zero)
					id_ctor_FF = JNIEnv.GetMethodID (class_ref, "<init>", "(FF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_FF, __args);
			} finally {
			}
		}

		static IntPtr id_distance_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='distance' and count(parameter)=2 and parameter[1][@type='com.google.zxing.ResultPoint'] and parameter[2][@type='com.google.zxing.ResultPoint']]"
		[Register ("distance", "(Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;)F", "")]
		public static unsafe float Distance (global::Com.Google.Zxing.ResultPoint p0, global::Com.Google.Zxing.ResultPoint p1)
		{
			if (id_distance_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_ == IntPtr.Zero)
				id_distance_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_ = JNIEnv.GetStaticMethodID (class_ref, "distance", "(Lcom/google/zxing/ResultPoint;Lcom/google/zxing/ResultPoint;)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_distance_Lcom_google_zxing_ResultPoint_Lcom_google_zxing_ResultPoint_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed unsafe bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()F", "")]
		public unsafe float GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()F");
			try {
				return JNIEnv.CallFloatMethod  (Handle, id_getX);
			} finally {
			}
		}

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()F", "")]
		public unsafe float GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()F");
			try {
				return JNIEnv.CallFloatMethod  (Handle, id_getY);
			} finally {
			}
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed unsafe int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_hashCode);
			} finally {
			}
		}

		static IntPtr id_orderBestPatterns_arrayLcom_google_zxing_ResultPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='orderBestPatterns' and count(parameter)=1 and parameter[1][@type='com.google.zxing.ResultPoint[]']]"
		[Register ("orderBestPatterns", "([Lcom/google/zxing/ResultPoint;)V", "")]
		public static unsafe void OrderBestPatterns (global::Com.Google.Zxing.ResultPoint[] p0)
		{
			if (id_orderBestPatterns_arrayLcom_google_zxing_ResultPoint_ == IntPtr.Zero)
				id_orderBestPatterns_arrayLcom_google_zxing_ResultPoint_ = JNIEnv.GetStaticMethodID (class_ref, "orderBestPatterns", "([Lcom/google/zxing/ResultPoint;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_orderBestPatterns_arrayLcom_google_zxing_ResultPoint_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='ResultPoint']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
