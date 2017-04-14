using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Aztec.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']"
	[global::Android.Runtime.Register ("com/google/zxing/aztec/encoder/AztecCode", DoNotGenerateAcw=true)]
	public sealed partial class AztecCode : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/aztec/encoder/AztecCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AztecCode); }
		}

		internal AztecCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/constructor[@name='AztecCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AztecCode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AztecCode)) {
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

		static IntPtr id_getCodeWords;
		static IntPtr id_setCodeWords_I;
		public unsafe int CodeWords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='getCodeWords' and count(parameter)=0]"
			[Register ("getCodeWords", "()I", "GetGetCodeWordsHandler")]
			get {
				if (id_getCodeWords == IntPtr.Zero)
					id_getCodeWords = JNIEnv.GetMethodID (class_ref, "getCodeWords", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getCodeWords);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='setCodeWords' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCodeWords", "(I)V", "GetSetCodeWords_IHandler")]
			set {
				if (id_setCodeWords_I == IntPtr.Zero)
					id_setCodeWords_I = JNIEnv.GetMethodID (class_ref, "setCodeWords", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setCodeWords_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isCompact;
		static IntPtr id_setCompact_Z;
		public unsafe bool Compact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='isCompact' and count(parameter)=0]"
			[Register ("isCompact", "()Z", "GetIsCompactHandler")]
			get {
				if (id_isCompact == IntPtr.Zero)
					id_isCompact = JNIEnv.GetMethodID (class_ref, "isCompact", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isCompact);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='setCompact' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCompact", "(Z)V", "GetSetCompact_ZHandler")]
			set {
				if (id_setCompact_Z == IntPtr.Zero)
					id_setCompact_Z = JNIEnv.GetMethodID (class_ref, "setCompact", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setCompact_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getLayers;
		static IntPtr id_setLayers_I;
		public unsafe int Layers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='getLayers' and count(parameter)=0]"
			[Register ("getLayers", "()I", "GetGetLayersHandler")]
			get {
				if (id_getLayers == IntPtr.Zero)
					id_getLayers = JNIEnv.GetMethodID (class_ref, "getLayers", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getLayers);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='setLayers' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLayers", "(I)V", "GetSetLayers_IHandler")]
			set {
				if (id_setLayers_I == IntPtr.Zero)
					id_setLayers_I = JNIEnv.GetMethodID (class_ref, "setLayers", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setLayers_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMatrix;
		static IntPtr id_setMatrix_Lcom_google_zxing_common_BitMatrix_;
		public unsafe global::Com.Google.Zxing.Common.BitMatrix Matrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='getMatrix' and count(parameter)=0]"
			[Register ("getMatrix", "()Lcom/google/zxing/common/BitMatrix;", "GetGetMatrixHandler")]
			get {
				if (id_getMatrix == IntPtr.Zero)
					id_getMatrix = JNIEnv.GetMethodID (class_ref, "getMatrix", "()Lcom/google/zxing/common/BitMatrix;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (JNIEnv.CallObjectMethod  (Handle, id_getMatrix), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='setMatrix' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
			[Register ("setMatrix", "(Lcom/google/zxing/common/BitMatrix;)V", "GetSetMatrix_Lcom_google_zxing_common_BitMatrix_Handler")]
			set {
				if (id_setMatrix_Lcom_google_zxing_common_BitMatrix_ == IntPtr.Zero)
					id_setMatrix_Lcom_google_zxing_common_BitMatrix_ = JNIEnv.GetMethodID (class_ref, "setMatrix", "(Lcom/google/zxing/common/BitMatrix;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setMatrix_Lcom_google_zxing_common_BitMatrix_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getSize;
		static IntPtr id_setSize_I;
		public unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSize);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSize", "(I)V", "GetSetSize_IHandler")]
			set {
				if (id_setSize_I == IntPtr.Zero)
					id_setSize_I = JNIEnv.GetMethodID (class_ref, "setSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setSize_I, __args);
				} finally {
				}
			}
		}

	}
}
