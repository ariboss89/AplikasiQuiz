package crc6414b77c8866d6e602;


public class PDFViewCtrl
	extends com.pdftron.pdf.PDFViewCtrl
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_closeDoc:()V:GetCloseDocHandler\n" +
			"n_destroy:()V:GetDestroyHandler\n" +
			"";
		mono.android.Runtime.register ("pdftron.PDF.PDFViewCtrl, PDFNetAndroid", PDFViewCtrl.class, __md_methods);
	}


	public PDFViewCtrl (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == PDFViewCtrl.class) {
			mono.android.TypeManager.Activate ("pdftron.PDF.PDFViewCtrl, PDFNetAndroid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public PDFViewCtrl (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == PDFViewCtrl.class) {
			mono.android.TypeManager.Activate ("pdftron.PDF.PDFViewCtrl, PDFNetAndroid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public void closeDoc ()
	{
		n_closeDoc ();
	}

	private native void n_closeDoc ();


	public void destroy ()
	{
		n_destroy ();
	}

	private native void n_destroy ();

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
