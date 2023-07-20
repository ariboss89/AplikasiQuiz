package crc640b1684672e816fd2;


public class DownloadActivity
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer,
		android.webkit.DownloadListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onBackPressed:()V:GetOnBackPressedHandler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"n_onDownloadStart:(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V:GetOnDownloadStart_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler:Android.Webkit.IDownloadListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("AplikasiQuiz.Activities.DownloadActivity, AplikasiQuiz", DownloadActivity.class, __md_methods);
	}


	public DownloadActivity ()
	{
		super ();
		if (getClass () == DownloadActivity.class) {
			mono.android.TypeManager.Activate ("AplikasiQuiz.Activities.DownloadActivity, AplikasiQuiz", "", this, new java.lang.Object[] {  });
		}
	}


	public DownloadActivity (int p0)
	{
		super (p0);
		if (getClass () == DownloadActivity.class) {
			mono.android.TypeManager.Activate ("AplikasiQuiz.Activities.DownloadActivity, AplikasiQuiz", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onBackPressed ()
	{
		n_onBackPressed ();
	}

	private native void n_onBackPressed ();


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();


	public void onDownloadStart (java.lang.String p0, java.lang.String p1, java.lang.String p2, java.lang.String p3, long p4)
	{
		n_onDownloadStart (p0, p1, p2, p3, p4);
	}

	private native void n_onDownloadStart (java.lang.String p0, java.lang.String p1, java.lang.String p2, java.lang.String p3, long p4);

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
