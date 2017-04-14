using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']"
	[global::Android.Runtime.Register ("com/google/zxing/LuminanceSource", DoNotGenerateAcw=true)]
	public abstract partial class LuminanceSource : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/LuminanceSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LuminanceSource); }
		}

		protected LuminanceSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/constructor[@name='LuminanceSource' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		protected unsafe LuminanceSource (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (LuminanceSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static IntPtr id_getHeight;
		public unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getHeight);
				} finally {
				}
			}
		}

		static Delegate cb_isCropSupported;
#pragma warning disable 0169
		static Delegate GetIsCropSupportedHandler ()
		{
			if (cb_isCropSupported == null)
				cb_isCropSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCropSupported);
			return cb_isCropSupported;
		}

		static bool n_IsCropSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.LuminanceSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCropSupported;
		}
#pragma warning restore 0169

		static IntPtr id_isCropSupported;
		public virtual unsafe bool IsCropSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='isCropSupported' and count(parameter)=0]"
			[Register ("isCropSupported", "()Z", "GetIsCropSupportedHandler")]
			get {
				if (id_isCropSupported == IntPtr.Zero)
					id_isCropSupported = JNIEnv.GetMethodID (class_ref, "isCropSupported", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isCropSupported);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCropSupported", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isRotateSupported;
#pragma warning disable 0169
		static Delegate GetIsRotateSupportedHandler ()
		{
			if (cb_isRotateSupported == null)
				cb_isRotateSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRotateSupported);
			return cb_isRotateSupported;
		}

		static bool n_IsRotateSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.LuminanceSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRotateSupported;
		}
#pragma warning restore 0169

		static IntPtr id_isRotateSupported;
		public virtual unsafe bool IsRotateSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='isRotateSupported' and count(parameter)=0]"
			[Register ("isRotateSupported", "()Z", "GetIsRotateSupportedHandler")]
			get {
				if (id_isRotateSupported == IntPtr.Zero)
					id_isRotateSupported = JNIEnv.GetMethodID (class_ref, "isRotateSupported", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isRotateSupported);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRotateSupported", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_getWidth;
		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getWidth);
				} finally {
				}
			}
		}

		static Delegate cb_crop_IIII;
#pragma warning disable 0169
		static Delegate GetCrop_IIIIHandler ()
		{
			if (cb_crop_IIII == null)
				cb_crop_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, IntPtr>) n_Crop_IIII);
			return cb_crop_IIII;
		}

		static IntPtr n_Crop_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Google.Zxing.LuminanceSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Crop (p0, p1, p2, p3));
		}
#pragma warning restore 0169

		static IntPtr id_crop_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='crop' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("crop", "(IIII)Lcom/google/zxing/LuminanceSource;", "GetCrop_IIIIHandler")]
		public virtual unsafe global::Com.Google.Zxing.LuminanceSource Crop (int p0, int p1, int p2, int p3)
		{
			if (id_crop_IIII == IntPtr.Zero)
				id_crop_IIII = JNIEnv.GetMethodID (class_ref, "crop", "(IIII)Lcom/google/zxing/LuminanceSource;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (JNIEnv.CallObjectMethod  (Handle, id_crop_IIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "crop", "(IIII)Lcom/google/zxing/LuminanceSource;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getMatrix;
#pragma warning disable 0169
		static Delegate GetGetMatrixHandler ()
		{
			if (cb_getMatrix == null)
				cb_getMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMatrix);
			return cb_getMatrix;
		}

		static IntPtr n_GetMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.LuminanceSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMatrix ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='getMatrix' and count(parameter)=0]"
		[Register ("getMatrix", "()[B", "GetGetMatrixHandler")]
		public abstract byte[] GetMatrix ();

		static Delegate cb_getRow_IarrayB;
#pragma warning disable 0169
		static Delegate GetGetRow_IarrayBHandler ()
		{
			if (cb_getRow_IarrayB == null)
				cb_getRow_IarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GetRow_IarrayB);
			return cb_getRow_IarrayB;
		}

		static IntPtr n_GetRow_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Zxing.LuminanceSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.GetRow (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='getRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("getRow", "(I[B)[B", "GetGetRow_IarrayBHandler")]
		public abstract byte[] GetRow (int p0, byte[] p1);

		static Delegate cb_invert;
#pragma warning disable 0169
		static Delegate GetInvertHandler ()
		{
			if (cb_invert == null)
				cb_invert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Invert);
			return cb_invert;
		}

		static IntPtr n_Invert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.LuminanceSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Invert ());
		}
