package mono.com.pdftron.pdf;


public class PDFViewCtrl_RenderingListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pdftron.pdf.PDFViewCtrl.RenderingListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRenderingFinished:()V:GetOnRenderingFinishedHandler:pdftronprivate.PDF.PDFViewCtrl/IRenderingListenerInvoker, PDFNetAndroid\n" +
			"n_onRenderingStarted:()V:GetOnRenderingStartedHandler:pdftronprivate.PDF.PDFViewCtrl/IRenderingListenerInvoker, PDFNetAndroid\n" +
			"";
		mono.android.Runtime.register ("pdftronprivate.PDF.PDFViewCtrl+IRenderingListenerImplementor, PDFNetAndroid", PDFViewCtrl_RenderingListenerImplementor.class, __md_methods);
	}


	public PDFViewCtrl_RenderingListenerImplementor ()
	{
		super ();
		if (getClass () == PDFViewCtrl_RenderingListenerImplementor.class) {
			mono.android.TypeManager.Activate ("pdftronprivate.PDF.PDFViewCtrl+IRenderingListenerImplementor, PDFNetAndroid", "", this, new java.lang.Object[] {  });
		}
	}


	public void onRenderingFinished ()
	{
		n_onRenderingFinished ();
	}

	private native void n_onRenderingFinished ();


	public void onRenderingStarted ()
	{
		n_onRenderingStarted ();
	}

	private native void n_onRenderingStarted ();

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
