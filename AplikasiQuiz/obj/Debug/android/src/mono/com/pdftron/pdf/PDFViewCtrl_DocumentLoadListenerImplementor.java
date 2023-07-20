package mono.com.pdftron.pdf;


public class PDFViewCtrl_DocumentLoadListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pdftron.pdf.PDFViewCtrl.DocumentLoadListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDocumentLoaded:()V:GetOnDocumentLoadedHandler:pdftronprivate.PDF.PDFViewCtrl/IDocumentLoadListenerInvoker, PDFNetAndroid\n" +
			"";
		mono.android.Runtime.register ("pdftronprivate.PDF.PDFViewCtrl+IDocumentLoadListenerImplementor, PDFNetAndroid", PDFViewCtrl_DocumentLoadListenerImplementor.class, __md_methods);
	}


	public PDFViewCtrl_DocumentLoadListenerImplementor ()
	{
		super ();
		if (getClass () == PDFViewCtrl_DocumentLoadListenerImplementor.class) {
			mono.android.TypeManager.Activate ("pdftronprivate.PDF.PDFViewCtrl+IDocumentLoadListenerImplementor, PDFNetAndroid", "", this, new java.lang.Object[] {  });
		}
	}


	public void onDocumentLoaded ()
	{
		n_onDocumentLoaded ();
	}

	private native void n_onDocumentLoaded ();

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
