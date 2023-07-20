package mono.com.pdftron.pdf;


public class PDFViewCtrl_PageChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pdftron.pdf.PDFViewCtrl.PageChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPageChange:(IILcom/pdftron/pdf/PDFViewCtrl$PageChangeState;)V:GetOnPageChange_IILcom_pdftron_pdf_PDFViewCtrl_PageChangeState_Handler:pdftronprivate.PDF.PDFViewCtrl/IPageChangeListenerInvoker, PDFNetAndroid\n" +
			"";
		mono.android.Runtime.register ("pdftronprivate.PDF.PDFViewCtrl+IPageChangeListenerImplementor, PDFNetAndroid", PDFViewCtrl_PageChangeListenerImplementor.class, __md_methods);
	}


	public PDFViewCtrl_PageChangeListenerImplementor ()
	{
		super ();
		if (getClass () == PDFViewCtrl_PageChangeListenerImplementor.class) {
			mono.android.TypeManager.Activate ("pdftronprivate.PDF.PDFViewCtrl+IPageChangeListenerImplementor, PDFNetAndroid", "", this, new java.lang.Object[] {  });
		}
	}


	public void onPageChange (int p0, int p1, com.pdftron.pdf.PDFViewCtrl.PageChangeState p2)
	{
		n_onPageChange (p0, p1, p2);
	}

	private native void n_onPageChange (int p0, int p1, com.pdftron.pdf.PDFViewCtrl.PageChangeState p2);

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
