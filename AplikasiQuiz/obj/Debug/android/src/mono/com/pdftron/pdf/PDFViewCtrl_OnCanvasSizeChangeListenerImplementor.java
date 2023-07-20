package mono.com.pdftron.pdf;


public class PDFViewCtrl_OnCanvasSizeChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pdftron.pdf.PDFViewCtrl.OnCanvasSizeChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCanvasSizeChanged:()V:GetOnCanvasSizeChangedHandler:pdftronprivate.PDF.PDFViewCtrl/IOnCanvasSizeChangeListenerInvoker, PDFNetAndroid\n" +
			"";
		mono.android.Runtime.register ("pdftronprivate.PDF.PDFViewCtrl+IOnCanvasSizeChangeListenerImplementor, PDFNetAndroid", PDFViewCtrl_OnCanvasSizeChangeListenerImplementor.class, __md_methods);
	}


	public PDFViewCtrl_OnCanvasSizeChangeListenerImplementor ()
	{
		super ();
		if (getClass () == PDFViewCtrl_OnCanvasSizeChangeListenerImplementor.class) {
			mono.android.TypeManager.Activate ("pdftronprivate.PDF.PDFViewCtrl+IOnCanvasSizeChangeListenerImplementor, PDFNetAndroid", "", this, new java.lang.Object[] {  });
		}
	}


	public void onCanvasSizeChanged ()
	{
		n_onCanvasSizeChanged ();
	}

	private native void n_onCanvasSizeChanged ();

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
