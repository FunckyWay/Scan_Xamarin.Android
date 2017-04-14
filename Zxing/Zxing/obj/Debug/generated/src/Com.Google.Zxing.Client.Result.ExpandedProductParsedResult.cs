using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/ExpandedProductParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class ExpandedProductParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/field[@name='KILOGRAM']"
		[Register ("KILOGRAM")]
		public const string Kilogram = (string) "KG";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/field[@name='POUND']"
		[Register ("POUND")]
		public const string Pound = (string) "LB";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/client/result/ExpandedProductParsedResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExpandedProductParsedResult); }
		}

		internal ExpandedProductParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getBestBeforeDate;
		public unsafe string BestBeforeDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getBestBeforeDate' and count(parameter)=0]"
			[Register ("getBestBeforeDate", "()Ljava/lang/String;", "GetGetBestBeforeDateHandler")]
			get {
				if (id_getBestBeforeDate == IntPtr.Zero)
					id_getBestBeforeDate = JNIEnv.GetMethodID (class_ref, "getBestBeforeDate", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBestBeforeDate), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDisplayResult;
		public override unsafe string DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
			[Register ("getDisplayResult", "()Ljava/lang/String;", "GetGetDisplayResultHandler")]
			get {
				if (id_getDisplayResult == IntPtr.Zero)
					id_getDisplayResult = JNIEnv.GetMethodID (class_ref, "getDisplayResult", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDisplayResult), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getExpirationDate;
		public unsafe string ExpirationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getExpirationDate' and count(parameter)=0]"
			[Register ("getExpirationDate", "()Ljava/lang/String;", "GetGetExpirationDateHandler")]
			get {
				if (id_getExpirationDate == IntPtr.Zero)
					id_getExpirationDate = JNIEnv.GetMethodID (class_ref, "getExpirationDate", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getExpirationDate), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getLotNumber;
		public unsafe string LotNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getLotNumber' and count(parameter)=0]"
			[Register ("getLotNumber", "()Ljava/lang/String;", "GetGetLotNumberHandler")]
			get {
				if (id_getLotNumber == IntPtr.Zero)
					id_getLotNumber = JNIEnv.GetMethodID (class_ref, "getLotNumber", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLotNumber), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPackagingDate;
		public unsafe string PackagingDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getPackagingDate' and count(parameter)=0]"
			[Register ("getPackagingDate", "()Ljava/lang/String;", "GetGetPackagingDateHandler")]
			get {
				if (id_getPackagingDate == IntPtr.Zero)
					id_getPackagingDate = JNIEnv.GetMethodID (class_ref, "getPackagingDate", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPackagingDate), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPrice;
		public unsafe string Price {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getPrice' and count(parameter)=0]"
			[Register ("getPrice", "()Ljava/lang/String;", "GetGetPriceHandler")]
			get {
				if (id_getPrice == IntPtr.Zero)
					id_getPrice = JNIEnv.GetMethodID (class_ref, "getPrice", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPrice), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPriceCurrency;
		public unsafe string PriceCurrency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getPriceCurrency' and count(parameter)=0]"
			[Register ("getPriceCurrency", "()Ljava/lang/String;", "GetGetPriceCurrencyHandler")]
			get {
				if (id_getPriceCurrency == IntPtr.Zero)
					id_getPriceCurrency = JNIEnv.GetMethodID (class_ref, "getPriceCurrency", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPriceCurrency), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPriceIncrement;
		public unsafe string PriceIncrement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getPriceIncrement' and count(parameter)=0]"
			[Register ("getPriceIncrement", "()Ljava/lang/String;", "GetGetPriceIncrementHandler")]
			get {
				if (id_getPriceIncrement == IntPtr.Zero)
					id_getPriceIncrement = JNIEnv.GetMethodID (class_ref, "getPriceIncrement", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPriceIncrement), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getProductID;
		public unsafe string ProductID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getProductID' and count(parameter)=0]"
			[Register ("getProductID", "()Ljava/lang/String;", "GetGetProductIDHandler")]
			get {
				if (id_getProductID == IntPtr.Zero)
					id_getProductID = JNIEnv.GetMethodID (class_ref, "getProductID", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProductID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getProductionDate;
		public unsafe string ProductionDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getProductionDate' and count(parameter)=0]"
			[Register ("getProductionDate", "()Ljava/lang/String;", "GetGetProductionDateHandler")]
			get {
				if (id_getProductionDate == IntPtr.Zero)
					id_getProductionDate = JNIEnv.GetMethodID (class_ref, "getProductionDate", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProductionDate), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRawText;
		public unsafe string RawText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getRawText' and count(parameter)=0]"
			[Register ("getRawText", "()Ljava/lang/String;", "GetGetRawTextHandler")]
			get {
				if (id_getRawText == IntPtr.Zero)
					id_getRawText = JNIEnv.GetMethodID (class_ref, "getRawText", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRawText), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSscc;
		public unsafe string Sscc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getSscc' and count(parameter)=0]"
			[Register ("getSscc", "()Ljava/lang/String;", "GetGetSsccHandler")]
			get {
				if (id_getSscc == IntPtr.Zero)
					id_getSscc = JNIEnv.GetMethodID (class_ref, "getSscc", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSscc), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getUncommonAIs;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> UncommonAIs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getUncommonAIs' and count(parameter)=0]"
			[Register ("getUncommonAIs", "()Ljava/util/Map;", "GetGetUncommonAIsHandler")]
			get {
				if (id_getUncommonAIs == IntPtr.Zero)
					id_getUncommonAIs = JNIEnv.GetMethodID (class_ref, "getUncommonAIs", "()Ljava/util/Map;");
				try {
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getUncommonAIs), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getWeight;
		public unsafe string Weight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getWeight' and count(parameter)=0]"
			[Register ("getWeight", "()Ljava/lang/String;", "GetGetWeightHandler")]
			get {
				if (id_getWeight == IntPtr.Zero)
					id_getWeight = JNIEnv.GetMethodID (class_ref, "getWeight", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getWeight), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getWeightIncrement;
		public unsafe string WeightIncrement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getWeightIncrement' and count(parameter)=0]"
			[Register ("getWeightIncrement", "()Ljava/lang/String;", "GetGetWeightIncrementHandler")]
			get {
				if (id_getWeightIncrement == IntPtr.Zero)
					id_getWeightIncrement = JNIEnv.GetMethodID (class_ref, "getWeightIncrement", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getWeightIncrement), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getWeightType;
		public unsafe string WeightType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='ExpandedProductParsedResult']/method[@name='getWeightType' and count(parameter)=0]"
			[Register ("getWeightType", "()Ljava/lang/String;", "GetGetWeightTypeHandler")]
			get {
				if (id_getWeightType == IntPtr.Zero)
					id_getWeightType = JNIEnv.GetMethodID (class_ref, "getWeightType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getWeightType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
