using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Theartofdev.Edmodo.Cropper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']"
	[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropOverlayView", DoNotGenerateAcw=true)]
	public partial class CropOverlayView : global::Android.Views.View {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/interface[@name='CropOverlayView.CropWindowChangeListener']"
		[Register ("com/theartofdev/edmodo/cropper/CropOverlayView$CropWindowChangeListener", "", "Com.Theartofdev.Edmodo.Cropper.CropOverlayView/ICropWindowChangeListenerInvoker")]
		public partial interface ICropWindowChangeListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/interface[@name='CropOverlayView.CropWindowChangeListener']/method[@name='onCropWindowChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onCropWindowChanged", "(Z)V", "GetOnCropWindowChanged_ZHandler:Com.Theartofdev.Edmodo.Cropper.CropOverlayView/ICropWindowChangeListenerInvoker, Binding_ImageCropperAndroid")]
			void OnCropWindowChanged (bool p0);

		}

		[global::Android.Runtime.Register ("com/theartofdev/edmodo/cropper/CropOverlayView$CropWindowChangeListener", DoNotGenerateAcw=true)]
		internal partial class ICropWindowChangeListenerInvoker : global::Java.Lang.Object, ICropWindowChangeListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropOverlayView$CropWindowChangeListener", typeof (ICropWindowChangeListenerInvoker));

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

			public static ICropWindowChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICropWindowChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.theartofdev.edmodo.cropper.CropOverlayView.CropWindowChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICropWindowChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCropWindowChanged_Z;
#pragma warning disable 0169
			static Delegate GetOnCropWindowChanged_ZHandler ()
			{
				if (cb_onCropWindowChanged_Z == null)
					cb_onCropWindowChanged_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnCropWindowChanged_Z);
				return cb_onCropWindowChanged_Z;
			}

			static void n_OnCropWindowChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView.ICropWindowChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCropWindowChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCropWindowChanged_Z;
			public unsafe void OnCropWindowChanged (bool p0)
			{
				if (id_onCropWindowChanged_Z == IntPtr.Zero)
					id_onCropWindowChanged_Z = JNIEnv.GetMethodID (class_ref, "onCropWindowChanged", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCropWindowChanged_Z, __args);
			}

		}

		// event args for com.theartofdev.edmodo.cropper.CropOverlayView.CropWindowChangeListener.onCropWindowChanged
		public partial class CropWindowChangeEventArgs : global::System.EventArgs {

			public CropWindowChangeEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/theartofdev/edmodo/cropper/CropOverlayView_CropWindowChangeListenerImplementor")]
		internal sealed partial class ICropWindowChangeListenerImplementor : global::Java.Lang.Object, ICropWindowChangeListener {

			object sender;

			public ICropWindowChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/theartofdev/edmodo/cropper/CropOverlayView_CropWindowChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CropWindowChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnCropWindowChanged (bool p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CropWindowChangeEventArgs (p0));
			}

			internal static bool __IsEmpty (ICropWindowChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/theartofdev/edmodo/cropper/CropOverlayView", typeof (CropOverlayView));
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

		protected CropOverlayView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/constructor[@name='CropOverlayView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CropOverlayView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/constructor[@name='CropOverlayView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CropOverlayView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		static Delegate cb_getAspectRatioX;
#pragma warning disable 0169
		static Delegate GetGetAspectRatioXHandler ()
		{
			if (cb_getAspectRatioX == null)
				cb_getAspectRatioX = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAspectRatioX);
			return cb_getAspectRatioX;
		}

		static int n_GetAspectRatioX (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AspectRatioX;
		}
#pragma warning restore 0169

		static Delegate cb_setAspectRatioX_I;
#pragma warning disable 0169
		static Delegate GetSetAspectRatioX_IHandler ()
		{
			if (cb_setAspectRatioX_I == null)
				cb_setAspectRatioX_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAspectRatioX_I);
			return cb_setAspectRatioX_I;
		}

		static void n_SetAspectRatioX_I (IntPtr jnienv, IntPtr native__this, int aspectRatioX)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AspectRatioX = aspectRatioX;
		}
