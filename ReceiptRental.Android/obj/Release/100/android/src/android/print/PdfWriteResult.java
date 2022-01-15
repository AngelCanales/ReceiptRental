package android.print;


public class PdfWriteResult
	extends android.print.PrintDocumentAdapter.WriteResultCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onWriteFinished:([Landroid/print/PageRange;)V:GetOnWriteFinished_arrayLandroid_print_PageRange_Handler\n" +
			"n_onWriteCancelled:()V:GetOnWriteCancelledHandler\n" +
			"n_onWriteFailed:(Ljava/lang/CharSequence;)V:GetOnWriteFailed_Ljava_lang_CharSequence_Handler\n" +
			"";
		mono.android.Runtime.register ("ReceiptRental.Droid.DependencyService.PdfWriteResultCallback, ReceiptRental.Android", PdfWriteResult.class, __md_methods);
	}


	public void onWriteFinished (android.print.PageRange[] p0)
	{
		n_onWriteFinished (p0);
	}

	private native void n_onWriteFinished (android.print.PageRange[] p0);


	public void onWriteCancelled ()
	{
		n_onWriteCancelled ();
	}

	private native void n_onWriteCancelled ();


	public void onWriteFailed (java.lang.CharSequence p0)
	{
		n_onWriteFailed (p0);
	}

	private native void n_onWriteFailed (java.lang.CharSequence p0);

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
