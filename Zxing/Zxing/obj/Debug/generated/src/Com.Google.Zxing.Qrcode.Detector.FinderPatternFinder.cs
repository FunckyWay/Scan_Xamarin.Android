using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Qrcode.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/detector/FinderPatternFinder", DoNotGenerateAcw=true)]
	public partial class FinderPatternFinder : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/field[@name='MAX_MODULES']"
		[Register ("MAX_MODULES")]
		protected const int MaxModules = (int) 57;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/field[@name='MIN_SKIP']"
		[Register ("MIN_SKIP")]
		protected const int MinSkip = (int) 3;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder.CenterComparator']"
		[global::Android.Runtime.Register ("com/google/zxing/qrcode/detector/FinderPatternFinder$CenterComparator", DoNotGenerateAcw=true)]
		public sealed partial class CenterComparator : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Util.IComparator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/zxing/qrcode/detector/FinderPatternFinder$CenterComparator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CenterComparator); }
			}

			internal CenterComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_compare_Lcom_google_zxing_qrcode_detector_FinderPattern_Lcom_google_zxing_qrcode_detector_FinderPattern_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder.CenterComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='com.google.zxing.qrcode.detector.FinderPattern'] and parameter[2][@type='com.google.zxing.qrcode.detector.FinderPattern']]"
			[Register ("compare", "(Lcom/google/zxing/qrcode/detector/FinderPattern;Lcom/google/zxing/qrcode/detector/FinderPattern;)I", "")]
			public unsafe int Compare (global::Com.Google.Zxing.Qrcode.Detector.FinderPattern p0, global::Com.Google.Zxing.Qrcode.Detector.FinderPattern p1)
			{
				if (id_compare_Lcom_google_zxing_qrcode_detector_FinderPattern_Lcom_google_zxing_qrcode_detector_FinderPattern_ == IntPtr.Zero)
					id_compare_Lcom_google_zxing_qrcode_detector_FinderPattern_Lcom_google_zxing_qrcode_detector_FinderPattern_ = JNIEnv.GetMethodID (class_ref, "compare", "(Lcom/google/zxing/qrcode/detector/FinderPattern;Lcom/google/zxing/qrcode/detector/FinderPattern;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					int __ret = JNIEnv.CallIntMethod  (Handle, id_compare_Lcom_google_zxing_qrcode_detector_FinderPattern_Lcom_google_zxing_qrcode_detector_FinderPattern_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_compare_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder.CenterComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder.FurthestFromAverageComparator']"
		[global::Android.Runtime.Register ("com/google/zxing/qrcode/detector/FinderPatternFinder$FurthestFromAverageComparator", DoNotGenerateAcw=true)]
		public sealed partial class FurthestFromAverageComparator : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Util.IComparator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/zxing/qrcode/detector/FinderPatternFinder$FurthestFromAverageComparator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FurthestFromAverageComparator); }
			}

			internal FurthestFromAverageComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_compare_Lcom_google_zxing_qrcode_detector_FinderPattern_Lcom_google_zxing_qrcode_detector_FinderPattern_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder.FurthestFromAverageComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='com.google.zxing.qrcode.detector.FinderPattern'] and parameter[2][@type='com.google.zxing.qrcode.detector.FinderPattern']]"
			[Register ("compare", "(Lcom/google/zxing/qrcode/detector/FinderPattern;Lcom/google/zxing/qrcode/detector/FinderPattern;)I", "")]
			public unsafe int Compare (global::Com.Google.Zxing.Qrcode.Detector.FinderPattern p0, global::Com.Google.Zxing.Qrcode.Detector.FinderPattern p1)
			{
				if (id_compare_Lcom_google_zxing_qrcode_detector_FinderPattern_Lcom_google_zxing_qrcode_detector_FinderPattern_ == IntPtr.Zero)
					id_compare_Lcom_google_zxing_qrcode_detector_FinderPattern_Lcom_google_zxing_qrcode_detector_FinderPattern_ = JNIEnv.GetMethodID (class_ref, "compare", "(Lcom/google/zxing/qrcode/detector/FinderPattern;Lcom/google/zxing/qrcode/detector/FinderPattern;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					int __ret = JNIEnv.CallIntMethod  (Handle, id_compare_Lcom_google_zxing_qrcode_detector_FinderPattern_Lcom_google_zxing_qrcode_detector_FinderPattern_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_compare_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder.FurthestFromAverageComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
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
				return JNIEnv.FindClass ("com/google/zxing/qrcode/detector/FinderPatternFinder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FinderPatternFinder); }
		}

		protected FinderPatternFinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_zxing_common_BitMatrix_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/constructor[@name='FinderPatternFinder' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;)V", "")]
		public unsafe FinderPatternFinder (global::Com.Google.Zxing.Common.BitMatrix p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FinderPatternFinder)) {
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

		static IntPtr id_ctor_Lcom_google_zxing_common_BitMatrix_Lcom_google_zxing_ResultPointCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/constructor[@name='FinderPatternFinder' and count(parameter)=2 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='com.google.zxing.ResultPointCallback']]"
		[Register (".ctor", "(Lcom/google/zxing/common/BitMatrix;Lcom/google/zxing/ResultPointCallback;)V", "")]
		public unsafe FinderPatternFinder (global::Com.Google.Zxing.Common.BitMatrix p0, global::Com.Google.Zxing.IResultPointCallback p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FinderPatternFinder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/zxing/common/BitMatrix;Lcom/google/zxing/ResultPointCallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/google/zxing/common/BitMatrix;Lcom/google/zxing/ResultPointCallback;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_zxing_common_BitMatrix_Lcom_google_zxing_ResultPointCallback_ == IntPtr.Zero)
					id_ctor_Lcom_google_zxing_common_BitMatrix_Lcom_google_zxing_ResultPointCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/zxing/common/BitMatrix;Lcom/google/zxing/ResultPointCallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_Lcom_google_zxing_ResultPointCallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_google_zxing_common_BitMatrix_Lcom_google_zxing_ResultPointCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_getImage;
		protected unsafe global::Com.Google.Zxing.Common.BitMatrix Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Lcom/google/zxing/common/BitMatrix;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Lcom/google/zxing/common/BitMatrix;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod  (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPossibleCenters;
		protected unsafe global::System.Collections.Generic.IList<global::Com.Google.Zxing.Qrcode.Detector.FinderPattern> PossibleCenters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/method[@name='getPossibleCenters' and count(parameter)=0]"
			[Register ("getPossibleCenters", "()Ljava/util/List;", "GetGetPossibleCentersHandler")]
			get {
				if (id_getPossibleCenters == IntPtr.Zero)
					id_getPossibleCenters = JNIEnv.GetMethodID (class_ref, "getPossibleCenters", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Google.Zxing.Qrcode.Detector.FinderPattern>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPossibleCenters), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_foundPatternCross_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/method[@name='foundPatternCross' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("foundPatternCross", "([I)Z", "")]
		protected static unsafe bool FoundPatternCross (int[] p0)
		{
			if (id_foundPatternCross_arrayI == IntPtr.Zero)
				id_foundPatternCross_arrayI = JNIEnv.GetStaticMethodID (class_ref, "foundPatternCross", "([I)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_foundPatternCross_arrayI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_handlePossibleCenter_arrayIIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.detector']/class[@name='FinderPatternFinder']/method[@name='handlePossibleCenter' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("handlePossibleCenter", "([IIIZ)Z", "")]
		protected unsafe bool HandlePossibleCenter (int[] p0, int p1, int p2, bool p3)
		{
			if (id_handlePossibleCenter_arrayIIIZ == IntPtr.Zero)
				id_handlePossibleCenter_arrayIIIZ = JNIEnv.GetMethodID (class_ref, "handlePossibleCenter", "([IIIZ)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_handlePossibleCenter_arrayIIIZ, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