#pragma warning restore 0169

		static IntPtr id_invert;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='invert' and count(parameter)=0]"
		[Register ("invert", "()Lcom/google/zxing/LuminanceSource;", "GetInvertHandler")]
		public virtual unsafe global::Com.Google.Zxing.LuminanceSource Invert ()
		{
			if (id_invert == IntPtr.Zero)
				id_invert = JNIEnv.GetMethodID (class_ref, "invert", "()Lcom/google/zxing/LuminanceSource;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (JNIEnv.CallObjectMethod  (Handle, id_invert), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invert", "()Lcom/google/zxing/LuminanceSource;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rotateCounterClockwise;
#pragma warning disable 0169
		static Delegate GetRotateCounterClockwiseHandler ()
		{
			if (cb_rotateCounterClockwise == null)
				cb_rotateCounterClockwise = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RotateCounterClockwise);
			return cb_rotateCounterClockwise;
		}

		static IntPtr n_RotateCounterClockwise (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.LuminanceSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotateCounterClockwise ());
		}
#pragma warning restore 0169

		static IntPtr id_rotateCounterClockwise;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='rotateCounterClockwise' and count(parameter)=0]"
		[Register ("rotateCounterClockwise", "()Lcom/google/zxing/LuminanceSource;", "GetRotateCounterClockwiseHandler")]
		public virtual unsafe global::Com.Google.Zxing.LuminanceSource RotateCounterClockwise ()
		{
			if (id_rotateCounterClockwise == IntPtr.Zero)
				id_rotateCounterClockwise = JNIEnv.GetMethodID (class_ref, "rotateCounterClockwise", "()Lcom/google/zxing/LuminanceSource;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (JNIEnv.CallObjectMethod  (Handle, id_rotateCounterClockwise), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotateCounterClockwise", "()Lcom/google/zxing/LuminanceSource;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rotateCounterClockwise45;
#pragma warning disable 0169
		static Delegate GetRotateCounterClockwise45Handler ()
		{
			if (cb_rotateCounterClockwise45 == null)
				cb_rotateCounterClockwise45 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RotateCounterClockwise45);
			return cb_rotateCounterClockwise45;
		}

		static IntPtr n_RotateCounterClockwise45 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Zxing.LuminanceSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotateCounterClockwise45 ());
		}
#pragma warning restore 0169

		static IntPtr id_rotateCounterClockwise45;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='rotateCounterClockwise45' and count(parameter)=0]"
		[Register ("rotateCounterClockwise45", "()Lcom/google/zxing/LuminanceSource;", "GetRotateCounterClockwise45Handler")]
		public virtual unsafe global::Com.Google.Zxing.LuminanceSource RotateCounterClockwise45 ()
		{
			if (id_rotateCounterClockwise45 == IntPtr.Zero)
				id_rotateCounterClockwise45 = JNIEnv.GetMethodID (class_ref, "rotateCounterClockwise45", "()Lcom/google/zxing/LuminanceSource;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (JNIEnv.CallObjectMethod  (Handle, id_rotateCounterClockwise45), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.LuminanceSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotateCounterClockwise45", "()Lcom/google/zxing/LuminanceSource;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/LuminanceSource", DoNotGenerateAcw=true)]
	internal partial class LuminanceSourceInvoker : LuminanceSource {

		public LuminanceSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LuminanceSourceInvoker); }
		}

		static IntPtr id_getMatrix;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='getMatrix' and count(parameter)=0]"
		[Register ("getMatrix", "()[B", "GetGetMatrixHandler")]
		public override unsafe byte[] GetMatrix ()
		{
			if (id_getMatrix == IntPtr.Zero)
				id_getMatrix = JNIEnv.GetMethodID (class_ref, "getMatrix", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getMatrix), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getRow_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='LuminanceSource']/method[@name='getRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("getRow", "(I[B)[B", "GetGetRow_IarrayBHandler")]
		public override unsafe byte[] GetRow (int p0, byte[] p1)
		{
			if (id_getRow_IarrayB == IntPtr.Zero)
				id_getRow_IarrayB = JNIEnv.GetMethodID (class_ref, "getRow", "(I[B)[B");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getRow_IarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}

}
