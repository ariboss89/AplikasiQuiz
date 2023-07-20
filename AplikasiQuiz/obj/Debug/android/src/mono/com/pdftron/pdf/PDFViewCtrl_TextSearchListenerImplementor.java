package mono.com.pdftron.pdf;


public class PDFViewCtrl_TextSearchListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pdftron.pdf.PDFViewCtrl.TextSearchListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTextSearchEnd:(Lcom/pdftron/pdf/PDFViewCtrl$TextSearchResult;)V:GetOnTextSearchEnd_Lcom_pdftron_pdf_PDFViewCtrl_TextSearchResult_Handler:pdftronprivate.PDF.PDFViewCtrl/ITextSearchListenerInvoker, PDFNetAndroid\n" +
			"n_onTextSearchProgress:(I)V:GetOnTextSearchProgress_IHandler:pdftronprivate.PDF.PDFViewCtrl/ITextSearchListenerInvoker, PDFNetAndroid\n" +
			"n_onTextSearchStart:()V:GetOnTextSearchStartHandler:pdftronprivate.PDF.PDFViewCtrl/ITextSearchListenerInvoker, PDFNetAndroid\n" +
			"";
		mono.android.Runtime.register ("pdftronprivate.PDF.PDFViewCtrl+ITextSearchListenerImplementor, PDFNetAndroid", PDFViewCtrl_TextSearchListenerImplementor.class, __md_methods);
	}


	public PDFViewCtrl_TextSearchListenerImplementor ()
	{
		super ();
		if (getClass () == PDFViewCtrl_TextSearchListenerImplementor.class) {
			mono.android.TypeManager.Activate ("pdftronprivate.PDF.PDFViewCtrl+ITextSearchListenerImplementor, PDFNetAndroid", "", this, new java.lang.Object[] {  });
		}
	}


	public void onTextSearchEnd (com.pdftron.pdf.PDFViewCtrl.TextSearchResult p0)
	{
		n_onTextSearchEnd (p0);
	}

	private native void n_onTextSearchEnd (com.pdftron.pdf.PDFViewCtrl.TextSearchResult p0);


	public void onTextSearchProgress (int p0)
	{
		n_onTextSearchProgress (p0);
	}

	private native void n_onTextSearchProgress (int p0);


	public void onTextSearchStart ()
	{
		n_onTextSearchStart ();
	}

	private native void n_onTextSearchStart ();

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
