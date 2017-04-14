using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Zxing.Oned.Rss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='RSSUtils']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/rss/RSSUtils", DoNotGenerateAcw=true)]
	public sealed partial class RSSUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/zxing/oned/rss/RSSUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RSSUtils); }
		}

		internal RSSUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getRSSvalue_arrayIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='RSSUtils']/method[@name='getRSSvalue' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("getRSSvalue", "([IIZ)I", "")]
		public static unsafe int GetRSSvalue (int[] p0, int p1, bool p2)
		{
			if (id_getRSSvalue_arrayIIZ == IntPtr.Zero)
				id_getRSSvalue_arrayIIZ = JNIEnv.GetStaticMethodID (class_ref, "getRSSvalue", "([IIZ)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getRSSvalue_arrayIIZ, __args);
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
