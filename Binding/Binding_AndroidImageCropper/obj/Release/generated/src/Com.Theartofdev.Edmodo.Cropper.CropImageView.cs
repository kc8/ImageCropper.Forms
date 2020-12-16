using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Theartofdev.Edmodo.Cropper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']"
	[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImageView", DoNotGenerateAcw=true)]
	public partial class CropImageView : global::Android.Widget.FrameLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropResult']"
		[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImageView$CropResult", DoNotGenerateAcw=true)]
		public partial class CropResult : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImageView$CropResult", typeof (CropResult));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected CropResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getBitmap;
#pragma warning disable 0169
			static Delegate GetGetBitmapHandler ()
			{
				if (cb_getBitmap == null)
					cb_getBitmap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBitmap);
				return cb_getBitmap;
			}

			static IntPtr n_GetBitmap (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Bitmap);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Graphics.Bitmap Bitmap {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropResult']/method[@name='getBitmap' and count(parameter)=0]"
				[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
				get {
					const string __id = "getBitmap.()Landroid/graphics/Bitmap;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getCropRect;
#pragma warning disable 0169
			static Delegate GetGetCropRectHandler ()
			{
				if (cb_getCropRect == null)
					cb_getCropRect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCropRect);
				return cb_getCropRect;
			}

			static IntPtr n_GetCropRect (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CropRect);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Graphics.Rect CropRect {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropResult']/method[@name='getCropRect' and count(parameter)=0]"
				[Register ("getCropRect", "()Landroid/graphics/Rect;", "GetGetCropRectHandler")]
				get {
					const string __id = "getCropRect.()Landroid/graphics/Rect;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getError;
#pragma warning disable 0169
			static Delegate GetGetErrorHandler ()
			{
				if (cb_getError == null)
					cb_getError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetError);
				return cb_getError;
			}

			static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Error);
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Lang.Exception Error {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropResult']/method[@name='getError' and count(parameter)=0]"
				[Register ("getError", "()Ljava/lang/Exception;", "GetGetErrorHandler")]
				get {
					const string __id = "getError.()Ljava/lang/Exception;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_isSuccessful;
#pragma warning disable 0169
			static Delegate GetIsSuccessfulHandler ()
			{
				if (cb_isSuccessful == null)
					cb_isSuccessful = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSuccessful);
				return cb_isSuccessful;
			}

			static bool n_IsSuccessful (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsSuccessful;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsSuccessful {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropResult']/method[@name='isSuccessful' and count(parameter)=0]"
				[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
				get {
					const string __id = "isSuccessful.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getOriginalBitmap;
#pragma warning disable 0169
			static Delegate GetGetOriginalBitmapHandler ()
			{
				if (cb_getOriginalBitmap == null)
					cb_getOriginalBitmap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOriginalBitmap);
				return cb_getOriginalBitmap;
			}

			static IntPtr n_GetOriginalBitmap (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.OriginalBitmap);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Graphics.Bitmap OriginalBitmap {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropResult']/method[@name='getOriginalBitmap' and count(parameter)=0]"
				[Register ("getOriginalBitmap", "()Landroid/graphics/Bitmap;", "GetGetOriginalBitmapHandler")]
				get {
					const string __id = "getOriginalBitmap.()Landroid/graphics/Bitmap;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getOriginalUri;
#pragma warning disable 0169
			static Delegate GetGetOriginalUriHandler ()
			{
				if (cb_getOriginalUri == null)
					cb_getOriginalUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOriginalUri);
				return cb_getOriginalUri;
			}

			static IntPtr n_GetOriginalUri (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.OriginalUri);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Net.Uri OriginalUri {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropResult']/method[@name='getOriginalUri' and count(parameter)=0]"
				[Register ("getOriginalUri", "()Landroid/net/Uri;", "GetGetOriginalUriHandler")]
				get {
					const string __id = "getOriginalUri.()Landroid/net/Uri;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getRotation;
#pragma warning disable 0169
			static Delegate GetGetRotationHandler ()
			{
				if (cb_getRotation == null)
					cb_getRotation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRotation);
				return cb_getRotation;
			}

			static int n_GetRotation (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Rotation;
			}
#pragma warning restore 0169

			public virtual unsafe int Rotation {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropResult']/method[@name='getRotation' and count(parameter)=0]"
				[Register ("getRotation", "()I", "GetGetRotationHandler")]
				get {
					const string __id = "getRotation.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getSampleSize;
#pragma warning disable 0169
			static Delegate GetGetSampleSizeHandler ()
			{
				if (cb_getSampleSize == null)
					cb_getSampleSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSampleSize);
				return cb_getSampleSize;
			}

			static int n_GetSampleSize (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SampleSize;
			}
#pragma warning restore 0169

			public virtual unsafe int SampleSize {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropResult']/method[@name='getSampleSize' and count(parameter)=0]"
				[Register ("getSampleSize", "()I", "GetGetSampleSizeHandler")]
				get {
					const string __id = "getSampleSize.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getUri;
#pragma warning disable 0169
			static Delegate GetGetUriHandler ()
			{
				if (cb_getUri == null)
					cb_getUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUri);
				return cb_getUri;
			}

			static IntPtr n_GetUri (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Uri);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Net.Uri Uri {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropResult']/method[@name='getUri' and count(parameter)=0]"
				[Register ("getUri", "()Landroid/net/Uri;", "GetGetUriHandler")]
				get {
					const string __id = "getUri.()Landroid/net/Uri;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getWholeImageRect;
#pragma warning disable 0169
			static Delegate GetGetWholeImageRectHandler ()
			{
				if (cb_getWholeImageRect == null)
					cb_getWholeImageRect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWholeImageRect);
				return cb_getWholeImageRect;
			}

			static IntPtr n_GetWholeImageRect (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.WholeImageRect);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Graphics.Rect WholeImageRect {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropResult']/method[@name='getWholeImageRect' and count(parameter)=0]"
				[Register ("getWholeImageRect", "()Landroid/graphics/Rect;", "GetGetWholeImageRectHandler")]
				get {
					const string __id = "getWholeImageRect.()Landroid/graphics/Rect;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getCropPoints;
#pragma warning disable 0169
			static Delegate GetGetCropPointsHandler ()
			{
				if (cb_getCropPoints == null)
					cb_getCropPoints = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCropPoints);
				return cb_getCropPoints;
			}

			static IntPtr n_GetCropPoints (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetCropPoints ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropResult']/method[@name='getCropPoints' and count(parameter)=0]"
			[Register ("getCropPoints", "()[F", "GetGetCropPointsHandler")]
			public virtual unsafe float[] GetCropPoints ()
			{
				const string __id = "getCropPoints.()[F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropShape']"
		[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImageView$CropShape", DoNotGenerateAcw=true)]
		public sealed partial class CropShape : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropShape']/field[@name='OVAL']"
			[Register ("OVAL")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape Oval {
				get {
					const string __id = "OVAL.Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropShape']/field[@name='RECTANGLE']"
			[Register ("RECTANGLE")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape Rectangle {
				get {
					const string __id = "RECTANGLE.Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImageView$CropShape", typeof (CropShape));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal CropShape (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropShape']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;", "")]
			public static unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.CropShape']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;", "")]
			public static unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape[] Values ()
			{
				const string __id = "values.()[Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.Guidelines']"
		[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImageView$Guidelines", DoNotGenerateAcw=true)]
		public sealed partial class Guidelines : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.Guidelines']/field[@name='OFF']"
			[Register ("OFF")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines Off {
				get {
					const string __id = "OFF.Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.Guidelines']/field[@name='ON']"
			[Register ("ON")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines On {
				get {
					const string __id = "ON.Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.Guidelines']/field[@name='ON_TOUCH']"
			[Register ("ON_TOUCH")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines OnTouch {
				get {
					const string __id = "ON_TOUCH.Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImageView$Guidelines", typeof (Guidelines));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal Guidelines (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.Guidelines']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;", "")]
			public static unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.Guidelines']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;", "")]
			public static unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines[] Values ()
			{
				const string __id = "values.()[Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/interface[@name='CropImageView.OnCropImageCompleteListener']"
		[Register ("com/theartofdev/edmodo/cropper/CropImageView$OnCropImageCompleteListener", "", "Com.Theartofdev.Edmodo.Cropper.CropImageView/IOnCropImageCompleteListenerInvoker")]
		public partial interface IOnCropImageCompleteListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/interface[@name='CropImageView.OnCropImageCompleteListener']/method[@name='onCropImageComplete' and count(parameter)=2 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView'] and parameter[2][@type='com.theartofdev.edmodo.cropper.CropImageView.CropResult']]"
			[Register ("onCropImageComplete", "(Lcom/theartofdev/edmodo/cropper/CropImageView;Lcom/theartofdev/edmodo/cropper/CropImageView$CropResult;)V", "GetOnCropImageComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Lcom_theartofdev_edmodo_cropper_CropImageView_CropResult_Handler:Com.Theartofdev.Edmodo.Cropper.CropImageView/IOnCropImageCompleteListenerInvoker, Binding_ImageCropperAndroid")]
			void OnCropImageComplete (global::Com.Theartofdev.Edmodo.Cropper.CropImageView p0, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult p1);

		}

		[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImageView$OnCropImageCompleteListener", DoNotGenerateAcw=true)]
		internal partial class IOnCropImageCompleteListenerInvoker : global::Java.Lang.Object, IOnCropImageCompleteListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImageView$OnCropImageCompleteListener", typeof (IOnCropImageCompleteListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnCropImageCompleteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCropImageCompleteListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.theartofdev.edmodo.cropper.CropImageView.OnCropImageCompleteListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCropImageCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCropImageComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Lcom_theartofdev_edmodo_cropper_CropImageView_CropResult_;
#pragma warning disable 0169
			static Delegate GetOnCropImageComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Lcom_theartofdev_edmodo_cropper_CropImageView_CropResult_Handler ()
			{
				if (cb_onCropImageComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Lcom_theartofdev_edmodo_cropper_CropImageView_CropResult_ == null)
					cb_onCropImageComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Lcom_theartofdev_edmodo_cropper_CropImageView_CropResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnCropImageComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Lcom_theartofdev_edmodo_cropper_CropImageView_CropResult_);
				return cb_onCropImageComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Lcom_theartofdev_edmodo_cropper_CropImageView_CropResult_;
			}

			static void n_OnCropImageComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Lcom_theartofdev_edmodo_cropper_CropImageView_CropResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnCropImageCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnCropImageComplete (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onCropImageComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Lcom_theartofdev_edmodo_cropper_CropImageView_CropResult_;
			public unsafe void OnCropImageComplete (global::Com.Theartofdev.Edmodo.Cropper.CropImageView p0, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult p1)
			{
				if (id_onCropImageComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Lcom_theartofdev_edmodo_cropper_CropImageView_CropResult_ == IntPtr.Zero)
					id_onCropImageComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Lcom_theartofdev_edmodo_cropper_CropImageView_CropResult_ = JNIEnv.GetMethodID (class_ref, "onCropImageComplete", "(Lcom/theartofdev/edmodo/cropper/CropImageView;Lcom/theartofdev/edmodo/cropper/CropImageView$CropResult;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCropImageComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Lcom_theartofdev_edmodo_cropper_CropImageView_CropResult_, __args);
			}

		}

		// event args for com.theartofdev.edmodo.cropper.CropImageView.OnCropImageCompleteListener.onCropImageComplete
		public partial class CropImageCompleteEventArgs : global::System.EventArgs {

			public CropImageCompleteEventArgs (global::Com.Theartofdev.Edmodo.Cropper.CropImageView p0, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Theartofdev.Edmodo.Cropper.CropImageView p0;
			public global::Com.Theartofdev.Edmodo.Cropper.CropImageView P0 {
				get { return p0; }
			}

			global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult p1;
			public global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/theartofdev/edmodo/cropper/CropImageView_OnCropImageCompleteListenerImplementor")]
		internal sealed partial class IOnCropImageCompleteListenerImplementor : global::Java.Lang.Object, IOnCropImageCompleteListener {

			object sender;

			public IOnCropImageCompleteListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/theartofdev/edmodo/cropper/CropImageView_OnCropImageCompleteListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CropImageCompleteEventArgs> Handler;
#pragma warning restore 0649

			public void OnCropImageComplete (global::Com.Theartofdev.Edmodo.Cropper.CropImageView p0, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CropImageCompleteEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnCropImageCompleteListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/interface[@name='CropImageView.OnSetCropOverlayMovedListener']"
		[Register ("com/theartofdev/edmodo/cropper/CropImageView$OnSetCropOverlayMovedListener", "", "Com.Theartofdev.Edmodo.Cropper.CropImageView/IOnSetCropOverlayMovedListenerInvoker")]
		public partial interface IOnSetCropOverlayMovedListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/interface[@name='CropImageView.OnSetCropOverlayMovedListener']/method[@name='onCropOverlayMoved' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
			[Register ("onCropOverlayMoved", "(Landroid/graphics/Rect;)V", "GetOnCropOverlayMoved_Landroid_graphics_Rect_Handler:Com.Theartofdev.Edmodo.Cropper.CropImageView/IOnSetCropOverlayMovedListenerInvoker, Binding_ImageCropperAndroid")]
			void OnCropOverlayMoved (global::Android.Graphics.Rect p0);

		}

		[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImageView$OnSetCropOverlayMovedListener", DoNotGenerateAcw=true)]
		internal partial class IOnSetCropOverlayMovedListenerInvoker : global::Java.Lang.Object, IOnSetCropOverlayMovedListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImageView$OnSetCropOverlayMovedListener", typeof (IOnSetCropOverlayMovedListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnSetCropOverlayMovedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSetCropOverlayMovedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.theartofdev.edmodo.cropper.CropImageView.OnSetCropOverlayMovedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSetCropOverlayMovedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCropOverlayMoved_Landroid_graphics_Rect_;
#pragma warning disable 0169
			static Delegate GetOnCropOverlayMoved_Landroid_graphics_Rect_Handler ()
			{
				if (cb_onCropOverlayMoved_Landroid_graphics_Rect_ == null)
					cb_onCropOverlayMoved_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCropOverlayMoved_Landroid_graphics_Rect_);
				return cb_onCropOverlayMoved_Landroid_graphics_Rect_;
			}

			static void n_OnCropOverlayMoved_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayMovedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCropOverlayMoved (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCropOverlayMoved_Landroid_graphics_Rect_;
			public unsafe void OnCropOverlayMoved (global::Android.Graphics.Rect p0)
			{
				if (id_onCropOverlayMoved_Landroid_graphics_Rect_ == IntPtr.Zero)
					id_onCropOverlayMoved_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "onCropOverlayMoved", "(Landroid/graphics/Rect;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCropOverlayMoved_Landroid_graphics_Rect_, __args);
			}

		}

		// event args for com.theartofdev.edmodo.cropper.CropImageView.OnSetCropOverlayMovedListener.onCropOverlayMoved
		public partial class SetCropOverlayMovedEventArgs : global::System.EventArgs {

			public SetCropOverlayMovedEventArgs (global::Android.Graphics.Rect p0)
			{
				this.p0 = p0;
			}

			global::Android.Graphics.Rect p0;
			public global::Android.Graphics.Rect P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/theartofdev/edmodo/cropper/CropImageView_OnSetCropOverlayMovedListenerImplementor")]
		internal sealed partial class IOnSetCropOverlayMovedListenerImplementor : global::Java.Lang.Object, IOnSetCropOverlayMovedListener {

			object sender;

			public IOnSetCropOverlayMovedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/theartofdev/edmodo/cropper/CropImageView_OnSetCropOverlayMovedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SetCropOverlayMovedEventArgs> Handler;
#pragma warning restore 0649

			public void OnCropOverlayMoved (global::Android.Graphics.Rect p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new SetCropOverlayMovedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnSetCropOverlayMovedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/interface[@name='CropImageView.OnSetCropOverlayReleasedListener']"
		[Register ("com/theartofdev/edmodo/cropper/CropImageView$OnSetCropOverlayReleasedListener", "", "Com.Theartofdev.Edmodo.Cropper.CropImageView/IOnSetCropOverlayReleasedListenerInvoker")]
		public partial interface IOnSetCropOverlayReleasedListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/interface[@name='CropImageView.OnSetCropOverlayReleasedListener']/method[@name='onCropOverlayReleased' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
			[Register ("onCropOverlayReleased", "(Landroid/graphics/Rect;)V", "GetOnCropOverlayReleased_Landroid_graphics_Rect_Handler:Com.Theartofdev.Edmodo.Cropper.CropImageView/IOnSetCropOverlayReleasedListenerInvoker, Binding_ImageCropperAndroid")]
			void OnCropOverlayReleased (global::Android.Graphics.Rect p0);

		}

		[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImageView$OnSetCropOverlayReleasedListener", DoNotGenerateAcw=true)]
		internal partial class IOnSetCropOverlayReleasedListenerInvoker : global::Java.Lang.Object, IOnSetCropOverlayReleasedListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImageView$OnSetCropOverlayReleasedListener", typeof (IOnSetCropOverlayReleasedListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnSetCropOverlayReleasedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSetCropOverlayReleasedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.theartofdev.edmodo.cropper.CropImageView.OnSetCropOverlayReleasedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSetCropOverlayReleasedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCropOverlayReleased_Landroid_graphics_Rect_;
#pragma warning disable 0169
			static Delegate GetOnCropOverlayReleased_Landroid_graphics_Rect_Handler ()
			{
				if (cb_onCropOverlayReleased_Landroid_graphics_Rect_ == null)
					cb_onCropOverlayReleased_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCropOverlayReleased_Landroid_graphics_Rect_);
				return cb_onCropOverlayReleased_Landroid_graphics_Rect_;
			}

			static void n_OnCropOverlayReleased_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayReleasedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCropOverlayReleased (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCropOverlayReleased_Landroid_graphics_Rect_;
			public unsafe void OnCropOverlayReleased (global::Android.Graphics.Rect p0)
			{
				if (id_onCropOverlayReleased_Landroid_graphics_Rect_ == IntPtr.Zero)
					id_onCropOverlayReleased_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "onCropOverlayReleased", "(Landroid/graphics/Rect;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCropOverlayReleased_Landroid_graphics_Rect_, __args);
			}

		}

		// event args for com.theartofdev.edmodo.cropper.CropImageView.OnSetCropOverlayReleasedListener.onCropOverlayReleased
		public partial class SetCropOverlayReleasedEventArgs : global::System.EventArgs {

			public SetCropOverlayReleasedEventArgs (global::Android.Graphics.Rect p0)
			{
				this.p0 = p0;
			}

			global::Android.Graphics.Rect p0;
			public global::Android.Graphics.Rect P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/theartofdev/edmodo/cropper/CropImageView_OnSetCropOverlayReleasedListenerImplementor")]
		internal sealed partial class IOnSetCropOverlayReleasedListenerImplementor : global::Java.Lang.Object, IOnSetCropOverlayReleasedListener {

			object sender;

			public IOnSetCropOverlayReleasedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/theartofdev/edmodo/cropper/CropImageView_OnSetCropOverlayReleasedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SetCropOverlayReleasedEventArgs> Handler;
#pragma warning restore 0649

			public void OnCropOverlayReleased (global::Android.Graphics.Rect p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new SetCropOverlayReleasedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnSetCropOverlayReleasedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/interface[@name='CropImageView.OnSetCropWindowChangeListener']"
		[Register ("com/theartofdev/edmodo/cropper/CropImageView$OnSetCropWindowChangeListener", "", "Com.Theartofdev.Edmodo.Cropper.CropImageView/IOnSetCropWindowChangeListenerInvoker")]
		public partial interface IOnSetCropWindowChangeListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/interface[@name='CropImageView.OnSetCropWindowChangeListener']/method[@name='onCropWindowChanged' and count(parameter)=0]"
			[Register ("onCropWindowChanged", "()V", "GetOnCropWindowChangedHandler:Com.Theartofdev.Edmodo.Cropper.CropImageView/IOnSetCropWindowChangeListenerInvoker, Binding_ImageCropperAndroid")]
			void OnCropWindowChanged ();

		}

		[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImageView$OnSetCropWindowChangeListener", DoNotGenerateAcw=true)]
		internal partial class IOnSetCropWindowChangeListenerInvoker : global::Java.Lang.Object, IOnSetCropWindowChangeListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImageView$OnSetCropWindowChangeListener", typeof (IOnSetCropWindowChangeListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnSetCropWindowChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSetCropWindowChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.theartofdev.edmodo.cropper.CropImageView.OnSetCropWindowChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSetCropWindowChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCropWindowChanged;
#pragma warning disable 0169
			static Delegate GetOnCropWindowChangedHandler ()
			{
				if (cb_onCropWindowChanged == null)
					cb_onCropWindowChanged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCropWindowChanged);
				return cb_onCropWindowChanged;
			}

			static void n_OnCropWindowChanged (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropWindowChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCropWindowChanged ();
			}
#pragma warning restore 0169

			IntPtr id_onCropWindowChanged;
			public unsafe void OnCropWindowChanged ()
			{
				if (id_onCropWindowChanged == IntPtr.Zero)
					id_onCropWindowChanged = JNIEnv.GetMethodID (class_ref, "onCropWindowChanged", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCropWindowChanged);
			}

		}

		[global::Android.Runtime.Register ("mono/com/theartofdev/edmodo/cropper/CropImageView_OnSetCropWindowChangeListenerImplementor")]
		internal sealed partial class IOnSetCropWindowChangeListenerImplementor : global::Java.Lang.Object, IOnSetCropWindowChangeListener {

			object sender;

			public IOnSetCropWindowChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/theartofdev/edmodo/cropper/CropImageView_OnSetCropWindowChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnCropWindowChanged ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnSetCropWindowChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/interface[@name='CropImageView.OnSetImageUriCompleteListener']"
		[Register ("com/theartofdev/edmodo/cropper/CropImageView$OnSetImageUriCompleteListener", "", "Com.Theartofdev.Edmodo.Cropper.CropImageView/IOnSetImageUriCompleteListenerInvoker")]
		public partial interface IOnSetImageUriCompleteListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/interface[@name='CropImageView.OnSetImageUriCompleteListener']/method[@name='onSetImageUriComplete' and count(parameter)=3 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.lang.Exception']]"
			[Register ("onSetImageUriComplete", "(Lcom/theartofdev/edmodo/cropper/CropImageView;Landroid/net/Uri;Ljava/lang/Exception;)V", "GetOnSetImageUriComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Landroid_net_Uri_Ljava_lang_Exception_Handler:Com.Theartofdev.Edmodo.Cropper.CropImageView/IOnSetImageUriCompleteListenerInvoker, Binding_ImageCropperAndroid")]
			void OnSetImageUriComplete (global::Com.Theartofdev.Edmodo.Cropper.CropImageView p0, global::Android.Net.Uri p1, global::Java.Lang.Exception p2);

		}

		[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImageView$OnSetImageUriCompleteListener", DoNotGenerateAcw=true)]
		internal partial class IOnSetImageUriCompleteListenerInvoker : global::Java.Lang.Object, IOnSetImageUriCompleteListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImageView$OnSetImageUriCompleteListener", typeof (IOnSetImageUriCompleteListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnSetImageUriCompleteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSetImageUriCompleteListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.theartofdev.edmodo.cropper.CropImageView.OnSetImageUriCompleteListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSetImageUriCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSetImageUriComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Landroid_net_Uri_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnSetImageUriComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Landroid_net_Uri_Ljava_lang_Exception_Handler ()
			{
				if (cb_onSetImageUriComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Landroid_net_Uri_Ljava_lang_Exception_ == null)
					cb_onSetImageUriComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Landroid_net_Uri_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnSetImageUriComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Landroid_net_Uri_Ljava_lang_Exception_);
				return cb_onSetImageUriComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Landroid_net_Uri_Ljava_lang_Exception_;
			}

			static void n_OnSetImageUriComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Landroid_net_Uri_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetImageUriCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnSetImageUriComplete (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onSetImageUriComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Landroid_net_Uri_Ljava_lang_Exception_;
			public unsafe void OnSetImageUriComplete (global::Com.Theartofdev.Edmodo.Cropper.CropImageView p0, global::Android.Net.Uri p1, global::Java.Lang.Exception p2)
			{
				if (id_onSetImageUriComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Landroid_net_Uri_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onSetImageUriComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Landroid_net_Uri_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onSetImageUriComplete", "(Lcom/theartofdev/edmodo/cropper/CropImageView;Landroid/net/Uri;Ljava/lang/Exception;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSetImageUriComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Landroid_net_Uri_Ljava_lang_Exception_, __args);
			}

		}

		// event args for com.theartofdev.edmodo.cropper.CropImageView.OnSetImageUriCompleteListener.onSetImageUriComplete
		public partial class SetImageUriCompleteEventArgs : global::System.EventArgs {

			public SetImageUriCompleteEventArgs (global::Com.Theartofdev.Edmodo.Cropper.CropImageView p0, global::Android.Net.Uri p1, global::Java.Lang.Exception p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Theartofdev.Edmodo.Cropper.CropImageView p0;
			public global::Com.Theartofdev.Edmodo.Cropper.CropImageView P0 {
				get { return p0; }
			}

			global::Android.Net.Uri p1;
			public global::Android.Net.Uri P1 {
				get { return p1; }
			}

			global::Java.Lang.Exception p2;
			public global::Java.Lang.Exception P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/theartofdev/edmodo/cropper/CropImageView_OnSetImageUriCompleteListenerImplementor")]
		internal sealed partial class IOnSetImageUriCompleteListenerImplementor : global::Java.Lang.Object, IOnSetImageUriCompleteListener {

			object sender;

			public IOnSetImageUriCompleteListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/theartofdev/edmodo/cropper/CropImageView_OnSetImageUriCompleteListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SetImageUriCompleteEventArgs> Handler;
#pragma warning restore 0649

			public void OnSetImageUriComplete (global::Com.Theartofdev.Edmodo.Cropper.CropImageView p0, global::Android.Net.Uri p1, global::Java.Lang.Exception p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new SetImageUriCompleteEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnSetImageUriCompleteListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.RequestSizeOptions']"
		[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions", DoNotGenerateAcw=true)]
		public sealed partial class RequestSizeOptions : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.RequestSizeOptions']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions None {
				get {
					const string __id = "NONE.Lcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.RequestSizeOptions']/field[@name='RESIZE_EXACT']"
			[Register ("RESIZE_EXACT")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions ResizeExact {
				get {
					const string __id = "RESIZE_EXACT.Lcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.RequestSizeOptions']/field[@name='RESIZE_FIT']"
			[Register ("RESIZE_FIT")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions ResizeFit {
				get {
					const string __id = "RESIZE_FIT.Lcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.RequestSizeOptions']/field[@name='RESIZE_INSIDE']"
			[Register ("RESIZE_INSIDE")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions ResizeInside {
				get {
					const string __id = "RESIZE_INSIDE.Lcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.RequestSizeOptions']/field[@name='SAMPLING']"
			[Register ("SAMPLING")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions Sampling {
				get {
					const string __id = "SAMPLING.Lcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions", typeof (RequestSizeOptions));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal RequestSizeOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.RequestSizeOptions']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;", "")]
			public static unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.RequestSizeOptions']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;", "")]
			public static unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions[] Values ()
			{
				const string __id = "values.()[Lcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.ScaleType']"
		[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImageView$ScaleType", DoNotGenerateAcw=true)]
		public sealed partial class ScaleType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.ScaleType']/field[@name='CENTER']"
			[Register ("CENTER")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType Center {
				get {
					const string __id = "CENTER.Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.ScaleType']/field[@name='CENTER_CROP']"
			[Register ("CENTER_CROP")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType CenterCrop {
				get {
					const string __id = "CENTER_CROP.Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.ScaleType']/field[@name='CENTER_INSIDE']"
			[Register ("CENTER_INSIDE")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType CenterInside {
				get {
					const string __id = "CENTER_INSIDE.Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.ScaleType']/field[@name='FIT_CENTER']"
			[Register ("FIT_CENTER")]
			public static global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType FitCenter {
				get {
					const string __id = "FIT_CENTER.Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImageView$ScaleType", typeof (ScaleType));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal ScaleType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.ScaleType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;", "")]
			public static unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView.ScaleType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;", "")]
			public static unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType[] Values ()
			{
				const string __id = "values.()[Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImageView", typeof (CropImageView));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected CropImageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/constructor[@name='CropImageView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CropImageView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/constructor[@name='CropImageView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CropImageView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_getAspectRatio;
#pragma warning disable 0169
		static Delegate GetGetAspectRatioHandler ()
		{
			if (cb_getAspectRatio == null)
				cb_getAspectRatio = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAspectRatio);
			return cb_getAspectRatio;
		}

		static IntPtr n_GetAspectRatio (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AspectRatio);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Util.Pair AspectRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getAspectRatio' and count(parameter)=0]"
			[Register ("getAspectRatio", "()Landroid/util/Pair;", "GetGetAspectRatioHandler")]
			get {
				const string __id = "getAspectRatio.()Landroid/util/Pair;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAutoZoomEnabled;
#pragma warning disable 0169
		static Delegate GetIsAutoZoomEnabledHandler ()
		{
			if (cb_isAutoZoomEnabled == null)
				cb_isAutoZoomEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAutoZoomEnabled);
			return cb_isAutoZoomEnabled;
		}

		static bool n_IsAutoZoomEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoZoomEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoZoomEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoZoomEnabled_ZHandler ()
		{
			if (cb_setAutoZoomEnabled_Z == null)
				cb_setAutoZoomEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAutoZoomEnabled_Z);
			return cb_setAutoZoomEnabled_Z;
		}

		static void n_SetAutoZoomEnabled_Z (IntPtr jnienv, IntPtr native__this, bool autoZoomEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoZoomEnabled = autoZoomEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool AutoZoomEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='isAutoZoomEnabled' and count(parameter)=0]"
			[Register ("isAutoZoomEnabled", "()Z", "GetIsAutoZoomEnabledHandler")]
			get {
				const string __id = "isAutoZoomEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setAutoZoomEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoZoomEnabled", "(Z)V", "GetSetAutoZoomEnabled_ZHandler")]
			set {
				const string __id = "setAutoZoomEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCropRect;
#pragma warning disable 0169
		static Delegate GetGetCropRectHandler ()
		{
			if (cb_getCropRect == null)
				cb_getCropRect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCropRect);
			return cb_getCropRect;
		}

		static IntPtr n_GetCropRect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CropRect);
		}
#pragma warning restore 0169

		static Delegate cb_setCropRect_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetSetCropRect_Landroid_graphics_Rect_Handler ()
		{
			if (cb_setCropRect_Landroid_graphics_Rect_ == null)
				cb_setCropRect_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCropRect_Landroid_graphics_Rect_);
			return cb_setCropRect_Landroid_graphics_Rect_;
		}

		static void n_SetCropRect_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rect)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rect = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_rect, JniHandleOwnership.DoNotTransfer);
			__this.CropRect = rect;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Rect CropRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getCropRect' and count(parameter)=0]"
			[Register ("getCropRect", "()Landroid/graphics/Rect;", "GetGetCropRectHandler")]
			get {
				const string __id = "getCropRect.()Landroid/graphics/Rect;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setCropRect' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
			[Register ("setCropRect", "(Landroid/graphics/Rect;)V", "GetSetCropRect_Landroid_graphics_Rect_Handler")]
			set {
				const string __id = "setCropRect.(Landroid/graphics/Rect;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getCropWindowRect;
#pragma warning disable 0169
		static Delegate GetGetCropWindowRectHandler ()
		{
			if (cb_getCropWindowRect == null)
				cb_getCropWindowRect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCropWindowRect);
			return cb_getCropWindowRect;
		}

		static IntPtr n_GetCropWindowRect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CropWindowRect);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.RectF CropWindowRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getCropWindowRect' and count(parameter)=0]"
			[Register ("getCropWindowRect", "()Landroid/graphics/RectF;", "GetGetCropWindowRectHandler")]
			get {
				const string __id = "getCropWindowRect.()Landroid/graphics/RectF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCroppedImage;
#pragma warning disable 0169
		static Delegate GetGetCroppedImageHandler ()
		{
			if (cb_getCroppedImage == null)
				cb_getCroppedImage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCroppedImage);
			return cb_getCroppedImage;
		}

		static IntPtr n_GetCroppedImage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CroppedImage);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Bitmap CroppedImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getCroppedImage' and count(parameter)=0]"
			[Register ("getCroppedImage", "()Landroid/graphics/Bitmap;", "GetGetCroppedImageHandler")]
			get {
				const string __id = "getCroppedImage.()Landroid/graphics/Bitmap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isFlippedHorizontally;
#pragma warning disable 0169
		static Delegate GetIsFlippedHorizontallyHandler ()
		{
			if (cb_isFlippedHorizontally == null)
				cb_isFlippedHorizontally = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFlippedHorizontally);
			return cb_isFlippedHorizontally;
		}

		static bool n_IsFlippedHorizontally (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FlippedHorizontally;
		}
#pragma warning restore 0169

		static Delegate cb_setFlippedHorizontally_Z;
#pragma warning disable 0169
		static Delegate GetSetFlippedHorizontally_ZHandler ()
		{
			if (cb_setFlippedHorizontally_Z == null)
				cb_setFlippedHorizontally_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFlippedHorizontally_Z);
			return cb_setFlippedHorizontally_Z;
		}

		static void n_SetFlippedHorizontally_Z (IntPtr jnienv, IntPtr native__this, bool flipHorizontally)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FlippedHorizontally = flipHorizontally;
		}
#pragma warning restore 0169

		public virtual unsafe bool FlippedHorizontally {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='isFlippedHorizontally' and count(parameter)=0]"
			[Register ("isFlippedHorizontally", "()Z", "GetIsFlippedHorizontallyHandler")]
			get {
				const string __id = "isFlippedHorizontally.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setFlippedHorizontally' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFlippedHorizontally", "(Z)V", "GetSetFlippedHorizontally_ZHandler")]
			set {
				const string __id = "setFlippedHorizontally.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isFlippedVertically;
#pragma warning disable 0169
		static Delegate GetIsFlippedVerticallyHandler ()
		{
			if (cb_isFlippedVertically == null)
				cb_isFlippedVertically = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFlippedVertically);
			return cb_isFlippedVertically;
		}

		static bool n_IsFlippedVertically (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FlippedVertically;
		}
#pragma warning restore 0169

		static Delegate cb_setFlippedVertically_Z;
#pragma warning disable 0169
		static Delegate GetSetFlippedVertically_ZHandler ()
		{
			if (cb_setFlippedVertically_Z == null)
				cb_setFlippedVertically_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFlippedVertically_Z);
			return cb_setFlippedVertically_Z;
		}

		static void n_SetFlippedVertically_Z (IntPtr jnienv, IntPtr native__this, bool flipVertically)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FlippedVertically = flipVertically;
		}
#pragma warning restore 0169

		public virtual unsafe bool FlippedVertically {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='isFlippedVertically' and count(parameter)=0]"
			[Register ("isFlippedVertically", "()Z", "GetIsFlippedVerticallyHandler")]
			get {
				const string __id = "isFlippedVertically.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setFlippedVertically' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFlippedVertically", "(Z)V", "GetSetFlippedVertically_ZHandler")]
			set {
				const string __id = "setFlippedVertically.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageResource;
#pragma warning disable 0169
		static Delegate GetGetImageResourceHandler ()
		{
			if (cb_getImageResource == null)
				cb_getImageResource = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetImageResource);
			return cb_getImageResource;
		}

		static int n_GetImageResource (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageResource;
		}
#pragma warning restore 0169

		static Delegate cb_setImageResource_I;
#pragma warning disable 0169
		static Delegate GetSetImageResource_IHandler ()
		{
			if (cb_setImageResource_I == null)
				cb_setImageResource_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetImageResource_I);
			return cb_setImageResource_I;
		}

		static void n_SetImageResource_I (IntPtr jnienv, IntPtr native__this, int resId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ImageResource = resId;
		}
#pragma warning restore 0169

		public virtual unsafe int ImageResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getImageResource' and count(parameter)=0]"
			[Register ("getImageResource", "()I", "GetGetImageResourceHandler")]
			get {
				const string __id = "getImageResource.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setImageResource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setImageResource", "(I)V", "GetSetImageResource_IHandler")]
			set {
				const string __id = "setImageResource.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageUri;
#pragma warning disable 0169
		static Delegate GetGetImageUriHandler ()
		{
			if (cb_getImageUri == null)
				cb_getImageUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetImageUri);
			return cb_getImageUri;
		}

		static IntPtr n_GetImageUri (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageUri);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Net.Uri ImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getImageUri' and count(parameter)=0]"
			[Register ("getImageUri", "()Landroid/net/Uri;", "GetGetImageUriHandler")]
			get {
				const string __id = "getImageUri.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isFixAspectRatio;
#pragma warning disable 0169
		static Delegate GetIsFixAspectRatioHandler ()
		{
			if (cb_isFixAspectRatio == null)
				cb_isFixAspectRatio = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFixAspectRatio);
			return cb_isFixAspectRatio;
		}

		static bool n_IsFixAspectRatio (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFixAspectRatio;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFixAspectRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='isFixAspectRatio' and count(parameter)=0]"
			[Register ("isFixAspectRatio", "()Z", "GetIsFixAspectRatioHandler")]
			get {
				const string __id = "isFixAspectRatio.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxZoom;
#pragma warning disable 0169
		static Delegate GetGetMaxZoomHandler ()
		{
			if (cb_getMaxZoom == null)
				cb_getMaxZoom = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaxZoom);
			return cb_getMaxZoom;
		}

		static int n_GetMaxZoom (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoom;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxZoom_I;
#pragma warning disable 0169
		static Delegate GetSetMaxZoom_IHandler ()
		{
			if (cb_setMaxZoom_I == null)
				cb_setMaxZoom_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaxZoom_I);
			return cb_setMaxZoom_I;
		}

		static void n_SetMaxZoom_I (IntPtr jnienv, IntPtr native__this, int maxZoom)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxZoom = maxZoom;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getMaxZoom' and count(parameter)=0]"
			[Register ("getMaxZoom", "()I", "GetGetMaxZoomHandler")]
			get {
				const string __id = "getMaxZoom.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setMaxZoom' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxZoom", "(I)V", "GetSetMaxZoom_IHandler")]
			set {
				const string __id = "setMaxZoom.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRotatedDegrees;
#pragma warning disable 0169
		static Delegate GetGetRotatedDegreesHandler ()
		{
			if (cb_getRotatedDegrees == null)
				cb_getRotatedDegrees = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRotatedDegrees);
			return cb_getRotatedDegrees;
		}

		static int n_GetRotatedDegrees (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RotatedDegrees;
		}
#pragma warning restore 0169

		static Delegate cb_setRotatedDegrees_I;
#pragma warning disable 0169
		static Delegate GetSetRotatedDegrees_IHandler ()
		{
			if (cb_setRotatedDegrees_I == null)
				cb_setRotatedDegrees_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRotatedDegrees_I);
			return cb_setRotatedDegrees_I;
		}

		static void n_SetRotatedDegrees_I (IntPtr jnienv, IntPtr native__this, int degrees)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RotatedDegrees = degrees;
		}
#pragma warning restore 0169

		public virtual unsafe int RotatedDegrees {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getRotatedDegrees' and count(parameter)=0]"
			[Register ("getRotatedDegrees", "()I", "GetGetRotatedDegreesHandler")]
			get {
				const string __id = "getRotatedDegrees.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setRotatedDegrees' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRotatedDegrees", "(I)V", "GetSetRotatedDegrees_IHandler")]
			set {
				const string __id = "setRotatedDegrees.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSaveBitmapToInstanceState;
#pragma warning disable 0169
		static Delegate GetIsSaveBitmapToInstanceStateHandler ()
		{
			if (cb_isSaveBitmapToInstanceState == null)
				cb_isSaveBitmapToInstanceState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSaveBitmapToInstanceState);
			return cb_isSaveBitmapToInstanceState;
		}

		static bool n_IsSaveBitmapToInstanceState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SaveBitmapToInstanceState;
		}
#pragma warning restore 0169

		static Delegate cb_setSaveBitmapToInstanceState_Z;
#pragma warning disable 0169
		static Delegate GetSetSaveBitmapToInstanceState_ZHandler ()
		{
			if (cb_setSaveBitmapToInstanceState_Z == null)
				cb_setSaveBitmapToInstanceState_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSaveBitmapToInstanceState_Z);
			return cb_setSaveBitmapToInstanceState_Z;
		}

		static void n_SetSaveBitmapToInstanceState_Z (IntPtr jnienv, IntPtr native__this, bool saveBitmapToInstanceState)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SaveBitmapToInstanceState = saveBitmapToInstanceState;
		}
#pragma warning restore 0169

		public virtual unsafe bool SaveBitmapToInstanceState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='isSaveBitmapToInstanceState' and count(parameter)=0]"
			[Register ("isSaveBitmapToInstanceState", "()Z", "GetIsSaveBitmapToInstanceStateHandler")]
			get {
				const string __id = "isSaveBitmapToInstanceState.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setSaveBitmapToInstanceState' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSaveBitmapToInstanceState", "(Z)V", "GetSetSaveBitmapToInstanceState_ZHandler")]
			set {
				const string __id = "setSaveBitmapToInstanceState.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isShowCropOverlay;
#pragma warning disable 0169
		static Delegate GetIsShowCropOverlayHandler ()
		{
			if (cb_isShowCropOverlay == null)
				cb_isShowCropOverlay = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsShowCropOverlay);
			return cb_isShowCropOverlay;
		}

		static bool n_IsShowCropOverlay (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowCropOverlay;
		}
#pragma warning restore 0169

		static Delegate cb_setShowCropOverlay_Z;
#pragma warning disable 0169
		static Delegate GetSetShowCropOverlay_ZHandler ()
		{
			if (cb_setShowCropOverlay_Z == null)
				cb_setShowCropOverlay_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetShowCropOverlay_Z);
			return cb_setShowCropOverlay_Z;
		}

		static void n_SetShowCropOverlay_Z (IntPtr jnienv, IntPtr native__this, bool showCropOverlay)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowCropOverlay = showCropOverlay;
		}
#pragma warning restore 0169

		public virtual unsafe bool ShowCropOverlay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='isShowCropOverlay' and count(parameter)=0]"
			[Register ("isShowCropOverlay", "()Z", "GetIsShowCropOverlayHandler")]
			get {
				const string __id = "isShowCropOverlay.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setShowCropOverlay' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowCropOverlay", "(Z)V", "GetSetShowCropOverlay_ZHandler")]
			set {
				const string __id = "setShowCropOverlay.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isShowProgressBar;
#pragma warning disable 0169
		static Delegate GetIsShowProgressBarHandler ()
		{
			if (cb_isShowProgressBar == null)
				cb_isShowProgressBar = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsShowProgressBar);
			return cb_isShowProgressBar;
		}

		static bool n_IsShowProgressBar (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowProgressBar;
		}
#pragma warning restore 0169

		static Delegate cb_setShowProgressBar_Z;
#pragma warning disable 0169
		static Delegate GetSetShowProgressBar_ZHandler ()
		{
			if (cb_setShowProgressBar_Z == null)
				cb_setShowProgressBar_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetShowProgressBar_Z);
			return cb_setShowProgressBar_Z;
		}

		static void n_SetShowProgressBar_Z (IntPtr jnienv, IntPtr native__this, bool showProgressBar)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowProgressBar = showProgressBar;
		}
#pragma warning restore 0169

		public virtual unsafe bool ShowProgressBar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='isShowProgressBar' and count(parameter)=0]"
			[Register ("isShowProgressBar", "()Z", "GetIsShowProgressBarHandler")]
			get {
				const string __id = "isShowProgressBar.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setShowProgressBar' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowProgressBar", "(Z)V", "GetSetShowProgressBar_ZHandler")]
			set {
				const string __id = "setShowProgressBar.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWholeImageRect;
#pragma warning disable 0169
		static Delegate GetGetWholeImageRectHandler ()
		{
			if (cb_getWholeImageRect == null)
				cb_getWholeImageRect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWholeImageRect);
			return cb_getWholeImageRect;
		}

		static IntPtr n_GetWholeImageRect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WholeImageRect);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Rect WholeImageRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getWholeImageRect' and count(parameter)=0]"
			[Register ("getWholeImageRect", "()Landroid/graphics/Rect;", "GetGetWholeImageRectHandler")]
			get {
				const string __id = "getWholeImageRect.()Landroid/graphics/Rect;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearAspectRatio;
#pragma warning disable 0169
		static Delegate GetClearAspectRatioHandler ()
		{
			if (cb_clearAspectRatio == null)
				cb_clearAspectRatio = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearAspectRatio);
			return cb_clearAspectRatio;
		}

		static void n_ClearAspectRatio (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAspectRatio ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='clearAspectRatio' and count(parameter)=0]"
		[Register ("clearAspectRatio", "()V", "GetClearAspectRatioHandler")]
		public virtual unsafe void ClearAspectRatio ()
		{
			const string __id = "clearAspectRatio.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearImage;
#pragma warning disable 0169
		static Delegate GetClearImageHandler ()
		{
			if (cb_clearImage == null)
				cb_clearImage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearImage);
			return cb_clearImage;
		}

		static void n_ClearImage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearImage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='clearImage' and count(parameter)=0]"
		[Register ("clearImage", "()V", "GetClearImageHandler")]
		public virtual unsafe void ClearImage ()
		{
			const string __id = "clearImage.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_flipImageHorizontally;
#pragma warning disable 0169
		static Delegate GetFlipImageHorizontallyHandler ()
		{
			if (cb_flipImageHorizontally == null)
				cb_flipImageHorizontally = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FlipImageHorizontally);
			return cb_flipImageHorizontally;
		}

		static void n_FlipImageHorizontally (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FlipImageHorizontally ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='flipImageHorizontally' and count(parameter)=0]"
		[Register ("flipImageHorizontally", "()V", "GetFlipImageHorizontallyHandler")]
		public virtual unsafe void FlipImageHorizontally ()
		{
			const string __id = "flipImageHorizontally.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_flipImageVertically;
#pragma warning disable 0169
		static Delegate GetFlipImageVerticallyHandler ()
		{
			if (cb_flipImageVertically == null)
				cb_flipImageVertically = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FlipImageVertically);
			return cb_flipImageVertically;
		}

		static void n_FlipImageVertically (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FlipImageVertically ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='flipImageVertically' and count(parameter)=0]"
		[Register ("flipImageVertically", "()V", "GetFlipImageVerticallyHandler")]
		public virtual unsafe void FlipImageVertically ()
		{
			const string __id = "flipImageVertically.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getCropPoints;
#pragma warning disable 0169
		static Delegate GetGetCropPointsHandler ()
		{
			if (cb_getCropPoints == null)
				cb_getCropPoints = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCropPoints);
			return cb_getCropPoints;
		}

		static IntPtr n_GetCropPoints (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCropPoints ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getCropPoints' and count(parameter)=0]"
		[Register ("getCropPoints", "()[F", "GetGetCropPointsHandler")]
		public virtual unsafe float[] GetCropPoints ()
		{
			const string __id = "getCropPoints.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getCropShape;
#pragma warning disable 0169
		static Delegate GetGetCropShapeHandler ()
		{
			if (cb_getCropShape == null)
				cb_getCropShape = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCropShape);
			return cb_getCropShape;
		}

		static IntPtr n_GetCropShape (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCropShape ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getCropShape' and count(parameter)=0]"
		[Register ("getCropShape", "()Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;", "GetGetCropShapeHandler")]
		public virtual unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape GetCropShape ()
		{
			const string __id = "getCropShape.()Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getCroppedImage_II;
#pragma warning disable 0169
		static Delegate GetGetCroppedImage_IIHandler ()
		{
			if (cb_getCroppedImage_II == null)
				cb_getCroppedImage_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_GetCroppedImage_II);
			return cb_getCroppedImage_II;
		}

		static IntPtr n_GetCroppedImage_II (IntPtr jnienv, IntPtr native__this, int reqWidth, int reqHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCroppedImage (reqWidth, reqHeight));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getCroppedImage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getCroppedImage", "(II)Landroid/graphics/Bitmap;", "GetGetCroppedImage_IIHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap GetCroppedImage (int reqWidth, int reqHeight)
		{
			const string __id = "getCroppedImage.(II)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (reqWidth);
				__args [1] = new JniArgumentValue (reqHeight);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getCroppedImage_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_;
#pragma warning disable 0169
		static Delegate GetGetCroppedImage_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Handler ()
		{
			if (cb_getCroppedImage_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_ == null)
				cb_getCroppedImage_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_L) n_GetCroppedImage_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_);
			return cb_getCroppedImage_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_;
		}

		static IntPtr n_GetCroppedImage_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_ (IntPtr jnienv, IntPtr native__this, int reqWidth, int reqHeight, IntPtr native_options)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCroppedImage (reqWidth, reqHeight, options));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getCroppedImage' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.theartofdev.edmodo.cropper.CropImageView.RequestSizeOptions']]"
		[Register ("getCroppedImage", "(IILcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;)Landroid/graphics/Bitmap;", "GetGetCroppedImage_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap GetCroppedImage (int reqWidth, int reqHeight, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions options)
		{
			const string __id = "getCroppedImage.(IILcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (reqWidth);
				__args [1] = new JniArgumentValue (reqHeight);
				__args [2] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (options);
			}
		}

		static Delegate cb_getCroppedImageAsync;
#pragma warning disable 0169
		static Delegate GetGetCroppedImageAsyncHandler ()
		{
			if (cb_getCroppedImageAsync == null)
				cb_getCroppedImageAsync = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_GetCroppedImageAsync);
			return cb_getCroppedImageAsync;
		}

		static void n_GetCroppedImageAsync (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetCroppedImageAsync ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getCroppedImageAsync' and count(parameter)=0]"
		[Register ("getCroppedImageAsync", "()V", "GetGetCroppedImageAsyncHandler")]
		public virtual unsafe void GetCroppedImageAsync ()
		{
			const string __id = "getCroppedImageAsync.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getCroppedImageAsync_II;
#pragma warning disable 0169
		static Delegate GetGetCroppedImageAsync_IIHandler ()
		{
			if (cb_getCroppedImageAsync_II == null)
				cb_getCroppedImageAsync_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_GetCroppedImageAsync_II);
			return cb_getCroppedImageAsync_II;
		}

		static void n_GetCroppedImageAsync_II (IntPtr jnienv, IntPtr native__this, int reqWidth, int reqHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetCroppedImageAsync (reqWidth, reqHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getCroppedImageAsync' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getCroppedImageAsync", "(II)V", "GetGetCroppedImageAsync_IIHandler")]
		public virtual unsafe void GetCroppedImageAsync (int reqWidth, int reqHeight)
		{
			const string __id = "getCroppedImageAsync.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (reqWidth);
				__args [1] = new JniArgumentValue (reqHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCroppedImageAsync_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_;
#pragma warning disable 0169
		static Delegate GetGetCroppedImageAsync_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Handler ()
		{
			if (cb_getCroppedImageAsync_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_ == null)
				cb_getCroppedImageAsync_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_V) n_GetCroppedImageAsync_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_);
			return cb_getCroppedImageAsync_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_;
		}

		static void n_GetCroppedImageAsync_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_ (IntPtr jnienv, IntPtr native__this, int reqWidth, int reqHeight, IntPtr native_options)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.GetCroppedImageAsync (reqWidth, reqHeight, options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getCroppedImageAsync' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.theartofdev.edmodo.cropper.CropImageView.RequestSizeOptions']]"
		[Register ("getCroppedImageAsync", "(IILcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;)V", "GetGetCroppedImageAsync_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Handler")]
		public virtual unsafe void GetCroppedImageAsync (int reqWidth, int reqHeight, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions options)
		{
			const string __id = "getCroppedImageAsync.(IILcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (reqWidth);
				__args [1] = new JniArgumentValue (reqHeight);
				__args [2] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (options);
			}
		}

		static Delegate cb_getGuidelines;
#pragma warning disable 0169
		static Delegate GetGetGuidelinesHandler ()
		{
			if (cb_getGuidelines == null)
				cb_getGuidelines = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGuidelines);
			return cb_getGuidelines;
		}

		static IntPtr n_GetGuidelines (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetGuidelines ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getGuidelines' and count(parameter)=0]"
		[Register ("getGuidelines", "()Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;", "GetGetGuidelinesHandler")]
		public virtual unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines GetGuidelines ()
		{
			const string __id = "getGuidelines.()Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getScaleType;
#pragma warning disable 0169
		static Delegate GetGetScaleTypeHandler ()
		{
			if (cb_getScaleType == null)
				cb_getScaleType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScaleType);
			return cb_getScaleType;
		}

		static IntPtr n_GetScaleType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetScaleType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='getScaleType' and count(parameter)=0]"
		[Register ("getScaleType", "()Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;", "GetGetScaleTypeHandler")]
		public virtual unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType GetScaleType ()
		{
			const string __id = "getScaleType.()Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;
#pragma warning disable 0169
		static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler ()
		{
			if (cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
				cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnRestoreInstanceState_Landroid_os_Parcelable_);
			return cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		static void n_OnRestoreInstanceState_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var state = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_state, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (state);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register ("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler")]
		public virtual unsafe void OnRestoreInstanceState (global::Android.OS.IParcelable state)
		{
			const string __id = "onRestoreInstanceState.(Landroid/os/Parcelable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((state == null) ? IntPtr.Zero : ((global::Java.Lang.Object) state).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (state);
			}
		}

		static Delegate cb_onSaveInstanceState;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceStateHandler ()
		{
			if (cb_onSaveInstanceState == null)
				cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OnSaveInstanceState);
			return cb_onSaveInstanceState;
		}

		static IntPtr n_OnSaveInstanceState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='onSaveInstanceState' and count(parameter)=0]"
		[Register ("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
		public virtual unsafe global::Android.OS.IParcelable OnSaveInstanceState ()
		{
			const string __id = "onSaveInstanceState.()Landroid/os/Parcelable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_resetCropRect;
#pragma warning disable 0169
		static Delegate GetResetCropRectHandler ()
		{
			if (cb_resetCropRect == null)
				cb_resetCropRect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ResetCropRect);
			return cb_resetCropRect;
		}

		static void n_ResetCropRect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetCropRect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='resetCropRect' and count(parameter)=0]"
		[Register ("resetCropRect", "()V", "GetResetCropRectHandler")]
		public virtual unsafe void ResetCropRect ()
		{
			const string __id = "resetCropRect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_rotateImage_I;
#pragma warning disable 0169
		static Delegate GetRotateImage_IHandler ()
		{
			if (cb_rotateImage_I == null)
				cb_rotateImage_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_RotateImage_I);
			return cb_rotateImage_I;
		}

		static void n_RotateImage_I (IntPtr jnienv, IntPtr native__this, int degrees)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RotateImage (degrees);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='rotateImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("rotateImage", "(I)V", "GetRotateImage_IHandler")]
		public virtual unsafe void RotateImage (int degrees)
		{
			const string __id = "rotateImage.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (degrees);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_saveCroppedImageAsync_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSaveCroppedImageAsync_Landroid_net_Uri_Handler ()
		{
			if (cb_saveCroppedImageAsync_Landroid_net_Uri_ == null)
				cb_saveCroppedImageAsync_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveCroppedImageAsync_Landroid_net_Uri_);
			return cb_saveCroppedImageAsync_Landroid_net_Uri_;
		}

		static void n_SaveCroppedImageAsync_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_saveUri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var saveUri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_saveUri, JniHandleOwnership.DoNotTransfer);
			__this.SaveCroppedImageAsync (saveUri);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='saveCroppedImageAsync' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("saveCroppedImageAsync", "(Landroid/net/Uri;)V", "GetSaveCroppedImageAsync_Landroid_net_Uri_Handler")]
		public virtual unsafe void SaveCroppedImageAsync (global::Android.Net.Uri saveUri)
		{
			const string __id = "saveCroppedImageAsync.(Landroid/net/Uri;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((saveUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) saveUri).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (saveUri);
			}
		}

		static Delegate cb_saveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_I;
#pragma warning disable 0169
		static Delegate GetSaveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IHandler ()
		{
			if (cb_saveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_I == null)
				cb_saveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_SaveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_I);
			return cb_saveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_I;
		}

		static void n_SaveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_I (IntPtr jnienv, IntPtr native__this, IntPtr native_saveUri, IntPtr native_saveCompressFormat, int saveCompressQuality)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var saveUri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_saveUri, JniHandleOwnership.DoNotTransfer);
			var saveCompressFormat = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (native_saveCompressFormat, JniHandleOwnership.DoNotTransfer);
			__this.SaveCroppedImageAsync (saveUri, saveCompressFormat, saveCompressQuality);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='saveCroppedImageAsync' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.graphics.Bitmap.CompressFormat'] and parameter[3][@type='int']]"
		[Register ("saveCroppedImageAsync", "(Landroid/net/Uri;Landroid/graphics/Bitmap$CompressFormat;I)V", "GetSaveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IHandler")]
		public virtual unsafe void SaveCroppedImageAsync (global::Android.Net.Uri saveUri, global::Android.Graphics.Bitmap.CompressFormat saveCompressFormat, int saveCompressQuality)
		{
			const string __id = "saveCroppedImageAsync.(Landroid/net/Uri;Landroid/graphics/Bitmap$CompressFormat;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((saveUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) saveUri).Handle);
				__args [1] = new JniArgumentValue ((saveCompressFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) saveCompressFormat).Handle);
				__args [2] = new JniArgumentValue (saveCompressQuality);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (saveUri);
				global::System.GC.KeepAlive (saveCompressFormat);
			}
		}

		static Delegate cb_saveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_III;
#pragma warning disable 0169
		static Delegate GetSaveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IIIHandler ()
		{
			if (cb_saveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_III == null)
				cb_saveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIII_V) n_SaveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_III);
			return cb_saveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_III;
		}

		static void n_SaveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_III (IntPtr jnienv, IntPtr native__this, IntPtr native_saveUri, IntPtr native_saveCompressFormat, int saveCompressQuality, int reqWidth, int reqHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var saveUri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_saveUri, JniHandleOwnership.DoNotTransfer);
			var saveCompressFormat = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (native_saveCompressFormat, JniHandleOwnership.DoNotTransfer);
			__this.SaveCroppedImageAsync (saveUri, saveCompressFormat, saveCompressQuality, reqWidth, reqHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='saveCroppedImageAsync' and count(parameter)=5 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.graphics.Bitmap.CompressFormat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("saveCroppedImageAsync", "(Landroid/net/Uri;Landroid/graphics/Bitmap$CompressFormat;III)V", "GetSaveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IIIHandler")]
		public virtual unsafe void SaveCroppedImageAsync (global::Android.Net.Uri saveUri, global::Android.Graphics.Bitmap.CompressFormat saveCompressFormat, int saveCompressQuality, int reqWidth, int reqHeight)
		{
			const string __id = "saveCroppedImageAsync.(Landroid/net/Uri;Landroid/graphics/Bitmap$CompressFormat;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((saveUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) saveUri).Handle);
				__args [1] = new JniArgumentValue ((saveCompressFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) saveCompressFormat).Handle);
				__args [2] = new JniArgumentValue (saveCompressQuality);
				__args [3] = new JniArgumentValue (reqWidth);
				__args [4] = new JniArgumentValue (reqHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (saveUri);
				global::System.GC.KeepAlive (saveCompressFormat);
			}
		}

		static Delegate cb_saveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IIILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_;
#pragma warning disable 0169
		static Delegate GetSaveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IIILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Handler ()
		{
			if (cb_saveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IIILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_ == null)
				cb_saveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IIILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIIIL_V) n_SaveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IIILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_);
			return cb_saveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IIILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_;
		}

		static void n_SaveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IIILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_saveUri, IntPtr native_saveCompressFormat, int saveCompressQuality, int reqWidth, int reqHeight, IntPtr native_options)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var saveUri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_saveUri, JniHandleOwnership.DoNotTransfer);
			var saveCompressFormat = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (native_saveCompressFormat, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.SaveCroppedImageAsync (saveUri, saveCompressFormat, saveCompressQuality, reqWidth, reqHeight, options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='saveCroppedImageAsync' and count(parameter)=6 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.graphics.Bitmap.CompressFormat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='com.theartofdev.edmodo.cropper.CropImageView.RequestSizeOptions']]"
		[Register ("saveCroppedImageAsync", "(Landroid/net/Uri;Landroid/graphics/Bitmap$CompressFormat;IIILcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;)V", "GetSaveCroppedImageAsync_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IIILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Handler")]
		public virtual unsafe void SaveCroppedImageAsync (global::Android.Net.Uri saveUri, global::Android.Graphics.Bitmap.CompressFormat saveCompressFormat, int saveCompressQuality, int reqWidth, int reqHeight, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions options)
		{
			const string __id = "saveCroppedImageAsync.(Landroid/net/Uri;Landroid/graphics/Bitmap$CompressFormat;IIILcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((saveUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) saveUri).Handle);
				__args [1] = new JniArgumentValue ((saveCompressFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) saveCompressFormat).Handle);
				__args [2] = new JniArgumentValue (saveCompressQuality);
				__args [3] = new JniArgumentValue (reqWidth);
				__args [4] = new JniArgumentValue (reqHeight);
				__args [5] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (saveUri);
				global::System.GC.KeepAlive (saveCompressFormat);
				global::System.GC.KeepAlive (options);
			}
		}

		static Delegate cb_setAspectRatio_II;
#pragma warning disable 0169
		static Delegate GetSetAspectRatio_IIHandler ()
		{
			if (cb_setAspectRatio_II == null)
				cb_setAspectRatio_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetAspectRatio_II);
			return cb_setAspectRatio_II;
		}

		static void n_SetAspectRatio_II (IntPtr jnienv, IntPtr native__this, int aspectRatioX, int aspectRatioY)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAspectRatio (aspectRatioX, aspectRatioY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setAspectRatio' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setAspectRatio", "(II)V", "GetSetAspectRatio_IIHandler")]
		public virtual unsafe void SetAspectRatio (int aspectRatioX, int aspectRatioY)
		{
			const string __id = "setAspectRatio.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (aspectRatioX);
				__args [1] = new JniArgumentValue (aspectRatioY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCropShape_Lcom_theartofdev_edmodo_cropper_CropImageView_CropShape_;
#pragma warning disable 0169
		static Delegate GetSetCropShape_Lcom_theartofdev_edmodo_cropper_CropImageView_CropShape_Handler ()
		{
			if (cb_setCropShape_Lcom_theartofdev_edmodo_cropper_CropImageView_CropShape_ == null)
				cb_setCropShape_Lcom_theartofdev_edmodo_cropper_CropImageView_CropShape_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCropShape_Lcom_theartofdev_edmodo_cropper_CropImageView_CropShape_);
			return cb_setCropShape_Lcom_theartofdev_edmodo_cropper_CropImageView_CropShape_;
		}

		static void n_SetCropShape_Lcom_theartofdev_edmodo_cropper_CropImageView_CropShape_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cropShape)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cropShape = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape> (native_cropShape, JniHandleOwnership.DoNotTransfer);
			__this.SetCropShape (cropShape);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setCropShape' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView.CropShape']]"
		[Register ("setCropShape", "(Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;)V", "GetSetCropShape_Lcom_theartofdev_edmodo_cropper_CropImageView_CropShape_Handler")]
		public virtual unsafe void SetCropShape (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape cropShape)
		{
			const string __id = "setCropShape.(Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cropShape == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cropShape).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cropShape);
			}
		}

		static Delegate cb_setFixedAspectRatio_Z;
#pragma warning disable 0169
		static Delegate GetSetFixedAspectRatio_ZHandler ()
		{
			if (cb_setFixedAspectRatio_Z == null)
				cb_setFixedAspectRatio_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFixedAspectRatio_Z);
			return cb_setFixedAspectRatio_Z;
		}

		static void n_SetFixedAspectRatio_Z (IntPtr jnienv, IntPtr native__this, bool fixAspectRatio)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFixedAspectRatio (fixAspectRatio);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setFixedAspectRatio' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFixedAspectRatio", "(Z)V", "GetSetFixedAspectRatio_ZHandler")]
		public virtual unsafe void SetFixedAspectRatio (bool fixAspectRatio)
		{
			const string __id = "setFixedAspectRatio.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fixAspectRatio);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setGuidelines_Lcom_theartofdev_edmodo_cropper_CropImageView_Guidelines_;
#pragma warning disable 0169
		static Delegate GetSetGuidelines_Lcom_theartofdev_edmodo_cropper_CropImageView_Guidelines_Handler ()
		{
			if (cb_setGuidelines_Lcom_theartofdev_edmodo_cropper_CropImageView_Guidelines_ == null)
				cb_setGuidelines_Lcom_theartofdev_edmodo_cropper_CropImageView_Guidelines_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetGuidelines_Lcom_theartofdev_edmodo_cropper_CropImageView_Guidelines_);
			return cb_setGuidelines_Lcom_theartofdev_edmodo_cropper_CropImageView_Guidelines_;
		}

		static void n_SetGuidelines_Lcom_theartofdev_edmodo_cropper_CropImageView_Guidelines_ (IntPtr jnienv, IntPtr native__this, IntPtr native_guidelines)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var guidelines = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines> (native_guidelines, JniHandleOwnership.DoNotTransfer);
			__this.SetGuidelines (guidelines);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setGuidelines' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView.Guidelines']]"
		[Register ("setGuidelines", "(Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;)V", "GetSetGuidelines_Lcom_theartofdev_edmodo_cropper_CropImageView_Guidelines_Handler")]
		public virtual unsafe void SetGuidelines (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines guidelines)
		{
			const string __id = "setGuidelines.(Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((guidelines == null) ? IntPtr.Zero : ((global::Java.Lang.Object) guidelines).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (guidelines);
			}
		}

		static Delegate cb_setImageBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetImageBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setImageBitmap_Landroid_graphics_Bitmap_ == null)
				cb_setImageBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetImageBitmap_Landroid_graphics_Bitmap_);
			return cb_setImageBitmap_Landroid_graphics_Bitmap_;
		}

		static void n_SetImageBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.SetImageBitmap (bitmap);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setImageBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setImageBitmap", "(Landroid/graphics/Bitmap;)V", "GetSetImageBitmap_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetImageBitmap (global::Android.Graphics.Bitmap bitmap)
		{
			const string __id = "setImageBitmap.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bitmap);
			}
		}

		static Delegate cb_setImageUriAsync_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetImageUriAsync_Landroid_net_Uri_Handler ()
		{
			if (cb_setImageUriAsync_Landroid_net_Uri_ == null)
				cb_setImageUriAsync_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetImageUriAsync_Landroid_net_Uri_);
			return cb_setImageUriAsync_Landroid_net_Uri_;
		}

		static void n_SetImageUriAsync_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			__this.SetImageUriAsync (uri);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setImageUriAsync' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("setImageUriAsync", "(Landroid/net/Uri;)V", "GetSetImageUriAsync_Landroid_net_Uri_Handler")]
		public virtual unsafe void SetImageUriAsync (global::Android.Net.Uri uri)
		{
			const string __id = "setImageUriAsync.(Landroid/net/Uri;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

		static Delegate cb_setMaxCropResultSize_II;
#pragma warning disable 0169
		static Delegate GetSetMaxCropResultSize_IIHandler ()
		{
			if (cb_setMaxCropResultSize_II == null)
				cb_setMaxCropResultSize_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetMaxCropResultSize_II);
			return cb_setMaxCropResultSize_II;
		}

		static void n_SetMaxCropResultSize_II (IntPtr jnienv, IntPtr native__this, int maxCropResultWidth, int maxCropResultHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxCropResultSize (maxCropResultWidth, maxCropResultHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setMaxCropResultSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setMaxCropResultSize", "(II)V", "GetSetMaxCropResultSize_IIHandler")]
		public virtual unsafe void SetMaxCropResultSize (int maxCropResultWidth, int maxCropResultHeight)
		{
			const string __id = "setMaxCropResultSize.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (maxCropResultWidth);
				__args [1] = new JniArgumentValue (maxCropResultHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMinCropResultSize_II;
#pragma warning disable 0169
		static Delegate GetSetMinCropResultSize_IIHandler ()
		{
			if (cb_setMinCropResultSize_II == null)
				cb_setMinCropResultSize_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetMinCropResultSize_II);
			return cb_setMinCropResultSize_II;
		}

		static void n_SetMinCropResultSize_II (IntPtr jnienv, IntPtr native__this, int minCropResultWidth, int minCropResultHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMinCropResultSize (minCropResultWidth, minCropResultHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setMinCropResultSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setMinCropResultSize", "(II)V", "GetSetMinCropResultSize_IIHandler")]
		public virtual unsafe void SetMinCropResultSize (int minCropResultWidth, int minCropResultHeight)
		{
			const string __id = "setMinCropResultSize.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (minCropResultWidth);
				__args [1] = new JniArgumentValue (minCropResultHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMultiTouchEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetMultiTouchEnabled_ZHandler ()
		{
			if (cb_setMultiTouchEnabled_Z == null)
				cb_setMultiTouchEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetMultiTouchEnabled_Z);
			return cb_setMultiTouchEnabled_Z;
		}

		static void n_SetMultiTouchEnabled_Z (IntPtr jnienv, IntPtr native__this, bool multiTouchEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMultiTouchEnabled (multiTouchEnabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setMultiTouchEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMultiTouchEnabled", "(Z)V", "GetSetMultiTouchEnabled_ZHandler")]
		public virtual unsafe void SetMultiTouchEnabled (bool multiTouchEnabled)
		{
			const string __id = "setMultiTouchEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (multiTouchEnabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnCropImageCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnCropImageCompleteListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCropImageCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnCropImageCompleteListener_Handler ()
		{
			if (cb_setOnCropImageCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnCropImageCompleteListener_ == null)
				cb_setOnCropImageCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnCropImageCompleteListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnCropImageCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnCropImageCompleteListener_);
			return cb_setOnCropImageCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnCropImageCompleteListener_;
		}

		static void n_SetOnCropImageCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnCropImageCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnCropImageCompleteListener)global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnCropImageCompleteListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCropImageCompleteListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setOnCropImageCompleteListener' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView.OnCropImageCompleteListener']]"
		[Register ("setOnCropImageCompleteListener", "(Lcom/theartofdev/edmodo/cropper/CropImageView$OnCropImageCompleteListener;)V", "GetSetOnCropImageCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnCropImageCompleteListener_Handler")]
		public virtual unsafe void SetOnCropImageCompleteListener (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnCropImageCompleteListener listener)
		{
			const string __id = "setOnCropImageCompleteListener.(Lcom/theartofdev/edmodo/cropper/CropImageView$OnCropImageCompleteListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setOnCropWindowChangedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropWindowChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCropWindowChangedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropWindowChangeListener_Handler ()
		{
			if (cb_setOnCropWindowChangedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropWindowChangeListener_ == null)
				cb_setOnCropWindowChangedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropWindowChangeListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnCropWindowChangedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropWindowChangeListener_);
			return cb_setOnCropWindowChangedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropWindowChangeListener_;
		}

		static void n_SetOnCropWindowChangedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropWindowChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropWindowChangeListener)global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropWindowChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCropWindowChangedListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setOnCropWindowChangedListener' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView.OnSetCropWindowChangeListener']]"
		[Register ("setOnCropWindowChangedListener", "(Lcom/theartofdev/edmodo/cropper/CropImageView$OnSetCropWindowChangeListener;)V", "GetSetOnCropWindowChangedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropWindowChangeListener_Handler")]
		public virtual unsafe void SetOnCropWindowChangedListener (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropWindowChangeListener listener)
		{
			const string __id = "setOnCropWindowChangedListener.(Lcom/theartofdev/edmodo/cropper/CropImageView$OnSetCropWindowChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setOnSetCropOverlayMovedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayMovedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSetCropOverlayMovedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayMovedListener_Handler ()
		{
			if (cb_setOnSetCropOverlayMovedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayMovedListener_ == null)
				cb_setOnSetCropOverlayMovedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayMovedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnSetCropOverlayMovedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayMovedListener_);
			return cb_setOnSetCropOverlayMovedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayMovedListener_;
		}

		static void n_SetOnSetCropOverlayMovedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayMovedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayMovedListener)global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayMovedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnSetCropOverlayMovedListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setOnSetCropOverlayMovedListener' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView.OnSetCropOverlayMovedListener']]"
		[Register ("setOnSetCropOverlayMovedListener", "(Lcom/theartofdev/edmodo/cropper/CropImageView$OnSetCropOverlayMovedListener;)V", "GetSetOnSetCropOverlayMovedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayMovedListener_Handler")]
		public virtual unsafe void SetOnSetCropOverlayMovedListener (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayMovedListener listener)
		{
			const string __id = "setOnSetCropOverlayMovedListener.(Lcom/theartofdev/edmodo/cropper/CropImageView$OnSetCropOverlayMovedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setOnSetCropOverlayReleasedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayReleasedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSetCropOverlayReleasedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayReleasedListener_Handler ()
		{
			if (cb_setOnSetCropOverlayReleasedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayReleasedListener_ == null)
				cb_setOnSetCropOverlayReleasedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayReleasedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnSetCropOverlayReleasedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayReleasedListener_);
			return cb_setOnSetCropOverlayReleasedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayReleasedListener_;
		}

		static void n_SetOnSetCropOverlayReleasedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayReleasedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayReleasedListener)global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayReleasedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnSetCropOverlayReleasedListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setOnSetCropOverlayReleasedListener' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView.OnSetCropOverlayReleasedListener']]"
		[Register ("setOnSetCropOverlayReleasedListener", "(Lcom/theartofdev/edmodo/cropper/CropImageView$OnSetCropOverlayReleasedListener;)V", "GetSetOnSetCropOverlayReleasedListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetCropOverlayReleasedListener_Handler")]
		public virtual unsafe void SetOnSetCropOverlayReleasedListener (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayReleasedListener listener)
		{
			const string __id = "setOnSetCropOverlayReleasedListener.(Lcom/theartofdev/edmodo/cropper/CropImageView$OnSetCropOverlayReleasedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setOnSetImageUriCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetImageUriCompleteListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSetImageUriCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetImageUriCompleteListener_Handler ()
		{
			if (cb_setOnSetImageUriCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetImageUriCompleteListener_ == null)
				cb_setOnSetImageUriCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetImageUriCompleteListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnSetImageUriCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetImageUriCompleteListener_);
			return cb_setOnSetImageUriCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetImageUriCompleteListener_;
		}

		static void n_SetOnSetImageUriCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetImageUriCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetImageUriCompleteListener)global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetImageUriCompleteListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnSetImageUriCompleteListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setOnSetImageUriCompleteListener' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView.OnSetImageUriCompleteListener']]"
		[Register ("setOnSetImageUriCompleteListener", "(Lcom/theartofdev/edmodo/cropper/CropImageView$OnSetImageUriCompleteListener;)V", "GetSetOnSetImageUriCompleteListener_Lcom_theartofdev_edmodo_cropper_CropImageView_OnSetImageUriCompleteListener_Handler")]
		public virtual unsafe void SetOnSetImageUriCompleteListener (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetImageUriCompleteListener listener)
		{
			const string __id = "setOnSetImageUriCompleteListener.(Lcom/theartofdev/edmodo/cropper/CropImageView$OnSetImageUriCompleteListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setScaleType_Lcom_theartofdev_edmodo_cropper_CropImageView_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetScaleType_Lcom_theartofdev_edmodo_cropper_CropImageView_ScaleType_Handler ()
		{
			if (cb_setScaleType_Lcom_theartofdev_edmodo_cropper_CropImageView_ScaleType_ == null)
				cb_setScaleType_Lcom_theartofdev_edmodo_cropper_CropImageView_ScaleType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetScaleType_Lcom_theartofdev_edmodo_cropper_CropImageView_ScaleType_);
			return cb_setScaleType_Lcom_theartofdev_edmodo_cropper_CropImageView_ScaleType_;
		}

		static void n_SetScaleType_Lcom_theartofdev_edmodo_cropper_CropImageView_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scaleType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scaleType = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleType (scaleType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setScaleType' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView.ScaleType']]"
		[Register ("setScaleType", "(Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;)V", "GetSetScaleType_Lcom_theartofdev_edmodo_cropper_CropImageView_ScaleType_Handler")]
		public virtual unsafe void SetScaleType (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType scaleType)
		{
			const string __id = "setScaleType.(Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((scaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleType).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (scaleType);
			}
		}

		static Delegate cb_setSnapRadius_F;
