package crc6468da811518fe3e30;


public class WebViewCallBack
	extends android.webkit.WebViewClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPageFinished:(Landroid/webkit/WebView;Ljava/lang/String;)V:GetOnPageFinished_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("ReceiptRental.Droid.DependencyService.WebViewCallBack, ReceiptRental.Android", WebViewCallBack.class, __md_methods);
	}


	public WebViewCallBack ()
	{
		super ();
		if (getClass () == WebViewCallBack.class)
			mono.android.TypeManager.Activate ("ReceiptRental.Droid.DependencyService.WebViewCallBack, ReceiptRental.Android", "", this, new java.lang.Object[] {  });
	}

	public WebViewCallBack (java.lang.String p0)
	{
		super ();
		if (getClass () == WebViewCallBack.class)
			mono.android.TypeManager.Activate ("ReceiptRental.Droid.DependencyService.WebViewCallBack, ReceiptRental.Android", "System.String, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onPageFinished (android.webkit.WebView p0, java.lang.String p1)
	{
		n_onPageFinished (p0, p1);
	}

	private native void n_onPageFinished (android.webkit.WebView p0, java.lang.String p1);

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