#pragma warning restore 0169

		public virtual unsafe int AspectRatioX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='getAspectRatioX' and count(parameter)=0]"
			[Register ("getAspectRatioX", "()I", "GetGetAspectRatioXHandler")]
			get {
				const string __id = "getAspectRatioX.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setAspectRatioX' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAspectRatioX", "(I)V", "GetSetAspectRatioX_IHandler")]
			set {
				const string __id = "setAspectRatioX.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAspectRatioY;
#pragma warning disable 0169
		static Delegate GetGetAspectRatioYHandler ()
		{
			if (cb_getAspectRatioY == null)
				cb_getAspectRatioY = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAspectRatioY);
			return cb_getAspectRatioY;
		}

		static int n_GetAspectRatioY (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AspectRatioY;
		}
#pragma warning restore 0169

		static Delegate cb_setAspectRatioY_I;
#pragma warning disable 0169
		static Delegate GetSetAspectRatioY_IHandler ()
		{
			if (cb_setAspectRatioY_I == null)
				cb_setAspectRatioY_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAspectRatioY_I);
			return cb_setAspectRatioY_I;
		}

		static void n_SetAspectRatioY_I (IntPtr jnienv, IntPtr native__this, int aspectRatioY)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AspectRatioY = aspectRatioY;
		}
#pragma warning restore 0169

		public virtual unsafe int AspectRatioY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='getAspectRatioY' and count(parameter)=0]"
			[Register ("getAspectRatioY", "()I", "GetGetAspectRatioYHandler")]
			get {
				const string __id = "getAspectRatioY.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setAspectRatioY' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAspectRatioY", "(I)V", "GetSetAspectRatioY_IHandler")]
			set {
				const string __id = "setAspectRatioY.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CropShape);
		}
#pragma warning restore 0169

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cropShape = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape> (native_cropShape, JniHandleOwnership.DoNotTransfer);
			__this.CropShape = cropShape;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape CropShape {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='getCropShape' and count(parameter)=0]"
			[Register ("getCropShape", "()Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;", "GetGetCropShapeHandler")]
			get {
				const string __id = "getCropShape.()Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.CropShape> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setCropShape' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView.CropShape']]"
			[Register ("setCropShape", "(Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;)V", "GetSetCropShape_Lcom_theartofdev_edmodo_cropper_CropImageView_CropShape_Handler")]
			set {
				const string __id = "setCropShape.(Lcom/theartofdev/edmodo/cropper/CropImageView$CropShape;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CropWindowRect);
		}
#pragma warning restore 0169

		static Delegate cb_setCropWindowRect_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetSetCropWindowRect_Landroid_graphics_RectF_Handler ()
		{
			if (cb_setCropWindowRect_Landroid_graphics_RectF_ == null)
				cb_setCropWindowRect_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCropWindowRect_Landroid_graphics_RectF_);
			return cb_setCropWindowRect_Landroid_graphics_RectF_;
		}

		static void n_SetCropWindowRect_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rect)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rect = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_rect, JniHandleOwnership.DoNotTransfer);
			__this.CropWindowRect = rect;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.RectF CropWindowRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='getCropWindowRect' and count(parameter)=0]"
			[Register ("getCropWindowRect", "()Landroid/graphics/RectF;", "GetGetCropWindowRectHandler")]
			get {
				const string __id = "getCropWindowRect.()Landroid/graphics/RectF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setCropWindowRect' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
			[Register ("setCropWindowRect", "(Landroid/graphics/RectF;)V", "GetSetCropWindowRect_Landroid_graphics_RectF_Handler")]
			set {
				const string __id = "setCropWindowRect.(Landroid/graphics/RectF;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Guidelines);
		}
#pragma warning restore 0169

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var guidelines = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines> (native_guidelines, JniHandleOwnership.DoNotTransfer);
			__this.Guidelines = guidelines;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines Guidelines {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='getGuidelines' and count(parameter)=0]"
			[Register ("getGuidelines", "()Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;", "GetGetGuidelinesHandler")]
			get {
				const string __id = "getGuidelines.()Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageView.Guidelines> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setGuidelines' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageView.Guidelines']]"
			[Register ("setGuidelines", "(Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;)V", "GetSetGuidelines_Lcom_theartofdev_edmodo_cropper_CropImageView_Guidelines_Handler")]
			set {
				const string __id = "setGuidelines.(Lcom/theartofdev/edmodo/cropper/CropImageView$Guidelines;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getInitialCropWindowRect;
#pragma warning disable 0169
		static Delegate GetGetInitialCropWindowRectHandler ()
		{
			if (cb_getInitialCropWindowRect == null)
				cb_getInitialCropWindowRect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetInitialCropWindowRect);
			return cb_getInitialCropWindowRect;
		}

		static IntPtr n_GetInitialCropWindowRect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitialCropWindowRect);
		}
