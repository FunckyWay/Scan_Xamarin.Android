using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Oned.Rss.Expanded.Decoders {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned.rss.expanded.decoders']/class[@name='AbstractExpandedDecoder']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/rss/expanded/decoders/AbstractExpandedDecoder", DoNotGenerateAcw=true)]
	public abstract partial class AbstractExpandedDecoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/oned/rss/expanded/decoders/AbstractExpandedDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractExpandedDecoder); }
		}

		protected AbstractExpandedDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInformation;
		protected unsafe global::Com.Google.Zxing.Common.BitArray Information {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss.expanded.decoders']/class[@name='AbstractExpandedDecoder']/method[@name='getInformation' and count(parameter)=0]"
			[Register ("getInformation", "()Lcom/google/zxing/common/BitArray;", "GetGetInformationHandler")]
			get {
				if (id_getInformation == IntPtr.Zero)
					id_getInformation = JNIEnv.GetMethodID (class_ref, "getInformation", "()Lcom/google/zxing/common/BitArray;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (JNIEnv.CallObjectMethod  (Handle, id_getInformation), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_createDecoder_Lcom_google_zxing_common_BitArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss.expanded.decoders']/class[@name='AbstractExpandedDecoder']/method[@name='createDecoder' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitArray']]"
		[Register ("createDecoder", "(Lcom/google/zxing/common/BitArray;)Lcom/google/zxing/oned/rss/expanded/decoders/AbstractExpandedDecoder;", "")]
		public static unsafe global::Com.Google.Zxing.Oned.Rss.Expanded.Decoders.AbstractExpandedDecoder CreateDecoder (global::Com.Google.Zxing.Common.BitArray p0)
		{
			if (id_createDecoder_Lcom_google_zxing_common_BitArray_ == IntPtr.Zero)
				id_createDecoder_Lcom_google_zxing_common_BitArray_ = JNIEnv.GetStaticMethodID (class_ref, "createDecoder", "(Lcom/google/zxing/common/BitArray;)Lcom/google/zxing/oned/rss/expanded/decoders/AbstractExpandedDecoder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Zxing.Oned.Rss.Expanded.Decoders.AbstractExpandedDecoder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.Rss.Expanded.Decoders.AbstractExpandedDecoder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createDecoder_Lcom_google_zxing_common_BitArray_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_parseInformation;
#pragma warning disable 0169
		static Delegate GetParseInformationHandler ()
		{
			if (cb_parseInformation == null)
				cb_parseInformation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ParseInformation);
			return cb_parseInformation;
		}

		static IntPtr n_ParseInformation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.Oned.Rss.Expanded.Decoders.AbstractExpandedDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Oned.Rss.Expanded.Decoders.AbstractExpandedDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ParseInformation ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss.expanded.decoders']/class[@name='AbstractExpandedDecoder']/method[@name='parseInformation' and count(parameter)=0]"
		[Register ("parseInformation", "()Ljava/lang/String;", "GetParseInformationHandler")]
		public abstract string ParseInformation ();

	}

	[global::Android.Runtime.Register ("com/google/zxing/oned/rss/expanded/decoders/AbstractExpandedDecoder", DoNotGenerateAcw=true)]
	internal partial class AbstractExpandedDecoderInvoker : AbstractExpandedDecoder {

		public AbstractExpandedDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractExpandedDecoderInvoker); }
		}

		static IntPtr id_parseInformation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss.expanded.decoders']/class[@name='AbstractExpandedDecoder']/method[@name='parseInformation' and count(parameter)=0]"
		[Register ("parseInformation", "()Ljava/lang/String;", "GetParseInformationHandler")]
		public override unsafe string ParseInformation ()
		{
			if (id_parseInformation == IntPtr.Zero)
				id_parseInformation = JNIEnv.GetMethodID (class_ref, "parseInformation", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_parseInformation), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
