package mono.com.theartofdev.edmodo.cropper;


public class CropImageView_OnSetCropOverlayMovedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.theartofdev.edmodo.cropper.CropImageView.OnSetCropOverlayMovedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCropOverlayMoved:(Landroid/graphics/Rect;)V:GetOnCropOverlayMoved_Landroid_graphics_Rect_Handler:Com.Theartofdev.Edmodo.Cropper.CropImageView/IOnSetCropOverlayMovedListenerInvoker, Binding_ImageCropperAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Theartofdev.Edmodo.Cropper.CropImageView+IOnSetCropOverlayMovedListenerImplementor, Binding_ImageCropperAndroid", CropImageView_OnSetCropOverlayMovedListenerImplementor.class, __md_methods);
	}


	public CropImageView_OnSetCropOverlayMovedListenerImplementor ()
	{
		super ();
		if (getClass () == CropImageView_OnSetCropOverlayMovedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Theartofdev.Edmodo.Cropper.CropImageView+IOnSetCropOverlayMovedListenerImplementor, Binding_ImageCropperAndroid", "", this, new java.lang.Object[] {  });
	}


	public void onCropOverlayMoved (android.graphics.Rect p0)
	{
		n_onCropOverlayMoved (p0);
	}

	private native void n_onCropOverlayMoved (android.graphics.Rect p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
