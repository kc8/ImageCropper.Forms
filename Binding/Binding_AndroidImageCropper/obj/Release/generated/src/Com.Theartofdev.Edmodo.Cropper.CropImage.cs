using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Theartofdev.Edmodo.Cropper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']"
	[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImage", DoNotGenerateAcw=true)]
	public sealed partial class CropImage : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/field[@name='CAMERA_CAPTURE_PERMISSIONS_REQUEST_CODE']"
		[Register ("CAMERA_CAPTURE_PERMISSIONS_REQUEST_CODE")]
		public const int CameraCapturePermissionsRequestCode = (int) 2011;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/field[@name='CROP_IMAGE_ACTIVITY_REQUEST_CODE']"
		[Register ("CROP_IMAGE_ACTIVITY_REQUEST_CODE")]
		public const int CropImageActivityRequestCode = (int) 203;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/field[@name='CROP_IMAGE_ACTIVITY_RESULT_ERROR_CODE']"
		[Register ("CROP_IMAGE_ACTIVITY_RESULT_ERROR_CODE")]
		public const int CropImageActivityResultErrorCode = (int) 204;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/field[@name='CROP_IMAGE_EXTRA_BUNDLE']"
		[Register ("CROP_IMAGE_EXTRA_BUNDLE")]
		public const string CropImageExtraBundle = (string) "CROP_IMAGE_EXTRA_BUNDLE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/field[@name='CROP_IMAGE_EXTRA_OPTIONS']"
		[Register ("CROP_IMAGE_EXTRA_OPTIONS")]
		public const string CropImageExtraOptions = (string) "CROP_IMAGE_EXTRA_OPTIONS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/field[@name='CROP_IMAGE_EXTRA_RESULT']"
		[Register ("CROP_IMAGE_EXTRA_RESULT")]
		public const string CropImageExtraResult = (string) "CROP_IMAGE_EXTRA_RESULT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/field[@name='CROP_IMAGE_EXTRA_SOURCE']"
		[Register ("CROP_IMAGE_EXTRA_SOURCE")]
		public const string CropImageExtraSource = (string) "CROP_IMAGE_EXTRA_SOURCE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/field[@name='PICK_IMAGE_CHOOSER_REQUEST_CODE']"
		[Register ("PICK_IMAGE_CHOOSER_REQUEST_CODE")]
		public const int PickImageChooserRequestCode = (int) 200;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/field[@name='PICK_IMAGE_PERMISSIONS_REQUEST_CODE']"
		[Register ("PICK_IMAGE_PERMISSIONS_REQUEST_CODE")]
		public const int PickImagePermissionsRequestCode = (int) 201;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']"
		[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImage$ActivityBuilder", DoNotGenerateAcw=true)]
		public sealed partial class ActivityBuilder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImage$ActivityBuilder", typeof (ActivityBuilder));
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

			internal ActivityBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='getIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("getIntent", "(Landroid/content/Context;)Landroid/content/Intent;", "")]
			public unsafe global::Android.Content.Intent GetIntent (global::Android.Content.Context context)
			{
				const string __id = "getIntent.(Landroid/content/Context;)Landroid/content/Intent;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='getIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
			[Register ("getIntent", "(Landroid/content/Context;Ljava/lang/Class;)Landroid/content/Intent;", "")]
			public unsafe global::Android.Content.Intent GetIntent (global::Android.Content.Context context, global::Java.Lang.Class cls)
			{
				const string __id = "getIntent.(Landroid/content/Context;Ljava/lang/Class;)Landroid/content/Intent;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue ((cls == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cls).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (context);
					global::System.GC.KeepAlive (cls);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setActivityMenuIconColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setActivityMenuIconColor", "(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetActivityMenuIconColor (int activityMenuIconColor)
			{
				const string __id = "setActivityMenuIconColor.(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (activityMenuIconColor);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setActivityTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setActivityTitle", "(Ljava/lang/CharSequence;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetActivityTitle (global::Java.Lang.ICharSequence activityTitle)
			{
				const string __id = "setActivityTitle.(Ljava/lang/CharSequence;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				IntPtr native_activityTitle = CharSequence.ToLocalJniHandle (activityTitle);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_activityTitle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_activityTitle);
					global::System.GC.KeepAlive (activityTitle);
				}
			}

			public global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetActivityTitle (string activityTitle)
			{
				var jls_activityTitle = activityTitle == null ? null : new global::Java.Lang.String (activityTitle);
				global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder __result = SetActivityTitle (jls_activityTitle);
				var __rsval = __result;
				jls_activityTitle?.Dispose ();
				return __rsval;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setAllowCounterRotation' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowCounterRotation", "(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetAllowCounterRotation (bool allowCounterRotation)
			{
				const string __id = "setAllowCounterRotation.(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (allowCounterRotation);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setAllowFlipping' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowFlipping", "(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetAllowFlipping (bool allowFlipping)
			{
				const string __id = "setAllowFlipping.(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (allowFlipping);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setAllowRotation' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowRotation", "(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetAllowRotation (bool allowRotation)
			{
				const string __id = "setAllowRotation.(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (allowRotation);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setAspectRatio' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setAspectRatio", "(II)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetAspectRatio (int aspectRatioX, int aspectRatioY)
			{
				const string __id = "setAspectRatio.(II)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (aspectRatioX);
					__args [1] = new JniArgumentValue (aspectRatioY);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setAutoZoomEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoZoomEnabled", "(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetAutoZoomEnabled (bool autoZoomEnabled)
			{
				const string __id = "setAutoZoomEnabled.(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (autoZoomEnabled);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBackgroundColor", "(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetBackgroundColor (int backgroundColor)
			{
				const string __id = "setBackgroundColor.(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (backgroundColor);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setBorderCornerColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBorderCornerColor", "(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetBorderCornerColor (int borderCornerColor)
			{
				const string __id = "setBorderCornerColor.(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (borderCornerColor);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setBorderCornerLength' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBorderCornerLength", "(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetBorderCornerLength (float borderCornerLength)
			{
				const string __id = "setBorderCornerLength.(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (borderCornerLength);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setBorderCornerOffset' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBorderCornerOffset", "(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetBorderCornerOffset (float borderCornerOffset)
			{
				const string __id = "setBorderCornerOffset.(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (borderCornerOffset);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setBorderCornerThickness' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBorderCornerThickness", "(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetBorderCornerThickness (float borderCornerThickness)
			{
				const string __id = "setBorderCornerThickness.(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (borderCornerThickness);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setBorderLineColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBorderLineColor", "(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetBorderLineColor (int borderLineColor)
			{
				const string __id = "setBorderLineColor.(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (borderLineColor);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setBorderLineThickness' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBorderLineThickness", "(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetBorderLineThickness (float borderLineThickness)
			{
				const string __id = "setBorderLineThickness.(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (borderLineThickness);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setCropMenuCropButtonIcon' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCropMenuCropButtonIcon", "(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetCropMenuCropButtonIcon (int drawableResource)
			{
				const string __id = "setCropMenuCropButtonIcon.(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (drawableResource);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setCropMenuCropButtonTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setCropMenuCropButtonTitle", "(Ljava/lang/CharSequence;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetCropMenuCropButtonTitle (global::Java.Lang.ICharSequence title)
			{
				const string __id = "setCropMenuCropButtonTitle.(Ljava/lang/CharSequence;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				IntPtr native_title = CharSequence.ToLocalJniHandle (title);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_title);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_title);
					global::System.GC.KeepAlive (title);
				}
			}

			public global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetCropMenuCropButtonTitle (string title)
			{
				var jls_title = title == null ? null : new global::Java.Lang.String (title);
				global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder __result = SetCropMenuCropButtonTitle (jls_title);
				var __rsval = __result;
				jls_title?.Dispose ();
				return __rsval;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setCropShape' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView.CropShape']]"
			[Register ("setCropShape", "(Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetCropShape (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape cropShape)
			{
				const string __id = "setCropShape.(Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((cropShape == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cropShape).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (cropShape);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setFixAspectRatio' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFixAspectRatio", "(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetFixAspectRatio (bool fixAspectRatio)
			{
				const string __id = "setFixAspectRatio.(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (fixAspectRatio);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setFlipHorizontally' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFlipHorizontally", "(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetFlipHorizontally (bool flipHorizontally)
			{
				const string __id = "setFlipHorizontally.(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (flipHorizontally);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setFlipVertically' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFlipVertically", "(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetFlipVertically (bool flipVertically)
			{
				const string __id = "setFlipVertically.(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (flipVertically);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setGuidelines' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView.Guidelines']]"
			[Register ("setGuidelines", "(Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetGuidelines (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines guidelines)
			{
				const string __id = "setGuidelines.(Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((guidelines == null) ? IntPtr.Zero : ((global::Java.Lang.Object) guidelines).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (guidelines);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setGuidelinesColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setGuidelinesColor", "(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetGuidelinesColor (int guidelinesColor)
			{
				const string __id = "setGuidelinesColor.(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (guidelinesColor);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setGuidelinesThickness' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setGuidelinesThickness", "(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetGuidelinesThickness (float guidelinesThickness)
			{
				const string __id = "setGuidelinesThickness.(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (guidelinesThickness);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setInitialCropWindowPaddingRatio' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setInitialCropWindowPaddingRatio", "(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetInitialCropWindowPaddingRatio (float initialCropWindowPaddingRatio)
			{
				const string __id = "setInitialCropWindowPaddingRatio.(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (initialCropWindowPaddingRatio);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setInitialCropWindowRectangle' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
			[Register ("setInitialCropWindowRectangle", "(Landroid/graphics/Rect;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetInitialCropWindowRectangle (global::Android.Graphics.Rect initialCropWindowRectangle)
			{
				const string __id = "setInitialCropWindowRectangle.(Landroid/graphics/Rect;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((initialCropWindowRectangle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) initialCropWindowRectangle).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (initialCropWindowRectangle);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setInitialRotation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setInitialRotation", "(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetInitialRotation (int initialRotation)
			{
				const string __id = "setInitialRotation.(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (initialRotation);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setMaxCropResultSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setMaxCropResultSize", "(II)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetMaxCropResultSize (int maxCropResultWidth, int maxCropResultHeight)
			{
				const string __id = "setMaxCropResultSize.(II)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (maxCropResultWidth);
					__args [1] = new JniArgumentValue (maxCropResultHeight);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setMaxZoom' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxZoom", "(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetMaxZoom (int maxZoom)
			{
				const string __id = "setMaxZoom.(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (maxZoom);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setMinCropResultSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setMinCropResultSize", "(II)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetMinCropResultSize (int minCropResultWidth, int minCropResultHeight)
			{
				const string __id = "setMinCropResultSize.(II)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (minCropResultWidth);
					__args [1] = new JniArgumentValue (minCropResultHeight);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setMinCropWindowSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setMinCropWindowSize", "(II)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetMinCropWindowSize (int minCropWindowWidth, int minCropWindowHeight)
			{
				const string __id = "setMinCropWindowSize.(II)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (minCropWindowWidth);
					__args [1] = new JniArgumentValue (minCropWindowHeight);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setMultiTouchEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMultiTouchEnabled", "(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetMultiTouchEnabled (bool multiTouchEnabled)
			{
				const string __id = "setMultiTouchEnabled.(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (multiTouchEnabled);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setNoOutputImage' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNoOutputImage", "(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetNoOutputImage (bool noOutputImage)
			{
				const string __id = "setNoOutputImage.(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (noOutputImage);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setOutputCompressFormat' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap.CompressFormat']]"
			[Register ("setOutputCompressFormat", "(Landroid/graphics/Bitmap$CompressFormat;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetOutputCompressFormat (global::Android.Graphics.Bitmap.CompressFormat outputCompressFormat)
			{
				const string __id = "setOutputCompressFormat.(Landroid/graphics/Bitmap$CompressFormat;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((outputCompressFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputCompressFormat).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (outputCompressFormat);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setOutputCompressQuality' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOutputCompressQuality", "(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetOutputCompressQuality (int outputCompressQuality)
			{
				const string __id = "setOutputCompressQuality.(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (outputCompressQuality);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setOutputUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register ("setOutputUri", "(Landroid/net/Uri;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetOutputUri (global::Android.Net.Uri outputUri)
			{
				const string __id = "setOutputUri.(Landroid/net/Uri;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((outputUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputUri).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (outputUri);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setRequestedSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setRequestedSize", "(II)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetRequestedSize (int reqWidth, int reqHeight)
			{
				const string __id = "setRequestedSize.(II)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (reqWidth);
					__args [1] = new JniArgumentValue (reqHeight);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setRequestedSize' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.theartofdev.edmodo.cropper.CropImageView.RequestSizeOptions']]"
			[Register ("setRequestedSize", "(IILcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetRequestedSize (int reqWidth, int reqHeight, global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions options)
			{
				const string __id = "setRequestedSize.(IILcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (reqWidth);
					__args [1] = new JniArgumentValue (reqHeight);
					__args [2] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (options);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setRotationDegrees' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRotationDegrees", "(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetRotationDegrees (int rotationDegrees)
			{
				const string __id = "setRotationDegrees.(I)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (rotationDegrees);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setScaleType' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView.ScaleType']]"
			[Register ("setScaleType", "(Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetScaleType (global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType scaleType)
			{
				const string __id = "setScaleType.(Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((scaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleType).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (scaleType);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setShowCropOverlay' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowCropOverlay", "(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetShowCropOverlay (bool showCropOverlay)
			{
				const string __id = "setShowCropOverlay.(Z)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (showCropOverlay);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setSnapRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSnapRadius", "(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetSnapRadius (float snapRadius)
			{
				const string __id = "setSnapRadius.(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (snapRadius);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='setTouchRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTouchRadius", "(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
			public unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder SetTouchRadius (float touchRadius)
			{
				const string __id = "setTouchRadius.(F)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (touchRadius);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='start' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("start", "(Landroid/app/Activity;)V", "")]
			public unsafe void Start (global::Android.App.Activity activity)
			{
				const string __id = "start.(Landroid/app/Activity;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (activity);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='start' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
			[Register ("start", "(Landroid/app/Activity;Ljava/lang/Class;)V", "")]
			public unsafe void Start (global::Android.App.Activity activity, global::Java.Lang.Class cls)
			{
				const string __id = "start.(Landroid/app/Activity;Ljava/lang/Class;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
					__args [1] = new JniArgumentValue ((cls == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cls).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (activity);
					global::System.GC.KeepAlive (cls);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='start' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.app.Fragment']]"
			[Register ("start", "(Landroid/content/Context;Landroid/app/Fragment;)V", "")]
			public unsafe void Start (global::Android.Content.Context context, global::Android.App.Fragment fragment)
			{
				const string __id = "start.(Landroid/content/Context;Landroid/app/Fragment;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue ((fragment == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fragment).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (context);
					global::System.GC.KeepAlive (fragment);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityBuilder']/method[@name='start' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.app.Fragment'] and parameter[3][@type='java.lang.Class&lt;?&gt;']]"
			[Register ("start", "(Landroid/content/Context;Landroid/app/Fragment;Ljava/lang/Class;)V", "")]
			public unsafe void Start (global::Android.Content.Context context, global::Android.App.Fragment fragment, global::Java.Lang.Class cls)
			{
				const string __id = "start.(Landroid/content/Context;Landroid/app/Fragment;Ljava/lang/Class;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue ((fragment == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fragment).Handle);
					__args [2] = new JniArgumentValue ((cls == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cls).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (context);
					global::System.GC.KeepAlive (fragment);
					global::System.GC.KeepAlive (cls);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityResult']"
		[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImage$ActivityResult", DoNotGenerateAcw=true)]
		public sealed partial class ActivityResult : global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropResult, global::Android.OS.IParcelable {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityResult']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImage$ActivityResult", typeof (ActivityResult));
			internal static new IntPtr class_ref {
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

			internal ActivityResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityResult']/constructor[@name='CropImage.ActivityResult' and count(parameter)=8 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.lang.Exception'] and parameter[4][@type='float[]'] and parameter[5][@type='android.graphics.Rect'] and parameter[6][@type='int'] and parameter[7][@type='android.graphics.Rect'] and parameter[8][@type='int']]"
			[Register (".ctor", "(Landroid/net/Uri;Landroid/net/Uri;Ljava/lang/Exception;[FLandroid/graphics/Rect;ILandroid/graphics/Rect;I)V", "")]
			public unsafe ActivityResult (global::Android.Net.Uri originalUri, global::Android.Net.Uri uri, global::Java.Lang.Exception error, float[] cropPoints, global::Android.Graphics.Rect cropRect, int rotation, global::Android.Graphics.Rect wholeImageRect, int sampleSize)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/net/Uri;Landroid/net/Uri;Ljava/lang/Exception;[FLandroid/graphics/Rect;ILandroid/graphics/Rect;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_cropPoints = JNIEnv.NewArray (cropPoints);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [8];
					__args [0] = new JniArgumentValue ((originalUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) originalUri).Handle);
					__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
					__args [2] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
					__args [3] = new JniArgumentValue (native_cropPoints);
					__args [4] = new JniArgumentValue ((cropRect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cropRect).Handle);
					__args [5] = new JniArgumentValue (rotation);
					__args [6] = new JniArgumentValue ((wholeImageRect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) wholeImageRect).Handle);
					__args [7] = new JniArgumentValue (sampleSize);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (cropPoints != null) {
						JNIEnv.CopyArray (native_cropPoints, cropPoints);
						JNIEnv.DeleteLocalRef (native_cropPoints);
					}
					global::System.GC.KeepAlive (originalUri);
					global::System.GC.KeepAlive (uri);
					global::System.GC.KeepAlive (error);
					global::System.GC.KeepAlive (cropPoints);
					global::System.GC.KeepAlive (cropRect);
					global::System.GC.KeepAlive (wholeImageRect);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityResult']/method[@name='describeContents' and count(parameter)=0]"
			[Register ("describeContents", "()I", "")]
			public unsafe int DescribeContents ()
			{
				const string __id = "describeContents.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage.ActivityResult']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
			[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
			public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
			{
				const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
					__args [1] = new JniArgumentValue ((int) flags);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (dest);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImage", typeof (CropImage));
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

		internal CropImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='activity' and count(parameter)=0]"
		[Register ("activity", "()Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
		public static unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder Activity ()
		{
			const string __id = "activity.()Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='activity' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("activity", "(Landroid/net/Uri;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;", "")]
		public static unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder Activity (global::Android.Net.Uri uri)
		{
			const string __id = "activity.(Landroid/net/Uri;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='getActivityResult' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getActivityResult", "(Landroid/content/Intent;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityResult;", "")]
		public static unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityResult GetActivityResult (global::Android.Content.Intent data)
		{
			const string __id = "getActivityResult.(Landroid/content/Intent;)Lcom/theartofdev/edmodo/cropper/CropImage$ActivityResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImage.ActivityResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='getCameraIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getCameraIntent", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetCameraIntent (global::Android.Content.Context context, global::Android.Net.Uri outputFileUri)
		{
			const string __id = "getCameraIntent.(Landroid/content/Context;Landroid/net/Uri;)Landroid/content/Intent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((outputFileUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputFileUri).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (outputFileUri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='getCameraIntents' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.pm.PackageManager']]"
		[Register ("getCameraIntents", "(Landroid/content/Context;Landroid/content/pm/PackageManager;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.Content.Intent> GetCameraIntents (global::Android.Content.Context context, global::Android.Content.PM.PackageManager packageManager)
		{
			const string __id = "getCameraIntents.(Landroid/content/Context;Landroid/content/pm/PackageManager;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((packageManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packageManager).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Android.Content.Intent>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (packageManager);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='getCaptureImageOutputUri' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCaptureImageOutputUri", "(Landroid/content/Context;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri GetCaptureImageOutputUri (global::Android.Content.Context context)
		{
			const string __id = "getCaptureImageOutputUri.(Landroid/content/Context;)Landroid/net/Uri;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='getGalleryIntents' and count(parameter)=3 and parameter[1][@type='android.content.pm.PackageManager'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getGalleryIntents", "(Landroid/content/pm/PackageManager;Ljava/lang/String;Z)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.Content.Intent> GetGalleryIntents (global::Android.Content.PM.PackageManager packageManager, string action, bool includeDocuments)
		{
			const string __id = "getGalleryIntents.(Landroid/content/pm/PackageManager;Ljava/lang/String;Z)Ljava/util/List;";
			IntPtr native_action = JNIEnv.NewString (action);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((packageManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packageManager).Handle);
				__args [1] = new JniArgumentValue (native_action);
				__args [2] = new JniArgumentValue (includeDocuments);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Android.Content.Intent>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_action);
				global::System.GC.KeepAlive (packageManager);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='getPickImageChooserIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPickImageChooserIntent", "(Landroid/content/Context;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetPickImageChooserIntent (global::Android.Content.Context context)
		{
			const string __id = "getPickImageChooserIntent.(Landroid/content/Context;)Landroid/content/Intent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='getPickImageChooserIntent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("getPickImageChooserIntent", "(Landroid/content/Context;Ljava/lang/CharSequence;ZZ)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetPickImageChooserIntent (global::Android.Content.Context context, global::Java.Lang.ICharSequence title, bool includeDocuments, bool includeCamera)
		{
			const string __id = "getPickImageChooserIntent.(Landroid/content/Context;Ljava/lang/CharSequence;ZZ)Landroid/content/Intent;";
			IntPtr native_title = CharSequence.ToLocalJniHandle (title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_title);
				__args [2] = new JniArgumentValue (includeDocuments);
				__args [3] = new JniArgumentValue (includeCamera);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (title);
			}
		}

		public static global::Android.Content.Intent GetPickImageChooserIntent (global::Android.Content.Context context, string title, bool includeDocuments, bool includeCamera)
		{
			var jls_title = title == null ? null : new global::Java.Lang.String (title);
			global::Android.Content.Intent __result = GetPickImageChooserIntent (context, jls_title, includeDocuments, includeCamera);
			var __rsval = __result;
			jls_title?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='getPickImageResultUri' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("getPickImageResultUri", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri GetPickImageResultUri (global::Android.Content.Context context, global::Android.Content.Intent data)
		{
			const string __id = "getPickImageResultUri.(Landroid/content/Context;Landroid/content/Intent;)Landroid/net/Uri;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='hasPermissionInManifest' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("hasPermissionInManifest", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool HasPermissionInManifest (global::Android.Content.Context context, string permissionName)
		{
			const string __id = "hasPermissionInManifest.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_permissionName = JNIEnv.NewString (permissionName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_permissionName);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_permissionName);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='isExplicitCameraPermissionRequired' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isExplicitCameraPermissionRequired", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsExplicitCameraPermissionRequired (global::Android.Content.Context context)
		{
			const string __id = "isExplicitCameraPermissionRequired.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='isReadExternalStoragePermissionsRequired' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("isReadExternalStoragePermissionsRequired", "(Landroid/content/Context;Landroid/net/Uri;)Z", "")]
		public static unsafe bool IsReadExternalStoragePermissionsRequired (global::Android.Content.Context context, global::Android.Net.Uri uri)
		{
			const string __id = "isReadExternalStoragePermissionsRequired.(Landroid/content/Context;Landroid/net/Uri;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='isUriRequiresPermissions' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("isUriRequiresPermissions", "(Landroid/content/Context;Landroid/net/Uri;)Z", "")]
		public static unsafe bool IsUriRequiresPermissions (global::Android.Content.Context context, global::Android.Net.Uri uri)
		{
			const string __id = "isUriRequiresPermissions.(Landroid/content/Context;Landroid/net/Uri;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='startPickImageActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("startPickImageActivity", "(Landroid/app/Activity;)V", "")]
		public static unsafe void StartPickImageActivity (global::Android.App.Activity activity)
		{
			const string __id = "startPickImageActivity.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImage']/method[@name='toOvalBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("toOvalBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap ToOvalBitmap (global::Android.Graphics.Bitmap bitmap)
		{
			const string __id = "toOvalBitmap.(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bitmap);
			}
		}

	}
}
