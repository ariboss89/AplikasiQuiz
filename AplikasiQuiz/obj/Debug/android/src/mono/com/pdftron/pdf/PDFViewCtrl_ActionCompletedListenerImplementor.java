package mono.com.pdftron.pdf;


public class PDFViewCtrl_ActionCompletedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pdftron.pdf.PDFViewCtrl.ActionCompletedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onActionCompleted:(Lcom/pdftron/pdf/Action;)V:GetOnActionCompleted_Lcom_pdftron_pdf_Action_Handler:pdftronprivate.PDF.PDFViewCtrl/IActionCompletedListenerInvoker, PDFNetAndroid\n" +
			"";
		mono.android.Runtime.register ("pdftronprivate.PDF.PDFViewCtrl+IActionCompletedListenerImplementor, PDFNetAndroid", PDFViewCtrl_ActionCompletedListenerImplementor.class, __md_methods);
	}


	public PDFViewCtrl_ActionCompletedListenerImplementor ()
	{
		super ();
		if (getClass () == PDFViewCtrl_ActionCompletedListenerImplementor.class) {
			mono.android.TypeManager.Activate ("pdftronprivate.PDF.PDFViewCtrl+IActionCompletedListenerImplementor, PDFNetAndroid", "", this, new java.lang.Object[] {  });
		}
	}


	public void onActionCompleted (com.pdftron.pdf.Action p0)
	{
		n_onActionCompleted (p0);
	}

	private native void n_onActionCompleted (com.pdftron.pdf.Action p0);

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
