using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Pdf417 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']"
	[global::Android.Runtime.Register ("com/google/zxing/pdf417/PDF417ResultMetadata", DoNotGenerateAcw=true)]
	public sealed partial class PDF417ResultMetadata : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/pdf417/PDF417ResultMetadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDF417ResultMetadata); }
		}

		internal PDF417ResultMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/constructor[@name='PDF417ResultMetadata' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PDF417ResultMetadata ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PDF417ResultMetadata)) {
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

		static IntPtr id_getFileId;
		static IntPtr id_setFileId_Ljava_lang_String_;
		public unsafe string FileId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='getFileId' and count(parameter)=0]"
			[Register ("getFileId", "()Ljava/lang/String;", "GetGetFileIdHandler")]
			get {
				if (id_getFileId == IntPtr.Zero)
					id_getFileId = JNIEnv.GetMethodID (class_ref, "getFileId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFileId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='setFileId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFileId", "(Ljava/lang/String;)V", "GetSetFileId_Ljava_lang_String_Handler")]
			set {
				if (id_setFileId_Ljava_lang_String_ == IntPtr.Zero)
					id_setFileId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFileId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setFileId_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_isLastSegment;
		static IntPtr id_setLastSegment_Z;
		public unsafe bool LastSegment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='isLastSegment' and count(parameter)=0]"
			[Register ("isLastSegment", "()Z", "GetIsLastSegmentHandler")]
			get {
				if (id_isLastSegment == IntPtr.Zero)
					id_isLastSegment = JNIEnv.GetMethodID (class_ref, "isLastSegment", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isLastSegment);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='setLastSegment' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLastSegment", "(Z)V", "GetSetLastSegment_ZHandler")]
			set {
				if (id_setLastSegment_Z == IntPtr.Zero)
					id_setLastSegment_Z = JNIEnv.GetMethodID (class_ref, "setLastSegment", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setLastSegment_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getSegmentIndex;
		static IntPtr id_setSegmentIndex_I;
		public unsafe int SegmentIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='getSegmentIndex' and count(parameter)=0]"
			[Register ("getSegmentIndex", "()I", "GetGetSegmentIndexHandler")]
			get {
				if (id_getSegmentIndex == IntPtr.Zero)
					id_getSegmentIndex = JNIEnv.GetMethodID (class_ref, "getSegmentIndex", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSegmentIndex);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='setSegmentIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSegmentIndex", "(I)V", "GetSetSegmentIndex_IHandler")]
			set {
				if (id_setSegmentIndex_I == IntPtr.Zero)
					id_setSegmentIndex_I = JNIEnv.GetMethodID (class_ref, "setSegmentIndex", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setSegmentIndex_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getOptionalData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='getOptionalData' and count(parameter)=0]"
		[Register ("getOptionalData", "()[I", "")]
		public unsafe int[] GetOptionalData ()
		{
			if (id_getOptionalData == IntPtr.Zero)
				id_getOptionalData = JNIEnv.GetMethodID (class_ref, "getOptionalData", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getOptionalData), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_setOptionalData_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.pdf417']/class[@name='PDF417ResultMetadata']/method[@name='setOptionalData' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setOptionalData", "([I)V", "")]
		public unsafe void SetOptionalData (int[] p0)
		{
			if (id_setOptionalData_arrayI == IntPtr.Zero)
				id_setOptionalData_arrayI = JNIEnv.GetMethodID (class_ref, "setOptionalData", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_setOptionalData_arrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
