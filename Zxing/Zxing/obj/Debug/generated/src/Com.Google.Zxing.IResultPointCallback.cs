using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.zxing']/interface[@name='ResultPointCallback']"
	[Register ("com/google/zxing/ResultPointCallback", "", "Com.Google.Zxing.IResultPointCallbackInvoker")]
	public partial interface IResultPointCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/interface[@name='ResultPointCallback']/method[@name='foundPossibleResultPoint' and count(parameter)=1 and parameter[1][@type='com.google.zxing.ResultPoint']]"
		[Register ("foundPossibleResultPoint", "(Lcom/google/zxing/ResultPoint;)V", "GetFoundPossibleResultPoint_Lcom_google_zxing_ResultPoint_Handler:Com.Google.Zxing.IResultPointCallbackInvoker, Zxing")]
		void FoundPossibleResultPoint (global::Com.Google.Zxing.ResultPoint p0);

	}

	[global::Android.Runtime.Register ("com/google/zxing/ResultPointCallback", DoNotGenerateAcw=true)]
	internal class IResultPointCallbackInvoker : global::Java.Lang.Object, IResultPointCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/zxing/ResultPointCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResultPointCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IResultPointCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResultPointCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.zxing.ResultPointCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResultPointCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_;
#pragma warning disable 0169
		static Delegate GetFoundPossibleResultPoint_Lcom_google_zxing_ResultPoint_Handler ()
		{
			if (cb_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_ == null)
				cb_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FoundPossibleResultPoint_Lcom_google_zxing_ResultPoint_);
			return cb_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_;
		}

		static void n_FoundPossibleResultPoint_Lcom_google_zxing_ResultPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Zxing.IResultPointCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.IResultPointCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Zxing.ResultPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.ResultPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FoundPossibleResultPoint (p0);
		}
#pragma warning restore 0169

		IntPtr id_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_;
		public unsafe void FoundPossibleResultPoint (global::Com.Google.Zxing.ResultPoint p0)
		{
			if (id_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_ == IntPtr.Zero)
				id_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_ = JNIEnv.GetMethodID (class_ref, "foundPossibleResultPoint", "(Lcom/google/zxing/ResultPoint;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_foundPossibleResultPoint_Lcom_google_zxing_ResultPoint_, __args);
		}

	}

}
