package mono.com.pdftron.pdf;


public class PDFViewCtrl_PageSlidingListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pdftron.pdf.PDFViewCtrl.PageSlidingListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScrollOffsetChanged:(II)V:GetOnScrollOffsetChanged_IIHandler:pdftronprivate.PDF.PDFViewCtrl/IPageSlidingListenerInvoker, PDFNetAndroid\n" +
			"";
		mono.android.Runtime.register ("pdftronprivate.PDF.PDFViewCtrl+IPageSlidingListenerImplementor, PDFNetAndroid", PDFViewCtrl_PageSlidingListenerImplementor.class, __md_methods);
	}


	public PDFViewCtrl_PageSlidingListenerImplementor ()
	{
		super ();
		if (getClass () == PDFViewCtrl_PageSlidingListenerImplementor.class) {
			mono.android.TypeManager.Activate ("pdftronprivate.PDF.PDFViewCtrl+IPageSlidingListenerImplementor, PDFNetAndroid", "", this, new java.lang.Object[] {  });
		}
	}


	public void onScrollOffsetChanged (int p0, int p1)
	{
		n_onScrollOffsetChanged (p0, p1);
	}

	private native void n_onScrollOffsetChanged (int p0, int p1);

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
