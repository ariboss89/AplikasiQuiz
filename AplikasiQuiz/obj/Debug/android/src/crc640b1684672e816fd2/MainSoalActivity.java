package crc640b1684672e816fd2;


public class MainSoalActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("AplikasiQuiz.Activities.MainSoalActivity, AplikasiQuiz", MainSoalActivity.class, __md_methods);
	}


	public MainSoalActivity ()
	{
		super ();
		if (getClass () == MainSoalActivity.class) {
			mono.android.TypeManager.Activate ("AplikasiQuiz.Activities.MainSoalActivity, AplikasiQuiz", "", this, new java.lang.Object[] {  });
		}
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
