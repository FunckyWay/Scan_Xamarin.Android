using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Datamatrix.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.detector']/class[@name='Detector']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/detector/Detector", DoNotGenerateAcw=true)]
	public sealed partial class Detector : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.detector']/class[@name='Detector.ResultPointsAndTransitions']"
		[global::Android.Runtime.Register ("com/google/zxing/datamatrix/detector/Detector$ResultPointsAndTransitions", DoNotGenerateAcw=true)]
		public sealed partial class ResultPointsAndTransitions : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/zxing/datamatrix/detector/Detector$ResultPointsAndTransitions", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResultPointsAndTransitions); }
			}

			internal ResultPointsAndTransitions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getTransitions;
			public unsafe int Transitions {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.detector']/class[@name='Detector.ResultPointsAndTransitions']/method[@name='getTransitions' and count(parameter)=0]"
				[Register ("getTransitions", "()I", "GetGetTransitionsHandler")]
				get {
					if (id_getTransitions == IntPtr.Zero)
						id_getTransitions = JNIEnv.GetMethodID (class_ref, "getTransitions", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getTransitions);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.detector']/class[@name='Detector.ResultPointsAndTransitionsComparator']"
		[global::Android.Runtime.Register ("com/google/zxing/datamatrix/detector/Detector$ResultPointsAndTransitionsComparator", DoNotGenerateAcw=true)]
		public sealed partial class ResultPointsAndTransitionsComparator : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Util.IComparator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/zxing/datamatrix/detector/Detector$ResultPointsAndTransitionsComparator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResultPointsAndTransitionsComparator); }
			}

			internal ResultPointsAndTransitionsComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_compare_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.detector']/class[@name='Detector.ResultPointsAndTransitionsComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
			[Register ("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", "")]
			public unsafe int Compare (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			{
				if (id_compare_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					int __ret = JNIEnv.CallIntMethod  (Handle, id_compare_Ljava_lang_Object_Ljava_lang_Object_, __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/datamatrix/detector/Detector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Detector); }
		}

		internal Detector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_common_BitMatrix_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.datamatrix.detector']/class[@name='Detector']/constructor[@name='Detector' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;)V", "")]
		public unsafe Detector (global::Com.Google.Zxing.Common.BitMatrix p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Detector)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/common/BitMatrix;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/common/BitMatrix;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_common_BitMatrix_ == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_common_BitMatrix_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/common/BitMatrix;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_, __args);
			} finally {
			}
		}

		static IntPtr id_detect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.detector']/class[@name='Detector']/method[@name='detect' and count(parameter)=0]"
		[Register ("detect", "()Lcom/google/zxing/common/DetectorResult;", "")]
		public unsafe global::Com.Google.Zxing.Common.DetectorResult Detect ()
		{
			if (id_detect == IntPtr.Zero)
				id_detect = JNIEnv.GetMethodID (class_ref, "detect", "()Lcom/google/zxing/common/DetectorResult;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.DetectorResult> (JNIEnv.CallObjectMethod  (Handle, id_detect), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