#pragma warning disable 0169
		static Delegate GetSetSnapRadius_FHandler ()
		{
			if (cb_setSnapRadius_F == null)
				cb_setSnapRadius_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetSnapRadius_F);
			return cb_setSnapRadius_F;
		}

		static void n_SetSnapRadius_F (IntPtr jnienv, IntPtr native__this, float snapRadius)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSnapRadius (snapRadius);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='setSnapRadius' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSnapRadius", "(F)V", "GetSetSnapRadius_FHandler")]
		public virtual unsafe void SetSnapRadius (float snapRadius)
		{
			const string __id = "setSnapRadius.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (snapRadius);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startCropWorkerTask_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_I;
#pragma warning disable 0169
		static Delegate GetStartCropWorkerTask_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IHandler ()
		{
			if (cb_startCropWorkerTask_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_I == null)
				cb_startCropWorkerTask_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIILLLI_V) n_StartCropWorkerTask_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_I);
			return cb_startCropWorkerTask_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_I;
		}

		static void n_StartCropWorkerTask_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_I (IntPtr jnienv, IntPtr native__this, int reqWidth, int reqHeight, IntPtr native_options, IntPtr native_saveUri, IntPtr native_saveCompressFormat, int saveCompressQuality)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			var saveUri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_saveUri, JniHandleOwnership.DoNotTransfer);
			var saveCompressFormat = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (native_saveCompressFormat, JniHandleOwnership.DoNotTransfer);
			__this.StartCropWorkerTask (reqWidth, reqHeight, options, saveUri, saveCompressFormat, saveCompressQuality);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageView']/method[@name='startCropWorkerTask' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.theartofdev.edmodo.cropper.CropImageView.RequestSizeOptions'] and parameter[4][@type='android.net.Uri'] and parameter[5][@type='android.graphics.Bitmap.CompressFormat'] and parameter[6][@type='int']]"
		[Register ("startCropWorkerTask", "(IILcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;Landroid/net/Uri;Landroid/graphics/Bitmap$CompressFormat;I)V", "GetStartCropWorkerTask_IILcom_theartofdev_edmodo_cropper_CropImageView_RequestSizeOptions_Landroid_net_Uri_Landroid_graphics_Bitmap_CompressFormat_IHandler")]
		public virtual unsafe void StartCropWorkerTask (int reqWidth, int reqHeight, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions options, global::Android.Net.Uri saveUri, global::Android.Graphics.Bitmap.CompressFormat saveCompressFormat, int saveCompressQuality)
		{
			const string __id = "startCropWorkerTask.(IILcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;Landroid/net/Uri;Landroid/graphics/Bitmap$CompressFormat;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (reqWidth);
				__args [1] = new JniArgumentValue (reqHeight);
				__args [2] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [3] = new JniArgumentValue ((saveUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) saveUri).Handle);
				__args [4] = new JniArgumentValue ((saveCompressFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) saveCompressFormat).Handle);
				__args [5] = new JniArgumentValue (saveCompressQuality);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (saveUri);
				global::System.GC.KeepAlive (saveCompressFormat);
			}
		}

