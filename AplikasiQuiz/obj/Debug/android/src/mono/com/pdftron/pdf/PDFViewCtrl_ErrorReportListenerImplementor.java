package mono.com.pdftron.pdf;


public class PDFViewCtrl_ErrorReportListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pdftron.pdf.PDFViewCtrl.ErrorReportListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onErrorReportEvent:(Ljava/lang/String;)V:GetOnErrorReportEvent_Ljava_lang_String_Handler:pdftronprivate.PDF.PDFViewCtrl/IErrorReportListenerInvoker, PDFNetAndroid\n" +
			"";
		mono.android.Runtime.register ("pdftronprivate.PDF.PDFViewCtrl+IErrorReportListenerImplementor, PDFNetAndroid", PDFViewCtrl_ErrorReportListenerImplementor.class, __md_methods);
	}


	public PDFViewCtrl_ErrorReportListenerImplementor ()
	{
		super ();
		if (getClass () == PDFViewCtrl_ErrorReportListenerImplementor.class) {
			mono.android.TypeManager.Activate ("pdftronprivate.PDF.PDFViewCtrl+IErrorReportListenerImplementor, PDFNetAndroid", "", this, new java.lang.Object[] {  });
		}
	}


	public void onErrorReportEvent (java.lang.String p0)
	{
		n_onErrorReportEvent (p0);
	}

	private native void n_onErrorReportEvent (java.lang.String p0);

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