#pragma warning restore 0169

		static Delegate cb_setInitialCropWindowRect_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetSetInitialCropWindowRect_Landroid_graphics_Rect_Handler ()
		{
			if (cb_setInitialCropWindowRect_Landroid_graphics_Rect_ == null)
				cb_setInitialCropWindowRect_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetInitialCropWindowRect_Landroid_graphics_Rect_);
			return cb_setInitialCropWindowRect_Landroid_graphics_Rect_;
		}

		static void n_SetInitialCropWindowRect_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rect)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rect = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_rect, JniHandleOwnership.DoNotTransfer);
			__this.InitialCropWindowRect = rect;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Rect InitialCropWindowRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='getInitialCropWindowRect' and count(parameter)=0]"
			[Register ("getInitialCropWindowRect", "()Landroid/graphics/Rect;", "GetGetInitialCropWindowRectHandler")]
			get {
				const string __id = "getInitialCropWindowRect.()Landroid/graphics/Rect;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setInitialCropWindowRect' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
			[Register ("setInitialCropWindowRect", "(Landroid/graphics/Rect;)V", "GetSetInitialCropWindowRect_Landroid_graphics_Rect_Handler")]
			set {
				const string __id = "setInitialCropWindowRect.(Landroid/graphics/Rect;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFixAspectRatio;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFixAspectRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='isFixAspectRatio' and count(parameter)=0]"
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

		static Delegate cb_fixCurrentCropWindowRect;
#pragma warning disable 0169
		static Delegate GetFixCurrentCropWindowRectHandler ()
		{
			if (cb_fixCurrentCropWindowRect == null)
				cb_fixCurrentCropWindowRect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FixCurrentCropWindowRect);
			return cb_fixCurrentCropWindowRect;
		}

		static void n_FixCurrentCropWindowRect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FixCurrentCropWindowRect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='fixCurrentCropWindowRect' and count(parameter)=0]"
		[Register ("fixCurrentCropWindowRect", "()V", "GetFixCurrentCropWindowRectHandler")]
		public virtual unsafe void FixCurrentCropWindowRect ()
		{
			const string __id = "fixCurrentCropWindowRect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resetCropOverlayView;
#pragma warning disable 0169
		static Delegate GetResetCropOverlayViewHandler ()
		{
			if (cb_resetCropOverlayView == null)
				cb_resetCropOverlayView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ResetCropOverlayView);
			return cb_resetCropOverlayView;
		}

		static void n_ResetCropOverlayView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetCropOverlayView ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='resetCropOverlayView' and count(parameter)=0]"
		[Register ("resetCropOverlayView", "()V", "GetResetCropOverlayViewHandler")]
		public virtual unsafe void ResetCropOverlayView ()
		{
			const string __id = "resetCropOverlayView.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resetCropWindowRect;
#pragma warning disable 0169
		static Delegate GetResetCropWindowRectHandler ()
		{
			if (cb_resetCropWindowRect == null)
				cb_resetCropWindowRect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ResetCropWindowRect);
			return cb_resetCropWindowRect;
		}

		static void n_ResetCropWindowRect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetCropWindowRect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='resetCropWindowRect' and count(parameter)=0]"
		[Register ("resetCropWindowRect", "()V", "GetResetCropWindowRectHandler")]
		public virtual unsafe void ResetCropWindowRect ()
		{
			const string __id = "resetCropWindowRect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setBounds_arrayFII;
#pragma warning disable 0169
		static Delegate GetSetBounds_arrayFIIHandler ()
		{
			if (cb_setBounds_arrayFII == null)
				cb_setBounds_arrayFII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_SetBounds_arrayFII);
			return cb_setBounds_arrayFII;
		}

		static void n_SetBounds_arrayFII (IntPtr jnienv, IntPtr native__this, IntPtr native_boundsPoints, int viewWidth, int viewHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var boundsPoints = (float[]) JNIEnv.GetArray (native_boundsPoints, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetBounds (boundsPoints, viewWidth, viewHeight);
			if (boundsPoints != null)
				JNIEnv.CopyArray (boundsPoints, native_boundsPoints);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setBounds' and count(parameter)=3 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setBounds", "([FII)V", "GetSetBounds_arrayFIIHandler")]
		public virtual unsafe void SetBounds (float[] boundsPoints, int viewWidth, int viewHeight)
		{
			const string __id = "setBounds.([FII)V";
			IntPtr native_boundsPoints = JNIEnv.NewArray (boundsPoints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_boundsPoints);
				__args [1] = new JniArgumentValue (viewWidth);
				__args [2] = new JniArgumentValue (viewHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (boundsPoints != null) {
					JNIEnv.CopyArray (native_boundsPoints, boundsPoints);
					JNIEnv.DeleteLocalRef (native_boundsPoints);
				}
				global::System.GC.KeepAlive (boundsPoints);
			}
		}

		static Delegate cb_setCropWindowChangeListener_Lcom_theartofdev_edmodo_cropper_CropOverlayView_CropWindowChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetCropWindowChangeListener_Lcom_theartofdev_edmodo_cropper_CropOverlayView_CropWindowChangeListener_Handler ()
		{
			if (cb_setCropWindowChangeListener_Lcom_theartofdev_edmodo_cropper_CropOverlayView_CropWindowChangeListener_ == null)
				cb_setCropWindowChangeListener_Lcom_theartofdev_edmodo_cropper_CropOverlayView_CropWindowChangeListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCropWindowChangeListener_Lcom_theartofdev_edmodo_cropper_CropOverlayView_CropWindowChangeListener_);
			return cb_setCropWindowChangeListener_Lcom_theartofdev_edmodo_cropper_CropOverlayView_CropWindowChangeListener_;
		}

		static void n_SetCropWindowChangeListener_Lcom_theartofdev_edmodo_cropper_CropOverlayView_CropWindowChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView.ICropWindowChangeListener)global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView.ICropWindowChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetCropWindowChangeListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setCropWindowChangeListener' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropOverlayView.CropWindowChangeListener']]"
		[Register ("setCropWindowChangeListener", "(Lcom/theartofdev/edmodo/cropper/CropOverlayView$CropWindowChangeListener;)V", "GetSetCropWindowChangeListener_Lcom_theartofdev_edmodo_cropper_CropOverlayView_CropWindowChangeListener_Handler")]
		public virtual unsafe void SetCropWindowChangeListener (global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView.ICropWindowChangeListener listener)
		{
			const string __id = "setCropWindowChangeListener.(Lcom/theartofdev/edmodo/cropper/CropOverlayView$CropWindowChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setCropWindowLimits_FFFF;
#pragma warning disable 0169
		static Delegate GetSetCropWindowLimits_FFFFHandler ()
		{
			if (cb_setCropWindowLimits_FFFF == null)
				cb_setCropWindowLimits_FFFF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFFFF_V) n_SetCropWindowLimits_FFFF);
			return cb_setCropWindowLimits_FFFF;
		}

		static void n_SetCropWindowLimits_FFFF (IntPtr jnienv, IntPtr native__this, float maxWidth, float maxHeight, float scaleFactorWidth, float scaleFactorHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCropWindowLimits (maxWidth, maxHeight, scaleFactorWidth, scaleFactorHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setCropWindowLimits' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("setCropWindowLimits", "(FFFF)V", "GetSetCropWindowLimits_FFFFHandler")]
		public virtual unsafe void SetCropWindowLimits (float maxWidth, float maxHeight, float scaleFactorWidth, float scaleFactorHeight)
		{
			const string __id = "setCropWindowLimits.(FFFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (maxWidth);
				__args [1] = new JniArgumentValue (maxHeight);
				__args [2] = new JniArgumentValue (scaleFactorWidth);
				__args [3] = new JniArgumentValue (scaleFactorHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFixedAspectRatio (fixAspectRatio);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setFixedAspectRatio' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setInitialAttributeValues_Lcom_theartofdev_edmodo_cropper_CropImageOptions_;
#pragma warning disable 0169
		static Delegate GetSetInitialAttributeValues_Lcom_theartofdev_edmodo_cropper_CropImageOptions_Handler ()
		{
			if (cb_setInitialAttributeValues_Lcom_theartofdev_edmodo_cropper_CropImageOptions_ == null)
				cb_setInitialAttributeValues_Lcom_theartofdev_edmodo_cropper_CropImageOptions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetInitialAttributeValues_Lcom_theartofdev_edmodo_cropper_CropImageOptions_);
			return cb_setInitialAttributeValues_Lcom_theartofdev_edmodo_cropper_CropImageOptions_;
		}

		static void n_SetInitialAttributeValues_Lcom_theartofdev_edmodo_cropper_CropImageOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropImageOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.SetInitialAttributeValues (options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setInitialAttributeValues' and count(parameter)=1 and parameter[1][@type='com.theartofdev.edmodo.cropper.CropImageOptions']]"
		[Register ("setInitialAttributeValues", "(Lcom/theartofdev/edmodo/cropper/CropImageOptions;)V", "GetSetInitialAttributeValues_Lcom_theartofdev_edmodo_cropper_CropImageOptions_Handler")]
		public virtual unsafe void SetInitialAttributeValues (global::Com.Theartofdev.Edmodo.Cropper.CropImageOptions options)
		{
			const string __id = "setInitialAttributeValues.(Lcom/theartofdev/edmodo/cropper/CropImageOptions;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (options);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxCropResultSize (maxCropResultWidth, maxCropResultHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setMaxCropResultSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMinCropResultSize (minCropResultWidth, minCropResultHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setMinCropResultSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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
				cb_setMultiTouchEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_Z) n_SetMultiTouchEnabled_Z);
			return cb_setMultiTouchEnabled_Z;
		}

		static bool n_SetMultiTouchEnabled_Z (IntPtr jnienv, IntPtr native__this, bool multiTouchEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetMultiTouchEnabled (multiTouchEnabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setMultiTouchEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMultiTouchEnabled", "(Z)Z", "GetSetMultiTouchEnabled_ZHandler")]
		public virtual unsafe bool SetMultiTouchEnabled (bool multiTouchEnabled)
		{
			const string __id = "setMultiTouchEnabled.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (multiTouchEnabled);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSnapRadius (snapRadius);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.theartofdev.edmodo.cropper']/class[@name='CropOverlayView']/method[@name='setSnapRadius' and count(parameter)=1 and parameter[1][@type='float']]"
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

#region "Event implementation for Com.Theartofdev.Edmodo.Cropper.CropOverlayView.ICropWindowChangeListener"
		public event EventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView.CropWindowChangeEventArgs> CropWindowChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView.ICropWindowChangeListener, global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView.ICropWindowChangeListenerImplementor>(
						ref weak_implementor_SetCropWindowChangeListener,
						__CreateICropWindowChangeListenerImplementor,
						SetCropWindowChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView.ICropWindowChangeListener, global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView.ICropWindowChangeListenerImplementor>(
						ref weak_implementor_SetCropWindowChangeListener,
						global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView.ICropWindowChangeListenerImplementor.__IsEmpty,
						__v => SetCropWindowChangeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetCropWindowChangeListener;

		global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView.ICropWindowChangeListenerImplementor __CreateICropWindowChangeListenerImplementor ()
		{
			return new global::Com.Theartofdev.Edmodo.Cropper.CropOverlayView.ICropWindowChangeListenerImplementor (this);
		}
#endregion
	}
}
