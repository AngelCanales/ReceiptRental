package android.print;


public class PdfLayoutResultCallback
	extends android.print.PrintDocumentAdapter.LayoutResultCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLayoutFinished:(Landroid/print/PrintDocumentInfo;Z)V:GetOnLayoutFinished_Landroid_print_PrintDocumentInfo_ZHandler\n" +
			"n_onLayoutCancelled:()V:GetOnLayoutCancelledHandler\n" +
			"n_onLayoutFailed:(Ljava/lang/CharSequence;)V:GetOnLayoutFailed_Ljava_lang_CharSequence_Handler\n" +
			"";
		mono.android.Runtime.register ("ReceiptRental.Droid.DependencyService.PdfLayoutResultCallback, ReceiptRental.Android", PdfLayoutResultCallback.class, __md_methods);
	}


	public void onLayoutFinished (android.print.PrintDocumentInfo p0, boolean p1)
	{
		n_onLayoutFinished (p0, p1);
	}

	private native void n_onLayoutFinished (android.print.PrintDocumentInfo p0, boolean p1);


	public void onLayoutCancelled ()
	{
		n_onLayoutCancelled ();
	}

	private native void n_onLayoutCancelled ();


	public void onLayoutFailed (java.lang.CharSequence p0)
	{
		n_onLayoutFailed (p0);
	}

	private native void n_onLayoutFailed (java.lang.CharSequence p0);

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
