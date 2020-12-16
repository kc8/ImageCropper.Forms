package mono.com.theartofdev.edmodo.cropper;


public class CropImageView_OnSetCropWindowChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.theartofdev.edmodo.cropper.CropImageView.OnSetCropWindowChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCropWindowChanged:()V:GetOnCropWindowChangedHandler:Com.Theartofdev.Edmodo.Cropper.CropImageView/IOnSetCropWindowChangeListenerInvoker, Binding_ImageCropperAndroid\n" +
			"";
		mono.android.Runtime.register ("Com.Theartofdev.Edmodo.Cropper.CropImageView+IOnSetCropWindowChangeListenerImplementor, Binding_ImageCropperAndroid", CropImageView_OnSetCropWindowChangeListenerImplementor.class, __md_methods);
	}


	public CropImageView_OnSetCropWindowChangeListenerImplementor ()
	{
		super ();
		if (getClass () == CropImageView_OnSetCropWindowChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Theartofdev.Edmodo.Cropper.CropImageView+IOnSetCropWindowChangeListenerImplementor, Binding_ImageCropperAndroid", "", this, new java.lang.Object[] {  });
	}


	public void onCropWindowChanged ()
	{
		n_onCropWindowChanged ();
	}

	private native void n_onCropWindowChanged ();

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
