package mono.com.pdftron.pdf;


public class PDFViewCtrl_UniversalDocumentProgressIndicatorListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pdftron.pdf.PDFViewCtrl.UniversalDocumentProgressIndicatorListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAddProgressIndicator:()V:GetOnAddProgressIndicatorHandler:pdftronprivate.PDF.PDFViewCtrl/IUniversalDocumentProgressIndicatorListenerInvoker, PDFNetAndroid\n" +
			"n_onPositionProgressIndicatorPage:(Lcom/pdftron/pdf/Rect;)V:GetOnPositionProgressIndicatorPage_Lcom_pdftron_pdf_Rect_Handler:pdftronprivate.PDF.PDFViewCtrl/IUniversalDocumentProgressIndicatorListenerInvoker, PDFNetAndroid\n" +
			"n_onProgressIndicatorPageVisibilityChanged:(Z)V:GetOnProgressIndicatorPageVisibilityChanged_ZHandler:pdftronprivate.PDF.PDFViewCtrl/IUniversalDocumentProgressIndicatorListenerInvoker, PDFNetAndroid\n" +
			"n_onRemoveContentPendingIndicator:()V:GetOnRemoveContentPendingIndicatorHandler:pdftronprivate.PDF.PDFViewCtrl/IUniversalDocumentProgressIndicatorListenerInvoker, PDFNetAndroid\n" +
			"n_onRemoveProgressIndicator:()V:GetOnRemoveProgressIndicatorHandler:pdftronprivate.PDF.PDFViewCtrl/IUniversalDocumentProgressIndicatorListenerInvoker, PDFNetAndroid\n" +
			"n_onShowContentPendingIndicator:()V:GetOnShowContentPendingIndicatorHandler:pdftronprivate.PDF.PDFViewCtrl/IUniversalDocumentProgressIndicatorListenerInvoker, PDFNetAndroid\n" +
			"";
		mono.android.Runtime.register ("pdftronprivate.PDF.PDFViewCtrl+IUniversalDocumentProgressIndicatorListenerImplementor, PDFNetAndroid", PDFViewCtrl_UniversalDocumentProgressIndicatorListenerImplementor.class, __md_methods);
	}


	public PDFViewCtrl_UniversalDocumentProgressIndicatorListenerImplementor ()
	{
		super ();
		if (getClass () == PDFViewCtrl_UniversalDocumentProgressIndicatorListenerImplementor.class) {
			mono.android.TypeManager.Activate ("pdftronprivate.PDF.PDFViewCtrl+IUniversalDocumentProgressIndicatorListenerImplementor, PDFNetAndroid", "", this, new java.lang.Object[] {  });
		}
	}


	public void onAddProgressIndicator ()
	{
		n_onAddProgressIndicator ();
	}

	private native void n_onAddProgressIndicator ();


	public void onPositionProgressIndicatorPage (com.pdftron.pdf.Rect p0)
	{
		n_onPositionProgressIndicatorPage (p0);
	}

	private native void n_onPositionProgressIndicatorPage (com.pdftron.pdf.Rect p0);


	public void onProgressIndicatorPageVisibilityChanged (boolean p0)
	{
		n_onProgressIndicatorPageVisibilityChanged (p0);
	}

	private native void n_onProgressIndicatorPageVisibilityChanged (boolean p0);


	public void onRemoveContentPendingIndicator ()
	{
		n_onRemoveContentPendingIndicator ();
	}

	private native void n_onRemoveContentPendingIndicator ();


	public void onRemoveProgressIndicator ()
	{
		n_onRemoveProgressIndicator ();
	}

	private native void n_onRemoveProgressIndicator ();


	public void onShowContentPendingIndicator ()
	{
		n_onShowContentPendingIndicator ();
	}

	private native void n_onShowContentPendingIndicator ();

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
