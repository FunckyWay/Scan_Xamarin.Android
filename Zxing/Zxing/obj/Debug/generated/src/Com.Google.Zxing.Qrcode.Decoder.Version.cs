using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Qrcode.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']"
	[global::Android.Runtime.Register ("com/google/zxing/qrcode/decoder/Version", DoNotGenerateAcw=true)]
	public sealed partial class Version : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECB']"
		[global::Android.Runtime.Register ("com/google/zxing/qrcode/decoder/Version$ECB", DoNotGenerateAcw=true)]
		public sealed partial class ECB : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/zxing/qrcode/decoder/Version$ECB", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ECB); }
			}

			internal ECB (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getCount;
			public unsafe int Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECB']/method[@name='getCount' and count(parameter)=0]"
				[Register ("getCount", "()I", "GetGetCountHandler")]
				get {
					if (id_getCount == IntPtr.Zero)
						id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getCount);
					} finally {
					}
				}
			}

			static IntPtr id_getDataCodewords;
			public unsafe int DataCodewords {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECB']/method[@name='getDataCodewords' and count(parameter)=0]"
				[Register ("getDataCodewords", "()I", "GetGetDataCodewordsHandler")]
				get {
					if (id_getDataCodewords == IntPtr.Zero)
						id_getDataCodewords = JNIEnv.GetMethodID (class_ref, "getDataCodewords", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getDataCodewords);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECBlocks']"
		[global::Android.Runtime.Register ("com/google/zxing/qrcode/decoder/Version$ECBlocks", DoNotGenerateAcw=true)]
		public sealed partial class ECBlocks : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/zxing/qrcode/decoder/Version$ECBlocks", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ECBlocks); }
			}

			internal ECBlocks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getECCodewordsPerBlock;
			public unsafe int ECCodewordsPerBlock {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECBlocks']/method[@name='getECCodewordsPerBlock' and count(parameter)=0]"
				[Register ("getECCodewordsPerBlock", "()I", "GetGetECCodewordsPerBlockHandler")]
				get {
					if (id_getECCodewordsPerBlock == IntPtr.Zero)
						id_getECCodewordsPerBlock = JNIEnv.GetMethodID (class_ref, "getECCodewordsPerBlock", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getECCodewordsPerBlock);
					} finally {
					}
				}
			}

			static IntPtr id_getNumBlocks;
			public unsafe int NumBlocks {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECBlocks']/method[@name='getNumBlocks' and count(parameter)=0]"
				[Register ("getNumBlocks", "()I", "GetGetNumBlocksHandler")]
				get {
					if (id_getNumBlocks == IntPtr.Zero)
						id_getNumBlocks = JNIEnv.GetMethodID (class_ref, "getNumBlocks", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getNumBlocks);
					} finally {
					}
				}
			}

			static IntPtr id_getTotalECCodewords;
			public unsafe int TotalECCodewords {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECBlocks']/method[@name='getTotalECCodewords' and count(parameter)=0]"
				[Register ("getTotalECCodewords", "()I", "GetGetTotalECCodewordsHandler")]
				get {
					if (id_getTotalECCodewords == IntPtr.Zero)
						id_getTotalECCodewords = JNIEnv.GetMethodID (class_ref, "getTotalECCodewords", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getTotalECCodewords);
					} finally {
					}
				}
			}

			static IntPtr id_getECBlocks;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version.ECBlocks']/method[@name='getECBlocks' and count(parameter)=0]"
			[Register ("getECBlocks", "()[Lcom/google/zxing/qrcode/decoder/Version$ECB;", "")]
			public unsafe global::Com.Google.Zxing.Qrcode.Decoder.Version.ECB[] GetECBlocks ()
			{
				if (id_getECBlocks == IntPtr.Zero)
					id_getECBlocks = JNIEnv.GetMethodID (class_ref, "getECBlocks", "()[Lcom/google/zxing/qrcode/decoder/Version$ECB;");
				try {
					return (global::Com.Google.Zxing.Qrcode.Decoder.Version.ECB[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getECBlocks), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Zxing.Qrcode.Decoder.Version.ECB));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/qrcode/decoder/Version", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Version); }
		}

		internal Version (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDimensionForVersion;
		public unsafe int DimensionForVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getDimensionForVersion' and count(parameter)=0]"
			[Register ("getDimensionForVersion", "()I", "GetGetDimensionForVersionHandler")]
			get {
				if (id_getDimensionForVersion == IntPtr.Zero)
					id_getDimensionForVersion = JNIEnv.GetMethodID (class_ref, "getDimensionForVersion", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getDimensionForVersion);
				} finally {
				}
			}
		}

		static IntPtr id_getTotalCodewords;
		public unsafe int TotalCodewords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getTotalCodewords' and count(parameter)=0]"
			[Register ("getTotalCodewords", "()I", "GetGetTotalCodewordsHandler")]
			get {
				if (id_getTotalCodewords == IntPtr.Zero)
					id_getTotalCodewords = JNIEnv.GetMethodID (class_ref, "getTotalCodewords", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getTotalCodewords);
				} finally {
				}
			}
		}

		static IntPtr id_getVersionNumber;
		public unsafe int VersionNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getVersionNumber' and count(parameter)=0]"
			[Register ("getVersionNumber", "()I", "GetGetVersionNumberHandler")]
			get {
				if (id_getVersionNumber == IntPtr.Zero)
					id_getVersionNumber = JNIEnv.GetMethodID (class_ref, "getVersionNumber", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getVersionNumber);
				} finally {
				}
			}
		}

		static IntPtr id_getAlignmentPatternCenters;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getAlignmentPatternCenters' and count(parameter)=0]"
		[Register ("getAlignmentPatternCenters", "()[I", "")]
		public unsafe int[] GetAlignmentPatternCenters ()
		{
			if (id_getAlignmentPatternCenters == IntPtr.Zero)
				id_getAlignmentPatternCenters = JNIEnv.GetMethodID (class_ref, "getAlignmentPatternCenters", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAlignmentPatternCenters), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_getECBlocksForLevel_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getECBlocksForLevel' and count(parameter)=1 and parameter[1][@type='com.google.zxing.qrcode.decoder.ErrorCorrectionLevel']]"
		[Register ("getECBlocksForLevel", "(Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;)Lcom/google/zxing/qrcode/decoder/Version$ECBlocks;", "")]
		public unsafe global::Com.Google.Zxing.Qrcode.Decoder.Version.ECBlocks GetECBlocksForLevel (global::Com.Google.Zxing.Qrcode.Decoder.ErrorCorrectionLevel p0)
		{
			if (id_getECBlocksForLevel_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_ == IntPtr.Zero)
				id_getECBlocksForLevel_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_ = JNIEnv.GetMethodID (class_ref, "getECBlocksForLevel", "(Lcom/google/zxing/qrcode/decoder/ErrorCorrectionLevel;)Lcom/google/zxing/qrcode/decoder/Version$ECBlocks;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Zxing.Qrcode.Decoder.Version.ECBlocks __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Version.ECBlocks> (JNIEnv.CallObjectMethod  (Handle, id_getECBlocksForLevel_Lcom_google_zxing_qrcode_decoder_ErrorCorrectionLevel_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getProvisionalVersionForDimension_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getProvisionalVersionForDimension' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getProvisionalVersionForDimension", "(I)Lcom/google/zxing/qrcode/decoder/Version;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.Version GetProvisionalVersionForDimension (int p0)
		{
			if (id_getProvisionalVersionForDimension_I == IntPtr.Zero)
				id_getProvisionalVersionForDimension_I = JNIEnv.GetStaticMethodID (class_ref, "getProvisionalVersionForDimension", "(I)Lcom/google/zxing/qrcode/decoder/Version;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Version> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProvisionalVersionForDimension_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getVersionForNumber_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.qrcode.decoder']/class[@name='Version']/method[@name='getVersionForNumber' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getVersionForNumber", "(I)Lcom/google/zxing/qrcode/decoder/Version;", "")]
		public static unsafe global::Com.Google.Zxing.Qrcode.Decoder.Version GetVersionForNumber (int p0)
		{
			if (id_getVersionForNumber_I == IntPtr.Zero)
				id_getVersionForNumber_I = JNIEnv.GetStaticMethodID (class_ref, "getVersionForNumber", "(I)Lcom/google/zxing/qrcode/decoder/Version;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Qrcode.Decoder.Version> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVersionForNumber_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
