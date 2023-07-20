package crc6414b77c8866d6e602;


public class Print
	extends com.pdftron.pdf.Print
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("pdftron.PDF.Print, PDFNetAndroid", Print.class, __md_methods);
	}


	public Print ()
	{
		super ();
		if (getClass () == Print.class) {
			mono.android.TypeManager.Activate ("pdftron.PDF.Print, PDFNetAndroid", "", this, new java.lang.Object[] {  });
		}
	}

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
