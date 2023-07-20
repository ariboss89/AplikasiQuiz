package mono.com.pdftron.pdf;


public class PDFViewCtrl_UniversalDocumentConversionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pdftron.pdf.PDFViewCtrl.UniversalDocumentConversionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onConversionEvent:(Lcom/pdftron/pdf/PDFViewCtrl$ConversionState;I)V:GetOnConversionEvent_Lcom_pdftron_pdf_PDFViewCtrl_ConversionState_IHandler:pdftronprivate.PDF.PDFViewCtrl/IUniversalDocumentConversionListenerInvoker, PDFNetAndroid\n" +
			"";
		mono.android.Runtime.register ("pdftronprivate.PDF.PDFViewCtrl+IUniversalDocumentConversionListenerImplementor, PDFNetAndroid", PDFViewCtrl_UniversalDocumentConversionListenerImplementor.class, __md_methods);
	}


	public PDFViewCtrl_UniversalDocumentConversionListenerImplementor ()
	{
		super ();
		if (getClass () == PDFViewCtrl_UniversalDocumentConversionListenerImplementor.class) {
			mono.android.TypeManager.Activate ("pdftronprivate.PDF.PDFViewCtrl+IUniversalDocumentConversionListenerImplementor, PDFNetAndroid", "", this, new java.lang.Object[] {  });
		}
	}


	public void onConversionEvent (com.pdftron.pdf.PDFViewCtrl.ConversionState p0, int p1)
	{
		n_onConversionEvent (p0, p1);
	}

	private native void n_onConversionEvent (com.pdftron.pdf.PDFViewCtrl.ConversionState p0, int p1);

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
