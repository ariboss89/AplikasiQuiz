package mono.com.pdftron.pdf;


public class PDFViewCtrl_ThumbAsyncListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pdftron.pdf.PDFViewCtrl.ThumbAsyncListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onThumbReceived:(I[III)V:GetOnThumbReceived_IarrayIIIHandler:pdftronprivate.PDF.PDFViewCtrl/IThumbAsyncListenerInvoker, PDFNetAndroid\n" +
			"";
		mono.android.Runtime.register ("pdftronprivate.PDF.PDFViewCtrl+IThumbAsyncListenerImplementor, PDFNetAndroid", PDFViewCtrl_ThumbAsyncListenerImplementor.class, __md_methods);
	}


	public PDFViewCtrl_ThumbAsyncListenerImplementor ()
	{
		super ();
		if (getClass () == PDFViewCtrl_ThumbAsyncListenerImplementor.class) {
			mono.android.TypeManager.Activate ("pdftronprivate.PDF.PDFViewCtrl+IThumbAsyncListenerImplementor, PDFNetAndroid", "", this, new java.lang.Object[] {  });
		}
	}


	public void onThumbReceived (int p0, int[] p1, int p2, int p3)
	{
		n_onThumbReceived (p0, p1, p2, p3);
	}

	private native void n_onThumbReceived (int p0, int[] p1, int p2, int p3);

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