#region "Event implementation for Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnCropImageCompleteListener"
		public event EventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropImageCompleteEventArgs> CropImageComplete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnCropImageCompleteListener, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnCropImageCompleteListenerImplementor>(
						ref weak_implementor_SetOnCropImageCompleteListener,
						__CreateIOnCropImageCompleteListenerImplementor,
						SetOnCropImageCompleteListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnCropImageCompleteListener, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnCropImageCompleteListenerImplementor>(
						ref weak_implementor_SetOnCropImageCompleteListener,
						global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnCropImageCompleteListenerImplementor.__IsEmpty,
						__v => SetOnCropImageCompleteListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCropImageCompleteListener;

		global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnCropImageCompleteListenerImplementor __CreateIOnCropImageCompleteListenerImplementor ()
		{
			return new global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnCropImageCompleteListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropWindowChangeListener"
		public event EventHandler CropWindowChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropWindowChangeListener, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropWindowChangeListenerImplementor>(
						ref weak_implementor_SetOnCropWindowChangedListener,
						__CreateIOnSetCropWindowChangeListenerImplementor,
						SetOnCropWindowChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropWindowChangeListener, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropWindowChangeListenerImplementor>(
						ref weak_implementor_SetOnCropWindowChangedListener,
						global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropWindowChangeListenerImplementor.__IsEmpty,
						__v => SetOnCropWindowChangedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCropWindowChangedListener;

		global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropWindowChangeListenerImplementor __CreateIOnSetCropWindowChangeListenerImplementor ()
		{
			return new global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropWindowChangeListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayMovedListener"
		public event EventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.SetCropOverlayMovedEventArgs> SetCropOverlayMoved {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayMovedListener, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayMovedListenerImplementor>(
						ref weak_implementor_SetOnSetCropOverlayMovedListener,
						__CreateIOnSetCropOverlayMovedListenerImplementor,
						SetOnSetCropOverlayMovedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayMovedListener, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayMovedListenerImplementor>(
						ref weak_implementor_SetOnSetCropOverlayMovedListener,
						global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayMovedListenerImplementor.__IsEmpty,
						__v => SetOnSetCropOverlayMovedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnSetCropOverlayMovedListener;

		global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayMovedListenerImplementor __CreateIOnSetCropOverlayMovedListenerImplementor ()
		{
			return new global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayMovedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayReleasedListener"
		public event EventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.SetCropOverlayReleasedEventArgs> SetCropOverlayReleased {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayReleasedListener, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayReleasedListenerImplementor>(
						ref weak_implementor_SetOnSetCropOverlayReleasedListener,
						__CreateIOnSetCropOverlayReleasedListenerImplementor,
						SetOnSetCropOverlayReleasedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayReleasedListener, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayReleasedListenerImplementor>(
						ref weak_implementor_SetOnSetCropOverlayReleasedListener,
						global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayReleasedListenerImplementor.__IsEmpty,
						__v => SetOnSetCropOverlayReleasedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnSetCropOverlayReleasedListener;

		global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayReleasedListenerImplementor __CreateIOnSetCropOverlayReleasedListenerImplementor ()
		{
			return new global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetCropOverlayReleasedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetImageUriCompleteListener"
		public event EventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.SetImageUriCompleteEventArgs> SetImageUriComplete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetImageUriCompleteListener, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetImageUriCompleteListenerImplementor>(
						ref weak_implementor_SetOnSetImageUriCompleteListener,
						__CreateIOnSetImageUriCompleteListenerImplementor,
						SetOnSetImageUriCompleteListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetImageUriCompleteListener, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetImageUriCompleteListenerImplementor>(
						ref weak_implementor_SetOnSetImageUriCompleteListener,
						global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetImageUriCompleteListenerImplementor.__IsEmpty,
						__v => SetOnSetImageUriCompleteListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnSetImageUriCompleteListener;

		global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetImageUriCompleteListenerImplementor __CreateIOnSetImageUriCompleteListenerImplementor ()
		{
			return new global::Com.Theartofdev.Edmodo.Cropper.CropImageView.IOnSetImageUriCompleteListenerImplementor (this);
		}
#endregion
	}
}
