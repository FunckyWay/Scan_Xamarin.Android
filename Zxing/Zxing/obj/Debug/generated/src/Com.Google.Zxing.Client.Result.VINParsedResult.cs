using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/VINParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class VINParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/client/result/VINParsedResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VINParsedResult); }
		}

		internal VINParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ICLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/constructor[@name='VINParsedResult' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='int'] and parameter[8][@type='char'] and parameter[9][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ICLjava/lang/String;)V", "")]
		public unsafe VINParsedResult (string p0, string p1, string p2, string p3, string p4, string p5, int p6, char p7, string p8)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (native_p8);
				if (GetType () != typeof (VINParsedResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ICLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ICLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ICLjava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ICLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ICLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ICLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ICLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p8);
			}
		}

		static IntPtr id_getCountryCode;
		public unsafe string CountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getCountryCode' and count(parameter)=0]"
			[Register ("getCountryCode", "()Ljava/lang/String;", "GetGetCountryCodeHandler")]
			get {
				if (id_getCountryCode == IntPtr.Zero)
					id_getCountryCode = JNIEnv.GetMethodID (class_ref, "getCountryCode", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCountryCode), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDisplayResult;
		public override unsafe string DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
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

		static IntPtr id_getModelYear;
		public unsafe int ModelYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getModelYear' and count(parameter)=0]"
			[Register ("getModelYear", "()I", "GetGetModelYearHandler")]
			get {
				if (id_getModelYear == IntPtr.Zero)
					id_getModelYear = JNIEnv.GetMethodID (class_ref, "getModelYear", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getModelYear);
				} finally {
				}
			}
		}

		static IntPtr id_getPlantCode;
		public unsafe char PlantCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getPlantCode' and count(parameter)=0]"
			[Register ("getPlantCode", "()C", "GetGetPlantCodeHandler")]
			get {
				if (id_getPlantCode == IntPtr.Zero)
					id_getPlantCode = JNIEnv.GetMethodID (class_ref, "getPlantCode", "()C");
				try {
					return JNIEnv.CallCharMethod  (Handle, id_getPlantCode);
				} finally {
				}
			}
		}

		static IntPtr id_getSequentialNumber;
		public unsafe string SequentialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getSequentialNumber' and count(parameter)=0]"
			[Register ("getSequentialNumber", "()Ljava/lang/String;", "GetGetSequentialNumberHandler")]
			get {
				if (id_getSequentialNumber == IntPtr.Zero)
					id_getSequentialNumber = JNIEnv.GetMethodID (class_ref, "getSequentialNumber", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSequentialNumber), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVIN;
		public unsafe string VIN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getVIN' and count(parameter)=0]"
			[Register ("getVIN", "()Ljava/lang/String;", "GetGetVINHandler")]
			get {
				if (id_getVIN == IntPtr.Zero)
					id_getVIN = JNIEnv.GetMethodID (class_ref, "getVIN", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVIN), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVehicleAttributes;
		public unsafe string VehicleAttributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getVehicleAttributes' and count(parameter)=0]"
			[Register ("getVehicleAttributes", "()Ljava/lang/String;", "GetGetVehicleAttributesHandler")]
			get {
				if (id_getVehicleAttributes == IntPtr.Zero)
					id_getVehicleAttributes = JNIEnv.GetMethodID (class_ref, "getVehicleAttributes", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVehicleAttributes), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVehicleDescriptorSection;
		public unsafe string VehicleDescriptorSection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getVehicleDescriptorSection' and count(parameter)=0]"
			[Register ("getVehicleDescriptorSection", "()Ljava/lang/String;", "GetGetVehicleDescriptorSectionHandler")]
			get {
				if (id_getVehicleDescriptorSection == IntPtr.Zero)
					id_getVehicleDescriptorSection = JNIEnv.GetMethodID (class_ref, "getVehicleDescriptorSection", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVehicleDescriptorSection), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVehicleIdentifierSection;
		public unsafe string VehicleIdentifierSection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getVehicleIdentifierSection' and count(parameter)=0]"
			[Register ("getVehicleIdentifierSection", "()Ljava/lang/String;", "GetGetVehicleIdentifierSectionHandler")]
			get {
				if (id_getVehicleIdentifierSection == IntPtr.Zero)
					id_getVehicleIdentifierSection = JNIEnv.GetMethodID (class_ref, "getVehicleIdentifierSection", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVehicleIdentifierSection), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getWorldManufacturerID;
		public unsafe string WorldManufacturerID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getWorldManufacturerID' and count(parameter)=0]"
			[Register ("getWorldManufacturerID", "()Ljava/lang/String;", "GetGetWorldManufacturerIDHandler")]
			get {
				if (id_getWorldManufacturerID == IntPtr.Zero)
					id_getWorldManufacturerID = JNIEnv.GetMethodID (class_ref, "getWorldManufacturerID", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getWorldManufacturerID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
