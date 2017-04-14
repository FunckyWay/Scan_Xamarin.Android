using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Datamatrix.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']"
	[global::Android.Runtime.Register ("com/google/zxing/datamatrix/decoder/Version", DoNotGenerateAcw=true)]
	public sealed partial class Version : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version.ECB']"
		[global::Android.Runtime.Register ("com/google/zxing/datamatrix/decoder/Version$ECB", DoNotGenerateAcw=true)]
		public sealed partial class ECB : global::Java.Lang.Object {

			internal ECB (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version.ECBlocks']"
		[global::Android.Runtime.Register ("com/google/zxing/datamatrix/decoder/Version$ECBlocks", DoNotGenerateAcw=true)]
		public sealed partial class ECBlocks : global::Java.Lang.Object {

			internal ECBlocks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/datamatrix/decoder/Version", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Version); }
		}

		internal Version (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDataRegionSizeColumns;
		public unsafe int DataRegionSizeColumns {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getDataRegionSizeColumns' and count(parameter)=0]"
			[Register ("getDataRegionSizeColumns", "()I", "GetGetDataRegionSizeColumnsHandler")]
			get {
				if (id_getDataRegionSizeColumns == IntPtr.Zero)
					id_getDataRegionSizeColumns = JNIEnv.GetMethodID (class_ref, "getDataRegionSizeColumns", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getDataRegionSizeColumns);
				} finally {
				}
			}
		}

		static IntPtr id_getDataRegionSizeRows;
		public unsafe int DataRegionSizeRows {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getDataRegionSizeRows' and count(parameter)=0]"
			[Register ("getDataRegionSizeRows", "()I", "GetGetDataRegionSizeRowsHandler")]
			get {
				if (id_getDataRegionSizeRows == IntPtr.Zero)
					id_getDataRegionSizeRows = JNIEnv.GetMethodID (class_ref, "getDataRegionSizeRows", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getDataRegionSizeRows);
				} finally {
				}
			}
		}

		static IntPtr id_getSymbolSizeColumns;
		public unsafe int SymbolSizeColumns {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getSymbolSizeColumns' and count(parameter)=0]"
			[Register ("getSymbolSizeColumns", "()I", "GetGetSymbolSizeColumnsHandler")]
			get {
				if (id_getSymbolSizeColumns == IntPtr.Zero)
					id_getSymbolSizeColumns = JNIEnv.GetMethodID (class_ref, "getSymbolSizeColumns", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSymbolSizeColumns);
				} finally {
				}
			}
		}

		static IntPtr id_getSymbolSizeRows;
		public unsafe int SymbolSizeRows {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getSymbolSizeRows' and count(parameter)=0]"
			[Register ("getSymbolSizeRows", "()I", "GetGetSymbolSizeRowsHandler")]
			get {
				if (id_getSymbolSizeRows == IntPtr.Zero)
					id_getSymbolSizeRows = JNIEnv.GetMethodID (class_ref, "getSymbolSizeRows", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSymbolSizeRows);
				} finally {
				}
			}
		}

		static IntPtr id_getTotalCodewords;
		public unsafe int TotalCodewords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getTotalCodewords' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getVersionNumber' and count(parameter)=0]"
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

		static IntPtr id_getVersionForDimensions_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.datamatrix.decoder']/class[@name='Version']/method[@name='getVersionForDimensions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getVersionForDimensions", "(II)Lcom/google/zxing/datamatrix/decoder/Version;", "")]
		public static unsafe global::Com.Google.Zxing.Datamatrix.Decoder.Version GetVersionForDimensions (int p0, int p1)
		{
			if (id_getVersionForDimensions_II == IntPtr.Zero)
				id_getVersionForDimensions_II = JNIEnv.GetStaticMethodID (class_ref, "getVersionForDimensions", "(II)Lcom/google/zxing/datamatrix/decoder/Version;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Datamatrix.Decoder.Version> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVersionForDimensions_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
