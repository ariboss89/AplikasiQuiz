package mono.com.pdftron.pdf;


public class PDFViewCtrl_DocumentDownloadListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pdftron.pdf.PDFViewCtrl.DocumentDownloadListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDownloadEvent:(Lcom/pdftron/pdf/PDFViewCtrl$DownloadState;IIILjava/lang/String;)V:GetOnDownloadEvent_Lcom_pdftron_pdf_PDFViewCtrl_DownloadState_IIILjava_lang_String_Handler:pdftronprivate.PDF.PDFViewCtrl/IDocumentDownloadListenerInvoker, PDFNetAndroid\n" +
			"";
		mono.android.Runtime.register ("pdftronprivate.PDF.PDFViewCtrl+IDocumentDownloadListenerImplementor, PDFNetAndroid", PDFViewCtrl_DocumentDownloadListenerImplementor.class, __md_methods);
	}


	public PDFViewCtrl_DocumentDownloadListenerImplementor ()
	{
		super ();
		if (getClass () == PDFViewCtrl_DocumentDownloadListenerImplementor.class) {
			mono.android.TypeManager.Activate ("pdftronprivate.PDF.PDFViewCtrl+IDocumentDownloadListenerImplementor, PDFNetAndroid", "", this, new java.lang.Object[] {  });
		}
	}


	public void onDownloadEvent (com.pdftron.pdf.PDFViewCtrl.DownloadState p0, int p1, int p2, int p3, java.lang.String p4)
	{
		n_onDownloadEvent (p0, p1, p2, p3, p4);
	}

	private native void n_onDownloadEvent (com.pdftron.pdf.PDFViewCtrl.DownloadState p0, int p1, int p2, int p3, java.lang.String p4);

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
