using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Theartofdev.Edmodo.Cropper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']"
	[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropImageOptions", DoNotGenerateAcw=true)]
	public partial class CropImageOptions : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='activityMenuIconColor']"
		[Register ("activityMenuIconColor")]
		public int ActivityMenuIconColor {
			get {
				const string __id = "activityMenuIconColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "activityMenuIconColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='activityTitle']"
		[Register ("activityTitle")]
		public global::Java.Lang.ICharSequence ActivityTitle {
			get {
				const string __id = "activityTitle.Ljava/lang/CharSequence;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "activityTitle.Ljava/lang/CharSequence;";

				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='allowCounterRotation']"
		[Register ("allowCounterRotation")]
		public bool AllowCounterRotation {
			get {
				const string __id = "allowCounterRotation.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "allowCounterRotation.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='allowFlipping']"
		[Register ("allowFlipping")]
		public bool AllowFlipping {
			get {
				const string __id = "allowFlipping.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "allowFlipping.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='allowRotation']"
		[Register ("allowRotation")]
		public bool AllowRotation {
			get {
				const string __id = "allowRotation.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "allowRotation.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='aspectRatioX']"
		[Register ("aspectRatioX")]
		public int AspectRatioX {
			get {
				const string __id = "aspectRatioX.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "aspectRatioX.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='aspectRatioY']"
		[Register ("aspectRatioY")]
		public int AspectRatioY {
			get {
				const string __id = "aspectRatioY.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "aspectRatioY.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='autoZoomEnabled']"
		[Register ("autoZoomEnabled")]
		public bool AutoZoomEnabled {
			get {
				const string __id = "autoZoomEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "autoZoomEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='backgroundColor']"
		[Register ("backgroundColor")]
		public int BackgroundColor {
			get {
				const string __id = "backgroundColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "backgroundColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='borderCornerColor']"
		[Register ("borderCornerColor")]
		public int BorderCornerColor {
			get {
				const string __id = "borderCornerColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "borderCornerColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='borderCornerLength']"
		[Register ("borderCornerLength")]
		public float BorderCornerLength {
			get {
				const string __id = "borderCornerLength.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "borderCornerLength.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='borderCornerOffset']"
		[Register ("borderCornerOffset")]
		public float BorderCornerOffset {
			get {
				const string __id = "borderCornerOffset.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "borderCornerOffset.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='borderCornerThickness']"
		[Register ("borderCornerThickness")]
		public float BorderCornerThickness {
			get {
				const string __id = "borderCornerThickness.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "borderCornerThickness.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='borderLineColor']"
		[Register ("borderLineColor")]
		public int BorderLineColor {
			get {
				const string __id = "borderLineColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "borderLineColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='borderLineThickness']"
		[Register ("borderLineThickness")]
		public float BorderLineThickness {
			get {
				const string __id = "borderLineThickness.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "borderLineThickness.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='cropMenuCropButtonIcon']"
		[Register ("cropMenuCropButtonIcon")]
		public int CropMenuCropButtonIcon {
			get {
				const string __id = "cropMenuCropButtonIcon.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "cropMenuCropButtonIcon.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='cropMenuCropButtonTitle']"
		[Register ("cropMenuCropButtonTitle")]
		public global::Java.Lang.ICharSequence CropMenuCropButtonTitle {
			get {
				const string __id = "cropMenuCropButtonTitle.Ljava/lang/CharSequence;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cropMenuCropButtonTitle.Ljava/lang/CharSequence;";

				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='cropShape']"
		[Register ("cropShape")]
		public global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape CropShape {
			get {
				const string __id = "cropShape.Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cropShape.Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='fixAspectRatio']"
		[Register ("fixAspectRatio")]
		public bool FixAspectRatio {
			get {
				const string __id = "fixAspectRatio.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "fixAspectRatio.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='flipHorizontally']"
		[Register ("flipHorizontally")]
		public bool FlipHorizontally {
			get {
				const string __id = "flipHorizontally.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "flipHorizontally.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='flipVertically']"
		[Register ("flipVertically")]
		public bool FlipVertically {
			get {
				const string __id = "flipVertically.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "flipVertically.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='guidelines']"
		[Register ("guidelines")]
		public global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines Guidelines {
			get {
				const string __id = "guidelines.Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "guidelines.Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='guidelinesColor']"
		[Register ("guidelinesColor")]
		public int GuidelinesColor {
			get {
				const string __id = "guidelinesColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "guidelinesColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='guidelinesThickness']"
		[Register ("guidelinesThickness")]
		public float GuidelinesThickness {
			get {
				const string __id = "guidelinesThickness.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "guidelinesThickness.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='initialCropWindowPaddingRatio']"
		[Register ("initialCropWindowPaddingRatio")]
		public float InitialCropWindowPaddingRatio {
			get {
				const string __id = "initialCropWindowPaddingRatio.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "initialCropWindowPaddingRatio.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='initialCropWindowRectangle']"
		[Register ("initialCropWindowRectangle")]
		public global::Android.Graphics.Rect InitialCropWindowRectangle {
			get {
				const string __id = "initialCropWindowRectangle.Landroid/graphics/Rect;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "initialCropWindowRectangle.Landroid/graphics/Rect;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='initialRotation']"
		[Register ("initialRotation")]
		public int InitialRotation {
			get {
				const string __id = "initialRotation.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "initialRotation.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='maxCropResultHeight']"
		[Register ("maxCropResultHeight")]
		public int MaxCropResultHeight {
			get {
				const string __id = "maxCropResultHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maxCropResultHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='maxCropResultWidth']"
		[Register ("maxCropResultWidth")]
		public int MaxCropResultWidth {
			get {
				const string __id = "maxCropResultWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maxCropResultWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='maxZoom']"
		[Register ("maxZoom")]
		public int MaxZoom {
			get {
				const string __id = "maxZoom.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maxZoom.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='minCropResultHeight']"
		[Register ("minCropResultHeight")]
		public int MinCropResultHeight {
			get {
				const string __id = "minCropResultHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "minCropResultHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='minCropResultWidth']"
		[Register ("minCropResultWidth")]
		public int MinCropResultWidth {
			get {
				const string __id = "minCropResultWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "minCropResultWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='minCropWindowHeight']"
		[Register ("minCropWindowHeight")]
		public int MinCropWindowHeight {
			get {
				const string __id = "minCropWindowHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "minCropWindowHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='minCropWindowWidth']"
		[Register ("minCropWindowWidth")]
		public int MinCropWindowWidth {
			get {
				const string __id = "minCropWindowWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "minCropWindowWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='multiTouchEnabled']"
		[Register ("multiTouchEnabled")]
		public bool MultiTouchEnabled {
			get {
				const string __id = "multiTouchEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "multiTouchEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='noOutputImage']"
		[Register ("noOutputImage")]
		public bool NoOutputImage {
			get {
				const string __id = "noOutputImage.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "noOutputImage.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='outputCompressFormat']"
		[Register ("outputCompressFormat")]
		public global::Android.Graphics.Bitmap.CompressFormat OutputCompressFormat {
			get {
				const string __id = "outputCompressFormat.Landroid/graphics/Bitmap$CompressFormat;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "outputCompressFormat.Landroid/graphics/Bitmap$CompressFormat;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='outputCompressQuality']"
		[Register ("outputCompressQuality")]
		public int OutputCompressQuality {
			get {
				const string __id = "outputCompressQuality.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "outputCompressQuality.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='outputRequestHeight']"
		[Register ("outputRequestHeight")]
		public int OutputRequestHeight {
			get {
				const string __id = "outputRequestHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "outputRequestHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='outputRequestSizeOptions']"
		[Register ("outputRequestSizeOptions")]
		public global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions OutputRequestSizeOptions {
			get {
				const string __id = "outputRequestSizeOptions.Lcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.RequestSizeOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "outputRequestSizeOptions.Lcom/theartofdev/edmodo/cropper/CropImageView$RequestSizeOptions;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='outputRequestWidth']"
		[Register ("outputRequestWidth")]
		public int OutputRequestWidth {
			get {
				const string __id = "outputRequestWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "outputRequestWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='outputUri']"
		[Register ("outputUri")]
		public global::Android.Net.Uri OutputUri {
			get {
				const string __id = "outputUri.Landroid/net/Uri;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "outputUri.Landroid/net/Uri;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='rotationDegrees']"
		[Register ("rotationDegrees")]
		public int RotationDegrees {
			get {
				const string __id = "rotationDegrees.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "rotationDegrees.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='scaleType']"
		[Register ("scaleType")]
		public global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType ScaleType {
			get {
				const string __id = "scaleType.Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.ScaleType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "scaleType.Lcom/theartofdev/edmodo/cropper/CropImageView$ScaleType;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='showCropOverlay']"
		[Register ("showCropOverlay")]
		public bool ShowCropOverlay {
			get {
				const string __id = "showCropOverlay.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "showCropOverlay.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='showProgressBar']"
		[Register ("showProgressBar")]
		public bool ShowProgressBar {
			get {
				const string __id = "showProgressBar.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "showProgressBar.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='snapRadius']"
		[Register ("snapRadius")]
		public float SnapRadius {
			get {
				const string __id = "snapRadius.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "snapRadius.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/field[@name='touchRadius']"
		[Register ("touchRadius")]
		public float TouchRadius {
			get {
				const string __id = "touchRadius.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "touchRadius.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropImageOptions", typeof (CropImageOptions));
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

		protected CropImageOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/constructor[@name='CropImageOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CropImageOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/constructor[@name='CropImageOptions' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe CropImageOptions (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcel;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@in);
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_validate;
#pragma warning disable 0169
		static Delegate GetValidateHandler ()
		{
			if (cb_validate == null)
				cb_validate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Validate);
			return cb_validate;
		}

		static void n_Validate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Validate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/method[@name='validate' and count(parameter)=0]"
		[Register ("validate", "()V", "GetValidateHandler")]
		public virtual unsafe void Validate ()
		{
			const string __id = "validate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			var flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropImageOptions']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dest);
			}
		}

	}
}
